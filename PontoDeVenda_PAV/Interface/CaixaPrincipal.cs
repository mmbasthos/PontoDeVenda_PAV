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
        public bool modoVenda = true;
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
            label3.Text = "Cliente";

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

        private void AdicionarItemVenda()
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

                    itemVenda.id_produto = id;
                    itemVenda.id_venda = controladorVendas.vendaAtual();
                    itemVenda.valor_unitario_item = valorUnitario;
                    itemVenda.quantidade_item = qtdprod;
                    itemVenda.total_item = valorUnitario * qtdprod;

                    controladorItemVenda.incluir(itemVenda);

                    // Atualizar o estoque

                    /*
                    controladorCadastroProdutos.AtualizarEstoque(id, qtdprod);
                    */
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

        private void AdicionarItemCompra()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                ControladorItemCompra controladorItemCompra = new ControladorItemCompra();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();
                ControladorCompras controladorCompras = new ControladorCompras();

                string idString = campoAddNum.Text;

                if (int.TryParse(idString, out int id))
                {
                    ItemCompra itemCompra = new ItemCompra();
                    Produtos produto = new Produtos();
                    produto.id_produto = id;

                    decimal valorUnitario = controladorCadastroProdutos.ObterValorProdutoPorId(id);

                    campoNomeProd.Text = controladorCadastroProdutos.ObterNomeProdutoPorId(id);
                    campoPrecoProd.Text = valorUnitario.ToString();
                    campoQTDProd.Text = qtdprod.ToString();
                    decimal totalprod = qtdprod * valorUnitario;
                    campoTotalProd.Text = totalprod.ToString();

                    itemCompra.Produto_id_produto = id;
                    itemCompra.Compra_id_compra = controladorCompras.compraAtual();
                    itemCompra.valor_unitario_compra = valorUnitario;
                    itemCompra.quantidade_compra = qtdprod;
                    itemCompra.total_item_compra = valorUnitario * qtdprod;

                    controladorItemCompra.incluir(itemCompra);

                    // Atualizar o estoque
                    /*
                    controladorCadastroProdutos.AtualizarEstoque(id, qtdprod);
                    */
                    int idCompraAtual = controladorCompras.compraAtual();
                    decimal totalCompraAtual = controladorCompras.ObterTotalCompra(idCompraAtual);

                    novoTotal += valorUnitario * qtdprod;
                    label2.Text = novoTotal.ToString();

                    // Atualiza o banco de dados com o novo total
                    controladorCompras.AtualizarTotalCompra(idCompraAtual, novoTotal);
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
                AtualizarTabelaCompra();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (modoVenda)
            {
                AdicionarItemVenda();
            }
            else
            {
                AdicionarItemCompra();
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

        private decimal AtualizarTabelaCompra()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT p.id_produto, p.nome_produto, ic.valor_unitario_compra, ic.quantidade_compra, ic.total_item_compra " +
                           "FROM produto p " +
                           "JOIN item_compra ic ON p.id_produto = ic.Produto_id_produto " +
                           "WHERE ic.Compra_id_compra = @Compra_id_compra";
                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    ControladorCompras controladorCompras = new ControladorCompras();
                    int idCompraAtual = controladorCompras.compraAtual();
                    comando.Parameters.AddWithValue("@Compra_id_compra", idCompraAtual);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        // Calcular o total
                        decimal total = 0m;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            total += Convert.ToDecimal(row["total_item_compra"]);
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
            MostraItens();
        }

        private void MostraItens()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
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
            FinalizarVendaPagamento finalizarCompra = new FinalizarVendaPagamento();
            finalizarCompra.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (modoVenda)
            {
                ExcluirItemVenda();
            }
            else
            {
                ExcluirItemCompra();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ExcluirItemCompra()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                ControladorItemCompra controladorItemCompra = new ControladorItemCompra();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();
                ControladorCompras controladorCompras = new ControladorCompras();
                int idCompra = controladorCompras.compraAtual();

                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                    int idProduto = Convert.ToInt32(selectedRow.Cells["id_produto"].Value);
                    int quantidade = Convert.ToInt32(selectedRow.Cells["quantidade_compra"].Value);

                    // Deleta o item da venda
                    controladorItemCompra.Deletar(idProduto, idCompra);

                    // Atualiza o label com o novo total
                    decimal valorUnitario = Convert.ToDecimal(selectedRow.Cells["valor_unitario_compra"].Value);
                    decimal totalDelete = valorUnitario * quantidade;
                    novoTotal -= totalDelete; // Subtrai o total excluído
                    label2.Text = novoTotal.ToString();

                    // Atualiza o estoque
                    /*
                    controladorCadastroProdutos.AumentarEstoque(idProduto, quantidade);
                    */

                    controladorCompras.AtualizarTotalCompra(idCompra, novoTotal);

                    AtualizarTabela();
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
        private void ExcluirItemVenda()
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                ControladorItemVenda controladorItemVenda = new ControladorItemVenda();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();
                ControladorVendas controladorVendas = new ControladorVendas();
                int idVenda = controladorVendas.vendaAtual();

                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                    int idProduto = Convert.ToInt32(selectedRow.Cells["id_produto"].Value);
                    int quantidade = Convert.ToInt32(selectedRow.Cells["quantidade_item"].Value);

                    // Deleta o item da venda
                    controladorItemVenda.Deletar(idProduto, idVenda);

                    // Atualiza o label com o novo total
                    decimal valorUnitario = Convert.ToDecimal(selectedRow.Cells["valor_unitario_item"].Value);
                    decimal totalDelete = valorUnitario * quantidade;
                    novoTotal -= totalDelete; // Subtrai o total excluído
                    label2.Text = novoTotal.ToString();

                    // Atualiza o estoque
                    /*
                     controladorCadastroProdutos.AumentarEstoque(idProduto, quantidade);
                    */

                    controladorVendas.AtualizarTotalVenda(idVenda, novoTotal);

                    AtualizarTabela();
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

        private void CancelarVenda(int idVenda)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                ControladorVendas controladorVendas = new ControladorVendas();
                ControladorItemVenda controladorItemVenda = new ControladorItemVenda();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();

                // Obter os produtos da venda
                List<ItemVenda> itensVenda = controladorItemVenda.ObterItensDaVenda(idVenda);

                // Para cada produto, devolver ao estoque
                /*
                foreach (ItemVenda itemVenda in itensVenda)
                {
                    int idProduto = itemVenda.id_produto;
                    int quantidade = itemVenda.quantidade_item;

                    controladorCadastroProdutos.AumentarEstoque(idProduto, quantidade);
                }
                */

                // Atualizar a situação da venda
                controladorVendas.AtualizarSituacaoVenda(idVenda, "Cancelada");

                // Manter o valor total da venda
                decimal totalVenda = controladorVendas.ObterTotalVenda(idVenda);

                // Atualiza o label com o novo total (se necessário)
                label2.Text = totalVenda.ToString();

                // Atualiza a tabela (se necessário)
                AtualizarTabela();
                LimparCamposCaixaPrincipal();
                LimparTabelaProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar venda: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
                MessageBox.Show("Venda Cancelada!");
            }
        }

        private void CancelarCompra(int idVenda)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                ControladorCompras controladorCompras = new ControladorCompras();
                ControladorItemCompra controladorItemCompra = new ControladorItemCompra();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();

                // Obter os produtos da venda
                List<ItemCompra> itensCompra = controladorItemCompra.ObterItensDaCompra(idVenda);

                // Para cada produto, devolver ao estoque
                /*
                foreach (ItemCompra itemCompra in itensCompra)
                {
                    int idProduto = itemCompra.id_produto;
                    int quantidade = itemCompra.quantidade_compra;

                    controladorCadastroProdutos.AumentarEstoque(idProduto, quantidade);
                }
                */

                // Atualizar a situação da venda
                controladorCompras.AtualizarSituacaoCompra(idVenda, "Cancelada");

                // Manter o valor total da venda
                decimal totalVenda = controladorCompras.ObterTotalCompra(idVenda);

                // Atualiza o label com o novo total (se necessário)
                label2.Text = totalVenda.ToString();

                // Atualiza a tabela (se necessário)
                AtualizarTabela();
                LimparCamposCaixaPrincipal();
                LimparTabelaProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar compra: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
                MessageBox.Show("Compra Cancelada!");
            }
        }


        private void cancelarVendaF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControladorVendas controladorVendas = new ControladorVendas();
            int idVenda = controladorVendas.vendaAtual();
            CancelarVenda(idVenda);

        }

        private void iniciarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaIdentificarFornecedor telaIdentificarFornecedor = new TelaIdentificarFornecedor(this);
            telaIdentificarFornecedor.ShowDialog();
            LimparCamposCaixaPrincipal();
            LimparTabelaProdutos();
            label3.Text = "Fornecedor";
        }

        private void campoNomeProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
        }

        private void finalizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalizarCompraPagamento finalizarCompraPagamento = new FinalizarCompraPagamento();
            finalizarCompraPagamento.ShowDialog();
        }

        private void cancelarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControladorCompras controladorCompras = new ControladorCompras();
            int idCompra = controladorCompras.compraAtual();
            CancelarCompra(idCompra);
        }

        public string GerarRelatorio(int idCaixa)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                StringBuilder relatorio = new StringBuilder();

                string query = "SELECT descricao_movimento, tipo_movimento, valor_movimento, formapagamento FROM movimento_caixa WHERE Caixa_id_caixa = @idCaixa";

                MySqlCommand command = new MySqlCommand(query, BancodeDados.obterInstancia().obterConexao());
                command.Parameters.AddWithValue("@idCaixa", idCaixa);

                MySqlDataReader reader = command.ExecuteReader();

                relatorio.AppendLine($"Relatório de Fechamento do Caixa");
                relatorio.AppendLine("Descrição\tE/S\tValor");

                Dictionary<string, Dictionary<string, decimal>> valoresPorFormaPagamento = new Dictionary<string, Dictionary<string, decimal>>();

                decimal totalEntradas = 0;
                decimal totalSaidas = 0;

                while (reader.Read())
                {
                    string descricaoMovimento = reader["descricao_movimento"].ToString();
                    string tipoMovimento = reader["tipo_movimento"].ToString();
                    decimal valorMovimento = Convert.ToDecimal(reader["valor_movimento"]);
                    string formaPagamento = reader["formapagamento"].ToString();

                    if (!valoresPorFormaPagamento.ContainsKey(formaPagamento))
                    {
                        valoresPorFormaPagamento[formaPagamento] = new Dictionary<string, decimal>
                {
                    { "Entrada", 0 },
                    { "Saida", 0 }
                };
                    }

                    if (tipoMovimento == "E")
                    {
                        valoresPorFormaPagamento[formaPagamento]["Entrada"] += valorMovimento;
                        totalEntradas += valorMovimento;
                    }
                    else if (tipoMovimento == "S")
                    {
                        valoresPorFormaPagamento[formaPagamento]["Saida"] += valorMovimento;
                        totalSaidas += valorMovimento;
                    }

                    relatorio.AppendLine($"{descricaoMovimento}\t{tipoMovimento}\t{valorMovimento:C}");
                }

                relatorio.AppendLine();
                relatorio.AppendLine("Resumo");
                relatorio.AppendLine("Forma de Pgto\tEntradas\tSaídas\tTotal");

                foreach (var kvp in valoresPorFormaPagamento)
                {
                    string formaPagamento = kvp.Key;
                    decimal totalFormaEntradas = kvp.Value["Entrada"];
                    decimal totalFormaSaidas = kvp.Value["Saida"];
                    decimal totalForma = totalFormaEntradas - totalFormaSaidas;

                    relatorio.AppendLine($"{formaPagamento,-15}\t{totalFormaEntradas,10}\t{totalFormaSaidas,7}\t{totalForma,6}");
                }

                relatorio.AppendLine();
                relatorio.AppendLine($"Total Geral\t{totalEntradas,10}\t{totalSaidas,7}\t{totalEntradas - totalSaidas,6}");

                return relatorio.ToString();
            }
            catch (Exception ex)
            {
                return "Erro ao gerar relatório: " + ex.Message;
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }


















        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ControladorCaixa controladorCaixa = new ControladorCaixa();
            int idCaixa = controladorCaixa.ObterCaixaAtual(); // Substitua 1 pelo valor real do ID do caixa

            string relatorio = GerarRelatorio(idCaixa);

            MessageBox.Show(relatorio, "Relatório de Fechamento do Caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}

