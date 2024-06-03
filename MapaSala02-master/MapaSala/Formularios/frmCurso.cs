using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmCurso : Form
    {
        BindingSource dados;
        public frmCurso()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridCurso.DataSource = dados;
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CursoEntidade curso = new CursoEntidade();
            curso.Id = Convert.ToInt32(numId.Value);
            curso.Nome = txtNome.Text;
            curso.Turno = txtTurno.Text;
            curso.Ativo = chkAtivo.Checked;
            dados.Add(curso);
        }
    }
}
