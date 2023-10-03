namespace PontoDeVenda_PAV.Interface
{
    partial class CaixaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            iniciarVendaToolStripMenuItem = new ToolStripMenuItem();
            iniciarCompraToolStripMenuItem = new ToolStripMenuItem();
            cadastrarClienteToolStripMenuItem = new ToolStripMenuItem();
            cadastrarClienteToolStripMenuItem1 = new ToolStripMenuItem();
            consultarClientesToolStripMenuItem = new ToolStripMenuItem();
            estoqueF5ToolStripMenuItem = new ToolStripMenuItem();
            finalizarVendaF7ToolStripMenuItem = new ToolStripMenuItem();
            cancelarVendaF8ToolStripMenuItem = new ToolStripMenuItem();
            campoNomeCaixa = new TextBox();
            campoIdCaixa = new TextBox();
            campoNomeCliente = new TextBox();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            inserirProdutoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(714, 26);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iniciarVendaToolStripMenuItem, iniciarCompraToolStripMenuItem, cadastrarClienteToolStripMenuItem, estoqueF5ToolStripMenuItem, finalizarVendaF7ToolStripMenuItem, cancelarVendaF8ToolStripMenuItem, inserirProdutoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1348, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // iniciarVendaToolStripMenuItem
            // 
            iniciarVendaToolStripMenuItem.Name = "iniciarVendaToolStripMenuItem";
            iniciarVendaToolStripMenuItem.ShortcutKeys = Keys.F1;
            iniciarVendaToolStripMenuItem.Size = new Size(109, 20);
            iniciarVendaToolStripMenuItem.Text = "Iniciar Venda - F1";
            iniciarVendaToolStripMenuItem.Click += iniciarVendaToolStripMenuItem_Click;
            // 
            // iniciarCompraToolStripMenuItem
            // 
            iniciarCompraToolStripMenuItem.Name = "iniciarCompraToolStripMenuItem";
            iniciarCompraToolStripMenuItem.ShortcutKeys = Keys.F2;
            iniciarCompraToolStripMenuItem.Size = new Size(120, 20);
            iniciarCompraToolStripMenuItem.Text = "Iniciar Compra - F2";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            cadastrarClienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarClienteToolStripMenuItem1, consultarClientesToolStripMenuItem });
            cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            cadastrarClienteToolStripMenuItem.Size = new Size(61, 20);
            cadastrarClienteToolStripMenuItem.Text = "Clientes";
            cadastrarClienteToolStripMenuItem.Click += cadastrarClienteToolStripMenuItem_Click;
            // 
            // cadastrarClienteToolStripMenuItem1
            // 
            cadastrarClienteToolStripMenuItem1.Name = "cadastrarClienteToolStripMenuItem1";
            cadastrarClienteToolStripMenuItem1.ShortcutKeys = Keys.F3;
            cadastrarClienteToolStripMenuItem1.Size = new Size(189, 22);
            cadastrarClienteToolStripMenuItem1.Text = "Cadastrar Cliente";
            cadastrarClienteToolStripMenuItem1.Click += cadastrarClienteToolStripMenuItem1_Click;
            // 
            // consultarClientesToolStripMenuItem
            // 
            consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            consultarClientesToolStripMenuItem.ShortcutKeys = Keys.F4;
            consultarClientesToolStripMenuItem.Size = new Size(189, 22);
            consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            consultarClientesToolStripMenuItem.Click += consultarClientesToolStripMenuItem_Click;
            // 
            // estoqueF5ToolStripMenuItem
            // 
            estoqueF5ToolStripMenuItem.Name = "estoqueF5ToolStripMenuItem";
            estoqueF5ToolStripMenuItem.Size = new Size(84, 20);
            estoqueF5ToolStripMenuItem.Text = "Estoque - F5";
            estoqueF5ToolStripMenuItem.Click += estoqueF5ToolStripMenuItem_Click;
            // 
            // finalizarVendaF7ToolStripMenuItem
            // 
            finalizarVendaF7ToolStripMenuItem.Name = "finalizarVendaF7ToolStripMenuItem";
            finalizarVendaF7ToolStripMenuItem.ShortcutKeys = Keys.F7;
            finalizarVendaF7ToolStripMenuItem.Size = new Size(120, 20);
            finalizarVendaF7ToolStripMenuItem.Text = "Finalizar Venda - F7";
            // 
            // cancelarVendaF8ToolStripMenuItem
            // 
            cancelarVendaF8ToolStripMenuItem.Name = "cancelarVendaF8ToolStripMenuItem";
            cancelarVendaF8ToolStripMenuItem.ShortcutKeys = Keys.F8;
            cancelarVendaF8ToolStripMenuItem.Size = new Size(123, 20);
            cancelarVendaF8ToolStripMenuItem.Text = "Cancelar Venda - F8";
            // 
            // campoNomeCaixa
            // 
            campoNomeCaixa.Enabled = false;
            campoNomeCaixa.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoNomeCaixa.Location = new Point(12, 27);
            campoNomeCaixa.Name = "campoNomeCaixa";
            campoNomeCaixa.Size = new Size(217, 52);
            campoNomeCaixa.TabIndex = 3;
            // 
            // campoIdCaixa
            // 
            campoIdCaixa.Enabled = false;
            campoIdCaixa.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoIdCaixa.Location = new Point(235, 27);
            campoIdCaixa.Name = "campoIdCaixa";
            campoIdCaixa.Size = new Size(136, 52);
            campoIdCaixa.TabIndex = 4;
            // 
            // campoNomeCliente
            // 
            campoNomeCliente.Enabled = false;
            campoNomeCliente.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoNomeCliente.Location = new Point(377, 27);
            campoNomeCliente.Name = "campoNomeCliente";
            campoNomeCliente.Size = new Size(959, 52);
            campoNomeCliente.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1324, 474);
            dataGridView1.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(12, 570);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(541, 52);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(559, 570);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(132, 52);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(697, 570);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(83, 52);
            textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(839, 570);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(156, 52);
            textBox7.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(786, 570);
            button2.Name = "button2";
            button2.Size = new Size(26, 26);
            button2.TabIndex = 11;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1067, 570);
            label1.Name = "label1";
            label1.Size = new Size(116, 54);
            label1.TabIndex = 14;
            label1.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1172, 570);
            label2.Name = "label2";
            label2.Size = new Size(164, 54);
            label2.TabIndex = 15;
            label2.Text = "0000,00";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(786, 596);
            button3.Name = "button3";
            button3.Size = new Size(26, 26);
            button3.TabIndex = 16;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            // 
            // inserirProdutoToolStripMenuItem
            // 
            inserirProdutoToolStripMenuItem.Name = "inserirProdutoToolStripMenuItem";
            inserirProdutoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            inserirProdutoToolStripMenuItem.Size = new Size(97, 20);
            inserirProdutoToolStripMenuItem.Text = "Inserir Produto";
            inserirProdutoToolStripMenuItem.Click += inserirProdutoToolStripMenuItem_Click;
            // 
            // CaixaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 634);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(dataGridView1);
            Controls.Add(campoNomeCliente);
            Controls.Add(campoIdCaixa);
            Controls.Add(campoNomeCaixa);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CaixaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CaixaPrincipal";
            Load += CaixaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iniciarVendaToolStripMenuItem;
        private ToolStripMenuItem iniciarCompraToolStripMenuItem;
        private ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private ToolStripMenuItem cadastrarClienteToolStripMenuItem1;
        private ToolStripMenuItem consultarClientesToolStripMenuItem;
        private ToolStripMenuItem estoqueF5ToolStripMenuItem;
        private TextBox campoNomeCaixa;
        private TextBox campoIdCaixa;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button2;
        private Label label1;
        private ToolStripMenuItem finalizarVendaF7ToolStripMenuItem;
        private ToolStripMenuItem cancelarVendaF8ToolStripMenuItem;
        private Label label2;
        private Button button3;
        public TextBox campoNomeCliente;
        private ToolStripMenuItem inserirProdutoToolStripMenuItem;
    }
}