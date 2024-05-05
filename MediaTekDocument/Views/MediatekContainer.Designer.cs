namespace MediaTekDocument.Views
{
    partial class MediatekContainer
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
            tcPages = new TabControl();
            tabPage1 = new TabPage();
            books = new Pages.Books();
            Dvd = new TabPage();
            dvds = new Pages.Dvds();
            Revues = new TabPage();
            reviews = new Pages.Reviews();
            tabPage3 = new TabPage();
            reviewsPublication1 = new Pages.ReviewsPublication();
            tabPage4 = new TabPage();
            commandBooks1 = new Pages.CommandBooks();
            tabPage5 = new TabPage();
            commandDvd1 = new Pages.CommandDvd();
            tabPage2 = new TabPage();
            reviewsSubscription1 = new Pages.ReviewsSubscription();
            tcPages.SuspendLayout();
            tabPage1.SuspendLayout();
            Dvd.SuspendLayout();
            Revues.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tcPages
            // 
            tcPages.Controls.Add(tabPage1);
            tcPages.Controls.Add(Dvd);
            tcPages.Controls.Add(Revues);
            tcPages.Controls.Add(tabPage3);
            tcPages.Controls.Add(tabPage4);
            tcPages.Controls.Add(tabPage5);
            tcPages.Controls.Add(tabPage2);
            tcPages.Dock = DockStyle.Fill;
            tcPages.Location = new Point(0, 0);
            tcPages.Name = "tcPages";
            tcPages.SelectedIndex = 0;
            tcPages.Size = new Size(880, 711);
            tcPages.TabIndex = 0;
            tcPages.SelectedIndexChanged += tcPages_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(books);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 683);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Livres";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // books
            // 
            books.Dock = DockStyle.Fill;
            books.Location = new Point(3, 3);
            books.Name = "books";
            books.Size = new Size(866, 677);
            books.TabIndex = 0;
            // 
            // Dvd
            // 
            Dvd.Controls.Add(dvds);
            Dvd.Location = new Point(4, 24);
            Dvd.Name = "Dvd";
            Dvd.Padding = new Padding(3);
            Dvd.Size = new Size(872, 683);
            Dvd.TabIndex = 1;
            Dvd.Text = "DVD";
            Dvd.UseVisualStyleBackColor = true;
            // 
            // dvds
            // 
            dvds.Dock = DockStyle.Fill;
            dvds.Location = new Point(3, 3);
            dvds.Name = "dvds";
            dvds.Size = new Size(866, 677);
            dvds.TabIndex = 0;
            // 
            // Revues
            // 
            Revues.Controls.Add(reviews);
            Revues.Location = new Point(4, 24);
            Revues.Name = "Revues";
            Revues.Padding = new Padding(3);
            Revues.Size = new Size(872, 683);
            Revues.TabIndex = 2;
            Revues.Text = "Revues";
            Revues.UseVisualStyleBackColor = true;
            // 
            // reviews
            // 
            reviews.Dock = DockStyle.Fill;
            reviews.Location = new Point(3, 3);
            reviews.Name = "reviews";
            reviews.Size = new Size(866, 677);
            reviews.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(reviewsPublication1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(872, 683);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Parution des revues";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // reviewsPublication1
            // 
            reviewsPublication1.Dock = DockStyle.Fill;
            reviewsPublication1.Location = new Point(3, 3);
            reviewsPublication1.Name = "reviewsPublication1";
            reviewsPublication1.Size = new Size(866, 677);
            reviewsPublication1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(commandBooks1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(872, 683);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Commandes livres";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // commandBooks1
            // 
            commandBooks1.Dock = DockStyle.Fill;
            commandBooks1.Location = new Point(3, 3);
            commandBooks1.Name = "commandBooks1";
            commandBooks1.Size = new Size(866, 677);
            commandBooks1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(commandDvd1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(872, 683);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "Commandes DVD";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // commandDvd1
            // 
            commandDvd1.Dock = DockStyle.Fill;
            commandDvd1.Location = new Point(3, 3);
            commandDvd1.Name = "commandDvd1";
            commandDvd1.Size = new Size(866, 677);
            commandDvd1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(reviewsSubscription1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(872, 683);
            tabPage2.TabIndex = 6;
            tabPage2.Text = "Abonnements revues";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // reviewsSubscription1
            // 
            reviewsSubscription1.Dock = DockStyle.Fill;
            reviewsSubscription1.Location = new Point(3, 3);
            reviewsSubscription1.Name = "reviewsSubscription1";
            reviewsSubscription1.Size = new Size(866, 677);
            reviewsSubscription1.TabIndex = 0;
            // 
            // MediatekContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 711);
            Controls.Add(tcPages);
            Enabled = false;
            Name = "MediatekContainer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des documents de la Médiathèque";
            tcPages.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            Dvd.ResumeLayout(false);
            Revues.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcPages;
        private TabPage tabPage1;
        private TabPage Dvd;
        private Pages.Books books;
        private TabPage Revues;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Pages.Dvds dvds;
        private Pages.Reviews reviews;
        private Pages.ReviewsPublication reviewsPublication1;
        private Pages.CommandBooks commandBooks1;
        private Pages.CommandDvd commandDvd1;
        private TabPage tabPage2;
        private Pages.ReviewsSubscription reviewsSubscription1;
    }
}