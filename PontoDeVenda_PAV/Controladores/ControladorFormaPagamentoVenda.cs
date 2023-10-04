using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorFormaPagamentoVenda : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM form_pagamento_venda WHERE Forma_Pagamento_id_forma_pagamento = @id_forma_pagamento AND Venda_id_venda = @id_venda";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO form_pagamento_venda VALUES (@valor_forma_pagamento, @Forma_Pagamento_id_forma_pagamento, @Venda_id_venda)";
        }

        protected override string criarComandoAtualizacao()
        {
            return "UPDATE form_pagamento_venda SET valor_forma_pagamento = @valor_forma_pagamento WHERE Forma_Pagamento_id_forma_pagamento = @id_forma_pagamento AND Venda_id_venda = @id_venda";
        }

        protected override string criarComandoExclusao()
        {
            return "DELETE FROM form_pagamento_venda WHERE Forma_Pagamento_id_forma_pagamento = @id_forma_pagamento AND Venda_id_venda = @id_venda";
        }

        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_VALOR_FORMA_PAGAMENTO, MySqlDbType.Decimal);
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_FORMA_PAGAMENTO_ID, MySqlDbType.Int32);
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_VENDA_ID, MySqlDbType.Int32);
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_FORMA_PAGAMENTO_ID, MySqlDbType.Int32);
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_VENDA_ID, MySqlDbType.Int32);
        }
    }
}

