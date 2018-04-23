using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace SinglePageReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Data> list = new List<Data>();
            Random random = new Random();

            for (int i = 0; i < 500; i++)
            {
                Data data = new Data()
                {
                    Name = string.Format("Name{0}", i),
                    Group = string.Format("Group{0}", random.Next(10)),
                    Description = string.Format("Item Description {0}", i),
                    Value = random.Next(1000)
                };

                list.Add(data);
            }

            SampleReport report = new SampleReport() { DataSource = list };

            SinglePageHelper.GenerateSinglePageReport(report);

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
