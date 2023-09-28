namespace PontoDeVenda_PAV.Interface
{
    partial class TelaCadastroClassificacaoProduto
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
            campoTipoProduto = new TextBox();
            btnConcluido = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // campoTipoProduto
            // 
            campoTipoProduto.Location = new Point(12, 61);
            campoTipoProduto.Name = "campoTipoProduto";
            campoTipoProduto.PlaceholderText = "Digite o tipo do produto";
            campoTipoProduto.Size = new Size(518, 27);
            campoTipoProduto.TabIndex = 2;
            campoTipoProduto.TextChanged += campoTipoProduto_TextChanged;
            // 
            // btnConcluido
            // 
            btnConcluido.Location = new Point(436, 110);
            btnConcluido.Name = "btnConcluido";
            btnConcluido.Size = new Size(94, 29);
            btnConcluido.TabIndex = 4;
            btnConcluido.Text = "Concluido";
            btnConcluido.UseVisualStyleBackColor = true;
            btnConcluido.Click += btnConcluido_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(336, 110);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 31);
            label1.TabIndex = 6;
            label1.Text = "Cadastro Tipo de Produto";
            // 
            // TelaCadastroClassificacaoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 151);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnConcluido);
            Controls.Add(campoTipoProduto);
            Name = "TelaCadastroClassificacaoProduto";
            Text = "Cadastro Tipo de Produto (Interface Teste)";
            Load += TelaCadastroClassificacaoProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void campoTipoProduto_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion
        private TextBox campoTipoProduto;
        private Button btnConcluido;
        private Button btnCancelar;
        private Label label1;
    }
}