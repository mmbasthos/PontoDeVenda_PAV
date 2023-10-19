namespace PontoDeVenda_PAV.Interface
{
    partial class TelaIdentificarFornecedor
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
            comboBoxFornecedorProd = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBoxFornecedorProd
            // 
            comboBoxFornecedorProd.FormattingEnabled = true;
            comboBoxFornecedorProd.Location = new Point(12, 12);
            comboBoxFornecedorProd.Name = "comboBoxFornecedorProd";
            comboBoxFornecedorProd.Size = new Size(309, 28);
            comboBoxFornecedorProd.TabIndex = 0;
            comboBoxFornecedorProd.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 46);
            button1.Name = "button1";
            button1.Size = new Size(209, 29);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar Fornecedor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 46);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "ok";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TelaIdentificarFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 87);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxFornecedorProd);
            Name = "TelaIdentificarFornecedor";
            Text = "TelaIdentificarFornecedor";
            Load += TelaIdentificarFornecedor_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxFornecedorProd;
        private Button button1;
        private Button button2;
    }
}