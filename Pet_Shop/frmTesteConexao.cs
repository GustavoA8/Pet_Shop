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

namespace Pet_Shop
{
    public partial class frmTesteConexao : Form
    {
        public frmTesteConexao()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            Dados_TesteConcexao teste = new Dados_TesteConcexao();
            teste.Verificar();

            if(teste.conectar == null)
            {
                lblMensagem.BackColor = Color.Red;
                lblMensagem.Text = "Falha!";
                MessageBox.Show(teste.mensagem, "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                lblMensagem.BackColor = Color.Blue;
                lblMensagem.Text = "Sucesso!";

            }
        }
    }
}
