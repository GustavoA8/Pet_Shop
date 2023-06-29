using ConexaoBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class Dados_Login
    {
        public int codigo { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string msg { get; set; }
        public int logado { get; set; }
    }
    public class AcessoLogin
    {
        public void Acessar(Dados_Login dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT userLogin FROM tb_usuarios WHERE " +
                "user_login = @usuario AND user_senha = @senha";
                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem atribuídos na string sql
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.usuario));
                cmd.Parameters.Add(new MySqlParameter("@senha", dados.senha));
                //Realiza a leitura dos dados
                MySqlDataReader dr = cmd.ExecuteReader();
                //Se houver linhas, pode-se recuperar valores individuais
                if (dr.HasRows)
                {
                    //Atribui o valor 1 à variável logado para o usuário
                    dados.logado = 1;
                    while (dr.Read())
                    {
                        //Armazena o usuário na posição 0 da linha de registro
                        dados.usuario = dr.GetValue(0).ToString();
                        dados.msg = "Bem vindo " + dados.usuario;
                    }
                }
                else
                {
                    dados.msg = "Erro - Usuário ou Senha inválido!";
                    dados.logado = 0;
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.msg = "Erro - AcessoLogin - Acessar " +
                erro.Message;
            }

        }
    }
}
