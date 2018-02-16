using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace video_aula_varios_exemplos
{
    class Business
    {
        public DataTable lista_dados_bus()
        {
            try
            {
                Data data = new Data();
                DataTable table = new DataTable();
                table = data.lista_dados_data();
                return table;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void grava_dados_bus(Model model)
        {
            try
            {
                Data data = new Data();
                data.grava_dados_data(model);
                
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void deleta_dados_bus()
        {
            Data data = new Data();
            Model model = new Model();
            data.deleta_dados_data(model);
        }
    }
}
