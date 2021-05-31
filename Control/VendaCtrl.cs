using Dao;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class VendaCtrl
    {
        public Boolean SalvarVendaNoArquivo(Venda _venda)
        {
            try
            {
                VendaDAO dao = new VendaDAO();

                return dao.SalvarVendaNoArquivo(_venda);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Dictionary<Int64, Venda> ListarVendasDoArquivo()
        {
            try
            {
                VendaDAO dao = new VendaDAO();

                return dao.ListarVendasDoArquivo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
