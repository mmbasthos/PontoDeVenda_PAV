namespace PontoDeVenda_PAV.Interface
{
    partial class ContasPagar
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
            button2 = new Button();
            campoIdCliente = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(889, 11);
            button2.Name = "button2";
            button2.Size = new Size(141, 29);
            button2.TabIndex = 13;
            button2.Text = "Procurar por ID";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // campoIdCliente
            // 
            campoIdCliente.Location = new Point(758, 12);
            campoIdCliente.Name = "campoIdCliente";
            campoIdCliente.Size = new Size(125, 27);
            campoIdCliente.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Abertas", "Pagas", "Vencidas" });
            comboBox1.Location = new Point(1201, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(524, 10);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 10;
            button1.Text = "Procurar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1302, 501);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(268, 12);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(12, 560);
            button3.Name = "button3";
            button3.Size = new Size(144, 29);
            button3.TabIndex = 14;
            button3.Text = "Pagar Conta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(162, 560);
            button4.Name = "button4";
            button4.Size = new Size(170, 29);
            button4.TabIndex = 15;
            button4.Text = "Conta Vencida";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ContasPagar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 601);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(campoIdCliente);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "ContasPagar";
            Text = "ContasPagar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox campoIdCliente;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
    }
}