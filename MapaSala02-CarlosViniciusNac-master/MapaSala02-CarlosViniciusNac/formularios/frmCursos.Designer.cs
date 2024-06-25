
namespace MapaSalaMiguel.formularios
{
    partial class frmCursos
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
            this.chkVagas = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // chkVagas
            // 
            this.chkVagas.AutoSize = true;
            this.chkVagas.Location = new System.Drawing.Point(30, 242);
            this.chkVagas.Name = "chkVagas";
            this.chkVagas.Size = new System.Drawing.Size(56, 17);
            this.chkVagas.TabIndex = 25;
            this.chkVagas.Text = "Vagas";
            this.chkVagas.UseVisualStyleBackColor = true;
            this.chkVagas.CheckedChanged += new System.EventHandler(this.chkboxVagas_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(27, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 38);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtGridCursos
            // 
            this.dtGridCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursos.Location = new System.Drawing.Point(321, 12);
            this.dtGridCursos.Name = "dtGridCursos";
            this.dtGridCursos.RowTemplate.Height = 25;
            this.dtGridCursos.Size = new System.Drawing.Size(467, 426);
            this.dtGridCursos.TabIndex = 23;
            this.dtGridCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 27;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(27, 162);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 28;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(27, 201);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodo.TabIndex = 29;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(27, 84);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Periodo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(27, 338);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 38);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(115, 294);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 38);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(115, 338);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(89, 38);
            this.btnAtualizar.TabIndex = 45;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.chkVagas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridCursos);
            this.Name = "FrmCursos";
            this.Text = "Formulário de cursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkVagas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtGridCursos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
    }
}