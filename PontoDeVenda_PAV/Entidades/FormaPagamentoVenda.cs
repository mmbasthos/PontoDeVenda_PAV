using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PontoDeVenda_PAV.Entidades
{
    public class FormaPagamentoVenda : Entidade
    {
        public const string ATRIBUTO_VALOR_FORMA_PAGAMENTO = "valor_forma_pagamento";
        public const string ATRIBUTO_FORMA_PAGAMENTO_ID = "Forma_Pagamento_id_forma_pagamento";
        public const string ATRIBUTO_VENDA_ID = "Venda_id_venda";

        public decimal valor_forma_pagamento { get; set; }
        public int Forma_Pagamento_id_forma_pagamento { get; set; }
        public int Venda_id_venda { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_VALOR_FORMA_PAGAMENTO].Value = valor_forma_pagamento;
            comando.Parameters[ATRIBUTO_FORMA_PAGAMENTO_ID].Value = Forma_Pagamento_id_forma_pagamento;
            comando.Parameters[ATRIBUTO_VENDA_ID].Value = Venda_id_venda;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_FORMA_PAGAMENTO_ID].Value = Forma_Pagamento_id_forma_pagamento;
            comando.Parameters[ATRIBUTO_VENDA_ID].Value = Venda_id_venda;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            valor_forma_pagamento = decimal.Parse(leitorDados[ATRIBUTO_VALOR_FORMA_PAGAMENTO].ToString());
            Forma_Pagamento_id_forma_pagamento = int.Parse(leitorDados[ATRIBUTO_FORMA_PAGAMENTO_ID].ToString());
            Venda_id_venda = int.Parse(leitorDados[ATRIBUTO_VENDA_ID].ToString());
        }
    }
}
