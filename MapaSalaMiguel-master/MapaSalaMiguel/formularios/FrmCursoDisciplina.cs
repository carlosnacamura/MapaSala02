using MapaSala.DAO;
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
        public FrmCursoDisciplina()
        {
            InitializeComponent();
        }

        private void FrmCursoDisciplina_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            lsDisciplina.Items.AddRange(disciplinasDAO.ListBox());
        }
    }
}
