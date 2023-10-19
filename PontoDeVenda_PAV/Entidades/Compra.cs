using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class Compra : Entidade
    {
        public const string ATRIBUTO_ID_COMPRA = "id_compra";
        public const string ATRIBUTO_ID_FORNECEDOR_COMPRA = "Fornecedor_id_fornecedor";
        public const string ATRIBUTO_DATA_COMPRA = "data_compra";
        public const string ATRIBUTO_HORA_COMPRA = "hora_compra";
        public const string ATRIBUTO_TOTAL_COMPRA = "total_compra";
        public const string ATRIBUTO_SITUACAO_COMPRA = "situacao_compra";

        public int id_compra { get; set; }
        public int id_fornecedor_compra { get; set; }
        public DateTime data_compra { get; set; }
        public TimeSpan hora_compra { get; set; }
        public decimal total_compra { get; set; }
        public string situacao_compra { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_COMPRA].Value = id_compra;
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR_COMPRA].Value = id_fornecedor_compra;
            comando.Parameters[ATRIBUTO_DATA_COMPRA].Value = data_compra;
            comando.Parameters[ATRIBUTO_HORA_COMPRA].Value = hora_compra;
            comando.Parameters[ATRIBUTO_TOTAL_COMPRA].Value = total_compra;
            comando.Parameters[ATRIBUTO_SITUACAO_COMPRA].Value = situacao_compra;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_COMPRA].Value = id_compra;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_compra = int.Parse(leitorDados[ATRIBUTO_ID_COMPRA].ToString());
            id_fornecedor_compra = int.Parse(leitorDados[ATRIBUTO_ID_FORNECEDOR_COMPRA].ToString());
            data_compra = DateTime.Parse(leitorDados[ATRIBUTO_DATA_COMPRA].ToString());
            hora_compra = TimeSpan.Parse(leitorDados[ATRIBUTO_HORA_COMPRA].ToString());
            total_compra = decimal.Parse(leitorDados[ATRIBUTO_TOTAL_COMPRA].ToString());
            situacao_compra = leitorDados[ATRIBUTO_SITUACAO_COMPRA].ToString();

        }

    }
}
