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
    public partial class frmProfessor : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmProfessor()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridProfessor.DataSource = dados;
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("768","Fernando","Fram");
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtboxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade professor = new ProfessoresEntidade();
            professor.Id = Convert.ToInt32(txtId.Text);
            professor.Nome = txtNome.Text;
            professor.Apelido = txtApelido.Text;
            dados.Rows.Add(professor.Linha());
            limpar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            limpar();
        }
        private void limpar()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtApelido.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridProfessor.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtId.Text = dtGridProfessor.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtNome.Text = dtGridProfessor.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtApelido.Text = dtGridProfessor.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dtGridProfessor.Rows[LinhaSelecionada].Cells[0].Value = txtId.Text;
            dtGridProfessor.Rows[LinhaSelecionada].Cells[1].Value = txtNome.Text;
            dtGridProfessor.Rows[LinhaSelecionada].Cells[2].Value = txtApelido.Text;
            
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {

        }
    }
}
