using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class PessoaDAO
    {
        //Caminho completo com Diretório de nome do Arquivo
        String path = @"C:\Users\domin\source\repos\AppAula_2021_1\bdPessoa.csv";
        
        public Boolean SalvarPessoaNoArquivo(Pessoa _pessoa)
        {
            bool resultado = false;

            try
            {
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_pessoa.CPF + ";");
                escritor.Write(_pessoa.Nome + ";");
                escritor.Write(_pessoa.Idade + ";");
                escritor.Write(_pessoa.Email + ";");
                escritor.Write(_pessoa.Endereco + ";");

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
    
        public Dictionary<String, Pessoa> ListarPessoasDoArquivo()
        {
            Dictionary<String, Pessoa> tabelaPessoas = new Dictionary<String, Pessoa>();
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

                    Pessoa p = new Pessoa();

                    p.CPF = campos[0];
                    p.Nome = campos[1];
                    p.Idade = Convert.ToInt32(campos[2]);
                    p.Email = campos[3];
                    p.Endereco = campos[4];
                    
                    tabelaPessoas.Add(p.CPF, p);
                }

                leitor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabelaPessoas;
        }
    }
}
