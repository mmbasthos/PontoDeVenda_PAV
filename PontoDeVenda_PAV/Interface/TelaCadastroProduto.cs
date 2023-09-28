using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Controladores;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;
using System;
using System.Data;
using System.Windows.Forms;

namespace PontoDeVenda_PAV.Interface
{
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
        }

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_fornecedor, nome_fornecedor FROM fornecedor";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBoxFornecedorProd.DataSource = dataTable;
                    comboBoxFornecedorProd.DisplayMember = "nome_fornecedor";
                    comboBoxFornecedorProd.ValueMember = "id_fornecedor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }

            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_classe, nome_classe FROM classe_produto";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBoxTipoProd.DataSource = dataTable;
                    comboBoxTipoProd.DisplayMember = "nome_classe";
                    comboBoxTipoProd.ValueMember = "id_classe";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tipos de produto: " + ex.Message);
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

                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();

                Produtos produtos = new Produtos();

                if (string.IsNullOrEmpty(campoNomeProd.Text))
                {
                    MessageBox.Show("Por favor, insira um nome de produto.");
                    return;
                }

                if (!decimal.TryParse(campoPrecoProd.Text, out decimal preco))
                {
                    MessageBox.Show("Por favor, insira um valor de preço válido.");
                    return;
                }

                if (!int.TryParse(campoQTDProd.Text, out int quantidade))
                {
                    MessageBox.Show("Por favor, insira uma quantidade válida.");
                    return;
                }

                produtos.nome_produto = campoNomeProd.Text;
                produtos.preco_produto = preco;
                produtos.quantidade_produto = quantidade;

                DataRowView fornecedorSelecionado = (DataRowView)comboBoxFornecedorProd.SelectedItem;
                int idFornecedor = Convert.ToInt32(fornecedorSelecionado["id_fornecedor"]);
                produtos.id_fornecedor = idFornecedor;

                DataRowView tipoProdutoSelecionado = (DataRowView)comboBoxTipoProd.SelectedItem;
                int idTipoProduto = Convert.ToInt32(tipoProdutoSelecionado["id_classe"]);
                produtos.id_classe = idTipoProduto;

                controladorCadastroProdutos.incluir(produtos);
                MessageBox.Show("Produto Incluído com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir produto: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
            Close();
        }
    }
}
