using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    class PessoaFisica : Pessoa
    {
        private string apelido;
        private string cpf;
        private int idade;

        public void gravar(string nome, string endereco, string apelido, string cpf, int idade)
        {
            base.gravar(nome, endereco);
            this.apelido = apelido;
            this.cpf = cpf;
            this.idade = idade;
        }

        public string getApelido () { return apelido; }
        public string getCpf () { return cpf; }
        public int getIdade() { return idade; }
       
    }
}
