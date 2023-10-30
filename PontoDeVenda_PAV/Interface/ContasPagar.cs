using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Controladores;
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
    public partial class ContasPagar : Form
    {
        public ContasPagar()
        {
            InitializeComponent();
        }

        public void botao()
        {
            try
            {

                // Obter as datas selecionadas nos DateTimePicker
                DateTime dataInicio = dateTimePicker1.Value;
                DateTime dataFim = dateTimePicker2.Value;

                BancodeDados.obterInstancia().conectar();

                // Construir a consulta SQL
                string comandoSql = "SELECT cp.id_conta_pagar ,f.nome_fornecedor, cp.data_lancamento, cp.data_vencimento, cp.valor_total, cp.valor_pago, cp.descricao_pagar " +
                                    "FROM conta_pagar cp " +
                                    "JOIN fornecedor f ON cp.Fornecedor_id_fornecedor = f.id_fornecedor " +
                                    "WHERE cp.data_vencimento BETWEEN @dataInicio AND @dataFim";



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
        private void button1_Click_1(object sender, EventArgs e)
        {
            botao(); 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idCliente = int.Parse(campoIdCliente.Text);
                // Obter as datas selecionadas nos DateTimePicker
                DateTime dataInicio = dateTimePicker1.Value;
                DateTime dataFim = dateTimePicker2.Value;

                BancodeDados.obterInstancia().conectar();

                // Construir a consulta SQL

                string comandoSql = "SELECT cp.id_conta_pagar, f.nome_fornecedor, cp.data_lancamento, cp.data_vencimento, cp.valor_total, cp.valor_pago, cp.descricao_pagar " +
                    "FROM conta_pagar cp " +
                    "JOIN fornecedor f ON cp.Fornecedor_id_fornecedor = f.id_fornecedor " +
                    "WHERE cp.data_vencimento BETWEEN @dataInicio AND @dataFim AND cp.Fornecedor_id_fornecedor = @idCliente";


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void inserircompra()
        {
            BancodeDados.obterInstancia().conectar();
            ControladorCompras controladorCompras = new ControladorCompras();
            Compra compra = new Compra();


            compra.id_fornecedor_compra = 1;


            compra.total_compra = 0m;
            compra.data_compra = DateTime.Now.Date;
            compra.hora_compra = DateTime.Now.TimeOfDay;
            compra.situacao_compra = "Ativa";

            controladorCompras.incluir(compra);
            BancodeDados.obterInstancia().desconectar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtém a linha selecionada
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Obtém o valor do ID da conta (pode ser necessário converter para o tipo correto)
                    int idConta = Convert.ToInt32(selectedRow.Cells["id_conta_pagar"].Value);

                    // Define a nova descrição e valor pago
                    string novaDescricao = "Paga";

                    decimal novoValorPago = Convert.ToDecimal(selectedRow.Cells["valor_pago"].Value);

                    inserircompra();
                    ContaPagarPagamento contaPagarPagamento = new ContaPagarPagamento(novoValorPago, idConta);
                    contaPagarPagamento.Show();

                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma conta para pagar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pagar conta: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtém a linha selecionada
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Obtém o valor do ID da conta (pode ser necessário converter para o tipo correto)
                    int idConta = Convert.ToInt32(selectedRow.Cells["id_conta_pagar"].Value);

                    // Define a nova descrição e valor recebido
                    string novaDescricao = "Vencida";
                    decimal novoValorRecebido = 0; // Define o novo valor recebido como zero

                    // Constrói o comando SQL para atualizar a conta
                    string comandoSql = "UPDATE conta_pagar SET descricao_pagar = @novaDescricao, valor_pago = @novoValorRecebido WHERE id_conta_pagar = @idConta";

                    using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                    {
                        comando.Parameters.AddWithValue("@novaDescricao", novaDescricao);
                        comando.Parameters.AddWithValue("@novoValorRecebido", novoValorRecebido);
                        comando.Parameters.AddWithValue("@idConta", idConta);

                        // Executa o comando
                        comando.ExecuteNonQuery();

                        // Atualiza o DataGridView
                        button1_Click_1(sender, e); // Chama a função de consulta novamente para atualizar os dados
                    }

                    MessageBox.Show("Conta marcada como vencida com sucesso!");
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma conta para vencer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao vencer conta: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statusSelecionado = comboBox1.SelectedItem.ToString();
            DataTable dataTable = new DataTable();

            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT cp.id_conta_pagar, f.nome_fornecedor, cp.data_lancamento, cp.data_vencimento, cp.valor_total, cp.valor_pago, cp.descricao_pagar " +
                                    "FROM conta_pagar cp " +
                                    "JOIN fornecedor f ON cp.Fornecedor_id_fornecedor = f.id_fornecedor ";

                switch (statusSelecionado)
                {
                    case "Vencidas":
                        comandoSql += "WHERE cp.descricao_pagar = 'Vencida'";
                        break;
                    case "Pagas":
                        comandoSql += "WHERE cp.descricao_pagar = 'Paga'";
                        break;
                    case "Abertas":
                        comandoSql += "WHERE cp.descricao_pagar = 'Aberta'";
                        break;
                    default:
                        break;
                }

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar contas a pagar: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

    }
}
