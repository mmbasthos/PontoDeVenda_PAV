namespace PontoDeVenda_PAV.Interface
{
    partial class TelaInserirCodigoProduto
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
            campoAddProduto = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // campoAddProduto
            // 
            campoAddProduto.Location = new Point(14, 16);
            campoAddProduto.Margin = new Padding(3, 4, 3, 4);
            campoAddProduto.Name = "campoAddProduto";
            campoAddProduto.Size = new Size(114, 27);
            campoAddProduto.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(135, 15);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(38, 31);
            button1.TabIndex = 1;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaInserirCodigoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 61);
            Controls.Add(button1);
            Controls.Add(campoAddProduto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaInserirCodigoProduto";
            Text = "TelaInserirCódigoProduto";
            Load += TelaInserirCodigoProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campoAddProduto;
        private Button button1;
    }
}