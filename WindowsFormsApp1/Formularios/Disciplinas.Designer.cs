namespace Formulario
{
    partial class DisciplinasEntidade
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.EditRowBtn = new System.Windows.Forms.Button();
            this.SearchTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.Table.Size = new System.Drawing.Size(750, 300);
            this.Table.TabIndex = 6;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);

            // Panel for Inputs
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.numId);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.txtNome);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtSigla);
            this.panelInput.Controls.Add(this.chkAtivo);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.SearchTbx);
            this.panelInput.Location = new System.Drawing.Point(15, 20);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(220, 240);
            this.panelInput.TabIndex = 26;

            // Panel for Buttons
            this.panelButtons.Controls.Add(this.btnCadastrar);
            this.panelButtons.Controls.Add(this.EditRowBtn);
            this.panelButtons.Controls.Add(this.DeleteRowBtn);
            this.panelButtons.Controls.Add(this.ClearBtn);
            this.panelButtons.Location = new System.Drawing.Point(15, 270);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(220, 120);
            this.panelButtons.TabIndex = 27;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            // btnCadastrar
            this.btnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(165, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

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
            this.DeleteRowBtn.TabIndex = 8;
            this.DeleteRowBtn.Text = "Excluir Registro atual";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);

            // EditRowBtn
            this.EditRowBtn.Location = new System.Drawing.Point(0, 30);
            this.EditRowBtn.Name = "EditRowBtn";
            this.EditRowBtn.Size = new System.Drawing.Size(165, 23);
            this.EditRowBtn.TabIndex = 9;
            this.EditRowBtn.Text = "Editar Registro";
            this.EditRowBtn.UseVisualStyleBackColor = true;
            this.EditRowBtn.Click += new System.EventHandler(this.EditRowBtn_Click);

            // SearchTbx
            this.SearchTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchTbx.Location = new System.Drawing.Point(80, 150);
            this.SearchTbx.Name = "SearchTbx";
            this.SearchTbx.Size = new System.Drawing.Size(120, 20);
            this.SearchTbx.TabIndex = 10;
            this.SearchTbx.TextChanged += new System.EventHandler(this.SearchTbx_TextChanged);

            // Labels and Controls for Inputs
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 60);
            this.label1.Text = "Nome";

            this.txtNome.Location = new System.Drawing.Point(80, 60);
            this.txtNome.Size = new System.Drawing.Size(120, 20);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Text = "Id";

            this.numId.Location = new System.Drawing.Point(80, 0);
            this.numId.Size = new System.Drawing.Size(120, 20);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 90);
            this.label3.Text = "Sigla";

            this.txtSigla.Location = new System.Drawing.Point(80, 90);
            this.txtSigla.Size = new System.Drawing.Size(120, 20);

            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(80, 120);
            this.chkAtivo.Text = "Ativo";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 150);
            this.label4.Text = "Pesquisar";

            // DisciplinasEntidade Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.Table);
            this.Name = "DisciplinasEntidade";
            this.Text = "Disciplinas";

            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.Button EditRowBtn;
        private System.Windows.Forms.TextBox SearchTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}