using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using Model.Entitidades;
using MapaSala.Formularios.Editar;
using MapaSala.Formularios.Adicionar;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
        DataTable dados;
        DisciplinaDAO dao = new DisciplinaDAO();

        public frmDisciplina()
        {
            InitializeComponent();
            dados = new DataTable();
            
            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }


            dtGridDisciplina.DataSource = dados;
            
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
        }

        private void frmDisciplina_Load(object sender, EventArgs e)
        {

        }

        private void dtGridDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dtGridDisciplina.Rows[e.RowIndex].Cells[0].Value);


                FrmEditarDisciplina editar = new FrmEditarDisciplina(id);

                
                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog(); 
            }
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {

            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
        }
        private void dtGridDisciplina_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dtGridDisciplina_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmAdicionarDisciplina adicionar = new FrmAdicionarDisciplina();
            adicionar.FormClosed += Fechou_Editar_FormClosed;

            adicionar.ShowDialog();
        }
    }
}
