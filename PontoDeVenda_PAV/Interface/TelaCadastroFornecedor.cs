using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Controladores;
using PontoDeVenda_PAV.Persistencia;


namespace PontoDeVenda_PAV.Interface
{
    public partial class TelaCadastroFornecedor : Form
    {
        public TelaCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();

            try
            {

                ControladorCadastroFornecedor controladorCadastroFornecedor = new ControladorCadastroFornecedor();

                Fornecedor fornecedor = new Fornecedor();

                fornecedor.nome_fornecedor = campoFornecedorNome.Text;
                fornecedor.cpf_cnpj_fornecedor = campoFornecedorCpf.Text;
                fornecedor.telefone_fornecedor = campoFornecedorTelefone.Text;
                fornecedor.email_fornecedor = campoFornecedorEmail.Text;

                fornecedor.logradouro_fornecedor = campoFornecedorLogradouro.Text;
                fornecedor.numero_logradouro_fornecedor = campoFornecedorNumeroLog.Text;
                fornecedor.complemento_fornecedor = campoFornecedorNumeroLog.Text;
                fornecedor.bairro_fornecedor = campoFornecedorBairro.Text;
                fornecedor.cidade_fornecedor = campoFornecedorCidade.Text;
                fornecedor.cep_fornecedor = campoFornecedorCep.Text;

                fornecedor.estado_fornecedor = comboBoxEstadoFornecedor.SelectedItem.ToString();

                controladorCadastroFornecedor.incluir(fornecedor);



                MessageBox.Show("Fornecedor Inserido com Sucesso!");
                // BancodeDados.obterInstancia().confirmarTransacao();

            }
            catch (Exception ex)
            {
                // BancodeDados.obterInstancia().cancelarTransacao();

                MessageBox.Show(ex.Message);
            }
            BancodeDados.obterInstancia().desconectar();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaCadastroFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
