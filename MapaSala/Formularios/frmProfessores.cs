using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using MapaSala.Formularios.Adicionar;
using MapaSala.Formularios.Editar;
using MapaSala.Formularios.Excluir;
using model.entidades;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmProfessores : Form
    {
        DataTable dados;
        ProfessorDAO dao = new ProfessorDAO();
        public frmProfessores()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterProfessores();

            dtGridProfessores.DataSource = dados;
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridProfessores.DataSource = dao.ObterProfessores();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FrmAdicionarProfessor adicionar = new FrmAdicionarProfessor();
            adicionar.FormClosed += Fechou_Editar_FormClosed;

            adicionar.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
        }
    

       
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridProfessores.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }

        private void frmProfessores_Load(object sender, EventArgs e)
        {

        }

        private void dtGridProfessores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dtGridProfessores.Rows[e.RowIndex].Cells[0].Value);


                    FrmEditarProfessor editar = new FrmEditarProfessor(id);


                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog();
            }
        }

    }
}
