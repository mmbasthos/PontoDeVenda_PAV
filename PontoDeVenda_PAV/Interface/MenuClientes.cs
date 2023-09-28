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
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCadastroCliente telaCadastroCliente = new TelaCadastroCliente();
            telaCadastroCliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaClientes consultaClientes = new ConsultaClientes();
            consultaClientes.ShowDialog();
        }
    }
}
