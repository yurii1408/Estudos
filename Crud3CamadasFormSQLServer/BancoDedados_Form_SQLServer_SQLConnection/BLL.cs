using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BancoDedados_Form_SQLServer_SQLConnection
{
    class BLL
    {
        DAL dal = null;

        public DataTable lista_bairros_dal()
        {
            DataTable datatable = new DataTable();

            try
            {
                dal = new DAL();
                datatable = dal.lista_bairros();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return datatable;
        }

        public void grava_dados_dal( Modelo model)
        {
            try
            {
                dal = new DAL();

                dal.grava_dados(model);
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        public void exclui_dados_dal(Modelo modelo)
        {
            
            try
            {
                DAL dal = new DAL();

                dal.exclui_dados(modelo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
