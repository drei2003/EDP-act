namespace EDPact7
{
    partial class roles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblRoleId;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
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
            lblRoleId = new Label();
            txtRoleId = new TextBox();
            lblRoleName = new Label();
            txtRoleName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblRoleId
            // 
            lblRoleId.AutoSize = true;
            lblRoleId.Location = new Point(50, 30);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(47, 15);
            lblRoleId.TabIndex = 0;
            lblRoleId.Text = "Role ID:";
            // 
            // txtRoleId
            // 
            txtRoleId.Location = new Point(150, 30);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.Size = new Size(200, 23);
            txtRoleId.TabIndex = 1;
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Location = new Point(50, 70);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(68, 15);
            lblRoleName.TabIndex = 2;
            lblRoleName.Text = "Role Name:";
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(150, 70);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(200, 23);
            txtRoleName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 110);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // roles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 200);
            Controls.Add(lblRoleId);
            Controls.Add(txtRoleId);
            Controls.Add(lblRoleName);
            Controls.Add(txtRoleName);
            Controls.Add(btnSave);
            Name = "roles";
            Text = "Roles";
            Load += roles_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        // Add this method to the 'roles' class
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add your save logic here
            MessageBox.Show("Save button clicked!");
        }

        #endregion
    }
}