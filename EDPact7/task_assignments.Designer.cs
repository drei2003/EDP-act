namespace EDPact7
{
    partial class task_assignments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblAssignedDate;
        private System.Windows.Forms.DateTimePicker dtpAssignedDate;
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
            lblTaskId = new Label();
            txtTaskId = new TextBox();
            lblUserId = new Label();
            txtUserId = new TextBox();
            lblAssignedDate = new Label();
            dtpAssignedDate = new DateTimePicker();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTaskId
            // 
            lblTaskId.AutoSize = true;
            lblTaskId.Location = new Point(50, 30);
            lblTaskId.Name = "lblTaskId";
            lblTaskId.Size = new Size(47, 15);
            lblTaskId.TabIndex = 0;
            lblTaskId.Text = "Task ID:";
            // 
            // txtTaskId
            // 
            txtTaskId.Location = new Point(150, 30);
            txtTaskId.Name = "txtTaskId";
            txtTaskId.Size = new Size(200, 23);
            txtTaskId.TabIndex = 1;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(50, 70);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(47, 15);
            lblUserId.TabIndex = 2;
            lblUserId.Text = "User ID:";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(150, 70);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(200, 23);
            txtUserId.TabIndex = 3;
            // 
            // lblAssignedDate
            // 
            lblAssignedDate.AutoSize = true;
            lblAssignedDate.Location = new Point(50, 110);
            lblAssignedDate.Name = "lblAssignedDate";
            lblAssignedDate.Size = new Size(85, 15);
            lblAssignedDate.TabIndex = 4;
            lblAssignedDate.Text = "Assigned Date:";
            // 
            // dtpAssignedDate
            // 
            dtpAssignedDate.Location = new Point(150, 110);
            dtpAssignedDate.Name = "dtpAssignedDate";
            dtpAssignedDate.Size = new Size(200, 23);
            dtpAssignedDate.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 150);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // task_assignments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 214);
            Controls.Add(lblTaskId);
            Controls.Add(txtTaskId);
            Controls.Add(lblUserId);
            Controls.Add(txtUserId);
            Controls.Add(lblAssignedDate);
            Controls.Add(dtpAssignedDate);
            Controls.Add(btnSave);
            Name = "task_assignments";
            Text = "Task Assignments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}