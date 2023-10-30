namespace PontoDeVenda_PAV.Interface
{
    partial class ContaReceberPagamento
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
            campoFormaPag.TabIndex = 14;
            // 
            // campoTotal
            // 
            campoTotal.Location = new Point(12, 46);
            campoTotal.Name = "campoTotal";
            campoTotal.Size = new Size(202, 27);
            campoTotal.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(12, 79);
            button2.Name = "button2";
            button2.Size = new Size(202, 29);
            button2.TabIndex = 12;
            button2.Text = "Cancelar Pagamento";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 114);
            button1.Name = "button1";
            button1.Size = new Size(202, 29);
            button1.TabIndex = 15;
            button1.Text = "Receber ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ContaReceberPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 146);
            Controls.Add(button1);
            Controls.Add(campoFormaPag);
            Controls.Add(campoTotal);
            Controls.Add(button2);
            Name = "ContaReceberPagamento";
            Text = "ContaReceberPagamanto";
            Load += ContaReceberPagamanto_Load;
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