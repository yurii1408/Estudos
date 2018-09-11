using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GridList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] cadastro = { tbx_nome.Text, tbx_endereco.Text, tbx_telefone.Text };
                ListViewItem items = new ListViewItem(cadastro);
                gridlist.Items.Add(items);

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            //SaveFileDialog savefile = new SaveFileDialog();
            //savefile.Filter = "Arquivo de texto (*.txt)|*.txt";
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nome = "gridlist.txt";
            string arquivo = Path.Combine(pasta, nome);
            using (StreamWriter sw = new StreamWriter(arquivo, false, Encoding.UTF8))
            {
                for (int i = 0; i < gridlist.Items.Count; i++)
                {
                    for (int a =0; a<gridlist.Items[i].SubItems.Count; a++)
                    {
                        string tab = (a == 0) ? string.Empty : "\t";
                        sw.Write(tab + gridlist.Items[i].SubItems[a].Text);
                    }
                    sw.WriteLine();
                }
                sw.Flush();
                sw.Close();
            }

        }
    }
}
