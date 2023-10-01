using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class ItemVenda : Entidade
    {
        public const string ATRIBUTO_ID_ITEM_VENDA = "id_item_venda";
        public const string ATRIBUTO_ID_PRODUTO = "Produto_id_produto";
        public const string ATRIBUTO_QUANTIDADE_ITEM = "quantidade_item";
        public const string ATRIBUTO_TOTAL_ITEM = "total_item";
        public const string ATRIBUTO_VALOR_UNIDADE = "valor_unitario_item";
        public const string ATRIBUTO_ID_VENDA = "id_venda";

        public int id_item_venda { get; set; }
        public int id_produto { get; set; }
        public int quantidade_item { get; set; }
        public decimal total_item { get; set; }
        public decimal valor_unitario_item { get; set; }
        public int id_venda { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_ITEM_VENDA].Value = id_item_venda;
            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = id_produto;
            comando.Parameters[ATRIBUTO_QUANTIDADE_ITEM].Value = quantidade_item;
            comando.Parameters[ATRIBUTO_TOTAL_ITEM].Value = total_item;
            comando.Parameters[ATRIBUTO_VALOR_UNIDADE].Value = valor_unitario_item;
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = id_venda;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_ITEM_VENDA].Value = id_item_venda;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_item_venda = int.Parse(leitorDados[ATRIBUTO_ID_ITEM_VENDA].ToString());
            id_produto = int.Parse(leitorDados[ATRIBUTO_ID_PRODUTO].ToString());
            quantidade_item = int.Parse(leitorDados[ATRIBUTO_QUANTIDADE_ITEM].ToString());
            total_item = decimal.Parse(leitorDados[ATRIBUTO_TOTAL_ITEM].ToString());
            valor_unitario_item = decimal.Parse(leitorDados[ATRIBUTO_VALOR_UNIDADE].ToString());
            id_venda = int.Parse(leitorDados[ATRIBUTO_ID_VENDA].ToString());
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