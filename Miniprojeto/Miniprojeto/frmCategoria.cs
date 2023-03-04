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

namespace Miniprojeto
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        string stringConexao = " " +
           "Data Source = localhost;" +
           "Initial Catalog=N8_MINIPROJETO;" +
           "user ID=sa;" +
           "password=123456";

    
        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
                Application.Exit();               
            }
        
        
        }    
     




        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDrescicao.Text = "";
            txtNome.Text = "";
            txtObs.Text = "";
            cboStatus.Text = "0";
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            TestarConexao();

        }
 

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into categoria " +
                "(" + 
                    "nome_categoria," +
                    "descricao_categoria," +
                    "obs_categoria, " +
                    "status_categoria" +
                    ")" +
                    "values" + "(" +
                    " ' " + txtNome.Text + "'," +
                    " ' " + txtDrescicao.Text + "' , " +
                    " ' " + txtObs.Text + "' ," +
                    " ' " + cboStatus.Text + " ' " +
                    ") select scope_identity()";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura; 
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i>0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select* from categoria where id_categoria = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();
            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txtCodigo.Text = leitura    [0].ToString();
                    txtNome.Text = leitura [1] .ToString();
                    txtDrescicao.Text = leitura [2] .ToString();    
                    txtObs.Text = leitura [3] .ToString();
                    cboStatus.Text = leitura [4] .ToString();
                }
                else
                {
                    MessageBox.Show("Código não encontrado!");
                }
   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
            finally 
            { 
                conn.Close();
            
            }
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update categoria set " +
               " nome_categoria= ' " + txtNome.Text + "'," +
               " descricao_categoria= ' " + txtDrescicao.Text + "'," +
               " obs_categoria= ' " + txtObs.Text + "'," +
               " status_categoria= ' " + cboStatus.Text + "'" + 
                " where id_categoria='" + txtCodigo.Text + "'";
;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            try
            {   conn.Open(); 

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados alterado com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
           
           
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from categoria where id_categoria= " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                conn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados alterado com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }

        }
    }
}
