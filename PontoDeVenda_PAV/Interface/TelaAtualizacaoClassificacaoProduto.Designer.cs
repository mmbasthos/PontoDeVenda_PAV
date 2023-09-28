namespace PontoDeVenda_PAV.Interface
{
    partial class TelaAtualizacaoClassificacaoProduto
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
            campoAtualizrTipo = new TextBox();
            Atualizar = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // campoAtualizrTipo
            // 
            campoAtualizrTipo.Location = new Point(12, 55);
            campoAtualizrTipo.Multiline = true;
            campoAtualizrTipo.Name = "campoAtualizrTipo";
            campoAtualizrTipo.PlaceholderText = "Digite o novo dado";
            campoAtualizrTipo.Size = new Size(469, 27);
            campoAtualizrTipo.TabIndex = 1;
            campoAtualizrTipo.TextChanged += campoAtualizrTipo_TextChanged;
            // 
            // Atualizar
            // 
            Atualizar.Location = new Point(387, 98);
            Atualizar.Name = "Atualizar";
            Atualizar.Size = new Size(94, 29);
            Atualizar.TabIndex = 2;
            Atualizar.Text = "Atualizar";
            Atualizar.UseVisualStyleBackColor = true;
            Atualizar.Click += Atualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 31);
            label1.TabIndex = 7;
            label1.Text = "Atualização Tipo de Produto";
            // 
            // button1
            // 
            button1.Location = new Point(288, 98);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaAtualizacaoClassificacaoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 139);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Atualizar);
            Controls.Add(campoAtualizrTipo);
            Name = "TelaAtualizacaoClassificacaoProduto";
            Text = "TelaAtualizacaoClassificacaoProduto";
            Load += TelaAtualizacaoClassificacaoProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox campoAtualizrTipo;
        private Button Atualizar;
        private Label label1;
        private Button button1;
    }
}