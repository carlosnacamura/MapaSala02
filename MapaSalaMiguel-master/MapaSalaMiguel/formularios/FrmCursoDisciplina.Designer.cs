
namespace MapaSalaMiguel.formularios
{
    partial class FrmCursoDisciplina
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
            this.lsDisciplina = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtCursoDisciplina = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtCursoDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // lsDisciplina
            // 
            this.lsDisciplina.FormattingEnabled = true;
            this.lsDisciplina.Items.AddRange(new object[] {
            "Fernando",
            "Galvani",
            "Eliete",
            "Malu",
            "Thais"});
            this.lsDisciplina.Location = new System.Drawing.Point(12, 75);
            this.lsDisciplina.Name = "lsDisciplina";
            this.lsDisciplina.Size = new System.Drawing.Size(173, 134);
            this.lsDisciplina.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Professores";
            // 
            // cbxCursos
            // 
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Items.AddRange(new object[] {
            "Desenvolvimento de Sistema Integral",
            "Administração Integral",
            "IF"});
            this.cbxCursos.Location = new System.Drawing.Point(205, 75);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(121, 21);
            this.cbxCursos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Disciplinas";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 376);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(173, 45);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dtCursoDisciplina
            // 
            this.dtCursoDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCursoDisciplina.Location = new System.Drawing.Point(357, 12);
            this.dtCursoDisciplina.Name = "dtCursoDisciplina";
            this.dtCursoDisciplina.Size = new System.Drawing.Size(431, 426);
            this.dtCursoDisciplina.TabIndex = 5;
            // 
            // FrmCursoDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtCursoDisciplina);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsDisciplina);
            this.Name = "FrmCursoDisciplina";
            this.Text = "FrmCursoDisciplina";
            this.Load += new System.EventHandler(this.FrmCursoDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCursoDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dtCursoDisciplina;
    }
}