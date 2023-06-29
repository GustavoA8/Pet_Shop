
namespace Pet_Shop
{
    partial class frmCProdutos
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
            this.txtID = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dtpRegistro = new System.Windows.Forms.DateTimePicker();
            this.dgvListarProduto = new System.Windows.Forms.DataGridView();
            this.lblProdutos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(63, 80);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(23, 18);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(60, 147);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 18);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(60, 114);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(63, 220);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(67, 18);
            this.lblRegistro.TabIndex = 5;
            this.lblRegistro.Text = "Registro";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(63, 183);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 18);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(142, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 26);
            this.textBox1.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 26);
            this.txtNome.TabIndex = 9;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(142, 180);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(136, 26);
            this.txtMarca.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(23, 295);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 32);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(152, 295);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(270, 295);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 32);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Acessório",
            "Alimento",
            "Remédio"});
            this.cboTipo.Location = new System.Drawing.Point(142, 147);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(136, 26);
            this.cboTipo.TabIndex = 18;
            // 
            // dtpRegistro
            // 
            this.dtpRegistro.Enabled = false;
            this.dtpRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistro.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpRegistro.Location = new System.Drawing.Point(142, 214);
            this.dtpRegistro.Name = "dtpRegistro";
            this.dtpRegistro.Size = new System.Drawing.Size(103, 26);
            this.dtpRegistro.TabIndex = 19;
            // 
            // dgvListarProduto
            // 
            this.dgvListarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarProduto.Location = new System.Drawing.Point(385, 77);
            this.dgvListarProduto.Name = "dgvListarProduto";
            this.dgvListarProduto.Size = new System.Drawing.Size(458, 250);
            this.dgvListarProduto.TabIndex = 20;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(491, 15);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(257, 29);
            this.lblProdutos.TabIndex = 21;
            this.lblProdutos.Text = "Produtos Cadastrado";
            // 
            // frmCProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 353);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.dgvListarProduto);
            this.Controls.Add(this.dtpRegistro);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtID);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCProdutos";
            this.Text = "frmCProdutos";
            this.Load += new System.EventHandler(this.frmCProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DateTimePicker dtpRegistro;
        private System.Windows.Forms.DataGridView dgvListarProduto;
        private System.Windows.Forms.Label lblProdutos;
    }
}