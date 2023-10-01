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
            campoSaldoCaixa = new TextBox();
            abrirCaixa = new Button();
            cancelarAbertura = new Button();
            campoNomeCaixa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // campoSaldoCaixa
            // 
            campoSaldoCaixa.Location = new Point(12, 85);
            campoSaldoCaixa.Multiline = true;
            campoSaldoCaixa.Name = "campoSaldoCaixa";
            campoSaldoCaixa.PlaceholderText = "Insira o Saldo Inicial";
            campoSaldoCaixa.Size = new Size(277, 27);
            campoSaldoCaixa.TabIndex = 0;
            // 
            // abrirCaixa
            // 
            abrirCaixa.Location = new Point(161, 135);
            abrirCaixa.Name = "abrirCaixa";
            abrirCaixa.Size = new Size(128, 29);
            abrirCaixa.TabIndex = 2;
            abrirCaixa.Text = "Abrir Caixa";
            abrirCaixa.UseVisualStyleBackColor = true;
            abrirCaixa.Click += abrirCaixa_Click;
            // 
            // cancelarAbertura
            // 
            cancelarAbertura.Location = new Point(12, 135);
            cancelarAbertura.Name = "cancelarAbertura";
            cancelarAbertura.Size = new Size(128, 29);
            cancelarAbertura.TabIndex = 3;
            cancelarAbertura.Text = "Cancelar";
            cancelarAbertura.UseVisualStyleBackColor = true;
            // 
            // campoNomeCaixa
            // 
            campoNomeCaixa.Location = new Point(12, 32);
            campoNomeCaixa.Name = "campoNomeCaixa";
            campoNomeCaixa.PlaceholderText = "Insira o Nome do Caixa";
            campoNomeCaixa.Size = new Size(277, 27);
            campoNomeCaixa.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome do Caixa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 6;
            label2.Text = "Saldo Inicial";
            // 
            // TelaAberturaCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 176);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(campoNomeCaixa);
            Controls.Add(cancelarAbertura);
            Controls.Add(abrirCaixa);
            Controls.Add(campoSaldoCaixa);
            Name = "TelaAberturaCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abrir Caixa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox campoSaldoCaixa;
        private Button abrirCaixa;
        private Button cancelarAbertura;
        private TextBox campoNomeCaixa;
    }
}