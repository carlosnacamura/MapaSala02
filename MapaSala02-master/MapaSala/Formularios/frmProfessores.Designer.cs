
namespace MapaSala.Formularios
{
    partial class frmProfessores
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
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtGridProfessores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Location = new System.Drawing.Point(12, 126);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProf.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apelido";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(12, 188);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(100, 20);
            this.txtApelido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(12, 66);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(120, 20);
            this.numId.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(9, 347);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 46);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtGridProfessores
            // 
            this.dtGridProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProfessores.Location = new System.Drawing.Point(287, 12);
            this.dtGridProfessores.Name = "dtGridProfessores";
            this.dtGridProfessores.Size = new System.Drawing.Size(501, 426);
            this.dtGridProfessores.TabIndex = 8;
            this.dtGridProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridProfessores);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProf);
            this.Name = "frmProfessores";
            this.Text = "Professores";
            this.Load += new System.EventHandler(this.frmProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dtGridProfessores;
    }
}