using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//Aqui temos o painel de menu principal do programa
//Temos que adicionar novos botoes caso seja necessario abrir outro Form direto da func principal
//Existem paines de submenu que sao mostrados quando clicamos no botao principal de cada parte. Ate o momento sao 3

namespace PontoDeVenda_PAV.Interface
{
    public partial class SideMenuBar : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
           );

        public SideMenuBar()
        {
            InitializeComponent();
            CustomizarDesing(); //isso é chamado aqui porque precisa abrir assim que o programa é iniciado
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }


        private void CustomizarDesing()
        {
            //Aqui iremos esconder os panels de submenu

            ConsultaPanel.Visible = false;
            CadastroPanel.Visible = false;

        }

        private void EsconderSubMenu()
        {
            //Com esse metodo, escondemos o submenu que foi mostrado anteriormente

            if (CadastroPanel.Visible == true) CadastroPanel.Visible = false;


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
            //chama a interface de cadastro do cliente
            openChildForm(new TelaCadastroCliente());

            EsconderSubMenu();
        }

        //Aqui é o botao de Fornecedor dentro de Cadastro
        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new TelaCadastroFornecedor());

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

            openChildForm(new ConsultaClientes());

            EsconderSubMenu();
        }
        private void ConsultaFornecedor_Click(object sender, EventArgs e)
        {
            //Codificar algo aqui 

            openChildForm(new ConsultaFornecedor());

            EsconderSubMenu();
        }


        //Fim dos Botoes de Consulta

        //--------------------------------------------------------------

        //Comeco dos Botoes de estoque

        private void BtEstoque_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuEstoque());

            /*MenuEstoque menuEstoque = new MenuEstoque();
            menuEstoque.Show();*/
        }

        //Fim dos Botoes de Estoque

        //--------------------------------------------------------------

        //Botao de fechar a janela

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            //aqui ele vai abrir o menu principal que estava antes configurado para ser a primeira tela do aplicativo
            MenuPrincipal telaMenuPrincipal = new MenuPrincipal();
            telaMenuPrincipal.ShowDialog();

            //nao tem necessidade de esconder o submenu aqui. O codigo deve fazer isso apenas quando há necessidade

        }

        private Form formAtiva = null;
        private void openChildForm(Form childForm)
        {
            if (formAtiva != null)
                formAtiva.Close();
            formAtiva = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DisplayFormsPanel.Controls.Add(childForm);
            DisplayFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TelaAberturaCaixa ObjetoTelaAberturaCaixa = new TelaAberturaCaixa();
            ObjetoTelaAberturaCaixa.ShowDialog();
        }

        private void DisplayFormsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
