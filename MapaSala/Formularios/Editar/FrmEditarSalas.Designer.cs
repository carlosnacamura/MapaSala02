namespace MapaSala.Formularios.Editar
{
    partial class FrmEditarSalas
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
            this.lblId = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.numComp = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numCad = new System.Windows.Forms.NumericUpDown();
            this.chkDisp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(61, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 23;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 288);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Código: ";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(12, 200);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(79, 17);
            this.chkAtivo.TabIndex = 18;
            this.chkAtivo.Text = "Laboratório";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome sala";
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Location = new System.Drawing.Point(12, 62);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.Size = new System.Drawing.Size(141, 20);
            this.txtNomeSala.TabIndex = 16;
            // 
            // numComp
            // 
            this.numComp.Location = new System.Drawing.Point(12, 109);
            this.numComp.Name = "numComp";
            this.numComp.Size = new System.Drawing.Size(120, 20);
            this.numComp.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Números de computadores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Números de cadeiras";
            // 
            // numCad
            // 
            this.numCad.Location = new System.Drawing.Point(12, 158);
            this.numCad.Name = "numCad";
            this.numCad.Size = new System.Drawing.Size(120, 20);
            this.numCad.TabIndex = 27;
            // 
            // chkDisp
            // 
            this.chkDisp.AutoSize = true;
            this.chkDisp.Location = new System.Drawing.Point(12, 234);
            this.chkDisp.Name = "chkDisp";
            this.chkDisp.Size = new System.Drawing.Size(77, 17);
            this.chkDisp.TabIndex = 29;
            this.chkDisp.Text = "Disponível";
            this.chkDisp.UseVisualStyleBackColor = true;
            // 
            // FrmEditarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 332);
            this.Controls.Add(this.chkDisp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numCad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numComp);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeSala);
            this.Name = "FrmEditarSalas";
            this.Text = "Editar salas";
            this.Load += new System.EventHandler(this.FrmEditarSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.NumericUpDown numComp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCad;
        private System.Windows.Forms.CheckBox chkDisp;
    }
}