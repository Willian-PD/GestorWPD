using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class VendaDAO
    {        //Caminho completo com Diretório de nome do Arquivo
        String path = @"C:\Users\domin\source\repos\AppAula_2021_1\bdVenda.csv";

        public Boolean SalvarVendaNoArquivo(Venda _venda)
        {
            bool resultado = false;

            try
            {
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_venda.codigo + ";");
                escritor.Write(_venda.cliente + ";");
                escritor.Write(_venda.totalDeProdutos + ";");
                escritor.Write(_venda.local + ";");
                escritor.Write(_venda.valor + ";");

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

        public Dictionary<Int64, Venda> ListarVendasDoArquivo()
        {
            Dictionary<Int64, Venda> tabelaVendas = new Dictionary<Int64, Venda>();
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

                    Venda p = new Venda();

                    p.codigo = Convert.ToInt32(campos[0]);
                    p.cliente = campos[1];
                    p.totalDeProdutos = Convert.ToInt32(campos[2]);
                    p.local = campos[3];
                    p.valor = Convert.ToInt32(campos[4]);

                    tabelaVendas.Add(p.codigo, p);
                }

                leitor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabelaVendas;
        }
    }
}
