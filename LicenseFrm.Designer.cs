namespace LicenseGenerator
{
    partial class LicenseFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseFrm));
            this.dateExpiration = new System.Windows.Forms.DateTimePicker();
            this.lblExpire = new MaterialSkin.Controls.MaterialLabel();
            this.swchNoExpirationDate = new MaterialSkin.Controls.MaterialSwitch();
            this.txtDeviceIdentifier = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCustomerName = new MaterialSkin.Controls.MaterialTextBox2();
            this.rtLicenseXml = new System.Windows.Forms.RichTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGenerateKeyPair = new MaterialSkin.Controls.MaterialButton();
            this.btnGenerateLicense = new MaterialSkin.Controls.MaterialButton();
            this.txtPublicKey = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPassPhrase = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPrivateKey = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.txtLicenseKey = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnSaveLicense = new MaterialSkin.Controls.MaterialButton();
            this.btnTestLicense = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveKeys = new MaterialSkin.Controls.MaterialButton();
            this.btnLoadLicense = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateExpiration
            // 
            this.dateExpiration.Location = new System.Drawing.Point(279, 130);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(264, 20);
            this.dateExpiration.TabIndex = 0;
            // 
            // lblExpire
            // 
            this.lblExpire.AutoSize = true;
            this.lblExpire.Depth = 0;
            this.lblExpire.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblExpire.Location = new System.Drawing.Point(228, 130);
            this.lblExpire.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(45, 19);
            this.lblExpire.TabIndex = 1;
            this.lblExpire.Text = "Expira";
            // 
            // swchNoExpirationDate
            // 
            this.swchNoExpirationDate.AutoSize = true;
            this.swchNoExpirationDate.Depth = 0;
            this.swchNoExpirationDate.Location = new System.Drawing.Point(28, 122);
            this.swchNoExpirationDate.Margin = new System.Windows.Forms.Padding(0);
            this.swchNoExpirationDate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swchNoExpirationDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.swchNoExpirationDate.Name = "swchNoExpirationDate";
            this.swchNoExpirationDate.Ripple = true;
            this.swchNoExpirationDate.Size = new System.Drawing.Size(129, 37);
            this.swchNoExpirationDate.TabIndex = 2;
            this.swchNoExpirationDate.Text = "Indefinida";
            this.swchNoExpirationDate.UseVisualStyleBackColor = true;
            this.swchNoExpirationDate.CheckedChanged += new System.EventHandler(this.NoExpirationDate_CheckedChanged);
            // 
            // txtDeviceIdentifier
            // 
            this.txtDeviceIdentifier.AnimateReadOnly = false;
            this.txtDeviceIdentifier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDeviceIdentifier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDeviceIdentifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDeviceIdentifier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDeviceIdentifier.Depth = 0;
            this.txtDeviceIdentifier.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeviceIdentifier.HideSelection = true;
            this.txtDeviceIdentifier.Hint = "Código de Producto / Product Code";
            this.txtDeviceIdentifier.LeadingIcon = null;
            this.txtDeviceIdentifier.Location = new System.Drawing.Point(28, 17);
            this.txtDeviceIdentifier.MaxLength = 32767;
            this.txtDeviceIdentifier.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDeviceIdentifier.Name = "txtDeviceIdentifier";
            this.txtDeviceIdentifier.PasswordChar = '\0';
            this.txtDeviceIdentifier.PrefixSuffixText = null;
            this.txtDeviceIdentifier.ReadOnly = false;
            this.txtDeviceIdentifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDeviceIdentifier.SelectedText = "";
            this.txtDeviceIdentifier.SelectionLength = 0;
            this.txtDeviceIdentifier.SelectionStart = 0;
            this.txtDeviceIdentifier.ShortcutsEnabled = true;
            this.txtDeviceIdentifier.Size = new System.Drawing.Size(515, 48);
            this.txtDeviceIdentifier.TabIndex = 3;
            this.txtDeviceIdentifier.TabStop = false;
            this.txtDeviceIdentifier.Text = "DELL-ON";
            this.txtDeviceIdentifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeviceIdentifier.TrailingIcon = null;
            this.txtDeviceIdentifier.UseSystemPasswordChar = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AnimateReadOnly = false;
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCustomerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCustomerName.Depth = 0;
            this.txtCustomerName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerName.HideSelection = true;
            this.txtCustomerName.Hint = "Cliente/Customer";
            this.txtCustomerName.LeadingIcon = null;
            this.txtCustomerName.Location = new System.Drawing.Point(28, 71);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PrefixSuffixText = null;
            this.txtCustomerName.ReadOnly = false;
            this.txtCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(515, 48);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TabStop = false;
            this.txtCustomerName.Text = "Ingenieria y Software";
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerName.TrailingIcon = null;
            this.txtCustomerName.UseSystemPasswordChar = false;
            // 
            // rtLicenseXml
            // 
            this.rtLicenseXml.Location = new System.Drawing.Point(17, 36);
            this.rtLicenseXml.Name = "rtLicenseXml";
            this.rtLicenseXml.ReadOnly = true;
            this.rtLicenseXml.Size = new System.Drawing.Size(481, 96);
            this.rtLicenseXml.TabIndex = 5;
            this.rtLicenseXml.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(97, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Licencia XML";
            // 
            // btnGenerateKeyPair
            // 
            this.btnGenerateKeyPair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerateKeyPair.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerateKeyPair.Depth = 0;
            this.btnGenerateKeyPair.HighEmphasis = true;
            this.btnGenerateKeyPair.Icon = null;
            this.btnGenerateKeyPair.Location = new System.Drawing.Point(606, 78);
            this.btnGenerateKeyPair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerateKeyPair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerateKeyPair.Name = "btnGenerateKeyPair";
            this.btnGenerateKeyPair.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerateKeyPair.Size = new System.Drawing.Size(143, 36);
            this.btnGenerateKeyPair.TabIndex = 7;
            this.btnGenerateKeyPair.Text = "Generar Llaves";
            this.btnGenerateKeyPair.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerateKeyPair.UseAccentColor = false;
            this.btnGenerateKeyPair.UseVisualStyleBackColor = true;
            this.btnGenerateKeyPair.Click += new System.EventHandler(this.GenerateKeyPair_Click);
            // 
            // btnGenerateLicense
            // 
            this.btnGenerateLicense.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerateLicense.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerateLicense.Depth = 0;
            this.btnGenerateLicense.HighEmphasis = true;
            this.btnGenerateLicense.Icon = null;
            this.btnGenerateLicense.Location = new System.Drawing.Point(606, 328);
            this.btnGenerateLicense.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerateLicense.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerateLicense.Name = "btnGenerateLicense";
            this.btnGenerateLicense.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerateLicense.Size = new System.Drawing.Size(155, 36);
            this.btnGenerateLicense.TabIndex = 7;
            this.btnGenerateLicense.Text = "Generar Licencia";
            this.btnGenerateLicense.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerateLicense.UseAccentColor = false;
            this.btnGenerateLicense.UseVisualStyleBackColor = true;
            this.btnGenerateLicense.Click += new System.EventHandler(this.GenerateLicense_Click);
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.AnimateReadOnly = false;
            this.txtPublicKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPublicKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPublicKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPublicKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPublicKey.Depth = 0;
            this.txtPublicKey.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPublicKey.HideSelection = true;
            this.txtPublicKey.Hint = "Public Key";
            this.txtPublicKey.LeadingIcon = null;
            this.txtPublicKey.Location = new System.Drawing.Point(28, 153);
            this.txtPublicKey.MaxLength = 32767;
            this.txtPublicKey.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.PasswordChar = '\0';
            this.txtPublicKey.PrefixSuffixText = null;
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPublicKey.SelectedText = "";
            this.txtPublicKey.SelectionLength = 0;
            this.txtPublicKey.SelectionStart = 0;
            this.txtPublicKey.ShortcutsEnabled = true;
            this.txtPublicKey.Size = new System.Drawing.Size(515, 48);
            this.txtPublicKey.TabIndex = 8;
            this.txtPublicKey.TabStop = false;
            this.txtPublicKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPublicKey.TrailingIcon = null;
            this.txtPublicKey.UseSystemPasswordChar = false;
            // 
            // txtPassPhrase
            // 
            this.txtPassPhrase.AnimateReadOnly = false;
            this.txtPassPhrase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassPhrase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassPhrase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassPhrase.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassPhrase.Depth = 0;
            this.txtPassPhrase.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassPhrase.HideSelection = true;
            this.txtPassPhrase.Hint = "Pass Phrase";
            this.txtPassPhrase.LeadingIcon = null;
            this.txtPassPhrase.Location = new System.Drawing.Point(28, 45);
            this.txtPassPhrase.MaxLength = 32767;
            this.txtPassPhrase.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassPhrase.Name = "txtPassPhrase";
            this.txtPassPhrase.PasswordChar = '\0';
            this.txtPassPhrase.PrefixSuffixText = null;
            this.txtPassPhrase.ReadOnly = false;
            this.txtPassPhrase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassPhrase.SelectedText = "";
            this.txtPassPhrase.SelectionLength = 0;
            this.txtPassPhrase.SelectionStart = 0;
            this.txtPassPhrase.ShortcutsEnabled = true;
            this.txtPassPhrase.Size = new System.Drawing.Size(515, 48);
            this.txtPassPhrase.TabIndex = 8;
            this.txtPassPhrase.TabStop = false;
            this.txtPassPhrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassPhrase.TrailingIcon = null;
            this.txtPassPhrase.UseSystemPasswordChar = false;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.AnimateReadOnly = false;
            this.txtPrivateKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrivateKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrivateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrivateKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrivateKey.Depth = 0;
            this.txtPrivateKey.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrivateKey.HideSelection = true;
            this.txtPrivateKey.Hint = "Private Key";
            this.txtPrivateKey.LeadingIcon = null;
            this.txtPrivateKey.Location = new System.Drawing.Point(28, 99);
            this.txtPrivateKey.MaxLength = 32767;
            this.txtPrivateKey.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.PasswordChar = '\0';
            this.txtPrivateKey.PrefixSuffixText = null;
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrivateKey.SelectedText = "";
            this.txtPrivateKey.SelectionLength = 0;
            this.txtPrivateKey.SelectionStart = 0;
            this.txtPrivateKey.ShortcutsEnabled = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(515, 48);
            this.txtPrivateKey.TabIndex = 8;
            this.txtPrivateKey.TabStop = false;
            this.txtPrivateKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrivateKey.TrailingIcon = null;
            this.txtPrivateKey.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.txtPassPhrase);
            this.materialCard1.Controls.Add(this.txtPrivateKey);
            this.materialCard1.Controls.Add(this.txtPublicKey);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(571, 222);
            this.materialCard1.TabIndex = 9;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(233, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Generar Llaves Publica y Privada";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialCard3);
            this.materialCard2.Controls.Add(this.lblExpire);
            this.materialCard2.Controls.Add(this.dateExpiration);
            this.materialCard2.Controls.Add(this.swchNoExpirationDate);
            this.materialCard2.Controls.Add(this.txtDeviceIdentifier);
            this.materialCard2.Controls.Add(this.txtCustomerName);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 328);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(571, 470);
            this.materialCard2.TabIndex = 10;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.txtLicenseKey);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.rtLicenseXml);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(28, 173);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(515, 285);
            this.materialCard3.TabIndex = 7;
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.AnimateReadOnly = false;
            this.txtLicenseKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLicenseKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLicenseKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseKey.Depth = 0;
            this.txtLicenseKey.HideSelection = true;
            this.txtLicenseKey.Hint = "Licence Key";
            this.txtLicenseKey.Location = new System.Drawing.Point(17, 138);
            this.txtLicenseKey.MaxLength = 32767;
            this.txtLicenseKey.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.PasswordChar = '\0';
            this.txtLicenseKey.ReadOnly = true;
            this.txtLicenseKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLicenseKey.SelectedText = "";
            this.txtLicenseKey.SelectionLength = 0;
            this.txtLicenseKey.SelectionStart = 0;
            this.txtLicenseKey.ShortcutsEnabled = true;
            this.txtLicenseKey.Size = new System.Drawing.Size(481, 130);
            this.txtLicenseKey.TabIndex = 12;
            this.txtLicenseKey.TabStop = false;
            this.txtLicenseKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLicenseKey.UseSystemPasswordChar = false;
            // 
            // btnSaveLicense
            // 
            this.btnSaveLicense.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveLicense.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveLicense.Depth = 0;
            this.btnSaveLicense.HighEmphasis = true;
            this.btnSaveLicense.Icon = null;
            this.btnSaveLicense.Location = new System.Drawing.Point(606, 376);
            this.btnSaveLicense.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveLicense.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveLicense.Name = "btnSaveLicense";
            this.btnSaveLicense.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveLicense.Size = new System.Drawing.Size(157, 36);
            this.btnSaveLicense.TabIndex = 11;
            this.btnSaveLicense.Text = "Guardar Licencia";
            this.btnSaveLicense.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSaveLicense.UseAccentColor = false;
            this.btnSaveLicense.UseVisualStyleBackColor = true;
            this.btnSaveLicense.Click += new System.EventHandler(this.btnSaveLicense_Click);
            // 
            // btnTestLicense
            // 
            this.btnTestLicense.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTestLicense.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTestLicense.Depth = 0;
            this.btnTestLicense.HighEmphasis = true;
            this.btnTestLicense.Icon = null;
            this.btnTestLicense.Location = new System.Drawing.Point(606, 762);
            this.btnTestLicense.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTestLicense.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestLicense.Name = "btnTestLicense";
            this.btnTestLicense.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTestLicense.Size = new System.Drawing.Size(146, 36);
            this.btnTestLicense.TabIndex = 11;
            this.btnTestLicense.Text = "Probar Licencia";
            this.btnTestLicense.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnTestLicense.UseAccentColor = false;
            this.btnTestLicense.UseVisualStyleBackColor = true;
            this.btnTestLicense.Click += new System.EventHandler(this.TestLicense_Click);
            // 
            // btnSaveKeys
            // 
            this.btnSaveKeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveKeys.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveKeys.Depth = 0;
            this.btnSaveKeys.HighEmphasis = true;
            this.btnSaveKeys.Icon = null;
            this.btnSaveKeys.Location = new System.Drawing.Point(604, 126);
            this.btnSaveKeys.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveKeys.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveKeys.Name = "btnSaveKeys";
            this.btnSaveKeys.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveKeys.Size = new System.Drawing.Size(145, 36);
            this.btnSaveKeys.TabIndex = 11;
            this.btnSaveKeys.Text = "Guardar Llaves";
            this.btnSaveKeys.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSaveKeys.UseAccentColor = false;
            this.btnSaveKeys.UseVisualStyleBackColor = true;
            this.btnSaveKeys.Click += new System.EventHandler(this.btnSaveKeys_Click);
            // 
            // btnLoadLicense
            // 
            this.btnLoadLicense.AutoSize = false;
            this.btnLoadLicense.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadLicense.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadLicense.Depth = 0;
            this.btnLoadLicense.HighEmphasis = true;
            this.btnLoadLicense.Icon = null;
            this.btnLoadLicense.Location = new System.Drawing.Point(606, 424);
            this.btnLoadLicense.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadLicense.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadLicense.Name = "btnLoadLicense";
            this.btnLoadLicense.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoadLicense.Size = new System.Drawing.Size(157, 36);
            this.btnLoadLicense.TabIndex = 12;
            this.btnLoadLicense.Text = "Cargar Licencia";
            this.btnLoadLicense.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLoadLicense.UseAccentColor = false;
            this.btnLoadLicense.UseVisualStyleBackColor = true;
            this.btnLoadLicense.Click += new System.EventHandler(this.btnLoadLicense_Click);
            // 
            // LicenseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 816);
            this.Controls.Add(this.btnLoadLicense);
            this.Controls.Add(this.btnTestLicense);
            this.Controls.Add(this.btnSaveKeys);
            this.Controls.Add(this.btnSaveLicense);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnGenerateLicense);
            this.Controls.Add(this.btnGenerateKeyPair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseFrm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateExpiration;
        private MaterialSkin.Controls.MaterialLabel lblExpire;
        private MaterialSkin.Controls.MaterialSwitch swchNoExpirationDate;
        private MaterialSkin.Controls.MaterialTextBox2 txtDeviceIdentifier;
        private MaterialSkin.Controls.MaterialTextBox2 txtCustomerName;
        private System.Windows.Forms.RichTextBox rtLicenseXml;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnGenerateKeyPair;
        private MaterialSkin.Controls.MaterialButton btnGenerateLicense;
        private MaterialSkin.Controls.MaterialTextBox2 txtPublicKey;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassPhrase;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrivateKey;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton btnSaveLicense;
        private MaterialSkin.Controls.MaterialButton btnTestLicense;
        private MaterialSkin.Controls.MaterialButton btnSaveKeys;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtLicenseKey;
        private MaterialSkin.Controls.MaterialButton btnLoadLicense;
    }
}

