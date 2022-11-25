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
            this.bLogin = new System.Windows.Forms.Button();
            this.bListarLogins = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cBPerm = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBUsuarioPerm = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tBBancoPerm = new System.Windows.Forms.TextBox();
            this.tBTabelaPerm = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bPerm = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cBComm = new System.Windows.Forms.ComboBox();
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
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(380, 491);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bConsultar
            // 
            this.bConsultar.Location = new System.Drawing.Point(12, 175);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(88, 38);
            this.bConsultar.TabIndex = 8;
            this.bConsultar.Text = "Listar bases de dados";
            this.bConsultar.UseVisualStyleBackColor = true;
            this.bConsultar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tBLoginCriar
            // 
            this.tBLoginCriar.Location = new System.Drawing.Point(573, 26);
            this.tBLoginCriar.Name = "tBLoginCriar";
            this.tBLoginCriar.Size = new System.Drawing.Size(100, 20);
            this.tBLoginCriar.TabIndex = 12;
            this.tBLoginCriar.TextChanged += new System.EventHandler(this.tBLoginCriar_TextChanged);
            // 
            // tBSenhaCriar
            // 
            this.tBSenhaCriar.Location = new System.Drawing.Point(573, 64);
            this.tBSenhaCriar.Name = "tBSenhaCriar";
            this.tBSenhaCriar.Size = new System.Drawing.Size(100, 20);
            this.tBSenhaCriar.TabIndex = 13;
            this.tBSenhaCriar.TextChanged += new System.EventHandler(this.tBSenhaCriar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login(criar)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Senha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bCriarUsuario
            // 
            this.bCriarUsuario.Location = new System.Drawing.Point(573, 256);
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
            this.bCriarLogin.Location = new System.Drawing.Point(573, 90);
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
            this.tBVinculaLogin.Location = new System.Drawing.Point(573, 230);
            this.tBVinculaLogin.Name = "tBVinculaLogin";
            this.tBVinculaLogin.Size = new System.Drawing.Size(100, 20);
            this.tBVinculaLogin.TabIndex = 25;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(11, 136);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 6;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bListarLogins
            // 
            this.bListarLogins.Enabled = false;
            this.bListarLogins.Location = new System.Drawing.Point(11, 227);
            this.bListarLogins.Name = "bListarLogins";
            this.bListarLogins.Size = new System.Drawing.Size(88, 23);
            this.bListarLogins.TabIndex = 26;
            this.bListarLogins.Text = "Listar logins";
            this.bListarLogins.UseVisualStyleBackColor = true;
            this.bListarLogins.Click += new System.EventHandler(this.bListarLogins_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Permissões";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cBPerm
            // 
            this.cBPerm.FormattingEnabled = true;
            this.cBPerm.Items.AddRange(new object[] {
            "grant",
            "deny",
            "revoke"});
            this.cBPerm.Location = new System.Drawing.Point(11, 319);
            this.cBPerm.Name = "cBPerm";
            this.cBPerm.Size = new System.Drawing.Size(100, 21);
            this.cBPerm.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Usuario";
            // 
            // tBUsuarioPerm
            // 
            this.tBUsuarioPerm.Location = new System.Drawing.Point(11, 282);
            this.tBUsuarioPerm.Name = "tBUsuarioPerm";
            this.tBUsuarioPerm.Size = new System.Drawing.Size(100, 20);
            this.tBUsuarioPerm.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Banco de Dados";
            // 
            // tBBancoPerm
            // 
            this.tBBancoPerm.Location = new System.Drawing.Point(11, 400);
            this.tBBancoPerm.Name = "tBBancoPerm";
            this.tBBancoPerm.Size = new System.Drawing.Size(100, 20);
            this.tBBancoPerm.TabIndex = 32;
            // 
            // tBTabelaPerm
            // 
            this.tBTabelaPerm.Location = new System.Drawing.Point(11, 439);
            this.tBTabelaPerm.Name = "tBTabelaPerm";
            this.tBTabelaPerm.Size = new System.Drawing.Size(100, 20);
            this.tBTabelaPerm.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Tabela";
            // 
            // bPerm
            // 
            this.bPerm.Location = new System.Drawing.Point(11, 480);
            this.bPerm.Name = "bPerm";
            this.bPerm.Size = new System.Drawing.Size(99, 23);
            this.bPerm.TabIndex = 35;
            this.bPerm.Text = "Gerar Permissões";
            this.bPerm.UseVisualStyleBackColor = true;
            this.bPerm.Click += new System.EventHandler(this.bPerm_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Comando";
            // 
            // cBComm
            // 
            this.cBComm.FormattingEnabled = true;
            this.cBComm.Items.AddRange(new object[] {
            "select",
            "insert",
            "update",
            "delete"});
            this.cBComm.Location = new System.Drawing.Point(12, 360);
            this.cBComm.Name = "cBComm";
            this.cBComm.Size = new System.Drawing.Size(99, 21);
            this.cBComm.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 523);
            this.Controls.Add(this.cBComm);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bPerm);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tBTabelaPerm);
            this.Controls.Add(this.tBBancoPerm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tBUsuarioPerm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cBPerm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bListarLogins);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBSenha;
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
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bListarLogins;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBPerm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBUsuarioPerm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBBancoPerm;
        private System.Windows.Forms.TextBox tBTabelaPerm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bPerm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cBComm;
    }
}

