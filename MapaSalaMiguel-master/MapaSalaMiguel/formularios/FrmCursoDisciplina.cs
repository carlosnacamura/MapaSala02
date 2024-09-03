using MapaSala.DAO;
using MapaSalaMiguel.DAO;
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
    public partial class FrmCursoDisciplina : Form
    {
        disciplinasDAO discDAO = new disciplinasDAO();
        cursosDAO curDAO = new cursosDAO();
        public FrmCursoDisciplina()
        {
            InitializeComponent();
            cbxDisciplina.DataSource = disciplinasDAO.PreencherComboBox();
            cbxDisciplina.DisplayMember = "Nome";
            cbxDisciplina.ValueMember = "Id";

            cbxCursos.DataSource = cursosDAO.PreencherComboBox();
            cbxCursos.DisplayMember = "Nome";
            cbxCursos.ValueMember = "Id";

        }

        private void FrmCursoDisciplina_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            lsDisciplina.Items.AddRange(disciplinasDAO.ListBox());
        }


    }
}
