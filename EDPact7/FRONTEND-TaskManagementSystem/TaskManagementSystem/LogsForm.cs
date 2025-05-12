using System.Data;

namespace TaskManagementSystem
{
    public partial class LogsForm : Form
    {
        private DataTable logsTable;

        public LogsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewLogs.MultiSelect = false;
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLogs.Size = new System.Drawing.Size(776, 329);
            this.dataGridViewLogs.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(713, 415);
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
            this.lblTitle.Size = new System.Drawing.Size(133, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "System Logs";
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(82, 45);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(121, 21);
            this.cmbFilterType.TabIndex = 6;
            // 
            // lblFilterType
            // 
            this.lblFilterType.AutoSize = true;
            this.lblFilterType.Location = new System.Drawing.Point(13, 48);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(63, 13);
            this.lblFilterType.TabIndex = 7;
            this.lblFilterType.Text = "Filter Type:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(282, 45);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(100, 20);
            this.dtpStartDate.TabIndex = 8;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(218, 48);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 9;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(451, 45);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(100, 20);
            this.dtpEndDate.TabIndex = 10;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(390, 48);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 11;
            this.lblEndDate.Text = "End Date:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(557, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Apply Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(638, 43);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilter.TabIndex = 13;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // LogsForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblFilterType);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewLogs);
            this.Name = "LogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Logs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilter;

        private void LoadData()
        {
            // In a real application, this would load data from a database
            // For this example, we'll create sample data
            logsTable = new DataTable();
            logsTable.Columns.Add("log_id", typeof(int));
            logsTable.Columns.Add("user_id", typeof(int));
            logsTable.Columns.Add("user_name", typeof(string));
            logsTable.Columns.Add("action", typeof(string));
            logsTable.Columns.Add("log_time", typeof(DateTime));
            logsTable.Columns.Add("table_name", typeof(string));
            logsTable.Columns.Add("record_id", typeof(int));
            logsTable.Columns.Add("project_id", typeof(int));
            logsTable.Columns.Add("project_name", typeof(string));

            // Add sample data
            logsTable.Rows.Add(1, 1, "John Doe", "Created new project", DateTime.Now.AddDays(-10), "projects", 1, 1, "Website Redesign");
            logsTable.Rows.Add(2, 2, "Jane Smith", "Updated task", DateTime.Now.AddDays(-8), "tasks", 2, 1, "Website Redesign");
            logsTable.Rows.Add(3, 3, "Bob Johnson", "Assigned task", DateTime.Now.AddDays(-7), "task_assignments", 1, 1, "Website Redesign");
            logsTable.Rows.Add(4, 1, "John Doe", "Created new project", DateTime.Now.AddDays(-5), "projects", 2, 2, "Mobile App");
            logsTable.Rows.Add(5, 2, "Jane Smith", "Updated user", DateTime.Now.AddDays(-3), "users", 3, null, null);
            logsTable.Rows.Add(6, 3, "Bob Johnson", "Completed task", DateTime.Now.AddDays(-1), "tasks", 2, 1, "Website Redesign");

            // Set up the DataGridView
            dataGridViewLogs.DataSource = logsTable;
            dataGridViewLogs.Columns["log_id"].Visible = false;
            dataGridViewLogs.Columns["user_id"].Visible = false;
            dataGridViewLogs.Columns["record_id"].Visible = false;
            dataGridViewLogs.Columns["project_id"].Visible = false;

            // Load filter types
            LoadFilterTypes();

            // Set default date range
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
        }

        private void LoadFilterTypes()
        {
            cmbFilterType.Items.Clear();
            cmbFilterType.Items.Add("All");
            cmbFilterType.Items.Add("Users");
            cmbFilterType.Items.Add("Tasks");
            cmbFilterType.Items.Add("Projects");
            cmbFilterType.Items.Add("Departments");
            cmbFilterType.Items.Add("Roles");
            cmbFilterType.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // In a real application, this would filter data from the database
            // For this example, we'll just filter the DataTable
            string filterType = cmbFilterType.SelectedItem.ToString();
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1); // End of the selected day

            DataView dv = logsTable.DefaultView;

            if (filterType == "All")
            {
                dv.RowFilter = $"log_time >= '#{startDate.ToString("yyyy-MM-dd HH:mm:ss")}#' AND log_time <= '#{endDate.ToString("yyyy-MM-dd HH:mm:ss")}#'";
            }
            else
            {
                string tableName = filterType.ToLower();
                if (tableName.EndsWith("s"))
                {
                    tableName = tableName.Substring(0, tableName.Length - 1);
                }

                dv.RowFilter = $"table_name = '{tableName}' AND log_time >= '#{startDate.ToString("yyyy-MM-dd HH:mm:ss")}#' AND log_time <= '#{endDate.ToString("yyyy-MM-dd HH:mm:ss")}#'";
            }

            dataGridViewLogs.DataSource = dv.ToTable();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbFilterType.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;

            dataGridViewLogs.DataSource = logsTable;
        }
    }
}