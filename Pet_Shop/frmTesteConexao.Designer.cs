
namespace Pet_Shop
{
    partial class frmTesteConexao
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
            this.lblTeste = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnTestar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(688, 299);
            this.lblTeste.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(460, 27);
            this.lblTeste.TabIndex = 0;
            this.lblTeste.Text = "Teste de Conexão com o Banco de Dados";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(867, 368);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(77, 27);
            this.lblMensagem.TabIndex = 1;
            this.lblMensagem.Text = "#####";
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(680, 490);
            this.btnTestar.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(176, 48);
            this.btnTestar.TabIndex = 2;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(980, 490);
            this.btnSair.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 48);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmTesteConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 676);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblTeste);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "frmTesteConexao";
            this.Text = "frmTesteConexao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Button btnSair;
    }
}