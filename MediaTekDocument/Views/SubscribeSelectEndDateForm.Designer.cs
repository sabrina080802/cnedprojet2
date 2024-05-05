namespace MediaTekDocument.Views
{
    partial class SubscribeSelectEndDateForm
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
            dtpEndDate = new DateTimePicker();
            btnValidate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "Date de fin de l'abonnement :";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(234, 23);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(141, 23);
            dtpEndDate.TabIndex = 1;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(234, 65);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(141, 31);
            btnValidate.TabIndex = 2;
            btnValidate.Text = "Créer l'abonnement";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 65);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SubscribeSelectEndDateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 106);
            Controls.Add(btnCancel);
            Controls.Add(btnValidate);
            Controls.Add(dtpEndDate);
            Controls.Add(label1);
            Name = "SubscribeSelectEndDateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sélectionnez une date de fin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpEndDate;
        private Button btnValidate;
        private Button btnCancel;
    }
}