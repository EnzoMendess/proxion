using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proxion
{
    public partial class Principal : Form
    {
        public string idDoUsuario;
        public string idNaLista;
        public Principal(string idDoPerfil)
        {
            InitializeComponent();
            dadosDoBanco(idDoPerfil);
            idDoUsuario = idDoPerfil;
        }
        public void dadosDoBanco(string idDoPerfil)
        {
            MySqlConnection objCon = new MySqlConnection("server=" + servidor + ";port=" + porta + ";User Id=" + usuario + ";UID=" + user + ";database=" + bancoDados + ";password=" + senha + "; SSL MODE = 0");
            objCon.Open();

            ///Ao chegar na tela sei o usuario e o id na tabela de user
            //pegar onde user_id na tabela todo_list for igual o id do user
            //e pegar o id do todo_list para achar oq ele precisa fazer no todo_list_item

            //retornando nome completo do usuario
            MySqlCommand retornaNomeCompleto = new MySqlCommand("SELECT full_name FROM user where id= ?", objCon);
            retornaNomeCompleto.Parameters.Clear();
            retornaNomeCompleto.Parameters.Add(@"id", MySqlDbType.VarChar).Value = idDoPerfil;
            retornaNomeCompleto.CommandType = CommandType.Text;
            MySqlDataReader nomeCompleto;
            nomeCompleto = retornaNomeCompleto.ExecuteReader();
            nomeCompleto.Read();
            try
            {
                lblNomeCompleto.Text = nomeCompleto.GetValue(0).ToString();

            }
            catch (Exception) { }
            nomeCompleto.Close();

            //descobrindo o id do todo_list
            MySqlCommand retornaIdTodo_list = new MySqlCommand("SELECT id FROM todo_list where user_id= ?", objCon);
            retornaIdTodo_list.Parameters.Clear();
            retornaIdTodo_list.Parameters.Add(@"id_user", MySqlDbType.VarChar).Value = idDoPerfil;
            retornaIdTodo_list.CommandType = CommandType.Text;
            MySqlDataReader infoBd;
            infoBd = retornaIdTodo_list.ExecuteReader();
            infoBd.Read();
            string idDoUsuarioNaLista = "";
            try
            {
                idDoUsuarioNaLista = infoBd.GetValue(0).ToString();
            }
            catch (Exception) { }
            infoBd.Close();
            idNaLista = idDoUsuarioNaLista;

            //descobrindo as tarefas que ele tem para fazer
            //
            MySqlCommand retornaIdTodo_list_item = new MySqlCommand("SELECT * FROM todo_list_item where todo_list_id= ?", objCon);
            retornaIdTodo_list_item.Parameters.Clear();
            retornaIdTodo_list_item.Parameters.Add(@"todo_list_id", MySqlDbType.VarChar).Value = idDoUsuarioNaLista;
            retornaIdTodo_list_item.CommandType = CommandType.Text;
            MySqlDataReader items;
            items = retornaIdTodo_list_item.ExecuteReader();
            items.Read();
            //string idDoUsuarioNaLista = "";
            try
            {
                DataTable dt = new DataTable();
                dt.Load(items);
                dtgListaDeTarefas.DataSource = dt;
            }
            catch (Exception) { }
            items.Close();
            objCon.Close();
        }
        static private string servidor = "localhost";
        static private string porta = "3306";
        static private string bancoDados = "proxion";
        static private string usuario = "root";
        static private string senha = "";
        static private string user = "root";
        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin tela = new FrmLogin();
            tela.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Principal.ActiveForm.Size = new Size(496, 513);
            lblCabeçalho.Location = new Point(100, 342);
            txtId.Location = new Point(100, 371);
            txtTarefa.Location = new Point(100, 400);
            lblId.Location = new Point(13, 374);
            lblTarefa.Location = new Point(13, 403);
            lblFinalizada.Location = new Point(13, 434);
            ckbSim.Location = new Point(100, 433);
            ckbNao.Location = new Point(186, 433);
            btnSalvar.Location = new Point(397, 433);
            btnSalvarCadastro.Location = new Point(1000, 1000);
            btnDeletar.Location = new Point(1000, 1000);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
            int tarefaFinalizada = 0;
            if (ckbSim.Checked)
            {
                tarefaFinalizada = 1;
            }
            if (ckbNao.Checked)
            {
                tarefaFinalizada = 0;
            }
            
            MySqlConnection objCon = new MySqlConnection("server=" + servidor + ";port=" + porta + ";User Id=" + usuario + ";UID=" + user + ";database=" + bancoDados + ";password=" + senha + "; SSL MODE = 0");
            objCon.Open();

            MySqlCommand atualizaDados = new MySqlCommand("UPDATE todo_list_item SET name = ?, is_done = ? where id = ?", objCon);//update todo_list_item set name = 'alterado', is_done = false, todo_list_id = 4 where id = 4
            atualizaDados.Parameters.Clear();
            atualizaDados.Parameters.AddWithValue("@name", txtTarefa.Text);
            atualizaDados.Parameters.AddWithValue("@is_done",tarefaFinalizada);
            atualizaDados.Parameters.AddWithValue("@id", txtId.Text);
            atualizaDados.CommandType = CommandType.Text;
            atualizaDados.ExecuteNonQuery();
            objCon.Close();
            MessageBox.Show("Atualização realizada com sucesso");
            dadosDoBanco(idDoUsuario);
        }

        private void btneExcluir_Click(object sender, EventArgs e)
        {
            Principal.ActiveForm.Size = new Size(501, 445);
            lblCabeçalho.Location = new Point(100, 342);
            lblCabeçalho.Text = "Insira o ID da tarefa que deseja excluir";
            txtId.Location = new Point(100, 374);
            lblId.Location = new Point(13, 374);
            btnDeletar.Location = new Point(397, 374);
            txtTarefa.Location = new Point(1000, 1000);


            lblTarefa.Location = new Point(1000,1000);
            lblFinalizada.Location = new Point(1000, 1000);
            ckbSim.Location = new Point(1000, 1000);
            ckbNao.Location = new Point(1000, 1000);
            btnSalvar.Location = new Point(1000, 1000);
            btnSalvarCadastro.Location = new Point(1000, 1000);
        }
        private void btnDeletar_Click_1(object sender, EventArgs e)
        {

            MySqlConnection objCon = new MySqlConnection("server=" + servidor + ";port=" + porta + ";User Id=" + usuario + ";UID=" + user + ";database=" + bancoDados + ";password=" + senha + "; SSL MODE = 0");
            objCon.Open();

            MySqlCommand deletaTarefa = new MySqlCommand("delete from todo_list_item where id = ?", objCon);

            deletaTarefa.Parameters.Clear();

            deletaTarefa.Parameters.Add("@id", MySqlDbType.Int32).Value = txtId.Text;

            deletaTarefa.CommandType = CommandType.Text;
            deletaTarefa.ExecuteNonQuery();
            objCon.Close();
            MessageBox.Show("Tarefa deletada");
            dadosDoBanco(idDoUsuario);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Principal.ActiveForm.Size = new Size(496, 513);
            lblCabeçalho.Location = new Point(100, 342);
            lblCabeçalho.Text = "Insira as informações da tarefa";
            txtTarefa.Location = new Point(100, 400);
            lblTarefa.Location = new Point(13, 403);
            lblFinalizada.Location = new Point(13, 434);
            ckbSim.Location = new Point(100, 433);
            ckbNao.Location = new Point(186, 433);
            btnSalvarCadastro.Location = new Point(330, 433);


            txtId.Location = new Point(1000, 1000);
            lblId.Location = new Point(1000, 1000);
            btnDeletar.Location = new Point(1000, 1000);
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            MySqlConnection objCon = new MySqlConnection("server=" + servidor + ";port=" + porta + ";User Id=" + usuario + ";UID=" + user + ";database=" + bancoDados + ";password=" + senha + "; SSL MODE = 0");
            objCon.Open();

            int tarefaFinalizada = 0;
            if (ckbSim.Checked)
            {
                ckbNao.Checked = false;
                tarefaFinalizada = 1;
            }
            if (ckbNao.Checked)
            {
                ckbSim.Checked = false;
                tarefaFinalizada = 0;
            }
            
           
            try
            {
                
                MySqlCommand inserirDados = new MySqlCommand("Insert into todo_list_item(id, name, is_done, todo_list_id) values(null, ?, ?, ?)", objCon);
                inserirDados.Parameters.Add("@name", MySqlDbType.VarChar, 40).Value = txtTarefa.Text;
                inserirDados.Parameters.Add("@is_done", MySqlDbType.Int32).Value = tarefaFinalizada;
                inserirDados.Parameters.Add("@todo_list_id", MySqlDbType.VarChar, 100).Value = idNaLista;
                inserirDados.CommandType = CommandType.Text;
                inserirDados.ExecuteNonQuery();
                objCon.Close();

                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception ex)
            {
                try
                {
                    string[] nome = lblNomeCompleto.Text.Split();
                    MySqlCommand InserirTodoList = new MySqlCommand("Insert into todo_list(id, name, user_id) values(null, ?, ?)", objCon);
                    InserirTodoList.Parameters.Add("@name", MySqlDbType.VarChar, 40).Value = nome[0];
                    InserirTodoList.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = idDoUsuario;
                    InserirTodoList.CommandType = CommandType.Text;
                    InserirTodoList.ExecuteNonQuery();

                    MySqlCommand retornaIdTodo_list = new MySqlCommand("SELECT id FROM todo_list where user_id= ?", objCon);
                    retornaIdTodo_list.Parameters.Clear();
                    retornaIdTodo_list.Parameters.Add(@"id_user", MySqlDbType.VarChar).Value = idDoUsuario;
                    retornaIdTodo_list.CommandType = CommandType.Text;
                    MySqlDataReader infoBd;
                    infoBd = retornaIdTodo_list.ExecuteReader();
                    infoBd.Read();
                    string idDoUsuarioNaLista = "";
                    try
                    {
                        idDoUsuarioNaLista = infoBd.GetValue(0).ToString();
                    }
                    catch (Exception) { }
                    infoBd.Close();
                    idNaLista = idDoUsuarioNaLista;

                    MySqlCommand inserirDados = new MySqlCommand("Insert into todo_list_item(id, name, is_done, todo_list_id) values(null, ?, ?, ?)", objCon);
                    inserirDados.Parameters.Add("@name", MySqlDbType.VarChar, 40).Value = txtTarefa.Text;
                    inserirDados.Parameters.Add("@is_done", MySqlDbType.Int32).Value = tarefaFinalizada;
                    inserirDados.Parameters.Add("@todo_list_id", MySqlDbType.VarChar, 100).Value = idNaLista;
                    inserirDados.CommandType = CommandType.Text;
                    inserirDados.ExecuteNonQuery();
                    objCon.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Erro ao cadastrar");

                }
            }

            dadosDoBanco(idDoUsuario);
        }

        private void ckbSim_Click(object sender, EventArgs e)
        {
            ckbNao.Checked = false;
        }

        private void ckbNao_Click(object sender, EventArgs e)
        {
            ckbSim.Checked = false;
        }
    }
}
