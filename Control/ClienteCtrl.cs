using Dao;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class ClienteCtrl
    {
        public Boolean SalvarClienteNoArquivo(Cliente _cliente)
        {
            try
            {
                ClienteDAO dao = new ClienteDAO();

                return dao.SalvarClienteNoArquivo(_cliente);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Dictionary<String, Cliente> ListarClientesDoArquivo()
        {
            try
            {
                ClienteDAO dao = new ClienteDAO();

                return dao.ListarClientesDoArquivo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
