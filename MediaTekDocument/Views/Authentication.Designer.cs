namespace MediaTekDocument.Views
{
    partial class Authentication
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
            btnConnect = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 14F);
            btnConnect.Location = new Point(112, 207);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(131, 36);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connexion";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.MouseClick += btnConnect_MouseClick;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(70, 152);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(213, 29);
            tbPassword.TabIndex = 3;
            tbPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F);
            tbUsername.Location = new Point(70, 117);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(213, 29);
            tbUsername.TabIndex = 2;
            tbUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(106, 80);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "AUTHENTIFICATION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(43, 34);
            label1.Name = "label1";
            label1.Size = new Size(269, 37);
            label1.TabIndex = 0;
            label1.Text = "Mediatek Documents";
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 273);
            Controls.Add(btnConnect);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Authentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Médiathèque - Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label label2;
        private Label label1;
    }
}