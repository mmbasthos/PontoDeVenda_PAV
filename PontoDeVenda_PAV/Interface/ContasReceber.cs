using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PontoDeVenda_PAV.Interface
{
    public partial class ContasReceber : Form
    {
        public ContasReceber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Obter as datas selecionadas nos DateTimePicker
                DateTime dataInicio = dateTimePicker1.Value;
                DateTime dataFim = dateTimePicker2.Value;

                BancodeDados.obterInstancia().conectar();

                // Construir a consulta SQL
                string comandoSql = "SELECT c.nome_cliente, r.data_lancamento, r.data_vencimento, r.valor_total, r.valor_recebimento, r.descricao_receber " +
                                    "FROM conta_receber r " +
                                    "JOIN cliente c ON r.Cliente_id_cliente = c.id_cliente " +
                                    "WHERE r.data_vencimento BETWEEN @dataInicio AND @dataFim";


                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@dataInicio", dataInicio);
                    comando.Parameters.AddWithValue("@dataFim", dataFim);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Preencher o DataGridView com os resultados
                        dataGridView1.DataSource = dataTable;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar contas a receber: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = int.Parse(campoIdCliente.Text);
                // Obter as datas selecionadas nos DateTimePicker
                DateTime dataInicio = dateTimePicker1.Value;
                DateTime dataFim = dateTimePicker2.Value;

                BancodeDados.obterInstancia().conectar();

                // Construir a consulta SQL
                string comandoSql = "SELECT c.nome_cliente, r.data_lancamento, r.data_vencimento, r.valor_total, r.valor_recebimento, r.descricao_receber " +
                                    "FROM conta_receber r " +
                                    "JOIN cliente c ON r.Cliente_id_cliente = c.id_cliente " +
                                    "WHERE r.data_vencimento BETWEEN @dataInicio AND @dataFim AND r.Cliente_id_cliente = @idCliente";


                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@dataInicio", dataInicio);
                    comando.Parameters.AddWithValue("@dataFim", dataFim);
                    comando.Parameters.AddWithValue("@idCliente", idCliente);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Preencher o DataGridView com os resultados
                        dataGridView1.DataSource = dataTable;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar contas a receber: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }
    }
}
