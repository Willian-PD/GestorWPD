using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class EstoqueDAO
    {        //Caminho completo com Diretório de nome do Arquivo
        String path = @"C:\Users\domin\source\repos\AppAula_2021_1\bdEstoque.csv";

        public Boolean SalvarEstoqueNoArquivo(Estoque _estoque)
        {
            bool resultado = false;

            try
            {
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_estoque.secao + ";");
                escritor.Write(_estoque.totalDeProdutos + ";");
                escritor.Write(_estoque.local + ";");

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

        public Dictionary<String, Estoque> ListarEstoquesDoArquivo()
        {
            Dictionary<String, Estoque> tabelaEstoques = new Dictionary<String, Estoque>();
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

                    Estoque p = new Estoque();

                    p.secao = campos[0];
                    p.totalDeProdutos = Convert.ToInt32(campos[1]);
                    p.local = campos[2];

                    tabelaEstoques.Add(p.secao, p);
                }

                leitor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabelaEstoques;
        }
    }
}
