using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* 
     * modificadores de acesso
     * public = pode ser acessado sem restrições
     * private = pode ser acessado somente dentro da classe
     * protected = semelhante ao private e podem ser acessados de outras classes derivadas
     * internal e protected internal
     */

    public class Produto
    {
        public Produto() //metodo constructor
        {
            Console.WriteLine("Instanciado metodo construtor!");
        }

        ~Produto() { } //metodo destructor





        //O "void" serve para setar um valor, adicionar um valor a variável neste caso
        //O "get" serve para ler o valor que foi setado pelo "void" 


        //Esse primeiro "this." informa que a variável "nome_produto" la de cima, é igual a que está dentro do método
        /*
        public void setNome(string nome_produto)
        { 
            this.nome_produto = nome_produto;
        }
                
        public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public string getNome()
        {
            return nome_produto;
        }

        public double getPreco()
        {
            return preco;
        }
        */

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
