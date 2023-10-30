using MySql.Data.MySqlClient;
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
    public partial class TelaIdentificarFornecedor : Form
    {
        private CaixaPrincipal caixaPrincipal;
        public TelaIdentificarFornecedor(CaixaPrincipal principal)
        {
            InitializeComponent();
            caixaPrincipal = principal;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelaIdentificarFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT id_fornecedor, nome_fornecedor FROM fornecedor";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBoxFornecedorProd.DataSource = dataTable;
                    comboBoxFornecedorProd.DisplayMember = "nome_fornecedor";
                    comboBoxFornecedorProd.ValueMember = "id_fornecedor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                BancodeDados.obterInstancia().conectar();
                int idFornecedorSelecionado = -1;

                

                ControladorCadastroFornecedor controladorCadastroFornecedor = new ControladorCadastroFornecedor();

                ControladorCompras controladorCompras = new ControladorCompras();
                Compra compra = new Compra();
                if (comboBoxFornecedorProd.SelectedValue != null)
                {
                    compra.id_fornecedor_compra = Convert.ToInt32(comboBoxFornecedorProd.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um fornecedor.");
                    return; // Sai do método caso nenhum fornecedor seja selecionado.
                }

                compra.total_compra = 0m;
                compra.data_compra = DateTime.Now.Date;
                compra.hora_compra = DateTime.Now.TimeOfDay;
                compra.situacao_compra = "Ativa";

                controladorCompras.incluir(compra);
                caixaPrincipal.novoTotal = 0m;
                BancodeDados.obterInstancia().desconectar();
                caixaPrincipal.campoNomeCliente.Text = comboBoxFornecedorProd.Text;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

            caixaPrincipal.modoVenda = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCadastroFornecedor telaCadastroFornecedor = new TelaCadastroFornecedor();
            telaCadastroFornecedor.ShowDialog();
        }
    }
}
