using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace student_manager
{
    internal class MEU_BD
    {
        // conexao é  objeto que representa a conexão com o banco de dados.
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username:root;password=;database=t5_sga_bd");
        //versão publica da variavel/objeto "conexao"
        public MySqlConnection getConexao
        {
            get
            {
                return conexao;
            }
        }
        // Método para abrir/omocoaçozar a coneão
        public void abrirConexao()


        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        // Método para abrir/omocoaçozar a coneão
        public void fecharConexao()


        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}