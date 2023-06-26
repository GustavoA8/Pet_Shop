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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes formfilho = new frmClientes();
            formfilho.MdiParent = this;
            formfilho.Show();
        }

        private void mnuAnimal_Click(object sender, EventArgs e)
        {
            frmAnimais formfilho = new frmAnimais();
            formfilho.MdiParent = this;
            formfilho.Show();
        }

        private void mnnuConexao_Click(object sender, EventArgs e)
        {
            frmTesteConexao formfilho = new frmTesteConexao();
            formfilho.MdiParent = this;
            formfilho.Show();
        }
        public void AbrirFormulario()
        {

        }
    }
}
