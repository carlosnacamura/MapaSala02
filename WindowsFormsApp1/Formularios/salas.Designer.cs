namespace Formulario
{
    partial class Salas
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
            this.NameEntry = new System.Windows.Forms.TextBox();
            this.PCsNumberEntry = new System.Windows.Forms.TextBox();
            this.ChairEntry = new System.Windows.Forms.TextBox();
            this.BuildingEntry = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.IsLabChk = new System.Windows.Forms.CheckBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.SearchTbx = new System.Windows.Forms.TextBox();
            this.DisponivelChk = new System.Windows.Forms.CheckBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPCsNumber = new System.Windows.Forms.Label();
            this.labelChair = new System.Windows.Forms.Label();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();

            // Name Label
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Nome:";

            // NameEntry
            this.NameEntry.Location = new System.Drawing.Point(25, 66);
            this.NameEntry.Name = "NameEntry";
            this.NameEntry.Size = new System.Drawing.Size(218, 20);
            this.NameEntry.TabIndex = 0;
            this.NameEntry.Enter += new System.EventHandler(this.NameEntry_Enter);
            this.NameEntry.Leave += new System.EventHandler(this.NameEntry_Leave);

            // PCsNumber Label
            this.labelPCsNumber.AutoSize = true;
            this.labelPCsNumber.Location = new System.Drawing.Point(25, 90);
            this.labelPCsNumber.Name = "labelPCsNumber";
            this.labelPCsNumber.Size = new System.Drawing.Size(89, 13);
            this.labelPCsNumber.TabIndex = 19;
            this.labelPCsNumber.Text = "Número de PCs:";

            // PCsNumberEntry
            this.PCsNumberEntry.Location = new System.Drawing.Point(25, 106);
            this.PCsNumberEntry.Name = "PCsNumberEntry";
            this.PCsNumberEntry.Size = new System.Drawing.Size(218, 20);
            this.PCsNumberEntry.TabIndex = 1;
            this.PCsNumberEntry.Enter += new System.EventHandler(this.PCsNumber_Enter);
            this.PCsNumberEntry.Leave += new System.EventHandler(this.PCsNumber_Leave);

            // Chair Label
            this.labelChair.AutoSize = true;
            this.labelChair.Location = new System.Drawing.Point(25, 130);
            this.labelChair.Name = "labelChair";
            this.labelChair.Size = new System.Drawing.Size(99, 13);
            this.labelChair.TabIndex = 20;
            this.labelChair.Text = "Número de Cadeiras:";

            // ChairEntry
            this.ChairEntry.Location = new System.Drawing.Point(25, 146);
            this.ChairEntry.Name = "ChairEntry";
            this.ChairEntry.Size = new System.Drawing.Size(218, 20);
            this.ChairEntry.TabIndex = 2;
            this.ChairEntry.Enter += new System.EventHandler(this.ChairEntry_Enter);
            this.ChairEntry.Leave += new System.EventHandler(this.ChairEntry_Leave);

            // Building Label
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Location = new System.Drawing.Point(25, 170);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(41, 13);
            this.labelBuilding.TabIndex = 21;
            this.labelBuilding.Text = "Prédio:";

            // BuildingEntry
            this.BuildingEntry.Location = new System.Drawing.Point(25, 186);
            this.BuildingEntry.Name = "BuildingEntry";
            this.BuildingEntry.Size = new System.Drawing.Size(218, 20);
            this.BuildingEntry.TabIndex = 3;
            this.BuildingEntry.Enter += new System.EventHandler(this.BuildingEntry_Enter);
            this.BuildingEntry.Leave += new System.EventHandler(this.BuildingEntry_Leave);

            // RegisterBtn
            this.RegisterBtn.Location = new System.Drawing.Point(25, 250);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(100, 25);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Cadastrar Registro";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);

            // IsLabChk
            this.IsLabChk.AutoSize = true;
            this.IsLabChk.Location = new System.Drawing.Point(25, 220);
            this.IsLabChk.Name = "IsLabChk";
            this.IsLabChk.Size = new System.Drawing.Size(79, 17);
            this.IsLabChk.TabIndex = 5;
            this.IsLabChk.Text = "Laboratório";
            this.IsLabChk.UseVisualStyleBackColor = true;

            // ClearBtn
            this.ClearBtn.Location = new System.Drawing.Point(143, 250);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 25);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);

            // WarningLabel
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.WarningLabel.Location = new System.Drawing.Point(24, 21);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 21);
            this.WarningLabel.TabIndex = 9;

            // EditBtn
            this.EditBtn.Location = new System.Drawing.Point(424, 415);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(123, 23);
            this.EditBtn.TabIndex = 13;
            this.EditBtn.Text = "Editar Registros";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);

            // DeleteRowBtn
            this.DeleteRowBtn.Location = new System.Drawing.Point(553, 415);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(123, 23);
            this.DeleteRowBtn.TabIndex = 14;
            this.DeleteRowBtn.Text = "Excluir Registro";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);

            // Table
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(424, 66);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(548, 320);
            this.Table.TabIndex = 15;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);

            // SearchTbx
            this.SearchTbx.Location = new System.Drawing.Point(424, 40);
            this.SearchTbx.Name = "SearchTbx";
            this.SearchTbx.Size = new System.Drawing.Size(548, 20);
            this.SearchTbx.TabIndex = 16;
            this.SearchTbx.TextChanged += new System.EventHandler(this.SearchTbx_TextChanged);

            // Search Label
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(424, 20);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(56, 13);
            this.labelSearch.TabIndex = 22;
            this.labelSearch.Text = "Pesquisar:";

            // DisponivelChk
            this.DisponivelChk.AutoSize = true;
            this.DisponivelChk.Location = new System.Drawing.Point(25, 300);
            this.DisponivelChk.Name = "DisponivelChk";
            this.DisponivelChk.Size = new System.Drawing.Size(75, 17);
            this.DisponivelChk.TabIndex = 17;
            this.DisponivelChk.Text = "Disponível";
            this.DisponivelChk.UseVisualStyleBackColor = true;

            // Salas
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.DisponivelChk);
            this.Controls.Add(this.SearchTbx);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.IsLabChk);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.BuildingEntry);
            this.Controls.Add(this.labelBuilding);
            this.Controls.Add(this.ChairEntry);
            this.Controls.Add(this.labelChair);
            this.Controls.Add(this.PCsNumberEntry);
            this.Controls.Add(this.labelPCsNumber);
            this.Controls.Add(this.NameEntry);
            this.Controls.Add(this.labelName);
            this.Name = "Salas";
            this.Text = "Salas";

            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox NameEntry;
        private System.Windows.Forms.TextBox PCsNumberEntry;
        private System.Windows.Forms.TextBox ChairEntry;
        private System.Windows.Forms.TextBox BuildingEntry;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.CheckBox IsLabChk;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox SearchTbx;
        private System.Windows.Forms.CheckBox DisponivelChk;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPCsNumber;
        private System.Windows.Forms.Label labelChair;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.Label labelSearch;
    }
}