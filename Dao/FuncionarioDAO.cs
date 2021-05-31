using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class FuncionarioDAO
    {        //Caminho completo com Diretório de nome do Arquivo
        String path = @"C:\Users\domin\source\repos\AppAula_2021_1\bdFuncionario.csv";

        public Boolean SalvarFuncionarioNoArquivo(Funcionario _funcionario)
        {
            bool resultado = false;

            try
            {
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_funcionario.matricula + ";");
                escritor.Write(_funcionario.CPF + ";");
                escritor.Write(_funcionario.Nome + ";");
                escritor.Write(_funcionario.Idade + ";");
                escritor.Write(_funcionario.Email + ";");
                escritor.Write(_funcionario.Endereco + ";");
                escritor.Write(_funcionario.salario + ";");
                escritor.Write(_funcionario.totalDeVendas + ";");

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

        public Dictionary<String, Funcionario> ListarFuncionariosDoArquivo()
        {
            Dictionary<String, Funcionario> tabelaFuncionarios = new Dictionary<String, Funcionario>();
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

                    Funcionario p = new Funcionario();

                    p.matricula = campos[0];
                    p.CPF = campos[1];
                    p.Nome = campos[2];
                    p.Idade = Convert.ToInt32(campos[3]);
                    p.Email = campos[4];
                    p.Endereco = campos[5];
                    p.salario = Convert.ToInt32(campos[6]);
                    p.totalDeVendas = Convert.ToInt32(campos[7]);

                    tabelaFuncionarios.Add(p.CPF, p);
                }

                leitor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabelaFuncionarios;
        }
    }
}
