
namespace Formulario
{
    partial class Cursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
{
    this.components = new System.ComponentModel.Container();
    this.Table = new System.Windows.Forms.DataGridView();
    this.txtNome = new System.Windows.Forms.TextBox();
    this.RegisterBtn = new System.Windows.Forms.Button();
    this.ClearBtn = new System.Windows.Forms.Button();
    this.DeleteRowBtn = new System.Windows.Forms.Button();
    this.EditBtn = new System.Windows.Forms.Button();
    this.SearchTbx = new System.Windows.Forms.TextBox();
    this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
    this.txtSigla = new System.Windows.Forms.TextBox();
    this.txtTurno = new System.Windows.Forms.TextBox();
    this.label1 = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
    this.label3 = new System.Windows.Forms.Label();
    this.chkAtivo = new System.Windows.Forms.CheckBox();
    this.IdLbl = new System.Windows.Forms.Label();
    this.Pesquisa = new System.Windows.Forms.Label();
    this.numId = new System.Windows.Forms.NumericUpDown();
    this.panelInput = new System.Windows.Forms.Panel();
    this.panelButtons = new System.Windows.Forms.Panel();

    ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
    this.panelInput.SuspendLayout();
    this.panelButtons.SuspendLayout();
    this.SuspendLayout();

    // Table
    this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
    this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.Table.Location = new System.Drawing.Point(250, 20);
    this.Table.Name = "Table";
    this.Table.Size = new System.Drawing.Size(750, 475);
    this.Table.TabIndex = 0;
    this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);

    // Panel for Inputs
    this.panelInput.Controls.Add(this.IdLbl);
    this.panelInput.Controls.Add(this.numId);
    this.panelInput.Controls.Add(this.label1);
    this.panelInput.Controls.Add(this.txtNome);
    this.panelInput.Controls.Add(this.label2);
    this.panelInput.Controls.Add(this.txtSigla);
    this.panelInput.Controls.Add(this.label3);
    this.panelInput.Controls.Add(this.txtTurno);
    this.panelInput.Controls.Add(this.chkAtivo);
    this.panelInput.Controls.Add(this.Pesquisa);
    this.panelInput.Controls.Add(this.SearchTbx);
    this.panelInput.Location = new System.Drawing.Point(15, 20);
    this.panelInput.Name = "panelInput";
    this.panelInput.Size = new System.Drawing.Size(220, 240);
    this.panelInput.TabIndex = 26;

    // Panel for Buttons
    this.panelButtons.Controls.Add(this.RegisterBtn);
    this.panelButtons.Controls.Add(this.EditBtn);
    this.panelButtons.Controls.Add(this.DeleteRowBtn);
    this.panelButtons.Controls.Add(this.ClearBtn);
    this.panelButtons.Location = new System.Drawing.Point(15, 270);
    this.panelButtons.Name = "panelButtons";
    this.panelButtons.Size = new System.Drawing.Size(220, 130);
    this.panelButtons.TabIndex = 27;
    this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

    // RegisterBtn
    this.RegisterBtn.Location = new System.Drawing.Point(0, 0);
    this.RegisterBtn.Name = "RegisterBtn";
    this.RegisterBtn.Size = new System.Drawing.Size(165, 23);
    this.RegisterBtn.TabIndex = 4;
    this.RegisterBtn.Text = "Cadastrar curso";
    this.RegisterBtn.UseVisualStyleBackColor = true;
    this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);

    // ClearBtn
    this.ClearBtn.Location = new System.Drawing.Point(0, 90);
    this.ClearBtn.Name = "ClearBtn";
    this.ClearBtn.Size = new System.Drawing.Size(165, 23);
    this.ClearBtn.TabIndex = 5;
    this.ClearBtn.Text = "Limpar";
    this.ClearBtn.UseVisualStyleBackColor = true;
    this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);

    // DeleteRowBtn
    this.DeleteRowBtn.Location = new System.Drawing.Point(0, 60);
    this.DeleteRowBtn.Name = "DeleteRowBtn";
    this.DeleteRowBtn.Size = new System.Drawing.Size(165, 23);
    this.DeleteRowBtn.TabIndex = 11;
    this.DeleteRowBtn.Text = "Deletar Registro";
    this.DeleteRowBtn.UseVisualStyleBackColor = true;
    this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);

    // EditBtn
    this.EditBtn.Location = new System.Drawing.Point(0, 30);
    this.EditBtn.Name = "EditBtn";
    this.EditBtn.Size = new System.Drawing.Size(165, 23);
    this.EditBtn.TabIndex = 12;
    this.EditBtn.Text = "Editar Registro";
    this.EditBtn.UseVisualStyleBackColor = true;
    this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);

    // SearchTbx
    this.SearchTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
    this.SearchTbx.Location = new System.Drawing.Point(80, 150);
    this.SearchTbx.Name = "SearchTbx";
    this.SearchTbx.Size = new System.Drawing.Size(120, 20);
    this.SearchTbx.TabIndex = 14;
    this.SearchTbx.TextChanged += new System.EventHandler(this.SearchTbx_TextChanged);

    // Labels and Controls for Inputs
    this.label1.AutoSize = true;
    this.label1.Location = new System.Drawing.Point(0, 30);
    this.label1.Text = "Nome";

    this.txtNome.Location = new System.Drawing.Point(80, 30);
    this.txtNome.Size = new System.Drawing.Size(120, 20);

    this.label2.AutoSize = true;
    this.label2.Location = new System.Drawing.Point(0, 60);
    this.label2.Text = "Sigla";

    this.txtSigla.Location = new System.Drawing.Point(80, 60);
    this.txtSigla.Size = new System.Drawing.Size(120, 20);

    this.label3.AutoSize = true;
    this.label3.Location = new System.Drawing.Point(0, 90);
    this.label3.Text = "Turno";

    this.txtTurno.Location = new System.Drawing.Point(80, 90);
    this.txtTurno.Size = new System.Drawing.Size(120, 20);

    this.chkAtivo.AutoSize = true;
    this.chkAtivo.Location = new System.Drawing.Point(80, 120);
    this.chkAtivo.Text = "Ativo";

    this.IdLbl.AutoSize = true;
    this.IdLbl.Location = new System.Drawing.Point(0, 0);
    this.IdLbl.Text = "Id";

    this.numId.Location = new System.Drawing.Point(80, 0);
    this.numId.Size = new System.Drawing.Size(120, 20);

    this.Pesquisa.AutoSize = true;
    this.Pesquisa.Location = new System.Drawing.Point(0, 150);
    this.Pesquisa.Text = "Pesquisar";

    // Cursos Form
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(1024, 520);
    this.Controls.Add(this.panelInput);
    this.Controls.Add(this.panelButtons);
    this.Controls.Add(this.Table);
    this.Name = "Cursos";
    this.Text = "Cursos";
    this.Load += new System.EventHandler(this.Cursos_Load);

    ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
    this.panelInput.ResumeLayout(false);
    this.panelInput.PerformLayout();
    this.panelButtons.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
}

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox SearchTbx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label Pesquisa;
        private System.Windows.Forms.NumericUpDown numId;
    }
}