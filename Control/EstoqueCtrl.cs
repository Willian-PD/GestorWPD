using Dao;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class EstoqueCtrl
    {
        public Boolean SalvarEstoqueNoArquivo(Estoque _estoque)
        {
            try
            {
                EstoqueDAO dao = new EstoqueDAO();

                return dao.SalvarEstoqueNoArquivo(_estoque);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Dictionary<String, Estoque> ListarEstoquesDoArquivo()
        {
            try
            {
                EstoqueDAO dao = new EstoqueDAO();

                return dao.ListarEstoquesDoArquivo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
