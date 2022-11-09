using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaTransaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bConsultar.Enabled = false;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {

            Pessoa p = new Pessoa();
            p.nome = tBUsuario.Text;
            Banco.setConec("Data Source=localhost;" +
            "Initial Catalog=aula;" +
            "User ID=" + usuario + ";" +
            "password=123456;" +
            "language=Portuguese");

            if (p.gravar())
            {
                MessageBox.Show("Gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao gravar.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();

            dt = bd.executaConsulta("select * from pessoas");

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
    }
}
