namespace MediaTekDocument.Views
{
    partial class DocumentSearchForm
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
            label1 = new Label();
            cbDocumentList = new ComboBox();
            btnValidate = new Button();
            label2 = new Label();
            nudCopyCount = new NumericUpDown();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCopyCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(8, 26);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom du document :";
            // 
            // cbDocumentList
            // 
            cbDocumentList.FormattingEnabled = true;
            cbDocumentList.Location = new Point(8, 44);
            cbDocumentList.Name = "cbDocumentList";
            cbDocumentList.Size = new Size(346, 23);
            cbDocumentList.TabIndex = 1;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(201, 114);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(153, 31);
            btnValidate.TabIndex = 2;
            btnValidate.Text = "Ajouter";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(8, 82);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre d'exemplaires :";
            // 
            // nudCopyCount
            // 
            nudCopyCount.Location = new Point(252, 80);
            nudCopyCount.Name = "nudCopyCount";
            nudCopyCount.Size = new Size(102, 23);
            nudCopyCount.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(8, 114);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 31);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DocumentSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 155);
            Controls.Add(btnCancel);
            Controls.Add(nudCopyCount);
            Controls.Add(label2);
            Controls.Add(btnValidate);
            Controls.Add(cbDocumentList);
            Controls.Add(label1);
            Name = "DocumentSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter un document à la commande";
            ((System.ComponentModel.ISupportInitialize)nudCopyCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbDocumentList;
        private Button btnValidate;
        private Label label2;
        private NumericUpDown nudCopyCount;
        private Button btnCancel;
    }
}