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
    }
}
