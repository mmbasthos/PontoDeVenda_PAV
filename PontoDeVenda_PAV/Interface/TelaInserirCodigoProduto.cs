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
    public partial class TelaInserirCodigoProduto : Form
    {
        public TelaInserirCodigoProduto()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                BancodeDados.obterInstancia().conectar();

                ControladorItemVenda controladorItemVenda = new ControladorItemVenda();
                ControladorVendas controladorVendas = new ControladorVendas();
                ControladorCadastroProdutos controladorCadastroProdutos = new ControladorCadastroProdutos();

                string idString = campoAddProduto.Text;

                if (int.TryParse(idString, out int id))
                {
                    ItemVenda itemVenda = new ItemVenda();
                    Produtos produto = new Produtos();
                    produto.id_produto = id;
                    decimal valorProduto = controladorCadastroProdutos.ObterValorProdutoPorId(id);

                    // Não precisamos chamar controladorCadastroProdutos.selecionar(produto); já que não usamos 'produto' diretamente.

                    itemVenda.id_produto = id;
                    itemVenda.id_venda = controladorVendas.vendaAtual();
                    itemVenda.valor_unitario_item = valorProduto;
                    itemVenda.quantidade_item = 1;
                    itemVenda.total_item = valorProduto;

                    controladorItemVenda.incluir(itemVenda);
                }
                else
                {
                    MessageBox.Show("O texto não é um ID de produto válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void TelaInserirCodigoProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
