
namespace MapaSala.Formularios.Adicionar
{
    partial class FrmAdicionarSalas
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
            this.chkDisp = new System.Windows.Forms.CheckBox();
            this.chkLab = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numCadeiras = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numComputadores = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComputadores)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDisp
            // 
            this.chkDisp.AutoSize = true;
            this.chkDisp.Location = new System.Drawing.Point(10, 203);
            this.chkDisp.Name = "chkDisp";
            this.chkDisp.Size = new System.Drawing.Size(77, 17);
            this.chkDisp.TabIndex = 49;
            this.chkDisp.Text = "Disponível";
            this.chkDisp.UseVisualStyleBackColor = true;
            // 
            // chkLab
            // 
            this.chkLab.AutoSize = true;
            this.chkLab.Location = new System.Drawing.Point(10, 166);
            this.chkLab.Name = "chkLab";
            this.chkLab.Size = new System.Drawing.Size(79, 17);
            this.chkLab.TabIndex = 48;
            this.chkLab.Text = "Laboratorio";
            this.chkLab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Número de cadeiras";
            // 
            // numCadeiras
            // 
            this.numCadeiras.Location = new System.Drawing.Point(10, 127);
            this.numCadeiras.Name = "numCadeiras";
            this.numCadeiras.Size = new System.Drawing.Size(120, 20);
            this.numCadeiras.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Número de computadores";
            // 
            // numComputadores
            // 
            this.numComputadores.Location = new System.Drawing.Point(10, 82);
            this.numComputadores.Name = "numComputadores";
            this.numComputadores.Size = new System.Drawing.Size(120, 20);
            this.numComputadores.TabIndex = 44;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(109, 266);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(10, 266);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 42;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome da sala";
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Location = new System.Drawing.Point(10, 33);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.Size = new System.Drawing.Size(141, 20);
            this.txtNomeSala.TabIndex = 40;
            // 
            // FrmAdicionarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 319);
            this.Controls.Add(this.chkDisp);
            this.Controls.Add(this.chkLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCadeiras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numComputadores);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeSala);
            this.Name = "FrmAdicionarSalas";
            this.Text = "Adicionar salas";
            this.Load += new System.EventHandler(this.FrmAdicionarSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComputadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDisp;
        private System.Windows.Forms.CheckBox chkLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCadeiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numComputadores;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeSala;
    }
}