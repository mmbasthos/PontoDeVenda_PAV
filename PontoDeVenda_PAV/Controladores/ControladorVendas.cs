using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                        // Retorne um valor indicando que nenhuma venda foi encontrada.
                        return -1; // Por exemplo, -1 pode indicar que nenhuma venda foi encontrada.
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário (por exemplo, registre-a ou a lance novamente).
                throw new Exception("Erro ao obter venda atual: " + ex.Message);
            }
        }

        

        public void AtualizarTotalVenda(int idVenda, decimal novoTotal)
        { 
            try
            {
                string comandoSql = "UPDATE venda SET total_venda = @novoTotal WHERE id_venda = @idVenda";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@novoTotal", novoTotal);
                    comando.Parameters.AddWithValue("@idVenda", idVenda);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o total da venda: " + ex.Message);
            }
        }
        public decimal ObterTotalVenda(int idVenda)
        {
            BancodeDados.obterInstancia().conectar();
            
            try
            {
                string comandoSql = "SELECT total_venda FROM venda WHERE id_venda = @idVenda";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@idVenda", idVenda);

                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToDecimal(resultado);
                    }
                    else
                    {
                        // Trate o caso em que a consulta não retorna nenhum valor.
                        return 0; // Ou outro valor padrão apropriado.
                    }
                    
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário (por exemplo, registre-a ou a lance novamente).
                throw new Exception("Erro ao obter o total da venda: " + ex.Message);
            }

            BancodeDados.obterInstancia().desconectar();
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