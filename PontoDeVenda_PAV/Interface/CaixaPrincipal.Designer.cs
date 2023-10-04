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
            inserirProdutoToolStripMenuItem = new ToolStripMenuItem();
            campoNomeCaixa = new TextBox();
            campoIdCaixa = new TextBox();
            campoNomeCliente = new TextBox();
            dataGridView1 = new DataGridView();
            campoNomeProd = new TextBox();
            campoPrecoProd = new TextBox();
            campoQTDProd = new TextBox();
            campoTotalProd = new TextBox();
            button2 = new Button();
            campoTotalVenda = new Label();
            label2 = new Label();
            button3 = new Button();
            campoAddNum = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(816, 35);
            button1.Name = "button1";
            button1.Size = new Size(31, 31);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iniciarVendaToolStripMenuItem, iniciarCompraToolStripMenuItem, cadastrarClienteToolStripMenuItem, estoqueF5ToolStripMenuItem, finalizarVendaF7ToolStripMenuItem, cancelarVendaF8ToolStripMenuItem, inserirProdutoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1541, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // iniciarVendaToolStripMenuItem
            // 
            iniciarVendaToolStripMenuItem.Name = "iniciarVendaToolStripMenuItem";
            iniciarVendaToolStripMenuItem.ShortcutKeys = Keys.F1;
            iniciarVendaToolStripMenuItem.Size = new Size(137, 24);
            iniciarVendaToolStripMenuItem.Text = "Iniciar Venda - F1";
            iniciarVendaToolStripMenuItem.Click += iniciarVendaToolStripMenuItem_Click;
            // 
            // iniciarCompraToolStripMenuItem
            // 
            iniciarCompraToolStripMenuItem.Name = "iniciarCompraToolStripMenuItem";
            iniciarCompraToolStripMenuItem.ShortcutKeys = Keys.F2;
            iniciarCompraToolStripMenuItem.Size = new Size(149, 24);
            iniciarCompraToolStripMenuItem.Text = "Iniciar Compra - F2";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            cadastrarClienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarClienteToolStripMenuItem1, consultarClientesToolStripMenuItem });
            cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            cadastrarClienteToolStripMenuItem.Size = new Size(75, 24);
            cadastrarClienteToolStripMenuItem.Text = "Clientes";
            cadastrarClienteToolStripMenuItem.Click += cadastrarClienteToolStripMenuItem_Click;
            // 
            // cadastrarClienteToolStripMenuItem1
            // 
            cadastrarClienteToolStripMenuItem1.Name = "cadastrarClienteToolStripMenuItem1";
            cadastrarClienteToolStripMenuItem1.ShortcutKeys = Keys.F3;
            cadastrarClienteToolStripMenuItem1.Size = new Size(234, 26);
            cadastrarClienteToolStripMenuItem1.Text = "Cadastrar Cliente";
            cadastrarClienteToolStripMenuItem1.Click += cadastrarClienteToolStripMenuItem1_Click;
            // 
            // consultarClientesToolStripMenuItem
            // 
            consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            consultarClientesToolStripMenuItem.ShortcutKeys = Keys.F4;
            consultarClientesToolStripMenuItem.Size = new Size(234, 26);
            consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            consultarClientesToolStripMenuItem.Click += consultarClientesToolStripMenuItem_Click;
            // 
            // estoqueF5ToolStripMenuItem
            // 
            estoqueF5ToolStripMenuItem.Name = "estoqueF5ToolStripMenuItem";
            estoqueF5ToolStripMenuItem.Size = new Size(105, 24);
            estoqueF5ToolStripMenuItem.Text = "Estoque - F5";
            estoqueF5ToolStripMenuItem.Click += estoqueF5ToolStripMenuItem_Click;
            // 
            // finalizarVendaF7ToolStripMenuItem
            // 
            finalizarVendaF7ToolStripMenuItem.Name = "finalizarVendaF7ToolStripMenuItem";
            finalizarVendaF7ToolStripMenuItem.ShortcutKeys = Keys.F7;
            finalizarVendaF7ToolStripMenuItem.Size = new Size(152, 24);
            finalizarVendaF7ToolStripMenuItem.Text = "Finalizar Venda - F7";
            finalizarVendaF7ToolStripMenuItem.Click += finalizarVendaF7ToolStripMenuItem_Click;
            // 
            // cancelarVendaF8ToolStripMenuItem
            // 
            cancelarVendaF8ToolStripMenuItem.Name = "cancelarVendaF8ToolStripMenuItem";
            cancelarVendaF8ToolStripMenuItem.ShortcutKeys = Keys.F8;
            cancelarVendaF8ToolStripMenuItem.Size = new Size(154, 24);
            cancelarVendaF8ToolStripMenuItem.Text = "Cancelar Venda - F8";
            // 
            // inserirProdutoToolStripMenuItem
            // 
            inserirProdutoToolStripMenuItem.Name = "inserirProdutoToolStripMenuItem";
            inserirProdutoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            inserirProdutoToolStripMenuItem.Size = new Size(120, 24);
            inserirProdutoToolStripMenuItem.Text = "Inserir Produto";
            inserirProdutoToolStripMenuItem.Click += inserirProdutoToolStripMenuItem_Click;
            // 
            // campoNomeCaixa
            // 
            campoNomeCaixa.Enabled = false;
            campoNomeCaixa.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoNomeCaixa.Location = new Point(14, 36);
            campoNomeCaixa.Margin = new Padding(3, 4, 3, 4);
            campoNomeCaixa.Name = "campoNomeCaixa";
            campoNomeCaixa.Size = new Size(247, 63);
            campoNomeCaixa.TabIndex = 3;
            // 
            // campoIdCaixa
            // 
            campoIdCaixa.Enabled = false;
            campoIdCaixa.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoIdCaixa.Location = new Point(269, 36);
            campoIdCaixa.Margin = new Padding(3, 4, 3, 4);
            campoIdCaixa.Name = "campoIdCaixa";
            campoIdCaixa.Size = new Size(155, 63);
            campoIdCaixa.TabIndex = 4;
            // 
            // campoNomeCliente
            // 
            campoNomeCliente.Enabled = false;
            campoNomeCliente.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoNomeCliente.Location = new Point(431, 36);
            campoNomeCliente.Margin = new Padding(3, 4, 3, 4);
            campoNomeCliente.Name = "campoNomeCliente";
            campoNomeCliente.Size = new Size(1095, 63);
            campoNomeCliente.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(431, 113);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1096, 632);
            dataGridView1.TabIndex = 6;
            // 
            // campoNomeProd
            // 
            campoNomeProd.Enabled = false;
            campoNomeProd.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoNomeProd.Location = new Point(14, 760);
            campoNomeProd.Margin = new Padding(3, 4, 3, 4);
            campoNomeProd.Name = "campoNomeProd";
            campoNomeProd.Size = new Size(618, 63);
            campoNomeProd.TabIndex = 7;
            // 
            // campoPrecoProd
            // 
            campoPrecoProd.Enabled = false;
            campoPrecoProd.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoPrecoProd.Location = new Point(639, 760);
            campoPrecoProd.Margin = new Padding(3, 4, 3, 4);
            campoPrecoProd.Name = "campoPrecoProd";
            campoPrecoProd.Size = new Size(150, 63);
            campoPrecoProd.TabIndex = 8;
            // 
            // campoQTDProd
            // 
            campoQTDProd.Enabled = false;
            campoQTDProd.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoQTDProd.Location = new Point(797, 760);
            campoQTDProd.Margin = new Padding(3, 4, 3, 4);
            campoQTDProd.Name = "campoQTDProd";
            campoQTDProd.Size = new Size(94, 63);
            campoQTDProd.TabIndex = 9;
            // 
            // campoTotalProd
            // 
            campoTotalProd.Enabled = false;
            campoTotalProd.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoTotalProd.Location = new Point(946, 760);
            campoTotalProd.Margin = new Padding(3, 4, 3, 4);
            campoTotalProd.Name = "campoTotalProd";
            campoTotalProd.Size = new Size(178, 63);
            campoTotalProd.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(898, 760);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 11;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // campoTotalVenda
            // 
            campoTotalVenda.AutoSize = true;
            campoTotalVenda.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            campoTotalVenda.Location = new Point(1206, 760);
            campoTotalVenda.Name = "campoTotalVenda";
            campoTotalVenda.Size = new Size(144, 67);
            campoTotalVenda.TabIndex = 14;
            campoTotalVenda.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1339, 760);
            label2.Name = "label2";
            label2.Size = new Size(202, 67);
            label2.TabIndex = 15;
            label2.Text = "0000,00";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(898, 795);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 16;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // campoAddNum
            // 
            campoAddNum.Location = new Point(15, 718);
            campoAddNum.Name = "campoAddNum";
            campoAddNum.Size = new Size(410, 27);
            campoAddNum.TabIndex = 17;
            campoAddNum.TextChanged += campoAddNum_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(1130, 761);
            button4.Name = "button4";
            button4.Size = new Size(70, 62);
            button4.TabIndex = 18;
            button4.Text = "ok";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(330, 683);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 19;
            button5.Text = "Excluir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(333, 423);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 20;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // CaixaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 845);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(campoAddNum);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(campoTotalVenda);
            Controls.Add(button2);
            Controls.Add(campoTotalProd);
            Controls.Add(campoQTDProd);
            Controls.Add(campoPrecoProd);
            Controls.Add(campoNomeProd);
            Controls.Add(dataGridView1);
            Controls.Add(campoNomeCliente);
            Controls.Add(campoIdCaixa);
            Controls.Add(campoNomeCaixa);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private TextBox campoNomeProd;
        private TextBox campoPrecoProd;
        private TextBox campoQTDProd;
        private TextBox campoTotalProd;
        private Button button2;
        private Label campoTotalVenda;
        private ToolStripMenuItem finalizarVendaF7ToolStripMenuItem;
        private ToolStripMenuItem cancelarVendaF8ToolStripMenuItem;
        private Label label2;
        private Button button3;
        public TextBox campoNomeCliente;
        private ToolStripMenuItem inserirProdutoToolStripMenuItem;
        private TextBox campoAddNum;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}