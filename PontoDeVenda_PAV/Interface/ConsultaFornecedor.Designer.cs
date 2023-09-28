namespace PontoDeVenda_PAV.Interface
{
    partial class ConsultaFornecedor
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
            dataGridView1 = new DataGridView();
            campoPesqID = new TextBox();
            campoPesqNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1238, 598);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // campoPesqID
            // 
            campoPesqID.Location = new Point(12, 21);
            campoPesqID.Name = "campoPesqID";
            campoPesqID.PlaceholderText = "Procurar por ID";
            campoPesqID.Size = new Size(138, 27);
            campoPesqID.TabIndex = 1;
            campoPesqID.KeyDown += textBox1_KeyDown;
            // 
            // campoPesqNome
            // 
            campoPesqNome.Location = new Point(156, 21);
            campoPesqNome.Name = "campoPesqNome";
            campoPesqNome.PlaceholderText = "Procurar por Nome";
            campoPesqNome.Size = new Size(280, 27);
            campoPesqNome.TabIndex = 2;
            campoPesqNome.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1117, 19);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 3;
            button1.Text = "O";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1156, 20);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ConsultaFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(campoPesqNome);
            Controls.Add(campoPesqID);
            Controls.Add(dataGridView1);
            Name = "ConsultaFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaFornecedor";
            Load += ConsultaFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox campoPesqID;
        private TextBox campoPesqNome;
        private Button button1;
        private Button button2;
    }
}