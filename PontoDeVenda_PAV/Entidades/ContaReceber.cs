using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class ContaReceber : Entidade
    {
        public const string ATRIBUTO_ID_CONTA_RECEBER = "id_conta_receber";
        public const string ATRIBUTO_DESCRICAO_RECEBER = "descricao_receber";
        public const string ATRIBUTO_DATA_LANCAMENTO = "data_lancamento";
        public const string ATRIBUTO_DATA_VENCIMENTO = "data_vencimento";
        public const string ATRIBUTO_VALOR_TOTAL = "valor_total";
        public const string ATRIBUTO_VALOR_RECEBIDO = "valor_recebido";
        public const string ATRIBUTO_DATA_RECEBIDO = "data_recebimento";
        public const string ATRIBUTO_VALOR_RECEBIMENTO = "valor_recebimento";
        public const string ATRIBUTO_ID_CLIENTE_CLIENTE = "Cliente_id_cliente";
        public const string ATRIBUTO_ID_FORMA_PAGAMENTO = "id_forma_pagamento";

        public int id_conta_receber { get; set; }
        public string descricao_receber { get; set; }
        public DateTime data_lancamento { get; set; }
        public DateTime data_vencimento { get; set; }
        public decimal valor_total { get; set; }
        public decimal valor_recebido { get; set; }
        public DateTime data_recebimento { get; set; }
        public decimal valor_recebimento { get; set; }
        public int Cliente_id_cliente { get; set; }
        public int id_forma_pagamento { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTA_RECEBER].Value = id_conta_receber;
            comando.Parameters[ATRIBUTO_DESCRICAO_RECEBER].Value = descricao_receber;
            comando.Parameters[ATRIBUTO_DATA_LANCAMENTO].Value = data_lancamento;
            comando.Parameters[ATRIBUTO_DATA_VENCIMENTO].Value = data_vencimento;
            comando.Parameters[ATRIBUTO_VALOR_TOTAL].Value = valor_total;
            comando.Parameters[ATRIBUTO_VALOR_RECEBIDO].Value = valor_recebido;
            comando.Parameters[ARTIBUTO_DATA_RECEBIDO].Value = data_recebimento; 
            comando.Parameters[ATRIBUTO_VALOR_RECEBIMENTO].Value = valor_recebimento;
            comando.Parameters[ATRIBUTO_ID_CLIENTE_CLIENTE].Value = Cliente_id_cliente;
            comando.Parameters[ATRIBUTO_ID_FORMA_PAGAMENTO].Value = id_forma_pagamento;
            
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTA_RECEBER].Value = id_conta_receber;

        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_conta_receber = int.Parse(leitorDados[ATRIBUTO_ID_CONTA_RECEBER].ToString());
            descricao_receber = leitorDados[ATRIBUTO_DESCRICAO_RECEBER].ToString();

            data_lancamento = DateTime.Parse(leitorDados[ATRIBUTO_DATA_LANCAMENTO].ToString());
            data_vencimento = DateTime.Parse(leitorDados[ATRIBUTO_DATA_VENCIMENTO].ToString());

            valor_total = decimal.Parse(leitorDados[ATRIBUTO_VALOR_TOTAL].ToString());
            valor_recebido = decimal.Parse(leitorDados[ATRIBUTO_VALOR_RECEBIDO].ToString());

            data_recebimento = DateTime.Parse(leitorDados[ATRIBUTO_DATA_RECEBIDO].ToString());
            valor_recebimento = decimal.Parse(leitorDados[ATRIBUTO_VALOR_RECEBIMENTO].ToString());

            Cliente_id_cliente = int.Parse(leitorDados[ATRIBUTO_ID_CLIENTE_CLIENTE].ToString());
            id_forma_pagamento = int.Parse(leitorDados[ATRIBUTO_ID_FORMA_PAGAMENTO].ToString());



        }
    }
}


/*
Table: conta_receber
Columns:
id_conta_receber int AI PK 
descricao_receber varchar(200) 
data_lancamento date 
data_vencimento date 
valor_total decimal(10,2) 
valor_recebido decimal(10,2) 
data_recebimento date 
valor_recebimento decimal(10,2) 
Cliente_id_cliente int
id_forma_pagamento int
*/
