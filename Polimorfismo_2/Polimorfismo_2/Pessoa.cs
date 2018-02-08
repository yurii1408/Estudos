using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    class Pessoa
    {
        private string nome;
        private string endereco;
        
        public void gravar (string nome, string endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
        }

        public string getNome() { return nome; }

        public string getEndereco() { return endereco; }
    }
}
