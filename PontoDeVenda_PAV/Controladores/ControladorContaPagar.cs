using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoDeVenda_PAV.Persistencia;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorContaPagar : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM conta_pagar WHERE id_conta_pagar = @id_conta_pagar";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO conta_pagar  VALUES (@id_conta_pagar, @descricao_pagar, @data_lancamento, @data_vencimento, @valor_total, @valor_pago, @data_pagamento, @valor_pagamento, @Fornecedor_id_fornecedor)";
        }

        protected override string criarComandoAtualizacao()
        {
            return "UPDATE conta_pagar" +
                " SET descricao_pagar = @descricao_pagar," +
                " data_lancamento = @data_lancamento," +
                " data_vencimento = @data_vencimento," +
                " valor_total = @valor_total," +
                " valor_pago = @valor_pago," +
                " data_pagamento = @data_pagamento," +
                " valor_pagamento = @valor_pagamento," +
                " Fornecedor_id_fornecedor = @Fornecedor_id_fornecedor" +
                " WHERE id_conta_pagar = @id_conta_pagar";
        }

        protected override string criarComandoExclusao()
        {
            return "DELETE FROM conta_pagar WHERE id_conta_pagar = @id_conta_pagar";
        }

        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(ContaPagar.ATRIBUTO_ID_CONTA_PAGAR, MySqlDbType.Int32);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_DESCRICAO_PAGAR, MySqlDbType.VarChar);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_DATA_LANCAMENTO, MySqlDbType.Date);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_DATA_VENCIMENTO, MySqlDbType.Date);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_VALOR_TOTAL, MySqlDbType.Decimal);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_VALOR_PAGO, MySqlDbType.Decimal);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_DATA_PAGAMENTO, MySqlDbType.Date);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_VALOR_PAGAMENTO, MySqlDbType.Decimal);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_FORNECEDOR_ID, MySqlDbType.Int32);
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(ContaPagar.ATRIBUTO_ID_CONTA_PAGAR, MySqlDbType.Int32);
        }
    }
}
