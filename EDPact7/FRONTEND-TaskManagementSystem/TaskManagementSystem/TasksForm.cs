using System.Data;

namespace TaskManagementSystem
{
    public partial class TasksForm : Form
    {
        private DataTable tasksTable;

        public TasksForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.cmbAssignedTo = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AllowUserToAddRows = false;
            this.dataGridViewTasks.AllowUserToDeleteRows = false;
            this.dataGridViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewTasks.MultiSelect = false;
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewTasks.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(93, 306);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(174, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(713, 306);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Manage Tasks";
            // 
            // panelControls
            // 
            this.panelControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControls.Controls.Add(this.btnCancel);
            this.panelControls.Controls.Add(this.btnSave);
            this.panelControls.Controls.Add(this.dtpDueDate);
            this.panelControls.Controls.Add(this.lblDueDate);
            this.panelControls.Controls.Add(this.cmbStatus);
            this.panelControls.Controls.Add(this.lblStatus);
            this.panelControls.Controls.Add(this.cmbAssignedTo);
            this.panelControls.Controls.Add(this.lblAssignedTo);
            this.panelControls.Controls.Add(this.cmbProject);
            this.panelControls.Controls.Add(this.lblProject);
            this.panelControls.Controls.Add(this.txtTaskName);
            this.panelControls.Controls.Add(this.lblTaskName);
            this.panelControls.Location = new System.Drawing.Point(12, 335);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(776, 103);
            this.panelControls.TabIndex = 6;
            this.panelControls.Visible = false;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(3, 9);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(65, 13);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Task Name:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(74, 6);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(200, 20);
            this.txtTaskName.TabIndex = 1;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(280, 9);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Project:";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(329, 6);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(150, 21);
            this.cmbProject.TabIndex = 3;
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Location = new System.Drawing.Point(485, 9);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(69, 13);
            this.lblAssignedTo.TabIndex = 4;
            this.lblAssignedTo.Text = "Assigned To:";
            // 
            // cmbAssignedTo
            // 
            this.cmbAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignedTo.FormattingEnabled = true;
            this.cmbAssignedTo.Location = new System.Drawing.Point(560, 6);
            this.cmbAssignedTo.Name = "cmbAssignedTo";
            this.cmbAssignedTo.Size = new System.Drawing.Size(150, 21);
            this.cmbAssignedTo.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(74, 33);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(280, 36);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 8;
            this.lblDueDate.Text = "Due Date:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(342, 33);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(137, 20);
            this.dtpDueDate.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(614, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(695, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TasksForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewTasks);
            this.Name = "TasksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.ComboBox cmbAssignedTo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private int editingTaskId = -1;
        private bool isAddMode = false;

        private void LoadData()
        {
            // In a real application, this would load data from a database
            // For this example, we'll create sample data
            tasksTable = new DataTable();
            tasksTable.Columns.Add("task_id", typeof(int));
            tasksTable.Columns.Add("task_name", typeof(string));
            tasksTable.Columns.Add("project_id", typeof(int));
            tasksTable.Columns.Add("project_name", typeof(string));
            tasksTable.Columns.Add("assigned_to", typeof(int));
            tasksTable.Columns.Add("assigned_to_name", typeof(string));
            tasksTable.Columns.Add("status", typeof(string));
            tasksTable.Columns.Add("due_date", typeof(DateTime));

            // Add sample data
            tasksTable.Rows.Add(1, "Design database schema", 1, "Website Redesign", 3, "Bob Johnson", "In Progress", DateTime.Now.AddDays(5));
            tasksTable.Rows.Add(2, "Create wireframes", 1, "Website Redesign", 2, "Jane Smith", "Completed", DateTime.Now.AddDays(-2));
            tasksTable.Rows.Add(3, "Implement login system", 2, "Mobile App", 3, "Bob Johnson", "Not Started", DateTime.Now.AddDays(10));

            // Set up the DataGridView
            dataGridViewTasks.DataSource = tasksTable;
            dataGridViewTasks.Columns["task_id"].Visible = false;
            dataGridViewTasks.Columns["project_id"].Visible = false;
            dataGridViewTasks.Columns["assigned_to"].Visible = false;

            // Load projects, users, and statuses for combo boxes
            LoadProjects();
            LoadUsers();
            LoadStatuses();
        }

        private void LoadProjects()
        {
            // In a real application, this would load from a database
            cmbProject.Items.Clear();
            cmbProject.DisplayMember = "Text";
            cmbProject.ValueMember = "Value";

            var items = new[] {
                new { Text = "Website Redesign", Value = 1 },
                new { Text = "Mobile App", Value = 2 },
                new { Text = "CRM Integration", Value = 3 }
            };

            foreach (var item in items)
            {
                cmbProject.Items.Add(item);
            }
        }

        private void LoadUsers()
        {
            // In a real application, this would load from a database
            cmbAssignedTo.Items.Clear();
            cmbAssignedTo.DisplayMember = "Text";
            cmbAssignedTo.ValueMember = "Value";

            var items = new[] {
                new { Text = "John Doe", Value = 1 },
                new { Text = "Jane Smith", Value = 2 },
                new { Text = "Bob Johnson", Value = 3 }
            };

            foreach (var item in items)
            {
                cmbAssignedTo.Items.Add(item);
            }
        }

        private void LoadStatuses()
        {
            // In a real application, this would load from a database
            cmbStatus.Items.Clear();

            var items = new[] {
                "Not Started",
                "In Progress",
                "On Hold",
                "Completed",
                "Cancelled"
            };

            foreach (var item in items)
            {
                cmbStatus.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            editingTaskId = -1;

            // Clear form fields
            txtTaskName.Text = "";
            cmbProject.SelectedIndex = -1;
            cmbAssignedTo.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtpDueDate.Value = DateTime.Now.AddDays(7);

            // Show the panel
            panelControls.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            isAddMode = false;
            DataGridViewRow row = dataGridViewTasks.SelectedRows[0];
            editingTaskId = Convert.ToInt32(row.Cells["task_id"].Value);

            // Populate form fields
            txtTaskName.Text = row.Cells["task_name"].Value.ToString();

            // Set project
            int projectId = Convert.ToInt32(row.Cells["project_id"].Value);
            for (int i = 0; i < cmbProject.Items.Count; i++)
            {
                dynamic item = cmbProject.Items[i];
                if (item.Value == projectId)
                {
                    cmbProject.SelectedIndex = i;
                    break;
                }
            }

            // Set assigned to
            int assignedTo = Convert.ToInt32(row.Cells["assigned_to"].Value);
            for (int i = 0; i < cmbAssignedTo.Items.Count; i++)
            {
                dynamic item = cmbAssignedTo.Items[i];
                if (item.Value == assignedTo)
                {
                    cmbAssignedTo.SelectedIndex = i;
                    break;
                }
            }

            // Set status
            string status = row.Cells["status"].Value.ToString();
            cmbStatus.SelectedItem = status;

            // Set due date
            dtpDueDate.Value = Convert.ToDateTime(row.Cells["due_date"].Value);

            // Show the panel
            panelControls.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewTasks.SelectedRows[0];
                int taskId = Convert.ToInt32(row.Cells["task_id"].Value);

                // In a real application, this would delete from the database
                // For this example, we'll just remove from the DataTable
                foreach (DataRow dataRow in tasksTable.Rows)
                {
                    if (Convert.ToInt32(dataRow["task_id"]) == taskId)
                    {
                        dataRow.Delete();
                        break;
                    }
                }

                tasksTable.AcceptChanges();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtTaskName.Text) ||
                cmbProject.SelectedIndex == -1 ||
                cmbAssignedTo.SelectedIndex == -1 ||
                cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get values from form
            string taskName = txtTaskName.Text;

            dynamic selectedProject = cmbProject.SelectedItem;
            int projectId = selectedProject.Value;
            string projectName = selectedProject.Text;

            dynamic selectedUser = cmbAssignedTo.SelectedItem;
            int assignedTo = selectedUser.Value;
            string assignedToName = selectedUser.Text;

            string status = cmbStatus.SelectedItem.ToString();
            DateTime dueDate = dtpDueDate.Value;

            if (isAddMode)
            {
                // In a real application, this would insert into the database
                // For this example, we'll just add to the DataTable
                int newId = 1;
                if (tasksTable.Rows.Count > 0)
                {
                    newId = tasksTable.AsEnumerable().Max(row => row.Field<int>("task_id")) + 1;
                }

                tasksTable.Rows.Add(newId, taskName, projectId, projectName, assignedTo, assignedToName, status, dueDate);
            }
            else
            {
                // In a real application, this would update the database
                // For this example, we'll just update the DataTable
                foreach (DataRow row in tasksTable.Rows)
                {
                    if (Convert.ToInt32(row["task_id"]) == editingTaskId)
                    {
                        row["task_name"] = taskName;
                        row["project_id"] = projectId;
                        row["project_name"] = projectName;
                        row["assigned_to"] = assignedTo;
                        row["assigned_to_name"] = assignedToName;
                        row["status"] = status;
                        row["due_date"] = dueDate;
                        break;
                    }
                }
            }

            tasksTable.AcceptChanges();
            panelControls.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelControls.Visible = false;
        }
    }
}