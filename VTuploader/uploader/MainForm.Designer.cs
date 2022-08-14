namespace uploader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dragLabel = new DarkUI.Controls.DarkLabel();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.SettingsBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dragLabel
            // 
            this.dragLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dragLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.dragLabel.Location = new System.Drawing.Point(53, 64);
            this.dragLabel.Name = "dragLabel";
            this.dragLabel.Size = new System.Drawing.Size(166, 65);
            this.dragLabel.TabIndex = 0;
            this.dragLabel.Text = "Drag file here";
            this.dragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dragLabel.Click += new System.EventHandler(this.dragLabel_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(242, 7);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 8;
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
            this.siticoneControlBox1.Location = new System.Drawing.Point(288, 7);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 7;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.siticoneGradientPanel1.BorderRadius = 5;
            this.siticoneGradientPanel1.Controls.Add(this.dragLabel);
            this.siticoneGradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(32, 37);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(273, 192);
            this.siticoneGradientPanel1.TabIndex = 9;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::uploader.Properties.Resources.VirusTotal;
            this.siticonePictureBox1.Location = new System.Drawing.Point(2, 2);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(32, 34);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 10;
            this.siticonePictureBox1.TabStop = false;
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
            this.siticoneLabel1.TabIndex = 11;
            this.siticoneLabel1.Text = "Virus Total Checker";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.SettingsBtn.BorderThickness = 1;
            this.SettingsBtn.CheckedState.Parent = this.SettingsBtn;
            this.SettingsBtn.CustomImages.Parent = this.SettingsBtn;
            this.SettingsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.SettingsBtn.HoveredState.Parent = this.SettingsBtn;
            this.SettingsBtn.Location = new System.Drawing.Point(129, 241);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.ShadowDecoration.Parent = this.SettingsBtn;
            this.SettingsBtn.Size = new System.Drawing.Size(78, 23);
            this.SettingsBtn.TabIndex = 28;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.Click += new System.EventHandler(this.moreLabel_Click);
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.siticoneLabel1;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(337, 276);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirusTotal Uploader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.siticoneGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel dragLabel;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneRoundedButton SettingsBtn;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
    }
}

