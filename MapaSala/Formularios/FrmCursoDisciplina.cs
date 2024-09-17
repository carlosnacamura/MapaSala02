using System;
using System.Data;
using System.Windows.Forms;
using MapaSala.DAO;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class FrmCursoDisciplina : Form
    {
        DisciplinaDAO disciplinaDAO = new DisciplinaDAO();
        CursoDAO cursoDAO = new CursoDAO();
        CursoDisciplinaDAO dao = new CursoDisciplinaDAO();
        int LinhaSelecionada;
        private void AtualizaGrid(DataTable dados)
        {
            dtCursoDisciplina.DataSource = dados;
        }

        public FrmCursoDisciplina()
        {
            InitializeComponent();

            cbDisciplinas.DataSource = disciplinaDAO.PreencherComboBox();
            cbDisciplinas.DisplayMember = "Nome";
            cbDisciplinas.ValueMember = "Id";

            cbxCursos.DataSource = cursoDAO.PreencherComboBox();
            cbxCursos.DisplayMember = "Nome";
            cbxCursos.ValueMember = "Id";

            AtualizaGrid(dao.ObterCursoDisciplina());
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {

            CursoDisciplinaDAO cursoDisciplinaDao = new CursoDisciplinaDAO();

            CursoDisciplinaEntidade entidade = new CursoDisciplinaEntidade();

            entidade.CursoId = Convert.ToInt32(cbxCursos.SelectedValue);
            entidade.DisciplinaId = Convert.ToInt32(cbDisciplinas.SelectedValue);
            entidade.Periodo = cbPeriodos.SelectedItem.ToString();

            cursoDisciplinaDao.Inserir(entidade);

            AtualizaGrid(dao.ObterCursoDisciplina());

        }

        private void FrmCursoDisciplina_Load(object sender, EventArgs e)
        {

        }

        private void dtCursoDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            cbDisciplinas.SelectedValue = dtCursoDisciplina.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            cbPeriodos.SelectedValue = dtCursoDisciplina.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            cbxCursos.SelectedValue = Convert.ToInt32(dtCursoDisciplina.Rows[LinhaSelecionada].Cells[0].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtCursoDisciplina.Rows.RemoveAt(LinhaSelecionada);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtCursoDisciplina.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }
    }
}