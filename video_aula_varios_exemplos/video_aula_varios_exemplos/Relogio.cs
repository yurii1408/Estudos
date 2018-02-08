using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_aula_varios_exemplos
{
    public partial class Relogio : Form
    {
        public Relogio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToShortDateString();
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
