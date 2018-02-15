using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Crud3CamadasFormSQLServer_TESTE2
{
    class Model
    {
        int codigo;
        string nome;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}