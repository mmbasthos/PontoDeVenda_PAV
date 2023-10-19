using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace PontoDeVenda_PAV.Entidades
{
    public class FormaPagamentoCompra : Entidade
    {
        public const string ATRIBUTO_VALOR_FORMA_PAGAMENTO = "valor_forma_pagamento";
        public const string ATRIBUTO_COMPRA_ID = "Compra_id_compra";
        public const string ATRIBUTO_FORMA_PAGAMENTO_ID = "Forma_Pagamento_id_forma_pagamento";

        public decimal valor_forma_pagamento { get; set; }
        public int Compra_id_compra { get; set; }
        public int Forma_Pagamento_id_forma_pagamento { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_VALOR_FORMA_PAGAMENTO].Value = valor_forma_pagamento;
            comando.Parameters[ATRIBUTO_COMPRA_ID].Value = Compra_id_compra;
            comando.Parameters[ATRIBUTO_FORMA_PAGAMENTO_ID].Value = Forma_Pagamento_id_forma_pagamento;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_COMPRA_ID].Value = Compra_id_compra;
            comando.Parameters[ATRIBUTO_FORMA_PAGAMENTO_ID].Value = Forma_Pagamento_id_forma_pagamento;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            valor_forma_pagamento = decimal.Parse(leitorDados[ATRIBUTO_VALOR_FORMA_PAGAMENTO].ToString());
            Compra_id_compra = int.Parse(leitorDados[ATRIBUTO_COMPRA_ID].ToString());
            Forma_Pagamento_id_forma_pagamento = int.Parse(leitorDados[ATRIBUTO_FORMA_PAGAMENTO_ID].ToString());
        }
    }
}

