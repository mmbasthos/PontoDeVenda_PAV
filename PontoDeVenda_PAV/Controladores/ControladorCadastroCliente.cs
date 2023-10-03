using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System.Data;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorCadastroCliente : ControladorCadastro
    {

        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM cliente WHERE id_cliente = @id_cliente"; //procurando por onde esta o id_cliente. 
        }
        protected override string criarComandoInclusao()
        {
            return "INSERT INTO cliente VALUES (@id_cliente, @nome_cliente, @cpf_cnpj_cliente, " +
                   "@logradouro_cliente, @numero_logradouro_cliente, @complemento_cliente, " +
                   "@bairro_cliente, @cidade_cliente, @estado_cliente, @cep_cliente, @telefone_cliente, @email_cliente)";

            //apenas dei espaço para organizar os termos e não ficar muito difícil de ler o código
        }
        protected override string criarComandoAtualizacao()
        {
            return "UPDATE cliente" +
                    " SET nome_cliente = @nome_cliente," +
                    " cpf_cnpj_cliente = @cpf_cnpj_cliente," +
                    " logradouro_cliente = @logradouro_cliente," +
                    " numero_logradouro_cliente = @numero_logradouro_cliente," +
                    " complemento_cliente = @complemento_cliente," +
                    " bairro_cliente = @bairro_cliente," +  // Adicionei uma vírgula aqui
                    " cidade_cliente = @cidade_cliente," +  // Adicionei uma vírgula aqui
                    " estado_cliente = @estado_cliente," +  // Adicionei uma vírgula aqui
                    " cep_cliente = @cep_cliente," +  // Adicionei uma vírgula aqui
                    " telefone_cliente = @telefone_cliente," +  // Adicionei uma vírgula aqui
                    " email_cliente = @email_cliente " +
                    "WHERE id_cliente = @id_cliente";
        }
        protected override string criarComandoExclusao()
        {
            return "DELETE FROM cliente WHERE id_cliente = @id_cliente";
        }

        public string ObterNomeClientePorCPF(string cpf)
        {
            BancodeDados.obterInstancia().conectar();

            using (MySqlCommand comando = new MySqlCommand("SELECT nome_cliente FROM cliente WHERE cpf_cnpj_cliente = @cpf", BancodeDados.obterInstancia().obterConexao()))
            {
                comando.Parameters.AddWithValue("@cpf", cpf);

                string nomeCliente = comando.ExecuteScalar() as string;
                return nomeCliente;
            }

            BancodeDados.obterInstancia().desconectar();
        }

        public int ObterIdClientePorCPF(string cpf)
        {
            int idCliente = -1; // Inicializamos com -1 para indicar que não foi encontrado

            using (MySqlCommand comando = new MySqlCommand("SELECT id_cliente FROM cliente WHERE cpf_cnpj_cliente = @cpf;", BancodeDados.obterInstancia().obterConexao()))
            {
                comando.Parameters.AddWithValue("@cpf", cpf);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idCliente = Convert.ToInt32(reader["id_cliente"]);
                    }
                }
            }

            // Adiciona esta linha para imprimir o valor no console
            Console.WriteLine("O id_cliente retornado é: " + idCliente);

            return idCliente;
        }




        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_ID_CLIENTE, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_NOME_CLIENTE, MySqlDbType.VarChar)); ;
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_LOGRADOURO_CLIENTE, MySqlDbType.VarChar));
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_CPF_CNPJ_CLIENTE, MySqlDbType.VarChar));

            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_NUM_LOGRADOURO_CLIENTE, MySqlDbType.VarChar));
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_COMPLEMENTO_LOGRADOURO_CLIENTE, MySqlDbType.VarChar));
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_BAIRRO_CLIENTE, MySqlDbType.VarChar));
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_CIDADE_CLIENTE, MySqlDbType.VarChar));

            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_ESTADO_CLIENTE, MySqlDbType.VarChar));
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_CEP_CLIENTE, MySqlDbType.VarChar));
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_TELEFONE_CLIENTE, MySqlDbType.VarChar));
            comando.Parameters.Add(new MySqlParameter(Cliente.ATRIBUTO_EMAIL_CLIENTE, MySqlDbType.VarChar));

        }
        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Cliente.ATRIBUTO_ID_CLIENTE, MySqlDbType.Int32);
        }
    }
}