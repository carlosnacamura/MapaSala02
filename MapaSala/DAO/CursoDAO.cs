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
    public class CursoDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public CursoDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(CursoEntidade objeto)
        {
            Conexao.Open();
            string query = "Insert into Cursos (Nome , Turno, Sigla, Ativo) Values (@nome, @turno, @sigla, @ativo) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@nome", objeto.Nome);
            SqlParameter parametro2 = new SqlParameter("@sigla", objeto.Sigla);
            SqlParameter parametro3 = new SqlParameter("@ativo", objeto.Ativo);
            SqlParameter parametro4 = new SqlParameter("@sigla", objeto.Turno);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);

            comando.ExecuteNonQuery();
            Conexao.Close();

        }

        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome FROM Cursos";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    // Preenche o DataTable com os dados da consulta
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Lida com erros, se necessário
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }

        public DataTable ObterDisciplinas()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM Cursos Order by Id desc";
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
                    CursoEntidade c = new CursoEntidade();
                    c.Id = Convert.ToInt32(Leitura[0]);
                    c.Nome = Leitura[1].ToString();
                    c.Turno = Leitura[2].ToString();
                    c.Sigla = Leitura[3].ToString();
                    c.Ativo = Convert.ToBoolean(Leitura[4]);
                    dt.Rows.Add(c.Linha());
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
                query = "SELECT Id,Nome,Turno,Sigla FROM Curso Order by Id desc";
            }
            else
            {
                query = $@"SELECT Id,Nome,Turno,Sigla FROM Curso
                           Where Nome like '%{pesquisa}%' OR Turno LIKE '%{pesquisa}%' OR Id LIKE '%{pesquisa}%' OR Sigla LIKE '%{pesquisa}%'
                           Order by Id desc";
            }



            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(CursoEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    CursoEntidade c = new CursoEntidade();
                    c.Id = Convert.ToInt32(Leitura[0]);
                    c.Nome = Leitura[1].ToString();
                    c.Turno = Leitura[2].ToString();
                    c.Sigla= Leitura[2].ToString();
                    dt.Rows.Add(c.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }
    }
}
