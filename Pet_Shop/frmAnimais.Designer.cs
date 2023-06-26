
namespace Pet_Shop
{
    partial class frmAnimais
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
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObsevacao = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblRga = new System.Windows.Forms.Label();
            this.txtRga = new System.Windows.Forms.TextBox();
            this.lblPedigree = new System.Windows.Forms.Label();
            this.rdoNao = new System.Windows.Forms.RadioButton();
            this.rdoSim = new System.Windows.Forms.RadioButton();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lblCodigoDono = new System.Windows.Forms.Label();
            this.txtCodigoDono = new System.Windows.Forms.TextBox();
            this.lblNomePet = new System.Windows.Forms.Label();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.lblCodigoPet = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.lblIdade);
            this.grpDados.Controls.Add(this.txtIdade);
            this.grpDados.Controls.Add(this.txtObservacao);
            this.grpDados.Controls.Add(this.lblObsevacao);
            this.grpDados.Controls.Add(this.cboSexo);
            this.grpDados.Controls.Add(this.lblSexo);
            this.grpDados.Controls.Add(this.lblRga);
            this.grpDados.Controls.Add(this.txtRga);
            this.grpDados.Controls.Add(this.lblPedigree);
            this.grpDados.Controls.Add(this.rdoNao);
            this.grpDados.Controls.Add(this.rdoSim);
            this.grpDados.Controls.Add(this.lblNascimento);
            this.grpDados.Controls.Add(this.dtpNascimento);
            this.grpDados.Controls.Add(this.lblPeso);
            this.grpDados.Controls.Add(this.txtPeso);
            this.grpDados.Controls.Add(this.lblTipo);
            this.grpDados.Controls.Add(this.txtTipo);
            this.grpDados.Controls.Add(this.lblCor);
            this.grpDados.Controls.Add(this.txtCor);
            this.grpDados.Controls.Add(this.lblRaca);
            this.grpDados.Controls.Add(this.txtRaca);
            this.grpDados.Controls.Add(this.lblFuncionario);
            this.grpDados.Controls.Add(this.txtFuncionario);
            this.grpDados.Controls.Add(this.lblCodigoDono);
            this.grpDados.Controls.Add(this.txtCodigoDono);
            this.grpDados.Controls.Add(this.lblNomePet);
            this.grpDados.Controls.Add(this.txtNomePet);
            this.grpDados.Controls.Add(this.lblCodigoPet);
            this.grpDados.Controls.Add(this.txtCodigo);
            this.grpDados.Location = new System.Drawing.Point(81, 71);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(867, 415);
            this.grpDados.TabIndex = 3;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados do Animal";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(208, 188);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 30;
            this.lblIdade.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(211, 209);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(106, 20);
            this.txtIdade.TabIndex = 29;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(52, 269);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(760, 107);
            this.txtObservacao.TabIndex = 28;
            // 
            // lblObsevacao
            // 
            this.lblObsevacao.AutoSize = true;
            this.lblObsevacao.Location = new System.Drawing.Point(49, 248);
            this.lblObsevacao.Name = "lblObsevacao";
            this.lblObsevacao.Size = new System.Drawing.Size(68, 13);
            this.lblObsevacao.TabIndex = 27;
            this.lblObsevacao.Text = "Observação:";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(691, 212);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(121, 21);
            this.cboSexo.TabIndex = 25;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(688, 191);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 24;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblRga
            // 
            this.lblRga.AutoSize = true;
            this.lblRga.Location = new System.Drawing.Point(491, 191);
            this.lblRga.Name = "lblRga";
            this.lblRga.Size = new System.Drawing.Size(33, 13);
            this.lblRga.TabIndex = 22;
            this.lblRga.Text = "RGA:";
            // 
            // txtRga
            // 
            this.txtRga.Location = new System.Drawing.Point(494, 212);
            this.txtRga.Name = "txtRga";
            this.txtRga.Size = new System.Drawing.Size(147, 20);
            this.txtRga.TabIndex = 21;
            // 
            // lblPedigree
            // 
            this.lblPedigree.AutoSize = true;
            this.lblPedigree.Location = new System.Drawing.Point(343, 195);
            this.lblPedigree.Name = "lblPedigree";
            this.lblPedigree.Size = new System.Drawing.Size(52, 13);
            this.lblPedigree.TabIndex = 20;
            this.lblPedigree.Text = "Pedigree:";
            // 
            // rdoNao
            // 
            this.rdoNao.AutoSize = true;
            this.rdoNao.Location = new System.Drawing.Point(416, 216);
            this.rdoNao.Name = "rdoNao";
            this.rdoNao.Size = new System.Drawing.Size(45, 17);
            this.rdoNao.TabIndex = 19;
            this.rdoNao.TabStop = true;
            this.rdoNao.Text = "Não";
            this.rdoNao.UseVisualStyleBackColor = true;
            // 
            // rdoSim
            // 
            this.rdoSim.AutoSize = true;
            this.rdoSim.Location = new System.Drawing.Point(343, 216);
            this.rdoSim.Name = "rdoSim";
            this.rdoSim.Size = new System.Drawing.Size(42, 17);
            this.rdoSim.TabIndex = 18;
            this.rdoSim.TabStop = true;
            this.rdoSim.Text = "Sim";
            this.rdoSim.UseVisualStyleBackColor = true;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(49, 188);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(66, 13);
            this.lblNascimento.TabIndex = 17;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(52, 209);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(122, 20);
            this.dtpNascimento.TabIndex = 16;
            this.dtpNascimento.ValueChanged += new System.EventHandler(this.dtpNascimento_ValueChanged);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(662, 121);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 15;
            this.lblPeso.Text = "Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(665, 142);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(147, 20);
            this.txtPeso.TabIndex = 14;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(453, 121);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(456, 142);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(147, 20);
            this.txtTipo.TabIndex = 12;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(254, 121);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 13);
            this.lblCor.TabIndex = 11;
            this.lblCor.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(257, 142);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(147, 20);
            this.txtCor.TabIndex = 10;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(49, 121);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(36, 13);
            this.lblRaca.TabIndex = 9;
            this.lblRaca.Text = "Raça:";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(52, 142);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(157, 20);
            this.txtRaca.TabIndex = 8;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(662, 56);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 7;
            this.lblFuncionario.Text = "Funcionário:";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(665, 77);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(147, 20);
            this.txtFuncionario.TabIndex = 6;
            // 
            // lblCodigoDono
            // 
            this.lblCodigoDono.AutoSize = true;
            this.lblCodigoDono.Location = new System.Drawing.Point(453, 56);
            this.lblCodigoDono.Name = "lblCodigoDono";
            this.lblCodigoDono.Size = new System.Drawing.Size(87, 13);
            this.lblCodigoDono.TabIndex = 5;
            this.lblCodigoDono.Text = "Código do Dono:";
            // 
            // txtCodigoDono
            // 
            this.txtCodigoDono.Location = new System.Drawing.Point(456, 77);
            this.txtCodigoDono.Name = "txtCodigoDono";
            this.txtCodigoDono.Size = new System.Drawing.Size(147, 20);
            this.txtCodigoDono.TabIndex = 4;
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.Location = new System.Drawing.Point(254, 56);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(72, 13);
            this.lblNomePet.TabIndex = 3;
            this.lblNomePet.Text = "Nome do Pet:";
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(257, 77);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(147, 20);
            this.txtNomePet.TabIndex = 2;
            // 
            // lblCodigoPet
            // 
            this.lblCodigoPet.AutoSize = true;
            this.lblCodigoPet.Location = new System.Drawing.Point(49, 56);
            this.lblCodigoPet.Name = "lblCodigoPet";
            this.lblCodigoPet.Size = new System.Drawing.Size(77, 13);
            this.lblCodigoPet.TabIndex = 1;
            this.lblCodigoPet.Text = "Código do Pet:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(52, 77);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(157, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(121, 505);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(390, 504);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(646, 522);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 557);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpDados);
            this.Name = "frmAnimais";
            this.Text = "frmAnimais";
            this.Load += new System.EventHandler(this.frmAnimais_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObsevacao;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblRga;
        private System.Windows.Forms.TextBox txtRga;
        private System.Windows.Forms.Label lblPedigree;
        private System.Windows.Forms.RadioButton rdoNao;
        private System.Windows.Forms.RadioButton rdoSim;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label lblCodigoDono;
        private System.Windows.Forms.TextBox txtCodigoDono;
        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.Label lblCodigoPet;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}