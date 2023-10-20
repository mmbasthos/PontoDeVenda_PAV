using MySql.Data.MySqlClient;
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
    public partial class ImprimirRelatorioCompras : Form
    {
        private DataTable dataTable = new DataTable();
        public ImprimirRelatorioCompras()
        {
            InitializeComponent();
        }

        private void CalcularTotais()
        {
            decimal totalCompras = 0m;
            decimal totalCanceladas = 0m;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                decimal totalCompra = Convert.ToDecimal(row.Cells["total_compra"].Value);
                string situacao = Convert.ToString(row.Cells["situacao_compra"].Value);

                totalCompras += totalCompra;

                if (situacao == "Cancelada")
                {
                    totalCanceladas += totalCompras;
                }
            }

            lblTotalVendas.Text = "Total de compras: " + totalCompras.ToString("C");
            lblTotalCanceladas.Text = "Total de compras canceladas: " + totalCanceladas.ToString("C");
            labelTotalFinal.Text = "Total final: " + (totalCompras + totalCanceladas).ToString("C");

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter as datas selecionadas nos DateTimePicker
                DateTime dataInicio = dateTimePicker1.Value;
                DateTime dataFim = dateTimePicker2.Value;

                BancodeDados.obterInstancia().conectar();

                // Construir a consulta SQL
                string comandoSql = "SELECT c.id_compra, c.data_compra, c.hora_compra, f.nome_fornecedor, c.situacao_compra, c.total_compra " +
                           "FROM compra c " +
                           "JOIN fornecedor f ON c.Fornecedor_id_fornecedor = f.id_fornecedor " +
                           "WHERE c.data_compra BETWEEN @dataInicio AND @dataFim";

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
                int idFornecedor = int.Parse(txtIdFornecedor.Text); // Método que você deve criar para obter o ID do cliente

                // Obter as datas selecionadas nos DateTimePicker
                DateTime dataInicio = dateTimePicker1.Value;
                DateTime dataFim = dateTimePicker2.Value;

                // Construir a consulta SQL
                string comandoSql = "SELECT c.id_compra, c.data_compra, c.hora_compra, f.nome_fornecedor, c.situacao_compra, c.total_compra " +
                                   "FROM compra c " +
                                   "JOIN fornecedor f ON c.Fornecedor_id_fornecedor = f.id_fornecedor " +
                                   "WHERE c.data_compra BETWEEN @dataInicio AND @dataFim " +
                                   "AND c.Fornecedor_id_fornecedor = @idFornecedor";


                // Executar a consulta no banco de dados
                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@dataInicio", dataInicio);
                    comando.Parameters.AddWithValue("@dataFim", dataFim);
                    comando.Parameters.AddWithValue("@idFornecedor", idFornecedor);

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
                MessageBox.Show("Erro ao consultar compras: " + ex.Message);
            }
            BancodeDados.obterInstancia().desconectar();
        }
    }
}


