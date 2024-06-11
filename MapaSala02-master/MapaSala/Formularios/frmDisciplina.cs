using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
        BindingSource dados;
        public frmDisciplina()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridDisciplina.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade d = new DisciplinaEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNomeDisciplina.Text;
            d.Sigla = txtSigla.Text;

            dados.Add(d);
            LimparDados();
        }
        private void LimparDados()
        {
            TextBox[] txt = new TextBox[] { txtNomeDisciplina, txtSigla };
            foreach(TextBox t in txt)
            {
                t.Text = "";
            }
            numId.Value = 0;
        }
        private void frmDisciplina_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }
        private object[] Linha()
        {
            return new object[] { Id, Nome, Sigla };
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
