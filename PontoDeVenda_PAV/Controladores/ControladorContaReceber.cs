using System;

public class Class1
{
    public class ControladorContaReceber : ControladorCadastro
    {

        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM conta_receber WHERE id_conta_receber = @id_conta_receber";
        }
        protected override string criarComandoInclusao()
        {
            return "INSERT INTO conta_receber VALUES (@id_conta_receber," +
                " @descricao_receber, @data_lancamento, @data_vencimento," +
                " @valor_total, @valor_recebido, " +
                "@data_recebimento, @valor_recebimento, @Cliente_id_cliente," +
                " @id_forma_pagamento";

        }
        protected override string criarComandoAtualizacao()
        {
            return "UPDATE conta_receber" +
                " SET id_conta_receber            = @id_conta_receber," +
                "     descricao_receber           = @descricao_receber," +
                "     data_lancamento             = @data_lancamento," +
                "     data_vencimento             = @data_vencimento," +
                "     valor_total                 = @valor_total," +
                "     valor_recebido              = @valor_recebido," +
                "     data_recebimento            = @data_recebimento," +
                "     valor_recebimento           = @valor_recebimento," +
                "     Cliente_id_cliente          = @Cliente_id_cliente," +
                "     id_forma_pagamento          = @id_forma_pagamento,";

        }
        protected override string criarComandoExclusao()
        {
            return "DELETE FROM conta_receber WHERE id_conta_receber = @id_conta_receber";
        }
        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(conta_receber.ATRIBUTO_ID_CONTA_RECEBER, MySqlDbType.Int32);
            comando.Parameters.Add(conta_receber.ATRIBUTO_DESCRICAO_RECEBER, MySqlDbType.VarChar); ;

            comando.Parameters.Add(conta_receber.ATRIBUTO_DATA_LANCAMENTO, MySqlDbType.Date);
            comando.Parameters.Add(conta_receber.ATRIBUTO_DATA_VENCIMENTO, MySqlDbType.Date);

            comando.Parameters.Add(conta_receber.ATRIBUTO_VALOR_TOTAL, MySqlDbType.Decimal);
            comando.Parameters.Add(conta_receber.ATRIBUTO_VALOR_RECEBIDO, MySqlDbType.Decimal);

            comando.Parameters.Add(conta_receber.ATRIBUTO_DATA_RECEBIDO, MySqlDbType.Date);
            comando.Parameters.Add(conta_receber.ATRIBUTO_VALOR_RECEBIMENTO, MySqlDbType.Decimal);

            comando.Parameters.Add(conta_receber.ATRIBUTO_ID_CLIENTE_CLIENTE, MySqlDbType.Int32);
            comando.Parameters.Add(conta_receber.ATRIBUTO_ID_FORMA_PAGAMENTO, MySqlDbType.Int32);


        }
        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Fornecedor.ATRIBUTO_ID_CONTA_RECEBER, MySqlDbType.Int32);
        }
    }
}