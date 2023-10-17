using System;
using System.Windows.Forms;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Controladores;
using PontoDeVenda_PAV.Persistencia;

namespace PontoDeVenda_PAV.Interface
{
    public partial class TelaAtualizacaoCliente : Form
    {
        public int IdCliente { get; set; }

        public TelaAtualizacaoCliente()
        {
            InitializeComponent();
        }

        private void TelaAtualizacaoCliente_Load(object sender, EventArgs e)
        {

            BancodeDados.obterInstancia().conectar();
            int idCliente = this.IdCliente;
            ControladorCadastroCliente controladorCliente = new ControladorCadastroCliente();
            Cliente cliente = new Cliente();
            cliente.id_cliente = idCliente;
            controladorCliente.selecionar(cliente);

            campoNomeCliente.Text = cliente.nome_cliente;
            campoCPFCliente.Text = cliente.cpf_cnpj_cliente;
            campoLogradouroCliente.Text = cliente.logradouro_cliente;
            campoNumeroLogCliente.Text = cliente.numero_logradouro_cliente;
            campoComplementoCliente.Text = cliente.complemento_cliente;
            campoBairroCliente.Text = cliente.bairro_cliente;
            campoCidadeCliente.Text = cliente.cidade_cliente;
            campoCepCliente.Text = cliente.cep_cliente;
            campoTelefoneCliente.Text = cliente.telefone_cliente;
            campoEmailCliente.Text = cliente.email_cliente;

            // Define o valor selecionado no ComboBox
            comboBoxEstadoCliente.SelectedItem = cliente.estado_cliente;
            BancodeDados.obterInstancia().desconectar();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                ControladorCadastroCliente controladorCliente = new ControladorCadastroCliente();
                int idCliente = this.IdCliente;
                Cliente cliente = new Cliente();
                cliente.id_cliente = idCliente;
                controladorCliente.selecionar(cliente);

                cliente.nome_cliente = campoNomeCliente.Text;
                cliente.cpf_cnpj_cliente = campoCPFCliente.Text;
                cliente.logradouro_cliente = campoLogradouroCliente.Text;
                cliente.numero_logradouro_cliente = campoNumeroLogCliente.Text;
                cliente.complemento_cliente = campoComplementoCliente.Text;
                cliente.bairro_cliente = campoBairroCliente.Text;
                cliente.cidade_cliente = campoCidadeCliente.Text;
                cliente.estado_cliente = comboBoxEstadoCliente.SelectedItem.ToString(); // Obtém o valor selecionado do ComboBox
                cliente.cep_cliente = campoCepCliente.Text;
                cliente.telefone_cliente = campoTelefoneCliente.Text;
                cliente.email_cliente = campoEmailCliente.Text;

                controladorCliente.atualizar(cliente);

                MessageBox.Show("Cliente Atualizado!");
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxHabilitarEdicaoFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitarEdicao = checkBoxEditarCliente.Checked;

            campoNomeCliente.Enabled = habilitarEdicao;
            campoCPFCliente.Enabled = habilitarEdicao;
            campoLogradouroCliente.Enabled = habilitarEdicao;
            campoNumeroLogCliente.Enabled = habilitarEdicao;
            campoComplementoCliente.Enabled = habilitarEdicao;
            campoBairroCliente.Enabled = habilitarEdicao;
            campoCidadeCliente.Enabled = habilitarEdicao;
            campoCepCliente.Enabled = habilitarEdicao;
            comboBoxEstadoCliente.Enabled = habilitarEdicao;
            campoTelefoneCliente.Enabled = habilitarEdicao;
            campoEmailCliente.Enabled = habilitarEdicao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
