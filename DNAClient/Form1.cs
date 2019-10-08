using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            lstResult.Items.Add($"Request-Reply Operation Started at @ {DateTime.Now.ToString()}");
            button2.Enabled = false;

            lstResult.Items.Add(client.RequestReplyOperation());
            button2.Enabled = true;

            lstResult.Items.Add($"Request-Reply Operation completed at @ {DateTime.Now.ToString()}");
            lstResult.Items.Add("");
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
    }
}
