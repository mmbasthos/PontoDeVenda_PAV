using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Controladores;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;

namespace PontoDeVenda_PAV.Interface
{
    public partial class TelaAtualizacaoProduto : Form
    {
        public int IdProduto { get; set; }

        public TelaAtualizacaoProduto()
        {
            InitializeComponent();
        }

        private void TelaAtualizacaoProduto_Load(object sender, EventArgs e)
        {
            PopularDadosNasCelulas();

            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSqlFornecedor = "SELECT id_fornecedor, nome_fornecedor FROM fornecedor";
                string comandoSqlTipoProduto = "SELECT id_classe, nome_classe FROM classe_produto";

                using (MySqlDataAdapter adapterFornecedor = new MySqlDataAdapter(comandoSqlFornecedor, BancodeDados.obterInstancia().obterConexao()))
                using (MySqlDataAdapter adapterTipoProduto = new MySqlDataAdapter(comandoSqlTipoProduto, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTableFornecedor = new DataTable();
                    DataTable dataTableTipoProduto = new DataTable();

                    adapterFornecedor.Fill(dataTableFornecedor);
                    adapterTipoProduto.Fill(dataTableTipoProduto);

                    comboBoxFornecedorProd.DataSource = dataTableFornecedor;
                    comboBoxFornecedorProd.DisplayMember = "nome_fornecedor";
                    comboBoxFornecedorProd.ValueMember = "id_fornecedor";

                    comboBoxTipoProd.DataSource = dataTableTipoProduto;
                    comboBoxTipoProd.DisplayMember = "nome_classe";
                    comboBoxTipoProd.ValueMember = "id_classe";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores/tipos de produto: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void PopularDadosNasCelulas()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();
                Produtos produtos = new Produtos();

                int idProduto = this.IdProduto;
                produtos.id_produto = idProduto;

                controladorCadastroProdutos.selecionar(produtos);

                campoNomeProd.Text = produtos.nome_produto;
                campoPrecoProd.Text = produtos.preco_produto.ToString();
                campoQTDProd.Text = produtos.quantidade_produto.ToString();

                comboBoxFornecedorProd.SelectedValue = produtos.id_fornecedor;
                comboBoxTipoProd.SelectedValue = produtos.id_classe;
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

        private void AtualizarDados()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();
                Produtos produtos = new Produtos();

                produtos.id_produto = this.IdProduto;
                produtos.nome_produto = campoNomeProd.Text;
                produtos.preco_produto = decimal.Parse(campoPrecoProd.Text);
                produtos.quantidade_produto = int.Parse(campoQTDProd.Text);
                produtos.id_fornecedor = (int)comboBoxFornecedorProd.SelectedValue;
                produtos.id_classe = (int)comboBoxTipoProd.SelectedValue;

                controladorCadastroProdutos.atualizar(produtos);

                MessageBox.Show("Produto Atualizado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
                Close();
            }
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
