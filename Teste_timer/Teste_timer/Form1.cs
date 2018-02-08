using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_timer
{
    public partial class Form1 : Form
    {

        DateTime data;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data = DateTime.Now;

            lbl_date.Text = "Data de hoje.: " + data.ToShortDateString() + " Hora.: " + data.ToLongTimeString();

        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }
    }
}
