using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
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
            comando.Parameters.Add(ItemVenda.ATRIBUTO_ID_ITEM_VENDA, MySqlDbType.Int32);
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