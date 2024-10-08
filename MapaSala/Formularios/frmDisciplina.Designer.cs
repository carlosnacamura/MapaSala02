
namespace MapaSala.Formularios
{
    partial class frmDisciplina
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
            this.dtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPes = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridDisciplina
            // 
            this.dtGridDisciplina.AllowUserToAddRows = false;
            this.dtGridDisciplina.AllowUserToDeleteRows = false;
            this.dtGridDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplina.Location = new System.Drawing.Point(12, 65);
            this.dtGridDisciplina.Name = "dtGridDisciplina";
            this.dtGridDisciplina.ReadOnly = true;
            this.dtGridDisciplina.Size = new System.Drawing.Size(616, 359);
            this.dtGridDisciplina.TabIndex = 7;
            this.dtGridDisciplina.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellContentDoubleClick);
            this.dtGridDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellDoubleClick);
            this.dtGridDisciplina.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGridDisciplina_CellMouseDoubleClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(443, 39);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(171, 20);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPes
            // 
            this.lblPes.AutoSize = true;
            this.lblPes.Location = new System.Drawing.Point(375, 42);
            this.lblPes.Name = "lblPes";
            this.lblPes.Size = new System.Drawing.Size(53, 13);
            this.lblPes.TabIndex = 9;
            this.lblPes.Text = "Pesquisar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(24, 37);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(186, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar disciplina";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblPes);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dtGridDisciplina);
            this.Name = "frmDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário disciplina";
            this.Load += new System.EventHandler(this.frmDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridDisciplina;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPes;
        private System.Windows.Forms.Button btnCadastrar;
    }
}