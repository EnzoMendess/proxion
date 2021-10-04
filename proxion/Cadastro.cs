using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace proxion
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        static private string servidor = "localhost";
        static private string porta = "3306";
        static private string bancoDados = "proxion";
        static private string usuario = "root";
        static private string senha = "";
        static private string user = "root";
        private string criptografia(string dado)
        {
            MD5 md5hasher = MD5.Create();
            byte[] valorCriptografado = md5hasher.ComputeHash(Encoding.Default.GetBytes(dado));

            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < valorCriptografado.Length; i++)

            {

                strBuilder.Append(valorCriptografado[i].ToString("x2"));

            }

            return strBuilder.ToString();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string password = criptografia(txtSenha.Text);
            if (txtNomeDeUsuario.Text == "" && txtSenha.Text == "" && txtNomeCompleto.Text == "")
            {
                lblVazio.Text = "Preencha os campos por favor";
                lblVazio.Location = new Point(142, 127);
                lblVazio.ForeColor = Color.Red;
            }
            else if (txtNomeDeUsuario.Text == "")
            {
                //154; 66
                lblVazio.Text = "Por favor informe o usuário";
                lblVazio.Location = new Point(142, 127);
                lblVazio.ForeColor = Color.Red;
            }
            else if (txtNomeCompleto.Text == "")
            {
                lblVazio.Text = "Por favor informe o nome completo";
                lblVazio.Location = new Point(142, 127);
                lblVazio.ForeColor = Color.Red;
            }
            else if (txtSenha.Text == "")
            {
                lblVazio.Text = "Por favor informe a senha deste usuário";
                lblVazio.Location = new Point(142, 127);
                lblVazio.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    MySqlConnection objCon = new MySqlConnection("server=" + servidor + ";port=" + porta + ";User Id=" + usuario + ";UID=" + user + ";database=" + bancoDados + ";password=" + senha + "; SSL MODE = 0");
                    objCon.Open();
                    MySqlCommand inserirDados = new MySqlCommand("Insert into user(id, username, password, full_name) values(null, ?, ?, ?)", objCon);
                    inserirDados.Parameters.Add("@username", MySqlDbType.VarChar, 40).Value = txtNomeDeUsuario.Text;
                    inserirDados.Parameters.Add("@password", MySqlDbType.VarChar, 40).Value = password;
                    inserirDados.Parameters.Add("@full_name", MySqlDbType.VarChar, 100).Value = txtNomeCompleto.Text;

                    inserirDados.ExecuteNonQuery();
                    objCon.Close();

                    lblVazio.Text = "Cadastro realizado com sucesso";
                    lblVazio.Location = new Point(142, 127);
                    lblVazio.ForeColor = Color.Black;
                }
                catch (Exception)
                {
                    lblVazio.Text = "Erro ao cadastrar tente novamente";
                    lblVazio.Location = new Point(142, 127);
                    lblVazio.ForeColor = Color.Red;
                }
                
            }

            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin tela = new FrmLogin();
            tela.Show();
        }
    }
}
