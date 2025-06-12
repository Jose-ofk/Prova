namespace ProvaGui
{
    partial class Clientes
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskWhatsapp = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.mskCpfEditar = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskCpfDeletar = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(182, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 190);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(628, 248);
            this.dgvClientes.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar CEP";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(216, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Whatsapp";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(429, 25);
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(107, 20);
            this.mskCpf.TabIndex = 12;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(555, 25);
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(107, 20);
            this.mskTelefone.TabIndex = 13;
            // 
            // mskWhatsapp
            // 
            this.mskWhatsapp.Location = new System.Drawing.Point(681, 25);
            this.mskWhatsapp.Name = "mskWhatsapp";
            this.mskWhatsapp.Size = new System.Drawing.Size(107, 20);
            this.mskWhatsapp.TabIndex = 14;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(15, 78);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(250, 78);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(131, 78);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(100, 20);
            this.txtLogradouro.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(368, 78);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(606, 78);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(485, 78);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 25;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(314, 138);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(154, 23);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 23);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(6, 71);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(139, 23);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // mskCpfEditar
            // 
            this.mskCpfEditar.Location = new System.Drawing.Point(6, 45);
            this.mskCpfEditar.Name = "mskCpfEditar";
            this.mskCpfEditar.Size = new System.Drawing.Size(139, 20);
            this.mskCpfEditar.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "CPF";
            // 
            // mskCpfDeletar
            // 
            this.mskCpfDeletar.Location = new System.Drawing.Point(6, 45);
            this.mskCpfDeletar.Name = "mskCpfDeletar";
            this.mskCpfDeletar.Size = new System.Drawing.Size(139, 20);
            this.mskCpfDeletar.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "CPF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.mskCpfEditar);
            this.groupBox1.Location = new System.Drawing.Point(649, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.mskCpfDeletar);
            this.groupBox2.Location = new System.Drawing.Point(649, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 100);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deletar Cliente";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.mskWhatsapp);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskWhatsapp;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mskCpfEditar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskCpfDeletar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}