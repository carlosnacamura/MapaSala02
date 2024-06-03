using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.Formularios;

namespace MapaSala
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalas s = new frmSalas();
            s.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessores p = new frmProfessores();
            p.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisciplinas d = new frmDisciplinas();
            d.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso c = new frmCurso();
            c.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios u = new frmUsuarios();
            u.ShowDialog();
        }
    }
}
