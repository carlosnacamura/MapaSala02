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
    public partial class FormularioUsuarios : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public FormularioUsuarios()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridUsuarios.DataSource = dados;
            foreach (var atributos in typeof(UsuariosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("1","carlos.oliveira","24ty","Carlos",true);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosEntidade usuario = new UsuariosEntidade();
            usuario.Id = Convert.ToInt32(txtId.Text);
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nome = txtNome.Text;
            usuario.Ativo = chkAtivo.Checked;
            dados.Rows.Add(usuario.Linha());
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()

        {
            txtId.Text = "";
            txtLogin.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            chkAtivo.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridUsuarios.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtId.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtLogin.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtNome.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtSenha.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridUsuarios.Rows[LinhaSelecionada].Cells[4].Value);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[0].Value = txtId.Text;
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[1].Value = txtLogin.Text;
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[2].Value = txtNome.Text;
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[3].Value = txtSenha.Text;
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[4].Value = chkAtivo.Checked;
        }

        private void dtGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
