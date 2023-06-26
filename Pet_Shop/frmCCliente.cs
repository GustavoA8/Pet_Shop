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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CarregarGrid()
        {
            ConsultarProduto consultarProduto = new ConsultarProduto();
            Dados_Produto produto = new Dados_Produto();

            dgvListaProduto.DataSource = consultarProduto.ListarDados(produto);
        }

        private void dgvListaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCCliente_Load(object sender, EventArgs e)
        {
            Dados_Cliente dados = new Dados_Cliente();
            CarregarCBO(dados);
            cboProduto.SelectedIndex = -1;
            MessageBox.Show(dados.codigo.ToString());
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

                MessageBox.Show ("ERRO - CarregarCBO - AlimentarCBO -" + erro.ErrorCode + erro.Message);
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Dados_Produto produto = new Dados_Produto();
            SalvarVenda salvarVenda = new SalvarVenda();

            produto.preco = txtPreco.Text;
            produto.validade = dtpValidade.Value;
            produto.codigo = Convert.ToInt32(cboProduto.SelectedValue);
            produto.quantidade = Convert.ToInt32( nudQtde.Value);
           //MessageBox.Show(produto.codigo);
            salvarVenda.inserirDados(produto);
            MessageBox.Show(produto.msg, "Aviso", MessageBoxButtons.OK);
        }
    }
}
