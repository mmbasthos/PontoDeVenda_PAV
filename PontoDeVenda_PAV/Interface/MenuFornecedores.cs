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
    public partial class MenuFornecedores : Form
    {
        public MenuFornecedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCadastroFornecedor telaCadastroFornecedor = new TelaCadastroFornecedor();
            telaCadastroFornecedor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor consultaFornecedor = new ConsultaFornecedor();
            consultaFornecedor.ShowDialog();
        }

        private void MenuFornecedores_Load(object sender, EventArgs e)
        {

        }
    }
}
