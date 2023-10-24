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

   


        public int ObterCaixaAtual()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_caixa FROM caixa ORDER BY id_caixa DESC LIMIT 1";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToInt32(resultado);
                    }
                    else
                    {
                        // Trate o caso em que a consulta não retorna nenhum valor.
                        // Por exemplo, você pode retornar um valor padrão ou lançar uma exceção.
                        throw new Exception("Nenhum caixa encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário (por exemplo, registre-a ou a lance novamente).
                throw new Exception("Erro ao obter caixa atual: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }


        public int caixaAtual()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_caixa FROM caixa ORDER BY id_caixa DESC LIMIT 1";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToInt32(resultado);
                    }
                    else
                    {
                        // Trate o caso em que a consulta não retorna nenhum valor.
                        // Por exemplo, você pode retornar um valor padrão ou lançar uma exceção.
                        throw new Exception("Nenhum caixa encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário (por exemplo, registre-a ou a lance novamente).
                throw new Exception("Erro ao obter caixa atual: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        /*
        public void aumentarSaldoCaixa(int idCaixa, decimal valor)
        {
            BancodeDados.obterInstancia().conectar();
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
        }*/

        public string ObterNomeCaixa(int idCaixa)
        {
            BancodeDados.obterInstancia().conectar();
            string comandoSql = "SELECT nome_caixa FROM caixa WHERE id_caixa = @idCaixa";
            MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao());
            comando.Parameters.AddWithValue("@idCaixa", idCaixa);

            try
            {
                string nomeCaixa = comando.ExecuteScalar() as string;
                return nomeCaixa;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o nome do caixa: " + ex.Message);
            }
            BancodeDados.obterInstancia().desconectar();
        }

        public void AtualizarSaldoCaixa(int idCaixa, decimal valor)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                string comandoSql = "UPDATE caixa SET saldo_caixa = saldo_caixa + @valor WHERE id_caixa = @idCaixa";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@valor", valor);
                    comando.Parameters.AddWithValue("@idCaixa", idCaixa);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o saldo do caixa: " + ex.Message);
            }
            BancodeDados.obterInstancia().desconectar();
        }

        public void AtualizarSaldoCaixaCompra(int idCaixa, decimal valor)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                string comandoSql = "UPDATE caixa SET saldo_caixa = saldo_caixa - @valor WHERE id_caixa = @idCaixa";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@valor", valor);
                    comando.Parameters.AddWithValue("@idCaixa", idCaixa);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o saldo do caixa: " + ex.Message);
            }
            BancodeDados.obterInstancia().desconectar();
        }




        /*
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
        */
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
