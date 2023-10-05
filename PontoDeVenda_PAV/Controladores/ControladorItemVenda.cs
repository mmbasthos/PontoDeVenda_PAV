using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorItemVenda : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM item_venda WHERE id_item_venda = @id_item_venda";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO item_venda VALUES (@id_item_venda, @Produto_id_produto, @quantidade_item, @total_item, @valor_unitario_item, @id_venda)";
        }

        protected override string criarComandoAtualizacao()
        {
            return "0";
        }

        protected override string criarComandoExclusao()
        {
            return "DELETE FORM item_venda WHERE id_item_venda = @id_item_venda";
        }

        public List<ItemVenda> ObterItensDaVenda(int idVenda)
        {
            List<ItemVenda> itens = new List<ItemVenda>();

            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT * FROM item_venda WHERE id_venda = @id_venda";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@id_venda", idVenda);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ItemVenda item = new ItemVenda();
                            item.id_produto = Convert.ToInt32(reader["Produto_id_produto"]);
                            item.id_venda = Convert.ToInt32(reader["id_venda"]);
                            item.quantidade_item = Convert.ToInt32(reader["quantidade_item"]);
                            item.valor_unitario_item = Convert.ToDecimal(reader["valor_unitario_item"]);
                            item.total_item = Convert.ToDecimal(reader["total_item"]);

                            itens.Add(item);
                        }
                    }
                }

                return itens;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter itens da venda: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }


        public decimal ObterTotalItemVenda(int idProduto, int idVenda)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT valor_unitario_item * quantidade_item " +
                                    "FROM item_venda " +
                                    "WHERE Produto_id_produto = @id_produto " +
                                    "AND id_venda = @id_venda";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@id_produto", idProduto);
                    comando.Parameters.AddWithValue("@id_venda", idVenda);

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
                MessageBox.Show("Erro ao obter o total do item da venda: " + ex.Message);
                return 0m; // Em caso de erro, retorna 0
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }

        }




        public void Deletar(int idProduto, int idVenda)
        {
            BancodeDados.obterInstancia().conectar();

            string comandoSql = "DELETE FROM item_venda WHERE Produto_id_produto = @id_produto AND id_venda = @id_venda";

            using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
            {
                comando.Parameters.AddWithValue("@id_produto", idProduto);
                comando.Parameters.AddWithValue("@id_venda", idVenda);

                comando.ExecuteNonQuery();
            }

            BancodeDados.obterInstancia().desconectar();
        }

        public int ObterIdItemVenda(int idProduto, int idVenda)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_item_venda FROM item_venda WHERE Produto_id_produto = @idProduto AND id_venda = @idVenda";
                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@idProduto", idProduto);
                    comando.Parameters.AddWithValue("@idVenda", idVenda);
                    object result = comando.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Retorna -1 se o item de venda não for encontrado
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter ID do item de venda: " + ex.Message);
                return -1;
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }


        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(new MySqlParameter(ItemVenda.ATRIBUTO_ID_ITEM_VENDA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(ItemVenda.ATRIBUTO_ID_PRODUTO, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(ItemVenda.ATRIBUTO_QUANTIDADE_ITEM, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(ItemVenda.ATRIBUTO_TOTAL_ITEM, MySqlDbType.Decimal));
            comando.Parameters.Add(new MySqlParameter(ItemVenda.ATRIBUTO_VALOR_UNIDADE, MySqlDbType.Decimal));
            comando.Parameters.Add(new MySqlParameter(ItemVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32));

        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(new MySqlParameter(ItemVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(ItemVenda.ATRIBUTO_ID_ITEM_VENDA, MySqlDbType.Int32));
        }
    }
}

/*
Table: item_venda
Columns:
id_item_venda int AI PK 
Produto_id_produto int 
quantidade_item int 
total_item decimal(10,2) 
valor_unitario_item decimal(10,2) 
id_venda int PK
*/