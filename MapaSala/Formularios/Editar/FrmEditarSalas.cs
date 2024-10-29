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

namespace MapaSala.Formularios.Editar
{
    public partial class FrmEditarSalas : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;

        public FrmEditarSalas(int SalaId)
        {
            InitializeComponent();

            string query = "select Id, Nome, NumeroComputadores, NumeroCadeiras,IsLab,Disponivel from Salas where Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@id", SalaId));

            SqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    lblId.Text = Leitura[0].ToString();
                    txtNomeSala.Text = Leitura[1].ToString();
                    numComp.Value = Convert.ToInt32(Leitura[2]);
                    numCad.Value = Convert.ToInt32(Leitura[3]);
                    chkDisp.Checked = Convert.ToBoolean(Leitura[4]);
                    chkAtivo.Checked = Convert.ToBoolean(Leitura[5]);

                }
            }
            Conexao.Close();
        }

        private void FrmEditarSalas_Load(object sender, EventArgs e)
        {

        }
    }
}
