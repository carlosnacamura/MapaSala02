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
    public partial class FrmAdicionarDisciplina : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public FrmAdicionarDisciplina()
        {
            InitializeComponent();
        }

        private void FrmAdicionarDisciplina_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "Insert into Disciplinas(Nome,Sigla,Ativo) Values (@nome, @sigla, @ativo)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNomeDisc.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkAtivo.Checked));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Disciplina Adicionada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

