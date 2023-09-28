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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_cliente, nome_cliente, telefone_cliente, email_cliente, logradouro_cliente, numero_logradouro_cliente, cidade_cliente FROM cliente";



                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);



                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BancodeDados.obterInstancia().conectar();
                ControladorCadastroCliente controladorCliente = new ControladorCadastroCliente();

                Cliente cliente = new Cliente();

                string idString = campoPesqID.Text;

                if (int.TryParse(idString, out int id))
                {
                    cliente.id_cliente = id;
                    controladorCliente.selecionar(cliente);

                    DataTable resultado = new DataTable();
                    resultado.Columns.Add("id_cliente", typeof(int));
                    resultado.Columns.Add("nome_cliente", typeof(string));
                    resultado.Columns.Add("cpf_cnpj_cliente", typeof(string));
                    resultado.Columns.Add("logradouro_cliente", typeof(string));
                    resultado.Columns.Add("numero_logradouro_cliente", typeof(string));
                    resultado.Columns.Add("cidade_cliente", typeof(string));
                    resultado.Columns.Add("telefone_cliente", typeof(string));
                    resultado.Columns.Add("email_cliente", typeof(string));

                    DataRow newRow = resultado.NewRow();
                    newRow["id_cliente"] = cliente.id_cliente;
                    newRow["nome_cliente"] = cliente.nome_cliente;
                    newRow["cpf_cnpj_cliente"] = cliente.cpf_cnpj_cliente;
                    newRow["telefone_cliente"] = cliente.telefone_cliente;
                    newRow["email_cliente"] = cliente.email_cliente;
                    newRow["logradouro_cliente"] = cliente.logradouro_cliente;
                    newRow["numero_logradouro_cliente"] = cliente.numero_logradouro_cliente;
                    newRow["cidade_cliente"] = cliente.cidade_cliente;

                    resultado.Rows.Add(newRow);

                    dataGridView1.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID válido.");
                }

                BancodeDados.obterInstancia().desconectar();
            }

        }

        private void campoPesqNome_TextChanged(object sender, EventArgs e)
        {
            string textoPesquisa = campoPesqNome.Text;
            string comandoSql = "SELECT cliente.id_cliente, cliente.nome_cliente, cliente.telefone_cliente, cliente.email_cliente, cliente.logradouro_cliente, cliente.numero_logradouro_cliente, cliente.cidade_cliente FROM cliente WHERE cliente.nome_cliente LIKE @textoPesquisa";

            try
            {
                BancodeDados.obterInstancia().conectar();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@textoPesquisa", "%" + textoPesquisa + "%");
                    DataTable dataTable = new DataTable();

                    // Adiciona manualmente as colunas ao DataTable
                    dataTable.Columns.Add("id_cliente", typeof(int));
                    dataTable.Columns.Add("nome_cliente", typeof(string));
                    dataTable.Columns.Add("telefone_cliente", typeof(string));
                    dataTable.Columns.Add("email_cliente", typeof(string));
                    dataTable.Columns.Add("logradouro_cliente", typeof(string));
                    dataTable.Columns.Add("numero_logradouro_cliente", typeof(string));
                    dataTable.Columns.Add("cidade_cliente", typeof(string));

                    // Preenche o DataTable com os dados do banco de dados
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
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
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_cliente, nome_cliente, telefone_cliente, email_cliente, logradouro_cliente, numero_logradouro_cliente, cidade_cliente FROM cliente";



                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);



                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int idCliente = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_cliente"].Value);

                    Cliente cliente = new Cliente();
                    cliente.id_cliente = idCliente;

                    ControladorCadastroCliente controlador = new ControladorCadastroCliente();
                    controlador.excluir(cliente);

                    // Remove a linha da tabela
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Cliente Excluído com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Selecione um cliente para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int idClasse = Convert.ToInt32(row.Cells["id_cliente"].Value);

                // Abra a nova tela para edição, passando o idClasse como parâmetro se necessário
                TelaAtualizacaoCliente telaEdicao = new TelaAtualizacaoCliente();
                telaEdicao.IdCliente = idClasse;
                telaEdicao.ShowDialog();

            }
        }
    }
}
