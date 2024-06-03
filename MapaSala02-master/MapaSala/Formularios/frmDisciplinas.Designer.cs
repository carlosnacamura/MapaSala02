
namespace MapaSala.Formularios
{
    partial class frmDisciplinas
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGridDisciplinas = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 121);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sigla";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(12, 201);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(163, 20);
            this.txtSigla.TabIndex = 2;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(12, 245);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 4;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(12, 49);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(120, 20);
            this.numId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // dtGridDisciplinas
            // 
            this.dtGridDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplinas.Location = new System.Drawing.Point(245, 12);
            this.dtGridDisciplinas.Name = "dtGridDisciplinas";
            this.dtGridDisciplinas.Size = new System.Drawing.Size(543, 426);
            this.dtGridDisciplinas.TabIndex = 7;
            this.dtGridDisciplinas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplinas_CellContentClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 331);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 42);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridDisciplinas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmDisciplinas";
            this.Text = "frmDisciplinas";
            this.Load += new System.EventHandler(this.frmDisciplinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtGridDisciplinas;
        private System.Windows.Forms.Button btnSalvar;
    }
}