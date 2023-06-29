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
using Microsoft.VisualBasic;

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
            if (dtpNascimento.Value < DateTime.Now) //Verifica se o nascimento é menor a data atual
            {
                int resultado = CalcularIdade(dtpNascimento.Value); //Realiza o Cálculo
                txtIdade.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Data inválida", "Aviso");
            }
        }
        //DIGITAR ESTE PROCEDIMENTO
        public int CalcularIdade(DateTime dataNascimento)
        {
            //Realiza a subtração entre o ano atual e o ano de nascimento
            int idade = DateTime.Now.Year - dataNascimento.Year;
            //Verifica se o dia do ano atual é menor que o de nascimento
            //Assim, verificamos se já ocorreu o aniversário
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade -= 1; //Equivalente a idade = idade - 1
            }
            return idade;
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
            animais.CodigoDono = cboCodigoDono.Text;
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
            cboCodigoDono.SelectedIndex = -1;
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
            CarregarGrid();
            ConfiguraDataGridView();

            ListarCodigoDono();
            cboCodigoDono.SelectedIndex = -1;
        }
        public void CarregarGrid()
        {
            ConsultarAnimais consultarAnimais = new ConsultarAnimais();
            Dados_Animal animais = new Dados_Animal();

            dgvListaAnimais.DataSource = consultarAnimais.ListarDadosAnimais(animais);

            if (!string.IsNullOrEmpty(animais.mensagem))
            {
                MessageBox.Show(animais.mensagem);
            }
        }
        public void ConfiguraDataGridView()
        {
            if (dgvListaAnimais.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListaAnimais.Columns[0].HeaderText = "Código";
                dgvListaAnimais.Columns[1].HeaderText = "Pet";
                dgvListaAnimais.Columns[2].HeaderText = "Código Dono";
                dgvListaAnimais.Columns[3].HeaderText = "Funcionário";
                //Configurar a largura das colunas no DataGridView
                dgvListaAnimais.Columns[0].Width = 50;
                dgvListaAnimais.Columns[1].Width = 150;
                dgvListaAnimais.Columns[2].Width = 50;
                dgvListaAnimais.Columns[3].Width = 150;
                //Alinhar o conteúdo das colunas
                dgvListaAnimais.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
                dgvListaAnimais.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            txtPesquisaDono.Text = "";
            //Instância das classes
            ConsultarAnimais consultarAnimais = new ConsultarAnimais();
            Dados_Animal animais = new Dados_Animal();
            //Atribuição do nome digitação no TextBox à variável
            animais.NomePet = txtPesquisa.Text;
            //Atribuição do retorno como tabela ao DataGridView
            dgvListaAnimais.DataSource = consultarAnimais.ListarDadosAnimaisPet(animais);
            //Verificar se houve erro na estrutura da tabela
            if (!string.IsNullOrEmpty(animais.mensagem))
            {
                MessageBox.Show(animais.mensagem);
            }
            //Formatação do Grid
            ConfiguraDataGridView();
        }

        private void txtPesquisaDono_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                //Instância das classes
                ConsultarAnimais consultarAnimais = new ConsultarAnimais();
                Dados_Animal animais = new Dados_Animal();
                //Atribuição do nome digitação no TextBox à variável
                animais.CodigoDono = txtPesquisaDono.Text;
                //Atribuição do retorno como tabela ao DataGridView
                dgvListaAnimais.DataSource = consultarAnimais.ListarDadosAnimaisDono(animais);
                //Verificar se houve erro na estrutura da tabela
                if (!string.IsNullOrEmpty(animais.mensagem))
                {
                    MessageBox.Show(animais.mensagem);
                }
                //Formatação do Grid
                ConfiguraDataGridView();
            }
            else
            {
                CarregarGrid();
            }
        }

        private void txtCodigoDono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListaAnimais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].ParaTexto
                txtCodigo.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNomePet.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboCodigoDono.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtFuncionario.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[3].Value.ToString();
                //Habilitar os botões de Editar e Excluir
                cboCodigoDono.Enabled = false;
                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;
                //Desabilitar o campo Código do Dono.
                //A constraint não permite atualizar esta informação.
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Instanciar as classes
            AtualizarAnimais atualizarAnimais = new AtualizarAnimais();
            Dados_Animal animais = new Dados_Animal();
            //Alimentar as variáveis
            animais.CodigoPet  = Convert.ToInt32(txtCodigo.Text);
            animais.NomePet = txtNomePet.Text;
            animais.Funcionario = txtFuncionario.Text;
            //Execução do método
            atualizarAnimais.AtualizarDados(animais);
            //Reestruturar o grid após atualização
            CarregarGrid();
            ConfiguraDataGridView();
            MessageBox.Show(animais.mensagem, "Aviso", MessageBoxButtons.OK);

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //Variáveis para construção da Caixa de Mensagem
            string senha, mensagem, titulo, padrao;
            object valor;
            senha = "123";
            mensagem = "Informe a senha:";
            titulo = "Deletar registro.";
            padrao = ""; //Aplicado no caso do inputbox vazio
                         //Construção da caixa de mensagem
            valor = Interaction.InputBox(mensagem, titulo, padrao);
            //Verificação da senha
            if (valor.ToString() == "")
            {
            }
            else if (valor.ToString() != senha)
            {
                Interaction.MsgBox("ERRO - Senha Inválida!");
            }
            else
            {
                //Agrupar um conjunto de códigos de forma personalizada 
                #region excluir
                //Instânciar das classes
                DeletarAnimais deletarAnimais = new DeletarAnimais();
                Dados_Animal animais = new Dados_Animal();
                //Armazenar o código para exclusão
                animais.CodigoPet = Convert.ToInt32(txtCodigo.Text);
                //Variável deletar que receberá a escolha do usuário: Yes ou No.
                DialogResult confirmacao = MessageBox.Show(
                "Deseja deletar o registro? Código " + txtCodigo.Text,
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Verificar se a escolha é Yes.
                if (confirmacao == DialogResult.Yes)
                {
                    //Execução do método de esclusão
                    deletarAnimais.DeletarDados(animais);
                    //Atualização do Grid e Campos de digitação
                    CarregarGrid();
                    ConfiguraDataGridView();
                    Limpar();

                    MessageBox.Show(animais.mensagem, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion
            }
        }
        public void ListarCodigoDono()
        {
            //Instância das Classes
            ConsultarAnimais consultarAnimais = new ConsultarAnimais();
            Dados_Animal animais = new Dados_Animal();
            //Alimenta o ComboBox com a coluna Código tabela
            cboCodigoDono.DataSource = consultarAnimais.ListarCodigoDono(animais);
            //Define qual valor da tabela será utilizado.
            cboCodigoDono.ValueMember = "id_cliente";
            //Define qual valor da tabela será mostrado no formulário.
            cboCodigoDono.DisplayMember = "id_cliente";
        }

    }
}
