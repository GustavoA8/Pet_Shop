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
            public int CodigoDono { get; set; }
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
}
