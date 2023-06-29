using ConexaoBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMarket
{
    public class Dados_Produto
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public DateTime validade { get; set; }
        public string marca { get; set; }
        public DateTime registro { get; set; }
        public int quantidade { get; set; }
        public string preco { get; set; }
        public string msg { set; get; }
        public string fornecedor { get; set; }

    }

    public class SalvarProduto
    {
        public void InserirDados(Dados_Produto dados)
        {
            try
            {
                string sql = "INSERT INTO tb_produto (pdt_nome, pdt_tipo, pdt_marca, pdt_registro) " +
                    "VALUES (@pdtnome, @pdttipo, @pdtmarca, @pdtregistro)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@pdtnome", dados.nome));
                cmd.Parameters.Add(new MySqlParameter("@pdttipo", dados.tipo));
                cmd.Parameters.Add(new MySqlParameter("@pdtregistro", dados.registro));
                cmd.Parameters.Add(new MySqlParameter("@pdtmarca", dados.marca));
                int registrosInseridos = cmd.ExecuteNonQuery();
                if (registrosInseridos >= 1)
                {
                    dados.msg = "Registro do produto inserido com Sucesso!";
                }
                else
                {
                    dados.msg = "Falha ao inserir o produto no registro!";
                }
            }
            catch (MySqlException erro)
            {

                dados.msg = "ERRO - SalvarProduto - InserirDados -" + erro.ErrorCode + erro.Message;
            }
        }
        
    }
    public class SalvarEstoque
    {
        public void InserirDados(Dados_Produto dados)
        {
            try
            {
                string sql = "INSERT INTO tb_estoque (est_qtde, est_id_pdt) " +
                    "VALUES (@qtde, @codigo)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.quantidade));
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.codigo));
                int registrosInseridos = cmd.ExecuteNonQuery();
                if (registrosInseridos >= 1)
                {
                    dados.msg = "Registro do produto inserido com Sucesso!";
                }
                else
                {
                    dados.msg = "Falha ao inserir o produto no registro!";
                }
            }
            catch (MySqlException erro)
            {

                dados.msg = "ERRO - SalvarProduto - InserirDados -" + erro.ErrorCode + erro.Message;
            }
        }
        public void BuscarCodigo(Dados_Produto dados)
        {
            try
            {
                string sql = "SELECT id_pdt FROM tb_produto  ORDER BY id_pdt DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Define o tipo de comando
                cmd.CommandType = CommandType.Text;
                //Realiza a leitura dos dados - Reader
                //Ignora os títulos da tabela
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verifica se há linhas nesta leitura de dados
                if (dr.HasRows)
                {
                    //Enquanto houver dados
                    while (dr.Read())
                    {
                        dados.codigo = dr.GetInt32(0);
                    }//11 + 1 = 12
                }
                Conexao.fecharConexao();

            }
            catch (MySqlException erro)
            {

                dados.msg = "ERRO - PegarCodigo - InserirDados -" + erro.ErrorCode + erro.Message;
            }
        }
    }
    public class SalvarCompra
    {
        public void InserirDados(Dados_Produto dados)
        {
            try
            {

                string sql = "INSERT INTO tb_fornecedor (for_id_pdt, for_fornecedor, for_dataval, for_qtde, for_preco, for_registro) " +
                    "VALUES (@idpdt, @fornecedor, @validade, @qtde, @preco, @registro)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@idpdt", dados.codigo));
                cmd.Parameters.Add(new MySqlParameter("@fornecedor", dados.fornecedor));
                cmd.Parameters.Add(new MySqlParameter("@validade", dados.validade));
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.quantidade));
                cmd.Parameters.Add(new MySqlParameter("@preco", dados.preco));
                cmd.Parameters.Add(new MySqlParameter("@registro", dados.registro));

                int registrosInseridos = cmd.ExecuteNonQuery();
                if (registrosInseridos >= 1)
                {
                    dados.msg = "Registro da compra inserido com Sucesso!";
                }
                else
                {
                    dados.msg = "Falha ao inserir a compra no registro!";
                }
            }
            catch (MySqlException erro)
            {

                dados.msg = "ERRO - SalvarCompra - InserirDados -" + erro.ErrorCode + erro.Message;
            }
        }
        public void CEstoque(Dados_Produto dados)
        {
            int qtde = new int();
            try
            {
                string sql = "SELECT est_qtde FROM tb_estoque WHERE est_id_pdt=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Define o tipo de comando
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.codigo));
                //Realiza a leitura dos dados - Reader
                //Ignora os títulos da tabela
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verifica se há linhas nesta leitura de dados
                if (dr.HasRows)
                {
                    //Enquanto houver dados
                    while (dr.Read())
                    {
                        qtde = dr.GetInt32(0);
                        dados.quantidade += qtde;
                    }//11 + 1 = 12
                }
                Conexao.fecharConexao();

            }
            catch (MySqlException erro)
            {

                dados.msg = "ERRO - PegarCodigo - InserirDados -" + erro.ErrorCode + erro.Message;
            }

            try
            {
                string sql = "UPDATE tb_estoque SET est_qtde=@qtde WHERE est_id_pdt=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.quantidade));
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.codigo));
                int registrosAtualizados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi atualizado
                if (registrosAtualizados >= 1)
                {
                    dados.msg = "Sucesso ao atualizar o registro!";
                }
                else
                {
                    dados.msg = "Falha ao atualizar o registro!";
                }
                Conexao.fecharConexao();

            }
            catch (MySqlException erro)
            {
                dados.msg = "ERRO - SalvarCompra - CEstoque -" + erro.ErrorCode + erro.Message;
            }
          
        }
    }
    public class SalvarVenda
    {
        public void inserirDados(Dados_Produto dados)
        {
            try
            {

                string sql = "INSERT INTO tb_venda (ven_id_pdt, ven_qtde, ven_preco, ven_validade) " +
                    "VALUES (@idpdt, @qtde, @preco, @validade)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@idpdt", dados.codigo));
                cmd.Parameters.Add(new MySqlParameter("@validade", dados.validade));
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.quantidade));
                cmd.Parameters.Add(new MySqlParameter("@preco", dados.preco));

                int registrosInseridos = cmd.ExecuteNonQuery();
                if (registrosInseridos >= 1)
                {
                    dados.msg = "Registro da venda inserido com Sucesso!";
                }
                else
                {
                    dados.msg = "Falha ao inserir a venda no registro!";
                }
            }
            catch (MySqlException erro)
            {

                dados.msg = "ERRO - SalvarVenda - InserirDados -" + erro.ErrorCode + erro.Message;
            }
        }
        public void VEstoque(Dados_Produto dados)
        {
            int qtde = new int();
            try
            {
                string sql = "SELECT est_qtde FROM tb_estoque WHERE est_id_pdt=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Define o tipo de comando
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.codigo));
                //Realiza a leitura dos dados - Reader
                //Ignora os títulos da tabela
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verifica se há linhas nesta leitura de dados
                if (dr.HasRows)
                {
                    //Enquanto houver dados
                    while (dr.Read())
                    {
                        qtde = dr.GetInt32(0);
                        dados.quantidade -= qtde;
                    }//11 + 1 = 12
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.msg = "ERRO - SalvarCompra - VEstoque -" + erro.ErrorCode + erro.Message;
            }
                try
                {
                    string sql = "UPDATE tb_estoque SET est_qtde=@qtde WHERE est_id_pdt=@codigo";
                    MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new MySqlParameter("@qtde", dados.quantidade));
                    cmd.Parameters.Add(new MySqlParameter("@codigo", dados.codigo));
                    int registrosAtualizados = cmd.ExecuteNonQuery();
                    //Verifica se algum registro foi atualizado
                    if (registrosAtualizados >= 1)
                    {
                        dados.msg = "Sucesso ao atualizar o registro!";
                    }
                    else
                    {
                        dados.msg = "Falha ao atualizar o registro!";
                    }
                    Conexao.fecharConexao();

                }
                catch (MySqlException erro)
                {
                    dados.msg = "ERRO - SalvarCompra - CEstoque -" + erro.ErrorCode + erro.Message;
                }

        }
        
    }
    public class ConsultarProduto
    {
        public DataTable ListarDados(Dados_Produto dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT id_pdt, pdt_nome, pdt_tipo, pdt_marca, pdt_registro  FROM tb_produto";
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
                dados.msg = "Erro - ConsultarProduto - ListarDadosProduto " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
        public DataTable ListarDadosFiltro(Dados_Produto dados)
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
                dados.msg = "Erro - ConsultarClientes - ListarDadosClientesFiltro " +
                erro.Message.ToString();
            }
            return tabela;
        }

    }
}
