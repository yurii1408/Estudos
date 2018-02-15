using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;

namespace Crud3CamadasFormSQLServer_TESTE2
{
    class Business
    {
        Data data = new Data();
        Model model = new Model();


        public DataTable lista_bairros_bus()
        {
            try
            {
                DataTable table;
                table = data.lista_bairros_data();
                return table;
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void insere_bairro_bus(Model model)
        {
            try
            {
                data.insere_bairros_data(model);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void deleta_bairros_bus(Model model)
        {
            try
            {
                data.deleta_bairros_data(model);
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        public void altera_bairros_bus(Model model)
        {
            data.altera_bairros_data(model);

        }

        public Model pesquisa_bairros_bus(string pesquisa)
        {
            try
            {
                
                return data.pesquisa_bairros_data(pesquisa);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}