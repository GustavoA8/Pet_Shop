using ConexaoBD;
using MySql.Data.MySqlClient;
using Negocio;
using PetMarket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class frmCCliente : Form
    {
        public frmCCliente()
        {
            InitializeComponent();
            lblPreco.BackColor = Color.Transparent;
            lblProduto.BackColor = Color.Transparent;
            lblQtde.BackColor = Color.Transparent;
            lblValidade.BackColor = Color.Transparent;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CarregarGrid()
        {
            ConsultarVenda consultarVenda = new ConsultarVenda();
            Dados_Produto produto = new Dados_Produto();

            dgvListaProduto.DataSource = consultarVenda.ListarVenda(produto);
            ConfigurarDataGridView();
           //MessageBox.Show(produto.msg);
        }

        private void ConfigurarDataGridView()
        {
            if (dgvListaProduto.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListaProduto.Columns[0].HeaderText = "ID";
                dgvListaProduto.Columns[1].HeaderText = "ID do produto";
                dgvListaProduto.Columns[2].HeaderText = "Preço";
                dgvListaProduto.Columns[3].HeaderText = "Validade";
                dgvListaProduto.Columns[4].HeaderText = "Quantidade";
                //Configurar a largura das colunas no DataGridView
                dgvListaProduto.Columns[0].Width = 50;
                dgvListaProduto.Columns[1].Width = 150;
                //Alinhar o conteúdo das colunas
                dgvListaProduto.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvListaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                cboProduto.SelectedValue = dgvListaProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPreco.Text = dgvListaProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpValidade.Text = dgvListaProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
                nudQtde.Value = Convert.ToInt32(dgvListaProduto.Rows[e.RowIndex].Cells[4].Value.ToString());
                
                btnAtualizar.Enabled = true;




            }
        }
        private void CarregarCBO(Dados_Cliente dados)
        {
            try
            {

                string sql = "SELECT id_pdt, pdt_nome FROM tb_produto ";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                MySqlDataReader leitorCat = cmd.ExecuteReader();
                DataTable tabelaCat = new DataTable();
                tabelaCat.Load(leitorCat);
                DataRow linha = tabelaCat.NewRow();
                cboProduto.DataSource = tabelaCat;
                cboProduto.ValueMember = "id_pdt";
                cboProduto.DisplayMember = "pdt_nome";


            }
            catch (MySqlException erro)
            {

                MessageBox.Show("ERRO - CarregarCBO - AlimentarCBO -" + erro.ErrorCode + erro.Message);
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarVenda atualizarVenda = new AtualizarVenda();
            Dados_Produto produto = new Dados_Produto();

            produto.quantidade = Convert.ToInt32(nudQtde.Value);
            produto.preco = txtPreco.Text;
            produto.validade = dtpValidade.Value;
            produto.total = Convert.ToInt32(produto.quantidade) * Convert.ToInt32(produto.preco);

            atualizarVenda.AtualizarDados(produto);

            CarregarGrid();
            ConfigurarDataGridView();
            MessageBox.Show(produto.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmCCliente_Load_1(object sender, EventArgs e)
        {
            Dados_Cliente dados = new Dados_Cliente();
            CarregarCBO(dados);
            cboProduto.SelectedIndex = -1;
            CarregarGrid();
        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {
            Dados_Produto produto = new Dados_Produto();
            SalvarVenda salvarVenda = new SalvarVenda();
            produto.quantidade = Convert.ToInt32(nudQtde.Value);
            produto.codigo = Convert.ToInt32(cboProduto.SelectedValue);

            salvarVenda.VerificarQtde(produto);


            if (produto.situacao == true)
            {
                produto.registro = DateTime.Now.Date;
                produto.preco = txtPreco.Text;
                produto.validade = dtpValidade.Value;
                produto.total = Convert.ToInt32(produto.quantidade) * Convert.ToInt32(produto.preco);
                //MessageBox.Show(produto.codigo);
                salvarVenda.inserirDados(produto);
                salvarVenda.VEstoque(produto);
                MessageBox.Show(produto.msg, "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Estoque do produto insuficiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            CarregarGrid();
        }
       
    }
}

