
namespace Pet_Shop
{
    partial class frmCCliente
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
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvListaProduto = new System.Windows.Forms.DataGridView();
            this.btnVender = new System.Windows.Forms.Button();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(403, 303);
            this.cboProduto.Margin = new System.Windows.Forms.Padding(4);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(180, 26);
            this.cboProduto.TabIndex = 0;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(698, 303);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(148, 26);
            this.txtPreco.TabIndex = 1;
            // 
            // nudQtde
            // 
            this.nudQtde.Location = new System.Drawing.Point(1229, 303);
            this.nudQtde.Margin = new System.Windows.Forms.Padding(4);
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(93, 26);
            this.nudQtde.TabIndex = 3;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(400, 281);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(63, 18);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.Text = "Produto";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(698, 283);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 18);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(950, 283);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(70, 18);
            this.lblValidade.TabIndex = 6;
            this.lblValidade.Text = "Validade";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(1226, 281);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(42, 18);
            this.lblQtde.TabIndex = 7;
            this.lblQtde.Text = "Qtde";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(846, 183);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 32);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Venda";
            // 
            // dgvListaProduto
            // 
            this.dgvListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProduto.Location = new System.Drawing.Point(403, 384);
            this.dgvListaProduto.Name = "dgvListaProduto";
            this.dgvListaProduto.Size = new System.Drawing.Size(1079, 272);
            this.dgvListaProduto.TabIndex = 9;
            this.dgvListaProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProduto_CellClick);
            this.dgvListaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(1384, 303);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(87, 27);
            this.btnVender.TabIndex = 10;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(953, 303);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(145, 26);
            this.dtpValidade.TabIndex = 11;
            // 
            // frmCCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 665);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.dgvListaProduto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.nudQtde);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.cboProduto);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCCliente";
            this.Text = "frmCCliente";
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.NumericUpDown nudQtde;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvListaProduto;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.DateTimePicker dtpValidade;
    }
}