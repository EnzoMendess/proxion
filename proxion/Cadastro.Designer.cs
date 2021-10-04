
namespace proxion
{
    partial class Cadastro
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
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtNomeDeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblVazio = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(22, 29);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(104, 15);
            this.lblNomeUsuario.TabIndex = 0;
            this.lblNomeUsuario.Text = "Nome de usuário :";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(22, 66);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 15);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha :";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(22, 101);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(100, 15);
            this.lblNomeCompleto.TabIndex = 2;
            this.lblNomeCompleto.Text = "Nome completo :";
            // 
            // txtNomeDeUsuario
            // 
            this.txtNomeDeUsuario.Location = new System.Drawing.Point(142, 26);
            this.txtNomeDeUsuario.Name = "txtNomeDeUsuario";
            this.txtNomeDeUsuario.Size = new System.Drawing.Size(226, 23);
            this.txtNomeDeUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(142, 63);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(226, 23);
            this.txtSenha.TabIndex = 4;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(142, 101);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(226, 23);
            this.txtNomeCompleto.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(293, 147);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblVazio
            // 
            this.lblVazio.AutoSize = true;
            this.lblVazio.Location = new System.Drawing.Point(613, 71);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(38, 15);
            this.lblVazio.TabIndex = 7;
            this.lblVazio.Text = "label1";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(22, 147);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 182);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblVazio);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNomeDeUsuario);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNomeUsuario);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtNomeDeUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblVazio;
        private System.Windows.Forms.Button btnVoltar;
    }
}