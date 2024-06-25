using model.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSalaMiguel.formularios
{
    public partial class frmCursos : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmCursos()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridCursos.DataSource = dados;
            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("321","DS","2024","Integral", true);
            

        }

        private void chkboxVagas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CursosEntidade cursos = new CursosEntidade(); 
            cursos.Id = Convert.ToInt32(txtId.Text);
            cursos.Nome = txtNome.Text;
            cursos.Ano = Convert.ToInt32(txtAno.Text);
            cursos.Periodo = txtPeriodo.Text;
            cursos.Vagas = chkVagas.Checked;
            dados.Rows.Add(cursos.Linha());
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtId.Text = "";
            txtAno.Text = "";
            txtNome.Text = "";
            txtPeriodo.Text = "";
            chkVagas.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridCursos.Rows.RemoveAt(LinhaSelecionada);

        }

        private void dtGridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtId.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtNome.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtAno.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtPeriodo.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            chkVagas.Checked = Convert.ToBoolean(dtGridCursos.Rows[LinhaSelecionada].Cells[4].Value);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value = txtId.Text;
            dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value = txtNome.Text;
            dtGridCursos.Rows[LinhaSelecionada].Cells[2].Value = txtAno.Text;
            dtGridCursos.Rows[LinhaSelecionada].Cells[3].Value = txtPeriodo.Text;
            dtGridCursos.Rows[LinhaSelecionada].Cells[4].Value = chkVagas.Checked;

        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
