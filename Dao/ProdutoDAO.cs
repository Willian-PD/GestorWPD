using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class ProdutoDAO
    {        //Caminho completo com Diretório de nome do Arquivo
        String path = @"C:\Users\domin\source\repos\AppAula_2021_1\bdProduto.csv";

        public Boolean SalvarProdutoNoArquivo(Produto _produto)
        {
            bool resultado = false;

            try
            {
                StreamWriter escritor = new StreamWriter(path, true);
                
                escritor.Write(_produto.codigo + ";");
                escritor.Write(_produto.tipo + ";");
                escritor.Write(_produto.marca + ";");

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

        public Dictionary<Int64, Produto> ListarProdutosDoArquivo()
        {
            Dictionary<Int64, Produto> tabelaProdutos = new Dictionary<Int64, Produto>();
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

                    Produto p = new Produto();

                    p.codigo = Convert.ToInt32(campos[0]);
                    p.tipo = campos[1];
                    p.marca = campos[2];

                    tabelaProdutos.Add(p.codigo, p);
                }

                leitor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabelaProdutos;
        }
    }
}
