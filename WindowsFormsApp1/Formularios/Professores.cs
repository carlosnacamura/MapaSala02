using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Model.Entidades;
using Formulario.DAO;


namespace Formulario
{
    public partial class Professores : Form
    {
        private ProfessorDAO conn;
        int LinhaSelecionada;

        public Professores()
        {
            InitializeComponent();
            conn = new ProfessorDAO();
            Table.DataSource = conn.Get();
        }
        string NomePlaceholder="Nome ";
        string ApelidoPlaceholder = "Apelido";
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
        private void ClearFields()
        {
            txtNome.Text = NomePlaceholder;
            txtNome.ForeColor = Color.Gray;
            txtApelido.Text = ApelidoPlaceholder;
            txtApelido.ForeColor = Color.Gray;
        }
        private bool DataIsCorrectly()
        {
            if (txtNome.Text == NomePlaceholder || txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo corretamente");
                return false;
            }

            if (txtApelido.Text == ApelidoPlaceholder || txtApelido.Text == "") {
                MessageBox.Show("Preencha o campo apelido corretamente");
                return false;
            }
            return true;
        }
        private ProfessoresEntidade Cadastro{
            get{
            ProfessoresEntidade professor = new ProfessoresEntidade();
            professor.Nome = txtNome.Text;
            professor.Apelido = txtApelido.Text;
            return professor;
            }
            set
            {
                txtNome.Text = value.Nome;
                txtApelido.Text = value.Apelido;
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
                if (!DataIsCorrectly()) 
                {
                MessageBox.Show("Dados não preenchidos");
                return;
                }
            ProfessoresEntidade professor = Cadastro;
            conn.InsertAndUpdateDataTable(professor,ref Table);
            ClearFields();

        }
        private void SetFields(ProfessoresEntidade professor)
        {
            txtNome.Text = professor.Nome;
            txtApelido.Text = professor.Apelido;
        }
        private void NomeEbx_Enter(object sender, EventArgs e)
        {
            Placeholder(txtNome, NomePlaceholder);
        }

        private void ApelidoTbx(object sender, EventArgs e)
        {
            //Placeholder(ApelidoTbx, ApelidoPlaceholder);
        }

        private void ApelidoTbx_Enter(object sender, EventArgs e)
        {
            //Placeholder(ApelidoTbx, ApelidoPlaceholder);

        }

        private void NomeEb_Leave(object sender, EventArgs e)
        {
            Placeholder(txtNome, NomePlaceholder);

        }

        private void ApelidoTbxx_Leave(object sender, EventArgs e)
        {
            Placeholder(txtApelido, ApelidoPlaceholder);
        }

        private void ApelidoTbxx_Enter(object sender, EventArgs e)
        {
            Placeholder(txtApelido, ApelidoPlaceholder);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();

        }


        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            Table.Rows.RemoveAt(LinhaSelecionada);
            DeleteRowBtn.Text = $"Excluir registro id: {Cadastro.Id}";
            conn.DeleteAndUpdateDataTable(Cadastro.Id, ref Table);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            conn.UpdateAndUpdateDataTable(Cadastro, ref Table);
        }

        private void DtGridProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            DeleteRowBtn.Text = $"Deletar linha {LinhaSelecionada + 1}";
            EditBtn.Text = $"Editar linha {LinhaSelecionada + 1}";
            DataGridViewCellCollection cells = Table.Rows[LinhaSelecionada].Cells;
            ProfessoresEntidade professor = new ProfessoresEntidade();
            professor.Id = Convert.ToInt32(cells[0].Value);
            professor.Nome=cells[1].Value.ToString();
            professor.Apelido=cells[2].Value.ToString();
            SetFields(professor);
        }


        private void SearchTbx_TextChanged(object sender, EventArgs e)
        {
            conn.SearchAndUpdateDataTable(SearchTbx.Text, ref Table);

        }

        private void Professores_Load(object sender, EventArgs e)
        {

        }
    }
}
