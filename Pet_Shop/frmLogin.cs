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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Instância das Classes
            dados = new LoginDTO();
            AcessoLogin acessoLogin = new AcessoLogin();
            //Armazenar Login e Senha do formulário
            login.usuario = txtUsuario.Text;
            login.senha = txtSenha.Text;
            //Execução do método Acessar
            acessoLogin.Acessar(login);
            //Verificar se o status é Logado = 1
            if (login.logado == 1)
            {
                MessageBox.Show(login.mensagem, "Aviso");
                //Fechar Formulário de Login se usuário e senha estiverem corretos
                Close();
            }
            else
            {
                MessageBox.Show(login.mensagem, "Aviso");
                textusuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }
    }
}
