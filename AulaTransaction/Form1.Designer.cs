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
            this.tBBanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bBancos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBUsuario
            // 
            this.tBUsuario.Location = new System.Drawing.Point(12, 28);
            this.tBUsuario.Name = "tBUsuario";
            this.tBUsuario.Size = new System.Drawing.Size(118, 20);
            this.tBUsuario.TabIndex = 0;
            this.tBUsuario.Text = "super";
            this.tBUsuario.TextChanged += new System.EventHandler(this.tBUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario (login)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // tBSenha
            // 
            this.tBSenha.Location = new System.Drawing.Point(12, 67);
            this.tBSenha.Name = "tBSenha";
            this.tBSenha.Size = new System.Drawing.Size(118, 20);
            this.tBSenha.TabIndex = 2;
            this.tBSenha.Text = "123456";
            this.tBSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(11, 111);
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
            this.dataGridView1.Size = new System.Drawing.Size(509, 360);
            this.dataGridView1.TabIndex = 7;
            // 
            // bConsultar
            // 
            this.bConsultar.Location = new System.Drawing.Point(11, 140);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(88, 38);
            this.bConsultar.TabIndex = 8;
            this.bConsultar.Text = "Listar bases de dados";
            this.bConsultar.UseVisualStyleBackColor = true;
            this.bConsultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBBanco
            // 
            this.tBBanco.Location = new System.Drawing.Point(11, 224);
            this.tBBanco.Name = "tBBanco";
            this.tBBanco.Size = new System.Drawing.Size(100, 20);
            this.tBBanco.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome do banco";
            // 
            // bBancos
            // 
            this.bBancos.Location = new System.Drawing.Point(11, 251);
            this.bBancos.Name = "bBancos";
            this.bBancos.Size = new System.Drawing.Size(81, 23);
            this.bBancos.TabIndex = 11;
            this.bBancos.Text = "Listar tabelas";
            this.bBancos.UseVisualStyleBackColor = true;
            this.bBancos.Click += new System.EventHandler(this.bBancos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 384);
            this.Controls.Add(this.bBancos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBBanco);
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
        private System.Windows.Forms.TextBox tBBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBancos;
    }
}

