using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculaSalarioRevisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RadioButton rbnTurno = gbxTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnCategoria = gbxCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);

            RealizarProcessamento(rbnTurno, rbnCategoria, Convert.ToDouble(txtHorasTrabalhadas.Text), Convert.ToDouble(txtSalarioMinimo.Text));

        }

        private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria, double txtHorasTrabalhadas, double txtSalarioMinimo)
        {
            double ValorCoeficiente = GetCoeficiente(rbnTurno);
            double ValorGratificacao = GetGratificacao(rbnTurno, txtHorasTrabalhadas);
            double ValorSalarioBruto = txtHorasTrabalhadas * ValorCoeficiente;
            double ValorImposto = GetImposto(rbnCategoria, ValorSalarioBruto);
        }

        private double GetCoeficiente(RadioButton rbnTurno)
        {
            double ValorDoCoeficiente = 0;
                switch (rbnTurno.Text)
            {
                case "Matutino":
                    ValorDoCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.01;
                    break;
                case "Vespertino":
                    ValorDoCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.02;
                    break;
                case "Noturno":
                    ValorDoCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.03;
                    break;             

            }
            return ValorDoCoeficiente;
        }

        private double GetGratificacao(RadioButton rbnTurno, double txtHorasTrabalhadas)
        {
            double ValorGratificacao = 30;
            if (rbnTurno.Text.Equals("Noturno") && txtHorasTrabalhadas > 80) ValorGratificacao = 50;
                    return ValorGratificacao;
        }

        private double GetImposto(RadioButton rbnCategoria, double ValorSalarioBruto)
        {
            double ValorImposto = 0;
            switch (rbnCategoria.Text)
            {
                case "Calouro":
                    if (ValorSalarioBruto < 300)
                        ValorImposto = ValorSalarioBruto * 0.01;
                    break;
                case "Veterano":
                    if (ValorSalarioBruto < 400)
                        ValorImposto = ValorSalarioBruto * 0.02;
                    else
                        ValorImposto = ValorSalarioBruto * 0.03;
                    break;
            }
            return ValorImposto;
                

                
        }
    }
}
