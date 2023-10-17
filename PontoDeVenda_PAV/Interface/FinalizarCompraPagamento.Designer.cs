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
            campoDinRecebido.Location = new Point(10, 59);
            campoDinRecebido.Margin = new Padding(3, 2, 3, 2);
            campoDinRecebido.Name = "campoDinRecebido";
            campoDinRecebido.PlaceholderText = "Dinheiro Recebido";
            campoDinRecebido.Size = new Size(128, 23);
            campoDinRecebido.TabIndex = 2;
            campoDinRecebido.TextChanged += campoDinRecebido_TextChanged;
            // 
            // campoTotal
            // 
            campoTotal.Location = new Point(10, 34);
            campoTotal.Margin = new Padding(3, 2, 3, 2);
            campoTotal.Name = "campoTotal";
            campoTotal.Size = new Size(261, 23);
            campoTotal.TabIndex = 1;
            campoTotal.TextChanged += campoTotal_TextChanged;
            // 
            // Finalizar
            // 
            Finalizar.Location = new Point(144, 94);
            Finalizar.Margin = new Padding(3, 2, 3, 2);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(128, 22);
            Finalizar.TabIndex = 2;
            Finalizar.Text = "Finalizar";
            Finalizar.UseVisualStyleBackColor = true;
            Finalizar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(10, 94);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(128, 22);
            button2.TabIndex = 3;
            button2.Text = "Continuar Compra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // campoFormaPag
            // 
            campoFormaPag.FormattingEnabled = true;
            campoFormaPag.Location = new Point(10, 9);
            campoFormaPag.Margin = new Padding(3, 2, 3, 2);
            campoFormaPag.Name = "campoFormaPag";
            campoFormaPag.Size = new Size(261, 23);
            campoFormaPag.TabIndex = 0;
            campoFormaPag.SelectedIndexChanged += campoFormaPag_SelectedIndexChanged;
            // 
            // campoTroco
            // 
            campoTroco.Location = new Point(144, 59);
            campoTroco.Margin = new Padding(3, 2, 3, 2);
            campoTroco.Name = "campoTroco";
            campoTroco.PlaceholderText = "Troco";
            campoTroco.Size = new Size(128, 23);
            campoTroco.TabIndex = 4;
            // 
            // FinalizarCompraPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 128);
            Controls.Add(campoTroco);
            Controls.Add(campoFormaPag);
            Controls.Add(button2);
            Controls.Add(Finalizar);
            Controls.Add(campoTotal);
            Controls.Add(campoDinRecebido);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label1;
        private Label label2;
    }
}