using MapaSala.Formularios;
using MapaSalaMiguel.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSalaMiguel
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalas s = new frmSalas();
            s.ShowDialog();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessor s = new frmProfessor();
            s.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioUsuarios s = new FormularioUsuarios();
            s.ShowDialog();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisciplina s = new frmDisciplina();
            s.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos s = new frmCursos();
            s.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunos s = new frmAlunos();
            s.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
