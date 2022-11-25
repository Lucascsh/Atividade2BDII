using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaTransaction
{
    public partial class Form1 : Form
    {
        private string stringConec;
        public Form1()
        {
            InitializeComponent();
            bConsultar.Enabled = false;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            stringConec = "Data Source=" + tBServidor.Text + ";" +
            "Initial Catalog=master;" +
            "User ID=" + tBUsuario.Text + ";" +
            "password=" + tBSenha.Text + ";" +
            "language=Portuguese";

            try
            {
                bd.setConec(stringConec);
                SqlConnection cn = bd.abrirConexao();
                if (cn == null)
                {
                    MessageBox.Show("Erro ao conectar com o banco!");
                }
                else
                {
                    MessageBox.Show("Conectado com Sucesso.");
                }
                bConsultar.Enabled = true;
                bListarLogins.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            try
            {
                bd.setConec(stringConec);
                SqlConnection cn = bd.abrirConexao();
                if (cn == null)
                {
                    MessageBox.Show("Erro ao conectar com o banco!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
            }

            DataTable dt = new DataTable();

            dt = bd.executaConsulta("select name, database_id, create_date from sys.databases;");

            dataGridView1.DataSource = dt;

            bd.fecharConexao();
        }

        private void tBUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Banco bd = new Banco();

                stringConec = "Data Source=" + tBServidor.Text + ";" +
                "Initial Catalog=" + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + ";" +
                "User ID=" + tBUsuario.Text + ";" +
                "password=" + tBSenha.Text + ";" +
                "language=Portuguese";

                try
                {
                    bd.setConec(stringConec);
                    SqlConnection cn = bd.abrirConexao();
                    if (cn == null)
                    {
                        MessageBox.Show("Erro ao conectar com o banco!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
                }

                DataTable dt = new DataTable();

                dt = bd.executaConsulta("SELECT table_catalog, table_name FROM information_schema.tables;");

                dataGridView1.DataSource = dt;

                bd.fecharConexao();
            }
        }

        private void tBServidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCriarUsuario_Click(object sender, EventArgs e)
        {
            stringConec = "Data Source=" + tBServidor.Text + ";" +
            "Initial Catalog=" + tBBancoCriar.Text + ";" +
            "User ID=sa;" +
            "password=laboratorio;" +
            "language=Portuguese";

            Banco bd = new Banco();

            try
            {
                bd.setConec(stringConec);
                SqlConnection cn = bd.abrirConexao();
                bd.executaComando("create user " + tBUsuarioCriar.Text + " for login " + tBVinculaLogin.Text);
                if (cn == null)
                {
                    MessageBox.Show("Erro ao conectar com o banco!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
            }

            bd.fecharConexao();
        }

        private void tBLoginCriar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tBSenhaCriar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bCriarLogin_Click(object sender, EventArgs e)
        {
            stringConec = "Data Source=" + tBServidor.Text + ";" +
            "Initial Catalog=master;" +
            "User ID=" + tBUsuario.Text + ";" +
            "password=" + tBSenha.Text + ";" +
            "language=Portuguese";

            Banco bd = new Banco();

            try
            {
                bd.setConec(stringConec);
                SqlConnection cn = bd.abrirConexao();
                if (cn == null)
                {
                    MessageBox.Show("Erro ao conectar com o banco 1!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco 2: " + ex.Message);
            }

            bd.executaComando("create login " + tBLoginCriar.Text + " with password =\'" + tBSenhaCriar.Text + "\', " +
                "default_database = master, " +
                "check_expiration = off, " +
                "check_policy = off");
            bd.fecharConexao();
        }

        private void bListarLogins_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            try
            {
                bd.setConec(stringConec);
                SqlConnection cn = bd.abrirConexao();
                if (cn == null)
                {
                    MessageBox.Show("Erro ao conectar com o banco!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
            }

            DataTable dt = new DataTable();

            dt = bd.executaConsulta("select name, is_disabled, create_date from sys.sql_logins");

            dataGridView1.DataSource = dt;

            bd.fecharConexao();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bPerm_Click(object sender, EventArgs e)
        {
            stringConec = "Data Source=" + tBServidor.Text + ";" +
            "Initial Catalog=" + tBBancoPerm.Text + ";" +
            "User ID=sa;" +
            "password=laboratorio;" +
            "language=Portuguese";
            
            Banco bd = new Banco();

            try
            {
                //--deny select on disciplinas to username
                bd.setConec(stringConec);
                SqlConnection cn = bd.abrirConexao();
                bd.executaComando(cBPerm.Items[cBPerm.SelectedIndex].ToString() + " " + cBComm.Items[cBComm.SelectedIndex].ToString() + " on " + tBTabelaPerm.Text + " to " + tBUsuarioPerm.Text);
                if (cn == null)
                {
                    MessageBox.Show("Erro ao conectar com o banco 1!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco 2: " + ex.Message);
            }

            bd.fecharConexao();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

