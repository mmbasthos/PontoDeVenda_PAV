namespace PontoDeVenda_PAV.Interface
{
    partial class TelaCadastroFornecedor
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
            label1 = new Label();
            label2 = new Label();
            campoFornecedorNome = new TextBox();
            campoFornecedorEmail = new TextBox();
            campoFornecedorTelefone = new TextBox();
            campoFornecedorCpf = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxEstadoFornecedor = new ComboBox();
            campoFornecedorCep = new TextBox();
            campoFornecedorBairro = new TextBox();
            campoFornecedorCidade = new TextBox();
            campoFornecedorComplemento = new TextBox();
            campoFornecedorNumeroLog = new TextBox();
            campoFornecedorLogradouro = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(607, 268);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 139);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 1;
            label1.Text = "Endereço do Fornecedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(218, 21);
            label2.TabIndex = 2;
            label2.Text = "Dados Gerais do Fornecedor";
            // 
            // campoFornecedorNome
            // 
            campoFornecedorNome.Location = new Point(10, 58);
            campoFornecedorNome.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorNome.Name = "campoFornecedorNome";
            campoFornecedorNome.Size = new Size(329, 23);
            campoFornecedorNome.TabIndex = 3;
            // 
            // campoFornecedorEmail
            // 
            campoFornecedorEmail.Location = new Point(284, 98);
            campoFornecedorEmail.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorEmail.Name = "campoFornecedorEmail";
            campoFornecedorEmail.Size = new Size(406, 23);
            campoFornecedorEmail.TabIndex = 4;
            // 
            // campoFornecedorTelefone
            // 
            campoFornecedorTelefone.Location = new Point(10, 98);
            campoFornecedorTelefone.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorTelefone.Name = "campoFornecedorTelefone";
            campoFornecedorTelefone.Size = new Size(252, 23);
            campoFornecedorTelefone.TabIndex = 5;
            // 
            // campoFornecedorCpf
            // 
            campoFornecedorCpf.Location = new Point(361, 58);
            campoFornecedorCpf.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorCpf.Name = "campoFornecedorCpf";
            campoFornecedorCpf.Size = new Size(329, 23);
            campoFornecedorCpf.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 41);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 7;
            label3.Text = "Nome do Fornecedor:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 81);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 81);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 41);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 10;
            label6.Text = "CNPJ ou CPF";
            // 
            // comboBoxEstadoFornecedor
            // 
            comboBoxEstadoFornecedor.FormattingEnabled = true;
            comboBoxEstadoFornecedor.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxEstadoFornecedor.Location = new Point(446, 233);
            comboBoxEstadoFornecedor.Margin = new Padding(3, 2, 3, 2);
            comboBoxEstadoFornecedor.Name = "comboBoxEstadoFornecedor";
            comboBoxEstadoFornecedor.Size = new Size(67, 23);
            comboBoxEstadoFornecedor.TabIndex = 11;
            // 
            // campoFornecedorCep
            // 
            campoFornecedorCep.Location = new Point(532, 234);
            campoFornecedorCep.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorCep.Name = "campoFornecedorCep";
            campoFornecedorCep.Size = new Size(158, 23);
            campoFornecedorCep.TabIndex = 12;
            // 
            // campoFornecedorBairro
            // 
            campoFornecedorBairro.Location = new Point(10, 234);
            campoFornecedorBairro.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorBairro.Name = "campoFornecedorBairro";
            campoFornecedorBairro.Size = new Size(199, 23);
            campoFornecedorBairro.TabIndex = 13;
            // 
            // campoFornecedorCidade
            // 
            campoFornecedorCidade.Location = new Point(229, 234);
            campoFornecedorCidade.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorCidade.Name = "campoFornecedorCidade";
            campoFornecedorCidade.Size = new Size(199, 23);
            campoFornecedorCidade.TabIndex = 14;
            // 
            // campoFornecedorComplemento
            // 
            campoFornecedorComplemento.Location = new Point(446, 193);
            campoFornecedorComplemento.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorComplemento.Name = "campoFornecedorComplemento";
            campoFornecedorComplemento.Size = new Size(244, 23);
            campoFornecedorComplemento.TabIndex = 15;
            // 
            // campoFornecedorNumeroLog
            // 
            campoFornecedorNumeroLog.Location = new Point(361, 193);
            campoFornecedorNumeroLog.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorNumeroLog.Name = "campoFornecedorNumeroLog";
            campoFornecedorNumeroLog.Size = new Size(67, 23);
            campoFornecedorNumeroLog.TabIndex = 16;
            // 
            // campoFornecedorLogradouro
            // 
            campoFornecedorLogradouro.Location = new Point(10, 193);
            campoFornecedorLogradouro.Margin = new Padding(3, 2, 3, 2);
            campoFornecedorLogradouro.Name = "campoFornecedorLogradouro";
            campoFornecedorLogradouro.Size = new Size(329, 23);
            campoFornecedorLogradouro.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(361, 176);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 18;
            label7.Text = "Nº";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 176);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 19;
            label8.Text = "Logradouro";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 215);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 20;
            label9.Text = "Bairro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(229, 215);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 21;
            label10.Text = "Cidade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(446, 176);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 22;
            label11.Text = "Complemento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(446, 215);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 23;
            label12.Text = "UF";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(532, 215);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 24;
            label13.Text = "CEP";
            // 
            // button2
            // 
            button2.Location = new Point(520, 268);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 25;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TelaCadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 248, 250);
            ClientSize = new Size(700, 298);
            Controls.Add(button2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(campoFornecedorLogradouro);
            Controls.Add(campoFornecedorNumeroLog);
            Controls.Add(campoFornecedorComplemento);
            Controls.Add(campoFornecedorCidade);
            Controls.Add(campoFornecedorBairro);
            Controls.Add(campoFornecedorCep);
            Controls.Add(comboBoxEstadoFornecedor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(campoFornecedorCpf);
            Controls.Add(campoFornecedorTelefone);
            Controls.Add(campoFornecedorEmail);
            Controls.Add(campoFornecedorNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCadastroFornecedor";
            Text = "TelaCadastroFornecedor";
            Load += TelaCadastroFornecedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox campoFornecedorNome;
        private TextBox campoFornecedorEmail;
        private TextBox campoFornecedorTelefone;
        private TextBox campoFornecedorCpf;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxEstadoFornecedor;
        private TextBox campoFornecedorCep;
        private TextBox campoFornecedorBairro;
        private TextBox campoFornecedorCidade;
        private TextBox campoFornecedorComplemento;
        private TextBox campoFornecedorNumeroLog;
        private TextBox campoFornecedorLogradouro;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button2;
    }
}