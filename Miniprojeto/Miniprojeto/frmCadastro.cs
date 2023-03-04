using System.Data;
using System.Data.SqlClient;




namespace Miniprojeto
{


    public partial class frmCadastro : Form
    {
        public frmCadastro()
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
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();


            }
        }

            private void Form1_Load(object sender, EventArgs e)
        
            { 
                TestarConexao();
            }
        

        private void btoSair_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            mskcpf.Text = "";
            cbxStatus.Text = "";
            txtObs.Text = "";


        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into usuario"  + "(" +
                "nome_usuario," +
                "login_usuario," +
                "senha_usuario," +
                "cpf_usuario," +
                "obs_usuario," +
                "status_usuario" +
                ") " +

                "values" +
                "(" +
                "'"+txtNome.Text + "'," +
                "'"+ txtLogin.Text + "',"+
                "'"+ txtSenha.Text + "',"+
                "'"+ mskcpf.Text + "',"+
                "'"+ txtObs.Text + "',"+
                "'"+ cbxStatus.Text + "'"+                
                ")";
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand (sql,conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i= cmd.ExecuteNonQuery();
                if (i>0)
                {
                    MessageBox.Show("cadastro realizado com Sucesso");
                }
                    


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());

            }
            finally
            { 
                conn.Close();
            }
        }
    }
}