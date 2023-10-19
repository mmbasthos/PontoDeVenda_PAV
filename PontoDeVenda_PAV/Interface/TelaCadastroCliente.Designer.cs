namespace PontoDeVenda_PAV.Interface
{
    partial class TelaCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroCliente));
            campoLogradouroCliente = new TextBox();
            campoNumeroLogCliente = new TextBox();
            campoComplementoCliente = new TextBox();
            campoCidadeCliente = new TextBox();
            campoBairroCliente = new TextBox();
            campoCepCliente = new TextBox();
            comboBoxEstadoCliente = new ComboBox();
            campoCPFCliente = new TextBox();
            campoTelefoneCliente = new TextBox();
            campoEmailCliente = new TextBox();
            campoNomeCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            SuspendLayout();
            // 
            // campoLogradouroCliente
            // 
            campoLogradouroCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoLogradouroCliente.BorderStyle = BorderStyle.None;
            campoLogradouroCliente.Location = new Point(24, 318);
            campoLogradouroCliente.Margin = new Padding(3, 2, 3, 2);
            campoLogradouroCliente.Name = "campoLogradouroCliente";
            campoLogradouroCliente.PlaceholderText = "Detalhes sobre o logradouro";
            campoLogradouroCliente.Size = new Size(329, 16);
            campoLogradouroCliente.TabIndex = 41;
            // 
            // campoNumeroLogCliente
            // 
            campoNumeroLogCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoNumeroLogCliente.BorderStyle = BorderStyle.None;
            campoNumeroLogCliente.Location = new Point(373, 318);
            campoNumeroLogCliente.Margin = new Padding(3, 2, 3, 2);
            campoNumeroLogCliente.Name = "campoNumeroLogCliente";
            campoNumeroLogCliente.PlaceholderText = "Nº do local";
            campoNumeroLogCliente.Size = new Size(67, 16);
            campoNumeroLogCliente.TabIndex = 40;
            campoNumeroLogCliente.TextChanged += campoNumeroLogCliente_TextChanged;
            // 
            // campoComplementoCliente
            // 
            campoComplementoCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoComplementoCliente.BorderStyle = BorderStyle.None;
            campoComplementoCliente.Location = new Point(460, 315);
            campoComplementoCliente.Margin = new Padding(3, 2, 3, 2);
            campoComplementoCliente.Name = "campoComplementoCliente";
            campoComplementoCliente.PlaceholderText = "Complemento";
            campoComplementoCliente.Size = new Size(244, 16);
            campoComplementoCliente.TabIndex = 39;
            // 
            // campoCidadeCliente
            // 
            campoCidadeCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoCidadeCliente.BorderStyle = BorderStyle.None;
            campoCidadeCliente.Location = new Point(243, 378);
            campoCidadeCliente.Margin = new Padding(3, 2, 3, 2);
            campoCidadeCliente.Name = "campoCidadeCliente";
            campoCidadeCliente.PlaceholderText = "Cidade";
            campoCidadeCliente.Size = new Size(188, 16);
            campoCidadeCliente.TabIndex = 38;
            // 
            // campoBairroCliente
            // 
            campoBairroCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoBairroCliente.BorderStyle = BorderStyle.None;
            campoBairroCliente.Location = new Point(24, 378);
            campoBairroCliente.Margin = new Padding(3, 2, 3, 2);
            campoBairroCliente.Name = "campoBairroCliente";
            campoBairroCliente.PlaceholderText = "Bairro";
            campoBairroCliente.Size = new Size(199, 16);
            campoBairroCliente.TabIndex = 37;
            // 
            // campoCepCliente
            // 
            campoCepCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoCepCliente.BorderStyle = BorderStyle.None;
            campoCepCliente.Location = new Point(437, 378);
            campoCepCliente.Margin = new Padding(3, 2, 3, 2);
            campoCepCliente.Name = "campoCepCliente";
            campoCepCliente.PlaceholderText = "CEP";
            campoCepCliente.Size = new Size(77, 16);
            campoCepCliente.TabIndex = 36;
            // 
            // comboBoxEstadoCliente
            // 
            comboBoxEstadoCliente.AccessibleName = "";
            comboBoxEstadoCliente.FormattingEnabled = true;
            comboBoxEstadoCliente.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxEstadoCliente.Location = new Point(553, 378);
            comboBoxEstadoCliente.Margin = new Padding(3, 2, 3, 2);
            comboBoxEstadoCliente.Name = "comboBoxEstadoCliente";
            comboBoxEstadoCliente.Size = new Size(67, 23);
            comboBoxEstadoCliente.TabIndex = 35;
            // 
            // campoCPFCliente
            // 
            campoCPFCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoCPFCliente.BorderStyle = BorderStyle.None;
            campoCPFCliente.Location = new Point(314, 123);
            campoCPFCliente.Margin = new Padding(3, 2, 3, 2);
            campoCPFCliente.Name = "campoCPFCliente";
            campoCPFCliente.PlaceholderText = "Insira o CPF ou CNPJ";
            campoCPFCliente.Size = new Size(329, 16);
            campoCPFCliente.TabIndex = 30;
            // 
            // campoTelefoneCliente
            // 
            campoTelefoneCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoTelefoneCliente.BorderStyle = BorderStyle.None;
            campoTelefoneCliente.Location = new Point(24, 175);
            campoTelefoneCliente.Margin = new Padding(3, 2, 3, 2);
            campoTelefoneCliente.Name = "campoTelefoneCliente";
            campoTelefoneCliente.PlaceholderText = "Telefone";
            campoTelefoneCliente.Size = new Size(261, 16);
            campoTelefoneCliente.TabIndex = 29;
            // 
            // campoEmailCliente
            // 
            campoEmailCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoEmailCliente.BorderStyle = BorderStyle.None;
            campoEmailCliente.Location = new Point(314, 175);
            campoEmailCliente.Margin = new Padding(3, 2, 3, 2);
            campoEmailCliente.Name = "campoEmailCliente";
            campoEmailCliente.PlaceholderText = "E-mail";
            campoEmailCliente.Size = new Size(276, 16);
            campoEmailCliente.TabIndex = 28;
            // 
            // campoNomeCliente
            // 
            campoNomeCliente.BackColor = Color.FromArgb(246, 248, 250);
            campoNomeCliente.BorderStyle = BorderStyle.None;
            campoNomeCliente.Location = new Point(25, 123);
            campoNomeCliente.Margin = new Padding(3, 2, 3, 2);
            campoNomeCliente.Name = "campoNomeCliente";
            campoNomeCliente.PlaceholderText = "Insira o nome do cliente";
            campoNomeCliente.Size = new Size(329, 16);
            campoNomeCliente.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(181, 21);
            label2.TabIndex = 26;
            label2.Text = "Dados gerais do cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 251);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 25;
            label1.Text = "Endereço do cliente";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(108, 181, 223);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(622, 453);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 49;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Desktop;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Padding = new Padding(5, 0, 0, 0);
            button3.Size = new Size(36, 29);
            button3.TabIndex = 51;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 181, 223);
            panel1.Location = new Point(25, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 2);
            panel1.TabIndex = 52;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 181, 223);
            panel2.Location = new Point(314, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 2);
            panel2.TabIndex = 53;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(108, 181, 223);
            panel3.Location = new Point(24, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 2);
            panel3.TabIndex = 53;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(108, 181, 223);
            panel4.Location = new Point(314, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 2);
            panel4.TabIndex = 54;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(108, 181, 223);
            panel5.Location = new Point(24, 339);
            panel5.Name = "panel5";
            panel5.Size = new Size(329, 2);
            panel5.TabIndex = 53;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(108, 181, 223);
            panel6.Location = new Point(373, 339);
            panel6.Name = "panel6";
            panel6.Size = new Size(72, 2);
            panel6.TabIndex = 54;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(108, 181, 223);
            panel7.Location = new Point(461, 339);
            panel7.Name = "panel7";
            panel7.Size = new Size(243, 2);
            panel7.TabIndex = 54;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(108, 181, 223);
            panel8.Location = new Point(25, 399);
            panel8.Name = "panel8";
            panel8.Size = new Size(198, 2);
            panel8.TabIndex = 54;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(108, 181, 223);
            panel9.Location = new Point(243, 399);
            panel9.Name = "panel9";
            panel9.Size = new Size(169, 2);
            panel9.TabIndex = 55;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(108, 181, 223);
            panel10.Location = new Point(438, 399);
            panel10.Name = "panel10";
            panel10.Size = new Size(76, 2);
            panel10.TabIndex = 56;
            // 
            // TelaCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 248, 250);
            ClientSize = new Size(1138, 641);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(campoLogradouroCliente);
            Controls.Add(campoNumeroLogCliente);
            Controls.Add(campoComplementoCliente);
            Controls.Add(campoCidadeCliente);
            Controls.Add(campoBairroCliente);
            Controls.Add(campoCepCliente);
            Controls.Add(comboBoxEstadoCliente);
            Controls.Add(campoCPFCliente);
            Controls.Add(campoTelefoneCliente);
            Controls.Add(campoEmailCliente);
            Controls.Add(campoNomeCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCadastroCliente";
            Text = "TelaCadastroCliente";
            Load += TelaCadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox campoLogradouroCliente;
        private TextBox campoNumeroLogCliente;
        private TextBox campoComplementoCliente;
        private TextBox campoCidadeCliente;
        private TextBox campoBairroCliente;
        private TextBox campoCepCliente;
        private ComboBox comboBoxEstadoCliente;
        private TextBox campoCPFCliente;
        private TextBox campoTelefoneCliente;
        private TextBox campoEmailCliente;
        private TextBox campoNomeCliente;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
    }
}