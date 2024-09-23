using System;
using System.Data;
using System.Windows.Forms;
using Formulario.DAO;
using Model.Entidades;


namespace Formulario
{
    public partial class Cursos : Form
    {
        DataTable data;
        int LinhaSelecionada;
        DataGridViewCellCollection Cells;
        DataGridViewRow SelectedRow;
        CursosDAO conn;
        public Cursos()
        {
            InitializeComponent();
            data = new DataTable();
            conn = new CursosDAO();
            Table.DataSource = conn.Get();
            foreach(var attributes in typeof(CursosEntidade).GetProperties())
            {
                data.Columns.Add(attributes.Name);
            }
        }
        private CursosEntidade Cadastro
        {
            get
            {
                CursosEntidade curso = new CursosEntidade();
                curso.Id = (int)numId.Value;
                curso.Nome = txtNome.Text;
                curso.Ativo=chkAtivo.Checked;
                curso.Turno=txtTurno.Text;
                curso.Sigla=txtSigla.Text;
                return curso;
            }
            set
            {
                numId.Value = value.Id;
                txtNome.Text = value.Nome;
                txtSigla.Text = value.Sigla;
                txtTurno.Text = value.Turno;
                chkAtivo.Checked = value.Ativo;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            CursosEntidade curso = Cadastro;
            if (!curso.IsFull())
            {
                MessageBox.Show("Tem campo vazio aí!");
            }
            conn.InsertAndUpdateDataTable(Cadastro, ref Table);
            //data.Rows.Add(curso.Linha());
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSigla.Text = "";
            txtTurno.Text = "";
            chkAtivo.Checked = false;
        }
        private void UpdateSelectedCellsVar()
        {
            Cells= Table.Rows[LinhaSelecionada].Cells;
        }
        private void UpdateSelectedRowVar(){
            
            SelectedRow = Table.Rows[LinhaSelecionada];

        }
        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            UpdateSelectedCellsVar();
            DeleteRowBtn.Text = $"Excluir linha {LinhaSelecionada + 1}";
            CursosEntidade curso = new CursosEntidade();
            curso.Id = Convert.ToInt32(Cells[0].Value);
            curso.Nome = Cells[1].Value.ToString();
            curso.Sigla = Cells[2].Value.ToString();
            curso.Turno = Cells[3].Value.ToString();
            curso.Ativo = Convert.ToBoolean(Cells[4].Value);
            Cadastro = curso;

        }
        private void DeleteRowBtn_Click(object sender, EventArgs e) => conn.DeleteAndUpdateDataTable((int)numId.Value, ref Table);

        private void EditBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedRowVar();
            UpdateSelectedCellsVar();
            var curso = Cadastro;
            EditBtn.Text = $"Editar Linha Id:{curso.Id}";
            conn.UpdateAndUpdateDataTable(curso, ref Table);
        }

        private void SearchTbx_TextChanged(object sender, EventArgs e)
        {
            conn.SearchAndUpdateDataTable(SearchTbx.Text, ref Table);
        }

        private void Cursos_Load(object sender, EventArgs e)
        {

        }
    }
}
