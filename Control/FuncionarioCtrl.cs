using Dao;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class FuncionarioCtrl
    {
        public Boolean SalvarFuncionarioNoArquivo(Funcionario _funcionario)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();

                return dao.SalvarFuncionarioNoArquivo(_funcionario);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Dictionary<String, Funcionario> ListarFuncionariosDoArquivo()
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();

                return dao.ListarFuncionariosDoArquivo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
