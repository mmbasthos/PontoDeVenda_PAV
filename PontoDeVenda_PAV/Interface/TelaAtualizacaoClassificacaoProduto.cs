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
    public partial class TelaAtualizacaoClassificacaoProduto : Form
    {
        public int IdClasse { get; set; }
        public TelaAtualizacaoClassificacaoProduto()
        {
            InitializeComponent();
        }

        private void TelaAtualizacaoClassificacaoProduto_Load(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            int idClasse = this.IdClasse;
            ControladorClassificacaoProduto controladorClassificacaoProduto = new ControladorClassificacaoProduto();
            ClassificacaoProduto classificacaoProduto = new ClassificacaoProduto();
            classificacaoProduto.id_classe = idClasse;
            controladorClassificacaoProduto.selecionar(classificacaoProduto);
            campoAtualizrTipo.Text = classificacaoProduto.nome_classe;
            BancodeDados.obterInstancia().desconectar();
           
        }

        public void CarregarDados()
        {

        }

        private void campoAtualizrTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            ControladorClassificacaoProduto controladorClassificacaoProduto = new ControladorClassificacaoProduto();
            int idClasse = this.IdClasse;
            ClassificacaoProduto classificacaoProduto = new ClassificacaoProduto();
            classificacaoProduto.id_classe = idClasse;
            controladorClassificacaoProduto.selecionar(classificacaoProduto);

            classificacaoProduto.nome_classe = campoAtualizrTipo.Text;

            controladorClassificacaoProduto.atualizar(classificacaoProduto);

            MessageBox.Show("Tipo Produto Atualizado!");

            BancodeDados.obterInstancia().desconectar();



            Close();

        }
    }
}
