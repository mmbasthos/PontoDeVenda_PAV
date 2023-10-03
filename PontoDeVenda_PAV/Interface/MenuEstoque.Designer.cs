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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            comboBoxFiltroTipo = new ComboBox();
            button5 = new Button();
            button4 = new Button();
            campoPesqNome = new TextBox();
            campoPesqID = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(212, 37);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar Produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(228, 9);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(212, 37);
            button2.TabIndex = 1;
            button2.Text = "Cadastrar Tipo de Produto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(444, 9);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(212, 37);
            button3.TabIndex = 2;
            button3.Text = "Consultar Tipos de Produto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxFiltroTipo);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(campoPesqNome);
            panel1.Controls.Add(campoPesqID);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(10, 58);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 438);
            panel1.TabIndex = 4;
            // 
            // comboBoxFiltroTipo
            // 
            comboBoxFiltroTipo.ForeColor = Color.Black;
            comboBoxFiltroTipo.FormattingEnabled = true;
            comboBoxFiltroTipo.Location = new Point(430, 3);
            comboBoxFiltroTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxFiltroTipo.Name = "comboBoxFiltroTipo";
            comboBoxFiltroTipo.Size = new Size(216, 23);
            comboBoxFiltroTipo.TabIndex = 5;
            comboBoxFiltroTipo.Text = "Filtrar por Tipo";
            comboBoxFiltroTipo.SelectedIndexChanged += comboBoxFiltroTipo_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(964, 2);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(27, 22);
            button5.TabIndex = 4;
            button5.Text = "O";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(997, 2);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 3;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // campoPesqNome
            // 
            campoPesqNome.Location = new Point(216, 2);
            campoPesqNome.Margin = new Padding(3, 2, 3, 2);
            campoPesqNome.Name = "campoPesqNome";
            campoPesqNome.PlaceholderText = "Procurar por Nome";
            campoPesqNome.Size = new Size(209, 23);
            campoPesqNome.TabIndex = 2;
            campoPesqNome.TextChanged += campoPesqNome_TextChanged;
            // 
            // campoPesqID
            // 
            campoPesqID.Location = new Point(3, 2);
            campoPesqID.Margin = new Padding(3, 2, 3, 2);
            campoPesqID.Name = "campoPesqID";
            campoPesqID.PlaceholderText = "Procurar por ID";
            campoPesqID.Size = new Size(209, 23);
            campoPesqID.TabIndex = 1;
            campoPesqID.TextChanged += campoPesqID_TextChanged;
            campoPesqID.KeyDown += campoPesqID_KeyDown;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 27);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1083, 418);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // MenuEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuEstoque (Interface Teste)";
            Load += MenuEstoque_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button4;
        private TextBox campoPesqNome;
        private TextBox campoPesqID;
        private Button button5;
        private ComboBox comboBoxFiltroTipo;
    }
}