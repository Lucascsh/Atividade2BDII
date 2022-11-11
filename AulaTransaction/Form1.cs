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
            //bConsultar.Enabled = false;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            stringConec = "Data Source=localhost;" +
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
            }
        }
        public string getStringConec()
        {
            return stringConec;
        }

        private void button2_Click(object sender, EventArgs e)
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
                else
                {
                    MessageBox.Show("Conectado com Sucesso.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
            }

            DataTable dt = new DataTable();

            dt = bd.executaConsulta("select * from sys.databases");

            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();

            // dt = bd.executaConsulta("select * from pessoas " +
            //"where nome = '" + textBox4.Text + "'");

            dataGridView1.DataSource = dt;
        }

        private void tBUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
