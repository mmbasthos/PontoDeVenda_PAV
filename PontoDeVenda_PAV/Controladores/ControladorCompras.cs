using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorCompras : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM compra WHERE id_compra = @id_compra";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO compra VALUES (@id_compra, @data_compra, @hora_compra, @total_compra, @situacao_compra, @Fornecedor_id_fornecedor)";
        }

        protected override string criarComandoAtualizacao()
        {
            return "0";
        }

        protected override string criarComandoExclusao()
        {
            return "0";
        }

        public int compraAtual()
        {
            
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_compra FROM compra ORDER BY id_compra DESC LIMIT 1";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToInt32(resultado);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter compra atual: " + ex.Message);
            }

               BancodeDados.obterInstancia().desconectar();
            
            
        }

        public void AtualizarTotalCompra(int idCompra, decimal novoTotal)
        {
            BancodeDados.obterInstancia().conectar();
            try
            {
                string comandoSql = "UPDATE compra SET total_compra = @novoTotal WHERE id_compra = @idCompra";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@novoTotal", novoTotal);
                    comando.Parameters.AddWithValue("@idCompra", idCompra);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o total da compra: " + ex.Message);
            }

                BancodeDados.obterInstancia().desconectar();

        }

        public void AtualizarSituacaoCompra(int idCompra, string situacao)
        {
            
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "UPDATE compra SET situacao_compra = @situacao WHERE id_compra = @id_compra";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@situacao", situacao);
                    comando.Parameters.AddWithValue("@id_compra", idCompra);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar situação da compra: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        public decimal ObterTotalCompra(int idCompra)
        {
            BancodeDados.obterInstancia().conectar();

            try
            {
                string comandoSql = "SELECT total_compra FROM compra WHERE id_compra = @idCompra";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@idCompra", idCompra);

                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToDecimal(resultado);
                    }
                    else
                    {
                        return 0;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o total da compra: " + ex.Message);
            }
                BancodeDados.obterInstancia().desconectar();

        }

        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(new MySqlParameter(Compra.ATRIBUTO_ID_COMPRA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(Compra.ATRIBUTO_ID_FORNECEDOR_COMPRA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(Compra.ATRIBUTO_DATA_COMPRA, MySqlDbType.Date));
            comando.Parameters.Add(new MySqlParameter(Compra.ATRIBUTO_HORA_COMPRA, MySqlDbType.Time));
            comando.Parameters.Add(new MySqlParameter(Compra.ATRIBUTO_TOTAL_COMPRA, MySqlDbType.Decimal));
            comando.Parameters.Add(new MySqlParameter(Compra.ATRIBUTO_SITUACAO_COMPRA, MySqlDbType.VarChar));
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Compra.ATRIBUTO_ID_COMPRA, MySqlDbType.Int32);
        }
    }
}
