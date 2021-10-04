
namespace proxion
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.dtgListaDeTarefas = new System.Windows.Forms.DataGridView();
            this.lblListDeTarefas = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btneExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCabeçalho = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.lblFinalizada = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.ckbSim = new System.Windows.Forms.CheckBox();
            this.ckbNao = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvarCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDeTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCompleto.Location = new System.Drawing.Point(12, 19);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(50, 21);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "nome";
            // 
            // dtgListaDeTarefas
            // 
            this.dtgListaDeTarefas.AllowUserToAddRows = false;
            this.dtgListaDeTarefas.AllowUserToDeleteRows = false;
            this.dtgListaDeTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaDeTarefas.Location = new System.Drawing.Point(12, 81);
            this.dtgListaDeTarefas.Name = "dtgListaDeTarefas";
            this.dtgListaDeTarefas.ReadOnly = true;
            this.dtgListaDeTarefas.RowTemplate.Height = 25;
            this.dtgListaDeTarefas.Size = new System.Drawing.Size(456, 183);
            this.dtgListaDeTarefas.TabIndex = 1;
            // 
            // lblListDeTarefas
            // 
            this.lblListDeTarefas.AutoSize = true;
            this.lblListDeTarefas.Location = new System.Drawing.Point(12, 63);
            this.lblListDeTarefas.Name = "lblListDeTarefas";
            this.lblListDeTarefas.Size = new System.Drawing.Size(91, 15);
            this.lblListDeTarefas.TabIndex = 2;
            this.lblListDeTarefas.Text = "Lista de tarefas :";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(397, 20);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 292);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btneExcluir
            // 
            this.btneExcluir.Location = new System.Drawing.Point(159, 292);
            this.btneExcluir.Name = "btneExcluir";
            this.btneExcluir.Size = new System.Drawing.Size(104, 23);
            this.btneExcluir.TabIndex = 5;
            this.btneExcluir.Text = "Excluir Campo";
            this.btneExcluir.UseVisualStyleBackColor = true;
            this.btneExcluir.Click += new System.EventHandler(this.btneExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(327, 292);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar tarefa";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCabeçalho
            // 
            this.lblCabeçalho.AutoSize = true;
            this.lblCabeçalho.Location = new System.Drawing.Point(1771, 1043);
            this.lblCabeçalho.Name = "lblCabeçalho";
            this.lblCabeçalho.Size = new System.Drawing.Size(279, 15);
            this.lblCabeçalho.TabIndex = 7;
            this.lblCabeçalho.Text = "Insira as informações do campos que será alterado :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1684, 1075);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 15);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id :";
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Location = new System.Drawing.Point(1684, 1104);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(44, 15);
            this.lblTarefa.TabIndex = 9;
            this.lblTarefa.Text = "Tarefa :";
            // 
            // lblFinalizada
            // 
            this.lblFinalizada.AutoSize = true;
            this.lblFinalizada.Location = new System.Drawing.Point(1684, 1135);
            this.lblFinalizada.Name = "lblFinalizada";
            this.lblFinalizada.Size = new System.Drawing.Size(65, 15);
            this.lblFinalizada.TabIndex = 10;
            this.lblFinalizada.Text = "Finalizada :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1771, 1072);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(279, 23);
            this.txtId.TabIndex = 3;
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(1771, 1101);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(279, 23);
            this.txtTarefa.TabIndex = 11;
            // 
            // ckbSim
            // 
            this.ckbSim.AutoSize = true;
            this.ckbSim.Location = new System.Drawing.Point(1771, 1134);
            this.ckbSim.Name = "ckbSim";
            this.ckbSim.Size = new System.Drawing.Size(46, 19);
            this.ckbSim.TabIndex = 12;
            this.ckbSim.Text = "Sim";
            this.ckbSim.UseVisualStyleBackColor = true;
            this.ckbSim.Click += new System.EventHandler(this.ckbSim_Click);
            // 
            // ckbNao
            // 
            this.ckbNao.AutoSize = true;
            this.ckbNao.Location = new System.Drawing.Point(1857, 1134);
            this.ckbNao.Name = "ckbNao";
            this.ckbNao.Size = new System.Drawing.Size(48, 19);
            this.ckbNao.TabIndex = 13;
            this.ckbNao.Text = "Não";
            this.ckbNao.UseVisualStyleBackColor = true;
            this.ckbNao.Click += new System.EventHandler(this.ckbNao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(2064, 1140);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(2078, 1218);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click_1);
            // 
            // btnSalvarCadastro
            // 
            this.btnSalvarCadastro.Location = new System.Drawing.Point(679, 241);
            this.btnSalvarCadastro.Name = "btnSalvarCadastro";
            this.btnSalvarCadastro.Size = new System.Drawing.Size(147, 23);
            this.btnSalvarCadastro.TabIndex = 17;
            this.btnSalvarCadastro.Text = "Salvar cadastro";
            this.btnSalvarCadastro.UseVisualStyleBackColor = true;
            this.btnSalvarCadastro.Click += new System.EventHandler(this.btnSalvarCadastro_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 329);
            this.Controls.Add(this.btnSalvarCadastro);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ckbNao);
            this.Controls.Add(this.ckbSim);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblFinalizada);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCabeçalho);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btneExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblListDeTarefas);
            this.Controls.Add(this.dtgListaDeTarefas);
            this.Controls.Add(this.lblNomeCompleto);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDeTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.DataGridView dtgListaDeTarefas;
        private System.Windows.Forms.Label lblListDeTarefas;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btneExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCabeçalho;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.Label lblFinalizada;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.CheckBox ckbSim;
        private System.Windows.Forms.CheckBox ckbNao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvarCadastro;
    }
}