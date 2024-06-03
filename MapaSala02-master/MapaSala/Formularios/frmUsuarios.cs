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
        BindingSource dados;
        public frmUsuarios()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridUsuarios.DataSource = dados;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosEntidade usuario = new UsuariosEntidade();
            usuario.Nome = txtNome.Text;
            usuario.Login = txtSenha.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Ativo = chkAtivo.Checked;
            dados.Add(usuario);
        }
    }
}
