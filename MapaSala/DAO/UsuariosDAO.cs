using System;
using Model.Entitidades;
using System.Data.SqlClient;
using System.Data;

namespace MapaSala.DAO
{
    public class UsuariosDAO
    {
        private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");
        private object usuarios;

        public UsuariosDAO()
        {
            Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");
        }
        public void Inserir(UsuariosEntidade usuario)
        {
            Conexao.Open();
            string query = "Insert into Usuario (Id, Login, Senha, Ativo) Values (@id, @login, @senha, @ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro2 = new SqlParameter("@id", usuario.Id);
            SqlParameter parametro3 = new SqlParameter("@login", usuario.Login);
            SqlParameter parametro4 = new SqlParameter("@senha", usuario.Senha);
            SqlParameter parametro5 = new SqlParameter("@ativo", usuario.Ativo);
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

            string query = "SELECT Id, Login FROM Usuarios";

            using (SqlConnection connection = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;"))
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
        public DataTable ObterUsuarios()
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
                query = "SELECT SELECT Id,Senha,Login FROM Usuarios order by Id desc FROM Usuarios order by Id desc";
            }
            else
            {
                query = $@"SELECT Id,Senha,Login FROM Usuarios
                           Where Id LIKE '%{pesquisa}%' OR Senha LIKE '%{pesquisa}%' OR Login LIKE '%{pesquisa}%'
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