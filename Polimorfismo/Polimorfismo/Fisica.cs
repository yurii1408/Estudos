using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Fisica : Pessoa
    {
        public override void gravar()
        {
            Console.WriteLine("Pessoa Fisica");
        }
    }
}
