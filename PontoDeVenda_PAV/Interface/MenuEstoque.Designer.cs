namespace PontoDeVenda_PAV.Interface
{
    partial class MenuEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEstoque));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            comboBoxFiltroTipo = new ComboBox();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            campoPesqID = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            campoPesqNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 34);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 16);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 6;
            label1.Text = "Estoque";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(229, 230, 234);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, -1);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1091, 471);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(10, 180);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 471);
            panel1.TabIndex = 4;
            // 
            // comboBoxFiltroTipo
            // 
            comboBoxFiltroTipo.FlatStyle = FlatStyle.Flat;
            comboBoxFiltroTipo.ForeColor = Color.Gray;
            comboBoxFiltroTipo.FormattingEnabled = true;
            comboBoxFiltroTipo.Location = new Point(10, 139);
            comboBoxFiltroTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxFiltroTipo.Name = "comboBoxFiltroTipo";
            comboBoxFiltroTipo.Size = new Size(184, 23);
            comboBoxFiltroTipo.TabIndex = 5;
            comboBoxFiltroTipo.Text = "Filtrar por Tipo";
            comboBoxFiltroTipo.SelectedIndexChanged += comboBoxFiltroTipo_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(224, 139);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(24, 23);
            button5.TabIndex = 4;
            button5.Text = "O";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Window;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(931, 105);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(170, 29);
            button3.TabIndex = 2;
            button3.Text = "Consultar tipos de produto";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(254, 139);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(109, 23);
            button4.TabIndex = 3;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(755, 105);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(170, 29);
            button2.TabIndex = 1;
            button2.Text = "Cadastrar tipos de produto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(campoPesqID);
            panel2.Location = new Point(10, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 29);
            panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 21);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // campoPesqID
            // 
            campoPesqID.BorderStyle = BorderStyle.None;
            campoPesqID.ForeColor = Color.WhiteSmoke;
            campoPesqID.Location = new Point(23, 5);
            campoPesqID.Margin = new Padding(3, 2, 3, 2);
            campoPesqID.Name = "campoPesqID";
            campoPesqID.PlaceholderText = "Procurar por ID";
            campoPesqID.Size = new Size(184, 16);
            campoPesqID.TabIndex = 1;
            campoPesqID.TextChanged += campoPesqID_TextChanged;
            campoPesqID.KeyDown += campoPesqID_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(579, 105);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar produto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(campoPesqNome);
            panel3.Location = new Point(224, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 29);
            panel3.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 21);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // campoPesqNome
            // 
            campoPesqNome.BorderStyle = BorderStyle.None;
            campoPesqNome.ForeColor = Color.WhiteSmoke;
            campoPesqNome.Location = new Point(27, 5);
            campoPesqNome.Margin = new Padding(3, 2, 3, 2);
            campoPesqNome.Name = "campoPesqNome";
            campoPesqNome.PlaceholderText = "Procurar por Nome";
            campoPesqNome.Size = new Size(140, 16);
            campoPesqNome.TabIndex = 2;
            campoPesqNome.TextChanged += campoPesqNome_TextChanged;
            // 
            // MenuEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1122, 662);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(comboBoxFiltroTipo);
            Controls.Add(button3);
            Controls.Add(button5);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuEstoque (Interface Teste)";
            Load += MenuEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private ComboBox comboBoxFiltroTipo;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button button2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox campoPesqID;
        private Button button1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private TextBox campoPesqNome;
    }
}