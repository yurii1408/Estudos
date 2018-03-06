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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_formA_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB(this);
            formB.ShowDialog();
        }
    }
    /*
 
 NOTA: A propriedade MODIFIERS das textbox precisam ser alteradas para PUBLICAS para serem acessadas dentro de outras classes – por padrão elas vem por private.

Código do FORM A:

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;


namespace Artigo_Polimorfismo

{

    public partial class Form1 : Form

    {

       


        public Form1()

        {

            InitializeComponent();

        }


        //botao que ABRE o FORM B

        private void button1_Click(object sender, EventArgs e)

        {

            Form2 formB = new Form2(this); //this, significa que estou passando ESSA classe (instância dela) como parametro

            formB.Show();

        }

    }

}

Código do FORM B (manipulando o FORM A):
using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;


namespace Artigo_Polimorfismo

{

    public partial class Form2 : Form

    {

        Form1 instanciaDoForm1; //crio um objeto do tipo FORM 1, que será usado dentro da classe


        //inicializador do FORM

        public Form2(Form1 frm1) //recebo por parametro um objeto do tipo FORM1

        {

            InitializeComponent();

            instanciaDoForm1 = frm1; //atribuo a instancia recebida pelo construtor a minha variavel interna


            //associo o mesmo texto do tbxTextBoxFormA ao meu FORM B

            tbxTextBoxFormB.Text = instanciaDoForm1.tbxTextBoxFormA.Text.ToString();

        }


        //botao alterar

        private void button1_Click(object sender, EventArgs e)

        {

            //passo para a textbox do FORM A o mesmo texto que está na minha do FORM B

            instanciaDoForm1.tbxTextBoxFormA.Text = tbxTextBoxFormB.Text.ToString();

            instanciaDoForm1.tbxTextBoxFormA.Refresh(); //recarrego ela

        }

    }

}
     */
}
