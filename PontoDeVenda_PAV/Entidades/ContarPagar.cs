using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class ContaPagar : Entidade
    {
        public const string ATRIBUTO_ID_CONTA_PAGAR = "id_conta_pagar";
        public const string ATRIBUTO_DESCRICAO_PAGAR = "descricao_pagar";
        public const string ATRIBUTO_DATA_LANCAMENTO = "data_lancamento";
        public const string ATRIBUTO_DATA_VENCIMENTO = "data_vencimento";
        public const string ATRIBUTO_VALOR_TOTAL = "valor_total";
        public const string ATRIBUTO_VALOR_PAGO = "valor_pago";
        public const string ATRIBUTO_DATA_PAGAMENTO = "data_pagamento";
        public const string ATRIBUTO_VALOR_PAGAMENTO = "valor_pagamento";
        public const string ATRIBUTO_FORNECEDOR_ID = "Fornecedor_id_fornecedor";

        public int id_conta_pagar { get; set; }
        public string descricao_pagar { get; set; }
        public DateTime data_lancamento { get; set; }
        public DateTime data_vencimento { get; set; }
        public decimal valor_total { get; set; }
        public decimal valor_pago { get; set; }
        public DateTime data_pagamento { get; set; }
        public decimal valor_pagamento { get; set; }
        public int Fornecedor_id_fornecedor { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTA_PAGAR].Value = id_conta_pagar;
            comando.Parameters[ATRIBUTO_DESCRICAO_PAGAR].Value = descricao_pagar;
            comando.Parameters[ATRIBUTO_DATA_LANCAMENTO].Value = data_lancamento;
            comando.Parameters[ATRIBUTO_DATA_VENCIMENTO].Value = data_vencimento;
            comando.Parameters[ATRIBUTO_VALOR_TOTAL].Value = valor_total;
            comando.Parameters[ATRIBUTO_VALOR_PAGO].Value = valor_pago;
            comando.Parameters[ATRIBUTO_DATA_PAGAMENTO].Value = data_pagamento;
            comando.Parameters[ATRIBUTO_VALOR_PAGAMENTO].Value = valor_pagamento;
            comando.Parameters[ATRIBUTO_FORNECEDOR_ID].Value = Fornecedor_id_fornecedor;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTA_PAGAR].Value = id_conta_pagar;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_conta_pagar = int.Parse(leitorDados[ATRIBUTO_ID_CONTA_PAGAR].ToString());
            descricao_pagar = leitorDados[ATRIBUTO_DESCRICAO_PAGAR].ToString();
            data_lancamento = DateTime.Parse(leitorDados[ATRIBUTO_DATA_LANCAMENTO].ToString());
            data_vencimento = DateTime.Parse(leitorDados[ATRIBUTO_DATA_VENCIMENTO].ToString());
            valor_total = decimal.Parse(leitorDados[ATRIBUTO_VALOR_TOTAL].ToString());
            valor_pago = decimal.Parse(leitorDados[ATRIBUTO_VALOR_PAGO].ToString());
            data_pagamento = DateTime.Parse(leitorDados[ATRIBUTO_DATA_PAGAMENTO].ToString());
            valor_pagamento = decimal.Parse(leitorDados[ATRIBUTO_VALOR_PAGAMENTO].ToString());
            Fornecedor_id_fornecedor = int.Parse(leitorDados[ATRIBUTO_FORNECEDOR_ID].ToString());
        }
    }
}
