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
    public partial class frmAlunos : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmAlunos()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridAlunos.DataSource = dados;
            foreach (var atributos in typeof(AlunoEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("1", "Carlos", "17", "18", true, "Estudante de C#");
            
        }
       


    private void chkboxVagas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AlunoEntidade aluno = new AlunoEntidade();
            aluno.ID = Convert.ToInt32(txtId.Text);
            aluno.nome = txtNome.Text;
            aluno.idade = Convert.ToInt32(txtIdade.Text);
            aluno.sala = Convert.ToInt32(txtSala.Text);
            aluno.apelido = txtApelido.Text;
            aluno.estudante = chkEstudante.Checked;
            dados.Rows.Add(aluno.Linha());
            limpar();
                }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtIdade.Text = "";
            txtApelido.Text = "";
            txtSala.Text = "";
            chkEstudante.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridAlunos.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtId.Text = dtGridAlunos.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtNome.Text = dtGridAlunos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
           
            txtIdade.Text =  dtGridAlunos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtSala.Text =  dtGridAlunos.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            chkEstudante.Checked = Convert.ToBoolean(dtGridAlunos.Rows[LinhaSelecionada].Cells[4].Value);
            txtApelido.Text = dtGridAlunos.Rows[LinhaSelecionada].Cells[5].Value.ToString();



        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
            dtGridAlunos.Rows[LinhaSelecionada].Cells[0].Value = txtId.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[1].Value = txtNome.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[2].Value = txtApelido.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[3].Value = txtIdade.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[4].Value = txtSala.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[5].Value = chkEstudante.Checked;

        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {

        }

        private void dtGridAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
