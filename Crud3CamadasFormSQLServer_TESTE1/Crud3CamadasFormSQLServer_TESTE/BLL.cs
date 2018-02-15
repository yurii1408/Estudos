using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Crud3CamadasFormSQLServer_TESTE
{
    class BLL
    {
        DataTable datatable = null;
        DAL dal = null;

        public DataTable lista_bairros_dal()
        {
            datatable = new DataTable();
            dal = new DAL();

            datatable = dal.lista_bairros();
            return datatable;
        }

    }
}
