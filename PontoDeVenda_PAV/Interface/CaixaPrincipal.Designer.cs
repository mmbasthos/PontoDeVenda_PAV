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
            finalizarVendaF7ToolStripMenuItem = new ToolStripMenuItem();
            cancelarVendaF8ToolStripMenuItem = new ToolStripMenuItem();
            iniciarCompraToolStripMenuItem = new ToolStripMenuItem();
            finalizarCompraToolStripMenuItem = new ToolStripMenuItem();
            cancelarCompraToolStripMenuItem = new ToolStripMenuItem();
            cadastrarClienteToolStripMenuItem = new ToolStripMenuItem();
            cadastrarClienteToolStripMenuItem1 = new ToolStripMenuItem();
            consultarClientesToolStripMenuItem = new ToolStripMenuItem();
            estoqueF5ToolStripMenuItem = new ToolStripMenuItem();
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button6 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(129, 82);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { iniciarVendaToolStripMenuItem, finalizarVendaF7ToolStripMenuItem, cancelarVendaF8ToolStripMenuItem, iniciarCompraToolStripMenuItem, finalizarCompraToolStripMenuItem, cancelarCompraToolStripMenuItem, cadastrarClienteToolStripMenuItem, estoqueF5ToolStripMenuItem });
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
            cancelarVendaF8ToolStripMenuItem.Click += cancelarVendaF8ToolStripMenuItem_Click;
            // 
            // iniciarCompraToolStripMenuItem
            // 
            iniciarCompraToolStripMenuItem.Name = "iniciarCompraToolStripMenuItem";
            iniciarCompraToolStripMenuItem.ShortcutKeys = Keys.F2;
            iniciarCompraToolStripMenuItem.Size = new Size(149, 24);
            iniciarCompraToolStripMenuItem.Text = "Iniciar Compra - F2";
            iniciarCompraToolStripMenuItem.Click += iniciarCompraToolStripMenuItem_Click;
            // 
            // finalizarCompraToolStripMenuItem
            // 
            finalizarCompraToolStripMenuItem.Name = "finalizarCompraToolStripMenuItem";
            finalizarCompraToolStripMenuItem.Size = new Size(135, 24);
            finalizarCompraToolStripMenuItem.Text = "Finalizar Compra";
            finalizarCompraToolStripMenuItem.Click += finalizarCompraToolStripMenuItem_Click;
            // 
            // cancelarCompraToolStripMenuItem
            // 
            cancelarCompraToolStripMenuItem.Name = "cancelarCompraToolStripMenuItem";
            cancelarCompraToolStripMenuItem.Size = new Size(141, 24);
            cancelarCompraToolStripMenuItem.Text = "Cancelar Compra ";
            cancelarCompraToolStripMenuItem.Click += cancelarCompraToolStripMenuItem_Click;
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
            // campoNomeCaixa
            // 
            campoNomeCaixa.Enabled = false;
            campoNomeCaixa.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoNomeCaixa.Location = new Point(16, 69);
            campoNomeCaixa.Margin = new Padding(3, 4, 3, 4);
            campoNomeCaixa.Name = "campoNomeCaixa";
            campoNomeCaixa.Size = new Size(247, 63);
            campoNomeCaixa.TabIndex = 3;
            // 
            // campoIdCaixa
            // 
            campoIdCaixa.Enabled = false;
            campoIdCaixa.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoIdCaixa.Location = new Point(271, 69);
            campoIdCaixa.Margin = new Padding(3, 4, 3, 4);
            campoIdCaixa.Name = "campoIdCaixa";
            campoIdCaixa.Size = new Size(155, 63);
            campoIdCaixa.TabIndex = 4;
            // 
            // campoNomeCliente
            // 
            campoNomeCliente.Enabled = false;
            campoNomeCliente.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            campoNomeCliente.Location = new Point(433, 69);
            campoNomeCliente.Margin = new Padding(3, 4, 3, 4);
            campoNomeCliente.Name = "campoNomeCliente";
            campoNomeCliente.Size = new Size(1095, 63);
            campoNomeCliente.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(433, 146);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1096, 575);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            campoNomeProd.TextChanged += campoNomeProd_TextChanged;
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
            campoAddNum.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            campoAddNum.Location = new Point(16, 678);
            campoAddNum.Name = "campoAddNum";
            campoAddNum.Size = new Size(410, 43);
            campoAddNum.TabIndex = 17;
            campoAddNum.TextChanged += campoAddNum_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(1130, 761);
            button4.Name = "button4";
            button4.Size = new Size(70, 62);
            button4.TabIndex = 18;
            button4.Text = "Lançar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(327, 146);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 19;
            button5.Text = "Excluir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 20;
            label1.Text = "Caixa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(433, 34);
            label3.Name = "label3";
            label3.Size = new Size(85, 31);
            label3.TabIndex = 21;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(271, 34);
            label4.Name = "label4";
            label4.Size = new Size(40, 31);
            label4.TabIndex = 22;
            label4.Text = "N°";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(946, 725);
            label5.Name = "label5";
            label5.Size = new Size(151, 31);
            label5.TabIndex = 23;
            label5.Text = "Total Produto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(797, 725);
            label6.Name = "label6";
            label6.Size = new Size(53, 31);
            label6.TabIndex = 24;
            label6.Text = "Qtd";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(639, 725);
            label7.Name = "label7";
            label7.Size = new Size(125, 31);
            label7.TabIndex = 25;
            label7.Text = "Valor Unid.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 725);
            label8.Name = "label8";
            label8.Size = new Size(96, 31);
            label8.TabIndex = 26;
            label8.Text = "Produto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 644);
            label9.Name = "label9";
            label9.Size = new Size(193, 31);
            label9.TabIndex = 27;
            label9.Text = "Inserir ID Produto";
            // 
            // button6
            // 
            button6.Location = new Point(333, 252);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 28;
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
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
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
        private Button button2;
        private Label campoTotalVenda;
        private ToolStripMenuItem finalizarVendaF7ToolStripMenuItem;
        private ToolStripMenuItem cancelarVendaF8ToolStripMenuItem;
        private Label label2;
        private Button button3;
        public TextBox campoNomeCliente;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        public TextBox campoNomeProd;
        public TextBox campoPrecoProd;
        public TextBox campoQTDProd;
        public TextBox campoTotalProd;
        public TextBox campoAddNum;
        private Button button6;
        private ToolStripMenuItem finalizarCompraToolStripMenuItem;
        private ToolStripMenuItem cancelarCompraToolStripMenuItem;
    }
}