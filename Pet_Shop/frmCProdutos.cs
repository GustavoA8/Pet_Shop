using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetMarket;

namespace Pet_Shop
{
    public partial class frmCProdutos : Form
    {
        public frmCProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Dados_Produto produto = new Dados_Produto();
            SalvarProduto salvarProduto = new SalvarProduto();
            if (txtNome.Text != null && cboTipo.Text != null && txtMarca.Text != null)
            {
                produto.nome = txtNome.Text;
                produto.tipo = cboTipo.Text;
                produto.marca = txtMarca.Text;
                produto.registro = dtpRegistro.Value;
                MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                salvarProduto.InserirDados(produto);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Preencha todos os espaços do cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtMarca.Clear();
            cboTipo.SelectedIndex = -1;
        }
    }
}
