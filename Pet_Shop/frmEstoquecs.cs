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
    public partial class frmEstoquecs : Form
    {
        public frmEstoquecs()
        {
            InitializeComponent();
        }

        private void frmEstoquecs_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ConsultarEstoque consultarEstoque = new ConsultarEstoque();
            Dados_Produto produto = new Dados_Produto();

            dgvListarEstoque.DataSource = consultarEstoque.ListarDadosProdutos(produto);
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            if (dgvListarEstoque.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListarEstoque.Columns[0].HeaderText = "Código";
                dgvListarEstoque.Columns[1].HeaderText = "Nome";
                dgvListarEstoque.Columns[2].HeaderText = "Quantidade";
                //Configurar a largura das colunas no DataGridView
                dgvListarEstoque.Columns[0].Width = 50;
                dgvListarEstoque.Columns[1].Width = 150;
                //Alinhar o conteúdo das colunas
                dgvListarEstoque.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            ConsultarEstoque consultarEstoque = new ConsultarEstoque();
            //Instância da classe ClientesDTO
            Dados_Produto produto = new Dados_Produto();
            //Amazenar o nome do TextBox
            produto.nome = txtPesquisar.Text;
            //Chamada do método para a pesquisa e preenchimento do DataGridView
            dgvListarEstoque.DataSource = consultarEstoque.ListarDadosProdutoFiltro(produto);
            //Configurar o DataGridView
            ConfigurarDataGridView();
        }
    }
}
