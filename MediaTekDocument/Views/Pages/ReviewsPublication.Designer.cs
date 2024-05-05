namespace MediaTekDocument.Views.Pages
{
    partial class ReviewsPublication
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
            groupBox1 = new GroupBox();
            pcbReviewImage = new PictureBox();
            pcbCopyImage = new PictureBox();
            dgvPublications = new DataGridView();
            tbImagePath = new TextBox();
            tbDepartment = new TextBox();
            tbPublic = new TextBox();
            tbGender = new TextBox();
            tbDelay = new TextBox();
            tbPeriodicity = new TextBox();
            tbTitle = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnSearchReview = new Button();
            tbReviewId = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnValidateReception = new Button();
            pcbNewRevCopyImage = new PictureBox();
            label15 = new Label();
            btnNewRevSearch = new Button();
            tbNewRevImagePath = new TextBox();
            label14 = new Label();
            dtpNewRevPublishDate = new DateTimePicker();
            label13 = new Label();
            tbNewRevNumber = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbReviewImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCopyImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPublications).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNewRevCopyImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pcbReviewImage);
            groupBox1.Controls.Add(pcbCopyImage);
            groupBox1.Controls.Add(dgvPublications);
            groupBox1.Controls.Add(tbImagePath);
            groupBox1.Controls.Add(tbDepartment);
            groupBox1.Controls.Add(tbPublic);
            groupBox1.Controls.Add(tbGender);
            groupBox1.Controls.Add(tbDelay);
            groupBox1.Controls.Add(tbPeriodicity);
            groupBox1.Controls.Add(tbTitle);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSearchReview);
            groupBox1.Controls.Add(tbReviewId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 385);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recherche revue";
            // 
            // pcbReviewImage
            // 
            pcbReviewImage.BackColor = Color.White;
            pcbReviewImage.BorderStyle = BorderStyle.FixedSingle;
            pcbReviewImage.Location = new Point(698, 22);
            pcbReviewImage.Name = "pcbReviewImage";
            pcbReviewImage.Size = new Size(154, 114);
            pcbReviewImage.TabIndex = 36;
            pcbReviewImage.TabStop = false;
            // 
            // pcbCopyImage
            // 
            pcbCopyImage.BackColor = Color.White;
            pcbCopyImage.BorderStyle = BorderStyle.FixedSingle;
            pcbCopyImage.Location = new Point(568, 168);
            pcbCopyImage.Name = "pcbCopyImage";
            pcbCopyImage.Size = new Size(284, 210);
            pcbCopyImage.TabIndex = 35;
            pcbCopyImage.TabStop = false;
            // 
            // dgvPublications
            // 
            dgvPublications.Name = "dgvPublications";
            dgvPublications.AllowUserToAddRows = false;
            dgvPublications.AllowUserToDeleteRows = false;
            dgvPublications.AllowUserToResizeColumns = false;
            dgvPublications.AllowUserToResizeRows = false;
            dgvPublications.MultiSelect = false;
            dgvPublications.ReadOnly = true;
            dgvPublications.RowHeadersVisible = false;
            dgvPublications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPublications.TabIndex = 34;
            dgvPublications.Size = new Size(380, 126);
            dgvPublications.Location = new Point(172, 252);
            dgvPublications.SelectionChanged += dgvPublications_SelectionChanged;
            dgvPublications.ColumnHeaderMouseClick += DgvPublications_ColumnHeaderMouseClick;

            // 
            // tbImagePath
            // 
            tbImagePath.Location = new Point(172, 223);
            tbImagePath.Name = "tbImagePath";
            tbImagePath.ReadOnly = true;
            tbImagePath.Size = new Size(380, 23);
            tbImagePath.TabIndex = 33;
            // 
            // tbDepartment
            // 
            tbDepartment.Location = new Point(172, 194);
            tbDepartment.Name = "tbDepartment";
            tbDepartment.ReadOnly = true;
            tbDepartment.Size = new Size(244, 23);
            tbDepartment.TabIndex = 32;
            // 
            // tbPublic
            // 
            tbPublic.Location = new Point(172, 165);
            tbPublic.Name = "tbPublic";
            tbPublic.ReadOnly = true;
            tbPublic.Size = new Size(244, 23);
            tbPublic.TabIndex = 31;
            // 
            // tbGender
            // 
            tbGender.Location = new Point(172, 136);
            tbGender.Name = "tbGender";
            tbGender.ReadOnly = true;
            tbGender.Size = new Size(244, 23);
            tbGender.TabIndex = 30;
            // 
            // tbDelay
            // 
            tbDelay.Location = new Point(172, 107);
            tbDelay.Name = "tbDelay";
            tbDelay.ReadOnly = true;
            tbDelay.Size = new Size(142, 23);
            tbDelay.TabIndex = 29;
            // 
            // tbPeriodicity
            // 
            tbPeriodicity.Location = new Point(172, 76);
            tbPeriodicity.Name = "tbPeriodicity";
            tbPeriodicity.ReadOnly = true;
            tbPeriodicity.Size = new Size(142, 23);
            tbPeriodicity.TabIndex = 28;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(172, 47);
            tbTitle.Name = "tbTitle";
            tbTitle.ReadOnly = true;
            tbTitle.Size = new Size(244, 23);
            tbTitle.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(568, 148);
            label11.Name = "label11";
            label11.Size = new Size(126, 17);
            label11.TabIndex = 26;
            label11.Text = "Image exemplaire :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(568, 24);
            label10.Name = "label10";
            label10.Size = new Size(92, 17);
            label10.TabIndex = 25;
            label10.Text = "Image revue :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 252);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 24;
            label9.Text = "Parutions :";
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
            label4.Size = new Size(130, 17);
            label4.TabIndex = 19;
            label4.Text = "Délai mise à dispo :";
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
            // btnSearchReview
            // 
            btnSearchReview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchReview.Location = new Point(320, 18);
            btnSearchReview.Name = "btnSearchReview";
            btnSearchReview.Size = new Size(96, 23);
            btnSearchReview.TabIndex = 16;
            btnSearchReview.Text = "Rechercher";
            btnSearchReview.UseVisualStyleBackColor = true;
            btnSearchReview.Click += btnSearchReview_Click;
            // 
            // tbReviewId
            // 
            tbReviewId.Location = new Point(172, 18);
            tbReviewId.Name = "tbReviewId";
            tbReviewId.Size = new Size(142, 23);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnValidateReception);
            groupBox2.Controls.Add(pcbNewRevCopyImage);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(btnNewRevSearch);
            groupBox2.Controls.Add(tbNewRevImagePath);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(dtpNewRevPublishDate);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(tbNewRevNumber);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(3, 394);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 281);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nouvelle parution réceptionnée pour cette revue";
            // 
            // btnValidateReception
            // 
            btnValidateReception.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidateReception.Location = new Point(8, 121);
            btnValidateReception.Name = "btnValidateReception";
            btnValidateReception.Size = new Size(544, 37);
            btnValidateReception.TabIndex = 40;
            btnValidateReception.Text = "Valider la réception";
            btnValidateReception.UseVisualStyleBackColor = true;
            // 
            // pcbNewRevCopyImage
            // 
            pcbNewRevCopyImage.BackColor = Color.White;
            pcbNewRevCopyImage.BorderStyle = BorderStyle.FixedSingle;
            pcbNewRevCopyImage.Location = new Point(568, 51);
            pcbNewRevCopyImage.Name = "pcbNewRevCopyImage";
            pcbNewRevCopyImage.Size = new Size(284, 210);
            pcbNewRevCopyImage.TabIndex = 39;
            pcbNewRevCopyImage.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(568, 31);
            label15.Name = "label15";
            label15.Size = new Size(126, 17);
            label15.TabIndex = 38;
            label15.Text = "Image exemplaire :";
            // 
            // btnNewRevSearch
            // 
            btnNewRevSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewRevSearch.Location = new Point(456, 87);
            btnNewRevSearch.Name = "btnNewRevSearch";
            btnNewRevSearch.Size = new Size(96, 23);
            btnNewRevSearch.TabIndex = 37;
            btnNewRevSearch.Text = "Rechercher";
            btnNewRevSearch.UseVisualStyleBackColor = true;
            // 
            // tbNewRevImagePath
            // 
            tbNewRevImagePath.Location = new Point(172, 86);
            tbNewRevImagePath.Name = "tbNewRevImagePath";
            tbNewRevImagePath.ReadOnly = true;
            tbNewRevImagePath.Size = new Size(278, 23);
            tbNewRevImagePath.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(8, 89);
            label14.Name = "label14";
            label14.Size = new Size(141, 17);
            label14.TabIndex = 20;
            label14.Text = "Emplacement image :";
            // 
            // dtpNewRevPublishDate
            // 
            dtpNewRevPublishDate.CustomFormat = "";
            dtpNewRevPublishDate.Format = DateTimePickerFormat.Short;
            dtpNewRevPublishDate.Location = new Point(172, 57);
            dtpNewRevPublishDate.Name = "dtpNewRevPublishDate";
            dtpNewRevPublishDate.Size = new Size(142, 23);
            dtpNewRevPublishDate.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(8, 61);
            label13.Name = "label13";
            label13.Size = new Size(121, 17);
            label13.TabIndex = 18;
            label13.Text = "Date de parution :";
            // 
            // tbNewRevNumber
            // 
            tbNewRevNumber.Location = new Point(172, 28);
            tbNewRevNumber.Name = "tbNewRevNumber";
            tbNewRevNumber.Size = new Size(142, 23);
            tbNewRevNumber.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(8, 31);
            label12.Name = "label12";
            label12.Size = new Size(143, 17);
            label12.TabIndex = 16;
            label12.Text = "Numéro réceptionné :";
            // 
            // ReviewsPublication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ReviewsPublication";
            Size = new Size(864, 678);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbReviewImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCopyImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPublications).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNewRevCopyImage).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupBox1;
        private TextBox tbReviewId;
        private Label label2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnSearchReview;
        private TextBox tbDepartment;
        private TextBox tbPublic;
        private TextBox tbGender;
        private TextBox tbDelay;
        private TextBox tbPeriodicity;
        private TextBox tbTitle;
        private TextBox tbImagePath;
        private DataGridView dgvPublications;
        private PictureBox pcbReviewImage;
        private PictureBox pcbCopyImage;
        private GroupBox groupBox2;
        private DateTimePicker dtpNewRevPublishDate;
        private Label label13;
        private TextBox tbNewRevNumber;
        private Label label12;
        private Button btnValidateReception;
        private PictureBox pcbNewRevCopyImage;
        private Label label15;
        private Button btnNewRevSearch;
        private TextBox tbNewRevImagePath;
        private Label label14;
    }
}
