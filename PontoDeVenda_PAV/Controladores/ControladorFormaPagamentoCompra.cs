using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System;
using System.Collections.Generic;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorFormaPagamentoCompra : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM form_pagamento_compra WHERE Compra_id_compra = @id_compra AND Forma_Pagamento_id_forma_pagamento = @id_forma_pagamento";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO form_pagamento_compra VALUES (@valor_forma_pagamento, @Compra_id_compra, @Forma_Pagamento_id_forma_pagamento)";
        }

        protected override string criarComandoAtualizacao()
        {
            return "UPDATE form_pagamento_compra SET valor_forma_pagamento = @valor_forma_pagamento WHERE Compra_id_compra = @id_compra AND Forma_Pagamento_id_forma_pagamento = @id_forma_pagamento";
        }

        protected override string criarComandoExclusao()
        {
            return "DELETE FROM form_pagamento_compra WHERE Compra_id_compra = @id_compra AND Forma_Pagamento_id_forma_pagamento = @id_forma_pagamento";
        }

        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(new MySqlParameter(FormaPagamentoCompra.ATRIBUTO_VALOR_FORMA_PAGAMENTO, MySqlDbType.Decimal));
            comando.Parameters.Add(new MySqlParameter(FormaPagamentoCompra.ATRIBUTO_COMPRA_ID, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(FormaPagamentoCompra.ATRIBUTO_FORMA_PAGAMENTO_ID, MySqlDbType.Int32));
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(new MySqlParameter(FormaPagamentoCompra.ATRIBUTO_COMPRA_ID, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(FormaPagamentoCompra.ATRIBUTO_FORMA_PAGAMENTO_ID, MySqlDbType.Int32));
        }
    }
}
