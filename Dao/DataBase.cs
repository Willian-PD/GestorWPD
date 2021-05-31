using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DataBase
    {
        private static String sqliteConnection = @"C:\Users\domin\OneDrive\Documentos\Programas\C#Desktop\cpti_2021_1sem\GestorWPD_DB.db";
        private static SQLiteConnection conexao;

        public DataBase() { }

        public static void CriarBancoSQLite() {
            try {
                SQLiteConnection.CreateFile(@"C:\Users\domin\OneDrive\Documentos\Programas\C#Desktop\cpti_2021_1sem\GestorWPD_DB.db");
            }
            catch (Exception ex) {
                throw new Exception("Erro ao criar Base de Dados: " + ex.Message);
            }
        }

        private static void AbrirConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.ConnectionString = sqliteConnection;
                        conexao.Open();
                    }
                }
                else
                {
                    conexao = new SqlCeConnection(strConn);
                    conexao.Open();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO ABRIR CONEXÃO: " + ex.Message);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO FECHAR CONEXÃO: " + ex.Message);
            }
        }

        public static DataTable GetClientes() {
            try
            {
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO FECHAR CONEXÃO: " + ex.Message);
            }
        }
    }
}
