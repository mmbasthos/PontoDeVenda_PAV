namespace PontoDeVenda_PAV.Interface
{
    partial class FinalizarVendaPagamento
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
            Parcelamento = new ComboBox();
            SuspendLayout();
            // 
            // campoDinRecebido
            // 
            campoDinRecebido.Location = new Point(11, 102);
            campoDinRecebido.Name = "campoDinRecebido";
            campoDinRecebido.PlaceholderText = "Dinheiro Recebido";
            campoDinRecebido.Size = new Size(146, 27);
            campoDinRecebido.TabIndex = 2;
            campoDinRecebido.TextChanged += campoDinRecebido_TextChanged;
            // 
            // campoTotal
            // 
            campoTotal.Location = new Point(11, 57);
            campoTotal.Name = "campoTotal";
            campoTotal.Size = new Size(298, 27);
            campoTotal.TabIndex = 1;
            campoTotal.TextChanged += campoTotal_TextChanged;
            // 
            // Finalizar
            // 
            Finalizar.Location = new Point(165, 148);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(146, 29);
            Finalizar.TabIndex = 2;
            Finalizar.Text = "Finalizar";
            Finalizar.UseVisualStyleBackColor = true;
            Finalizar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(11, 148);
            button2.Name = "button2";
            button2.Size = new Size(146, 29);
            button2.TabIndex = 3;
            button2.Text = "Continuar Compra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // campoFormaPag
            // 
            campoFormaPag.FormattingEnabled = true;
            campoFormaPag.Location = new Point(11, 12);
            campoFormaPag.Name = "campoFormaPag";
            campoFormaPag.Size = new Size(234, 28);
            campoFormaPag.TabIndex = 0;
            campoFormaPag.SelectedIndexChanged += campoFormaPag_SelectedIndexChanged;
            // 
            // campoTroco
            // 
            campoTroco.Location = new Point(165, 102);
            campoTroco.Name = "campoTroco";
            campoTroco.PlaceholderText = "Troco";
            campoTroco.Size = new Size(146, 27);
            campoTroco.TabIndex = 4;
            // 
            // Parcelamento
            // 
            Parcelamento.FormattingEnabled = true;
            Parcelamento.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            Parcelamento.Location = new Point(251, 12);
            Parcelamento.Name = "Parcelamento";
            Parcelamento.Size = new Size(58, 28);
            Parcelamento.TabIndex = 5;
            // 
            // FinalizarVendaPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 190);
            Controls.Add(Parcelamento);
            Controls.Add(campoTroco);
            Controls.Add(campoFormaPag);
            Controls.Add(button2);
            Controls.Add(Finalizar);
            Controls.Add(campoTotal);
            Controls.Add(campoDinRecebido);
            Name = "FinalizarVendaPagamento";
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
        private ComboBox Parcelamento;
    }
}