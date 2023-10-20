namespace PontoDeVenda_PAV.Interface
{
    partial class ImprimirRelatorioCompras
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
            txtIdFornecedor = new TextBox();
            button1 = new Button();
            labelTotalFinal = new Label();
            label2 = new Label();
            label1 = new Label();
            btnConsultar = new Button();
            lblTotalCanceladas = new Label();
            lblTotalVendas = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtIdFornecedor
            // 
            txtIdFornecedor.Location = new Point(846, 30);
            txtIdFornecedor.Name = "txtIdFornecedor";
            txtIdFornecedor.PlaceholderText = "Insira o ID";
            txtIdFornecedor.Size = new Size(86, 27);
            txtIdFornecedor.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(938, 30);
            button1.Name = "button1";
            button1.Size = new Size(208, 29);
            button1.TabIndex = 20;
            button1.Text = "Procurar Por ID Fornecedor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelTotalFinal
            // 
            labelTotalFinal.AutoSize = true;
            labelTotalFinal.Location = new Point(674, 509);
            labelTotalFinal.Name = "labelTotalFinal";
            labelTotalFinal.Size = new Size(0, 20);
            labelTotalFinal.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 9);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 18;
            label2.Text = "Até";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 17;
            label1.Text = "De";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(650, 30);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(160, 29);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Procurar Por Data";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblTotalCanceladas
            // 
            lblTotalCanceladas.AutoSize = true;
            lblTotalCanceladas.Location = new Point(348, 509);
            lblTotalCanceladas.Name = "lblTotalCanceladas";
            lblTotalCanceladas.Size = new Size(0, 20);
            lblTotalCanceladas.TabIndex = 15;
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Location = new Point(12, 509);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(0, 20);
            lblTotalVendas.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1134, 431);
            dataGridView1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(331, 32);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(313, 27);
            dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(313, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // ImprimirRelatorioCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 537);
            Controls.Add(txtIdFornecedor);
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
            Name = "ImprimirRelatorioCompras";
            Text = "ImprimirRelatorioCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdFornecedor;
        private Button button1;
        private Label labelTotalFinal;
        private Label label2;
        private Label label1;
        private Button btnConsultar;
        private Label lblTotalCanceladas;
        private Label lblTotalVendas;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}