using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class Caixa : Entidade
    {
        public const string ATRIBUTO_ID_CAIXA = "id_caixa";
        public const string ATRIBUTO_NOME_CAIXA = "nome_caixa";
        public const string ATRIBUTO_SALDO_CAIXA = "saldo_caixa";

        public int id_caixa { get; set; }
        public string nome_caixa { get; set; }
        public decimal saldo_caixa { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = id_caixa;
            comando.Parameters[ATRIBUTO_NOME_CAIXA].Value = nome_caixa;
            comando.Parameters[ATRIBUTO_SALDO_CAIXA].Value = saldo_caixa;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = id_caixa;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_caixa = int.Parse(leitorDados[ATRIBUTO_ID_CAIXA].ToString());
            nome_caixa = leitorDados[ATRIBUTO_NOME_CAIXA].ToString();
            saldo_caixa = decimal.Parse(leitorDados[ATRIBUTO_SALDO_CAIXA].ToString());
        }

    }
}
