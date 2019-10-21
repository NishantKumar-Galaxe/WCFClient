using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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
            //client = new GxService.SimpleServiceClient();
            reportServiceClient = new GxService.ReportServiceClient();
        }



        private void Btn_GetCustomer_Click(object sender, EventArgs e)
        {
            DateTime dtStart = DateTime.Now;
            GxService.SimpleServiceClient client1 = new GxService.SimpleServiceClient();

            var lst = client1.GetCustomerList();
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

            client1.Close();
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

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            DateTime dtStart = DateTime.Now;
            var cust = GetCustObject();
            var lst = client.AddNewCustomer(cust);

            DateTime dtEnd = DateTime.Now;
            long res = dtEnd.Subtract(dtStart).Ticks;

            double res1 = dtEnd.Subtract(dtStart).TotalSeconds;

            if (sb.Length > 0)
                sb.AppendLine();

            sb.AppendLine("Non Restful Service Call.");
            sb.AppendLine(res.ToString() + " Ticks, Processing time at client.");
            sb.AppendLine(res1.ToString() + " Seconds, Processing time at client.");
            txtMessage.Text = sb.ToString();

        }

        private void Btn_AddNewCustRest_Click(object sender, EventArgs e)
        {
            DateTime dtStart = DateTime.Now;
            var url = "http://localhost:8085/GxRestService/AddNewCustomer_Rest";

            var cust = GetCustObject();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(cust);

                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }



            DateTime dtEnd = DateTime.Now;

            long res = dtEnd.Subtract(dtStart).Ticks;  //.  Seconds);
            double res1 = dtEnd.Subtract(dtStart).TotalSeconds;

            if (sb.Length > 0)
                sb.AppendLine();
            sb.AppendLine("Restful Service Call.");
            sb.AppendLine(res.ToString() + " Ticks, Processing time at client.");
            sb.AppendLine(res1.ToString() + " Seconds, Processing time at client.");
            txtMessage.Text = sb.ToString();
        }
        private GxService.Customer GetCustObject()
        {
            GxService.Customer cust = new GxService.Customer();
            cust.CustomerID = $"{ DateTime.Now.ToString("ssttt") }";
            cust.CompanyName = "Berglunds snabbköp";
            cust.ContactName = "Christina";
            cust.ContactTitle = "Berglund";
            cust.Address = "Order Administrator Berguvsvägen  8 Sample";
            cust.City = "Sweden";
            cust.Region = "S - 958 22";
            cust.PostalCode = "2122";
            cust.Country = "India";
            cust.Phone = "0921 - 12 34 65";
            cust.Fax = "0921 - 12 34 67";
            return cust;

        }

        private void btnConcurrency_Click(object sender, EventArgs e)
        {
            GxService.SimpleServiceClient client = new GxService.SimpleServiceClient();
            for (int i = 1; i <= 20; i++)
            {
                client.CheckConcurrencyBehaviour(i);
            }
        }
    }
}
