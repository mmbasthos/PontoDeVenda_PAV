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
    public partial class CaixaPrincipal : Form
    {
        int qtdprod = 1;
       public decimal novoTotal;
       
        public CaixaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            ControladorCaixa controladorCaixa = new ControladorCaixa();
            int idCaixa = controladorCaixa.caixaAtual();

            decimal valorAumento = 100.00m;


            BancodeDados.obterInstancia().desconectar();
        }

        private void CaixaPrincipal_Load(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            ControladorCaixa controladorCaixa = new ControladorCaixa();
            int idCaixa = controladorCaixa.caixaAtual();
            campoIdCaixa.Text = idCaixa.ToString();
            campoNomeCaixa.Text = controladorCaixa.ObterNomeCaixa(idCaixa);

            BancodeDados.obterInstancia().desconectar();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void LimparCamposCaixaPrincipal()
        {
            campoAddNum.Text = "";
            campoNomeProd.Text = "";
            campoPrecoProd.Text = "";
            campoQTDProd.Text = "1";
            campoTotalProd.Text = "";
            campoTotalVenda.Text = "Total: 0,00";
            label2.Text = "0,00";
        }

        public void LimparTabelaProdutos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

        }


        private void cadastrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastroCliente telaCadastroCliente = new TelaCadastroCliente();
            telaCadastroCliente.ShowDialog();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes consultaClientes = new ConsultaClientes();
            consultaClientes.ShowDialog();
        }

        private void consultarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEstoque menuEstoque = new MenuEstoque();
            menuEstoque.Show();
        }

        private void iniciarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaIdentificarCliente telaIdentificarCliente = new TelaIdentificarCliente(this);
            telaIdentificarCliente.ShowDialog();
            LimparCamposCaixaPrincipal();
            LimparTabelaProdutos();

        }

        private void estoqueF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEstoque menuEstoque = new MenuEstoque();
            menuEstoque.Show();
        }

        private void inserirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInserirCodigoProduto telaInserirCódigoProduto = new TelaInserirCodigoProduto();
            telaInserirCódigoProduto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                BancodeDados.obterInstancia().conectar();


                ControladorItemVenda controladorItemVenda = new ControladorItemVenda();
                ControladorVendas controladorVendas = new ControladorVendas();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();

                string idString = campoAddNum.Text;

                if (int.TryParse(idString, out int id))
                {
                    ItemVenda itemVenda = new ItemVenda();
                    Produtos produto = new Produtos();
                    produto.id_produto = id;

                    decimal valorUnitario = controladorCadastroProdutos.ObterValorProdutoPorId(id);



                    itemVenda.id_produto = id;
                    itemVenda.id_venda = controladorVendas.vendaAtual();
                    itemVenda.valor_unitario_item = valorUnitario;
                    itemVenda.quantidade_item = qtdprod;
                    itemVenda.total_item = valorUnitario * qtdprod;

                    controladorItemVenda.incluir(itemVenda);

                    // Atualizar o estoque
                    controladorCadastroProdutos.AtualizarEstoque(id, qtdprod); // Reduz 1 do estoque
                    int idVendaAtual = controladorVendas.vendaAtual();
                    decimal totalVendaAtual = controladorVendas.ObterTotalVenda(idVendaAtual);

                    // Calcula o novo total da venda
                    novoTotal += valorUnitario * qtdprod;
                    label2.Text = novoTotal.ToString();

                    // Atualiza o banco de dados com o novo total
                    controladorVendas.AtualizarTotalVenda(idVendaAtual, novoTotal);


                }
                else
                {
                    MessageBox.Show("O texto não é um ID de produto válido.");
                }

                BancodeDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancodeDados.obterInstancia().cancelarTransacao();
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
                qtdprod = 1;
                AtualizarTabela();
            }


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                    // Obtendo o ID do produto
                    int idProduto = Convert.ToInt32(selectedRow.Cells["id_produto"].Value);

                    // Obtendo a quantidade
                    int quantidade = Convert.ToInt32(selectedRow.Cells["quantidade_item"].Value);

                    // Agora você tem o ID do produto e a quantidade para usar como precisar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados da linha selecionada: " + ex.Message);
            }
        }


        private decimal AtualizarTabela()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT p.id_produto, p.nome_produto, iv.valor_unitario_item, iv.quantidade_item, iv.total_item " +
                           "FROM produto p " +
                           "JOIN item_venda iv ON p.id_produto = iv.Produto_id_produto " +
                           "WHERE iv.id_venda = @id_venda";
                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    ControladorVendas controladorVendas = new ControladorVendas();
                    int idVendaAtual = controladorVendas.vendaAtual();
                    comando.Parameters.AddWithValue("@id_venda", idVendaAtual);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        // Calcular o total
                        decimal total = 0m;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            total += Convert.ToDecimal(row["total_item"]);
                        }

                        return total;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                return 0m; // Retorna 0 se houver um erro
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }


        private void campoAddNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();


                ControladorItemVenda controladorItemVenda = new ControladorItemVenda();
                ControladorVendas controladorVendas = new ControladorVendas();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();

                string idString = campoAddNum.Text;

                if (int.TryParse(idString, out int id))
                {
                    ItemVenda itemVenda = new ItemVenda();
                    Produtos produto = new Produtos();
                    produto.id_produto = id;

                    decimal valorUnitario = controladorCadastroProdutos.ObterValorProdutoPorId(id);

                    campoNomeProd.Text = controladorCadastroProdutos.ObterNomeProdutoPorId(id);
                    campoPrecoProd.Text = valorUnitario.ToString();
                    campoQTDProd.Text = qtdprod.ToString();
                    decimal totalprod = qtdprod * valorUnitario;
                    campoTotalProd.Text = totalprod.ToString();
                }

                BancodeDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancodeDados.obterInstancia().cancelarTransacao();
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void AtualizarCampos()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string idString = campoAddNum.Text;

                if (int.TryParse(idString, out int id))
                {
                    ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();

                    decimal valorUnitario = controladorCadastroProdutos.ObterValorProdutoPorId(id);

                    campoNomeProd.Text = controladorCadastroProdutos.ObterNomeProdutoPorId(id);
                    campoPrecoProd.Text = valorUnitario.ToString();
                    campoQTDProd.Text = qtdprod.ToString();
                    decimal totalprod = qtdprod * valorUnitario;
                    campoTotalProd.Text = totalprod.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os campos: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            qtdprod = qtdprod + 1;
            AtualizarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qtdprod = qtdprod - 1;
            if (qtdprod < 1) qtdprod = 1; // Evita valores negativos ou zero
            AtualizarCampos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private decimal ObterTotalVendaAtual()
        {
            ControladorVendas controladorVendas = new ControladorVendas();
            int idVendaAtual = controladorVendas.vendaAtual();
            decimal totalVendaAtual = controladorVendas.ObterTotalVenda(idVendaAtual);
            return totalVendaAtual;
        }


        private void finalizarVendaF7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalizarCompraPagamento finalizarCompra = new FinalizarCompraPagamento();
            finalizarCompra.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            try
            {
                ControladorVendas controladorVendas = new ControladorVendas();
                int idVendaAtual = controladorVendas.vendaAtual();
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                    int idProduto = Convert.ToInt32(selectedRow.Cells["id_produto"].Value);
                    int quantidade = Convert.ToInt32(selectedRow.Cells["quantidade_item"].Value);
                    decimal totalDelete = controladorVendas.ObterTotalVenda(idVendaAtual);
                    DeletarItemVenda(idProduto, quantidade);

                    // Atualiza o label com o novo total
                    novoTotal = ObterTotalVendaAtual()
                    label2.Text = novoTotal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar item: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }



        private void DeletarItemVenda(int idProduto, int quantidade)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                ControladorItemVenda controladorItemVenda = new ControladorItemVenda();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();
                ControladorVendas controladorVendas = new ControladorVendas();
                int idVenda = controladorVendas.vendaAtual();

                controladorItemVenda.Deletar(idProduto, idVenda);

                // Calcula o novo total da venda
                decimal valorUnitario = controladorCadastroProdutos.ObterValorProdutoPorId(idProduto);
                decimal novoTotal = ObterTotalVendaAtual() - (valorUnitario * quantidade);

                // Atualiza o banco de dados com o novo total
                controladorVendas.AtualizarTotalVenda(idVenda, novoTotal);

                // Retornar a quantidade para o estoque
                controladorCadastroProdutos.AumentarEstoque(idProduto, quantidade);

                AtualizarTabela();

                BancodeDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancodeDados.obterInstancia().cancelarTransacao();
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

                try
                {
                    BancodeDados.obterInstancia().conectar();
                    ControladorVendas controladorVendas = new ControladorVendas();

                    // Obtém o ID da venda atual
                    int idVendaAtual = controladorVendas.vendaAtual();

                // Atualiza o total da venda para 0

                    decimal valor = controladorVendas.ObterTotalVenda(idVendaAtual);
                controladorVendas.AtualizarTotalVenda(idVendaAtual, valor);
                    // Atualiza o rótulo na interface com o novo total
                    label2.Text = "0,00";
                    
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao zerar venda: " + ex.Message);
                }
                finally
                {
                    BancodeDados.obterInstancia().desconectar();
                }
            }

  
    }
}

