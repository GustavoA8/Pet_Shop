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
            SalvarEstoque salvarEstoque = new SalvarEstoque();
            if (txtNome.Text != null && cboTipo.Text != null && txtMarca.Text != null)
            {
                produto.nome = txtNome.Text;
                produto.tipo = cboTipo.Text;
                produto.marca = txtMarca.Text;
                produto.registro = dtpRegistro.Value;
                MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                salvarProduto.InserirDados(produto);
                salvarEstoque.BuscarCodigo(produto);
                salvarEstoque.InserirDados(produto);
                MessageBox.Show(produto.msg);
                
                LimparCampos();
                CarregarGrid();
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
            txtID.Clear();
            txtNome.Clear();
            txtMarca.Clear();
            cboTipo.SelectedIndex = -1;
        }

        private void frmCProdutos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ConsultarProduto consultarProduto = new ConsultarProduto();
            Dados_Produto produto = new Dados_Produto();

            dgvListarProduto.DataSource = consultarProduto.ListarDados(produto);

            ConfiguraDataGridView();
        }
        private void ConfiguraDataGridView()
        {
            if (dgvListarProduto.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListarProduto.Columns[0].HeaderText = "ID";
                dgvListarProduto.Columns[1].HeaderText = "Nome";
                dgvListarProduto.Columns[2].HeaderText = "Tipo";
                dgvListarProduto.Columns[3].HeaderText = "Marca";
                dgvListarProduto.Columns[4].HeaderText = "Registro";
                //Configurar a largura das colunas no DataGridView
                dgvListarProduto.Columns[0].Width = 50;
                dgvListarProduto.Columns[1].Width = 100;
                dgvListarProduto.Columns[2].Width = 100;
                dgvListarProduto.Columns[3].Width = 100;
                dgvListarProduto.Columns[4].Width = 100;
                //Alinhar o conteúdo das colunas
                dgvListarProduto.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void lblProdutos_Click(object sender, EventArgs e)
        {

        }

        private void dgvListarProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                txtID.Text = dgvListarProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvListarProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboTipo.SelectedItem = dgvListarProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMarca.Text = dgvListarProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpRegistro.Text = dgvListarProduto.Rows[e.RowIndex].Cells[4].Value.ToString();

                btnAtualizar.Visible = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarProduto atualizarProduto = new AtualizarProduto();
            Dados_Produto produto = new Dados_Produto();

            produto.codigo = Convert.ToInt32(txtID.Text);
            produto.nome = txtNome.Text;
            produto.tipo = cboTipo.Text;
            produto.marca = txtMarca.Text;
            produto.registro = dtpRegistro.Value;
            atualizarProduto.AtualizarDados(produto);
            CarregarGrid();
            ConfiguraDataGridView();
            MessageBox.Show(produto.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvListarProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair da aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
