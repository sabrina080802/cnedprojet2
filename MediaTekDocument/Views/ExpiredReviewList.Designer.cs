namespace MediaTekDocument.Views
{
    partial class ExpiredReviewList
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
            dgvSubscriptionList = new DataGridView();
            label1 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubscriptionList).BeginInit();
            SuspendLayout();
            // 
            // dgvSubscriptionList
            // 
            dgvSubscriptionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubscriptionList.Location = new Point(12, 45);
            dgvSubscriptionList.Name = "dgvSubscriptionList";
            dgvSubscriptionList.Size = new Size(776, 272);
            dgvSubscriptionList.TabIndex = 0;
            dgvSubscriptionList.ReadOnly = true;
            dgvSubscriptionList.MultiSelect = false;
            dgvSubscriptionList.AllowUserToAddRows = false;
            dgvSubscriptionList.AllowUserToDeleteRows = false;
            dgvSubscriptionList.AllowUserToResizeColumns = false;
            dgvSubscriptionList.AllowUserToResizeRows = false;
            dgvSubscriptionList.RowHeadersVisible = false;
            dgvSubscriptionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubscriptionList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubscriptionList.ColumnHeaderMouseClick += DgvData_ColumnHeaderMouseClick;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(543, 25);
            label1.TabIndex = 1;
            label1.Text = "Liste des abonnements qui expirent dans les 30 prochains jours";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.Location = new Point(322, 323);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(153, 34);
            btnClose.TabIndex = 2;
            btnClose.Text = "Terminer";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ExpiredReviewList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(dgvSubscriptionList);
            Name = "ExpiredReviewList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpiredReviewList";
            ((System.ComponentModel.ISupportInitialize)dgvSubscriptionList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView dgvSubscriptionList;
        private Label label1;
        private Button btnClose;
    }
}