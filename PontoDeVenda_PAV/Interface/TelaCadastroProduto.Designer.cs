namespace PontoDeVenda_PAV.Interface
{
    partial class TelaCadastroProduto
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
            campoNomeProd = new TextBox();
            campoQTDProd = new TextBox();
            campoPrecoProd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBoxTipoProd = new ComboBox();
            comboBoxFornecedorProd = new ComboBox();
            SuspendLayout();
            // 
            // campoNomeProd
            // 
            campoNomeProd.Location = new Point(12, 74);
            campoNomeProd.Name = "campoNomeProd";
            campoNomeProd.Size = new Size(329, 27);
            campoNomeProd.TabIndex = 0;
            // 
            // campoQTDProd
            // 
            campoQTDProd.Location = new Point(541, 74);
            campoQTDProd.Name = "campoQTDProd";
            campoQTDProd.Size = new Size(166, 27);
            campoQTDProd.TabIndex = 1;
            // 
            // campoPrecoProd
            // 
            campoPrecoProd.Location = new Point(362, 74);
            campoPrecoProd.Name = "campoPrecoProd";
            campoPrecoProd.Size = new Size(158, 27);
            campoPrecoProd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 6;
            label2.Text = "Dados do Produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome do Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 51);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(541, 51);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 9;
            label4.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 104);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 10;
            label5.Text = "Tipo do Produto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(362, 104);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 11;
            label6.Text = "Fornecido por";
            // 
            // button1
            // 
            button1.Location = new Point(613, 171);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(515, 171);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxTipoProd
            // 
            comboBoxTipoProd.FormattingEnabled = true;
            comboBoxTipoProd.Location = new Point(12, 127);
            comboBoxTipoProd.Name = "comboBoxTipoProd";
            comboBoxTipoProd.Size = new Size(329, 28);
            comboBoxTipoProd.TabIndex = 16;
            // 
            // comboBoxFornecedorProd
            // 
            comboBoxFornecedorProd.FormattingEnabled = true;
            comboBoxFornecedorProd.Location = new Point(362, 127);
            comboBoxFornecedorProd.Name = "comboBoxFornecedorProd";
            comboBoxFornecedorProd.Size = new Size(345, 28);
            comboBoxFornecedorProd.TabIndex = 17;
            // 
            // TelaCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 214);
            Controls.Add(comboBoxFornecedorProd);
            Controls.Add(comboBoxTipoProd);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(campoPrecoProd);
            Controls.Add(campoQTDProd);
            Controls.Add(campoNomeProd);
            Name = "TelaCadastroProduto";
            Text = "TelaCadastroProduto";
            Load += TelaCadastroProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private TextBox campoNomeProd;
        private TextBox campoQTDProd;
        private TextBox campoPrecoProd;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private ComboBox comboBoxTipoProd;
        private ComboBox comboBoxFornecedorProd;
    }
}