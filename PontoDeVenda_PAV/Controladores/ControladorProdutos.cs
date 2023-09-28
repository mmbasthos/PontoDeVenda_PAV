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