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
using static System.Windows.Forms.DataFormats;

namespace PontoDeVenda_PAV.Interface
{
    public partial class MenuEstoque : Form
    {
        public MenuEstoque()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastroClassificacaoProduto cadastroClassificacaoProduto = new TelaCadastroClassificacaoProduto();
            cadastroClassificacaoProduto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaTipoProduto consultaTipoProduto = new ConsultaTipoProduto();
            consultaTipoProduto.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telaCadastroProduto = new TelaCadastroProduto();
            telaCadastroProduto.ShowDialog();
        }

        private void MenuEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT * FROM classe_produto";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBoxFiltroTipo.DisplayMember = "nome_classe"; // Define o campo que será exibido no ComboBox
                    comboBoxFiltroTipo.ValueMember = "id_classe"; // Define o valor associado a cada item

                    // Adiciona os itens ao ComboBox
                    comboBoxFiltroTipo.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar classes: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT produto.id_produto, produto.nome_produto, produto.preco_produto, produto.quantidade_produto, classe_produto.nome_classe, fornecedor.nome_fornecedor " +
                                    "FROM produto " +
                                    "JOIN fornecedor ON produto.Fornecedor_id_fornecedor = fornecedor.id_fornecedor " +
                                    "JOIN classe_produto ON produto.id_classe = classe_produto.id_classe";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Associar o DataTable ao DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Reorganizar as colunas
                    dataGridView1.Columns["id_produto"].DisplayIndex = 0;
                    dataGridView1.Columns["nome_produto"].DisplayIndex = 1;
                    dataGridView1.Columns["preco_produto"].DisplayIndex = 2;
                    dataGridView1.Columns["quantidade_produto"].DisplayIndex = 3;
                    dataGridView1.Columns["nome_classe"].DisplayIndex = 4;
                    dataGridView1.Columns["nome_fornecedor"].DisplayIndex = 5;
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

        private void campoPesqID_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        BancodeDados.obterInstancia().conectar();
                        ControladorCadastroProdutos controladorProdutos = new ControladorCadastroProdutos();

                        Produtos produto = new Produtos();

                        string idString = campoPesqID.Text;

                        if (int.TryParse(idString, out int id))
                        {
                            produto.id_produto = id;
                            controladorProdutos.selecionar(produto);

                            string comandoSql =
                                "SELECT produto.id_produto, produto.nome_produto, produto.preco_produto, produto.quantidade_produto, " +
                                "classe_produto.nome_classe, fornecedor.nome_fornecedor " +
                                "FROM produto " +
                                "JOIN fornecedor ON produto.Fornecedor_id_fornecedor = fornecedor.id_fornecedor " +
                                "JOIN classe_produto ON produto.id_classe = classe_produto.id_classe " +
                                "WHERE produto.id_produto = @id_produto";

                            using (MySqlCommand cmd = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                            {
                                cmd.Parameters.AddWithValue("@id_produto", produto.id_produto);
                                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                dataGridView1.DataSource = dataTable;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um ID válido.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao realizar a pesquisa: " + ex.Message);
                    }
                    finally
                    {
                        BancodeDados.obterInstancia().desconectar();
                    }
                }

            }
        }

        private void campoPesqNome_TextChanged(object sender, EventArgs e)
        {
            string textoPesquisa = campoPesqNome.Text;
            string comandoSql = "SELECT produto.id_produto, produto.nome_produto, produto.preco_produto, produto.quantidade_produto, classe_produto.nome_classe, fornecedor.nome_fornecedor " +
                                "FROM produto " +
                                "JOIN fornecedor ON produto.Fornecedor_id_fornecedor = fornecedor.id_fornecedor " +
                                "JOIN classe_produto ON produto.id_classe = classe_produto.id_classe " +
                                "WHERE produto.nome_produto LIKE @textoPesquisa";

            try
            {
                BancodeDados.obterInstancia().conectar();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@textoPesquisa", "%" + textoPesquisa + "%");
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int idProduto = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_produto"].Value);

                    Produtos produto = new Produtos();
                    produto.id_produto = idProduto;

                    ControladorCadastroProdutos controlador = new ControladorCadastroProdutos();
                    controlador.excluir(produto);

                    // Remove a linha da tabela
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Produto Excluído com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Selecione um produto para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT produto.id_produto, produto.nome_produto, produto.preco_produto, produto.quantidade_produto, classe_produto.nome_classe, fornecedor.nome_fornecedor " +
                                    "FROM produto " +
                                    "JOIN fornecedor ON produto.Fornecedor_id_fornecedor = fornecedor.id_fornecedor " +
                                    "JOIN classe_produto ON produto.id_classe = classe_produto.id_classe";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Associar o DataTable ao DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Reorganizar as colunas
                    dataGridView1.Columns["id_produto"].DisplayIndex = 0;
                    dataGridView1.Columns["nome_produto"].DisplayIndex = 1;
                    dataGridView1.Columns["preco_produto"].DisplayIndex = 2;
                    dataGridView1.Columns["quantidade_produto"].DisplayIndex = 3;
                    dataGridView1.Columns["nome_classe"].DisplayIndex = 4;
                    dataGridView1.Columns["nome_fornecedor"].DisplayIndex = 5;
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
                int idProduto = Convert.ToInt32(row.Cells["id_produto"].Value);

                TelaAtualizacaoProduto telaAtualizacaoProduto = new TelaAtualizacaoProduto();
                telaAtualizacaoProduto.IdProduto = idProduto;
                telaAtualizacaoProduto.ShowDialog();
            }
        }

        private void comboBoxFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                int idClasseSelecionada = Convert.ToInt32(comboBoxFiltroTipo.SelectedValue);

                string comandoSql =
                    "SELECT produto.id_produto, produto.nome_produto, produto.preco_produto, produto.quantidade_produto, " +
                    "classe_produto.nome_classe, fornecedor.nome_fornecedor " +
                    "FROM produto " +
                    "JOIN fornecedor ON produto.Fornecedor_id_fornecedor = fornecedor.id_fornecedor " +
                    "JOIN classe_produto ON produto.id_classe = classe_produto.id_classe " +
                    "WHERE classe_produto.id_classe = @id_classe";

                using (MySqlCommand cmd = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    cmd.Parameters.AddWithValue("@id_classe", idClasseSelecionada);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void campoPesqID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
