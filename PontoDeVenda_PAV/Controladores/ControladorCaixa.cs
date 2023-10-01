using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Controladores;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System;
using System.Data;
using System.Windows.Forms;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorCaixa : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM caixa WHERE id_caixa = @id_caixa";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO caixa VALUES (@id_caixa, @nome_caixa, @saldo_caixa)";
        }

        protected override string criarComandoAtualizacao()
        {
            return "0";
        }

        public void aumentarSaldoCaixa(int idCaixa, decimal valor)
        {
            
            string comandoSql = "UPDATE caixa SET saldo_caixa = saldo_caixa + @valor WHERE id_caixa = @idCaixa";
            MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao());
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@idCaixa", idCaixa);

            try
            {
                BancodeDados.obterInstancia().iniciarTransacao();
                comando.ExecuteNonQuery();
                BancodeDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancodeDados.obterInstancia().cancelarTransacao();
                throw new Exception("Erro ao aumentar saldo do caixa: " + ex.Message);
            }
        }

        public void diminuirSaldoCaixa(int idCaixa, decimal valor)
        {
            string comandoSql = "UPDATE caixa SET saldo_caixa = saldo_caixa - @valor WHERE id_caixa = @idCaixa";
            MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao());
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@idCaixa", idCaixa);

            try
            {
                BancodeDados.obterInstancia().iniciarTransacao();
                comando.ExecuteNonQuery();
                BancodeDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancodeDados.obterInstancia().cancelarTransacao();
                throw new Exception("Erro ao diminuir saldo do caixa: " + ex.Message);
            }
        }

        protected override string criarComandoExclusao()
        {
            return "0";
        }

        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Caixa.ATRIBUTO_ID_CAIXA, MySqlDbType.Int32);
            comando.Parameters.Add(Caixa.ATRIBUTO_NOME_CAIXA, MySqlDbType.VarChar);
            comando.Parameters.Add(Caixa.ATRIBUTO_SALDO_CAIXA, MySqlDbType.Decimal);
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Caixa.ATRIBUTO_ID_CAIXA, MySqlDbType.Int32);
        }

    }
}
