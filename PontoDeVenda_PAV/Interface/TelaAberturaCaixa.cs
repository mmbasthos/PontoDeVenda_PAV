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
    public partial class TelaAberturaCaixa : Form
    {
        public TelaAberturaCaixa()
        {
            InitializeComponent();
        }

        private void abrirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.obterInstancia().conectar();

                ControladorCaixa controladorCaixa = new ControladorCaixa();

                Caixa caixa = new Caixa();

                if (string.IsNullOrEmpty(campoNomeCaixa.Text))
                {
                    MessageBox.Show("Por favor, insira o nome do caixa.");
                    return;
                }

                if (!decimal.TryParse(campoSaldoCaixa.Text, out decimal saldo))
                {
                    MessageBox.Show("Por favor, insira um valor de preço válido.");
                    return;
                }

                caixa.nome_caixa = campoNomeCaixa.Text;
                caixa.saldo_caixa = saldo;
                controladorCaixa.incluir(caixa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir caixa: " + ex.Message);
            }
            finally
            {
                BancodeDados.obterInstancia().desconectar();
            }
            CaixaPrincipal caixaPrincipal = new CaixaPrincipal();
            caixaPrincipal.ShowDialog();
            Close();

        }
    }
}
