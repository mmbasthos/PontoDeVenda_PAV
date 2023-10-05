namespace PontoDeVenda_PAV.Interface
{
    partial class SideMenuBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideMenuBar));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            BotaoDeSair = new Button();
            SideMenuPanel = new Panel();
            EstoquePanel = new Panel();
            ConsultarTipoDeProduto = new Button();
            CadastrarTipoProduto = new Button();
            CadastrarProduto = new Button();
            BtEstoque = new Button();
            ConsultaPanel = new Panel();
            ConsultaFornecedor = new Button();
            ConsultaCliente = new Button();
            BtConsulta = new Button();
            CadastroPanel = new Panel();
            CadastroFornecedor = new Button();
            CadastroCliente = new Button();
            Cadastro = new Button();
            DisplayFormsPanel = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SideMenuPanel.SuspendLayout();
            EstoquePanel.SuspendLayout();
            ConsultaPanel.SuspendLayout();
            CadastroPanel.SuspendLayout();
            DisplayFormsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BotaoDeSair);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 39);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 31);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BotaoDeSair
            // 
            BotaoDeSair.FlatAppearance.BorderSize = 0;
            BotaoDeSair.FlatStyle = FlatStyle.Flat;
            BotaoDeSair.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BotaoDeSair.ForeColor = SystemColors.Desktop;
            BotaoDeSair.Image = (Image)resources.GetObject("BotaoDeSair.Image");
            BotaoDeSair.ImageAlign = ContentAlignment.MiddleLeft;
            BotaoDeSair.Location = new Point(1045, 0);
            BotaoDeSair.Margin = new Padding(3, 4, 3, 4);
            BotaoDeSair.Name = "BotaoDeSair";
            BotaoDeSair.Padding = new Padding(6, 0, 0, 0);
            BotaoDeSair.Size = new Size(41, 39);
            BotaoDeSair.TabIndex = 7;
            BotaoDeSair.TextAlign = ContentAlignment.MiddleLeft;
            BotaoDeSair.UseVisualStyleBackColor = true;
            BotaoDeSair.Click += button1_Click_2;
            // 
            // SideMenuPanel
            // 
            SideMenuPanel.AutoScroll = true;
            SideMenuPanel.BackColor = Color.WhiteSmoke;
            SideMenuPanel.Controls.Add(EstoquePanel);
            SideMenuPanel.Controls.Add(BtEstoque);
            SideMenuPanel.Controls.Add(ConsultaPanel);
            SideMenuPanel.Controls.Add(BtConsulta);
            SideMenuPanel.Controls.Add(CadastroPanel);
            SideMenuPanel.Controls.Add(Cadastro);
            SideMenuPanel.Dock = DockStyle.Left;
            SideMenuPanel.Location = new Point(0, 39);
            SideMenuPanel.Margin = new Padding(3, 4, 3, 4);
            SideMenuPanel.Name = "SideMenuPanel";
            SideMenuPanel.Size = new Size(206, 761);
            SideMenuPanel.TabIndex = 1;
            SideMenuPanel.Paint += SideMenuPanel_Paint;
            // 
            // EstoquePanel
            // 
            EstoquePanel.BackColor = Color.FromArgb(239, 239, 239);
            EstoquePanel.Controls.Add(ConsultarTipoDeProduto);
            EstoquePanel.Controls.Add(CadastrarTipoProduto);
            EstoquePanel.Controls.Add(CadastrarProduto);
            EstoquePanel.Location = new Point(0, 301);
            EstoquePanel.Margin = new Padding(3, 4, 3, 4);
            EstoquePanel.Name = "EstoquePanel";
            EstoquePanel.Size = new Size(206, 120);
            EstoquePanel.TabIndex = 6;
            // 
            // ConsultarTipoDeProduto
            // 
            ConsultarTipoDeProduto.FlatAppearance.BorderSize = 0;
            ConsultarTipoDeProduto.FlatStyle = FlatStyle.Flat;
            ConsultarTipoDeProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConsultarTipoDeProduto.ForeColor = SystemColors.Desktop;
            ConsultarTipoDeProduto.Image = (Image)resources.GetObject("ConsultarTipoDeProduto.Image");
            ConsultarTipoDeProduto.ImageAlign = ContentAlignment.MiddleLeft;
            ConsultarTipoDeProduto.Location = new Point(0, 77);
            ConsultarTipoDeProduto.Margin = new Padding(3, 4, 3, 4);
            ConsultarTipoDeProduto.Name = "ConsultarTipoDeProduto";
            ConsultarTipoDeProduto.Padding = new Padding(23, 0, 0, 0);
            ConsultarTipoDeProduto.Size = new Size(206, 40);
            ConsultarTipoDeProduto.TabIndex = 2;
            ConsultarTipoDeProduto.Text = "     Consultar produto";
            ConsultarTipoDeProduto.TextAlign = ContentAlignment.MiddleLeft;
            ConsultarTipoDeProduto.UseVisualStyleBackColor = true;
            ConsultarTipoDeProduto.Click += ConsultarTipoDeProduto_Click;
            // 
            // CadastrarTipoProduto
            // 
            CadastrarTipoProduto.FlatAppearance.BorderSize = 0;
            CadastrarTipoProduto.FlatStyle = FlatStyle.Flat;
            CadastrarTipoProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarTipoProduto.ForeColor = SystemColors.Desktop;
            CadastrarTipoProduto.Image = (Image)resources.GetObject("CadastrarTipoProduto.Image");
            CadastrarTipoProduto.ImageAlign = ContentAlignment.MiddleLeft;
            CadastrarTipoProduto.Location = new Point(0, 37);
            CadastrarTipoProduto.Margin = new Padding(3, 4, 3, 4);
            CadastrarTipoProduto.Name = "CadastrarTipoProduto";
            CadastrarTipoProduto.Padding = new Padding(23, 0, 0, 0);
            CadastrarTipoProduto.Size = new Size(206, 40);
            CadastrarTipoProduto.TabIndex = 1;
            CadastrarTipoProduto.Text = "     Cadastrar tipo";
            CadastrarTipoProduto.TextAlign = ContentAlignment.MiddleLeft;
            CadastrarTipoProduto.UseVisualStyleBackColor = true;
            CadastrarTipoProduto.Click += CadastrarTipoProduto_Click;
            // 
            // CadastrarProduto
            // 
            CadastrarProduto.FlatAppearance.BorderSize = 0;
            CadastrarProduto.FlatStyle = FlatStyle.Flat;
            CadastrarProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarProduto.ForeColor = SystemColors.Desktop;
            CadastrarProduto.Image = (Image)resources.GetObject("CadastrarProduto.Image");
            CadastrarProduto.ImageAlign = ContentAlignment.MiddleLeft;
            CadastrarProduto.Location = new Point(-1, -1);
            CadastrarProduto.Margin = new Padding(3, 4, 3, 4);
            CadastrarProduto.Name = "CadastrarProduto";
            CadastrarProduto.Padding = new Padding(23, 0, 0, 0);
            CadastrarProduto.Size = new Size(207, 40);
            CadastrarProduto.TabIndex = 0;
            CadastrarProduto.Text = "     Cadastrar produto";
            CadastrarProduto.TextAlign = ContentAlignment.MiddleLeft;
            CadastrarProduto.UseVisualStyleBackColor = true;
            CadastrarProduto.Click += CadastrarProduto_Click;
            // 
            // BtEstoque
            // 
            BtEstoque.FlatAppearance.BorderSize = 0;
            BtEstoque.FlatStyle = FlatStyle.Flat;
            BtEstoque.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtEstoque.ForeColor = SystemColors.Desktop;
            BtEstoque.Image = (Image)resources.GetObject("BtEstoque.Image");
            BtEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            BtEstoque.Location = new Point(0, 256);
            BtEstoque.Margin = new Padding(3, 4, 3, 4);
            BtEstoque.Name = "BtEstoque";
            BtEstoque.Padding = new Padding(6, 0, 0, 0);
            BtEstoque.Size = new Size(206, 47);
            BtEstoque.TabIndex = 5;
            BtEstoque.Text = "     Estoque";
            BtEstoque.TextAlign = ContentAlignment.MiddleLeft;
            BtEstoque.UseVisualStyleBackColor = true;
            BtEstoque.Click += BtEstoque_Click;
            // 
            // ConsultaPanel
            // 
            ConsultaPanel.BackColor = Color.FromArgb(239, 239, 239);
            ConsultaPanel.Controls.Add(ConsultaFornecedor);
            ConsultaPanel.Controls.Add(ConsultaCliente);
            ConsultaPanel.Location = new Point(0, 173);
            ConsultaPanel.Margin = new Padding(3, 4, 3, 4);
            ConsultaPanel.Name = "ConsultaPanel";
            ConsultaPanel.Size = new Size(206, 81);
            ConsultaPanel.TabIndex = 4;
            // 
            // ConsultaFornecedor
            // 
            ConsultaFornecedor.FlatAppearance.BorderSize = 0;
            ConsultaFornecedor.FlatStyle = FlatStyle.Flat;
            ConsultaFornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConsultaFornecedor.ForeColor = SystemColors.Desktop;
            ConsultaFornecedor.Image = (Image)resources.GetObject("ConsultaFornecedor.Image");
            ConsultaFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            ConsultaFornecedor.Location = new Point(0, 39);
            ConsultaFornecedor.Margin = new Padding(3, 4, 3, 4);
            ConsultaFornecedor.Name = "ConsultaFornecedor";
            ConsultaFornecedor.Padding = new Padding(23, 0, 0, 0);
            ConsultaFornecedor.Size = new Size(206, 40);
            ConsultaFornecedor.TabIndex = 1;
            ConsultaFornecedor.Text = "     Fornecedor";
            ConsultaFornecedor.TextAlign = ContentAlignment.MiddleLeft;
            ConsultaFornecedor.UseVisualStyleBackColor = true;
            ConsultaFornecedor.Click += ConsultaFornecedor_Click;
            // 
            // ConsultaCliente
            // 
            ConsultaCliente.FlatAppearance.BorderSize = 0;
            ConsultaCliente.FlatStyle = FlatStyle.Flat;
            ConsultaCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConsultaCliente.ForeColor = SystemColors.Desktop;
            ConsultaCliente.Image = (Image)resources.GetObject("ConsultaCliente.Image");
            ConsultaCliente.ImageAlign = ContentAlignment.MiddleLeft;
            ConsultaCliente.Location = new Point(-1, 0);
            ConsultaCliente.Margin = new Padding(3, 4, 3, 4);
            ConsultaCliente.Name = "ConsultaCliente";
            ConsultaCliente.Padding = new Padding(23, 0, 0, 0);
            ConsultaCliente.Size = new Size(207, 40);
            ConsultaCliente.TabIndex = 0;
            ConsultaCliente.Text = "     Cliente";
            ConsultaCliente.TextAlign = ContentAlignment.MiddleLeft;
            ConsultaCliente.UseVisualStyleBackColor = true;
            ConsultaCliente.Click += ConsultaCliente_Click;
            // 
            // BtConsulta
            // 
            BtConsulta.FlatAppearance.BorderSize = 0;
            BtConsulta.FlatStyle = FlatStyle.Flat;
            BtConsulta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtConsulta.ForeColor = SystemColors.Desktop;
            BtConsulta.Image = (Image)resources.GetObject("BtConsulta.Image");
            BtConsulta.ImageAlign = ContentAlignment.TopLeft;
            BtConsulta.Location = new Point(0, 128);
            BtConsulta.Margin = new Padding(3, 4, 3, 4);
            BtConsulta.Name = "BtConsulta";
            BtConsulta.Padding = new Padding(6, 0, 0, 0);
            BtConsulta.RightToLeft = RightToLeft.No;
            BtConsulta.Size = new Size(206, 47);
            BtConsulta.TabIndex = 3;
            BtConsulta.Text = "     Consulta";
            BtConsulta.TextAlign = ContentAlignment.MiddleLeft;
            BtConsulta.UseVisualStyleBackColor = true;
            BtConsulta.Click += BtConsulta_Click;
            // 
            // CadastroPanel
            // 
            CadastroPanel.BackColor = Color.FromArgb(239, 239, 239);
            CadastroPanel.Controls.Add(CadastroFornecedor);
            CadastroPanel.Controls.Add(CadastroCliente);
            CadastroPanel.Location = new Point(0, 45);
            CadastroPanel.Margin = new Padding(3, 4, 3, 4);
            CadastroPanel.Name = "CadastroPanel";
            CadastroPanel.Size = new Size(206, 81);
            CadastroPanel.TabIndex = 2;
            // 
            // CadastroFornecedor
            // 
            CadastroFornecedor.FlatAppearance.BorderSize = 0;
            CadastroFornecedor.FlatStyle = FlatStyle.Flat;
            CadastroFornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CadastroFornecedor.ForeColor = SystemColors.Desktop;
            CadastroFornecedor.Image = (Image)resources.GetObject("CadastroFornecedor.Image");
            CadastroFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            CadastroFornecedor.Location = new Point(0, 40);
            CadastroFornecedor.Margin = new Padding(3, 4, 3, 4);
            CadastroFornecedor.Name = "CadastroFornecedor";
            CadastroFornecedor.Padding = new Padding(23, 0, 0, 0);
            CadastroFornecedor.Size = new Size(206, 40);
            CadastroFornecedor.TabIndex = 1;
            CadastroFornecedor.Text = "     Fornecedor";
            CadastroFornecedor.TextAlign = ContentAlignment.MiddleLeft;
            CadastroFornecedor.UseVisualStyleBackColor = true;
            CadastroFornecedor.Click += button1_Click_1;
            // 
            // CadastroCliente
            // 
            CadastroCliente.FlatAppearance.BorderSize = 0;
            CadastroCliente.FlatStyle = FlatStyle.Flat;
            CadastroCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CadastroCliente.ForeColor = SystemColors.Desktop;
            CadastroCliente.Image = (Image)resources.GetObject("CadastroCliente.Image");
            CadastroCliente.ImageAlign = ContentAlignment.MiddleLeft;
            CadastroCliente.Location = new Point(-1, -1);
            CadastroCliente.Margin = new Padding(3, 4, 3, 4);
            CadastroCliente.Name = "CadastroCliente";
            CadastroCliente.Padding = new Padding(23, 0, 0, 0);
            CadastroCliente.Size = new Size(207, 40);
            CadastroCliente.TabIndex = 0;
            CadastroCliente.Text = "     Cliente";
            CadastroCliente.TextAlign = ContentAlignment.MiddleLeft;
            CadastroCliente.UseVisualStyleBackColor = true;
            CadastroCliente.Click += CadastroCliente_Click;
            // 
            // Cadastro
            // 
            Cadastro.FlatAppearance.BorderSize = 0;
            Cadastro.FlatStyle = FlatStyle.Flat;
            Cadastro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cadastro.ForeColor = SystemColors.Desktop;
            Cadastro.Image = (Image)resources.GetObject("Cadastro.Image");
            Cadastro.ImageAlign = ContentAlignment.MiddleLeft;
            Cadastro.Location = new Point(0, 0);
            Cadastro.Margin = new Padding(3, 4, 3, 4);
            Cadastro.Name = "Cadastro";
            Cadastro.Padding = new Padding(6, 0, 0, 0);
            Cadastro.Size = new Size(206, 47);
            Cadastro.TabIndex = 0;
            Cadastro.Text = "     Cadastro";
            Cadastro.TextAlign = ContentAlignment.MiddleLeft;
            Cadastro.UseVisualStyleBackColor = true;
            Cadastro.Click += Cadastro_Click;
            // 
            // DisplayFormsPanel
            // 
            DisplayFormsPanel.Controls.Add(pictureBox2);
            DisplayFormsPanel.Dock = DockStyle.Fill;
            DisplayFormsPanel.Location = new Point(206, 39);
            DisplayFormsPanel.Margin = new Padding(3, 4, 3, 4);
            DisplayFormsPanel.Name = "DisplayFormsPanel";
            DisplayFormsPanel.Size = new Size(880, 761);
            DisplayFormsPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-5, -21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 814);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // SideMenuBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1086, 800);
            Controls.Add(DisplayFormsPanel);
            Controls.Add(SideMenuPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1086, 800);
            Name = "SideMenuBar";
            Text = "SideMenuBar";
            Load += SideMenuBar_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SideMenuPanel.ResumeLayout(false);
            EstoquePanel.ResumeLayout(false);
            ConsultaPanel.ResumeLayout(false);
            CadastroPanel.ResumeLayout(false);
            DisplayFormsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel SideMenuPanel;
        private Panel CadastroPanel;
        private Button Cadastro;
        private Button CadastroFornecedor;
        private Button CadastroCliente;
        private Button CadastrarTipoProduto;
        private Panel EstoquePanel;
        private Button CadastrarProduto;
        private Button BtEstoque;
        private Panel ConsultaPanel;
        private Button ConsultaFornecedor;
        private Button ConsultaCliente;
        private Button BtConsulta;
        private Button ConsultarTipoDeProduto;
        private PictureBox pictureBox1;
        private Panel DisplayFormsPanel;
        private Button BotaoDeSair;
        private PictureBox pictureBox2;
    }
}