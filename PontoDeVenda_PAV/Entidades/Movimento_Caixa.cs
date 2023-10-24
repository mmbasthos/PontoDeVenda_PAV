using MySql.Data.MySqlClient;
using System;

namespace PontoDeVenda_PAV.Entidades
{
    public class MovimentoCaixa : Entidade
    {
        public const string ATRIBUTO_ID_MOVIMENTO_CAIXA = "id_movimento_caixa";
        public const string ATRIBUTO_DATA_MOVIMENTO = "data_movimento";
        public const string ATRIBUTO_HORA_MOVIMENTO = "hora_movimento";
        public const string ATRIBUTO_DESCRICAO_MOVIMENTO = "descricao_movimento";
        public const string ATRIBUTO_TIPO_MOVIMENTO = "tipo_movimento";
        public const string ATRIBUTO_VALOR_MOVIMENTO = "valor_movimento";
        public const string ATRIBUTO_CAIXA_ID_CAIXA = "Caixa_id_caixa";
        public const string FORMA_PAGAMENTO = "formapagamento";
        public int id_movimento_caixa { get; set; }
        public DateTime data_movimento { get; set; }
        public TimeSpan hora_movimento { get; set; }
        public string descricao_movimento { get; set; }
        public string tipo_movimento { get; set; }
        public decimal valor_movimento { get; set; }
        public int Caixa_id_caixa { get; set; }
        public string formapagamento { get; set; }  

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_MOVIMENTO_CAIXA].Value = id_movimento_caixa;
            comando.Parameters[ATRIBUTO_DATA_MOVIMENTO].Value = data_movimento;
            comando.Parameters[ATRIBUTO_HORA_MOVIMENTO].Value = hora_movimento;
            comando.Parameters[ATRIBUTO_DESCRICAO_MOVIMENTO].Value = descricao_movimento;
            comando.Parameters[ATRIBUTO_TIPO_MOVIMENTO].Value = tipo_movimento;
            comando.Parameters[ATRIBUTO_VALOR_MOVIMENTO].Value = valor_movimento;
            comando.Parameters[ATRIBUTO_CAIXA_ID_CAIXA].Value = Caixa_id_caixa;
            comando.Parameters[FORMA_PAGAMENTO].Value = formapagamento;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_MOVIMENTO_CAIXA].Value = id_movimento_caixa;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_movimento_caixa = int.Parse(leitorDados[ATRIBUTO_ID_MOVIMENTO_CAIXA].ToString());
            data_movimento = DateTime.Parse(leitorDados[ATRIBUTO_DATA_MOVIMENTO].ToString());
            hora_movimento = TimeSpan.Parse(leitorDados[ATRIBUTO_HORA_MOVIMENTO].ToString());
            descricao_movimento = leitorDados[ATRIBUTO_DESCRICAO_MOVIMENTO].ToString();
            tipo_movimento = leitorDados[ATRIBUTO_TIPO_MOVIMENTO].ToString();
            valor_movimento = decimal.Parse(leitorDados[ATRIBUTO_VALOR_MOVIMENTO].ToString());
            Caixa_id_caixa = int.Parse(leitorDados[ATRIBUTO_CAIXA_ID_CAIXA].ToString());
            formapagamento = leitorDados[FORMA_PAGAMENTO].ToString();
        }
    }
}
