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
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                ControladorCadastroCliente controladorCadastroCliente = new ControladorCadastroCliente();

                Cliente cliente = new Cliente();

                cliente.nome_cliente = campoNomeCliente.Text;
                cliente.cpf_cnpj_cliente = campoCPFCliente.Text;
                cliente.telefone_cliente = campoTelefoneCliente.Text;
                cliente.email_cliente = campoEmailCliente.Text;

                cliente.logradouro_cliente = campoLogradouroCliente.Text;
                cliente.numero_logradouro_cliente = campoNumeroLogCliente.Text;
                cliente.complemento_cliente = campoComplementoCliente.Text;
                cliente.bairro_cliente = campoBairroCliente.Text;
                cliente.cidade_cliente = campoCidadeCliente.Text;
                cliente.cep_cliente = campoCepCliente.Text;

                cliente.estado_cliente = comboBoxEstadoCliente.SelectedItem.ToString();

                controladorCadastroCliente.incluir(cliente);

                MessageBox.Show("Cliente Inserido com Sucesso!");

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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
