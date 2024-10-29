using MapaSala.DAO;
using MapaSala.Formularios.Adicionar;
using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmUsuarios : Form
    {
        DataTable dados;
        UsuariosDAO dao = new UsuariosDAO();
        public frmUsuarios()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(UsuariosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtGridUsuarios.DataSource = dados;
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {

            dtGridUsuarios.DataSource = dao.ObterUsuarios();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                FrmAdicionarUsuarios adicionar = new FrmAdicionarUsuarios();
                adicionar.FormClosed += Fechou_Editar_FormClosed;

                adicionar.ShowDialog();
            }
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void dtGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
