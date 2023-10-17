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
            button1.Location = new Point(1012, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(971, 8);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(35, 22);
            button2.TabIndex = 1;
            button2.Text = "O";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // campoPesqID
            // 
            campoPesqID.Location = new Point(10, 9);
            campoPesqID.Margin = new Padding(3, 2, 3, 2);
            campoPesqID.Name = "campoPesqID";
            campoPesqID.PlaceholderText = "Procurar por ID";
            campoPesqID.Size = new Size(121, 23);
            campoPesqID.TabIndex = 2;
            campoPesqID.KeyDown += textBox1_KeyDown;
            // 
            // campoPesqNome
            // 
            campoPesqNome.Location = new Point(136, 9);
            campoPesqNome.Margin = new Padding(3, 2, 3, 2);
            campoPesqNome.Name = "campoPesqNome";
            campoPesqNome.PlaceholderText = "Procurar por Nome ";
            campoPesqNome.Size = new Size(246, 23);
            campoPesqNome.TabIndex = 3;
            campoPesqNome.TextChanged += campoPesqNome_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 34);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1083, 462);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // ConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 248, 250);
            ClientSize = new Size(1104, 505);
            Controls.Add(dataGridView1);
            Controls.Add(campoPesqNome);
            Controls.Add(campoPesqID);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
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