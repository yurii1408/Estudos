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

namespace Diretorios
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo diretorio = new DirectoryInfo(@"c:\ecosis");

                if (diretorio.Exists)
                {
                    MessageBox.Show("Este diretório já existe!");
                }
                else
                {
                    MessageBox.Show("Este diretório ainda não existe, será criado agora.");
                    diretorio.Create();
                    MessageBox.Show("Criado com sucesso!");
                }
            }
            catch (IOException erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo diretorio = new DirectoryInfo(@"c:\ecosis");

                if (diretorio.Exists)
                {
                    MessageBox.Show("Excluindo diretório...");
                    diretorio.Delete();
                    MessageBox.Show("Diretório excluido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não existe nenhum diretório a ser excluido.");
                }
            }
            catch (IOException erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo diretorio = new DirectoryInfo(@"C:\ecosis");

                MessageBox.Show("Criando subdiretórios...");
                diretorio.CreateSubdirectory("dados");
                diretorio.CreateSubdirectory(@"dados\ecodados");


                MessageBox.Show("Criado diretório: " + diretorio.FullName);
            }
            catch (IOException erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            FileInfo arquivo = new FileInfo(@"C:\ecosis\eco.txt");
            MessageBox.Show("O arquivo " + arquivo + " será criado...");
            FileStream fs = arquivo.Create();
            MessageBox.Show("Arquivo criado com sucesso!");
            MessageBox.Show("Criado em: "+arquivo.CreationTime+"\n"+ "Atributos: " + arquivo.Attributes+ "\n" + "Diretório: " + arquivo.FullName);
            fs.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo arquivo = new FileInfo(@"c:\ecosis\eco.ini");
                arquivo.Delete();
                MessageBox.Show("Arquivo apagado com sucesso!");
            }
            catch (IOException erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\ecosis\eco.txt",FileMode.OpenOrCreate,FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            /*sw.WriteLine("Teste1");
            sw.WriteLine("Teste2");*/
            sw.WriteLine(rtb_texto.Text);
            sw.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\ecosis\eco.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            rtb_texto.Text = sr.ReadToEnd();
            sr.Close();

        }
    } 
}
