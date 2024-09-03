using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades.NewFolder1
{
    class CursoDisciplinaEntidade
    {
        public int Id { get; set; }
        public int DisciplinaId{ get; set; }
        public int CursoId { get; set; }
        public string NomeCurso { get; set; }
        public string NomeDisciplina { get; set; }

        public Object[] Linha()
        {
            return new object[] { Id, NomeCurso, NomeDisciplina};
        }
    }
}
