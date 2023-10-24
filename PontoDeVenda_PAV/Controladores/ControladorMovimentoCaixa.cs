using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using System;
using System.Collections.Generic;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorMovimentoCaixa : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM movimento_caixa WHERE id_movimento_caixa = @id_movimento_caixa";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO movimento_caixa VALUES (@id_movimento_caixa, @data_movimento, @hora_movimento, @descricao_movimento, @tipo_movimento, @valor_movimento, @Caixa_id_caixa, @formapagamento)";
        }

        protected override string criarComandoAtualizacao()
        {
            return "UPDATE movimento_caixa" +
                " SET data_movimento = @data_movimento, hora_movimento = @hora_movimento, descricao_movimento = @descricao_movimento, tipo_movimento = @tipo_movimento, valor_movimento = @valor_movimento, Caixa_id_caixa = @Caixa_id_caixa" +
                " WHERE id_movimento_caixa = @id_movimento_caixa";
        }

        protected override string criarComandoExclusao()
        {
            return "DELETE FROM movimento_caixa WHERE id_movimento_caixa = @id_movimento_caixa";
        }

        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_ID_MOVIMENTO_CAIXA, MySqlDbType.Int32);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_DATA_MOVIMENTO, MySqlDbType.Date);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_HORA_MOVIMENTO, MySqlDbType.Time);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_DESCRICAO_MOVIMENTO, MySqlDbType.VarChar);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_TIPO_MOVIMENTO, MySqlDbType.VarChar);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_VALOR_MOVIMENTO, MySqlDbType.Decimal);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_CAIXA_ID_CAIXA, MySqlDbType.Int32);
            comando.Parameters.Add(MovimentoCaixa.FORMA_PAGAMENTO, MySqlDbType.VarChar);
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_ID_MOVIMENTO_CAIXA, MySqlDbType.Int32);
        }

        
    }
}
