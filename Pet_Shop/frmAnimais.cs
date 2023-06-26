using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class frmAnimais : Form
    {
        public frmAnimais()
        {
            InitializeComponent();
        }

        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {
            Dados_Animal animal = new Dados_Animal();
            animal.Idade = DateTime.Now.Year - dtpNascimento.Value.Year;
            if (DateTime.Now.DayOfYear < dtpNascimento.Value.DayOfYear)
            {
                animal.Idade = animal.Idade - 1;
            }
            txtIdade.Text = animal.Idade.ToString();
            txtIdade.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*Dados_Animal animal = new Dados_Animal();
            animal.NomePet = txtNomePet.Text;
            animal.CodigoDono = txtCodigo.Text;
            animal.Funcionario = txtFuncionario.Text;
            animal.Raca = txtRaca.Text;
            animal.Cor = txtCor.Text;
            animal.Tipo = txtTipo.Text;
            animal.Peso = Convert.ToDecimal(txtPeso.Text);
            animal.Nascimento = dtpNascimento.Value;
            if (rdoSim.Checked == true)
            {
                animal.Pedigree = rdoSim.Text;
            }
            else
            {
                animal.Pedigree = rdoNao.Text;
            }
            Limpar();
            animal.Rga = Convert.ToInt32(txtRga.Text);
            animal.Sexo = cboSexo.Text;
            animal.Observacao = txtObservacao.Text;

            MessageBox.Show("Cadatrado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            //Instância da classe SalvarAnimais

            SalvarAnimais salvarAnimais = new SalvarAnimais();
            Dados_Animal animais = new Dados_Animal();
            //Acesso às variáveis por meio do objeto animais.
            //animais.codigoPet = Convert.ToInt32(txtCodigoPet.Text);
            animais.CodigoDono =Convert.ToInt32(txtCodigoDono.Text);
            animais.NomePet = txtNomePet.Text;
            animais.Funcionario = txtFuncionario.Text;
            animais.Nascimento = dtpNascimento.Value;
            //Teste de funcionamento
            //Chamada do método InserirDados por meio do objeto salvarAnimais
            salvarAnimais.InserirDados(animais);
            //Exibir a mensagem de Sucesso ou Falha
            MessageBox.Show(animais.mensagem, "Aviso", MessageBoxButtons.OK);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();

        }
        private void Limpar()
        {
            txtNomePet.Clear();
            txtCodigoDono.Clear();
            txtFuncionario.Clear();
            txtRaca.Clear();
            txtCor.Clear();
            txtTipo.Clear();
            txtPeso.Clear();
            dtpNascimento.Value = DateTime.Now;
            txtIdade.Clear();
            rdoNao.Checked = false;
            rdoSim.Checked = false;
            txtRga.Clear();
            cboSexo.SelectedItem = null;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair da aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void frmAnimais_Load(object sender, EventArgs e)
        {

        }
    }
}
