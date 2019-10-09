using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNAClient
{
    public partial class Form1 : Form
    {
        GxService.SimpleServiceClient client;
        GxService.IReportService reportServiceClient;

        public Form1()
        {
            InitializeComponent();
            client = new GxService.SimpleServiceClient();
            reportServiceClient = new GxService.ReportServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = client.GetMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //lstResult.Items.Add($"Request-Reply Operation Started at @ {DateTime.Now.ToString()}");
            //button2.Enabled = false;

            DateTime dtStart = DateTime.Now;
            lstResult.Items.Add(client.RequestReplyOperation());
            DateTime dtEnd = DateTime.Now;
            long res = dtEnd.Subtract(dtStart).Ticks;  //.  Seconds);

            double res1 = dtEnd.Subtract(dtStart).TotalSeconds;
            lstResult.Items.Add("Non Restful Service Call:");
            lstResult.Items.Add(res.ToString() + " Ticks processing time at client");
            lstResult.Items.Add(res1.ToString() + " Total seconds processing time at client");
            lstResult.Items.Add("-------------------------------------------");
            lstResult.Items.Add("\n");
            //button2.Enabled = true;

            //lstResult.Items.Add($"Request-Reply Operation completed at @ {DateTime.Now.ToString()}");
            //lstResult.Items.Add("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstResult.Items.Add($"One Way Operation Started at @ {DateTime.Now.ToString()}");
            button3.Enabled = false;

            //client is not blocked, service request is in service queue.
            client.OneWayOperationDemo();

            button3.Enabled = true;
            lstResult.Items.Add($"One Way Operation completed at @ {DateTime.Now.ToString()}");
            lstResult.Items.Add("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reportServiceClient.ProcessReport();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            //var url = txtServiceURL.Text;
            DateTime dtStart = DateTime.Now;

            var url = "http://localhost:8085/GxRestService/paybill";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            var response = (HttpWebResponse)request.GetResponse();
            string content = string.Empty;
            using (var stream = response.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }
            //var releases = JArray.Parse(content);
            DateTime dtEnd = DateTime.Now;

            long res = dtEnd.Subtract(dtStart).Ticks;  //.  Seconds);
            double res1 = dtEnd.Subtract(dtStart).TotalSeconds;

            lstResult.Items.Add("Restful Service Call:");
            lstResult.Items.Add(res.ToString() + " Ticks processing time at client");
            lstResult.Items.Add(res1.ToString() + " Total seconds processing time at client");
            //lstResult.Items.Add(((double)(dtEnd.Subtract(dtStart).Seconds)).ToString() + " seconds processing time at Client");
            //lstResult.Items.Add("\n");
            lstResult.Items.Add(content);
            lstResult.Items.Add("-------------------------------------------");
            lstResult.Items.Add("\n");
        }
    }
}
