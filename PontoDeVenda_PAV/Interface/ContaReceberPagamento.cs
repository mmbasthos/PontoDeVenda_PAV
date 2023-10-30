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
    public partial class ContaReceberPagamento : Form
    {
        private decimal valorReceber;
        private int idConta;
        public ContaReceberPagamento(decimal valor, int idConta)
        {
            InitializeComponent();
            this.valorReceber = valor;
            this.idConta = idConta;
        }

        public void MovimentoEntrada(int caixaAtual)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                // Adicione um log para verificar se a conexão está aberta
                int idFormaPagamento = (int)campoFormaPag.SelectedValue;
                string nomeFormaPagamento = campoFormaPag.Text;
                ControladorVendas controladorVenda = new ControladorVendas();
                ControladorCaixa controladorCaixa = new ControladorCaixa();
                ControladorMovimentoCaixa controladorMovimentoCaixa = new ControladorMovimentoCaixa();
                MovimentoCaixa movimentoCaixa = new MovimentoCaixa();
                int idVenda = controladorVenda.vendaAtual();
                decimal valor = valorReceber;
                movimentoCaixa.data_movimento = DateTime.Now.Date;
                movimentoCaixa.hora_movimento = DateTime.Now.TimeOfDay;
                movimentoCaixa.descricao_movimento = "R.Conta";
                movimentoCaixa.tipo_movimento = "E";
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
        private void ContaReceberPagamanto_Load(object sender, EventArgs e)
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

                campoTotal.Text = "Total da Parcela: " + valorReceber.ToString("C");


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
                ControladorVendas controladorVendas = new ControladorVendas();
                ControladorCaixa controladorCaixa = new ControladorCaixa();
                int idVenda = controladorVendas.vendaAtual();
                decimal valorFormaPagamento = valorReceber;

                // Constrói o comando SQL para atualizar a conta
                string comandoSql = "UPDATE conta_receber SET descricao_receber = @novaDescricao, valor_recebimento = @novoValorPago WHERE id_conta_receber = @idConta";

                using (MySqlCommand comando = new MySqlCommand(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    comando.Parameters.AddWithValue("@novaDescricao", "Paga");
                    comando.Parameters.AddWithValue("@novoValorPago", valorReceber);
                    comando.Parameters.AddWithValue("@idConta", idConta);

                    // Executa o comando
                    comando.ExecuteNonQuery();
                }




                // Inserir a forma de pagamento
                ControladorFormaPagamentoVenda controladorFormaPagamentoVenda = new ControladorFormaPagamentoVenda();
                FormaPagamentoVenda formaPagamentoVenda = new FormaPagamentoVenda();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();

                formaPagamentoVenda.Venda_id_venda = idVenda;
                formaPagamentoVenda.Forma_Pagamento_id_forma_pagamento = idFormaPagamento;
                formaPagamentoVenda.valor_forma_pagamento = valorFormaPagamento;

                controladorFormaPagamentoVenda.incluir(formaPagamentoVenda);


                int idCaixa = controladorCaixa.caixaAtual();
                controladorCaixa.AtualizarSaldoCaixaCompra(idCaixa, valorFormaPagamento);
               

                MovimentoEntrada(idCaixa);

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
    }
}
