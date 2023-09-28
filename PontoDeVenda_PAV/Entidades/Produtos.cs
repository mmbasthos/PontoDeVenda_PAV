using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class Produtos : Entidade 
    {
        public const string ATRIBUTO_ID_PRODUTO = "id_produto";
        public const string ATRIBUTO_ID_FORNECEDOR = "Fornecedor_id_fornecedor";
        public const string ATRIBUTO_NOME_PRODUTO = "nome_produto";
        public const string ATRIBUTO_QUANTIDADE_PRODUTO = "quantidade_produto";
        public const string ATRIBUTO_PRECO_PRODUTO = "preco_produto";
        public const string ATRIBUTO_ID_CLASSE = "id_classe";



        public int id_produto { get; set; }
        public int id_fornecedor { get; set; }
        public string nome_produto { get; set; }
        public int quantidade_produto { get; set; }
        public decimal preco_produto { get; set; }

        public int id_classe { get; set; }


        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = id_produto;
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR].Value = id_fornecedor;
            comando.Parameters[ATRIBUTO_NOME_PRODUTO].Value = nome_produto;

            comando.Parameters[ATRIBUTO_QUANTIDADE_PRODUTO].Value = quantidade_produto;
            comando.Parameters[ATRIBUTO_PRECO_PRODUTO].Value = preco_produto;


            comando.Parameters[ATRIBUTO_ID_CLASSE].Value = id_classe;
        }


        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = id_produto;
           
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_produto = int.Parse(leitorDados[ATRIBUTO_ID_PRODUTO].ToString());
            id_fornecedor = int.Parse(leitorDados[ATRIBUTO_ID_FORNECEDOR].ToString());
            nome_produto = leitorDados[ATRIBUTO_NOME_PRODUTO].ToString();


            quantidade_produto = int.Parse(leitorDados[ATRIBUTO_QUANTIDADE_PRODUTO].ToString());
            preco_produto = decimal.Parse(leitorDados[ATRIBUTO_PRECO_PRODUTO].ToString());


            id_classe = int.Parse(leitorDados[ATRIBUTO_ID_CLASSE].ToString());

        }
    }
}
