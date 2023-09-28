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
using PontoDeVenda_PAV.Persistencia;
using PontoDeVenda_PAV.Controladores;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PontoDeVenda_PAV.Interface
{
    public partial class ConsultaTipoProduto : Form
    {
        public ConsultaTipoProduto()
        {
            InitializeComponent();
        }



        private void ConsultaTipoProduto_Load(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                string comandoSql = "SELECT * FROM classe_produto";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void campoPesqID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BancodeDados.obterInstancia().conectar();
                ControladorClassificacaoProduto controladorClassificacaoProduto = new ControladorClassificacaoProduto();

                ClassificacaoProduto classificacaoProduto = new ClassificacaoProduto();

                string idString = campoPesqID.Text;

                if (int.TryParse(idString, out int id))
                {
                    classificacaoProduto.id_classe = id;
                    controladorClassificacaoProduto.selecionar(classificacaoProduto);


                    DataTable resultado = new DataTable();
                    resultado.Columns.Add("id_classe", typeof(int));
                    resultado.Columns.Add("nome_classe", typeof(string));

                    DataRow newRow = resultado.NewRow();
                    newRow["id_classe"] = classificacaoProduto.id_classe;
                    newRow["nome_classe"] = classificacaoProduto.nome_classe;
                    resultado.Rows.Add(newRow);


                    dataGridView1.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID válido.");
                }

                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int idClasse = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_classe"].Value);

                ClassificacaoProduto classificacaoProduto = new ClassificacaoProduto();
                classificacaoProduto.id_classe = idClasse;

                ControladorClassificacaoProduto controlador = new ControladorClassificacaoProduto();
                controlador.excluir(classificacaoProduto);
                dataGridView1.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Tipo de Produto Exlcluído com Sucesso!");
            }
        }

        private void campoPesqNome_TextChanged(object sender, EventArgs e)
        {
            string textoPesquisa = campoPesqNome.Text;
            string comandoSql = "SELECT * FROM classe_produto WHERE nome_classe LIKE @textoPesquisa";

            try
            {
                BancodeDados.obterInstancia().conectar();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@textoPesquisa", "%" + textoPesquisa + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void campoPesqNome_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int idClasse = Convert.ToInt32(row.Cells["id_classe"].Value);

                // Abra a nova tela para edição, passando o idClasse como parâmetro se necessário
                TelaAtualizacaoClassificacaoProduto telaEdicao = new TelaAtualizacaoClassificacaoProduto();
                telaEdicao.IdClasse = idClasse;
                telaEdicao.ShowDialog();

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();
                string comandoSql = "SELECT * FROM classe_produto";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql, BancodeDados.obterInstancia().obterConexao()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


