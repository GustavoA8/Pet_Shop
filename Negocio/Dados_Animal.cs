using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ConexaoBD;
using System.Data;


namespace Negocio
{
    public class Dados_Animal
    {
            public int CodigoPet { get; set; }
            public string NomePet { get; set; }
            public string CodigoDono { get; set; }
            public string Funcionario { get; set; }
            public string Raca { get; set; }
            public string Cor { get; set; }
            public string Tipo { get; set; }
            public decimal Peso { get; set; }
            public DateTime Nascimento { get; set; }
            public int Idade { get; set; }
            public int Rga { get; set; }
            public string Pedigree { get; set; }
            public string Sexo { get; set; }
            public string Observacao { get; set; }
            public string mensagem { get; set; } 
        
    }

    public class SalvarAnimais
    {
        //Metodo - ação - função
        public void InserirDados(Dados_Animal dados)
        {
            try
            {
                //String com o comando Insert do Banco
                string sql = "INSERT INTO tb_animais (an_nome," +
                "cliente_id, an_funcionario, an_nascimento) VALUES (@NomePet, @CodigoDono, @Funcionario, @Nascimento)";
                //Variável que receberá o resultado da Conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substiruídos
                cmd.Parameters.Add(new MySqlParameter("@NomePet", dados.NomePet));
                cmd.Parameters.Add(new MySqlParameter("@CodigoDono", dados.CodigoDono));
                cmd.Parameters.Add(new MySqlParameter("@Funcionario", dados.Funcionario));
                cmd.Parameters.Add(new MySqlParameter("@Nascimento", dados.Nascimento));
                int registrosInseridos = cmd.ExecuteNonQuery();
                if(registrosInseridos >= 1)
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
                dados.mensagem = "ERRO - SalvarAnimais - InserirDados -" + erro.ErrorCode + erro.Message;


               
            }
        }
    }
    public class ConsultarAnimais
    {
        public DataTable ListarDadosAnimais(Dados_Animal dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT * FROM tb_animais";
                //Adaptação dos dados do Banco de dados para o formato
                //de tabela com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "ERRO - ConsultarAnimais - ListarDadosAnimais: " +
                erro.Message.ToString();
            }
            //Retorno da tabela para DataGridView do form
            return tabela;

        }
        public DataTable ListarDadosAnimaisPet(Dados_Animal dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados com WHERE e LIKE
                string sql = "SELECT * FROM tb_animais WHERE an_nome LIKE @nome";
                //Comando para executar a Conexao e Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Parâmetros que serão substituídos na string sql
                cmd.Parameters.Add(new MySqlParameter("@nome", "%" + dados.NomePet + "%"));
                //Adaptação dos dados do Banco de dados para o formato
                //de tabela com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarClientes - ListarDadosAnimaisPet: " +
                erro.Message.ToString();
            }
            //Retorno da tabela para o DataGridView do form
            return tabela;
        }
        public DataTable ListarDadosAnimaisDono(Dados_Animal dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados com WHERE e LIKE
                string sql = "SELECT * FROM tb_animais WHERE cliente_id LIKE @codigo";
                //Comando para executar a Conexao e Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Parâmetros que serão substituídos na string sql
                cmd.Parameters.Add(new MySqlParameter("@codigo", "%" + dados.CodigoDono + "%"));
                //Adaptação dos dados do Banco de dados para o formato
                //de tabela com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarClientes - ListarDadosAnimaisDono: " +
                erro.Message.ToString();
            }
            //Retorno da tabela para o DataGridView do form
            return tabela;
        }
        public DataTable ListarCodigoDono(Dados_Animal dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados - Seleção da coluna Código
                string sql = "SELECT id_cliente FROM tb_cliente";
                //Adaptação dos dados do Banco de dados para o formato de Tabela
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "ERRO - ConsultarAnimais - ListarCodigoDono: " +
                erro.Message.ToString();
            }
            return tabela;

        }
    }
    public class AtualizarAnimais
    {
        public void AtualizarDados(Dados_Animal dados)
        {
            try
            {
                //String com o comando Insert do Banco
                string sql = "UPDATE tb_animais SET an_nome = @nomePet," +
                "an_funcionario = @funcionario WHERE an_id = @codigoPet";
                //Variável que receberá o resultado da Conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos
                cmd.Parameters.Add(new MySqlParameter("@codigoPet", dados.CodigoPet));
                cmd.Parameters.Add(new MySqlParameter("@nomePet", dados.NomePet));
                cmd.Parameters.Add(new MySqlParameter("@funcionario", dados.Funcionario));
                //Realiza a contagem de registros inseridos.
                int registrosAtualizados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi atualizado no Banco de Dados.
                if (registrosAtualizados >= 1)
                {
                    dados.mensagem = "Registro atualizado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao atualizar registro!";
                }
                //Fecha a conexão com o Banco de Dados.
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "ERRO - AtualizarAnimais - AtualizarDados:" +
                erro.Message.ToString();
            }

        }
    }
    public class DeletarAnimais
    {
        public void DeletarDados(Dados_Animal dados)
        {
            try
            {
                //String com o comando DELETE do Banco
                string sql = "DELETE FROM tb_animais WHERE an_id = @codigoPet";
                //Variável que receberá o resultado da Conexão com o comando Delete
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos
                cmd.Parameters.Add(new MySqlParameter("@codigoPet", dados.CodigoPet));
                //Realiza a contagem de registros deletados.
                int registrosDeletados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi deletado no Banco de Dados.
                if (registrosDeletados >= 1)
                {
                    dados.mensagem = "Registro deletado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao deletar registro!";
                }
                //Fecha a conexão com o Banco de Dados.
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "ERRO - DeletarAnimais - DeletarDados:" +
                erro.Message.ToString();
            }

        }
    }
}
