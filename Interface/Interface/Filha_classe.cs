using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Filha_classe : Pai_Interface
    {
        string campo1, campo2;

        public void getCampo(string campo1, string campo2)
        {
            this.campo1 = campo1;
            this.campo2 = campo2;
        }

        
        public string getCampo1()
        {
            return campo1;
        }

        public string getCampo2()
        {
            return campo2;
        }
    }
}
