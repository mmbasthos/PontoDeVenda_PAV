namespace PontoDeVenda_PAV.Interface
{
    partial class ContasReceber
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            campoIdCliente = new TextBox();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(268, 12);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 1;
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
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(524, 10);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 3;
            button1.Text = "Procurar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Abertas", "Pagas", "Vencidas" });
            comboBox1.Location = new Point(1201, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // campoIdCliente
            // 
            campoIdCliente.Location = new Point(758, 12);
            campoIdCliente.Name = "campoIdCliente";
            campoIdCliente.Size = new Size(125, 27);
            campoIdCliente.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(889, 11);
            button2.Name = "button2";
            button2.Size = new Size(141, 29);
            button2.TabIndex = 6;
            button2.Text = "Procurar por ID";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(162, 556);
            button4.Name = "button4";
            button4.Size = new Size(170, 29);
            button4.TabIndex = 17;
            button4.Text = "Conta Vencida";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 556);
            button3.Name = "button3";
            button3.Size = new Size(144, 29);
            button3.TabIndex = 16;
            button3.Text = "Receber Conta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ContasReceber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 597);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(campoIdCliente);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "ContasReceber";
            Text = "ContasReceber";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox campoIdCliente;
        private Button button2;
        private Button button4;
        private Button button3;
    }
}