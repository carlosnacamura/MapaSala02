﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.Entitidades;
using System.Data;

namespace MapaSala.DAO
{
    public class ProfessorDAO
    {
        // "LS05MPF" servidor em rede; "Localhost" próprio PC
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;

        public ProfessorDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string query = "Insert into Professores (Nome, Apelido) Values (@nome,@apelido)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome",professor.Nome);
            SqlParameter parametro2 = new SqlParameter("@apelido", professor.Apelido);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable ObterProfessor()
        {
            Conexao.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Professores ORDER BY ID desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader reader = comando.ExecuteReader();

            dt.Load(reader);

            reader.Close();
            Conexao.Close();

  
            return dt;
        }


    }
}
