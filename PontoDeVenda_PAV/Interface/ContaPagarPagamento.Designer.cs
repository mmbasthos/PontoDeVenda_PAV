namespace PontoDeVenda_PAV.Interface
{
    partial class ContaPagarPagamento
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
            campoFormaPag = new ComboBox();
            campoTotal = new TextBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // campoFormaPag
            // 
            campoFormaPag.FormattingEnabled = true;
            campoFormaPag.Location = new Point(12, 12);
            campoFormaPag.Name = "campoFormaPag";
            campoFormaPag.Size = new Size(202, 28);
            campoFormaPag.TabIndex = 10;
            // 
            // campoTotal
            // 
            campoTotal.Location = new Point(12, 46);
            campoTotal.Name = "campoTotal";
            campoTotal.Size = new Size(202, 27);
            campoTotal.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(12, 79);
            button2.Name = "button2";
            button2.Size = new Size(202, 29);
            button2.TabIndex = 8;
            button2.Text = "Cancelar Pagamento";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 114);
            button1.Name = "button1";
            button1.Size = new Size(202, 29);
            button1.TabIndex = 7;
            button1.Text = "Pagar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ContaPagarPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 161);
            Controls.Add(campoFormaPag);
            Controls.Add(campoTotal);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ContaPagarPagamento";
            Text = "ContaPagarPagamento";
            Load += ContaPagarPagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox campoFormaPag;
        private TextBox campoTotal;
        private Button button2;
        private Button button1;
    }
}