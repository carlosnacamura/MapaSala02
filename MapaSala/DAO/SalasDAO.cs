using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.DAO
{
    public class SalasDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public SalasDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(SalasEntidade objeto)
        {
            Conexao.Open();
            string query = "Insert into Salas (Nome , NumeroComputadores, NumeroCadeiras, IsLab, Disponivel) Values (@nome, @numerocomputadores, @numerocadeiras, @islab, @disponivel) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@nome", objeto.Nome);
            SqlParameter parametro2 = new SqlParameter("@numerocomputadores", objeto.NumeroComputadores);
            SqlParameter parametro3 = new SqlParameter("@numerocadeiras", objeto.NumeroCadeiras);
            SqlParameter parametro4 = new SqlParameter("@islab", objeto.IsLab);
            SqlParameter parametro5 = new SqlParameter("@disponivel", objeto.Disponivel);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);

            comando.ExecuteNonQuery();
            Conexao.Close();

        }

        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome FROM Salas";

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
            string query = "SELECT Id,Nome,NumeroCadeiras,NumeroComputadores Ativo FROM Cursos Order by Id desc";
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
                    SalasEntidade s = new SalasEntidade();
                    s.Id = Convert.ToInt32(Leitura[0]);
                    s.Nome = Leitura[1].ToString();
                    s.NumeroCadeiras = Convert.ToInt32(Leitura[2]);
                    s.NumeroComputadores= Convert.ToInt32(Leitura[3]);
                    s.IsLab = Convert.ToBoolean(Leitura[4]);
                    dt.Rows.Add(s.Linha());
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
                query = "SELECT Id, Nome, NumeroComputadores, NumeroCadeiras FROM Salas order by Id desc";
            }
            else
            {
                query = $@"SELECT Id, Nome, NumeroComputadores, NumeroCadeiras FROM Salas
                           Where Nome like '%{pesquisa}%' OR NumeroComputadores LIKE '%{pesquisa}%' OR NumeroCadeiras LIKE '%{pesquisa}%' OR Id LIKE '%{pesquisa}%'
                           Order by Id desc";
            }
            


            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    SalasEntidade s = new SalasEntidade();
                    s.Id = Convert.ToInt32(Leitura[0]);
                    s.Nome = Leitura[1].ToString();
                    s.NumeroCadeiras = Convert.ToInt32(Leitura[2]);
                    s.NumeroComputadores = Convert.ToInt32(Leitura[3]);
                    dt.Rows.Add(s.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }
    }
}
