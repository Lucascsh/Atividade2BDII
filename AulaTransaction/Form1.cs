﻿using System;
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
            "Initial Catalog="+ tBBancoCriar +";" +
            "User ID=" + tBUsuarioCriar.Text + ";" +
            "password=" + tBSenhaCriar.Text + ";" +
            "language=Portuguese";

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
    }
}
