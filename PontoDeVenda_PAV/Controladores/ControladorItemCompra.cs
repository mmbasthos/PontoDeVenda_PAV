using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorItemCompra : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM item_compra WHERE id_item_compra = @id_item_compra";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO item_compra VALUES (@id_item_compra, @Compra_id_compra, @Produto_id_produto, @quantidade_compra, @valor_unitario_compra, @total_item_compra)";
        }

        protected override string criarComandoAtualizacao()
        {
            return "0";
        }

        protected override string criarComandoExclusao()
        {
            return "DELETE FROM item_compra WHERE id_item_compra = @id_item_compra";
        }

        public List<ItemCompra> ObterItensDaCompra(int idCompra)
        {
            List<ItemCompra> itens = new List<ItemCompra>();

            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT * FROM item_compra WHERE Compra_id_compra = @idCompra";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@idCompra", idCompra);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ItemCompra item = new ItemCompra();
                            item.id_item_compra = Convert.ToInt32(reader["id_item_compra"]);
                            item.Compra_id_compra = Convert.ToInt32(reader["Compra_id_compra"]);
                            item.Produto_id_produto = Convert.ToInt32(reader["Produto_id_produto"]);
                            item.quantidade_compra = Convert.ToInt32(reader["quantidade_compra"]);
                            item.valor_unitario_compra = Convert.ToDecimal(reader["valor_unitario_compra"]);
                            item.total_item_compra = Convert.ToDecimal(reader["total_item_compra"]);

                            itens.Add(item);
                        }
                    }
                }

                return itens;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter itens da compra: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        public decimal ObterTotalItemCompra(int idItemCompra)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT valor_unitario_compra * quantidade_compra " +
                                    "FROM item_compra " +
                                    "WHERE id_item_compra = @id_item_compra";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@id_item_compra", idItemCompra);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        return Convert.ToDecimal(resultado);
                    }
                    else
                    {
                        return 0m; // Se não houver resultado, retorna 0
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o total do item da compra: " + ex.Message);
                return 0m; // Em caso de erro, retorna 0
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }

        }

        public void Deletar(int idProduto, int idCompra)
        {
            BancodeDados.obterInstancia().conectar();

            string comandoSql = "DELETE FROM item_compra WHERE Produto_id_produto = @id_produto AND Compra_id_compra = @Compra_id_compra";

            using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
            {
                comando.Parameters.AddWithValue("@id_produto", idProduto);
                comando.Parameters.AddWithValue("@Compra_id_compra", idCompra);

                comando.ExecuteNonQuery();
            }

            BancodeDados.obterInstancia().desconectar();
        }

        public int ObterIdItemCompra(int idProduto, int idCompra)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_item_compra FROM item_compra WHERE Produto_id_produto = @idProduto AND Compra_id_compra = @idCompra";
                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idCompra", idCompra);
                    object result = comando.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Retorna -1 se o item de compra não for encontrado
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter ID do item de compra: " + ex.Message);
                return -1;
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(new MySqlParameter(ItemCompra.ATRIBUTO_ID_ITEM_COMPRA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(ItemCompra.ATRIBUTO_ID_COMPRA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(ItemCompra.ATRIBUTO_ID_PRODUTO, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(ItemCompra.ATRIBUTO_QUANTIDADE_COMPRA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(ItemCompra.ATRIBUTO_VALOR_UNITARIO_COMPRA, MySqlDbType.Decimal));
            comando.Parameters.Add(new MySqlParameter(ItemCompra.ATRIBUTO_TOTAL_ITEM_COMPRA, MySqlDbType.Decimal));
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(new MySqlParameter(ItemCompra.ATRIBUTO_ID_ITEM_COMPRA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(ItemCompra.ATRIBUTO_ID_COMPRA, MySqlDbType.Int32));
        }
    }
}