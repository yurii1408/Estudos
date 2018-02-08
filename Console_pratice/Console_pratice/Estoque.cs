using System;
using System.Collections.Generic;
using System.Text;

namespace Console_pratice
{
    class Estoque
    {
        private string nome_produto;
        private double preco;

        public string Nome_produto
        {
            get { return nome_produto; }
            set { nome_produto = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

    }
}
