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
    public class ControladorCadastroFornecedor : ControladorCadastro
    {

        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM fornecedor WHERE id_fornecedor = @id_fornecedor";
        }
        protected override string criarComandoInclusao()
        {
            return "INSERT INTO fornecedor VALUES (@id_fornecedor, @nome_fornecedor, @cpf_cnpj_fornecedor, @logradouro_fornecedor, @numero_logradouro_fornecedor, @complemento_fornecedor, @bairro_fornecedor, @cidade_fornecedor, @estado_fornecedor, @cep_fornecedor, @telefone_fornecedor, @email_fornecedor)";

        }
        protected override string criarComandoAtualizacao()
        {
            return "UPDATE fornecedor" +
                " SET nome_fornecedor             = @nome_fornecedor," +
                "     cpf_cnpj_fornecedor         = @cpf_cnpj_fornecedor," +
                "     logradouro_fornecedor       = @logradouro_fornecedor," +
                "     numero_logradouro_fornecedor= @numero_logradouro_fornecedor," +
                "     complemento_fornecedor      = @complemento_fornecedor," +
                "     bairro_fornecedor           = @bairro_fornecedor," +
                "     cidade_fornecedor           = @cidade_fornecedor," +
                "     estado_fornecedor           = @estado_fornecedor," +
                "     cep_fornecedor              = @cep_fornecedor," +
                "     telefone_fornecedor         = @telefone_fornecedor," +
                "     email_fornecedor            = @email_fornecedor " +
                "WHERE id_fornecedor              = @id_fornecedor";

        }
        protected override string criarComandoExclusao()
        {
            return "DELETE FROM fornecedor WHERE id_fornecedor = @id_fornecedor";
        }
        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Fornecedor.ATRIBUTO_ID_FORNECEDOR, MySqlDbType.Int32);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_NOME_FORNECEDOR, MySqlDbType.VarChar); ;
            comando.Parameters.Add(Fornecedor.ATRIBUTO_LOGRADOURO_FORNECEDOR, MySqlDbType.VarChar);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_CPF_CNPJ_FORNECEDOR, MySqlDbType.VarChar);

            comando.Parameters.Add(Fornecedor.ATRIBUTO_NUM_LOGRADOURO_FORNECEDOR, MySqlDbType.VarChar);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_COMPLEMENTO_FORNECEDOR, MySqlDbType.VarChar);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_BAIRRO_FORNECEDOR, MySqlDbType.VarChar);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_CIDADE_FORNECEDOR, MySqlDbType.VarChar);

            comando.Parameters.Add(Fornecedor.ATRIBUTO_ESTADO_FORNECEDOR, MySqlDbType.VarChar);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_CEP_FORNECEDOR, MySqlDbType.VarChar);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_TELEFONE_FORNECEDOR, MySqlDbType.VarChar);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_EMAIL_FORNECEDOR, MySqlDbType.VarChar);

        }
        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Fornecedor.ATRIBUTO_ID_FORNECEDOR, MySqlDbType.Int32);
        }


    }
}