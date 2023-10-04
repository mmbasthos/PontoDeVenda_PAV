namespace PontoDeVenda_PAV.Interface
{
    partial class FinalizarCompraPagamento
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
            campoDinRecebido = new TextBox();
            campoTotal = new TextBox();
            Finalizar = new Button();
            button2 = new Button();
            campoFormaPag = new ComboBox();
            campoTroco = new TextBox();
            SuspendLayout();
            // 
            // campoDinRecebido
            // 
            campoDinRecebido.Location = new Point(12, 79);
            campoDinRecebido.Name = "campoDinRecebido";
            campoDinRecebido.Size = new Size(146, 27);
            campoDinRecebido.TabIndex = 0;
            campoDinRecebido.TextChanged += campoDinRecebido_TextChanged;
            // 
            // campoTotal
            // 
            campoTotal.Location = new Point(12, 46);
            campoTotal.Name = "campoTotal";
            campoTotal.Size = new Size(298, 27);
            campoTotal.TabIndex = 1;
            campoTotal.TextChanged += campoTotal_TextChanged;
            // 
            // Finalizar
            // 
            Finalizar.Location = new Point(164, 126);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(146, 29);
            Finalizar.TabIndex = 2;
            Finalizar.Text = "Finalizar";
            Finalizar.UseVisualStyleBackColor = true;
            Finalizar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 126);
            button2.Name = "button2";
            button2.Size = new Size(146, 29);
            button2.TabIndex = 3;
            button2.Text = "Continuar Compra";
            button2.UseVisualStyleBackColor = true;
            // 
            // campoFormaPag
            // 
            campoFormaPag.FormattingEnabled = true;
            campoFormaPag.Location = new Point(12, 12);
            campoFormaPag.Name = "campoFormaPag";
            campoFormaPag.Size = new Size(298, 28);
            campoFormaPag.TabIndex = 4;
            // 
            // campoTroco
            // 
            campoTroco.Location = new Point(164, 79);
            campoTroco.Name = "campoTroco";
            campoTroco.Size = new Size(146, 27);
            campoTroco.TabIndex = 5;
            // 
            // FinalizarCompraPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 170);
            Controls.Add(campoTroco);
            Controls.Add(campoFormaPag);
            Controls.Add(button2);
            Controls.Add(Finalizar);
            Controls.Add(campoTotal);
            Controls.Add(campoDinRecebido);
            Name = "FinalizarCompraPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalizarCompraPagamento";
            Load += FinalizarCompraPagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campoDinRecebido;
        private TextBox campoTotal;
        private Button Finalizar;
        private Button button2;
        private ComboBox campoFormaPag;
        private TextBox campoTroco;
    }
}