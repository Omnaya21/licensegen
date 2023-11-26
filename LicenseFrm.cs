using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Standard.Licensing;
using Standard.Licensing.Security.Cryptography;
using Standard.Licensing.Validation;

using Hardware.Info;
using System.IO;

namespace LicenseGenerator
{
    public partial class LicenseFrm : MaterialForm
    {
        readonly MaterialSkinManager themeManager = MaterialSkinManager.Instance;
        public LicenseFrm()
        {
            InitializeComponent();

            themeManager.EnforceBackcolorOnAllComponents = true;
            themeManager.AddFormToManage(this);
        }

        private string GetHDDSerial()
        {   
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject obj in searcher.Get()) 
            {
                // Get the harddrive serial number
                if (!string.IsNullOrEmpty(obj["SerialNumber"].ToString()))                    
                    return obj["SerialNumber"].ToString().Trim(); 
            }
            /*
            /// Get info about serial numbers
            /// 
            IHardwareInfo hardwareInfo = new HardwareInfo();

            hardwareInfo.RefreshDriveList();
            foreach (var drive in hardwareInfo.DriveList)
            {
                return drive.SerialNumber;
            }
            */
            return string.Empty;
        }

        private void GenerateKeyPair_Click(object sender, EventArgs e)
        {
            /// Antes de generar la licencia hay que verificar que tengamos el PassPhrase
            /// 
            if (txtPassPhrase.Text.Length == 0)
            {
                txtPassPhrase.SelectAll();
                return;
            }

            /// Si ya generamos las llaves, ya no volvemos a hacerlo
            /// 
            if (txtPrivateKey.Text.Length > 0 || txtPublicKey.Text.Length > 0)
            {
                MaterialDialog dialog = new MaterialDialog(this, "Nuevas llaves", "Desea generar las llaves nuevamente?", "Generar", true, "Cancelar");
                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;
            }

            KeyGenerator keyGenerator = KeyGenerator.Create();
            KeyPair keyPair = keyGenerator.GenerateKeyPair();
            string passPhrase = txtPassPhrase.Text;
            string privateKey = keyPair.ToEncryptedPrivateKeyString(passPhrase);
            string publicKey = keyPair.ToPublicKeyString();

            txtPrivateKey.Text = privateKey;
            txtPublicKey.Text = publicKey;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDeviceIdentifier.Text = Environment.MachineName + "-" + GetHDDSerial();  

            string encodedIdentifier = Base64UrlEncoder.Encode(txtDeviceIdentifier.Text);

            /// Debemos verificar si ya se generaron las claves privada y publica. Solamente se deben de generar 
            /// una sola vez y guardarla como archivos en el mismo folder y ya no volver a generarlas para no 
            /// perder la continuidad la llave publica se debera enviar junto con el sofware para poder validar 
            /// la licencia
            /// 
            if (File.Exists("phr.key"))
            {
                txtPassPhrase.Text = File.ReadAllText("phr.key");
            }
            if (File.Exists("prk.key"))
            {
                txtPrivateKey.Text = File.ReadAllText("prk.key");
            }
            if (File.Exists("puk.key"))
            {
                txtPublicKey.Text = File.ReadAllText("puk.key");
            }
        }

        private void GenerateLicense_Click(object sender, EventArgs e)
        {
            DateTime expiryDate = dateExpiration.Value.AddDays(30); //DateTime.UtcNow.Date.AddDays(30);
            string deviceIdentifier = txtDeviceIdentifier.Text;
            string customerName = txtCustomerName.Text;

            /// Validar que tengamos todos los datos necesarios para generar la licencia
            /// antes de generarla
            /// 

            try
            {
                Standard.Licensing.License newLicense = Standard.Licensing.License.New()
                    .WithUniqueIdentifier(Guid.NewGuid())
                    .ExpiresAt(swchNoExpirationDate.Checked ? DateTime.Now.AddYears(30) : expiryDate)
                    .WithAdditionalAttributes(new Dictionary<string, string>
                    {
                    { "DeviceIdentifier", deviceIdentifier }
                    })
                    .LicensedTo((c) => c.Name = customerName)
                    .CreateAndSignWithPrivateKey(txtPrivateKey.Text, txtPassPhrase.Text);

                string licenseXml = newLicense.ToString();
                rtLicenseXml.Text = licenseXml;

                string licenseKey = Base64UrlEncoder.Encode(licenseXml);
                txtLicenseKey.Text = Encryption.Encrypt(licenseKey);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar la licencia. " + ex.Message);
            }
        }

        private void TestLicense_Click(object sender, EventArgs e)
        {
            string currentDeviceIdentifier = Environment.MachineName + "-" + GetHDDSerial();
            try
            {
                Standard.Licensing.License license = Standard.Licensing.License.Load(Base64UrlEncoder.Decode(Encryption.Decrypt(txtLicenseKey.Text)));

                var validationFailures =
                license.Validate()
                        .ExpirationDate()
                        .And()
                        .Signature(txtPublicKey.Text)
                        .And()
                        .AssertThat(lic => // Check Device Identifier matches.
                            lic.AdditionalAttributes.Get("DeviceIdentifier") == currentDeviceIdentifier,
                            new GeneralValidationFailure()
                            {
                                Message = "Invalid Device.",
                                HowToResolve = "Contact the supplier to obtain a new license key."
                            })
                        .AssertValidLicense();

                if (validationFailures.Any())
                {
                    throw new UnauthorizedAccessException(validationFailures.First().Message);
                }
                else
                {
                    MaterialDialog message = new MaterialDialog(this, "Licencia válida!");
                    message.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                //throw new Exception("Licence Key invalid");                
                MaterialDialog message = new MaterialDialog(this, "License Key Invalid!", ex.Message);
                message.ShowDialog(this);
            }            
        }

        private void NoExpirationDate_CheckedChanged(object sender, EventArgs e)
        {
            lblExpire.Visible = dateExpiration.Visible = !swchNoExpirationDate.Checked;
        }

        private void btnSaveKeys_Click(object sender, EventArgs e)
        {
            /// Hay que verificar que haya algo que guardar antes
            /// 
            if (txtPrivateKey.Text.Length > 0 && txtPublicKey.Text.Length > 0)
            {
                /// Si ya existe el archivo ya no generamos otro y al abrir la aplicacion cargamos las llaves
                /// 
                if (File.Exists("prk.key") || File.Exists("puk.key"))
                {
                    MaterialDialog dialog = new MaterialDialog(this, "Sobreescribir", "Desea sobreescribir las llaves existentes?", "Sobreescribir", true, "Cancelar");
                    if (dialog.ShowDialog(this) != DialogResult.OK)
                        return;
                }
                File.WriteAllText("phr.key", txtPassPhrase.Text);
                File.WriteAllText("prk.key", txtPrivateKey.Text);
                File.WriteAllText("puk.key", txtPublicKey.Text);
            }
        }

        private void btnSaveLicense_Click(object sender, EventArgs e)
        {
            FileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Licencia|*.key";
            if (saveDialog.ShowDialog() == DialogResult.OK) 
            { 
                /// Save file
                /// 
                File.WriteAllText(saveDialog.FileName, txtLicenseKey.Text);
            }
        }

        private void btnLoadLicense_Click(object sender, EventArgs e)
        {
            FileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Licencia|*.key";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtLicenseKey.Text = File.ReadAllText(openFile.FileName);
            }
        }
    }

    /// <summary>
    /// Encodes and Decodes strings using Base64 URL encoding.
    /// </summary>
    public static class Base64UrlEncoder
    {
        #region Constants

        private const char Base64Character62 = '+';
        private const char Base64Character63 = '/';
        private const string Base64DoublePadCharacter = "==";
        private const char Base64PadCharacter = '=';
        private const char Base64UrlCharacter62 = '-';
        private const char Base64UrlCharacter63 = '_';

        #endregion

        #region Methods

        /// <summary>
        /// Converts the specified Base64 URL encoded string to a UTF8 string.
        /// </summary>
        /// <param name="s">The Base64 URL encoded string to convert</param>
        /// <returns>A UTF8 string</returns>
        public static string Decode(string s)
        {
            return Encoding.UTF8.GetString(DecodeBytes(s));
        }

        /// <summary>
        /// Converts the specified Base64 URL encoded string to a byte array.</summary>
        /// <param name="s">The Base64 URL encoded string to convert</param>
        /// <returns>A byte array</returns>
        public static byte[] DecodeBytes(string s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));

            // Replace - with +
            s = s.Replace(Base64UrlCharacter62, Base64Character62);

            // Replace _ with /
            s = s.Replace(Base64UrlCharacter63, Base64Character63);

            // Check padding.
            switch (s.Length % 4)
            {
                case 0: // No pad characters.
                    break;
                case 2: // Two pad characters.
                    s += Base64DoublePadCharacter;
                    break;
                case 3: // One pad character.
                    s += Base64PadCharacter;
                    break;
                default:
                    throw new FormatException("Invalid Base64 URL encoding.");
            }

            return Convert.FromBase64String(s);
        }

        /// <summary>
        /// Converts the specified UTF8 string into a Base64 URL encoded string.
        /// </summary>
        /// <param name="s">The UTF8 string to convert</param>
        /// <returns>A Base64 URL encoded string</returns>
        public static string Encode(string s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));

            return Encode(Encoding.UTF8.GetBytes(s));
        }

        /// <summary>
        /// Converts the specified byte array to a Base64 URL encoded string.
        /// </summary>
        /// <param name="bytes">The byte array to convert</param>
        /// <returns>A Base64 URL encoded string</returns>
        public static string Encode(byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            string s = Convert.ToBase64String(bytes, 0, bytes.Length);
            s = s.Split(Base64PadCharacter)[0];                     // Remove trailing padding i.e. = or ==
            s = s.Replace(Base64Character62, Base64UrlCharacter62); // Replace + with -
            s = s.Replace(Base64Character63, Base64UrlCharacter63); // Replace / with _

            return s;
        }

        /// <summary>
        /// Converts the specified byte array to a Base64 URL encoded string.
        /// </summary>
        /// <param name="bytes">The byte array to convert</param>
        /// <param name="offset">The byte array offset</param>
        /// <param name="length">The number of elements in the byte array to convert</param>
        /// <returns>A Base64 URL encoded string</returns>
        public static string Encode(byte[] bytes, int offset, int length)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            string s = Convert.ToBase64String(bytes, offset, length);
            s = s.Split(Base64PadCharacter)[0];                     // Remove trailing padding i.e. = or ==
            s = s.Replace(Base64Character62, Base64UrlCharacter62); // Replace + with -
            s = s.Replace(Base64Character63, Base64UrlCharacter63); // Replace / with _

            return s;
        }

        #endregion
    }
}
