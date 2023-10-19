using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class ItemCompra : Entidade
    {
            public const string ATRIBUTO_ID_ITEM_COMPRA = "id_item_compra";
            public const string ATRIBUTO_ID_COMPRA = "Compra_id_compra";
            public const string ATRIBUTO_ID_PRODUTO = "Produto_id_produto";
            public const string ATRIBUTO_QUANTIDADE_COMPRA = "quantidade_compra";
            public const string ATRIBUTO_VALOR_UNITARIO_COMPRA = "valor_unitario_compra";
            public const string ATRIBUTO_TOTAL_ITEM_COMPRA = "total_item_compra";

            public int id_item_compra { get; set; }
            public int Compra_id_compra { get; set; }
            public int Produto_id_produto { get; set; }
            public int quantidade_compra { get; set; }
            public decimal valor_unitario_compra { get; set; }
            public decimal total_item_compra { get; set; }

            public override void transferirDados(MySqlCommand comando)
            {
                comando.Parameters[ATRIBUTO_ID_ITEM_COMPRA].Value = id_item_compra;
                comando.Parameters[ATRIBUTO_ID_COMPRA].Value = Compra_id_compra;
                comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = Produto_id_produto;
                comando.Parameters[ATRIBUTO_QUANTIDADE_COMPRA].Value = quantidade_compra;
                comando.Parameters[ATRIBUTO_VALOR_UNITARIO_COMPRA].Value = valor_unitario_compra;
                comando.Parameters[ATRIBUTO_TOTAL_ITEM_COMPRA].Value = total_item_compra;
            }

            public override void transferirDadosIdentificador(MySqlCommand comando)
            {
                comando.Parameters[ATRIBUTO_ID_ITEM_COMPRA].Value = id_item_compra;
                comando.Parameters[ATRIBUTO_ID_COMPRA].Value = Compra_id_compra;
            }

            public override void lerDados(MySqlDataReader leitorDados)
            {
                id_item_compra = int.Parse(leitorDados[ATRIBUTO_ID_ITEM_COMPRA].ToString());
                Compra_id_compra = int.Parse(leitorDados[ATRIBUTO_ID_COMPRA].ToString());
                Produto_id_produto = int.Parse(leitorDados[ATRIBUTO_ID_PRODUTO].ToString());
                quantidade_compra = int.Parse(leitorDados[ATRIBUTO_QUANTIDADE_COMPRA].ToString());
                valor_unitario_compra = decimal.Parse(leitorDados[ATRIBUTO_VALOR_UNITARIO_COMPRA].ToString());
                total_item_compra = decimal.Parse(leitorDados[ATRIBUTO_TOTAL_ITEM_COMPRA].ToString());
            }
     }
 }
