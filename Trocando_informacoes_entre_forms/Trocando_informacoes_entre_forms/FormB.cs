using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trocando_informacoes_entre_forms
{
    public partial class FormB : Form
    {
        Form1 instacia_formA;

        public FormB(Form1 formA)
        {
            InitializeComponent();
            instacia_formA = formA;
            tbx_formB.Text = instacia_formA.tbx_formA.Text;
        }

        private void btn_formB_Click(object sender, EventArgs e)
        {
            instacia_formA.tbx_formA.Text = tbx_formB.Text;
        }
    }
}
