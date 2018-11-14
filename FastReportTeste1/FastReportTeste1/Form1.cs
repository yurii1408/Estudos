using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            report1.SetParameterValue("FASE", "JUL");
            report1.Show();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
