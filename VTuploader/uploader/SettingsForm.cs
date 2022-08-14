using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;

namespace uploader
{
    public partial class SettingsForm : DarkForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var settings = Settings.LoadSettings();

            apiTextboxsit.Text = settings.ApiKey;
            directCheckboxsit.Checked = settings.DirectUpload;

            var languages = LocalizationHelper.GetLanguages();
            languageCombosit.Items.Clear();
            foreach (var language in languages)
            {
                languageCombosit.Items.Add(language);
            }

            if (string.IsNullOrEmpty(settings.Language))
            {
                var defaultLanguage = languageCombosit.Items.Add("Default (Build-in English)");
                languageCombosit.SelectedIndex = defaultLanguage;
            }
            else
            {
                var index = languageCombosit.Items.IndexOf(settings.Language);
                languageCombosit.SelectedIndex = index;
            }

            darkLabel1.Text = LocalizationHelper.Base.SettingsForm_Key;
            getApiButtonsit.Text = LocalizationHelper.Base.SettingsForm_Get;
            langaugeLabelsit.Text = LocalizationHelper.Base.SettingsForm_Language;
            saveButtonsit.Text = LocalizationHelper.Base.SettingsForm_Save;
            this.Text = LocalizationHelper.Base.SettingsForm_Title;
            directCheckboxsit.Text = LocalizationHelper.Base.SettingsForm_DirectUpload;

            //LocalizationHelper.Export();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            apiTextboxsit.Text = apiTextboxsit.Text.Trim();

            var settings = new Settings
            {
                ApiKey = apiTextboxsit.Text, 
                Language = languageCombosit.Text,
                DirectUpload = directCheckboxsit.Checked
            };

            Settings.SaveSettings(settings);
            //statusLabel.Text = LocalizationHelper.Base.Message_Saved;
            MessageBox.Show(LocalizationHelper.Base.Message_Saved, "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information); // TODO: custom messagebox with dark theme (because default win32 one is annoying)

            // Needs full restart to initialize main form strings again
            Application.Restart();
            Environment.Exit(0);
        }

        private void getApiButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://developers.virustotal.com/reference");
        }

        private void siticoneLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
