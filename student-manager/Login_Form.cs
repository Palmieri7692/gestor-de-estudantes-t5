using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_manager
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Coloca a imagem user.png na picture box da janela.
            pictureBox1.Image = Image.FromFile("../../imagens/user.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MEU_BD bancoDeDados = new MEU_BD();

            MySqlDataAdapter adaptator = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario` = @usn AND `senha`= @psw", bancoDeDados.getConexao);

            comando.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsuaria.Text;
            comando.Parameters.Add("psw,", MySqlDbType.VarChar).Value = txtSenha.Text;
            adaptator.SelectCommand = comando;
            adaptator.Fill(tabela);
            if (tabela.Rows.Count > 0)
            {
                MessageBox.Show("YES");
            }
            {
                MessageBox.Show("NO");
            }
        }   
    }
}
