using Dao;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class CompraCtrl
    {
        public Boolean SalvarCompraNoArquivo(Compra _compra)
        {
            try
            {
                CompraDAO dao = new CompraDAO();

                return dao.SalvarCompraNoArquivo(_compra);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Dictionary<String, Compra> ListarComprasDoArquivo()
        {
            try
            {
                CompraDAO dao = new CompraDAO();

                return dao.ListarComprasDoArquivo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
