namespace TaskManagementSystem
{
    partial class SignupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSignUp;

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
            lblUsername = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnSignUp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
                    SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.DarkSlateGray;
            lblUsername.Location = new Point(138, 115);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.DarkSlateGray;
            lblPassword.Location = new Point(138, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 19);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.DarkSlateGray;
            lblEmail.Location = new Point(138, 215);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(123, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Confirm Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(138, 137);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(292, 25);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(138, 187);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(292, 25);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(138, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 25);
            txtEmail.TabIndex = 5;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.Highlight;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(138, 288);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(292, 35);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Create Account";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += BtnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(198, 40);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 7;
            label1.Text = "Create an Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(159, 70);
            label2.Name = "label2";
            label2.Size = new Size(255, 15);
            label2.TabIndex = 8;
            label2.Text = "Enter your details below to create your account";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(179, 342);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 9;
            label3.Text = "Already have an account?";
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F);
            linkLabel1.LinkColor = SystemColors.Highlight;
            linkLabel1.Location = new Point(327, 342);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(580, 435);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "SignupForm";
            Text = "Sign Up";
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}