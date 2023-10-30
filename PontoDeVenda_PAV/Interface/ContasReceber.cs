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
    public partial class ContasReceber : Form
    {
        public ContasReceber()
        {
            InitializeComponent();
        }

        public void inserirvenda()
        {
            BancodeDados.obterInstancia().conectar();
            ControladorVendas controladorVendas = new ControladorVendas();
            Vendas venda = new Vendas();


            venda.id_cliente_venda = 1;


            venda.total_venda = 0m;
            venda.data_venda = DateTime.Now.Date;
            venda.hora_venda = DateTime.Now.TimeOfDay;
            venda.situacao_venda = "Ativa";

            controladorVendas.incluir(venda);
            BancodeDados.obterInstancia().desconectar();
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
                string comandoSql = "SELECT r.id_conta_receber, c.nome_cliente, r.data_lancamento, r.data_vencimento, r.valor_total, r.valor_recebimento, r.descricao_receber " +
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
                string comandoSql = "SELECT r.id_conta_receber, c.nome_cliente, r.data_lancamento, r.data_vencimento, r.valor_total, r.valor_recebimento, r.descricao_receber " +
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
                    int idConta = Convert.ToInt32(selectedRow.Cells["id_conta_receber"].Value);

                    // Define a nova descrição e valor pago
                    string novaDescricao = "Paga";
                    decimal novoValorPago = Convert.ToDecimal(selectedRow.Cells["valor_recebimento"].Value);
                    
                    inserirvenda();
                    ContaReceberPagamento contaReceberPagamento = new ContaReceberPagamento(novoValorPago,idConta);
                    contaReceberPagamento.Show();
                }

                else
                {
                    MessageBox.Show("Por favor, selecione uma conta para receber.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao receber conta: " + ex.Message);
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
                    int idConta = Convert.ToInt32(selectedRow.Cells["id_conta_receber"].Value);

                    // Define a nova descrição e valor recebido
                    string novaDescricao = "Vencida";
                    decimal novoValorRecebido = 0; // Define o novo valor recebido como zero

                    // Constrói o comando SQL para atualizar a conta
                    string comandoSql = "UPDATE conta_receber SET descricao_receber = @novaDescricao, valor_recebimento = @novoValorRecebido WHERE id_conta_receber = @idConta";

                    using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                    {
                        comando.Parameters.AddWithValue("@novaDescricao", novaDescricao);
                        comando.Parameters.AddWithValue("@novoValorRecebido", novoValorRecebido);
                        comando.Parameters.AddWithValue("@idConta", idConta);

                        // Executa o comando
                        comando.ExecuteNonQuery();

                        // Atualiza o DataGridView
                        button1_Click(sender, e); // Chama a função de consulta novamente para atualizar os dados
                    }

                    MessageBox.Show("Conta marcada como vencida com sucesso!");
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma conta para receber.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao receber conta: " + ex.Message);
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

                string comandoSql = "SELECT cr.id_conta_receber, c.nome_cliente, cr.data_lancamento, cr.data_vencimento, cr.valor_total, cr.valor_recebimento, cr.descricao_receber " +
                                           "FROM conta_receber cr " +
                                           "JOIN cliente c ON cr.Cliente_id_cliente = c.id_cliente ";

                switch (statusSelecionado)
                {
                    case "Vencidas":
                        comandoSql += "WHERE cr.descricao_receber = 'Vencida'";
                        break;
                    case "Pagas":
                        comandoSql += "WHERE cr.descricao_receber = 'Paga'";
                        break;
                    case "Abertas":
                        comandoSql += "WHERE cr.descricao_receber = 'Aberta'";
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
