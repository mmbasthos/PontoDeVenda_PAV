namespace PontoDeVenda_PAV.Interface
{
    partial class ConsultaClientes
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
            campoPesqID = new TextBox();
            campoPesqNome = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1156, 10);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1110, 11);
            button2.Name = "button2";
            button2.Size = new Size(40, 29);
            button2.TabIndex = 1;
            button2.Text = "O";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // campoPesqID
            // 
            campoPesqID.Location = new Point(12, 12);
            campoPesqID.Name = "campoPesqID";
            campoPesqID.PlaceholderText = "Procurar por ID";
            campoPesqID.Size = new Size(138, 27);
            campoPesqID.TabIndex = 2;
            campoPesqID.KeyDown += textBox1_KeyDown;
            // 
            // campoPesqNome
            // 
            campoPesqNome.Location = new Point(156, 12);
            campoPesqNome.Name = "campoPesqNome";
            campoPesqNome.PlaceholderText = "Procurar por Nome ";
            campoPesqNome.Size = new Size(280, 27);
            campoPesqNome.TabIndex = 3;
            campoPesqNome.TextChanged += campoPesqNome_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1238, 616);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // ConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dataGridView1);
            Controls.Add(campoPesqNome);
            Controls.Add(campoPesqID);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ConsultaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaClientes";
            Load += ConsultaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox campoPesqID;
        private TextBox campoPesqNome;
        private DataGridView dataGridView1;
    }
}