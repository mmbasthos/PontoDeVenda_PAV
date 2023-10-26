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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PontoDeVenda_PAV.Interface
{
    public partial class FinalizarCompraPagamento : Form
    {
        public FinalizarCompraPagamento()
        {
            InitializeComponent();
        }

        public void parcelamento(int idCompra)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                ControladorCompras controlador = new ControladorCompras();
                ControladorContaPagar controladorContaPagar = new ControladorContaPagar();
                int parcelas = Convert.ToInt32(Parcelamento.SelectedItem);
                DateTime dataVencimento = DateTime.Now; // Data inicial
                decimal valorTotal = controlador.ObterTotalCompra(idCompra); // Obtém o valor total da compra
                int idfornecedor = controlador.ObterIdFornecedorPorIdCompra(idCompra);

                // Insere as parcelas no banco de dados
                for (int i = 1; i <= parcelas; i++)
                {
                    ContaPagar novaParcela = new ContaPagar();

                    novaParcela.descricao_pagar= "Parcela" + i;
                    novaParcela.data_lancamento = DateTime.Now.Date;
                    novaParcela.data_vencimento = dataVencimento;
                    novaParcela.valor_total = valorTotal;// Divide o valor total pelo número de parcelas
                    novaParcela.valor_pago = 0;
                    novaParcela.data_pagamento = DateTime.Now.Date;
                    novaParcela.valor_pagamento = valorTotal / parcelas;
                    novaParcela.Fornecedor_id_fornecedor = idfornecedor; // Substitua pelo ID do fornecedor


                    // Insere a nova parcela no banco de dados
                    controladorContaPagar.incluir(novaParcela);

                    // Adiciona 30 dias para a próxima parcela
                    dataVencimento = dataVencimento.AddDays(30);
                }

                MessageBox.Show("Parcelas criadas com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar parcelas: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        public void MovimentoSaida(int caixaAtual)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                // Adicione um log para verificar se a conexão está aberta

                ControladorCompras controladorCompras = new ControladorCompras();
                ControladorCaixa controladorCaixa = new ControladorCaixa();
                ControladorMovimentoCaixa controladorMovimentoCaixa = new ControladorMovimentoCaixa();
                MovimentoCaixa movimentoCaixa = new MovimentoCaixa();
                string nomeFormaPagamento = campoFormaPag.Text;
                int idCompra = controladorCompras.compraAtual();
                decimal valor = controladorCompras.ObterTotalCompra(idCompra);
                movimentoCaixa.data_movimento = DateTime.Now.Date;
                movimentoCaixa.hora_movimento = DateTime.Now.TimeOfDay;
                movimentoCaixa.descricao_movimento = "Compra";
                movimentoCaixa.tipo_movimento = "S";
                movimentoCaixa.valor_movimento = valor;
                movimentoCaixa.Caixa_id_caixa = caixaAtual;
                movimentoCaixa.formapagamento = nomeFormaPagamento;


                controladorMovimentoCaixa.incluir(movimentoCaixa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir movimentação: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }

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

                ControladorCompras controladorCompras = new ControladorCompras();
                int idVenda = controladorCompras.compraAtual();
                decimal totalCompra = controladorCompras.ObterTotalCompra(idVenda);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                // Obter os valores selecionados
                int idFormaPagamento = (int)campoFormaPag.SelectedValue;
                // Obter o ID da venda atual
                ControladorCompras controladorCompras = new ControladorCompras();
                ControladorCaixa controladorCaixa = new ControladorCaixa();
                int idCompra = controladorCompras.compraAtual();
                decimal valorFormaPagamento = controladorCompras.ObterTotalCompra(idCompra);





                // Inserir a forma de pagamento
                ControladorFormaPagamentoCompra controladorFormaPagamentoCompra = new ControladorFormaPagamentoCompra();
                FormaPagamentoCompra formaPagamentoCompra = new FormaPagamentoCompra();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();
                ControladorItemCompra controladorItemCompra = new ControladorItemCompra();

                formaPagamentoCompra.Compra_id_compra = idCompra;
                formaPagamentoCompra.Forma_Pagamento_id_forma_pagamento = idFormaPagamento;
                formaPagamentoCompra.valor_forma_pagamento = valorFormaPagamento;

                controladorFormaPagamentoCompra.incluir(formaPagamentoCompra);


                int idCaixa = controladorCaixa.caixaAtual();
                controladorCaixa.AtualizarSaldoCaixaCompra(idCaixa, valorFormaPagamento);
                MessageBox.Show("Compra Concluída com Sucesso");

                List<ItemCompra> itensCompra = controladorItemCompra.ObterItensDaCompra(idCompra);


                foreach (ItemCompra itemCompra in itensCompra)
                {
                    int idProduto = itemCompra.Produto_id_produto;
                    int quantidade = itemCompra.quantidade_compra;

                    controladorCadastroProdutos.AumentarEstoque(idProduto, quantidade);
                }

                MovimentoSaida(idCaixa);

                string formaPagamentoSelecionada = campoFormaPag.Text;
                if (formaPagamentoSelecionada == "Crediário")
                {
                    parcelamento(idCompra);
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Compra: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
            Close();

        }
    }
}
