using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using MapaSala.Formularios.Adicionar;
using MapaSala.Formularios.Editar;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmSalas : Form
    {
        DataTable dados;
        SalasDAO dao = new SalasDAO();
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }


            dtGridSalas.DataSource = dados;
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {
           
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridSalas.DataSource = dao.ObterSalas();
        }

        private void dtGridSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtGridSalas.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }

        private void dtGridSalas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dtGridSalas.Rows[e.RowIndex].Cells[0].Value);


                FrmEditarSalas editar = new FrmEditarSalas(id);


                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog();
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            FrmAdicionarSalas adicionar = new FrmAdicionarSalas();
            adicionar.FormClosed += Fechou_Editar_FormClosed;

            adicionar.ShowDialog();
        }
    }
}
