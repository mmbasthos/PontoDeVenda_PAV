namespace PontoDeVenda_PAV.Interface
{
    partial class ConsultaTipoProduto
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            controladorClassificacaoProdutoBindingSource = new BindingSource(components);
            campoPesqID = new TextBox();
            campoPesqNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controladorClassificacaoProdutoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 383);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // controladorClassificacaoProdutoBindingSource
            // 
            controladorClassificacaoProdutoBindingSource.DataSource = typeof(Controladores.ControladorClassificacaoProduto);
            // 
            // campoPesqID
            // 
            campoPesqID.Location = new Point(12, 12);
            campoPesqID.Name = "campoPesqID";
            campoPesqID.PlaceholderText = "Pesquisa Por Id";
            campoPesqID.Size = new Size(246, 27);
            campoPesqID.TabIndex = 1;
            campoPesqID.TextChanged += textBox1_TextChanged;
            campoPesqID.KeyDown += campoPesqID_KeyDown;
            campoPesqID.KeyPress += textBox1_KeyPress;
            // 
            // campoPesqNome
            // 
            campoPesqNome.Location = new Point(264, 12);
            campoPesqNome.Name = "campoPesqNome";
            campoPesqNome.PlaceholderText = "Pesquisa Por Nome";
            campoPesqNome.Size = new Size(246, 27);
            campoPesqNome.TabIndex = 2;
            campoPesqNome.TextChanged += campoPesqNome_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(694, 10);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(647, 10);
            button2.Name = "button2";
            button2.Size = new Size(41, 29);
            button2.TabIndex = 4;
            button2.Text = "O";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.Paint += button2_Paint;
            // 
            // ConsultaTipoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(campoPesqNome);
            Controls.Add(campoPesqID);
            Controls.Add(dataGridView1);
            Name = "ConsultaTipoProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaTipoProduto";
            Load += ConsultaTipoProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)controladorClassificacaoProdutoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource controladorClassificacaoProdutoBindingSource;
        private TextBox campoPesqID;
        private TextBox campoPesqNome;
        private Button button1;
        private Button button2;
    }
}