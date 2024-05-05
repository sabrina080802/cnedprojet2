namespace MediaTekDocument.Views.Pages
{
    partial class Books
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
            components = new System.ComponentModel.Container();
            dataList = new Components.BookSearch();
            groupBox1 = new GroupBox();
            btnEdit = new Button();
            tbImagePath = new TextBox();
            cbDepartment = new ComboBox();
            cbPublic = new ComboBox();
            cbGender = new ComboBox();
            tbCollection = new TextBox();
            tbAuthor = new TextBox();
            tbTitle = new TextBox();
            tbISBN = new TextBox();
            label10 = new Label();
            tbNumber = new TextBox();
            pbImage = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            imageList1 = new ImageList(components);
            btnDeleteBook = new Button();
            btnNewBook = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // dataList
            // 
            dataList.Location = new Point(3, 3);
            dataList.Name = "dataList";
            dataList.Size = new Size(859, 336);
            dataList.TabIndex = 0;
            dataList.DataSelectionChanged += dataList_DataSelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(tbImagePath);
            groupBox1.Controls.Add(cbDepartment);
            groupBox1.Controls.Add(cbPublic);
            groupBox1.Controls.Add(cbGender);
            groupBox1.Controls.Add(tbCollection);
            groupBox1.Controls.Add(tbAuthor);
            groupBox1.Controls.Add(tbTitle);
            groupBox1.Controls.Add(tbISBN);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tbNumber);
            groupBox1.Controls.Add(pbImage);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 8F);
            groupBox1.Location = new Point(3, 374);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(859, 301);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations détaillées";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(350, 262);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(164, 33);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Modifier les informations";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.MouseClick += btnEdit_MouseClick;
            // 
            // tbImagePath
            // 
            tbImagePath.Location = new Point(166, 222);
            tbImagePath.Name = "tbImagePath";
            tbImagePath.Size = new Size(390, 22);
            tbImagePath.TabIndex = 19;
            // 
            // cbDepartment
            // 
            cbDepartment.DisplayMember = "Libelle";
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(166, 195);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(212, 21);
            cbDepartment.TabIndex = 18;
            // 
            // cbPublic
            // 
            cbPublic.DisplayMember = "Libelle";
            cbPublic.FormattingEnabled = true;
            cbPublic.Location = new Point(166, 168);
            cbPublic.Name = "cbPublic";
            cbPublic.Size = new Size(212, 21);
            cbPublic.TabIndex = 17;
            // 
            // cbGender
            // 
            cbGender.DisplayMember = "Libelle";
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(166, 141);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(212, 21);
            cbGender.TabIndex = 16;
            // 
            // tbCollection
            // 
            tbCollection.Location = new Point(166, 113);
            tbCollection.Name = "tbCollection";
            tbCollection.Size = new Size(390, 22);
            tbCollection.TabIndex = 15;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(166, 85);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(212, 22);
            tbAuthor.TabIndex = 14;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(166, 57);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(390, 22);
            tbTitle.TabIndex = 13;
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(456, 29);
            tbISBN.Name = "tbISBN";
            tbISBN.ReadOnly = true;
            tbISBN.Size = new Size(100, 22);
            tbISBN.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(370, 32);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 11;
            label10.Text = "Code ISBN :";
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(166, 29);
            tbNumber.Name = "tbNumber";
            tbNumber.ReadOnly = true;
            tbNumber.Size = new Size(130, 22);
            tbNumber.TabIndex = 10;
            // 
            // pbImage
            // 
            pbImage.BackColor = Color.White;
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(608, 57);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(247, 187);
            pbImage.TabIndex = 9;
            pbImage.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(608, 32);
            label9.Name = "label9";
            label9.Size = new Size(54, 17);
            label9.TabIndex = 8;
            label9.Text = "Image :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 225);
            label8.Name = "label8";
            label8.Size = new Size(132, 17);
            label8.TabIndex = 7;
            label8.Text = "Chemin de l'image :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 197);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 6;
            label7.Text = "Rayon :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 170);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 5;
            label6.Text = "Public :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 143);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 4;
            label5.Text = "Genre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 116);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 3;
            label4.Text = "Collection :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 88);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 2;
            label3.Text = "Auteur(e) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 60);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 1;
            label2.Text = "Titre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 32);
            label1.Name = "label1";
            label1.Size = new Size(152, 17);
            label1.TabIndex = 0;
            label1.Text = "Numéro du document :";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.Red;
            btnDeleteBook.FlatAppearance.BorderColor = Color.Red;
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Location = new Point(741, 345);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(114, 23);
            btnDeleteBook.TabIndex = 2;
            btnDeleteBook.Text = "Supprimer le livre";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnNewBook
            // 
            btnNewBook.Location = new Point(611, 345);
            btnNewBook.Name = "btnNewBook";
            btnNewBook.Size = new Size(124, 23);
            btnNewBook.TabIndex = 3;
            btnNewBook.Text = "Nouveau livre";
            btnNewBook.UseVisualStyleBackColor = true;
            btnNewBook.Click += btnNewBook_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNewBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(groupBox1);
            Controls.Add(dataList);
            Name = "Books";
            Size = new Size(864, 678);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Components.BookSearch dataList;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ImageList imageList1;
        private PictureBox pbImage;
        private TextBox tbImagePath;
        private ComboBox cbDepartment;
        private ComboBox cbPublic;
        private ComboBox cbGender;
        private TextBox tbCollection;
        private TextBox tbAuthor;
        private TextBox tbTitle;
        private TextBox tbISBN;
        private Label label10;
        private TextBox tbNumber;
        private Button btnEdit;
        private Button btnDeleteBook;
        private Button btnNewBook;
    }
}
