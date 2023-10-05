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
    public partial class FinalizarCompraPagamento : Form
    {
        public FinalizarCompraPagamento()
        {
            InitializeComponent();
        }

        private string ObterNomeCliente(int idVenda)
        {
            BancodeDados.obterInstancia().conectar();
            try
            {
                string comandoSql = "SELECT c.nome_cliente " +
                                    "FROM venda v " +
                                    "JOIN cliente c ON v.Cliente_id_cliente = c.id_cliente " +
                                    "WHERE v.id_venda = @id_venda";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@id_venda", idVenda);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        return resultado.ToString();
                        BancodeDados.obterInstancia().desconectar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter nome do cliente: " + ex.Message);
            }

            return string.Empty; // Retorna uma string vazia se não encontrar o cliente
        }

        public List<ItemVenda> ObterItensVenda(int idVenda)
        {
            List<ItemVenda> itens = new List<ItemVenda>();

            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT * FROM item_venda WHERE id_venda = @id_venda";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@id_venda", idVenda);

                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            ItemVenda item = new ItemVenda();
                            item.lerDados(leitor);
                            itens.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter itens de venda: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }

            return itens;
        }


        public string GerarRelatorio(int idVenda)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                StringBuilder relatorio = new StringBuilder();

                // Obter nome do cliente
                string nomeCliente = ObterNomeCliente(idVenda);

                // Obter lista de itens da venda
                List<ItemVenda> itens = ObterItensVenda(idVenda);

                relatorio.AppendLine($"-----------------------------");
                relatorio.AppendLine($"        Relatório de Venda       ");
                relatorio.AppendLine($"-----------------------------");
                relatorio.AppendLine($"Venda: {idVenda:D3}");
                relatorio.AppendLine($"Data: {DateTime.Now.ToShortDateString()}");
                relatorio.AppendLine($"Hora: {DateTime.Now.ToShortTimeString()}");
                relatorio.AppendLine($"-----------------------------");

                if (!string.IsNullOrEmpty(nomeCliente))
                {
                    relatorio.AppendLine($"Cliente: {nomeCliente}");
                    relatorio.AppendLine($"-----------------------------");
                }

                relatorio.AppendLine($"Item   Descrição           Qtd   Preço   Total");
                relatorio.AppendLine($"-----------------------------");

                foreach (var item in itens)
                {
                    ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();
                    string nomeProduto = controladorCadastroProdutos.ObterNomeProdutoPorId(item.id_produto);
                    relatorio.AppendLine($"{item.id_produto:D4}   {nomeProduto}     {item.quantidade_item}   {item.valor_unitario_item:C}   {item.total_item:C}");
                }

                relatorio.AppendLine($"-----------------------------");

                // Calcular total
                decimal total = itens.Sum(item => item.total_item);
                relatorio.AppendLine($"Total: {total:C}");

                return relatorio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message);
                return "";
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

                // Obter os valores selecionados
                int idFormaPagamento = (int)campoFormaPag.SelectedValue;
                // Obter o ID da venda atual
                ControladorVendas controladorVendas = new ControladorVendas();
                int idVenda = controladorVendas.vendaAtual();
                decimal valorFormaPagamento = controladorVendas.ObterTotalVenda(idVenda);


                // Inserir a forma de pagamento
                ControladorFormaPagamentoVenda controladorFormaPagamentoVenda = new ControladorFormaPagamentoVenda();
                FormaPagamentoVenda formaPagamentoVenda = new FormaPagamentoVenda();

                formaPagamentoVenda.Venda_id_venda = idVenda;
                formaPagamentoVenda.Forma_Pagamento_id_forma_pagamento = idFormaPagamento;
                formaPagamentoVenda.valor_forma_pagamento = valorFormaPagamento;

                controladorFormaPagamentoVenda.incluir(formaPagamentoVenda);

                ControladorCaixa controladorCaixa = new ControladorCaixa();
                int idCaixa = controladorCaixa.caixaAtual();
                controladorCaixa.AtualizarSaldoCaixa(idCaixa, valorFormaPagamento);


                string relatorio = GerarRelatorio(idVenda);


                // Exibe o relatório em uma MessageBox
                MessageBox.Show(relatorio, "Relatório da Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Venda: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
            Close();

        }


        private void FinalizarCompraPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_forma_pagamento, nome_forma_pagamento FROM forma_pagamento";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    campoFormaPag.DataSource = dataTable;
                    campoFormaPag.DisplayMember = "nome_forma_pagamento";
                    campoFormaPag.ValueMember = "id_forma_pagamento";
                }

                ControladorVendas controladorVendas = new ControladorVendas();
                int idVenda = controladorVendas.vendaAtual();
                decimal totalCompra = controladorVendas.ObterTotalVenda(idVenda);
                campoTotal.Text = "Total da Compra: " + totalCompra.ToString("C");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar forma de pagamento " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void campoTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoDinRecebido_TextChanged(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            ControladorVendas controladorVendas = new ControladorVendas();
            int idVenda = controladorVendas.vendaAtual();
            decimal totalCompra = controladorVendas.ObterTotalVenda(idVenda);


            if (decimal.TryParse(campoDinRecebido.Text, out decimal valorDado))
            {
                if (valorDado >= totalCompra)
                {
                    decimal troco = valorDado - totalCompra;

                    campoTroco.Text = "Troco: " + troco.ToString("C");
                }
                else
                {
                    campoTroco.Text = "Pag. Insuficiente";
                }
            }
            BancodeDados.obterInstancia().desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
