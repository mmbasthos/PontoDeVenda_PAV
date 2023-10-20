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
            button1 = new Button();
            button2 = new Button();
            campoTotal = new TextBox();
            campoFormaPag = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 114);
            button1.Name = "button1";
            button1.Size = new Size(202, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 79);
            button2.Name = "button2";
            button2.Size = new Size(202, 29);
            button2.TabIndex = 1;
            button2.Text = "Continuar Compra";
            button2.UseVisualStyleBackColor = true;
            // 
            // campoTotal
            // 
            campoTotal.Location = new Point(12, 46);
            campoTotal.Name = "campoTotal";
            campoTotal.Size = new Size(202, 27);
            campoTotal.TabIndex = 2;
            // 
            // campoFormaPag
            // 
            campoFormaPag.FormattingEnabled = true;
            campoFormaPag.Location = new Point(12, 12);
            campoFormaPag.Name = "campoFormaPag";
            campoFormaPag.Size = new Size(202, 28);
            campoFormaPag.TabIndex = 3;
            // 
            // FinalizarCompraPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 153);
            Controls.Add(campoFormaPag);
            Controls.Add(campoTotal);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FinalizarCompraPagamento";
            Text = "FinalizarCompraPagamento";
            Load += FinalizarCompraPagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox campoTotal;
        private ComboBox campoFormaPag;
    }
}