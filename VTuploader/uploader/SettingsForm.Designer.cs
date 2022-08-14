namespace uploader
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.statusLabel = new DarkUI.Controls.DarkLabel();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.directCheckboxsit = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.languageCombosit = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.langaugeLabelsit = new DarkUI.Controls.DarkLabel();
            this.getApiButtonsit = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.apiTextboxsit = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveButtonsit = new Siticone.UI.WinForms.SiticoneRoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.statusLabel.Location = new System.Drawing.Point(256, 169);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(163, 23);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(314, 7);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 6;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.Location = new System.Drawing.Point(360, 7);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 5;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.siticoneLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.siticoneLabel1.IsSelectionEnabled = false;
            this.siticoneLabel1.Location = new System.Drawing.Point(40, 12);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(115, 15);
            this.siticoneLabel1.TabIndex = 31;
            this.siticoneLabel1.Text = "Virus Total Checker";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::uploader.Properties.Resources.VirusTotal;
            this.siticonePictureBox1.Location = new System.Drawing.Point(2, 2);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(32, 34);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 30;
            this.siticonePictureBox1.TabStop = false;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.siticoneGradientPanel1.BorderRadius = 5;
            this.siticoneGradientPanel1.Controls.Add(this.directCheckboxsit);
            this.siticoneGradientPanel1.Controls.Add(this.languageCombosit);
            this.siticoneGradientPanel1.Controls.Add(this.langaugeLabelsit);
            this.siticoneGradientPanel1.Controls.Add(this.getApiButtonsit);
            this.siticoneGradientPanel1.Controls.Add(this.darkLabel1);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneLabel2);
            this.siticoneGradientPanel1.Controls.Add(this.apiTextboxsit);
            this.siticoneGradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(32, 37);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(344, 272);
            this.siticoneGradientPanel1.TabIndex = 31;
            // 
            // directCheckboxsit
            // 
            this.directCheckboxsit.AutoSize = true;
            this.directCheckboxsit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.directCheckboxsit.CheckedState.BorderRadius = 2;
            this.directCheckboxsit.CheckedState.BorderThickness = 0;
            this.directCheckboxsit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.directCheckboxsit.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.directCheckboxsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.directCheckboxsit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.directCheckboxsit.Location = new System.Drawing.Point(111, 224);
            this.directCheckboxsit.Name = "directCheckboxsit";
            this.directCheckboxsit.Size = new System.Drawing.Size(123, 17);
            this.directCheckboxsit.TabIndex = 46;
            this.directCheckboxsit.Text = "Direct file upload";
            this.directCheckboxsit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.directCheckboxsit.UncheckedState.BorderRadius = 2;
            this.directCheckboxsit.UncheckedState.BorderThickness = 2;
            this.directCheckboxsit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.directCheckboxsit.UseVisualStyleBackColor = true;
            // 
            // languageCombosit
            // 
            this.languageCombosit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.languageCombosit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.languageCombosit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.languageCombosit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageCombosit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.languageCombosit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.languageCombosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.languageCombosit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.languageCombosit.FormattingEnabled = true;
            this.languageCombosit.HoveredState.Parent = this.languageCombosit;
            this.languageCombosit.ItemHeight = 30;
            this.languageCombosit.ItemsAppearance.Parent = this.languageCombosit;
            this.languageCombosit.Location = new System.Drawing.Point(8, 160);
            this.languageCombosit.Name = "languageCombosit";
            this.languageCombosit.ShadowDecoration.Parent = this.languageCombosit;
            this.languageCombosit.Size = new System.Drawing.Size(328, 36);
            this.languageCombosit.TabIndex = 45;
            // 
            // langaugeLabelsit
            // 
            this.langaugeLabelsit.AutoSize = true;
            this.langaugeLabelsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langaugeLabelsit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.langaugeLabelsit.Location = new System.Drawing.Point(141, 140);
            this.langaugeLabelsit.Name = "langaugeLabelsit";
            this.langaugeLabelsit.Size = new System.Drawing.Size(63, 13);
            this.langaugeLabelsit.TabIndex = 44;
            this.langaugeLabelsit.Text = "Language";
            // 
            // getApiButtonsit
            // 
            this.getApiButtonsit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.getApiButtonsit.BorderThickness = 1;
            this.getApiButtonsit.CheckedState.Parent = this.getApiButtonsit;
            this.getApiButtonsit.CustomImages.Parent = this.getApiButtonsit;
            this.getApiButtonsit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.getApiButtonsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.getApiButtonsit.ForeColor = System.Drawing.Color.Gainsboro;
            this.getApiButtonsit.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.getApiButtonsit.HoveredState.Parent = this.getApiButtonsit;
            this.getApiButtonsit.Location = new System.Drawing.Point(133, 97);
            this.getApiButtonsit.Name = "getApiButtonsit";
            this.getApiButtonsit.ShadowDecoration.Parent = this.getApiButtonsit;
            this.getApiButtonsit.Size = new System.Drawing.Size(78, 23);
            this.getApiButtonsit.TabIndex = 43;
            this.getApiButtonsit.Text = "Get API key";
            this.getApiButtonsit.Click += new System.EventHandler(this.getApiButton_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(146, 39);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(52, 13);
            this.darkLabel1.TabIndex = 42;
            this.darkLabel1.Text = "API Key";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.siticoneLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.siticoneLabel2.Location = new System.Drawing.Point(148, 12);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(49, 15);
            this.siticoneLabel2.TabIndex = 40;
            this.siticoneLabel2.Text = "Settings";
            this.siticoneLabel2.Click += new System.EventHandler(this.siticoneLabel2_Click);
            // 
            // apiTextboxsit
            // 
            this.apiTextboxsit.AllowDrop = true;
            this.apiTextboxsit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.apiTextboxsit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apiTextboxsit.DefaultText = "";
            this.apiTextboxsit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.apiTextboxsit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.apiTextboxsit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.apiTextboxsit.DisabledState.Parent = this.apiTextboxsit;
            this.apiTextboxsit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.apiTextboxsit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.apiTextboxsit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apiTextboxsit.FocusedState.Parent = this.apiTextboxsit;
            this.apiTextboxsit.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apiTextboxsit.HoveredState.Parent = this.apiTextboxsit;
            this.apiTextboxsit.Location = new System.Drawing.Point(8, 56);
            this.apiTextboxsit.Margin = new System.Windows.Forms.Padding(4);
            this.apiTextboxsit.Name = "apiTextboxsit";
            this.apiTextboxsit.PasswordChar = '\0';
            this.apiTextboxsit.PlaceholderText = "";
            this.apiTextboxsit.SelectedText = "";
            this.apiTextboxsit.ShadowDecoration.Parent = this.apiTextboxsit;
            this.apiTextboxsit.Size = new System.Drawing.Size(328, 30);
            this.apiTextboxsit.TabIndex = 34;
            this.apiTextboxsit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButtonsit
            // 
            this.saveButtonsit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.saveButtonsit.BorderThickness = 1;
            this.saveButtonsit.CheckedState.Parent = this.saveButtonsit;
            this.saveButtonsit.CustomImages.Parent = this.saveButtonsit;
            this.saveButtonsit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.saveButtonsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.saveButtonsit.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveButtonsit.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.saveButtonsit.HoveredState.Parent = this.saveButtonsit;
            this.saveButtonsit.Location = new System.Drawing.Point(144, 325);
            this.saveButtonsit.Name = "saveButtonsit";
            this.saveButtonsit.ShadowDecoration.Parent = this.saveButtonsit;
            this.saveButtonsit.Size = new System.Drawing.Size(121, 31);
            this.saveButtonsit.TabIndex = 47;
            this.saveButtonsit.Text = "Save";
            this.saveButtonsit.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(408, 368);
            this.Controls.Add(this.saveButtonsit);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkLabel statusLabel;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox apiTextboxsit;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private Siticone.UI.WinForms.SiticoneRoundedButton getApiButtonsit;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox languageCombosit;
        private DarkUI.Controls.DarkLabel langaugeLabelsit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Siticone.UI.WinForms.SiticoneCheckBox directCheckboxsit;
        private Siticone.UI.WinForms.SiticoneRoundedButton saveButtonsit;
    }
}