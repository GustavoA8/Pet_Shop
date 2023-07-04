using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Negocio;
using PetMarket;

namespace Pet_Shop
{
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Dados_Produto produto = new Dados_Produto();
            SalvarCompra salvarCompra = new SalvarCompra();
                produto.codigo = Convert.ToInt32(txtID.Text);
                produto.nome = txtProduto.Text;
                produto.registro = dtpRegistro.Value;
                produto.preco = txtPreco.Text;
                produto.quantidade = Convert.ToInt32(nmrQtde.Value);
                produto.validade = dtpValidade.Value;
                produto.fornecedor = txtFornecedor.Text;
            produto.total = Convert.ToInt32(produto.quantidade) * Convert.ToInt32(produto.preco);
            salvarCompra.InserirDados(produto);
            salvarCompra.CEstoque(produto);
            MessageBox.Show(produto.msg);
            CarregarGrid();
            LimparCampos();
            
        }
        private void LimparCampos()
        {
            txtProduto.Clear();
            txtProduto.Clear();
            txtPreco.Clear();
            nmrQtde.Value = 0;
            txtFornecedor.Clear();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ConsultarProduto consultarProduto = new ConsultarProduto();
            Dados_Produto produtos = new Dados_Produto();

            dgvListarProduto.DataSource = consultarProduto.ListarDados(produtos);
            ConfiguraDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dgvListarProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evitar o erro no clique dos títulos (linha -1)
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                txtID.Text = dgvListarProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProduto.Text = dgvListarProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
                
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            frmHistorico tela = new frmHistorico();
            tela.Show();
            

        }


    }
}
