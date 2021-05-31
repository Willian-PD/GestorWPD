using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class CompraDAO
    {        //Caminho completo com Diretório de nome do Arquivo
        String path = @"C:\Users\domin\source\repos\AppAula_2021_1\bdCompra.csv";

        public Boolean SalvarCompraNoArquivo(Compra _compra)
        {
            bool resultado = false;

            try
            {
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_compra.codigo + ";");
                escritor.Write(_compra.fornecedor + ";");
                escritor.Write(_compra.totalDeProdutos + ";");
                escritor.Write(_compra.local + ";");
                escritor.Write(_compra.valor + ";");

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

        public Dictionary<String, Compra> ListarComprasDoArquivo()
        {
            Dictionary<String, Compra> tabelaCompras = new Dictionary<String, Compra>();
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

                    Compra p = new Compra();

                    p.codigo = campos[0];
                    p.fornecedor = campos[1];
                    p.totalDeProdutos = Convert.ToInt32(campos[2]);
                    p.tipoDeProduto = campos[3];
                    p.valor = (float)Convert.ToDouble(campos[4]);

                    tabelaCompras.Add(p.codigo, p);
                }

                leitor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabelaCompras;
        }
    }
}
