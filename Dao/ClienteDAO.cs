using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class ClienteDAO
    {
        //Caminho completo com Diretório de nome do Arquivo
        String path = @"C:\Users\domin\source\repos\AppAula_2021_1\bdCliente.csv";

        public Boolean SalvarClienteNoArquivo(Cliente _cliente)
        {
            bool resultado = false;

            try
            {
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_cliente.codigo + ";");
                escritor.Write(_cliente.CPF + ";");
                escritor.Write(_cliente.Nome + ";");
                escritor.Write(_cliente.Idade + ";");
                escritor.Write(_cliente.Email + ";");
                escritor.Write(_cliente.Endereco + ";");
                escritor.Write(_cliente.preferencias + ";");
                escritor.Write(_cliente.totalDeCompras + ";");

                //Preparar o arquivo para a próxima escrita, ou seja, adicionar quebra de linha
                escritor.WriteLine();

                escritor.Close();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return resultado;
        }

        public Dictionary<String, Cliente> ListarClientesDoArquivo()
        {
            Dictionary<String, Cliente> tabelaClientes = new Dictionary<String, Cliente>();
            try
            {
                StreamReader leitor = new StreamReader(path);

                String arquivo = leitor.ReadToEnd();

                char[] divLinhas = { '\n' };//Linhas do Arquivo
                char[] divCampos = { ';' };//Colunas do Registro no Arquivo

                string[] linhas = arquivo.Split(divLinhas);//Divide todo arquivos em linhas (registros do arquivo)
                for (int i = 0; i < linhas.Length - 1; i++)//-1 por causa da linha em branco do arquivo
                {
                    string[] campos = linhas[i].Split(divCampos);

                    Cliente p = new Cliente();

                    p.codigo = campos[0];
                    p.CPF = campos[1];
                    p.Nome = campos[2];
                    p.Idade = Convert.ToInt32(campos[3]);
                    p.Email = campos[4];
                    p.Endereco = campos[5];
                    p.preferencias = campos[6];
                    p.totalDeCompras = Convert.ToInt32(campos[7]);

                    tabelaClientes.Add(p.CPF, p);
                }

                leitor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabelaClientes;
        }
    }
}
