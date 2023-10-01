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
    public partial class CaixaPrincipal : Form
    {
        public CaixaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancodeDados.obterInstancia().conectar();
            ControladorCaixa controladorCaixa = new ControladorCaixa();
            int idCaixa = controladorCaixa.caixaAtual();

            decimal valorAumento = 100.00m;

            controladorCaixa.aumentarSaldoCaixa(idCaixa, valorAumento);
            BancodeDados.obterInstancia().desconectar();
        }

        private void CaixaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
