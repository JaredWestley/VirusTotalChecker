using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Http;

namespace uploader
{
    public partial class SummaryForm : Form
    {

        private SettingsForm _settingsForm = new SettingsForm();

        private readonly string _fileName;
        private readonly Settings _settings;
        private RestClient _client;

        public SummaryForm(Settings settings, string fileName)
        {
            _fileName = fileName;
            _settings = settings;

            InitializeComponent();
            SummaryLoad();
        }
        private static string[] suffixes = new[] { " B", " KB", " MB", " GB", " TB", " PB" };

        public static string ToSize(double number, int precision = 2)
        {
            // unit's number of bytes
            const double unit = 1024;
            // suffix counter
            int i = 0;
            // as long as we're bigger than a unit, keep going
            while (number > unit)
            {
                number /= unit;
                i++;
            }
            // apply precision and current suffix
            return Math.Round(number, precision) + suffixes[i];
        }

        private void SummaryLoad()
        {
            _client = new RestClient("https://www.virustotal.com");

            //var report = "api/v3/files/" + Utils.GetMD5(_fileName);


            var reportRequest = new RestRequest("api/v3/files/" + Utils.GetMD5(_fileName), Method.Get);
            reportRequest.AddHeader("x-apikey", _settings.ApiKey);
            reportRequest.AddParameter("resource", Utils.GetMD5(_fileName));

            var reportResponse = _client.Execute(reportRequest);
            var reportContent = reportResponse.Content;
            dynamic reportJson = JsonConvert.DeserializeObject(reportContent);
            var reportLink = (reportJson);



            //try
            //{
            //    var reportLink = reportJson.data.attributes.type_description();
            //
            //    siticoneLabel2.Text = reportLink;
            //
            //
            //}
            //catch (RuntimeBinderException)
            //{
            //    MessageBox.Show("Error");
            //}
            //var reportLink = reportJson.data.attributes.type_description();



            //File Info

            //FileName
            File_name.Text = reportLink.data.attributes.names[0].ToString();
            //FileType
            File_type.Text = reportLink.data.attributes.trid[0].file_type.ToString();
            //FileSize
            var File_size0 = reportLink.data.attributes.size.ToString();
            Int64 File_size1 = Int64.Parse(File_size0);
            string File_size2 = ToSize(File_size1, 2);
            File_size.Text = File_size2;

            //UniqueUploads
            Unique_uploads.Text = reportLink.data.attributes.unique_sources.ToString() + " Unique Uploads";
            //var vtlink = reportLink.data.links[0].ToString();

        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            SummaryLoad();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
