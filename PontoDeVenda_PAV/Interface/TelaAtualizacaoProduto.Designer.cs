namespace PontoDeVenda_PAV.Interface
{
    partial class TelaAtualizacaoProduto
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
            comboBoxTipoProd = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            campoPrecoProd = new TextBox();
            campoQTDProd = new TextBox();
            campoNomeProd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBoxFornecedorProd
            // 
            comboBoxFornecedorProd.FormattingEnabled = true;
            comboBoxFornecedorProd.Location = new Point(362, 127);
            comboBoxFornecedorProd.Name = "comboBoxFornecedorProd";
            comboBoxFornecedorProd.Size = new Size(345, 28);
            comboBoxFornecedorProd.TabIndex = 28;
            // 
            // comboBoxTipoProd
            // 
            comboBoxTipoProd.FormattingEnabled = true;
            comboBoxTipoProd.Location = new Point(12, 127);
            comboBoxTipoProd.Name = "comboBoxTipoProd";
            comboBoxTipoProd.Size = new Size(329, 28);
            comboBoxTipoProd.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(362, 104);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 26;
            label6.Text = "Fornecido por";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 104);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 25;
            label5.Text = "Tipo do Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(541, 51);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 24;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 51);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 23;
            label3.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 22;
            label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 21;
            label2.Text = "Dados do Produto";
            // 
            // campoPrecoProd
            // 
            campoPrecoProd.Location = new Point(362, 74);
            campoPrecoProd.Name = "campoPrecoProd";
            campoPrecoProd.Size = new Size(158, 27);
            campoPrecoProd.TabIndex = 20;
            // 
            // campoQTDProd
            // 
            campoQTDProd.Location = new Point(541, 74);
            campoQTDProd.Name = "campoQTDProd";
            campoQTDProd.Size = new Size(166, 27);
            campoQTDProd.TabIndex = 19;
            // 
            // campoNomeProd
            // 
            campoNomeProd.Location = new Point(12, 74);
            campoNomeProd.Name = "campoNomeProd";
            campoNomeProd.Size = new Size(329, 27);
            campoNomeProd.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(513, 173);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 29;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(613, 173);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 30;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TelaAtualizacaoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 214);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxFornecedorProd);
            Controls.Add(comboBoxTipoProd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(campoPrecoProd);
            Controls.Add(campoQTDProd);
            Controls.Add(campoNomeProd);
            Name = "TelaAtualizacaoProduto";
            Text = "TelaAtualizacaoProduto";
            Load += TelaAtualizacaoProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFornecedorProd;
        private ComboBox comboBoxTipoProd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox campoPrecoProd;
        private TextBox campoQTDProd;
        private TextBox campoNomeProd;
        private Button button1;
        private Button button2;
    }
}