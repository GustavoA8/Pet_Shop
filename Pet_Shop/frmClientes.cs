using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace Pet_Shop
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();

        }
        public void Limpar()
        {
            txtNome.Clear();
            mtxCep.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtn.Clear();
            txtUF.Clear();
            mtxTelefone.Clear();
            txtComplemento.Clear();
            rdoF.Checked = false;
            rdoM.Checked = false;
            rdoB.Checked = false;
            txtOutros.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rdoB_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoB.Checked)
            {
                this.txtOutros.Visible = true;
            }
            else
            {
                this.txtOutros.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Dados_Cliente cliente = new Dados_Cliente();
            
            cliente.nome = txtNome.Text;
            cliente.cep = mtxCep.Text;
            cliente.email = txtEmail.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.n = Convert.ToInt32(txtn.Text);
            cliente.bairro = txtBairro.Text;
            cliente.cidade = txtCidade.Text;
            cliente.uf = txtUF.Text;
            cliente.telefone = mtxTelefone.Text;
            cliente.complemento = txtComplemento.Text;
            if (rdoM.Checked)
            {
                cliente.sexo = "Masculino";
            }
            if (rdoF.Checked)
            {
                cliente.sexo = "Feminino";
            }
            if (rdoB.Checked && txtOutros.Text != "")
            {
                cliente.sexo = txtOutros.Text;
            }
            cliente.LimparCEP();
            SalvarCliente salvarCliente = new SalvarCliente();
            salvarCliente.InserirDados(cliente);

            MessageBox.Show(cliente.nome + ": " + cliente.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Limpar();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void mtxCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;


        }

        private void mtxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se é letra(capiturando a tecla digitada)
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                //parar a execução do teclado
                e.Handled = true;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)))
                e.Handled = true;

        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)))
                e.Handled = true;
        }

        private void txtOutros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)))
                e.Handled = true;
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void mtxCep_Leave(object sender, EventArgs e)
        {
            //intanciar a classe Coreios
            /*CorreiosApi correio = new CorreiosApi();

            try
            {
               
                var retornoCep = correio.consultaCEP(mtxCep.Text.Replace("-", ""));
                if (retornoCep != null)
                {
                    txtEndereco.Text = retornoCep.end;
                    txtUF.Text = retornoCep.uf;
                    txtCidade.Text = retornoCep.cidade;
                    txtBairro.Text = retornoCep.bairro;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message.ToString(), "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }*/
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CorreiosApi correio = new CorreiosApi();

            try
            {

                var retornoCep = correio.consultaCEP(mtxCep.Text.Replace("-", ""));
                if (retornoCep != null)
                {
                    txtEndereco.Text = retornoCep.end;
                    txtUF.Text = retornoCep.uf;
                    txtCidade.Text = retornoCep.cidade;
                    txtBairro.Text = retornoCep.bairro;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString(), "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair da aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void grpCadastro_Enter(object sender, EventArgs e)
        {

        }
        public void CarregarGrid()
        {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            Dados_Cliente clientes = new Dados_Cliente();

            dgvListaClientes.DataSource = consultarCliente.ListarDados(clientes);
        }
        public void ConfiguraDataGridView()
        {
            //Verificar se o DataGridView contém linhas
            if (dgvListaClientes.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListaClientes.Columns[0].HeaderText = "Código";
                dgvListaClientes.Columns[1].HeaderText = "Nome";
                dgvListaClientes.Columns[2].HeaderText = "CEP";
                dgvListaClientes.Columns[3].HeaderText = "E-mail";
                dgvListaClientes.Columns[4].HeaderText = "Endereço";
                dgvListaClientes.Columns[5].HeaderText = "N°";
                dgvListaClientes.Columns[6].HeaderText = "Bairro";
                dgvListaClientes.Columns[7].HeaderText = "Cidade";
                dgvListaClientes.Columns[8].HeaderText = "UF";
                dgvListaClientes.Columns[9].HeaderText = "Telefone";
                dgvListaClientes.Columns[10].HeaderText = "Complemente";
                dgvListaClientes.Columns[11].HeaderText = "Sexo";




                //Configurar a largura das colunas no DataGridView
                dgvListaClientes.Columns[0].Width = 50;
                dgvListaClientes.Columns[1].Width = 150;
                dgvListaClientes.Columns[2].Width = 100;
                dgvListaClientes.Columns[3].Width = 175;
                dgvListaClientes.Columns[4].Width = 200;
                dgvListaClientes.Columns[5].Width = 50;
                dgvListaClientes.Columns[6].Width = 100;
                dgvListaClientes.Columns[7].Width = 50;
                dgvListaClientes.Columns[8].Width = 50;
                dgvListaClientes.Columns[9].Width = 150;
                dgvListaClientes.Columns[10].Width = 150;
                dgvListaClientes.Columns[11].Width = 50;
                //Alinhar o conteúdo das colunas
                dgvListaClientes.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            //Instância da classe ConsultarClientes
            //NomeClasse variavel = new NomeClasse();
            ConsultarCliente consultarCliente = new ConsultarCliente();
            //Instância da classe ClientesDTO
            Dados_Cliente clientes = new Dados_Cliente();
            //Amazenar o nome do TextBox
            clientes.nome = txtPesquisar.Text;
            //Chamada do método para a pesquisa e preenchimento do DataGridView
            dgvListaClientes.DataSource = consultarCliente.ListarDadosFiltro(clientes);
            //Configurar o DataGridView
            ConfiguraDataGridView();
        }

        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dados_Cliente cliente = new Dados_Cliente();
            //Evitar o erro no clique dos títulos (linha -1)
            if (e.RowIndex >= 0)
            {
                
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                txtCodigo.Text = dgvListaClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvListaClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                mtxCep.Text = dgvListaClientes.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtEmail.Text = dgvListaClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEndereco.Text = dgvListaClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtn.Text = dgvListaClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtBairro.Text = dgvListaClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCidade.Text = dgvListaClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtUF.Text = dgvListaClientes.Rows[e.RowIndex].Cells[7].Value.ToString();
                mtxTelefone.Text = dgvListaClientes.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtComplemento.Text = dgvListaClientes.Rows[e.RowIndex].Cells[9].Value.ToString();
                if (dgvListaClientes.Rows[e.RowIndex].Cells[10].Value.ToString() == "Feminino")
                {
                    rdoF.Checked = true;
                }
                if (dgvListaClientes.Rows[e.RowIndex].Cells[10].Value.ToString() == "Masculino")
                {
                    rdoM.Checked = true;
                }
                else
                {
                    rdoB.Checked = true;
                    txtOutros.Text = dgvListaClientes.Rows[e.RowIndex].Cells[10].Value.ToString();
                }
                btnEditar.Visible = true; //Ou enable
                btnSalvar.Enabled = false;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Instância das classes AtualizarClientes e ClientesDTO
            AtualizarDados atualizarDados = new AtualizarDados();
            Dados_Cliente clientes = new Dados_Cliente();
            //Verificar se determinados campos foram preenchidos.
            //Repita esta estrutura de IF / ELSE IF para as informações obrigatórias.
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                txtNome.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (txtn.Text == string.Empty)
            {
                MessageBox.Show("Campo Número obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtn.Focus();
                return;
            }
            //Armazenar as informações do formulário
            clientes.codigo = Convert.ToInt32(txtCodigo.Text);
            clientes.nome = txtNome.Text;
            clientes.cep = mtxCep.Text;
            clientes.email = txtEmail.Text;
            clientes.endereco = txtEndereco.Text;
            clientes.n = Convert.ToInt32(txtn.Text);
            clientes.bairro = txtBairro.Text;
            clientes.cidade = txtCidade.Text;
            clientes.uf = txtUF.Text;
            clientes.telefone = mtxTelefone.Text;
            clientes.complemento = txtComplemento.Text;
            if (rdoF.Checked == true)
            {
                clientes.sexo = "Feminino";
            }
            if(rdoM.Checked == true)
            {
                clientes.sexo = "Masculino";
            }
            else
            {
                clientes.sexo = txtOutros.Text;
            }
            //Utilização do método AtualizarDados com os dados do cliente como parâmetro
            atualizarDados.AtualizarCliente(clientes);
            //Atualizar e configurar o DataGridView após atualização
            CarregarGrid();
            ConfiguraDataGridView();
            MessageBox.Show(clientes.mensagem, "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
