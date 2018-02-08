using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculaSalario
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

        private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria,
            double HorasTrabalhadas, double ValorSalarioMinimo)
        {
            double ValorCoeficiente = GetCoeficiente(rbnTurno);
            double ValorGratificacao = GetGratificacao(rbnTurno, HorasTrabalhadas);
            double ValorSalarioBruto = HorasTrabalhadas * ValorCoeficiente;
            double ValorImposto = GetImposto(rbnCategoria, ValorSalarioBruto);
            double ValorAuxilioAlimentação = GetAuxilioAlimentacao(rbnCategoria, ValorSalarioBruto, ValorSalarioMinimo);
            double ValorSalarioLiquido = (ValorSalarioBruto + (ValorGratificacao + ValorAuxilioAlimentação) - ValorImposto);
            ApresentarResultados(ValorCoeficiente, ValorSalarioBruto, ValorImposto, ValorGratificacao, ValorAuxilioAlimentação, ValorSalarioLiquido);

        }

        private double GetCoeficiente(RadioButton rbnTurno)
        {
            double ValorCoeficiente = 0;
            switch (rbnTurno.Text)
            {
                case "Matutino":
                    ValorCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.01;
                    break;
                case "Vespertino":
                    ValorCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.02;
                    break;
                case "Noturno":
                    ValorCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.03;
                    break;
            }
            return ValorCoeficiente;

        }

        private double GetGratificacao(RadioButton rbnTurno, double HorasTrabalhadas)
        {
            double ValorGratificacao = 30;
            if (rbnTurno.Text.Equals("Noturno") && HorasTrabalhadas > 80) ValorGratificacao = 50;

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

        private double GetAuxilioAlimentacao(RadioButton rbnCategoria, double ValorSalarioBruto,
            double ValorSalarioMinimo)
        {
            double ValorAuxilioAlimentacao = (ValorSalarioBruto / 3) / 2;

            if (rbnCategoria.Text.Equals("Calouro") && (ValorSalarioBruto < (ValorSalarioMinimo / 2)))
                ValorAuxilioAlimentacao = (ValorSalarioBruto / 3);

            return ValorAuxilioAlimentacao;
        }

        private void ApresentarResultados(double ValorCoeficiente, double ValorSalarioBruto,
            double ValorImposto, double ValorGratificacao, double ValorAuxilioAlimentacao,
            double ValorSalarioLiquido)
        {
            lblCategoria.Text = GetSituacaoEstagiario(ValorSalarioLiquido);
            lbxPainel.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do coeficiente:", ValorCoeficiente));
            lbxPainel.Items.Add(String.Format("{0,-29}{1,12:C}", "Salário bruto:", ValorSalarioBruto));
            lbxPainel.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor imposto:", ValorImposto));
            lbxPainel.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor da gratificação:", ValorGratificacao));
            lbxPainel.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor auxilio alimentação:", ValorAuxilioAlimentacao));
            lbxPainel.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do salário liquido:", ValorSalarioLiquido));

        }

        private string GetSituacaoEstagiario(double ValorSalarioLiquido)
        {
            if (ValorSalarioLiquido < 350)
                return "Mal remunerado";
            else if (ValorSalarioLiquido < 600)
                return "Normal";
            else
                return "Bem remunerado";
        }
    }
}