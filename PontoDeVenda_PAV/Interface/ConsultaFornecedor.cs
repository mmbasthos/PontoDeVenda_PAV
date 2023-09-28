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
    public partial class ConsultaFornecedor : Form
    {
        public ConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void ConsultaFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_fornecedor, nome_fornecedor, telefone_fornecedor, email_fornecedor, logradouro_fornecedor, numero_logradouro_fornecedor, cidade_fornecedor FROM fornecedor";


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BancodeDados.obterInstancia().conectar();
                ControladorCadastroFornecedor controladorFornecedor = new ControladorCadastroFornecedor();

                Fornecedor fornecedor = new Fornecedor();

                string idString = campoPesqID.Text;

                if (int.TryParse(idString, out int id))
                {
                    fornecedor.id_fornecedor = id;
                    controladorFornecedor.selecionar(fornecedor);

                    DataTable resultado = new DataTable();
                    resultado.Columns.Add("id_fornecedor", typeof(int));
                    resultado.Columns.Add("nome_fornecedor", typeof(string));
                    resultado.Columns.Add("cpf_cnpj_fornecedor", typeof(string));
                    resultado.Columns.Add("logradouro_fornecedor", typeof(string));
                    resultado.Columns.Add("numero_logradouro_fornecedor", typeof(string));
                    resultado.Columns.Add("cidade_fornecedor", typeof(string));
                    resultado.Columns.Add("telefone_fornecedor", typeof(string));
                    resultado.Columns.Add("email_fornecedor", typeof(string));

                    DataRow newRow = resultado.NewRow();
                    newRow["id_fornecedor"] = fornecedor.id_fornecedor;
                    newRow["nome_fornecedor"] = fornecedor.nome_fornecedor;
                    newRow["cpf_cnpj_fornecedor"] = fornecedor.cpf_cnpj_fornecedor;
                    newRow["telefone_fornecedor"] = fornecedor.telefone_fornecedor;
                    newRow["email_fornecedor"] = fornecedor.email_fornecedor;
                    newRow["logradouro_fornecedor"] = fornecedor.logradouro_fornecedor;
                    newRow["numero_logradouro_fornecedor"] = fornecedor.numero_logradouro_fornecedor;
                    newRow["cidade_fornecedor"] = fornecedor.cidade_fornecedor;



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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textoPesquisa = campoPesqNome.Text;
            string comandoSql = "SELECT id_fornecedor, nome_fornecedor, cpf_cnpj_fornecedor, logradouro_fornecedor, numero_logradouro_fornecedor, cidade_fornecedor, telefone_fornecedor, email_fornecedor FROM fornecedor WHERE nome_fornecedor LIKE @textoPesquisa";

            try
            {
                BancodeDados.obterInstancia().conectar();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {


                    adapter.SelectCommand.Parameters.AddWithValue("@textoPesquisa", "%" + textoPesquisa + "%");
                    DataTable dataTable = new DataTable();

                    // Adiciona manualmente as colunas ao DataTable
                    dataTable.Columns.Add("id_fornecedor", typeof(int));
                    dataTable.Columns.Add("nome_fornecedor", typeof(string));
                    dataTable.Columns.Add("cpf_cnpj_fornecedor", typeof(string));
                    dataTable.Columns.Add("logradouro_fornecedor", typeof(string));
                    dataTable.Columns.Add("numero_logradouro_fornecedor", typeof(string));
                    dataTable.Columns.Add("cidade_fornecedor", typeof(string));
                    dataTable.Columns.Add("telefone_fornecedor", typeof(string));
                    dataTable.Columns.Add("email_fornecedor", typeof(string));

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

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int idFornecedor = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_fornecedor"].Value);

                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.id_fornecedor = idFornecedor;

                    ControladorCadastroFornecedor controlador = new ControladorCadastroFornecedor();
                    controlador.excluir(fornecedor);

                    // Remove a linha da tabela
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Fornecedor Excluído com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_fornecedor, nome_fornecedor, telefone_fornecedor, email_fornecedor, logradouro_fornecedor, numero_logradouro_fornecedor, cidade_fornecedor FROM fornecedor";


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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int idClasse = Convert.ToInt32(row.Cells["id_fornecedor"].Value);

                // Abra a nova tela para edição, passando o idClasse como parâmetro se necessário
                TelaAtualizacaoFornecedor telaAtualizacaoFornecedor = new TelaAtualizacaoFornecedor();
                telaAtualizacaoFornecedor.IdFornecedor = idClasse;
                telaAtualizacaoFornecedor.ShowDialog();

            }
        }
    }
}
