using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entitidades;

namespace MapaSala.DAO
{
    public class DisciplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public DisciplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(DisciplinaEntidade disciplina)
        {
            Conexao.Open();
            string query = "Insert into Disciplinas (Nome , Sigla) Values (@nome, @sigla) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@nome", disciplina.Nome);
            SqlParameter parametro2 = new SqlParameter("@sigla", disciplina.Sigla);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);

            comando.ExecuteNonQuery();
            Conexao.Close();

        }

       

        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome FROM Disciplinas";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }



        public DataTable ObterDisciplinas()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Sigla FROM Disciplinas Order by Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    DisciplinaEntidade p = new DisciplinaEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Sigla = Leitura[2].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
         public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT id, Nome, Sigla FROM Disciplinas order by Id desc";
            }
            else
            {
                query = $@"SELECT id, Nome, Sigla FROM Disciplinas 
                           Where Nome like '%{pesquisa}%' OR Sigla LIKE '%{pesquisa}%' OR Id LIKE '%{pesquisa}%'
                           Order by Id desc";
            }
            


            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    DisciplinaEntidade d = new DisciplinaEntidade();
                    d.Id = Convert.ToInt32(Leitura[0]);
                    d.Nome = Leitura[1].ToString();
                    d.Sigla = Leitura[2].ToString();
                    dt.Rows.Add(d.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }
    }
}
