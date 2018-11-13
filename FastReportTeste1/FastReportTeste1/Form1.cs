using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastReportTeste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FastReport.Report report1 = new FastReport.Report();
            report1.Load(@"c:\report.frx");
            report1.SetParameterValue("X", 4);
            report1.SetParameterValue("@X", 4);
            report1.SetParameterValue("@ID", 4);
            report1.SetParameterValue("ID", 4);
            report1.Show();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
