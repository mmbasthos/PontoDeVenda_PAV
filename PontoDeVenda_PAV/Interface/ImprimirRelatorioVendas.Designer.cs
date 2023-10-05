namespace PontoDeVenda_PAV.Interface
{
    partial class ImprimirRelatorioVendas
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
            lblTotalVendas = new Label();
            lblTotalCanceladas = new Label();
            btnConsultar = new Button();
            label1 = new Label();
            label2 = new Label();
            labelTotalFinal = new Label();
            button1 = new Button();
            txtIdCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(313, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(331, 28);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(313, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1134, 431);
            dataGridView1.TabIndex = 2;
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Location = new Point(12, 505);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(0, 20);
            lblTotalVendas.TabIndex = 3;
            // 
            // lblTotalCanceladas
            // 
            lblTotalCanceladas.AutoSize = true;
            lblTotalCanceladas.Location = new Point(348, 505);
            lblTotalCanceladas.Name = "lblTotalCanceladas";
            lblTotalCanceladas.Size = new Size(0, 20);
            lblTotalCanceladas.TabIndex = 4;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(650, 26);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(160, 29);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Procurar Por Data";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 6;
            label1.Text = "De";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 5);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 7;
            label2.Text = "Até";
            // 
            // labelTotalFinal
            // 
            labelTotalFinal.AutoSize = true;
            labelTotalFinal.Location = new Point(674, 505);
            labelTotalFinal.Name = "labelTotalFinal";
            labelTotalFinal.Size = new Size(0, 20);
            labelTotalFinal.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(970, 26);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 9;
            button1.Text = "Procurar Por ID Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(878, 26);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.PlaceholderText = "Insira o ID";
            txtIdCliente.Size = new Size(86, 27);
            txtIdCliente.TabIndex = 10;
            // 
            // ImprimirRelatorioVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 537);
            Controls.Add(txtIdCliente);
            Controls.Add(button1);
            Controls.Add(labelTotalFinal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            Controls.Add(lblTotalCanceladas);
            Controls.Add(lblTotalVendas);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "ImprimirRelatorioVendas";
            Text = "ImprimirRelatorioVendas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Label lblTotalVendas;
        private Label lblTotalCanceladas;
        private Button btnConsultar;
        private Label label1;
        private Label label2;
        private Label labelTotalFinal;
        private Button button1;
        private TextBox txtIdCliente;
    }
}