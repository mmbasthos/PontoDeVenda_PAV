using MySql.Data.MySqlClient;
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
    public partial class RelatorioFechamentoCaixa : Form
    {
        public RelatorioFechamentoCaixa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void RelatorioFechamentoCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                int idCaixa = 264;
                BancodeDados.obterInstancia().conectar();
                string query = "SELECT formapagamento, tipo_movimento, valor_movimento FROM movimento_caixa WHERE Caixa_id_caixa = @idCaixa";

                MySqlCommand command = new MySqlCommand(query, BancodeDados.obterInstancia().obterConexao());
                command.Parameters.AddWithValue("@idCaixa", idCaixa);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Filtrar entradas e saídas
                DataTable entradas = dataTable.Select("tipo_movimento = 'E'").CopyToDataTable();
                DataTable saidas = dataTable.Select("tipo_movimento = 'S'").CopyToDataTable();

                // Configurar a DataGridView para mostrar as entradas
                dataGridView1.DataSource = entradas;

                // Adicionar uma nova coluna para as saídas
                DataGridViewColumn colunaSaidas = new DataGridViewColumn();
                colunaSaidas.HeaderText = "Saídas";
                colunaSaidas.CellTemplate = new DataGridViewTextBoxCell();

                dataGridView1.Columns.Add(colunaSaidas);

                // Popular a nova coluna com os valores de saída correspondentes
                foreach (DataGridViewRow linha in dataGridView1.Rows)
                {
                    string formaPagamento = linha.Cells["formapagamento"].Value.ToString();
                    decimal totalSaidas = saidas.AsEnumerable()
                                                .Where(dr => dr.Field<string>("formapagamento") == formaPagamento)
                                                .Sum(dr => dr.Field<decimal>("valor_movimento"));
                    linha.Cells["Saídas"].Value = totalSaidas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
        }
    }
}
