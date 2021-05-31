using Dao;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class ProdutoCtrl
    {
        public Boolean SalvarProdutoNoArquivo(Produto _produto)
        {
            try
            {
                ProdutoDAO dao = new ProdutoDAO();

                return dao.SalvarProdutoNoArquivo(_produto);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Dictionary<Int64, Produto> ListarProdutosDoArquivo()
        {
            try
            {
                ProdutoDAO dao = new ProdutoDAO();

                return dao.ListarProdutosDoArquivo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
