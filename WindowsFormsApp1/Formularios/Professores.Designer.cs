namespace Formulario
{
    partial class Professores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professores));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SearchTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // Table
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(250, 20);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(800, 400);
            this.Table.TabIndex = 0;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridProfessores_CellClick);

            // Panel for Inputs
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.txtNome);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.txtApelido);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.SearchTbx);
            this.panelInput.Location = new System.Drawing.Point(15, 20);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(220, 200);
            this.panelInput.TabIndex = 1;

            // Panel for Buttons
            this.panelButtons.Controls.Add(this.RegisterBtn);
            this.panelButtons.Controls.Add(this.EditBtn);
            this.panelButtons.Controls.Add(this.DeleteRowBtn);
            this.panelButtons.Controls.Add(this.ClearBtn);
            this.panelButtons.Location = new System.Drawing.Point(15, 230);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(220, 150);
            this.panelButtons.TabIndex = 2;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            // txtNome
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            this.txtNome.Enter += new System.EventHandler(this.NomeEbx_Enter);
            this.txtNome.Leave += new System.EventHandler(this.NomeEb_Leave);

            // txtApelido
            resources.ApplyResources(this.txtApelido, "txtApelido");
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Enter += new System.EventHandler(this.ApelidoTbxx_Enter);
            this.txtApelido.Leave += new System.EventHandler(this.ApelidoTbxx_Leave);

            // RegisterBtn
            resources.ApplyResources(this.RegisterBtn, "RegisterBtn");
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);

            // ClearBtn
            resources.ApplyResources(this.ClearBtn, "ClearBtn");
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);

            // DeleteRowBtn
            resources.ApplyResources(this.DeleteRowBtn, "DeleteRowBtn");
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);

            // EditBtn
            resources.ApplyResources(this.EditBtn, "EditBtn");
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);

            // SearchTbx
            this.SearchTbx.Location = new System.Drawing.Point(80, 150);
            this.SearchTbx.Name = "SearchTbx";
            this.SearchTbx.Size = new System.Drawing.Size(120, 20);
            this.SearchTbx.TabIndex = 3;
            this.SearchTbx.TextChanged += new System.EventHandler(this.SearchTbx_TextChanged);

            // label1
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";

            // label2
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";

            // label3
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Location = new System.Drawing.Point(0, 150);
            this.label3.Text = "Pesquisar";

            // Professores
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.Table);
            this.Name = "Professores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Professores_Load);

            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox SearchTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}