using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            ReportViewer reportviewer = new ReportViewer();
            reportviewer.ProcessingMode = ProcessingMode.Local;

            // Caminho para encontrar o relatorio
            reportviewer.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";

            //Parametros do relatorio
            List<ReportParameter> listReportParameters = new List<ReportParameter>();
            listReportParameters.Add(new ReportParameter("nome", tbx_nome.Text));

            //Passando parametros para o report
            reportviewer.LocalReport.SetParameters(listReportParameters);

            //Criando o PDF

            //Renderizando o arquivo
            Warning[] warnings;
            string[] streamids;
            string mimetype;
            string encoding;
            string extension;

            byte[] bytePDF = reportviewer.LocalReport.Render("Pdf", null, out mimetype, out encoding, out extension, out streamids, out warnings);

            //Criando o nome do arquivo
            FileStream filestream = null;
            string nomearquivos = Path.GetTempPath() + "relatorio" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";

            //Salvando o arquivo no disco
            filestream = new FileStream(nomearquivos, FileMode.Create);
            filestream.Write(bytePDF, 0, bytePDF.Length);
            filestream.Close();

            //Iniciando o arquivos
            Process.Start(nomearquivos);
        }
    }
}
