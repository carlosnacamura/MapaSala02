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
    public partial class frmDisciplina : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmDisciplina()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridDisciplina.DataSource = dados;
            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("231","Desenvonvilmento de Sistemas","DS",true);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinasEntidade disciplina = new DisciplinasEntidade();
            disciplina.ID = Convert.ToInt32(txtId.Text);
            disciplina.nome = txtNome.Text;
            disciplina.sigla = txtSigla.Text;
            disciplina.ativo = chkAtivo.Checked;
            dados.Rows.Add(disciplina.Linha());
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtNome.Text = "";
            txtId.Text = "";
            txtSigla.Text = "";
            chkAtivo.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtId.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtNome.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtSigla.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridDisciplina.Rows[LinhaSelecionada].Cells[3].Value);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows[LinhaSelecionada].Cells[0].Value = txtId.Text;
            dtGridDisciplina.Rows[LinhaSelecionada].Cells[1].Value = txtNome.Text;
            dtGridDisciplina.Rows[LinhaSelecionada].Cells[2].Value = txtSigla.Text;
            dtGridDisciplina.Rows[LinhaSelecionada].Cells[3].Value = chkAtivo.Checked;
        }

        private void FrmDisciplina_Load(object sender, EventArgs e)
        {

        }
    }
}
