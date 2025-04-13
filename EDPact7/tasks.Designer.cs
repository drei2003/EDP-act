namespace EDPact7
{
    partial class tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.TextBox txtAssignedTo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
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
            txtTaskId = new TextBox();
            txtTaskName = new TextBox();
            txtProjectId = new TextBox();
            txtAssignedTo = new TextBox();
            cmbStatus = new ComboBox();
            dtpDueDate = new DateTimePicker();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtTaskId
            // 
            txtTaskId.Location = new Point(28, 21);
            txtTaskId.Name = "txtTaskId";
            txtTaskId.PlaceholderText = "Task ID";
            txtTaskId.Size = new Size(194, 23);
            txtTaskId.TabIndex = 0;
            txtTaskId.TextChanged += txtTaskId_TextChanged;
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(28, 61);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.PlaceholderText = "Task Name";
            txtTaskName.Size = new Size(194, 23);
            txtTaskName.TabIndex = 1;
            // 
            // txtProjectId
            // 
            txtProjectId.Location = new Point(28, 101);
            txtProjectId.Name = "txtProjectId";
            txtProjectId.PlaceholderText = "Project ID";
            txtProjectId.Size = new Size(194, 23);
            txtProjectId.TabIndex = 2;
            txtProjectId.TextChanged += txtProjectId_TextChanged;
            // 
            // txtAssignedTo
            // 
            txtAssignedTo.Location = new Point(28, 141);
            txtAssignedTo.Name = "txtAssignedTo";
            txtAssignedTo.PlaceholderText = "Assigned To";
            txtAssignedTo.Size = new Size(194, 23);
            txtAssignedTo.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Completed" });
            cmbStatus.Location = new Point(28, 181);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(194, 23);
            cmbStatus.TabIndex = 4;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(28, 221);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(194, 23);
            dtpDueDate.TabIndex = 5;
            dtpDueDate.ValueChanged += dtpDueDate_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(28, 261);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tasks
            // 
            ClientSize = new Size(265, 320);
            Controls.Add(txtTaskId);
            Controls.Add(txtTaskName);
            Controls.Add(txtProjectId);
            Controls.Add(txtAssignedTo);
            Controls.Add(cmbStatus);
            Controls.Add(dtpDueDate);
            Controls.Add(btnSave);
            Name = "tasks";
            Text = "Task Management";
            ResumeLayout(false);
            PerformLayout();
        }
        // Add this method to the `tasks` class
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add your save logic here
            MessageBox.Show("Save button clicked!");
        }

        #endregion
    }
}