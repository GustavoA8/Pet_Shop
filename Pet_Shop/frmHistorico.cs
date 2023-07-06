using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using PetMarket;

namespace Pet_Shop
{
    public partial class frmHistorico : Form
    {
        public frmHistorico()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            dgvFornecedor.ReadOnly = true;
        }

        public void CarregarGrid()
        {
            ConsultarCompra consultarCompra = new ConsultarCompra();
            Dados_Produto produto = new Dados_Produto();

            dgvFornecedor.DataSource = consultarCompra.ListarCompra(produto);

            ConfigurarDataGridView();

        }
        public void ConfigurarDataGridView()
        {
            if (dgvFornecedor.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvFornecedor.Columns[0].HeaderText = "Código";
                dgvFornecedor.Columns[1].HeaderText = "Fornecedor";
                dgvFornecedor.Columns[2].HeaderText = "Validade";
                dgvFornecedor.Columns[3].HeaderText = "Quantidade";
                dgvFornecedor.Columns[4].HeaderText = "Preço";
                dgvFornecedor.Columns[5].HeaderText = "Registro";
                dgvFornecedor.Columns[6].HeaderText = "Id do Produto";
                //Configurar a largura das colunas no DataGridView
                dgvFornecedor.Columns[0].Width = 50;
                dgvFornecedor.Columns[1].Width = 150;
                //Alinhar o conteúdo das colunas
                dgvFornecedor.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Instância das classes AtualizarClientes e ClientesDTO
            AtualizarCompra atualizarCompra = new AtualizarCompra();
            Dados_Produto produto = new Dados_Produto();
            //Verificar se determinados campos foram preenchidos.
            //Repita esta estrutura de IF / ELSE IF para as informações obrigatórias.
            //Armazenar as informações do formulário
            produto.codigo = Convert.ToInt32(txtID.Text);
            produto.fornecedor = txtFornecedor.Text;
            produto.validade = dtpValidade.Value;
            produto.quantidade = Convert.ToInt32(nudQtde.Value);
            produto.preco = txtPreco.Text;
            produto.registro = dtpRegistro.Value;
            produto.produto =Convert.ToInt32( txtProduto.Text);
            produto.total = Convert.ToInt32(produto.quantidade) * Convert.ToInt32(produto.preco);


            atualizarCompra.AtualizarDados(produto);
            //Atualizar e configurar o DataGridView após atualização
           
            MessageBox.Show(produto.msg, "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarGrid();
            ConfigurarDataGridView();
            Limpar();
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                txtID.Text = dgvFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFornecedor.Text = dgvFornecedor.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpValidade.Text = dgvFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                nudQtde.Text = dgvFornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPreco.Text = dgvFornecedor.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtpRegistro.Text = dgvFornecedor.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtProduto.Text = dgvFornecedor.Rows[e.RowIndex].Cells[6].Value.ToString();

                btnEditar.Enabled = true;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarCompra deletarCompra = new DeletarCompra();
            Dados_Produto produto = new Dados_Produto();

            produto.codigo = Convert.ToInt32( txtID.Text);
            produto.produto = Convert.ToInt32(txtProduto.Text);
            produto.quantidade = Convert.ToInt32( nudQtde.Value);
            DialogResult confirmacao = MessageBox.Show("Deseja deletar o registro? Código " +
              txtID.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacao == DialogResult.Yes)
            {
                //Executar o método de exclusão
                deletarCompra.DCEstoque(produto);
                MessageBox.Show(produto.msg);
                deletarCompra.DeletarDados(produto);
                
                CarregarGrid();
                ConfigurarDataGridView();
                MessageBox.Show(produto.msg, "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            
        }
        private void Limpar()
        {
            txtID.Clear();
            txtFornecedor.Clear();
            txtPreco.Clear();
            txtProduto.Clear();
            nudQtde.Value = 0;
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }
}
