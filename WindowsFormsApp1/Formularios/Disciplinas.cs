using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formulario.DAO;
using Model.Entidades;

namespace Formulario
{
    public partial class DisciplinasEntidade : Form
    {
        private DataTable data;
        private int LinhaSelecionada;
        private DataGridViewRow CurrentRow;
        private string NomePlaceholder, SiglaPlaceholder;
        private DAOAbstract<DisciplinaEntidade> conn;
        public DisciplinasEntidade()
        {
            InitializeComponent();
            conn = new DisciplinasDAO();
            data = new DataTable();
            Table.DataSource = data;
            foreach(var attributes in typeof(DisciplinaEntidade).GetProperties())
            {
                data.Columns.Add(attributes.Name);
            }
            SetPlaceholders();
        }
        private void SetPlaceholders()
        {
            NomePlaceholder = txtNome.Text;
            SiglaPlaceholder = txtSigla.Text;
        }

        private void ClearFields()
        {
            txtNome.Text = "Nome";
            txtSigla.Text = "Sigla";
            numId.Value = 0;
        }

        private void Placeholder(TextBox textBox, String placeholder_value)
        {
            String textBox_text = textBox.Text;

            if (textBox_text == placeholder_value)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            else if (textBox_text == "")
            {
                textBox.Text = placeholder_value;
                textBox.ForeColor = Color.Gray;
            }
        }

        private DisciplinaEntidade Cadastro{
            get{
            DisciplinaEntidade disciplina;
            disciplina = new DisciplinaEntidade();
            disciplina.Id= Convert.ToInt32(numId.Value);
            disciplina.Nome= txtNome.Text;
            disciplina.Sigla= txtSigla.Text;
            return disciplina;
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {

        }
        private void SetFieldsValues(DisciplinaEntidade disciplina){
            txtNome.Text=disciplina.Nome;
            txtSigla.Text=disciplina.Sigla;
            numId.Value=disciplina.Id;
        }
        private DisciplinaEntidade MakeObjectDisciplinasEntidade(DataGridViewRow Rows){
            DataGridViewCellCollection Cells= Rows.Cells;
             DisciplinaEntidade disciplina = new DisciplinaEntidade();
            disciplina.Id= Convert.ToInt32(Cells[0].Value);
            disciplina.Nome = Cells[1].Value.ToString();
            disciplina.Sigla = Cells[2].Value.ToString();


            return disciplina;
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            CurrentRow = Table.Rows[LinhaSelecionada];
            DeleteRowBtn.Text = $"Excluir linha {LinhaSelecionada+1}";
            DisciplinaEntidade disciplina = MakeObjectDisciplinasEntidade(CurrentRow);
            SetFieldsValues(disciplina);
        }

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            data.Rows[LinhaSelecionada].Delete();
            conn.DeleteAndUpdateDataTable(Cadastro.Id, ref Table);
        }

        private void EditRowBtn_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade disciplina = Cadastro;
            if (CurrentRow == null || !disciplina.IsFull())
            {
                return;
            }
            CurrentRow.SetValues(disciplina.Linha());
        }


        private void SearchTbx_TextChanged(object sender, EventArgs e)
        {
            conn.SearchAndUpdateDataTable(SearchTbx.Text, ref Table);

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();

        }
    }
}
