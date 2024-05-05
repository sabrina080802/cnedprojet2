namespace MediaTekDocument.Views.Components
{
    partial class SearchArea<T>
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            tbSearchTitle = new TextBox();
            tbSearchNumber = new TextBox();
            btnSearch = new Button();
            cbGender = new ComboBox();
            cbPublic = new ComboBox();
            cbDepartment = new ComboBox();
            btnDropPublic = new Button();
            btnDropDepartment = new Button();
            btnDropGender = new Button();
            dgvData = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Rechercher par titre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 1;
            label2.Text = "Rechercher par numéro :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(443, 26);
            label4.Name = "label4";
            label4.Size = new Size(186, 20);
            label4.TabIndex = 3;
            label4.Text = "Ou sélectionner le genre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(443, 70);
            label5.Name = "label5";
            label5.Size = new Size(188, 20);
            label5.TabIndex = 4;
            label5.Text = "Ou sélectionner le public :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(443, 114);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 5;
            label6.Text = "Ou sélectionner le rayon :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvData);
            groupBox1.Controls.Add(btnDropGender);
            groupBox1.Controls.Add(btnDropDepartment);
            groupBox1.Controls.Add(btnDropPublic);
            groupBox1.Controls.Add(cbDepartment);
            groupBox1.Controls.Add(cbPublic);
            groupBox1.Controls.Add(cbGender);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbSearchNumber);
            groupBox1.Controls.Add(tbSearchTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(859, 331);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recherches";
            // 
            // tbSearchTitle
            // 
            tbSearchTitle.Location = new Point(193, 25);
            tbSearchTitle.Name = "tbSearchTitle";
            tbSearchTitle.Size = new Size(215, 23);
            tbSearchTitle.TabIndex = 6;
            // 
            // tbSearchNumber
            // 
            tbSearchNumber.Location = new Point(193, 69);
            tbSearchNumber.Name = "tbSearchNumber";
            tbSearchNumber.Size = new Size(101, 23);
            tbSearchNumber.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(300, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Rechercher";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(635, 25);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(186, 23);
            cbGender.TabIndex = 9;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            cbGender.DisplayMember = "Libelle";
            // 
            // cbPublic
            // 
            cbPublic.FormattingEnabled = true;
            cbPublic.Location = new Point(635, 69);
            cbPublic.Name = "cbPublic";
            cbPublic.Size = new Size(186, 23);
            cbPublic.TabIndex = 10;
            cbPublic.SelectedIndexChanged += cbPublic_SelectedIndexChanged;
            cbPublic.DisplayMember = "Libelle";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(635, 113);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(186, 23);
            cbDepartment.TabIndex = 11;
            cbDepartment.SelectedIndexChanged += cbDepartment_SelectedIndexChanged;
            cbDepartment.DisplayMember = "Libelle";

            // 
            // btnDropPublic
            // 
            btnDropPublic.Location = new Point(827, 69);
            btnDropPublic.Name = "btnDropPublic";
            btnDropPublic.Size = new Size(26, 23);
            btnDropPublic.TabIndex = 12;
            btnDropPublic.Text = "X";
            btnDropPublic.UseVisualStyleBackColor = true;
            btnDropPublic.Click += btnDropPublic_Click;
            // 
            // btnDropDepartment
            // 
            btnDropDepartment.Location = new Point(827, 113);
            btnDropDepartment.Name = "btnDropDepartment";
            btnDropDepartment.Size = new Size(26, 23);
            btnDropDepartment.TabIndex = 13;
            btnDropDepartment.Text = "X";
            btnDropDepartment.UseVisualStyleBackColor = true;
            btnDropDepartment.Click += btnDropDepartment_Click;
            // 
            // btnDropGender
            // 
            btnDropGender.Location = new Point(827, 25);
            btnDropGender.Name = "btnDropGender";
            btnDropGender.Size = new Size(26, 23);
            btnDropGender.TabIndex = 14;
            btnDropGender.Text = "X";
            btnDropGender.UseVisualStyleBackColor = true;
            btnDropGender.Click += btnDropGender_Click;
            // 
            // dvgData
            // 
            dgvData.Location = new Point(6, 160);
            dgvData.Name = "dvgData";
            dgvData.Size = new Size(847, 170);
            dgvData.TabIndex = 15;
            dgvData.ReadOnly = true;
            dgvData.MultiSelect = false;
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AllowUserToResizeColumns = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.RowHeadersVisible = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.ColumnHeaderMouseClick += DgvData_ColumnHeaderMouseClick;
            dgvData.CellFormatting += DgvData_CellFormatting;
            dgvData.SelectionChanged += DgvData_SelectionChanged;


            // 
            // SearchArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "SearchArea";
            Size = new Size(859, 336);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox tbSearchNumber;
        private TextBox tbSearchTitle;
        private ComboBox cbDepartment;
        private ComboBox cbPublic;
        private ComboBox cbGender;
        private Button btnSearch;
        private Button btnDropPublic;
        private Button btnDropGender;
        private Button btnDropDepartment;
        private DataGridView dgvData;
    }
}
