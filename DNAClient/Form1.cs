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
        StringBuilder sb = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            client = new GxService.SimpleServiceClient();
            reportServiceClient = new GxService.ReportServiceClient();
        }



        private void Btn_GetCustomer_Click(object sender, EventArgs e)
        {
            DateTime dtStart = DateTime.Now;
            var lst = client.GetCustomerList();
            gvData.DataSource = lst;

            DateTime dtEnd = DateTime.Now;
            long res = dtEnd.Subtract(dtStart).Ticks;  //.  Seconds);

            double res1 = dtEnd.Subtract(dtStart).TotalSeconds;

            if (sb.Length > 0)
                sb.AppendLine();

            sb.AppendLine("Non Restful Service Call, Total " + lst.Count().ToString() + " row recieved.");
            sb.AppendLine(res.ToString() + " Ticks, Processing time at client.");
            sb.AppendLine(res1.ToString() + " Seconds, Processing time at client.");
            txtMessage.Text = sb.ToString();
        }

        private void Btn_GetCustomer_Rest_Click(object sender, EventArgs e)
        {
            DateTime dtStart = DateTime.Now;
            var url = "http://localhost:8085/GxRestService/GetCustomerList_Rest";
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
            var releases = JArray.Parse(content);

            gvData.DataSource = releases;
            DateTime dtEnd = DateTime.Now;

            long res = dtEnd.Subtract(dtStart).Ticks;  //.  Seconds);
            double res1 = dtEnd.Subtract(dtStart).TotalSeconds;

            if (sb.Length > 0)
                sb.AppendLine();
            sb.AppendLine("Restful Service Call, Total " + releases.Count().ToString() + " row recieved.");
            sb.AppendLine(res.ToString() + " Ticks, Processing time at client.");
            sb.AppendLine(res1.ToString() + " Seconds, Processing time at client.");
            txtMessage.Text = sb.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sb = new StringBuilder();
            txtMessage.Text = string.Empty;
            gvData.DataSource = null;
        }
    }
}
