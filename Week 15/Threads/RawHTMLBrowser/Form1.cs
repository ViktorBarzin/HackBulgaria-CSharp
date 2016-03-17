using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawHTMLBrowser
{
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "Load")
            {
                if (this.TxtUrl.Text == string.Empty)
                {
                    MessageBox.Show("Enter Url first!");
                    return;
                }
                this.UpdateButtonTextToCancel();

                string url = this.TxtUrl.Text;
                this.DownloadHtmlThread(url);
            }
            else
            {

            }
        }

        private void DownloadHtmlThread(string url)
        {
            Thread thread = new Thread(
                () =>
                    {
                        using (WebClient webClient = new WebClient())
                        {
                            lock (this)
                            {
                                string source = (webClient.DownloadString(url));
                                this.Callback(source);
                            }
                        }
                    }) { IsBackground = true };
            thread.Start();
            Thread.Sleep(2000);

        }

        private void Callback(string html)
        {
            this.TxtOutput.Text = html;
            this.UpdateButtonTextToLoad();
        }

        private void UpdateButtonTextToCancel()
        {
            this.button1.Text = "Cancel";
        }
        private void UpdateButtonTextToLoad()
        {
            this.button1.Text = "Load";
        }
    }
}
