﻿using ConexaoBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Dados_Cliente
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string cep { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public int n { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string telefone { get; set; }
        public string complemento { get; set; }
        public string sexo { get; set; }
        public string outros { get; set; }
        public string mensagem { get; set; }


        public string LimparCEP()
        {
            this.cep = this.cep.Replace("-", "");
            return this.cep;
        }
        public string LimparTelefone()
        {
            this.telefone = this.telefone.Replace("(", "").Replace(")", "").Replace("-", "");
            return this.telefone;
        }
    }
    public class SalvarCliente
    {
        public void InserirDados(Dados_Cliente dados)
        {
            try
            {
                //String com o comando Insert do Banco
                string sql = "INSERT INTO tb_cliente (cliente_nome," +
                "cliente_cep, cliente_email, cliente_endereco, cliente_n, cliente_bairro, cliente_cidade, cliente_uf, cliente_telefone, cliente_complemento, cliente_sexo) " +
                "VALUES (@Nome, @Cep, @Email, @Endereco, @N, @Bairro, @Cidade, @Uf, @Telefone, @Complemento, @Sexo)";
                //Variável que receberá o resultado da Conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substiruídos
                cmd.Parameters.Add(new MySqlParameter("@Nome", dados.nome));
                cmd.Parameters.Add(new MySqlParameter("@Cep", dados.cep));
                cmd.Parameters.Add(new MySqlParameter("@Email", dados.email));
                cmd.Parameters.Add(new MySqlParameter("@Endereco", dados.endereco));
                cmd.Parameters.Add(new MySqlParameter("@N", dados.n));
                cmd.Parameters.Add(new MySqlParameter("@Bairro", dados.bairro));
                cmd.Parameters.Add(new MySqlParameter("@Cidade", dados.cidade));
                cmd.Parameters.Add(new MySqlParameter("@Uf", dados.uf));
                cmd.Parameters.Add(new MySqlParameter("@Telefone", dados.telefone));
                cmd.Parameters.Add(new MySqlParameter("@Complemento", dados.complemento));
                cmd.Parameters.Add(new MySqlParameter("@Sexo", dados.sexo));
                int registrosInseridos = cmd.ExecuteNonQuery();
                if (registrosInseridos >= 1)
                {
                    dados.mensagem = "Registro inserido com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao inserir o registro!";
                }
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "ERRO - SalvarClients - InserirDados -" + erro.ErrorCode + erro.Message;



            }
        }
    }
    public class ConsultarCliente
    {
        public DataTable ListarDados(Dados_Cliente dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT * FROM tb_cliente";
                //Comando para o SELECT e a Conexão - MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Adaptar os dados do BD para o formato de tabela
                //com a execução da Conexão e SELECT
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechar a conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarClientes - ListarDadosClientes " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
        public DataTable ListarDadosFiltro(Dados_Cliente dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT * From tb_cliente WHERE cliente_nome LIKE @nome";
                //Comando para o SELECT e a Conexão - MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                cmd.Parameters.Add(new MySqlParameter("@nome", "%" + dados.nome + "%"));
                //Adaptar os dados do BD para o formato de tabela
                //com a execução da Conexão e SELECT
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechar a conexão
                Conexao.fecharConexao();
            }
            catch (Exception erro)
            {
                dados.mensagem = "Erro - ConsultarClientes - ListarDadosClientesFiltro " +
                erro.Message.ToString();
            }
            return tabela;
        }
       
    }
    public class AtualizarDados
    {
        public void AtualizarCliente(Dados_Cliente dados)
        {
            try
            {
                string sql = "UPDATE tb_cliente SET cliente_nome=@Nome, " +
               "cliente_cep=@Cep, cliente_email=@Email, cliente_endereco=@Endereco, cliente_n=@N, cliente_bairro=@Bairro, cliente_cidade=@Cidade, cliente_Uf=@Uf, cliente_telefone=@Telefone, cliente_complemento=@Complemento, cliente_sexo=@Sexo " +
               "WHERE id_cliente=@Codigo";
          
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substiruídos
                cmd.Parameters.Add(new MySqlParameter("@Nome", dados.nome));
                cmd.Parameters.Add(new MySqlParameter("@Cep", dados.cep));
                cmd.Parameters.Add(new MySqlParameter("@Email", dados.email));
                cmd.Parameters.Add(new MySqlParameter("@Endereco", dados.endereco));
                cmd.Parameters.Add(new MySqlParameter("@N", dados.n));
                cmd.Parameters.Add(new MySqlParameter("@Bairro", dados.bairro));
                cmd.Parameters.Add(new MySqlParameter("@Cidade", dados.cidade));
                cmd.Parameters.Add(new MySqlParameter("@Uf", dados.uf));
                cmd.Parameters.Add(new MySqlParameter("@Telefone", dados.telefone));
                cmd.Parameters.Add(new MySqlParameter("@Complemento", dados.complemento));
                cmd.Parameters.Add(new MySqlParameter("@Sexo", dados.sexo));
                cmd.Parameters.Add(new MySqlParameter("@Codigo", dados.codigo));
                int registrosAtualizados = cmd.ExecuteNonQuery();

                if( registrosAtualizados >= 1)
                {
                    dados.mensagem = "Sucesso ao atualizar o registro!";
                    
                }
                else
                {
                    dados.mensagem = "Falha ao atualizar o registro!";
                }
                Conexao.fecharConexao();


            }
            catch (Exception erro)
            {
                dados.mensagem = "ERRO - AtualizarClientes - AtualizarDados - " +
                erro.Message.ToString();
            }
        }
    }
    public class ExcluirClientes
    {
        public void DeletarDados(Dados_Cliente dados)
        {
            try
            {
                //Comando Delete para o BD
                string sql = "DELETE FROM tb_cliente WHERE ClCodigo=@codigo";
                //Variável que receberá o resultado da Conexão e Delete
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Declarar o tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.codigo));
                //Execução do comando
                int registrosDeletados = cmd.ExecuteNonQuery();
                //Verificação da exclusão do registros
                if (registrosDeletados >= 1)
                {
                    dados.mensagem = "Registro deletado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao deletar o registro!";
                }
                Conexao.fecharConexao();

            }
            catch (MySqlException erro)
            {

                dados.mensagem = "ERRO - DeletarClientes - DeletarDdos" + erro.Message;
                erro.Message.ToString();
            }
        }
        
    }
}

