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

namespace MapaSala.Formularios.Adicionar
{
    public partial class FrmAdicionarSalas : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public FrmAdicionarSalas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdicionarSalas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "Insert into Salas(Nome,NumeroComputadores,NumeroCadeiras,IsLab,Disponivel) Values (@nome, @numcomp,@numcad,@islab,@disp)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@nome", txtNomeSala.Text));
            comando.Parameters.Add(new SqlParameter("@numcomp", numComputadores.Value));
            comando.Parameters.Add(new SqlParameter("@numcad", numCadeiras.Value));
            comando.Parameters.Add(new SqlParameter("@islab", chkLab.Checked));
            comando.Parameters.Add(new SqlParameter("@disp", chkDisp.Checked));



            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Sala Adicionada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao adicionar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
