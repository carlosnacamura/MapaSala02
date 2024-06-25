
namespace MapaSalaMiguel.formularios
{
    partial class frmAlunos
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
            this.chkEstudante = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtGridAlunos = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEstudante
            // 
            this.chkEstudante.AutoSize = true;
            this.chkEstudante.Location = new System.Drawing.Point(12, 269);
            this.chkEstudante.Name = "chkEstudante";
            this.chkEstudante.Size = new System.Drawing.Size(74, 17);
            this.chkEstudante.TabIndex = 28;
            this.chkEstudante.Text = "Estudante";
            this.chkEstudante.UseVisualStyleBackColor = true;
            this.chkEstudante.CheckedChanged += new System.EventHandler(this.chkboxVagas_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 311);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 51);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtGridAlunos
            // 
            this.dtGridAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAlunos.Location = new System.Drawing.Point(272, 12);
            this.dtGridAlunos.Name = "dtGridAlunos";
            this.dtGridAlunos.RowTemplate.Height = 25;
            this.dtGridAlunos.Size = new System.Drawing.Size(516, 426);
            this.dtGridAlunos.TabIndex = 26;
            this.dtGridAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAlunos_CellClick);
            this.dtGridAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAlunos_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 30;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 31;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(12, 139);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 32;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(12, 182);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(100, 20);
            this.txtSala.TabIndex = 33;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(12, 225);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(100, 20);
            this.txtApelido.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Idade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Apelido";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(134, 368);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 51);
            this.btnLimpar.TabIndex = 40;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 368);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 51);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(134, 311);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(116, 51);
            this.btnAtualizar.TabIndex = 44;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkEstudante);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridAlunos);
            this.Name = "FrmAlunos";
            this.Text = "Formulário de alunos";
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEstudante;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtGridAlunos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
    }
}