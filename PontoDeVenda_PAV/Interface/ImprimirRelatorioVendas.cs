using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PontoDeVenda_PAV.Persistencia;

namespace PontoDeVenda_PAV.Interface
{
    public partial class ImprimirRelatorioVendas : Form
    {
        private DataTable dataTable = new DataTable();
        public ImprimirRelatorioVendas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
        }


        private void CalcularTotais()
        {
            decimal totalVendas = 0m;
            decimal totalCanceladas = 0m;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                decimal totalVenda = Convert.ToDecimal(row.Cells["total_venda"].Value);
                string situacao = Convert.ToString(row.Cells["situacao_venda"].Value);

                totalVendas += totalVenda;

                if (situacao == "Cancelada")
                {
                    totalCanceladas += totalVenda;
                }
            }

            lblTotalVendas.Text = "Total de vendas: " + totalVendas.ToString("C");
            lblTotalCanceladas.Text = "Total de vendas canceladas: " + totalCanceladas.ToString("C");
            labelTotalFinal.Text = "Total final: " + (totalVendas + totalCanceladas).ToString("C");

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obter as datas selecionadas nos DateTimePicker
                DateTime dataInicio = dateTimePicker1.Value;
                DateTime dataFim = dateTimePicker2.Value;

                BancodeDados.obterInstancia().conectar();

                // Construir a consulta SQL
                string comandoSql = "SELECT v.id_venda, v.data_venda, v.hora_venda, c.nome_cliente, v.situacao_venda, v.total_venda " +
                           "FROM venda v " +
                           "JOIN cliente c ON v.Cliente_id_cliente = c.id_cliente " +
                           "WHERE v.data_venda BETWEEN @dataInicio AND @dataFim";

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

                // Calcular e exibir os totais
                CalcularTotais();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar vendas: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();

            try
            {
                int idCliente = int.Parse(txtIdCliente.Text); // Método que você deve criar para obter o ID do cliente

                // Obter as datas selecionadas nos DateTimePicker
                DateTime dataInicio = dateTimePicker1.Value;
                DateTime dataFim = dateTimePicker2.Value;

                // Construir a consulta SQL
                string comandoSql = "SELECT v.id_venda, v.data_venda, v.hora_venda, c.nome_cliente, v.situacao_venda, v.total_venda " +
                                           "FROM venda v " +
                                           "JOIN cliente c ON v.Cliente_id_cliente = c.id_cliente " +
                                           "WHERE v.data_venda BETWEEN @dataInicio AND @dataFim " +
                                           "AND v.Cliente_id_cliente = @idCliente";


                // Executar a consulta no banco de dados
                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@dataInicio", dataInicio);
                    comando.Parameters.AddWithValue("@dataFim", dataFim);
                    comando.Parameters.AddWithValue("@idCliente", idCliente);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        dataTable.Clear(); // Limpar os dados antigos
                        adapter.Fill(dataTable);

                        // Preencher o DataGridView com os resultados
                        dataGridView1.DataSource = dataTable;
                    }
                }

                // Calcular e exibir os totais
                CalcularTotais();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar vendas: " + ex.Message);
            }
            BancodeDados.obterInstancia().desconectar();
        }

    }
}
