using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proxion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            

        }
        static private string servidor = "localhost";
        static private string porta = "3306";
        static private string bancoDados = "proxion";
        static private string usuario = "root";
        static private string senha = "";
        static private string user = "root";
        private bool conectar()
        {
            var result = false;
            try
            {
                using (var cn = new MySqlConnection(Conector.strConec))
                {
                    cn.Open();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Falha: " + ex.Message);
            }
            return result;
        }

        private void txtEntrar_Click(object sender, EventArgs e)
        {
            //326; 221 size
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                lblUsuarioVazio.Text = "Preencha os campos por favor";
                lblUsuarioVazio.Location = new Point(100, 113);
                lblUsuarioVazio.ForeColor = Color.Red;
            }
            else if (txtUsuario.Text == "")
            {
                //154; 66
                lblUsuarioVazio.Text = "Por favor informe o usuário";
                lblUsuarioVazio.Location = new Point(50, 113);
                lblUsuarioVazio.ForeColor = Color.Red;
            }
            else if (txtSenha.Text == "")
            {
                lblUsuarioVazio.Text = "Por favor informe a senha deste usuário";
                lblUsuarioVazio.Location = new Point(60, 113);
                lblUsuarioVazio.ForeColor = Color.Red;
            }
            else
            {
                //698dc19d489c4e4db73e28a713eab07b
                string password = criptografia(txtSenha.Text);
                MySqlConnection objCon = new MySqlConnection("server=" + servidor + ";port=" + porta +";User Id="+usuario+";UID="+user+";database="+bancoDados+";password="+senha+"; SSL MODE = 0");
                objCon.Open();
                MySqlCommand retornaDados = new MySqlCommand("SELECT password,id FROM user where username= ?",objCon);
                retornaDados.Parameters.Clear();
                retornaDados.Parameters.Add(@"username", MySqlDbType.VarChar).Value = txtUsuario.Text;
                retornaDados.CommandType = CommandType.Text;

                MySqlDataReader infoBd;
                infoBd = retornaDados.ExecuteReader();
                infoBd.Read();
                var senhaDoPerfil = "";
                string idDoPerfil = "";
                try
                {
                    senhaDoPerfil = infoBd.GetValue(0).ToString();
                    idDoPerfil = infoBd.GetValue(1).ToString();
                }
                catch (Exception){}

                if (senhaDoPerfil == "")
                {
                    lblUsuarioVazio.Text = "Usuário ou Senha incorreto";
                    lblUsuarioVazio.Location = new Point(100, 113);
                    lblUsuarioVazio.ForeColor = Color.Red;
                }
                else if (senhaDoPerfil == password)
                {
                    this.Hide();
                    Principal tela = new Principal(idDoPerfil);
                    tela.Show();

                    //logou
                }
                else
                {
                    lblUsuarioVazio.Text = "Usuário ou Senha incorreto";
                    lblUsuarioVazio.Location = new Point(100, 113);
                    lblUsuarioVazio.ForeColor = Color.Red;
                }

                objCon.Close();
                
            }
            System.Diagnostics.Process.Start(Application.ExecutablePath);

        }
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
            this.Hide();

            Cadastro tela = new Cadastro();
            tela.Show();

        }

        private void lblUsuarioVazio_Click(object sender, EventArgs e)
        {

        }
    }
}
