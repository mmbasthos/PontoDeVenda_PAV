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
    public partial class TelaIdentificarCliente : Form
    {
        private CaixaPrincipal caixaPrincipal;

        public TelaIdentificarCliente(CaixaPrincipal principal)
        {
            InitializeComponent();
            caixaPrincipal = principal;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void AdicionarNumero(string numero)
        {
            campoCPF.Text += numero;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            campoCPF.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TelaCadastroCliente telaCadastroCliente = new TelaCadastroCliente();
            telaCadastroCliente.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            ControladorCadastroCliente controladorCadastroCliente = new ControladorCadastroCliente();
            ControladorVendas controladorVendas = new ControladorVendas();
            string cpf = campoCPF.Text;

            if (string.IsNullOrEmpty(cpf))
            {
                caixaPrincipal.Invoke(new Action(() =>
                {
                    caixaPrincipal.campoNomeCliente.Text = "Cliente não identificado";
                }));
            }
            else
            {

                string nomeCliente = controladorCadastroCliente.ObterNomeClientePorCPF(cpf);

                caixaPrincipal.Invoke(new Action(() =>
                {
                    caixaPrincipal.campoNomeCliente.Text = nomeCliente;
                }));
            }
            Vendas venda = new Vendas();

            venda.total_venda = 10.00m;
            if (string.IsNullOrEmpty(cpf))
            {
                venda.id_cliente_venda = 1;
            }
            else
            {
                venda.id_cliente_venda = controladorCadastroCliente.ObterIdClientePorCPF(cpf);
            }
            venda.data_venda = DateTime.Now.Date;
            venda.hora_venda = DateTime.Now.TimeOfDay;
            venda.situacao_venda = "ok";



            controladorVendas.incluir(venda);
            caixaPrincipal.novoTotal = 0m;
            BancodeDados.obterInstancia().desconectar();
            Close();
        }

        private void TelaIdentificarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

