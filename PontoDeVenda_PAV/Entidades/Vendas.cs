using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class Vendas : Entidade
    {

        public const string ATRIBUTO_ID_VENDA = "id_venda";
        public const string ATRIBUTO_ID_CLIENTE_VENDA = "Cliente_id_cliente";
        public const string ATRIBUTO_DATA_VENDA = "data_venda";
        public const string ATRIBUTO_HORA_VENDA = "hora_venda";
        public const string ATRIBUTO_TOTAL_VENDA = "total_venda";
        public const string ATRIBUTO_SITUACAO_VENDA = "situacao_venda";

        public int id_venda { get; set; }
        public int id_cliente_venda { get; set; }
        public DateTime data_venda { get; set; }
        public TimeSpan hora_venda { get; set; }
        public decimal total_venda { get; set; }
        public string situacao_venda { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = id_venda;
            comando.Parameters[ATRIBUTO_ID_CLIENTE_VENDA].Value = id_cliente_venda;
            comando.Parameters[ATRIBUTO_DATA_VENDA].Value = data_venda;
            comando.Parameters[ATRIBUTO_HORA_VENDA].Value = hora_venda;
            comando.Parameters[ATRIBUTO_TOTAL_VENDA].Value = total_venda;
            comando.Parameters[ATRIBUTO_SITUACAO_VENDA].Value = situacao_venda;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = id_venda;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_venda = int.Parse(leitorDados[ATRIBUTO_ID_VENDA].ToString());
            id_cliente_venda = int.Parse(leitorDados[ATRIBUTO_ID_CLIENTE_VENDA].ToString());
            data_venda = DateTime.Parse(leitorDados[ATRIBUTO_DATA_VENDA].ToString());
            hora_venda = TimeSpan.Parse(leitorDados[ATRIBUTO_HORA_VENDA].ToString());
            total_venda = decimal.Parse(leitorDados[ATRIBUTO_TOTAL_VENDA].ToString());
            situacao_venda = leitorDados[ATRIBUTO_SITUACAO_VENDA].ToString();

        }


    }
}
