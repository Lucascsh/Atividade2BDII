using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AulaTransaction
{
    internal class Banco
    {
        /*
            create database aula
            create table pessoas
            (
	            id integer primary key identity,
	            nome varchar(50) not null,
	            idade integer,
	            altura integer
            )

            create login usuario with password='senha1234';
            create user usuario from login usuario;
            exec sp_addrolemember 'DB_DATAREADER', 'usuario';
            exec sp_addrolemember 'DB_DATAWRITER', 'usuario'
         */

        private string conec = "";
        public void setConec(string conec)
        {
            this.conec = conec;
        }

        //ADO.Net
        private SqlConnection cn; 

        private void conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch(TimeoutException ex)
            {
                return null;
            }
            catch (AccessViolationException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable executaConsulta(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand comando = new SqlCommand(sql, cn);
                comando.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void executaComando(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand comando = new SqlCommand(sql, cn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
