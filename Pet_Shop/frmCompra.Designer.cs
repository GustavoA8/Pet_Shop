
namespace Pet_Shop
{
    partial class frmCompra
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Label();
            this.nmrQtde = new System.Windows.Forms.NumericUpDown();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.dtpRegistro = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.dgvListarProduto = new System.Windows.Forms.DataGridView();
            this.btnHistorico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(852, 221);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(682, 318);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 26);
            this.txtID.TabIndex = 2;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(860, 295);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 18);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(680, 353);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(89, 18);
            this.lblFornecedor.TabIndex = 5;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(679, 409);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(70, 18);
            this.lblValidade.TabIndex = 7;
            this.lblValidade.Text = "Validade";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(977, 295);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(42, 18);
            this.lblQtde.TabIndex = 8;
            this.lblQtde.Text = "Qtde";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(756, 297);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(63, 18);
            this.lblProduto.TabIndex = 9;
            this.lblProduto.Text = "Produto";
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Location = new System.Drawing.Point(792, 411);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(67, 18);
            this.Registro.TabIndex = 11;
            this.Registro.Text = "Registro";
            // 
            // nmrQtde
            // 
            this.nmrQtde.Location = new System.Drawing.Point(980, 316);
            this.nmrQtde.Name = "nmrQtde";
            this.nmrQtde.Size = new System.Drawing.Size(53, 26);
            this.nmrQtde.TabIndex = 12;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(680, 374);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(295, 26);
            this.txtFornecedor.TabIndex = 13;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(858, 317);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 26);
            this.txtPreco.TabIndex = 14;
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(758, 317);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(88, 26);
            this.txtProduto.TabIndex = 15;
            // 
            // dtpRegistro
            // 
            this.dtpRegistro.Enabled = false;
            this.dtpRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistro.Location = new System.Drawing.Point(795, 432);
            this.dtpRegistro.Name = "dtpRegistro";
            this.dtpRegistro.Size = new System.Drawing.Size(100, 26);
            this.dtpRegistro.TabIndex = 19;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(682, 474);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(680, 432);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(100, 26);
            this.dtpValidade.TabIndex = 21;
            // 
            // dgvListarProduto
            // 
            this.dgvListarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarProduto.Location = new System.Drawing.Point(680, 521);
            this.dgvListarProduto.Name = "dgvListarProduto";
            this.dgvListarProduto.Size = new System.Drawing.Size(497, 226);
            this.dgvListarProduto.TabIndex = 22;
            this.dgvListarProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarProduto_CellClick);
            this.dgvListarProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(795, 474);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(80, 28);
            this.btnHistorico.TabIndex = 23;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 691);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.dgvListarProduto);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpRegistro);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.nmrQtde);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.NumericUpDown nmrQtde;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.DateTimePicker dtpRegistro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.DataGridView dgvListarProduto;
        private System.Windows.Forms.Button btnHistorico;
    }
}