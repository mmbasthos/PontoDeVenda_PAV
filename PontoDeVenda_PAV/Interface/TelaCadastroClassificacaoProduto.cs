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
    public partial class TelaCadastroClassificacaoProduto : Form
    {
        public TelaCadastroClassificacaoProduto()
        {
            InitializeComponent();
        }

        private void TelaCadastroClassificacaoProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnConcluido_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();

            try
            {

                ControladorClassificacaoProduto controladorClassificacaoProduto = new ControladorClassificacaoProduto();

                ClassificacaoProduto classificacaoProduto = new ClassificacaoProduto();

                classificacaoProduto.nome_classe = campoTipoProduto.Text;

                controladorClassificacaoProduto.incluir(classificacaoProduto);

                MessageBox.Show("Tipo de Produto inserido com sucesso!");

                campoTipoProduto.Text = "";
               

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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
