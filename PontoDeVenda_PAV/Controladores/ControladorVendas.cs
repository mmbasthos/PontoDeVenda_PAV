using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorVendas : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM venda WHERE id_venda = @id_venda";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO venda VALUES (@id_venda, @Cliente_id_cliente, @data_venda, @hora_venda, @total_venda, @situacao_venda)";
        }

        protected override string criarComandoAtualizacao()
        {
            return "0";
        }

        protected override string criarComandoExclusao()
        {
            return "0";
        }
        public int vendaAtual()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_venda FROM venda ORDER BY id_venda DESC LIMIT 1";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToInt32(resultado);
                    }
                    else
                    {
                        // Trate o caso em que a consulta não retorna nenhum valor.
                        // Por exemplo, você pode retornar um valor padrão ou lançar uma exceção.
                        throw new Exception("Nenhuma venda encontrada.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário (por exemplo, registre-a ou a lance novamente).
                throw new Exception("Erro ao obter venda atual: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }


        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(new MySqlParameter(Vendas.ATRIBUTO_ID_VENDA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(Vendas.ATRIBUTO_ID_CLIENTE_VENDA, MySqlDbType.Int32));
            comando.Parameters.Add(new MySqlParameter(Vendas.ATRIBUTO_DATA_VENDA, MySqlDbType.Date));
            comando.Parameters.Add(new MySqlParameter(Vendas.ATRIBUTO_HORA_VENDA, MySqlDbType.Time));
            comando.Parameters.Add(new MySqlParameter(Vendas.ATRIBUTO_TOTAL_VENDA, MySqlDbType.Decimal));
            comando.Parameters.Add(new MySqlParameter(Vendas.ATRIBUTO_SITUACAO_VENDA, MySqlDbType.VarChar));
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Vendas.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
        }



    }
}


/*
Columns:
id_venda int PK 
Cliente_id_cliente int AI 
data_venda date 
hora_venda time 
total_venda decimal(10,2) 
situacao_venda varchar(45)
*/