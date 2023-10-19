namespace PontoDeVenda_PAV.Interface
{
    partial class TelaAberturaCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAberturaCaixa));
            campoSaldoCaixa = new TextBox();
            abrirCaixa = new Button();
            campoNomeCaixa = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // campoSaldoCaixa
            // 
            campoSaldoCaixa.BorderStyle = BorderStyle.None;
            campoSaldoCaixa.Location = new Point(22, 219);
            campoSaldoCaixa.Margin = new Padding(3, 2, 3, 2);
            campoSaldoCaixa.Multiline = true;
            campoSaldoCaixa.Name = "campoSaldoCaixa";
            campoSaldoCaixa.PlaceholderText = "Insira o saldo Inicial";
            campoSaldoCaixa.Size = new Size(218, 19);
            campoSaldoCaixa.TabIndex = 0;
            // 
            // abrirCaixa
            // 
            abrirCaixa.BackColor = Color.FromArgb(108, 181, 223);
            abrirCaixa.FlatAppearance.BorderSize = 0;
            abrirCaixa.FlatStyle = FlatStyle.Flat;
            abrirCaixa.ForeColor = SystemColors.Window;
            abrirCaixa.Location = new Point(73, 348);
            abrirCaixa.Margin = new Padding(3, 2, 3, 2);
            abrirCaixa.Name = "abrirCaixa";
            abrirCaixa.Size = new Size(112, 22);
            abrirCaixa.TabIndex = 2;
            abrirCaixa.Text = "Abrir Caixa";
            abrirCaixa.UseVisualStyleBackColor = false;
            abrirCaixa.Click += abrirCaixa_Click;
            // 
            // campoNomeCaixa
            // 
            campoNomeCaixa.BorderStyle = BorderStyle.None;
            campoNomeCaixa.Location = new Point(22, 156);
            campoNomeCaixa.Margin = new Padding(3, 2, 3, 2);
            campoNomeCaixa.Name = "campoNomeCaixa";
            campoNomeCaixa.PlaceholderText = "Insira o nome do Caixa";
            campoNomeCaixa.Size = new Size(218, 16);
            campoNomeCaixa.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Desktop;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 0, 0);
            button1.Size = new Size(36, 29);
            button1.TabIndex = 9;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 181, 223);
            panel1.Location = new Point(22, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 2);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 181, 223);
            panel2.Location = new Point(22, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 2);
            panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 109);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // TelaAberturaCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(261, 395);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(campoNomeCaixa);
            Controls.Add(abrirCaixa);
            Controls.Add(campoSaldoCaixa);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaAberturaCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abrir Caixa";
            Load += TelaAberturaCaixa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox campoSaldoCaixa;
        private Button abrirCaixa;
        private TextBox campoNomeCaixa;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}