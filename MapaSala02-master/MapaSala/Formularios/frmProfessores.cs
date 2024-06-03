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
    public partial class frmProfessores : Form
    {
        BindingSource dados;
        public frmProfessores()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridProfessores.DataSource = dados;
        }

        private void frmProfessores_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade professor = new ProfessoresEntidade();
            professor.Id = Convert.ToInt32(numId.Value);
            professor.Nome = txtNomeProf.Text;
            professor.Apelido = txtApelido.Text;
            dados.Add(professor);
        }
    }
}