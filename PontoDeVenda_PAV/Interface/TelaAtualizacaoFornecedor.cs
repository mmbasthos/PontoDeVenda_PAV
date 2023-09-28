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
    public partial class TelaAtualizacaoFornecedor : Form
    {
        public int IdFornecedor { get; set; }
        public TelaAtualizacaoFornecedor()
        {
            InitializeComponent();
        }

        private void TelaAtualizacaoFornecedor_Load(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            int IdFornecedor = this.IdFornecedor;
            ControladorCadastroFornecedor controladorCadastroFornecedor = new ControladorCadastroFornecedor();
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.id_fornecedor = IdFornecedor;
            controladorCadastroFornecedor.selecionar(fornecedor);

            campoFornecedorNome.Text = fornecedor.nome_fornecedor;
            campoFornecedorCpf.Text = fornecedor.cpf_cnpj_fornecedor;
            campoFornecedorTelefone.Text = fornecedor.telefone_fornecedor;
            campoFornecedorEmail.Text = fornecedor.email_fornecedor;
            campoFornecedorLogradouro.Text = fornecedor.logradouro_fornecedor;
            campoFornecedorNumeroLog.Text = fornecedor.numero_logradouro_fornecedor;
            campoFornecedorComplemento.Text = fornecedor.complemento_fornecedor;
            campoFornecedorBairro.Text = fornecedor.bairro_fornecedor;
            campoFornecedorCidade.Text = fornecedor.cidade_fornecedor;
            campoFornecedorCep.Text = fornecedor.cep_fornecedor;

            comboBoxEstadoFornecedor.SelectedItem = fornecedor.estado_fornecedor;
            BancodeDados.obterInstancia().desconectar();

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                ControladorCadastroFornecedor controladorFornecedor = new ControladorCadastroFornecedor();
                int idFornecedor = this.IdFornecedor;
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.id_fornecedor = idFornecedor;
                controladorFornecedor.selecionar(fornecedor);

                fornecedor.nome_fornecedor = campoFornecedorNome.Text;
                fornecedor.cpf_cnpj_fornecedor = campoFornecedorCpf.Text;
                fornecedor.telefone_fornecedor = campoFornecedorTelefone.Text;
                fornecedor.email_fornecedor = campoFornecedorEmail.Text;
                fornecedor.logradouro_fornecedor = campoFornecedorLogradouro.Text;
                fornecedor.numero_logradouro_fornecedor = campoFornecedorNumeroLog.Text;
                fornecedor.complemento_fornecedor = campoFornecedorComplemento.Text;
                fornecedor.bairro_fornecedor = campoFornecedorBairro.Text;
                fornecedor.cidade_fornecedor = campoFornecedorCidade.Text;
                fornecedor.cep_fornecedor = campoFornecedorCep.Text;

                controladorFornecedor.atualizar(fornecedor);

                MessageBox.Show("Fornecedor Atualizado!");
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

        private void checkBoxHabilitarEdicaoFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitarEdicao = checkBoxHabilitarEdicaoFornecedor.Checked;

            campoFornecedorNome.Enabled = habilitarEdicao;
            campoFornecedorCpf.Enabled = habilitarEdicao;
            campoFornecedorTelefone.Enabled = habilitarEdicao;
            campoFornecedorEmail.Enabled = habilitarEdicao;
            campoFornecedorLogradouro.Enabled = habilitarEdicao;
            campoFornecedorNumeroLog.Enabled = habilitarEdicao;
            campoFornecedorComplemento.Enabled = habilitarEdicao;
            campoFornecedorBairro.Enabled = habilitarEdicao;
            campoFornecedorCidade.Enabled = habilitarEdicao;
            comboBoxEstadoFornecedor.Enabled = habilitarEdicao;
            campoFornecedorCep.Enabled = habilitarEdicao;
        }
    }
}
