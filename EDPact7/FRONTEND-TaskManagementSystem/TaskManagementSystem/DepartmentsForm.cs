using System.Data;

namespace TaskManagementSystem
{
    public partial class DepartmentsForm : Form
    {
        private DataTable departmentsTable;

        public DepartmentsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.AllowUserToAddRows = false;
            this.dataGridViewDepartments.AllowUserToDeleteRows = false;
            this.dataGridViewDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewDepartments.MultiSelect = false;
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.ReadOnly = true;
            this.dataGridViewDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewDepartments.TabIndex = 0;
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
            this.lblTitle.Size = new System.Drawing.Size(212, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Manage Departments";
            // 
            // panelControls
            // 
            this.panelControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControls.Controls.Add(this.btnCancel);
            this.panelControls.Controls.Add(this.btnSave);
            this.panelControls.Controls.Add(this.txtDepartmentName);
            this.panelControls.Controls.Add(this.lblDepartmentName);
            this.panelControls.Location = new System.Drawing.Point(12, 335);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(776, 103);
            this.panelControls.TabIndex = 6;
            this.panelControls.Visible = false;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(3, 9);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(96, 13);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "Department Name:";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(105, 6);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(200, 20);
            this.txtDepartmentName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(614, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(695, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DepartmentsForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Name = "DepartmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Departments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewDepartments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private int editingDepartmentId = -1;
        private bool isAddMode = false;

        private void LoadData()
        {
            // In a real application, this would load data from a database
            // For this example, we'll create sample data
            departmentsTable = new DataTable();
            departmentsTable.Columns.Add("department_id", typeof(int));
            departmentsTable.Columns.Add("department_name", typeof(string));

            // Add sample data
            departmentsTable.Rows.Add(1, "IT");
            departmentsTable.Rows.Add(2, "HR");
            departmentsTable.Rows.Add(3, "Finance");
            departmentsTable.Rows.Add(4, "Marketing");

            // Set up the DataGridView
            dataGridViewDepartments.DataSource = departmentsTable;
            dataGridViewDepartments.Columns["department_id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            editingDepartmentId = -1;

            // Clear form fields
            txtDepartmentName.Text = "";

            // Show the panel
            panelControls.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepartments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a department to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            isAddMode = false;
            DataGridViewRow row = dataGridViewDepartments.SelectedRows[0];
            editingDepartmentId = Convert.ToInt32(row.Cells["department_id"].Value);

            // Populate form fields
            txtDepartmentName.Text = row.Cells["department_name"].Value.ToString();

            // Show the panel
            panelControls.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepartments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a department to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewDepartments.SelectedRows[0];
                int departmentId = Convert.ToInt32(row.Cells["department_id"].Value);

                // In a real application, this would delete from the database
                // For this example, we'll just remove from the DataTable
                foreach (DataRow dataRow in departmentsTable.Rows)
                {
                    if (Convert.ToInt32(dataRow["department_id"]) == departmentId)
                    {
                        dataRow.Delete();
                        break;
                    }
                }

                departmentsTable.AcceptChanges();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                MessageBox.Show("Please enter a department name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get values from form
            string departmentName = txtDepartmentName.Text;

            if (isAddMode)
            {
                // In a real application, this would insert into the database
                // For this example, we'll just add to the DataTable
                int newId = 1;
                if (departmentsTable.Rows.Count > 0)
                {
                    newId = departmentsTable.AsEnumerable().Max(row => row.Field<int>("department_id")) + 1;
                }

                departmentsTable.Rows.Add(newId, departmentName);
            }
            else
            {
                // In a real application, this would update the database
                // For this example, we'll just update the DataTable
                foreach (DataRow row in departmentsTable.Rows)
                {
                    if (Convert.ToInt32(row["department_id"]) == editingDepartmentId)
                    {
                        row["department_name"] = departmentName;
                        break;
                    }
                }
            }

            departmentsTable.AcceptChanges();
            panelControls.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelControls.Visible = false;
        }
    }
}