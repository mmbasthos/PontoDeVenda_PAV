using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PontoDeVenda_PAV.Controladores;
using PontoDeVenda_PAV.Persistencia;
using PontoDeVenda_PAV.Entidades;

namespace PontoDeVenda_PAV.Interface
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuClientes menuClientes = new MenuClientes();
            menuClientes.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuFornecedores menuFornecedores = new MenuFornecedores();
            menuFornecedores.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuEstoque menuEstoque = new MenuEstoque();
            menuEstoque.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TelaAberturaCaixa telaAberturaCaixa = new TelaAberturaCaixa();
            telaAberturaCaixa.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SideMenuBar side = new SideMenuBar();
            side.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ImprimirRelatorioVendas imprimirRelatorioVendas = new ImprimirRelatorioVendas();
            imprimirRelatorioVendas.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ImprimirRelatorioCompras imprimirRelatorioCompras = new ImprimirRelatorioCompras();
            imprimirRelatorioCompras.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ContasReceber contasReceber = new ContasReceber();  
            contasReceber.Show();
        }
    }
}
