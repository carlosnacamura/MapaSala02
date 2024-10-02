using System;
using Model.Entitidades;
using System.Data.SqlClient;
using System.Data;

namespace MapaSala.DAO
{
    public class UsuariosDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        private object usuarios;

        public UsuariosDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(UsuariosEntidade usuario)
        {
            Conexao.Open();
            string query = "Insert into Usuario (Nome, Id, Login, Senha, Ativo) Values (@nome,@id, @login, @senha, @ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", usuario.Nome);
            SqlParameter parametro2 = new SqlParameter("@id", usuario.Id);
            SqlParameter parametro3 = new SqlParameter("@login", usuario.Login);
            SqlParameter parametro4 = new SqlParameter("@senha", usuario.Senha);
            SqlParameter parametro5 = new SqlParameter("@ativo", usuario.Ativo);
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

            string query = "SELECT Id, Nome FROM Usuarios";

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
        public DataTable ObterProfessores()
        {

            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM Usuarios order by Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(UsuariosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    UsuariosEntidade p = new UsuariosEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Login = Leitura[1].ToString();
                    p.Senha = Leitura[2].ToString();
                    p.Nome = Leitura[3].ToString();
                    p.Ativo = Convert.ToBoolean(Leitura[4]);

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
                query = "SELECT SELECT Id,Nome,Senha,Login FROM Usuarios order by Id desc FROM Usuarios order by Id desc";
            }
            else
            {
                query = $@"SELECT Id,Nome,Senha,Login FROM Usuarios
                           Where Id like '%{pesquisa}%' OR Nome LIKE '%{pesquisa}%' OR Senha LIKE '%{pesquisa}%' OR Login LIKE '%{pesquisa}%'
                           Order by Id desc";
            }



            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(UsuariosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    UsuariosEntidade u = new UsuariosEntidade();
                    u.Id = Convert.ToInt32(Leitura[0]);
                    u.Nome = Leitura[1].ToString();
                    u.Senha = Leitura[2].ToString();
                    u.Login = Leitura[3].ToString();
                    dt.Rows.Add(u.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }

    }
}