using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
    
    namespace PontoDeVenda_PAV.Controladores
    {
        public class ControladorCadastroProdutos : ControladorCadastro
        {

            protected override string criarComandoSelecao()
            {
                return "SELECT * FROM produto WHERE id_produto = @id_produto";
            }
            protected override string criarComandoInclusao()
            {
                return "INSERT INTO produto VALUES (@id_produto,@Fornecedor_id_fornecedor, @nome_produto, @quantidade_produto, @preco_produto, @id_classe)";
            }
            protected override string criarComandoAtualizacao()
            {
                return "UPDATE produto" +
                    " SET nome_produto             = @nome_produto," +
                    "     quantidade_produto       = @quantidade_produto," +
                    "     preco_produto            = @preco_produto," +
                    "     id_classe                = @id_classe," +
                    "     Fornecedor_id_Fornecedor = @Fornecedor_id_Fornecedor" +
                    " WHERE id_produto              = @id_produto";
        }
            protected override string criarComandoExclusao()
            {
                return "DELETE FROM produto WHERE id_produto = @id_produto";
            }
        public decimal ObterValorProdutoPorId(int id)
        {
            decimal valorProduto = -1; // Inicializamos com -1 para indicar que não foi encontrado

            try
            {

                string comandoSql = "SELECT preco_produto FROM produto WHERE id_produto = @id_produto";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@id_produto", id);

                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        valorProduto = Convert.ToDecimal(resultado);
                    }
                    else
                    {
                        // Trate o caso em que a consulta não retorna nenhum valor.
                        // Por exemplo, você pode retornar um valor padrão ou lançar uma exceção.
                        // throw new Exception("Nenhum valor de produto encontrado para o ID fornecido.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário (por exemplo, registre-a ou a lance novamente).
                // throw new Exception("Erro ao obter valor do produto: " + ex.Message);
            }
            return valorProduto;
        }

        public void AtualizarEstoque(int idProduto, int quantidade)
        {
            try
            {
                string comandoSql = "UPDATE produto SET quantidade_produto = quantidade_produto - @quantidade WHERE id_produto = @id_produto";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    comando.Parameters.AddWithValue("@id_produto", idProduto);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar estoque do produto: " + ex.Message);
            }
        }

        public void AumentarEstoque(int idProduto, int quantidade)
        {
            try
            {
                string comandoSql = "UPDATE produto SET quantidade_produto = quantidade_produto + @quantidade WHERE id_produto = @id_produto";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    comando.Parameters.AddWithValue("@id_produto", idProduto);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar estoque do produto: " + ex.Message);
            }
        }

        public string ObterNomeProdutoPorId(int id)
        {
            BancodeDados.obterInstancia().conectar();
            try
            {

                string comandoSql = "SELECT nome_produto FROM produto WHERE id_produto = @id_produto";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@id_produto", id);

                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToString(resultado);
                    }
                    else
                    {
                        throw new Exception("Nenhum produto encontrado para o ID fornecido.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter nome do produto: " + ex.Message);
            }
            BancodeDados.obterInstancia().desconectar();
        }
        protected override void criarParametros(MySqlCommand comando)
            {
                comando.Parameters.Add(Produtos.ATRIBUTO_ID_PRODUTO, MySqlDbType.Int32);
                comando.Parameters.Add(Produtos.ATRIBUTO_ID_FORNECEDOR, MySqlDbType.Int32);;
                comando.Parameters.Add(Produtos.ATRIBUTO_NOME_PRODUTO, MySqlDbType.VarChar);
                comando.Parameters.Add(Produtos.ATRIBUTO_QUANTIDADE_PRODUTO, MySqlDbType.Int32);
                comando.Parameters.Add(Produtos.ATRIBUTO_PRECO_PRODUTO, MySqlDbType.Decimal);
                comando.Parameters.Add(Produtos.ATRIBUTO_ID_CLASSE, MySqlDbType.Int32);
            }
            protected override void criarParametrosChavePrimaria(MySqlCommand comando)
            {
                comando.Parameters.Add(Produtos.ATRIBUTO_ID_PRODUTO, MySqlDbType.Int32);
            }
        }
    }