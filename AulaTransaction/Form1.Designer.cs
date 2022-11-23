namespace AulaTransaction
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBSenha = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bConsultar = new System.Windows.Forms.Button();
            this.tBLoginCriar = new System.Windows.Forms.TextBox();
            this.tBSenhaCriar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bCriarUsuario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBServidor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBBancoCriar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBUsuarioCriar = new System.Windows.Forms.TextBox();
            this.bCriarLogin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tBVinculaLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBUsuario
            // 
            this.tBUsuario.Location = new System.Drawing.Point(12, 67);
            this.tBUsuario.Name = "tBUsuario";
            this.tBUsuario.Size = new System.Drawing.Size(118, 20);
            this.tBUsuario.TabIndex = 0;
            this.tBUsuario.Text = "super";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario (login)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // tBSenha
            // 
            this.tBSenha.Location = new System.Drawing.Point(11, 106);
            this.tBSenha.Name = "tBSenha";
            this.tBSenha.Size = new System.Drawing.Size(118, 20);
            this.tBSenha.TabIndex = 2;
            this.tBSenha.Text = "123456";
            this.tBSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(11, 157);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 6;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(380, 360);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bConsultar
            // 
            this.bConsultar.Location = new System.Drawing.Point(11, 198);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(88, 38);
            this.bConsultar.TabIndex = 8;
            this.bConsultar.Text = "Listar bases de dados";
            this.bConsultar.UseVisualStyleBackColor = true;
            this.bConsultar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tBLoginCriar
            // 
            this.tBLoginCriar.Location = new System.Drawing.Point(579, 26);
            this.tBLoginCriar.Name = "tBLoginCriar";
            this.tBLoginCriar.Size = new System.Drawing.Size(100, 20);
            this.tBLoginCriar.TabIndex = 12;
            this.tBLoginCriar.TextChanged += new System.EventHandler(this.tBLoginCriar_TextChanged);
            // 
            // tBSenhaCriar
            // 
            this.tBSenhaCriar.Location = new System.Drawing.Point(579, 65);
            this.tBSenhaCriar.Name = "tBSenhaCriar";
            this.tBSenhaCriar.Size = new System.Drawing.Size(100, 20);
            this.tBSenhaCriar.TabIndex = 13;
            this.tBSenhaCriar.TextChanged += new System.EventHandler(this.tBSenhaCriar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login(criar)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Senha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bCriarUsuario
            // 
            this.bCriarUsuario.Location = new System.Drawing.Point(576, 256);
            this.bCriarUsuario.Name = "bCriarUsuario";
            this.bCriarUsuario.Size = new System.Drawing.Size(75, 23);
            this.bCriarUsuario.TabIndex = 16;
            this.bCriarUsuario.Text = "Criar usuário";
            this.bCriarUsuario.UseVisualStyleBackColor = true;
            this.bCriarUsuario.Click += new System.EventHandler(this.bCriarUsuario_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Servidor";
            // 
            // tBServidor
            // 
            this.tBServidor.Location = new System.Drawing.Point(12, 26);
            this.tBServidor.Name = "tBServidor";
            this.tBServidor.Size = new System.Drawing.Size(118, 20);
            this.tBServidor.TabIndex = 18;
            this.tBServidor.Text = "localhost";
            this.tBServidor.TextChanged += new System.EventHandler(this.tBServidor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Banco de Dados";
            // 
            // tBBancoCriar
            // 
            this.tBBancoCriar.Location = new System.Drawing.Point(573, 152);
            this.tBBancoCriar.Name = "tBBancoCriar";
            this.tBBancoCriar.Size = new System.Drawing.Size(100, 20);
            this.tBBancoCriar.TabIndex = 20;
            this.tBBancoCriar.Text = "db_jogos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Usuário(criar)";
            // 
            // tBUsuarioCriar
            // 
            this.tBUsuarioCriar.Location = new System.Drawing.Point(573, 191);
            this.tBUsuarioCriar.Name = "tBUsuarioCriar";
            this.tBUsuarioCriar.Size = new System.Drawing.Size(100, 20);
            this.tBUsuarioCriar.TabIndex = 22;
            // 
            // bCriarLogin
            // 
            this.bCriarLogin.Location = new System.Drawing.Point(576, 91);
            this.bCriarLogin.Name = "bCriarLogin";
            this.bCriarLogin.Size = new System.Drawing.Size(72, 23);
            this.bCriarLogin.TabIndex = 23;
            this.bCriarLogin.Text = "Criar Login";
            this.bCriarLogin.UseVisualStyleBackColor = true;
            this.bCriarLogin.Click += new System.EventHandler(this.bCriarLogin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(573, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Login Vinculado";
            // 
            // tBVinculaLogin
            // 
            this.tBVinculaLogin.Location = new System.Drawing.Point(576, 230);
            this.tBVinculaLogin.Name = "tBVinculaLogin";
            this.tBVinculaLogin.Size = new System.Drawing.Size(97, 20);
            this.tBVinculaLogin.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 384);
            this.Controls.Add(this.tBVinculaLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bCriarLogin);
            this.Controls.Add(this.tBUsuarioCriar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBBancoCriar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBServidor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bCriarUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBSenhaCriar);
            this.Controls.Add(this.tBLoginCriar);
            this.Controls.Add(this.bConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBSenha;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bConsultar;
        private System.Windows.Forms.TextBox tBLoginCriar;
        private System.Windows.Forms.TextBox tBSenhaCriar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bCriarUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBServidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBBancoCriar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBUsuarioCriar;
        private System.Windows.Forms.Button bCriarLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBVinculaLogin;
    }
}

