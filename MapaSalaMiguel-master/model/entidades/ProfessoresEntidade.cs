using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades
{
    public class CursoDisciplinaEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int DisciplinaId { get; set; }
        public string NomeCurso { get; set; }
        public string NomeDisciplina { get; set; }
        public SqlDbType Periodo { get; set; }
        public SqlDbType CursoId { get; set; }

        public Object[] Linha()
        {
            return new object[] { Id, Nome, Apelido };
        }
    }
}
