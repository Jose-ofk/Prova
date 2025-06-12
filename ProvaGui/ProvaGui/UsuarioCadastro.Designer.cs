namespace ProvaGui
{
    partial class UsuarioCadastro
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
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExcluirUsuario = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuarioEditar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaEditar = new System.Windows.Forms.TextBox();
            this.btnEditarSenha = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(147, 28);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtSenhaUsuario.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Senha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExcluirUsuario);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(641, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 100);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluir Usuário";
            // 
            // txtExcluirUsuario
            // 
            this.txtExcluirUsuario.Location = new System.Drawing.Point(10, 45);
            this.txtExcluirUsuario.Name = "txtExcluirUsuario";
            this.txtExcluirUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtExcluirUsuario.TabIndex = 38;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(6, 71);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(139, 23);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir Usuário";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Usuário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuarioEditar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSenhaEditar);
            this.groupBox1.Controls.Add(this.btnEditarSenha);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(641, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 148);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Senha";
            // 
            // txtUsuarioEditar
            // 
            this.txtUsuarioEditar.Location = new System.Drawing.Point(10, 34);
            this.txtUsuarioEditar.Name = "txtUsuarioEditar";
            this.txtUsuarioEditar.Size = new System.Drawing.Size(130, 20);
            this.txtUsuarioEditar.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Usuario";
            // 
            // txtSenhaEditar
            // 
            this.txtSenhaEditar.Location = new System.Drawing.Point(10, 83);
            this.txtSenhaEditar.Name = "txtSenhaEditar";
            this.txtSenhaEditar.Size = new System.Drawing.Size(130, 20);
            this.txtSenhaEditar.TabIndex = 38;
            // 
            // btnEditarSenha
            // 
            this.btnEditarSenha.Location = new System.Drawing.Point(6, 109);
            this.btnEditarSenha.Name = "btnEditarSenha";
            this.btnEditarSenha.Size = new System.Drawing.Size(139, 23);
            this.btnEditarSenha.TabIndex = 28;
            this.btnEditarSenha.Text = "Mudar";
            this.btnEditarSenha.UseVisualStyleBackColor = true;
            this.btnEditarSenha.Click += new System.EventHandler(this.btnEditarSenha_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Nova Senha";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(11, 82);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(624, 357);
            this.dgvUsuario.TabIndex = 43;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(283, 25);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(113, 23);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(11, 28);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtUsuario.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Usuario";
            // 
            // UsuarioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "UsuarioCadastro";
            this.Text = "UsuarioCadastro";
            this.Load += new System.EventHandler(this.UsuarioCadastro_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExcluirUsuario;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuarioEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaEditar;
        private System.Windows.Forms.Button btnEditarSenha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
    }
}