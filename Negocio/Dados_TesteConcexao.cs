using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ConexaoBD;

namespace Negocio
{
    public class Dados_TesteConcexao
    {
        public MySqlConnection conectar = null;
        public string mensagem = string.Empty;

        public void Verificar()
        {
            conectar = Conexao.obterConexao();
            mensagem = Conexao.mensagem;
        }
    }
}
