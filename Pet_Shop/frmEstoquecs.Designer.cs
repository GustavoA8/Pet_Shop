
namespace Pet_Shop
{
    partial class frmEstoquecs
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
            this.dgvListarEstoque = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarEstoque
            // 
            this.dgvListarEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEstoque.Location = new System.Drawing.Point(18, 87);
            this.dgvListarEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListarEstoque.Name = "dgvListarEstoque";
            this.dgvListarEstoque.Size = new System.Drawing.Size(431, 308);
            this.dgvListarEstoque.TabIndex = 0;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(106, 51);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(198, 26);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(20, 51);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(79, 18);
            this.lblPesquisar.TabIndex = 2;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(121, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(73, 19);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Estoque";
            // 
            // frmEstoquecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 415);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvListarEstoque);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEstoquecs";
            this.Text = "frmEstoquecs";
            this.Load += new System.EventHandler(this.frmEstoquecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarEstoque;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblTitulo;
    }
}