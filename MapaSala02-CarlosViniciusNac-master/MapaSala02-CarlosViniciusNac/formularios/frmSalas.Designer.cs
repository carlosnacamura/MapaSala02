
namespace MapaSala.Formularios
{
    partial class frmSalas
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
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numComputadores = new System.Windows.Forms.NumericUpDown();
            this.numCadeiras = new System.Windows.Forms.NumericUpDown();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            this.chkLaboratorio = new System.Windows.Forms.CheckBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numComputadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Location = new System.Drawing.Point(137, 60);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.Size = new System.Drawing.Size(86, 20);
            this.txtNomeSala.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Da Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nº De Computador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº De Cadeiras";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(128, 237);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 60);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // numComputadores
            // 
            this.numComputadores.Location = new System.Drawing.Point(134, 103);
            this.numComputadores.Name = "numComputadores";
            this.numComputadores.Size = new System.Drawing.Size(103, 20);
            this.numComputadores.TabIndex = 8;
            // 
            // numCadeiras
            // 
            this.numCadeiras.Location = new System.Drawing.Point(134, 151);
            this.numCadeiras.Name = "numCadeiras";
            this.numCadeiras.Size = new System.Drawing.Size(103, 20);
            this.numCadeiras.TabIndex = 9;
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(255, 12);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.RowTemplate.Height = 25;
            this.dtGridSalas.Size = new System.Drawing.Size(419, 366);
            this.dtGridSalas.TabIndex = 10;
            this.dtGridSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSalas_CellClick);
            // 
            // chkLaboratorio
            // 
            this.chkLaboratorio.AutoSize = true;
            this.chkLaboratorio.Location = new System.Drawing.Point(15, 185);
            this.chkLaboratorio.Name = "chkLaboratorio";
            this.chkLaboratorio.Size = new System.Drawing.Size(79, 17);
            this.chkLaboratorio.TabIndex = 11;
            this.chkLaboratorio.Text = "Laboratório";
            this.chkLaboratorio.UseVisualStyleBackColor = true;
            this.chkLaboratorio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(15, 207);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(77, 17);
            this.chkDisponivel.TabIndex = 12;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(15, 237);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 60);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(128, 303);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 60);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 303);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 60);
            this.btnAtualizar.TabIndex = 45;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(15, 101);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 46;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 148);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 47;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(15, 60);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodo.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Periodo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Id";
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.chkLaboratorio);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.numCadeiras);
            this.Controls.Add(this.numComputadores);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeSala);
            this.Name = "frmSalas";
            this.Text = "Formulário de salas";
            this.Load += new System.EventHandler(this.frmSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numComputadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numComputadores;
        private System.Windows.Forms.NumericUpDown numCadeiras;
        private System.Windows.Forms.DataGridView dtGridSalas;
        private System.Windows.Forms.CheckBox chkLaboratorio;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}