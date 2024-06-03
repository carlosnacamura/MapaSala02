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
    public partial class frmDisciplinas : Form
    {
        BindingSource dados;
        public frmDisciplinas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridDisciplinas.DataSource = dados;
        }

        private void frmDisciplinas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinasEntidade disciplina = new DisciplinasEntidade();
            disciplina.Id = Convert.ToInt32(numId.Value);
            disciplina.Nome = txtNome.Text;
            disciplina.Sigla = txtSigla.Text;
            disciplina.Ativo = chkAtivo.Checked;
            dados.Add(disciplina);
        }

        private void dtGridDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
