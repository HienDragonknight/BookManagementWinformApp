namespace BookManagement_HoangNgocTrinh
{
    partial class Login
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
            Label lblUsername;
            Label label1;
            txtLoginName = new TextBox();
            txtLoginPassword = new TextBox();
            btnLogin = new Button();
            btnLoginQuit = new Button();
            lblUsername = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Yellow;
            lblUsername.Location = new Point(88, 131);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Email: ";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            lblUsername.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(88, 209);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 1;
            label1.Text = "Password: ";
            // 
            // txtLoginName
            // 
            txtLoginName.Location = new Point(244, 131);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(307, 31);
            txtLoginName.TabIndex = 2;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(244, 221);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(307, 31);
            txtLoginPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(244, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLoginQuit
            // 
            btnLoginQuit.Location = new Point(439, 289);
            btnLoginQuit.Name = "btnLoginQuit";
            btnLoginQuit.Size = new Size(112, 34);
            btnLoginQuit.TabIndex = 5;
            btnLoginQuit.Text = "Quit";
            btnLoginQuit.UseVisualStyleBackColor = true;
            btnLoginQuit.Click += btnLoginQuit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoginQuit);
            Controls.Add(btnLogin);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginName);
            Controls.Add(label1);
            Controls.Add(lblUsername);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoginName;
        private TextBox txtLoginPassword;
        private Button btnLogin;
        private Button btnLoginQuit;
    }
}