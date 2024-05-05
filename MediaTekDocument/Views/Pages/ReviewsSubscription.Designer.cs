namespace MediaTekDocument.Views.Pages
{
    partial class ReviewsSubscription
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
            dtpSubscriptionEndDate = new DateTimePicker();
            label13 = new Label();
            nudCommandCost = new NumericUpDown();
            label14 = new Label();
            btnEdit = new Button();
            btnDeleteCommand = new Button();
            tbCommandId = new TextBox();
            label9 = new Label();
            dtpCommandDate = new DateTimePicker();
            label11 = new Label();
            dgvSubscribeList = new DataGridView();
            groupBox1 = new GroupBox();
            pcbBookImage = new PictureBox();
            tbImagePath = new TextBox();
            tbDepartment = new TextBox();
            tbPublic = new TextBox();
            tbGender = new TextBox();
            tbDelay = new TextBox();
            tbPeriodicity = new TextBox();
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
            tbReviewId = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCommandCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubscribeList).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBookImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNewCommand);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dgvSubscribeList);
            groupBox2.Location = new Point(3, 271);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 404);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Liste des abonnements";
            // 
            // btnNewCommand
            // 
            btnNewCommand.Enabled = false;
            btnNewCommand.Location = new Point(6, 361);
            btnNewCommand.Name = "btnNewCommand";
            btnNewCommand.Size = new Size(380, 29);
            btnNewCommand.TabIndex = 43;
            btnNewCommand.Text = "+ Nouvel Abonnement";
            btnNewCommand.UseVisualStyleBackColor = true;
            btnNewCommand.Click += btnNewCommand_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpSubscriptionEndDate);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(nudCommandCost);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(btnEdit);
            groupBox3.Controls.Add(btnDeleteCommand);
            groupBox3.Controls.Add(tbCommandId);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(dtpCommandDate);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(392, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(460, 191);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informations de la commande";
            // 
            // dtpSubscriptionEndDate
            // 
            dtpSubscriptionEndDate.Enabled = false;
            dtpSubscriptionEndDate.Format = DateTimePickerFormat.Short;
            dtpSubscriptionEndDate.Location = new Point(253, 122);
            dtpSubscriptionEndDate.Name = "dtpSubscriptionEndDate";
            dtpSubscriptionEndDate.Size = new Size(200, 23);
            dtpSubscriptionEndDate.TabIndex = 50;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(5, 125);
            label13.Name = "label13";
            label13.Size = new Size(194, 17);
            label13.TabIndex = 49;
            label13.Text = "Date de fin de l'abonnement :";
            // 
            // nudCommandCost
            // 
            nudCommandCost.Location = new Point(351, 90);
            nudCommandCost.Name = "nudCommandCost";
            nudCommandCost.ReadOnly = true;
            nudCommandCost.Size = new Size(102, 23);
            nudCommandCost.TabIndex = 48;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(5, 93);
            label14.Name = "label14";
            label14.Size = new Size(175, 17);
            label14.TabIndex = 47;
            label14.Text = "Montant de la commande :";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.Enabled = false;
            btnEdit.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(289, 151);
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
            btnDeleteCommand.Location = new Point(6, 151);
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
            // dgvSubscribeList
            // 
            dgvSubscribeList.AllowUserToAddRows = false;
            dgvSubscribeList.AllowUserToDeleteRows = false;
            dgvSubscribeList.AllowUserToResizeColumns = false;
            dgvSubscribeList.AllowUserToResizeRows = false;
            dgvSubscribeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubscribeList.Location = new Point(6, 22);
            dgvSubscribeList.MultiSelect = false;
            dgvSubscribeList.Name = "dgvSubscribeList";
            dgvSubscribeList.ReadOnly = true;
            dgvSubscribeList.RowHeadersVisible = false;
            dgvSubscribeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubscribeList.Size = new Size(380, 334);
            dgvSubscribeList.TabIndex = 41;
            dgvSubscribeList.SelectionChanged += DgvCommandList_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pcbBookImage);
            groupBox1.Controls.Add(tbImagePath);
            groupBox1.Controls.Add(tbDepartment);
            groupBox1.Controls.Add(tbPublic);
            groupBox1.Controls.Add(tbGender);
            groupBox1.Controls.Add(tbDelay);
            groupBox1.Controls.Add(tbPeriodicity);
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
            groupBox1.Controls.Add(tbReviewId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 262);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recherche revue";
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
            tbImagePath.Size = new Size(420, 23);
            tbImagePath.TabIndex = 33;
            // 
            // tbDepartment
            // 
            tbDepartment.Location = new Point(172, 194);
            tbDepartment.Name = "tbDepartment";
            tbDepartment.ReadOnly = true;
            tbDepartment.Size = new Size(284, 23);
            tbDepartment.TabIndex = 32;
            // 
            // tbPublic
            // 
            tbPublic.Location = new Point(172, 165);
            tbPublic.Name = "tbPublic";
            tbPublic.ReadOnly = true;
            tbPublic.Size = new Size(284, 23);
            tbPublic.TabIndex = 31;
            // 
            // tbGender
            // 
            tbGender.Location = new Point(172, 136);
            tbGender.Name = "tbGender";
            tbGender.ReadOnly = true;
            tbGender.Size = new Size(284, 23);
            tbGender.TabIndex = 30;
            // 
            // tbDelay
            // 
            tbDelay.Location = new Point(172, 107);
            tbDelay.Name = "tbDelay";
            tbDelay.ReadOnly = true;
            tbDelay.Size = new Size(182, 23);
            tbDelay.TabIndex = 29;
            // 
            // tbPeriodicity
            // 
            tbPeriodicity.Location = new Point(172, 76);
            tbPeriodicity.Name = "tbPeriodicity";
            tbPeriodicity.ReadOnly = true;
            tbPeriodicity.Size = new Size(182, 23);
            tbPeriodicity.TabIndex = 28;
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
            label10.Size = new Size(92, 17);
            label10.TabIndex = 25;
            label10.Text = "Image revue :";
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
            label4.Size = new Size(153, 17);
            label4.TabIndex = 19;
            label4.Text = "Delai de mise à dispo. :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 79);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 18;
            label3.Text = "Périodicité :";
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
            btnSearchBook.Click += btnSearchReview_Click;
            // 
            // tbReviewId
            // 
            tbReviewId.Location = new Point(172, 18);
            tbReviewId.Name = "tbReviewId";
            tbReviewId.Size = new Size(182, 23);
            tbReviewId.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 21);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 14;
            label2.Text = "Numéro revue :";
            // 
            // ReviewsSubscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ReviewsSubscription";
            Size = new Size(864, 678);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCommandCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubscribeList).EndInit();
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
        private Button btnEdit;
        private Button btnDeleteCommand;
        private TextBox tbCommandId;
        private Label label9;
        private DateTimePicker dtpCommandDate;
        private Label label11;
        private DataGridView dgvSubscribeList;
        private GroupBox groupBox1;
        private PictureBox pcbBookImage;
        private TextBox tbImagePath;
        private TextBox tbDepartment;
        private TextBox tbPublic;
        private TextBox tbGender;
        private TextBox tbDelay;
        private TextBox tbPeriodicity;
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
        private TextBox tbReviewId;
        private Label label2;
        private DateTimePicker dtpSubscriptionEndDate;
        private Label label13;
    }
}
