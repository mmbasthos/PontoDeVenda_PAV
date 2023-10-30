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
    public partial class ContaPagarPagamento : Form
    {
        private decimal valorPagar;
        private int idConta;

        public ContaPagarPagamento(decimal valor, int idConta)
        {
            InitializeComponent();
            this.valorPagar = valor;
            this.idConta = idConta;
        }

        public void MovimentoSaida(int caixaAtual)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                ContasPagar contasPagar = new ContasPagar();
                // Adicione um log para verificar se a conexão está aberta

                ControladorCompras controladorCompras = new ControladorCompras();
                ControladorCaixa controladorCaixa = new ControladorCaixa();
                ControladorMovimentoCaixa controladorMovimentoCaixa = new ControladorMovimentoCaixa();
                MovimentoCaixa movimentoCaixa = new MovimentoCaixa();
                string nomeFormaPagamento = campoFormaPag.Text;
                int idCompra = controladorCompras.compraAtual();
                decimal valor = valorPagar;
                movimentoCaixa.data_movimento = DateTime.Now.Date;
                movimentoCaixa.hora_movimento = DateTime.Now.TimeOfDay;
                movimentoCaixa.descricao_movimento = "P.Conta";
                movimentoCaixa.tipo_movimento = "S";
                movimentoCaixa.valor_movimento = valor;
                movimentoCaixa.Caixa_id_caixa = caixaAtual;
                movimentoCaixa.formapagamento = nomeFormaPagamento;


                controladorMovimentoCaixa.incluir(movimentoCaixa);

                string comandoSql = "UPDATE conta_pagar SET descricao_pagar = @novaDescricao, valor_pago = @novoValorPago WHERE id_conta_pagar = @idConta";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@novaDescricao", "Paga");
                    comando.Parameters.AddWithValue("@novoValorPago", valorPagar);
                    comando.Parameters.AddWithValue("@idConta", idConta);

                    comando.ExecuteNonQuery();
                }

                contasPagar.botao();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                decimal valorFormaPagamento = valorPagar;





                // Inserir a forma de pagamento
                ControladorFormaPagamentoCompra controladorFormaPagamentoCompra = new ControladorFormaPagamentoCompra();
                FormaPagamentoCompra formaPagamentoCompra = new FormaPagamentoCompra();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();

                formaPagamentoCompra.Compra_id_compra = idCompra;
                formaPagamentoCompra.Forma_Pagamento_id_forma_pagamento = idFormaPagamento;
                formaPagamentoCompra.valor_forma_pagamento = valorFormaPagamento;

                controladorFormaPagamentoCompra.incluir(formaPagamentoCompra);


                int idCaixa = controladorCaixa.caixaAtual();
                controladorCaixa.AtualizarSaldoCaixaCompra(idCaixa, valorFormaPagamento);
                MessageBox.Show("Parcela Paga com Sucesso");
                MovimentoSaida(idCaixa);
     
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Pagamento: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
            Close();

        }

        private void ContaPagarPagamento_Load(object sender, EventArgs e)
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

                campoTotal.Text = "Total da Parcela: " + valorPagar.ToString("C");


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
    }
}
