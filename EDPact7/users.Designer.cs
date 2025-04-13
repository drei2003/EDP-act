namespace EDPact7
{
    partial class users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDepartmentId;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.Button btnSave;

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
            txtUserId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtDepartmentId = new TextBox();
            txtRoleId = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(72, 15);
            txtUserId.Name = "txtUserId";
            txtUserId.PlaceholderText = "User ID";
            txtUserId.Size = new Size(200, 23);
            txtUserId.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(72, 55);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(72, 95);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(72, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(72, 175);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 4;
            // 
            // txtDepartmentId
            // 
            txtDepartmentId.Location = new Point(72, 215);
            txtDepartmentId.Name = "txtDepartmentId";
            txtDepartmentId.PlaceholderText = "Department ID";
            txtDepartmentId.Size = new Size(200, 23);
            txtDepartmentId.TabIndex = 5;
            // 
            // txtRoleId
            // 
            txtRoleId.Location = new Point(72, 255);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.PlaceholderText = "Role ID";
            txtRoleId.Size = new Size(200, 23);
            txtRoleId.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(72, 295);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 30);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // users
            // 
            ClientSize = new Size(345, 350);
            Controls.Add(txtUserId);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtDepartmentId);
            Controls.Add(txtRoleId);
            Controls.Add(btnSave);
            Name = "users";
            Text = "User Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}