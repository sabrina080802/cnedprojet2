namespace MediaTekDocument.Views.Pages
{
    partial class CommandDvd
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
            groupBox2 = new GroupBox();
            btnNewCommand = new Button();
            groupBox3 = new GroupBox();
            nudCommandCost = new NumericUpDown();
            label14 = new Label();
            btnAddDocument = new Button();
            label13 = new Label();
            dgvCommandDocumentList = new DataGridView();
            cbCommandStatus = new ComboBox();
            btnEdit = new Button();
            btnDeleteCommand = new Button();
            tbCommandId = new TextBox();
            label9 = new Label();
            dtpCommandDate = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            dgvCommandList = new DataGridView();
            groupBox1 = new GroupBox();
            tbSynopsis = new TextBox();
            label15 = new Label();
            pcbBookImage = new PictureBox();
            tbImagePath = new TextBox();
            tbDepartment = new TextBox();
            tbPublic = new TextBox();
            tbGender = new TextBox();
            tbDuration = new TextBox();
            tbReal = new TextBox();
            tbTitle = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnSearchBook = new Button();
            tbDvdId = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCommandCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommandDocumentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommandList).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBookImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNewCommand);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dgvCommandList);
            groupBox2.Location = new Point(3, 271);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 404);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Liste des commandes";
            // 
            // btnNewCommand
            // 
            btnNewCommand.Enabled = false;
            btnNewCommand.Location = new Point(6, 361);
            btnNewCommand.Name = "btnNewCommand";
            btnNewCommand.Size = new Size(380, 29);
            btnNewCommand.TabIndex = 43;
            btnNewCommand.Text = "+ Nouvelle commande";
            btnNewCommand.UseVisualStyleBackColor = true;
            btnNewCommand.Click += btnNewCommand_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nudCommandCost);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(btnAddDocument);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(dgvCommandDocumentList);
            groupBox3.Controls.Add(cbCommandStatus);
            groupBox3.Controls.Add(btnEdit);
            groupBox3.Controls.Add(btnDeleteCommand);
            groupBox3.Controls.Add(tbCommandId);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(dtpCommandDate);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(392, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(460, 376);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informations de la commande";
            // 
            // nudCommandCost
            // 
            nudCommandCost.Location = new Point(351, 128);
            nudCommandCost.Name = "nudCommandCost";
            nudCommandCost.ReadOnly = true;
            nudCommandCost.Size = new Size(102, 23);
            nudCommandCost.TabIndex = 48;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(5, 131);
            label14.Name = "label14";
            label14.Size = new Size(175, 17);
            label14.TabIndex = 47;
            label14.Text = "Montant de la commande :";
            // 
            // btnAddDocument
            // 
            btnAddDocument.BackColor = Color.DodgerBlue;
            btnAddDocument.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnAddDocument.FlatStyle = FlatStyle.Flat;
            btnAddDocument.ForeColor = Color.White;
            btnAddDocument.Location = new Point(147, 337);
            btnAddDocument.Name = "btnAddDocument";
            btnAddDocument.Size = new Size(137, 33);
            btnAddDocument.TabIndex = 46;
            btnAddDocument.Text = "Ajouter un DVD";
            btnAddDocument.UseVisualStyleBackColor = false;
            btnAddDocument.Visible = false;
            btnAddDocument.Click += btnAddDocument_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 162);
            label13.Name = "label13";
            label13.Size = new Size(174, 17);
            label13.TabIndex = 45;
            label13.Text = "Contenu de la commande :";
            // 
            // dgvCommandDocumentList
            // 
            dgvCommandDocumentList.AllowUserToAddRows = false;
            dgvCommandDocumentList.AllowUserToDeleteRows = false;
            dgvCommandDocumentList.AllowUserToResizeColumns = false;
            dgvCommandDocumentList.AllowUserToResizeRows = false;
            dgvCommandDocumentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandDocumentList.Location = new Point(7, 182);
            dgvCommandDocumentList.MultiSelect = false;
            dgvCommandDocumentList.Name = "dgvCommandDocumentList";
            dgvCommandDocumentList.RowHeadersVisible = false;
            dgvCommandDocumentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCommandDocumentList.Size = new Size(447, 152);
            dgvCommandDocumentList.TabIndex = 44;
            // 
            // cbCommandStatus
            // 
            cbCommandStatus.Enabled = false;
            cbCommandStatus.FormattingEnabled = true;
            cbCommandStatus.Location = new Point(253, 92);
            cbCommandStatus.Name = "cbCommandStatus";
            cbCommandStatus.Size = new Size(200, 23);
            cbCommandStatus.TabIndex = 44;
            cbCommandStatus.SelectedIndexChanged += cbCommandStatus_SelectedIndexChanged;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.Enabled = false;
            btnEdit.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(290, 337);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(164, 33);
            btnEdit.TabIndex = 42;
            btnEdit.Text = "Modifier les informations";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDeleteCommand
            // 
            btnDeleteCommand.BackColor = Color.Red;
            btnDeleteCommand.Enabled = false;
            btnDeleteCommand.FlatAppearance.BorderColor = Color.Red;
            btnDeleteCommand.FlatStyle = FlatStyle.Flat;
            btnDeleteCommand.ForeColor = Color.White;
            btnDeleteCommand.Location = new Point(7, 337);
            btnDeleteCommand.Name = "btnDeleteCommand";
            btnDeleteCommand.Size = new Size(134, 33);
            btnDeleteCommand.TabIndex = 41;
            btnDeleteCommand.Text = "Suppr. la commande";
            btnDeleteCommand.UseVisualStyleBackColor = false;
            btnDeleteCommand.Visible = false;
            btnDeleteCommand.Click += btnDeleteCommand_Click;
            // 
            // tbCommandId
            // 
            tbCommandId.Location = new Point(253, 22);
            tbCommandId.Name = "tbCommandId";
            tbCommandId.ReadOnly = true;
            tbCommandId.Size = new Size(200, 23);
            tbCommandId.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 25);
            label9.Name = "label9";
            label9.Size = new Size(136, 17);
            label9.TabIndex = 28;
            label9.Text = "ID de la commande :";
            // 
            // dtpCommandDate
            // 
            dtpCommandDate.Enabled = false;
            dtpCommandDate.Format = DateTimePickerFormat.Short;
            dtpCommandDate.Location = new Point(253, 58);
            dtpCommandDate.Name = "dtpCommandDate";
            dtpCommandDate.Size = new Size(200, 23);
            dtpCommandDate.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(5, 61);
            label11.Name = "label11";
            label11.Size = new Size(151, 17);
            label11.TabIndex = 30;
            label11.Text = "Date de la commande :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(5, 98);
            label12.Name = "label12";
            label12.Size = new Size(146, 17);
            label12.TabIndex = 32;
            label12.Text = "Etat de la commande :";
            // 
            // dgvCommandList
            // 
            dgvCommandList.AllowUserToAddRows = false;
            dgvCommandList.AllowUserToDeleteRows = false;
            dgvCommandList.AllowUserToResizeColumns = false;
            dgvCommandList.AllowUserToResizeRows = false;
            dgvCommandList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandList.Location = new Point(6, 22);
            dgvCommandList.MultiSelect = false;
            dgvCommandList.Name = "dgvCommandList";
            dgvCommandList.ReadOnly = true;
            dgvCommandList.RowHeadersVisible = false;
            dgvCommandList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCommandList.Size = new Size(380, 334);
            dgvCommandList.TabIndex = 41;
            dgvCommandList.CellFormatting += DgvCommandList_CellFormatting;
            dgvCommandList.SelectionChanged += DgvCommandList_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSynopsis);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(pcbBookImage);
            groupBox1.Controls.Add(tbImagePath);
            groupBox1.Controls.Add(tbDepartment);
            groupBox1.Controls.Add(tbPublic);
            groupBox1.Controls.Add(tbGender);
            groupBox1.Controls.Add(tbDuration);
            groupBox1.Controls.Add(tbReal);
            groupBox1.Controls.Add(tbTitle);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSearchBook);
            groupBox1.Controls.Add(tbDvdId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 262);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recherche livre";
            // 
            // tbSynopsis
            // 
            tbSynopsis.AcceptsReturn = true;
            tbSynopsis.Location = new Point(360, 106);
            tbSynopsis.Multiline = true;
            tbSynopsis.Name = "tbSynopsis";
            tbSynopsis.ReadOnly = true;
            tbSynopsis.ScrollBars = ScrollBars.Vertical;
            tbSynopsis.Size = new Size(232, 140);
            tbSynopsis.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(360, 79);
            label15.Name = "label15";
            label15.Size = new Size(70, 17);
            label15.TabIndex = 37;
            label15.Text = "Synopsis :";
            // 
            // pcbBookImage
            // 
            pcbBookImage.BackColor = Color.White;
            pcbBookImage.BorderStyle = BorderStyle.FixedSingle;
            pcbBookImage.Location = new Point(605, 59);
            pcbBookImage.Name = "pcbBookImage";
            pcbBookImage.Size = new Size(247, 187);
            pcbBookImage.TabIndex = 36;
            pcbBookImage.TabStop = false;
            // 
            // tbImagePath
            // 
            tbImagePath.Location = new Point(172, 223);
            tbImagePath.Name = "tbImagePath";
            tbImagePath.ReadOnly = true;
            tbImagePath.Size = new Size(182, 23);
            tbImagePath.TabIndex = 33;
            // 
            // tbDepartment
            // 
            tbDepartment.Location = new Point(172, 194);
            tbDepartment.Name = "tbDepartment";
            tbDepartment.ReadOnly = true;
            tbDepartment.Size = new Size(182, 23);
            tbDepartment.TabIndex = 32;
            // 
            // tbPublic
            // 
            tbPublic.Location = new Point(172, 165);
            tbPublic.Name = "tbPublic";
            tbPublic.ReadOnly = true;
            tbPublic.Size = new Size(182, 23);
            tbPublic.TabIndex = 31;
            // 
            // tbGender
            // 
            tbGender.Location = new Point(172, 136);
            tbGender.Name = "tbGender";
            tbGender.ReadOnly = true;
            tbGender.Size = new Size(182, 23);
            tbGender.TabIndex = 30;
            // 
            // tbDuration
            // 
            tbDuration.Location = new Point(172, 107);
            tbDuration.Name = "tbDuration";
            tbDuration.ReadOnly = true;
            tbDuration.Size = new Size(182, 23);
            tbDuration.TabIndex = 29;
            // 
            // tbReal
            // 
            tbReal.Location = new Point(172, 76);
            tbReal.Name = "tbReal";
            tbReal.ReadOnly = true;
            tbReal.Size = new Size(182, 23);
            tbReal.TabIndex = 28;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(172, 47);
            tbTitle.Name = "tbTitle";
            tbTitle.ReadOnly = true;
            tbTitle.Size = new Size(284, 23);
            tbTitle.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(605, 39);
            label10.Name = "label10";
            label10.Size = new Size(87, 17);
            label10.TabIndex = 25;
            label10.Text = "Image DVD :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 226);
            label8.Name = "label8";
            label8.Size = new Size(132, 17);
            label8.TabIndex = 23;
            label8.Text = "Chemin de l'image :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 197);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 22;
            label7.Text = "Rayon :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 168);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 21;
            label6.Text = "Public :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 139);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 20;
            label5.Text = "Genre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 110);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 19;
            label4.Text = "Durée :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 79);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 18;
            label3.Text = "Réalisateur :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 50);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 17;
            label1.Text = "Titre :";
            // 
            // btnSearchBook
            // 
            btnSearchBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBook.Location = new Point(360, 18);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(96, 23);
            btnSearchBook.TabIndex = 16;
            btnSearchBook.Text = "Rechercher";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchDvd_Click;
            // 
            // tbDvdId
            // 
            tbDvdId.Location = new Point(172, 18);
            tbDvdId.Name = "tbDvdId";
            tbDvdId.Size = new Size(182, 23);
            tbDvdId.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 21);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 14;
            label2.Text = "Numéro DVD  :";
            // 
            // CommandDvd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CommandDvd";
            Size = new Size(864, 678);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCommandCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommandDocumentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommandList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBookImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnNewCommand;
        private GroupBox groupBox3;
        private NumericUpDown nudCommandCost;
        private Label label14;
        private Button btnAddDocument;
        private Label label13;
        private DataGridView dgvCommandDocumentList;
        private ComboBox cbCommandStatus;
        private Button btnEdit;
        private Button btnDeleteCommand;
        private TextBox tbCommandId;
        private Label label9;
        private DateTimePicker dtpCommandDate;
        private Label label11;
        private Label label12;
        private DataGridView dgvCommandList;
        private GroupBox groupBox1;
        private PictureBox pcbBookImage;
        private TextBox tbImagePath;
        private TextBox tbDepartment;
        private TextBox tbPublic;
        private TextBox tbGender;
        private TextBox tbDuration;
        private TextBox tbReal;
        private TextBox tbTitle;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnSearchBook;
        private TextBox tbDvdId;
        private Label label2;
        private Label label15;
        private TextBox tbSynopsis;
    }
}
