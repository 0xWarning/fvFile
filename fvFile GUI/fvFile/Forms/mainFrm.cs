using DevExpress.Utils;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Helpers.FindSearchRichParser;
using static fvFile.Classes.AuthAPI;

namespace fvFile
{
    public partial class mainFrm : DevExpress.XtraEditors.XtraForm
    {

        private readonly System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        static string logedInToken = UserLoggedInfo.token;
        static string logedInEmail = UserLoggedInfo.email;
        static String[] parts = logedInEmail.Split(new[] { '@' });

        public mainFrm()
        {
            InitializeComponent();
        }

        public static class FormUpload
        {
            private static readonly Encoding encoding = Encoding.UTF8;
            public static HttpWebResponse MultipartFormPost(string postUrl, string userAgent, Dictionary<string, object> postParameters)
            {
                string formDataBoundary = String.Format("----------{0:N}", Guid.NewGuid());
                string contentType = "multipart/form-data; boundary=" + formDataBoundary;

                byte[] formData = GetMultipartFormData(postParameters, formDataBoundary);

                return PostForm(postUrl, userAgent, contentType, formData);
            }
            private static HttpWebResponse PostForm(string postUrl, string userAgent, string contentType, byte[] formData)
            {
                HttpWebRequest request = WebRequest.Create(postUrl) as HttpWebRequest;

                if (request == null)
                {
                    throw new NullReferenceException("request is not a http request");
                }

                request.Method = "POST";
                request.ContentType = contentType;
                request.UserAgent = userAgent;
                request.CookieContainer = new CookieContainer();
                request.ContentLength = formData.Length;
                request.Headers.Add("auth-token", logedInToken);

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(formData, 0, formData.Length);
                    requestStream.Close();
                }

                return request.GetResponse() as HttpWebResponse;
            }

            private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
            {
                Stream formDataStream = new System.IO.MemoryStream();
                bool needsCLRF = false;

                foreach (var param in postParameters)
                {

                    if (needsCLRF)
                        formDataStream.Write(encoding.GetBytes("\r\n"), 0, encoding.GetByteCount("\r\n"));

                    needsCLRF = true;

                    if (param.Value is FileParameter) 
                    {
                        FileParameter fileToUpload = (FileParameter)param.Value;

                        string header = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\"\r\nContent-Type: {3}\r\n\r\n",
                            boundary,
                            param.Key,
                            fileToUpload.FileName ?? param.Key,
                            fileToUpload.ContentType ?? "application/octet-stream");

                        formDataStream.Write(encoding.GetBytes(header), 0, encoding.GetByteCount(header));
                        formDataStream.Write(fileToUpload.File, 0, fileToUpload.File.Length);
                    }
                    else
                    {
                        string postData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
                            boundary,
                            param.Key,
                            param.Value);
                        formDataStream.Write(encoding.GetBytes(postData), 0, encoding.GetByteCount(postData));
                    }
                }

                string footer = "\r\n--" + boundary + "--\r\n";
                formDataStream.Write(encoding.GetBytes(footer), 0, encoding.GetByteCount(footer));
                formDataStream.Position = 0;
                byte[] formData = new byte[formDataStream.Length];
                formDataStream.Read(formData, 0, formData.Length);
                formDataStream.Close();

                return formData;
            }

            public class FileParameter
            {
                public byte[] File { get; set; }
                public string FileName { get; set; }
                public string ContentType { get; set; }
                public FileParameter(byte[] file) : this(file, null) { }
                public FileParameter(byte[] file, string filename) : this(file, filename, null) { }
                public FileParameter(byte[] file, string filename, string contenttype)
                {
                    File = file;
                    FileName = filename;
                    ContentType = contenttype;
                }
            }
        }

        private void OnDownloadProgressChange(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            string downloadProgress = e.ProgressPercentage + "%";
            string downloadSpeed = string.Format("{0} MB/s", (e.BytesReceived / 1024.0 / 1024.0 / stopwatch.Elapsed.TotalSeconds).ToString("0.00"));
            string downloadedMBs = Math.Round(e.BytesReceived / 1024.0 / 1024.0) + " MB";
            string totalMBs = Math.Round(e.TotalBytesToReceive / 1024.0 / 1024.0) + " MB";

            string progress = $"{downloadedMBs}/{totalMBs} ({downloadProgress}) @ {downloadSpeed}"; // 10 MB / 100 MB (10%) @ 1.23 MB/s

            labelControl15.Text = progress;
            labelControl12.Text = downloadSpeed;

            progressBarControl2.Position = e.ProgressPercentage;
        }

        private void OnDownloadFileComplete(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            labelControl15.Text = "Download complete!";
            stopwatch.Reset();
        }

        public void DownloadFunction(string file)
        {

            string selectedFile = file;

            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                wc.DownloadProgressChanged += OnDownloadProgressChange;
                wc.DownloadFileCompleted += OnDownloadFileComplete;

                stopwatch.Start();
                if (selectedFile == "Squid Game")
                {

                    wc.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/857580693144338463/986692194876391484/squid.txt"),
                    @"C:\fvFiles\squid.txt");

                }
                else if (selectedFile == "Scylla")
                {

                    wc.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/986758461251518514/986759032087904276/Scylla_v0.9.8.rar"),
                    @"C:\fvFiles\Scylla.rar");

                }
                else if (selectedFile == "Popcorn Time")
                {

                    wc.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/986758461251518514/986765551424659516/PopcornTimeLatest_patch_Still_working.zip"),
                    @"C:\fvFiles\PopcornTime.rar");

                }
                else
                {
                    MessageBox.Show("error");
                    stopwatch.Stop();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textEdit3.Text = logedInToken;
            textEdit4.Text = logedInEmail;

            listBoxControl3.Items.Clear();

            listBoxControl3.Items.Add("Item");
            listBoxControl3.Items.Add("Popcorn Time");
            listBoxControl3.Items.Add("Scylla");
            listBoxControl3.Items.Add("Squid Game");
        }

        private void Download_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to download this file?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                timer1.Enabled = true;
                timer1.Interval = 50;
                string fileToDownload = listBoxControl3.SelectedItem.ToString();
                DownloadFunction(fileToDownload); 

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(comboBoxEdit2.Text);
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = xtraOpenFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                string file = xtraOpenFileDialog1.FileName;
                try
                {
                    if (XtraMessageBox.Show("Do you want to upload this file?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        string requestURL = "http://localhost:1337/api/files/upload";
                        string fileName = file;
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData(fileName);
                        Dictionary<string, object> postParameters = new Dictionary<string, object>();
                        postParameters.Add("file", new FormUpload.FileParameter(bytes, Path.GetFileName(fileName)));
                        string userAgent = "FileVision/Client-GUI";
                        HttpWebResponse webResponse = FormUpload.MultipartFormPost(requestURL, userAgent, postParameters);
                        StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
                        labelControl16.Text = responseReader.ReadToEnd();
                        webResponse.Close();
                    }

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarControl2.Position == 100) 
            {
                timer1.Stop();
            }
            else
            {
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
        }
    }
}
