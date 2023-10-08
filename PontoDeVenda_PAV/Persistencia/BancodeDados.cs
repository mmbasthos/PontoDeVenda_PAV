using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PontoDeVenda_PAV.Persistencia
{
    public class BancodeDados
    {

        // teste git

        private int porta = 3306;
        private string servidor = "localhost";
        private string nomeBancoDados = "sys";
        private MySqlConnection conexao;
        private MySqlTransaction transacao;
        private static BancodeDados instancia = null;

        private string criarStringConexao(string usuario, string senha)
        {
            return "server = " + servidor +
                   ";port = " + porta.ToString() +
                   ";user id = " + usuario +
                   ";database = " + nomeBancoDados +
                   ";password = " + senha;
        }

        public void conectar(string usuario, string senha)
        {
            try
            {
                if (conexao == null || conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao = new MySqlConnection(criarStringConexao(usuario, senha));
                    conexao.Open();
                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void conectar()
        {
            //usbw é a senha usada no USBWebServer
            conectar("root", "18042001Go@5");
        }

        public void desconectar()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                conexao.Dispose();
                
            }
        }

        public static BancodeDados obterInstancia()
        {
            if (instancia == null)
            {
                instancia = new BancodeDados();
            }
            return instancia;
        }

        public MySqlConnection obterConexao()
        {
            return conexao;
        }

        public void iniciarTransacao()
        {
            transacao = conexao.BeginTransaction();
        }

        public void confirmarTransacao()
        {
            if (transacao != null)
            {
                transacao.Commit();
                transacao.Dispose();
            }
        }

        public void cancelarTransacao()
        {
            try
            {
                if (transacao != null && transacao.Connection != null && transacao.Connection.State == System.Data.ConnectionState.Open)
                {
                    transacao.Rollback();
                    transacao.Dispose();
                    Console.WriteLine("Transação cancelada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Não foi possível cancelar a transação: transação não ativa.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cancelar transação: " + ex.Message);
            }
        }



    }
}
