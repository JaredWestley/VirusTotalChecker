namespace uploader
{
    partial class UploadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm));
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.UploadBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.mdTextboxsit = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.shaTextboxsit = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.sha2Textboxsit = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.settingsGroupsit = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(171, 155);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(53, 13);
            this.darkLabel3.TabIndex = 4;
            this.darkLabel3.Text = "SHA256";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(178, 97);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(39, 13);
            this.darkLabel2.TabIndex = 2;
            this.darkLabel2.Text = "SHA1";
            this.darkLabel2.Click += new System.EventHandler(this.darkLabel2_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(364, 7);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 4;
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
            this.siticoneControlBox1.Location = new System.Drawing.Point(410, 7);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 3;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // UploadBtn
            // 
            this.UploadBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.UploadBtn.BorderThickness = 1;
            this.UploadBtn.CheckedState.Parent = this.UploadBtn;
            this.UploadBtn.CustomImages.Parent = this.UploadBtn;
            this.UploadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.UploadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBtn.ForeColor = System.Drawing.Color.White;
            this.UploadBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.UploadBtn.HoveredState.Parent = this.UploadBtn;
            this.UploadBtn.Location = new System.Drawing.Point(137, 292);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.ShadowDecoration.Parent = this.UploadBtn;
            this.UploadBtn.Size = new System.Drawing.Size(78, 23);
            this.UploadBtn.TabIndex = 27;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
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
            this.siticoneLabel1.TabIndex = 29;
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
            this.siticonePictureBox1.TabIndex = 28;
            this.siticonePictureBox1.TabStop = false;
            // 
            // mdTextboxsit
            // 
            this.mdTextboxsit.AllowDrop = true;
            this.mdTextboxsit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.mdTextboxsit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mdTextboxsit.DefaultText = "";
            this.mdTextboxsit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mdTextboxsit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mdTextboxsit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mdTextboxsit.DisabledState.Parent = this.mdTextboxsit;
            this.mdTextboxsit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mdTextboxsit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.mdTextboxsit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mdTextboxsit.FocusedState.Parent = this.mdTextboxsit;
            this.mdTextboxsit.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mdTextboxsit.HoveredState.Parent = this.mdTextboxsit;
            this.mdTextboxsit.Location = new System.Drawing.Point(33, 56);
            this.mdTextboxsit.Margin = new System.Windows.Forms.Padding(4);
            this.mdTextboxsit.Name = "mdTextboxsit";
            this.mdTextboxsit.PasswordChar = '\0';
            this.mdTextboxsit.PlaceholderText = "";
            this.mdTextboxsit.SelectedText = "";
            this.mdTextboxsit.ShadowDecoration.Parent = this.mdTextboxsit;
            this.mdTextboxsit.Size = new System.Drawing.Size(328, 30);
            this.mdTextboxsit.TabIndex = 34;
            this.mdTextboxsit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(181, 39);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(33, 13);
            this.darkLabel4.TabIndex = 35;
            this.darkLabel4.Text = "MD5";
            // 
            // shaTextboxsit
            // 
            this.shaTextboxsit.AllowDrop = true;
            this.shaTextboxsit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.shaTextboxsit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.shaTextboxsit.DefaultText = "";
            this.shaTextboxsit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.shaTextboxsit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.shaTextboxsit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shaTextboxsit.DisabledState.Parent = this.shaTextboxsit;
            this.shaTextboxsit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shaTextboxsit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.shaTextboxsit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shaTextboxsit.FocusedState.Parent = this.shaTextboxsit;
            this.shaTextboxsit.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shaTextboxsit.HoveredState.Parent = this.shaTextboxsit;
            this.shaTextboxsit.Location = new System.Drawing.Point(33, 112);
            this.shaTextboxsit.Margin = new System.Windows.Forms.Padding(4);
            this.shaTextboxsit.Name = "shaTextboxsit";
            this.shaTextboxsit.PasswordChar = '\0';
            this.shaTextboxsit.PlaceholderText = "";
            this.shaTextboxsit.SelectedText = "";
            this.shaTextboxsit.ShadowDecoration.Parent = this.shaTextboxsit;
            this.shaTextboxsit.Size = new System.Drawing.Size(328, 30);
            this.shaTextboxsit.TabIndex = 36;
            this.shaTextboxsit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sha2Textboxsit
            // 
            this.sha2Textboxsit.AllowDrop = true;
            this.sha2Textboxsit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.sha2Textboxsit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sha2Textboxsit.DefaultText = "";
            this.sha2Textboxsit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sha2Textboxsit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sha2Textboxsit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sha2Textboxsit.DisabledState.Parent = this.sha2Textboxsit;
            this.sha2Textboxsit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sha2Textboxsit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.sha2Textboxsit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sha2Textboxsit.FocusedState.Parent = this.sha2Textboxsit;
            this.sha2Textboxsit.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sha2Textboxsit.HoveredState.Parent = this.sha2Textboxsit;
            this.sha2Textboxsit.Location = new System.Drawing.Point(33, 173);
            this.sha2Textboxsit.Margin = new System.Windows.Forms.Padding(4);
            this.sha2Textboxsit.Name = "sha2Textboxsit";
            this.sha2Textboxsit.PasswordChar = '\0';
            this.sha2Textboxsit.PlaceholderText = "";
            this.sha2Textboxsit.SelectedText = "";
            this.sha2Textboxsit.ShadowDecoration.Parent = this.sha2Textboxsit;
            this.sha2Textboxsit.Size = new System.Drawing.Size(328, 30);
            this.sha2Textboxsit.TabIndex = 38;
            this.sha2Textboxsit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.siticoneGradientPanel1.BorderRadius = 5;
            this.siticoneGradientPanel1.Controls.Add(this.settingsGroupsit);
            this.siticoneGradientPanel1.Controls.Add(this.sha2Textboxsit);
            this.siticoneGradientPanel1.Controls.Add(this.shaTextboxsit);
            this.siticoneGradientPanel1.Controls.Add(this.darkLabel4);
            this.siticoneGradientPanel1.Controls.Add(this.darkLabel2);
            this.siticoneGradientPanel1.Controls.Add(this.mdTextboxsit);
            this.siticoneGradientPanel1.Controls.Add(this.darkLabel3);
            this.siticoneGradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(32, 37);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(395, 241);
            this.siticoneGradientPanel1.TabIndex = 30;
            // 
            // settingsGroupsit
            // 
            this.settingsGroupsit.BackColor = System.Drawing.Color.Transparent;
            this.settingsGroupsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.settingsGroupsit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.settingsGroupsit.Location = new System.Drawing.Point(152, 12);
            this.settingsGroupsit.Name = "settingsGroupsit";
            this.settingsGroupsit.Size = new System.Drawing.Size(90, 15);
            this.settingsGroupsit.TabIndex = 39;
            this.settingsGroupsit.Text = "File Information";
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.siticoneRoundedButton1.BorderThickness = 1;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(244, 292);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(78, 23);
            this.siticoneRoundedButton1.TabIndex = 31;
            this.siticoneRoundedButton1.Text = "Settings";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(460, 329);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UploadForm_FormClosing);
            this.Load += new System.EventHandler(this.UploadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneRoundedButton UploadBtn;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticoneLabel settingsGroupsit;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox sha2Textboxsit;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox shaTextboxsit;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox mdTextboxsit;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
    }
}