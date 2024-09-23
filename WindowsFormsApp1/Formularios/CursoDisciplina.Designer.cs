namespace WindowsFormsApp1.Formularios
{
    partial class CursoDisciplina
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
    this.CursoCbx = new System.Windows.Forms.ComboBox();
    this.label1 = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
    this.DisciplinaCbx = new System.Windows.Forms.ComboBox();
    this.Table = new System.Windows.Forms.DataGridView();
    this.PeriodoCbx = new System.Windows.Forms.ComboBox();
    this.TurnoLbl = new System.Windows.Forms.Label();
    this.RegisterBtn = new System.Windows.Forms.Button();
    this.DeleteBtn = new System.Windows.Forms.Button();
    this.EditBtn = new System.Windows.Forms.Button();
    this.panelButtons = new System.Windows.Forms.Panel();
    this.SearchTbx = new System.Windows.Forms.TextBox();
    this.labelSearch = new System.Windows.Forms.Label();

    ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
    this.panelButtons.SuspendLayout();
    this.SuspendLayout();

    // CursoCbx
    this.CursoCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.CursoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.CursoCbx.Location = new System.Drawing.Point(20, 20);
    this.CursoCbx.Size = new System.Drawing.Size(200, 25);

    // Label for Curso
    this.label1.Location = new System.Drawing.Point(20, 0);
    this.label1.Text = "Curso";

    // Label for Disciplina
    this.label2.Location = new System.Drawing.Point(20, 60);
    this.label2.Text = "Disciplina";

    // DisciplinaCbx
    this.DisciplinaCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.DisciplinaCbx.Location = new System.Drawing.Point(20, 80);
    this.DisciplinaCbx.Size = new System.Drawing.Size(200, 25);

    // Table
    this.Table.Location = new System.Drawing.Point(240, 20);
    this.Table.Size = new System.Drawing.Size(600, 400);

    // PeriodoCbx
    this.PeriodoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.PeriodoCbx.Location = new System.Drawing.Point(20, 140);
    this.PeriodoCbx.Size = new System.Drawing.Size(200, 25);

    // TurnoLbl
    this.TurnoLbl.Location = new System.Drawing.Point(20, 120);
    this.TurnoLbl.Text = "Periodo";

    // RegisterBtn
    this.RegisterBtn.Text = "Adicionar Registro";

    // DeleteBtn
    this.DeleteBtn.Text = "Excluir Registro";

    // EditBtn
    this.EditBtn.Text = "Editar Registro";

    // Panel for Buttons
    this.panelButtons.Location = new System.Drawing.Point(20, 230);
    this.panelButtons.Size = new System.Drawing.Size(220, 100);
    this.panelButtons.Controls.Add(this.RegisterBtn);
    this.panelButtons.Controls.Add(this.EditBtn);
    this.panelButtons.Controls.Add(this.DeleteBtn);
    this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

    // Label for Search
    this.labelSearch.Location = new System.Drawing.Point(20, 180);
    this.labelSearch.Size = new System.Drawing.Size(200, 20);
    this.labelSearch.Text = "Pesquisar";

    // SearchTbx
    this.SearchTbx.Location = new System.Drawing.Point(20, 200);
    this.SearchTbx.Size = new System.Drawing.Size(200, 25);

    // Form settings
    this.ClientSize = new System.Drawing.Size(860, 450);
    this.Controls.Add(this.CursoCbx);
    this.Controls.Add(this.DisciplinaCbx);
    this.Controls.Add(this.PeriodoCbx);
    this.Controls.Add(this.Table);
    this.Controls.Add(this.TurnoLbl);
    this.Controls.Add(this.panelButtons);
    this.Controls.Add(this.label1);
    this.Controls.Add(this.label2);
    this.Controls.Add(this.labelSearch);
    this.Controls.Add(this.SearchTbx);

    ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
    this.panelButtons.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
}

        #endregion

        private System.Windows.Forms.ComboBox CursoCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DisciplinaCbx;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ComboBox PeriodoCbx;
        private System.Windows.Forms.Label TurnoLbl;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
    }
}