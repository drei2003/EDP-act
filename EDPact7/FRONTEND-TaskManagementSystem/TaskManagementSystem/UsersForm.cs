using System.Data;

namespace TaskManagementSystem
{
    public partial class UsersForm : Form
    {
        private DataTable usersTable;

        public UsersForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewUsers.TabIndex = 0;
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
            this.lblTitle.Text = "Manage Users";
            // 
            // panelControls
            // 
            this.panelControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControls.Controls.Add(this.btnCancel);
            this.panelControls.Controls.Add(this.btnSave);
            this.panelControls.Controls.Add(this.cmbRole);
            this.panelControls.Controls.Add(this.lblRole);
            this.panelControls.Controls.Add(this.cmbDepartment);
            this.panelControls.Controls.Add(this.lblDepartment);
            this.panelControls.Controls.Add(this.txtPhone);
            this.panelControls.Controls.Add(this.lblPhone);
            this.panelControls.Controls.Add(this.txtEmail);
            this.panelControls.Controls.Add(this.lblEmail);
            this.panelControls.Controls.Add(this.txtLastName);
            this.panelControls.Controls.Add(this.lblLastName);
            this.panelControls.Controls.Add(this.txtFirstName);
            this.panelControls.Controls.Add(this.lblFirstName);
            this.panelControls.Location = new System.Drawing.Point(12, 335);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(776, 103);
            this.panelControls.TabIndex = 6;
            this.panelControls.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(69, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(225, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(292, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(448, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(489, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 35);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(69, 32);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(225, 35);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(292, 32);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(150, 21);
            this.cmbDepartment.TabIndex = 9;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(448, 35);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(489, 32);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(200, 21);
            this.cmbRole.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(614, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(695, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UsersForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private int editingUserId = -1;
        private bool isAddMode = false;

        private void LoadData()
        {
            // In a real application, this would load data from a database
            // For this example, we'll create sample data
            usersTable = new DataTable();
            usersTable.Columns.Add("user_id", typeof(int));
            usersTable.Columns.Add("first_name", typeof(string));
            usersTable.Columns.Add("last_name", typeof(string));
            usersTable.Columns.Add("email", typeof(string));
            usersTable.Columns.Add("phone", typeof(string));
            usersTable.Columns.Add("department_id", typeof(int));
            usersTable.Columns.Add("department_name", typeof(string));
            usersTable.Columns.Add("role_id", typeof(int));
            usersTable.Columns.Add("role_name", typeof(string));

            // Add sample data
            usersTable.Rows.Add(1, "John", "Doe", "john.doe@example.com", "555-1234", 1, "IT", 1, "Admin");
            usersTable.Rows.Add(2, "Jane", "Smith", "jane.smith@example.com", "555-5678", 2, "HR", 2, "Manager");
            usersTable.Rows.Add(3, "Bob", "Johnson", "bob.johnson@example.com", "555-9012", 1, "IT", 3, "Developer");

            // Set up the DataGridView
            dataGridViewUsers.DataSource = usersTable;
            dataGridViewUsers.Columns["user_id"].Visible = false;
            dataGridViewUsers.Columns["department_id"].Visible = false;
            dataGridViewUsers.Columns["role_id"].Visible = false;

            // Load departments and roles for combo boxes
            LoadDepartments();
            LoadRoles();
        }

        private void LoadDepartments()
        {
            // In a real application, this would load from a database
            cmbDepartment.Items.Clear();
            cmbDepartment.DisplayMember = "Text";
            cmbDepartment.ValueMember = "Value";

            var items = new[] {
                new { Text = "IT", Value = 1 },
                new { Text = "HR", Value = 2 },
                new { Text = "Finance", Value = 3 },
                new { Text = "Marketing", Value = 4 }
            };

            foreach (var item in items)
            {
                cmbDepartment.Items.Add(item);
            }
        }

        private void LoadRoles()
        {
            // In a real application, this would load from a database
            cmbRole.Items.Clear();
            cmbRole.DisplayMember = "Text";
            cmbRole.ValueMember = "Value";

            var items = new[] {
                new { Text = "Admin", Value = 1 },
                new { Text = "Manager", Value = 2 },
                new { Text = "Developer", Value = 3 },
                new { Text = "Analyst", Value = 4 }
            };

            foreach (var item in items)
            {
                cmbRole.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            editingUserId = -1;

            // Clear form fields
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbRole.SelectedIndex = -1;

            // Show the panel
            panelControls.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            isAddMode = false;
            DataGridViewRow row = dataGridViewUsers.SelectedRows[0];
            editingUserId = Convert.ToInt32(row.Cells["user_id"].Value);

            // Populate form fields
            txtFirstName.Text = row.Cells["first_name"].Value.ToString();
            txtLastName.Text = row.Cells["last_name"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            txtPhone.Text = row.Cells["phone"].Value.ToString();

            // Set department and role
            int departmentId = Convert.ToInt32(row.Cells["department_id"].Value);
            int roleId = Convert.ToInt32(row.Cells["role_id"].Value);

            for (int i = 0; i < cmbDepartment.Items.Count; i++)
            {
                dynamic item = cmbDepartment.Items[i];
                if (item.Value == departmentId)
                {
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbRole.Items.Count; i++)
            {
                dynamic item = cmbRole.Items[i];
                if (item.Value == roleId)
                {
                    cmbRole.SelectedIndex = i;
                    break;
                }
            }

            // Show the panel
            panelControls.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewUsers.SelectedRows[0];
                int userId = Convert.ToInt32(row.Cells["user_id"].Value);

                // In a real application, this would delete from the database
                // For this example, we'll just remove from the DataTable
                foreach (DataRow dataRow in usersTable.Rows)
                {
                    if (Convert.ToInt32(dataRow["user_id"]) == userId)
                    {
                        dataRow.Delete();
                        break;
                    }
                }

                usersTable.AcceptChanges();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cmbDepartment.SelectedIndex == -1 ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get values from form
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            dynamic selectedDepartment = cmbDepartment.SelectedItem;
            int departmentId = selectedDepartment.Value;
            string departmentName = selectedDepartment.Text;

            dynamic selectedRole = cmbRole.SelectedItem;
            int roleId = selectedRole.Value;
            string roleName = selectedRole.Text;

            if (isAddMode)
            {
                // In a real application, this would insert into the database
                // For this example, we'll just add to the DataTable
                int newId = 1;
                if (usersTable.Rows.Count > 0)
                {
                    newId = usersTable.AsEnumerable().Max(row => row.Field<int>("user_id")) + 1;
                }

                usersTable.Rows.Add(newId, firstName, lastName, email, phone, departmentId, departmentName, roleId, roleName);
            }
            else
            {
                // In a real application, this would update the database
                // For this example, we'll just update the DataTable
                foreach (DataRow row in usersTable.Rows)
                {
                    if (Convert.ToInt32(row["user_id"]) == editingUserId)
                    {
                        row["first_name"] = firstName;
                        row["last_name"] = lastName;
                        row["email"] = email;
                        row["phone"] = phone;
                        row["department_id"] = departmentId;
                        row["department_name"] = departmentName;
                        row["role_id"] = roleId;
                        row["role_name"] = roleName;
                        break;
                    }
                }
            }

            usersTable.AcceptChanges();
            panelControls.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelControls.Visible = false;
        }
    }
}