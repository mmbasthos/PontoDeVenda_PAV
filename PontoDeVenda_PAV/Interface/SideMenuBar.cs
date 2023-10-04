using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Aqui temos o painel de menu principal do programa
//Temos que adicionar novos botoes caso seja necessario abrir outro Form direto da func principal
//Existem paines de submenu que sao mostrados quando clicamos no botao principal de cada parte. Ate o momento sao 3

namespace PontoDeVenda_PAV.Interface
{
    public partial class SideMenuBar : Form
    {
        public SideMenuBar()
        {
            InitializeComponent();
            CustomizarDesing();

        }

        private void CustomizarDesing()
        {
            //Aqui iremos esconder os panels de submenu

            ConsultaPanel.Visible = false;
            CadastroPanel.Visible = false;
            EstoquePanel.Visible = false;

        }

        private void EsconderSubMenu()
        {
            //Com esse metodo, escondemos o submenu que foi mostrado anteriormente

            if (CadastroPanel.Visible == true) CadastroPanel.Visible = false;

            if (EstoquePanel.Visible == true) EstoquePanel.Visible = false;

            if (ConsultaPanel.Visible == true) ConsultaPanel.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            //Aqui mostramos o subMenu

            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //Funcao para abrir novos forms direto do panel principal

        private Form activeForm = null;
        private void AbrirForms(Form FormsPanel)
        {
            if (activeForm != null) activeForm.Close(); //Aqui a form aberta será encerrada assim que abrirmos outra
            activeForm = FormsPanel;
            FormsPanel.TopLevel = false;
            FormsPanel.FormBorderStyle = FormBorderStyle.None; //assim, eles nao vao ter bordas quando chamados na func principal
            FormsPanel.Dock = DockStyle.Fill; //vai preencher o campo designado
            DisplayFormsPanel.Controls.Add(FormsPanel);
            DisplayFormsPanel.Tag = FormsPanel;
            FormsPanel.BringToFront();
            FormsPanel.Show();


        }

        private void SideMenuBar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //Botao Cadastro - e subBotoes
        private void Cadastro_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(CadastroPanel);
        }

        private void CadastroCliente_Click(object sender, EventArgs e)
        {
            //chamar uma nova forma
            TelaCadastroCliente telaCadastroCliente = new TelaCadastroCliente();
            telaCadastroCliente.ShowDialog();

            EsconderSubMenu();
        }

        //Aqui é o botao de Fornecedor dentro de Cadastro
        private void button1_Click_1(object sender, EventArgs e)
        {
            //abre uma nova janela 
            TelaCadastroFornecedor telaCadastroFornecedor = new TelaCadastroFornecedor();
            telaCadastroFornecedor.ShowDialog();

            EsconderSubMenu();
        }

        //Fim dos Botoes de cadastro

        //--------------------------------------------------------------

        //Comeco dos Botoes de Consulta
        private void BtConsulta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(ConsultaPanel);
        }

        private void ConsultaCliente_Click(object sender, EventArgs e)
        {
            //Codificar para mostrar as outras formas
            ConsultaClientes consultaClientes = new ConsultaClientes();
            consultaClientes.ShowDialog();
            EsconderSubMenu();
        }
        private void ConsultaFornecedor_Click(object sender, EventArgs e)
        {
            //Codificar algo aqui 
            ConsultaFornecedor consultaFornecedor = new ConsultaFornecedor();
            consultaFornecedor.ShowDialog();
            EsconderSubMenu();
        }


        //Fim dos Botoes de Consulta

        //--------------------------------------------------------------

        //Comeco dos Botoes de estoque

        private void BtEstoque_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(EstoquePanel);
            MenuEstoque menuEstoque = new MenuEstoque();        
            menuEstoque.Show();
        }
        private void CadastrarProduto_Click(object sender, EventArgs e)
        {
            //Cadastrar produto entra aqui 
            EsconderSubMenu();
        }
        private void CadastrarTipoProduto_Click(object sender, EventArgs e)
        {
            //Cadastrar tipo de produto entra aqui 
            EsconderSubMenu();
        }
        private void ConsultarTipoDeProduto_Click(object sender, EventArgs e)
        {
            //Consultar tipo de produto entra aqui 
            EsconderSubMenu();

        }

        //Fim dos Botoes de Estoque

        //--------------------------------------------------------------

        //Botao de fechar a janela

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
