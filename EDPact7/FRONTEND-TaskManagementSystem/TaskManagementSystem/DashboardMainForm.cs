using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TaskManagementSystem
{
    public partial class DashboardMainForm : Form
    {
        // Sample data tables
        private DataTable usersTable;
        private DataTable tasksTable;
        private DataTable projectsTable;
        private DataTable logsTable;

        public DashboardMainForm()
        {
            InitializeComponent();
            LoadSampleData();
            UpdateDashboard();
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskAssignmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.tableLayoutPanelStats = new System.Windows.Forms.TableLayoutPanel();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.panelTasks = new System.Windows.Forms.Panel();
            this.lblTaskCount = new System.Windows.Forms.Label();
            this.lblTasksTitle = new System.Windows.Forms.Label();
            this.panelProjects = new System.Windows.Forms.Panel();
            this.lblProjectCount = new System.Windows.Forms.Label();
            this.lblProjectsTitle = new System.Windows.Forms.Label();
            this.panelDepartments = new System.Windows.Forms.Panel();
            this.lblDepartmentCount = new System.Windows.Forms.Label();
            this.lblDepartmentsTitle = new System.Windows.Forms.Label();
            this.panelTaskStatus = new System.Windows.Forms.Panel();
            this.panelTaskStatusChart = new System.Windows.Forms.Panel();
            this.lblTaskStatusTitle = new System.Windows.Forms.Label();
            this.panelRecentActivity = new System.Windows.Forms.Panel();
            this.dataGridViewRecentActivity = new System.Windows.Forms.DataGridView();
            this.lblRecentActivityTitle = new System.Windows.Forms.Label();
            this.panelUpcomingTasks = new System.Windows.Forms.Panel();
            this.dataGridViewUpcomingTasks = new System.Windows.Forms.DataGridView();
            this.lblUpcomingTasksTitle = new System.Windows.Forms.Label();
            this.panelQuickActions = new System.Windows.Forms.Panel();
            this.btnRefreshDashboard = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblQuickActionsTitle = new System.Windows.Forms.Label();
            this.panelProjectProgress = new System.Windows.Forms.Panel();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.lblProjectProgressTitle = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.tableLayoutPanelStats.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelTasks.SuspendLayout();
            this.panelProjects.SuspendLayout();
            this.panelDepartments.SuspendLayout();
            this.panelTaskStatus.SuspendLayout();
            this.panelRecentActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentActivity)).BeginInit();
            this.panelUpcomingTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingTasks)).BeginInit();
            this.panelQuickActions.SuspendLayout();
            this.panelProjectProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.taskAssignmentsToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tasksToolStripMenuItem.Text = "Tasks";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.tasksToolStripMenuItem_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.departmentsToolStripMenuItem.Text = "Departments";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // taskAssignmentsToolStripMenuItem
            // 
            this.taskAssignmentsToolStripMenuItem.Name = "taskAssignmentsToolStripMenuItem";
            this.taskAssignmentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taskAssignmentsToolStripMenuItem.Text = "Task Assignments";
            this.taskAssignmentsToolStripMenuItem.Click += new System.EventHandler(this.taskAssignmentsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblDashboardTitle);
            this.panelHeader.Controls.Add(this.lblCurrentDate);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 24);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1184, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(12, 14);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(339, 32);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Task Management Dashboard";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(884, 14);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(288, 32);
            this.lblCurrentDate.TabIndex = 1;
            this.lblCurrentDate.Text = "Monday, January 1, 2023";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelStats
            // 
            this.panelStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStats.Controls.Add(this.tableLayoutPanelStats);
            this.panelStats.Location = new System.Drawing.Point(12, 90);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1160, 100);
            this.panelStats.TabIndex = 3;
            // 
            // tableLayoutPanelStats
            // 
            this.tableLayoutPanelStats.ColumnCount = 4;
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStats.Controls.Add(this.panelUsers, 0, 0);
            this.tableLayoutPanelStats.Controls.Add(this.panelTasks, 1, 0);
            this.tableLayoutPanelStats.Controls.Add(this.panelProjects, 2, 0);
            this.tableLayoutPanelStats.Controls.Add(this.panelDepartments, 3, 0);
            this.tableLayoutPanelStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStats.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelStats.Name = "tableLayoutPanelStats";
            this.tableLayoutPanelStats.RowCount = 1;
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStats.Size = new System.Drawing.Size(1160, 100);
            this.tableLayoutPanelStats.TabIndex = 0;
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelUsers.Controls.Add(this.lblUserCount);
            this.panelUsers.Controls.Add(this.lblUsersTitle);
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsers.ForeColor = System.Drawing.Color.White;
            this.panelUsers.Location = new System.Drawing.Point(10, 10);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(10);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(270, 80);
            this.panelUsers.TabIndex = 0;
            // 
            // lblUserCount
            // 
            this.lblUserCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCount.Location = new System.Drawing.Point(0, 25);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(270, 55);
            this.lblUserCount.TabIndex = 1;
            this.lblUserCount.Text = "0";
            this.lblUserCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsersTitle
            // 
            this.lblUsersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersTitle.Location = new System.Drawing.Point(0, 0);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.Size = new System.Drawing.Size(270, 25);
            this.lblUsersTitle.TabIndex = 0;
            this.lblUsersTitle.Text = "Total Users";
            this.lblUsersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTasks
            // 
            this.panelTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panelTasks.Controls.Add(this.lblTaskCount);
            this.panelTasks.Controls.Add(this.lblTasksTitle);
            this.panelTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTasks.ForeColor = System.Drawing.Color.White;
            this.panelTasks.Location = new System.Drawing.Point(300, 10);
            this.panelTasks.Margin = new System.Windows.Forms.Padding(10);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Size = new System.Drawing.Size(270, 80);
            this.panelTasks.TabIndex = 1;
            // 
            // lblTaskCount
            // 
            this.lblTaskCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaskCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskCount.Location = new System.Drawing.Point(0, 25);
            this.lblTaskCount.Name = "lblTaskCount";
            this.lblTaskCount.Size = new System.Drawing.Size(270, 55);
            this.lblTaskCount.TabIndex = 1;
            this.lblTaskCount.Text = "0";
            this.lblTaskCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTasksTitle
            // 
            this.lblTasksTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTasksTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasksTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTasksTitle.Name = "lblTasksTitle";
            this.lblTasksTitle.Size = new System.Drawing.Size(270, 25);
            this.lblTasksTitle.TabIndex = 0;
            this.lblTasksTitle.Text = "Active Tasks";
            this.lblTasksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProjects
            // 
            this.panelProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelProjects.Controls.Add(this.lblProjectCount);
            this.panelProjects.Controls.Add(this.lblProjectsTitle);
            this.panelProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProjects.ForeColor = System.Drawing.Color.White;
            this.panelProjects.Location = new System.Drawing.Point(590, 10);
            this.panelProjects.Margin = new System.Windows.Forms.Padding(10);
            this.panelProjects.Name = "panelProjects";
            this.panelProjects.Size = new System.Drawing.Size(270, 80);
            this.panelProjects.TabIndex = 2;
            // 
            // lblProjectCount
            // 
            this.lblProjectCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjectCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectCount.Location = new System.Drawing.Point(0, 25);
            this.lblProjectCount.Name = "lblProjectCount";
            this.lblProjectCount.Size = new System.Drawing.Size(270, 55);
            this.lblProjectCount.TabIndex = 1;
            this.lblProjectCount.Text = "0";
            this.lblProjectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProjectsTitle
            // 
            this.lblProjectsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblProjectsTitle.Name = "lblProjectsTitle";
            this.lblProjectsTitle.Size = new System.Drawing.Size(270, 25);
            this.lblProjectsTitle.TabIndex = 0;
            this.lblProjectsTitle.Text = "Active Projects";
            this.lblProjectsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDepartments
            // 
            this.panelDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelDepartments.Controls.Add(this.lblDepartmentCount);
            this.panelDepartments.Controls.Add(this.lblDepartmentsTitle);
            this.panelDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDepartments.ForeColor = System.Drawing.Color.White;
            this.panelDepartments.Location = new System.Drawing.Point(880, 10);
            this.panelDepartments.Margin = new System.Windows.Forms.Padding(10);
            this.panelDepartments.Name = "panelDepartments";
            this.panelDepartments.Size = new System.Drawing.Size(270, 80);
            this.panelDepartments.TabIndex = 3;
            // 
            // lblDepartmentCount
            // 
            this.lblDepartmentCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartmentCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentCount.Location = new System.Drawing.Point(0, 25);
            this.lblDepartmentCount.Name = "lblDepartmentCount";
            this.lblDepartmentCount.Size = new System.Drawing.Size(270, 55);
            this.lblDepartmentCount.TabIndex = 1;
            this.lblDepartmentCount.Text = "0";
            this.lblDepartmentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartmentsTitle
            // 
            this.lblDepartmentsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepartmentsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDepartmentsTitle.Name = "lblDepartmentsTitle";
            this.lblDepartmentsTitle.Size = new System.Drawing.Size(270, 25);
            this.lblDepartmentsTitle.TabIndex = 0;
            this.lblDepartmentsTitle.Text = "Departments";
            this.lblDepartmentsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTaskStatus
            // 
            this.panelTaskStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTaskStatus.BackColor = System.Drawing.Color.White;
            this.panelTaskStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTaskStatus.Controls.Add(this.panelTaskStatusChart);
            this.panelTaskStatus.Controls.Add(this.lblTaskStatusTitle);
            this.panelTaskStatus.Location = new System.Drawing.Point(12, 196);
            this.panelTaskStatus.Name = "panelTaskStatus";
            this.panelTaskStatus.Size = new System.Drawing.Size(280, 280);
            this.panelTaskStatus.TabIndex = 4;
            // 
            // panelTaskStatusChart
            // 
            this.panelTaskStatusChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaskStatusChart.Location = new System.Drawing.Point(0, 30);
            this.panelTaskStatusChart.Name = "panelTaskStatusChart";
            this.panelTaskStatusChart.Size = new System.Drawing.Size(278, 248);
            this.panelTaskStatusChart.TabIndex = 1;
            this.panelTaskStatusChart.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTaskStatusChart_Paint);
            // 
            // lblTaskStatusTitle
            // 
            this.lblTaskStatusTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTaskStatusTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskStatusTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskStatusTitle.ForeColor = System.Drawing.Color.White;
            this.lblTaskStatusTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTaskStatusTitle.Name = "lblTaskStatusTitle";
            this.lblTaskStatusTitle.Size = new System.Drawing.Size(278, 30);
            this.lblTaskStatusTitle.TabIndex = 0;
            this.lblTaskStatusTitle.Text = "Task Status";
            this.lblTaskStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRecentActivity
            // 
            this.panelRecentActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecentActivity.BackColor = System.Drawing.Color.White;
            this.panelRecentActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecentActivity.Controls.Add(this.dataGridViewRecentActivity);
            this.panelRecentActivity.Controls.Add(this.lblRecentActivityTitle);
            this.panelRecentActivity.Location = new System.Drawing.Point(298, 196);
            this.panelRecentActivity.Name = "panelRecentActivity";
            this.panelRecentActivity.Size = new System.Drawing.Size(580, 280);
            this.panelRecentActivity.TabIndex = 5;
            // 
            // dataGridViewRecentActivity
            // 
            this.dataGridViewRecentActivity.AllowUserToAddRows = false;
            this.dataGridViewRecentActivity.AllowUserToDeleteRows = false;
            this.dataGridViewRecentActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecentActivity.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecentActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecentActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecentActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRecentActivity.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewRecentActivity.Name = "dataGridViewRecentActivity";
            this.dataGridViewRecentActivity.ReadOnly = true;
            this.dataGridViewRecentActivity.RowHeadersVisible = false;
            this.dataGridViewRecentActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecentActivity.Size = new System.Drawing.Size(578, 248);
            this.dataGridViewRecentActivity.TabIndex = 1;
            // 
            // lblRecentActivityTitle
            // 
            this.lblRecentActivityTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblRecentActivityTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentActivityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentActivityTitle.ForeColor = System.Drawing.Color.White;
            this.lblRecentActivityTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRecentActivityTitle.Name = "lblRecentActivityTitle";
            this.lblRecentActivityTitle.Size = new System.Drawing.Size(578, 30);
            this.lblRecentActivityTitle.TabIndex = 0;
            this.lblRecentActivityTitle.Text = "Recent Activity";
            this.lblRecentActivityTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUpcomingTasks
            // 
            this.panelUpcomingTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUpcomingTasks.BackColor = System.Drawing.Color.White;
            this.panelUpcomingTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpcomingTasks.Controls.Add(this.dataGridViewUpcomingTasks);
            this.panelUpcomingTasks.Controls.Add(this.lblUpcomingTasksTitle);
            this.panelUpcomingTasks.Location = new System.Drawing.Point(884, 196);
            this.panelUpcomingTasks.Name = "panelUpcomingTasks";
            this.panelUpcomingTasks.Size = new System.Drawing.Size(288, 280);
            this.panelUpcomingTasks.TabIndex = 6;
            // 
            // dataGridViewUpcomingTasks
            // 
            this.dataGridViewUpcomingTasks.AllowUserToAddRows = false;
            this.dataGridViewUpcomingTasks.AllowUserToDeleteRows = false;
            this.dataGridViewUpcomingTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpcomingTasks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUpcomingTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUpcomingTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpcomingTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUpcomingTasks.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewUpcomingTasks.Name = "dataGridViewUpcomingTasks";
            this.dataGridViewUpcomingTasks.ReadOnly = true;
            this.dataGridViewUpcomingTasks.RowHeadersVisible = false;
            this.dataGridViewUpcomingTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUpcomingTasks.Size = new System.Drawing.Size(286, 248);
            this.dataGridViewUpcomingTasks.TabIndex = 1;
            // 
            // lblUpcomingTasksTitle
            // 
            this.lblUpcomingTasksTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblUpcomingTasksTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUpcomingTasksTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingTasksTitle.ForeColor = System.Drawing.Color.White;
            this.lblUpcomingTasksTitle.Location = new System.Drawing.Point(0, 0);
            this.lblUpcomingTasksTitle.Name = "lblUpcomingTasksTitle";
            this.lblUpcomingTasksTitle.Size = new System.Drawing.Size(286, 30);
            this.lblUpcomingTasksTitle.TabIndex = 0;
            this.lblUpcomingTasksTitle.Text = "Upcoming Tasks";
            this.lblUpcomingTasksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelQuickActions
            // 
            this.panelQuickActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelQuickActions.BackColor = System.Drawing.Color.White;
            this.panelQuickActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuickActions.Controls.Add(this.btnRefreshDashboard);
            this.panelQuickActions.Controls.Add(this.btnAddTask);
            this.panelQuickActions.Controls.Add(this.btnAddProject);
            this.panelQuickActions.Controls.Add(this.btnAddUser);
            this.panelQuickActions.Controls.Add(this.lblQuickActionsTitle);
            this.panelQuickActions.Location = new System.Drawing.Point(12, 482);
            this.panelQuickActions.Name = "panelQuickActions";
            this.panelQuickActions.Size = new System.Drawing.Size(280, 200);
            this.panelQuickActions.TabIndex = 7;
            // 
            // btnRefreshDashboard
            // 
            this.btnRefreshDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefreshDashboard.FlatAppearance.BorderSize = 0;
            this.btnRefreshDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDashboard.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDashboard.Location = new System.Drawing.Point(11, 157);
            this.btnRefreshDashboard.Name = "btnRefreshDashboard";
            this.btnRefreshDashboard.Size = new System.Drawing.Size(256, 30);
            this.btnRefreshDashboard.TabIndex = 4;
            this.btnRefreshDashboard.Text = "Refresh Dashboard";
            this.btnRefreshDashboard.UseVisualStyleBackColor = false;
            this.btnRefreshDashboard.Click += new System.EventHandler(this.btnRefreshDashboard_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(11, 85);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(256, 30);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add New Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnAddProject.FlatAppearance.BorderSize = 0;
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.White;
            this.btnAddProject.Location = new System.Drawing.Point(11, 121);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(256, 30);
            this.btnAddProject.TabIndex = 2;
            this.btnAddProject.Text = "Add New Project";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(11, 49);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(256, 30);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblQuickActionsTitle
            // 
            this.lblQuickActionsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblQuickActionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuickActionsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickActionsTitle.ForeColor = System.Drawing.Color.White;
            this.lblQuickActionsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            this.lblQuickActionsTitle.Size = new System.Drawing.Size(278, 30);
            this.lblQuickActionsTitle.TabIndex = 0;
            this.lblQuickActionsTitle.Text = "Quick Actions";
            this.lblQuickActionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProjectProgress
            // 
            this.panelProjectProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProjectProgress.BackColor = System.Drawing.Color.White;
            this.panelProjectProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProjectProgress.Controls.Add(this.dataGridViewProjects);
            this.panelProjectProgress.Controls.Add(this.lblProjectProgressTitle);
            this.panelProjectProgress.Location = new System.Drawing.Point(298, 482);
            this.panelProjectProgress.Name = "panelProjectProgress";
            this.panelProjectProgress.Size = new System.Drawing.Size(874, 200);
            this.panelProjectProgress.TabIndex = 8;
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AllowUserToAddRows = false;
            this.dataGridViewProjects.AllowUserToDeleteRows = false;
            this.dataGridViewProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProjects.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProjects.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.ReadOnly = true;
            this.dataGridViewProjects.RowHeadersVisible = false;
            this.dataGridViewProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjects.Size = new System.Drawing.Size(872, 168);
            this.dataGridViewProjects.TabIndex = 1;
            // 
            // lblProjectProgressTitle
            // 
            this.lblProjectProgressTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblProjectProgressTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectProgressTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectProgressTitle.ForeColor = System.Drawing.Color.White;
            this.lblProjectProgressTitle.Location = new System.Drawing.Point(0, 0);
            this.lblProjectProgressTitle.Name = "lblProjectProgressTitle";
            this.lblProjectProgressTitle.Size = new System.Drawing.Size(872, 30);
            this.lblProjectProgressTitle.TabIndex = 0;
            this.lblProjectProgressTitle.Text = "Project Progress";
            this.lblProjectProgressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 60000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // DashboardMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.panelProjectProgress);
            this.Controls.Add(this.panelQuickActions);
            this.Controls.Add(this.panelUpcomingTasks);
            this.Controls.Add(this.panelRecentActivity);
            this.Controls.Add(this.panelTaskStatus);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "DashboardMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management System - Dashboard";
            this.Load += new System.EventHandler(this.DashboardMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.tableLayoutPanelStats.ResumeLayout(false);
            this.panelUsers.ResumeLayout(false);
            this.panelTasks.ResumeLayout(false);
            this.panelProjects.ResumeLayout(false);
            this.panelDepartments.ResumeLayout(false);
            this.panelTaskStatus.ResumeLayout(false);
            this.panelRecentActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentActivity)).EndInit();
            this.panelUpcomingTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingTasks)).EndInit();
            this.panelQuickActions.ResumeLayout(false);
            this.panelProjectProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskAssignmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStats;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Label lblUserCount;
        private System.Windows.Forms.Label lblUsersTitle;
        private System.Windows.Forms.Panel panelTasks;
        private System.Windows.Forms.Label lblTaskCount;
        private System.Windows.Forms.Label lblTasksTitle;
        private System.Windows.Forms.Panel panelProjects;
        private System.Windows.Forms.Label lblProjectCount;
        private System.Windows.Forms.Label lblProjectsTitle;
        private System.Windows.Forms.Panel panelDepartments;
        private System.Windows.Forms.Label lblDepartmentCount;
        private System.Windows.Forms.Label lblDepartmentsTitle;
        private System.Windows.Forms.Panel panelTaskStatus;
        private System.Windows.Forms.Panel panelTaskStatusChart;
        private System.Windows.Forms.Label lblTaskStatusTitle;
        private System.Windows.Forms.Panel panelRecentActivity;
        private System.Windows.Forms.DataGridView dataGridViewRecentActivity;
        private System.Windows.Forms.Label lblRecentActivityTitle;
        private System.Windows.Forms.Panel panelUpcomingTasks;
        private System.Windows.Forms.DataGridView dataGridViewUpcomingTasks;
        private System.Windows.Forms.Label lblUpcomingTasksTitle;
        private System.Windows.Forms.Panel panelQuickActions;
        private System.Windows.Forms.Button btnRefreshDashboard;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblQuickActionsTitle;
        private System.Windows.Forms.Panel panelProjectProgress;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.Label lblProjectProgressTitle;
        private System.Windows.Forms.Timer timerRefresh;

        private void DashboardMainForm_Load(object sender, EventArgs e)
        {
            // Set current date
            lblCurrentDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");

            // Start the refresh timer
            timerRefresh.Start();
        }

        private void LoadSampleData()
        {
            // In a real application, this would load data from a database
            // For this example, we'll create sample data

            // Users data
            usersTable = new DataTable();
            usersTable.Columns.Add("user_id", typeof(int));
            usersTable.Columns.Add("first_name", typeof(string));
            usersTable.Columns.Add("last_name", typeof(string));
            usersTable.Columns.Add("email", typeof(string));
            usersTable.Columns.Add("department_name", typeof(string));
            usersTable.Columns.Add("role_name", typeof(string));

            // Add sample user data
            usersTable.Rows.Add(1, "John", "Doe", "john.doe@example.com", "IT", "Admin");
            usersTable.Rows.Add(2, "Jane", "Smith", "jane.smith@example.com", "HR", "Manager");
            usersTable.Rows.Add(3, "Bob", "Johnson", "bob.johnson@example.com", "IT", "Developer");
            usersTable.Rows.Add(4, "Alice", "Williams", "alice.williams@example.com", "Finance", "Analyst");
            usersTable.Rows.Add(5, "Charlie", "Brown", "charlie.brown@example.com", "Marketing", "Manager");

            // Tasks data
            tasksTable = new DataTable();
            tasksTable.Columns.Add("task_id", typeof(int));
            tasksTable.Columns.Add("task_name", typeof(string));
            tasksTable.Columns.Add("project_name", typeof(string));
            tasksTable.Columns.Add("assigned_to", typeof(string));
            tasksTable.Columns.Add("status", typeof(string));
            tasksTable.Columns.Add("due_date", typeof(DateTime));

            // Add sample task data
            tasksTable.Rows.Add(1, "Design database schema", "Website Redesign", "Bob Johnson", "In Progress", DateTime.Now.AddDays(5));
            tasksTable.Rows.Add(2, "Create wireframes", "Website Redesign", "Jane Smith", "Completed", DateTime.Now.AddDays(-2));
            tasksTable.Rows.Add(3, "Implement login system", "Mobile App", "Bob Johnson", "Not Started", DateTime.Now.AddDays(10));
            tasksTable.Rows.Add(4, "Write API documentation", "CRM Integration", "Alice Williams", "In Progress", DateTime.Now.AddDays(3));
            tasksTable.Rows.Add(5, "Create marketing materials", "Product Launch", "Charlie Brown", "Not Started", DateTime.Now.AddDays(15));
            tasksTable.Rows.Add(6, "Test payment gateway", "E-commerce Platform", "John Doe", "In Progress", DateTime.Now.AddDays(7));
            tasksTable.Rows.Add(7, "Deploy to production", "Website Redesign", "John Doe", "Not Started", DateTime.Now.AddDays(20));

            // Projects data
            projectsTable = new DataTable();
            projectsTable.Columns.Add("project_id", typeof(int));
            projectsTable.Columns.Add("project_name", typeof(string));
            projectsTable.Columns.Add("manager_name", typeof(string));
            projectsTable.Columns.Add("start_date", typeof(DateTime));
            projectsTable.Columns.Add("end_date", typeof(DateTime));
            projectsTable.Columns.Add("status", typeof(string));
            projectsTable.Columns.Add("progress", typeof(int));
            projectsTable.Columns.Add("department_name", typeof(string));

            // Add sample project data
            projectsTable.Rows.Add(1, "Website Redesign", "Jane Smith", DateTime.Now.AddDays(-30), DateTime.Now.AddDays(60), "In Progress", 45, "IT");
            projectsTable.Rows.Add(2, "Mobile App", "John Doe", DateTime.Now.AddDays(-15), DateTime.Now.AddDays(90), "In Progress", 20, "IT");
            projectsTable.Rows.Add(3, "CRM Integration", "Jane Smith", DateTime.Now.AddDays(15), DateTime.Now.AddDays(120), "Planning", 5, "Finance");
            projectsTable.Rows.Add(4, "Product Launch", "Charlie Brown", DateTime.Now.AddDays(-45), DateTime.Now.AddDays(15), "In Progress", 75, "Marketing");
            projectsTable.Rows.Add(5, "E-commerce Platform", "John Doe", DateTime.Now.AddDays(-60), DateTime.Now.AddDays(30), "In Progress", 80, "IT");

            // Logs/Activity data
            logsTable = new DataTable();
            logsTable.Columns.Add("log_id", typeof(int));
            logsTable.Columns.Add("user_name", typeof(string));
            logsTable.Columns.Add("action", typeof(string));
            logsTable.Columns.Add("log_time", typeof(DateTime));
            logsTable.Columns.Add("details", typeof(string));

            // Add sample log data
            logsTable.Rows.Add(1, "John Doe", "Created project", DateTime.Now.AddHours(-2), "Created project 'Website Redesign'");
            logsTable.Rows.Add(2, "Jane Smith", "Updated task", DateTime.Now.AddHours(-5), "Updated task 'Create wireframes' to Completed");
            logsTable.Rows.Add(3, "Bob Johnson", "Assigned task", DateTime.Now.AddHours(-8), "Assigned task 'Implement login system' to Bob Johnson");
            logsTable.Rows.Add(4, "Alice Williams", "Created task", DateTime.Now.AddHours(-12), "Created task 'Write API documentation'");
            logsTable.Rows.Add(5, "Charlie Brown", "Updated project", DateTime.Now.AddDays(-1), "Updated project 'Product Launch' progress to 75%");
            logsTable.Rows.Add(6, "John Doe", "Added user", DateTime.Now.AddDays(-2), "Added user 'Alice Williams'");
            logsTable.Rows.Add(7, "Jane Smith", "Created department", DateTime.Now.AddDays(-3), "Created department 'Marketing'");
        }

        private void UpdateDashboard()
        {
            // Update statistics
            lblUserCount.Text = usersTable.Rows.Count.ToString();

            int activeTasks = 0;
            foreach (DataRow row in tasksTable.Rows)
            {
                if (row["status"].ToString() != "Completed")
                    activeTasks++;
            }
            lblTaskCount.Text = activeTasks.ToString();

            lblProjectCount.Text = projectsTable.Rows.Count.ToString();

            // Get unique departments
            var departments = new HashSet<string>();
            foreach (DataRow row in usersTable.Rows)
            {
                departments.Add(row["department_name"].ToString());
            }
            lblDepartmentCount.Text = departments.Count.ToString();

            // Update recent activity
            DataView recentActivityView = new DataView(logsTable);
            recentActivityView.Sort = "log_time DESC";
            dataGridViewRecentActivity.DataSource = recentActivityView;

            // Format the recent activity grid
            if (dataGridViewRecentActivity.Columns.Count > 0)
            {
                dataGridViewRecentActivity.Columns["log_id"].Visible = false;
                dataGridViewRecentActivity.Columns["log_time"].DefaultCellStyle.Format = "g"; // Short date and time format
            }

            // Update upcoming tasks
            DataView upcomingTasksView = new DataView(tasksTable);
            upcomingTasksView.RowFilter = "status <> 'Completed' AND due_date >= #" + DateTime.Now.ToString("yyyy-MM-dd") + "#";
            upcomingTasksView.Sort = "due_date ASC";
            dataGridViewUpcomingTasks.DataSource = upcomingTasksView;

            // Format the upcoming tasks grid
            if (dataGridViewUpcomingTasks.Columns.Count > 0)
            {
                dataGridViewUpcomingTasks.Columns["task_id"].Visible = false;
                dataGridViewUpcomingTasks.Columns["due_date"].DefaultCellStyle.Format = "d"; // Short date format

                // Add color coding based on due date
                dataGridViewUpcomingTasks.CellFormatting += (s, e) => {
                    if (e.ColumnIndex == dataGridViewUpcomingTasks.Columns["due_date"].Index && e.Value != null)
                    {
                        DateTime dueDate = (DateTime)e.Value;
                        if (dueDate < DateTime.Now.AddDays(3))
                        {
                            e.CellStyle.BackColor = Color.LightCoral;
                        }
                        else if (dueDate < DateTime.Now.AddDays(7))
                        {
                            e.CellStyle.BackColor = Color.LightYellow;
                        }
                    }
                };
            }

            // Update project progress
            dataGridViewProjects.DataSource = projectsTable;

            // Format the projects grid
            if (dataGridViewProjects.Columns.Count > 0)
            {
                dataGridViewProjects.Columns["project_id"].Visible = false;
                dataGridViewProjects.Columns["start_date"].DefaultCellStyle.Format = "d"; // Short date format
                dataGridViewProjects.Columns["end_date"].DefaultCellStyle.Format = "d"; // Short date format

                // Add progress bar column
                if (!dataGridViewProjects.Columns.Contains("ProgressBar"))
                {
                    DataGridViewProgressColumn progressColumn = new DataGridViewProgressColumn();
                    progressColumn.HeaderText = "Progress";
                    progressColumn.Name = "ProgressBar";
                    progressColumn.DataPropertyName = "progress";
                    dataGridViewProjects.Columns.Add(progressColumn);
                }
            }

            // Refresh the task status chart
            panelTaskStatusChart.Invalidate();
        }

        private void panelTaskStatusChart_Paint(object sender, PaintEventArgs e)
        {
            // Count tasks by status
            int notStarted = 0;
            int inProgress = 0;
            int completed = 0;

            foreach (DataRow row in tasksTable.Rows)
            {
                string status = row["status"].ToString();
                if (status == "Not Started")
                    notStarted++;
                else if (status == "In Progress")
                    inProgress++;
                else if (status == "Completed")
                    completed++;
            }

            // Calculate total and percentages
            int total = notStarted + inProgress + completed;
            if (total == 0) return; // Avoid division by zero

            float notStartedPct = (float)notStarted / total;
            float inProgressPct = (float)inProgress / total;
            float completedPct = (float)completed / total;

            // Define colors
            Color notStartedColor = Color.FromArgb(231, 76, 60); // Red
            Color inProgressColor = Color.FromArgb(241, 196, 15); // Yellow
            Color completedColor = Color.FromArgb(46, 204, 113); // Green

            // Draw pie chart
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Calculate chart dimensions
            Rectangle chartRect = new Rectangle(30, 30, panelTaskStatusChart.Width - 60, panelTaskStatusChart.Height - 100);

            // Draw segments
            float startAngle = 0;

            if (completedPct > 0)
            {
                float sweepAngle = completedPct * 360;
                using (SolidBrush brush = new SolidBrush(completedColor))
                {
                    g.FillPie(brush, chartRect, startAngle, sweepAngle);
                }
                startAngle += sweepAngle;
            }

            if (inProgressPct > 0)
            {
                float sweepAngle = inProgressPct * 360;
                using (SolidBrush brush = new SolidBrush(inProgressColor))
                {
                    g.FillPie(brush, chartRect, startAngle, sweepAngle);
                }
                startAngle += sweepAngle;
            }

            if (notStartedPct > 0)
            {
                float sweepAngle = notStartedPct * 360;
                using (SolidBrush brush = new SolidBrush(notStartedColor))
                {
                    g.FillPie(brush, chartRect, startAngle, sweepAngle);
                }
            }

            // Draw legend
            int legendY = chartRect.Bottom + 10;

            // Completed legend
            g.FillRectangle(new SolidBrush(completedColor), 30, legendY, 15, 15);
            g.DrawString($"Completed ({completed})", new Font("Segoe UI", 9), Brushes.Black, 50, legendY);

            // In Progress legend
            legendY += 20;
            g.FillRectangle(new SolidBrush(inProgressColor), 30, legendY, 15, 15);
            g.DrawString($"In Progress ({inProgress})", new Font("Segoe UI", 9), Brushes.Black, 50, legendY);

            // Not Started legend
            legendY += 20;
            g.FillRectangle(new SolidBrush(notStartedColor), 30, legendY, 15, 15);
            g.DrawString($"Not Started ({notStarted})", new Font("Segoe UI", 9), Brushes.Black, 50, legendY);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
            UpdateDashboard(); // Refresh dashboard after form closes
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm();
            tasksForm.ShowDialog();
            UpdateDashboard(); // Refresh dashboard after form closes
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectsForm projectsForm = new ProjectsForm();
            projectsForm.ShowDialog();
            UpdateDashboard(); // Refresh dashboard after form closes
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentsForm departmentsForm = new DepartmentsForm();
            departmentsForm.ShowDialog();
            UpdateDashboard(); // Refresh dashboard after form closes
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm rolesForm = new RolesForm();
            rolesForm.ShowDialog();
            UpdateDashboard(); // Refresh dashboard after form closes
        }

        private void taskAssignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskAssignmentsForm taskAssignmentsForm = new TaskAssignmentsForm();
            taskAssignmentsForm.ShowDialog();
            UpdateDashboard(); // Refresh dashboard after form closes
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogsForm logsForm = new LogsForm();
            logsForm.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
            UpdateDashboard(); // Refresh dashboard after form closes
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm();
            tasksForm.ShowDialog();
            UpdateDashboard(); // Refresh dashboard after form closes
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            ProjectsForm projectsForm = new ProjectsForm();
            projectsForm.ShowDialog();
            UpdateDashboard(); // Refresh dashboard after form closes
        }

        private void btnRefreshDashboard_Click(object sender, EventArgs e)
        {
            // In a real application, this would reload data from the database
            UpdateDashboard();
            statusLabel.Text = "Dashboard refreshed at " + DateTime.Now.ToString("g");
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            // Auto-refresh the dashboard every minute
            UpdateDashboard();
            lblCurrentDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            statusLabel.Text = "Dashboard auto-refreshed at " + DateTime.Now.ToString("g");
        }
    }

    // Custom DataGridViewProgressColumn for showing progress bars
    public class DataGridViewProgressColumn : DataGridViewColumn
    {
        public DataGridViewProgressColumn()
        {
            CellTemplate = new DataGridViewProgressCell();
        }
    }

    public class DataGridViewProgressCell : DataGridViewTextBoxCell
    {
        protected override void Paint(Graphics g, Rectangle clipBounds, Rectangle cellBounds,
            int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue,
            string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // First paint the cell background
            base.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue,
                errorText, cellStyle, advancedBorderStyle, paintParts);

            if (value != null && int.TryParse(value.ToString(), out int progressValue))
            {
                // Ensure progress is between 0 and 100
                progressValue = Math.Max(0, Math.Min(100, progressValue));

                // Calculate progress bar rectangle
                Rectangle progressRect = new Rectangle(
                    cellBounds.X + 2,
                    cellBounds.Y + 2,
                    (int)((cellBounds.Width - 4) * ((double)progressValue / 100)),
                    cellBounds.Height - 4);

                // Choose color based on progress
                Color progressColor;
                if (progressValue < 30)
                    progressColor = Color.FromArgb(231, 76, 60); // Red
                else if (progressValue < 70)
                    progressColor = Color.FromArgb(241, 196, 15); // Yellow
                else
                    progressColor = Color.FromArgb(46, 204, 113); // Green

                // Draw progress bar
                using (Brush brush = new SolidBrush(progressColor))
                {
                    g.FillRectangle(brush, progressRect);
                }

                // Draw progress text
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    using (Brush textBrush = new SolidBrush(Color.Black))
                    {
                        g.DrawString(progressValue + "%", cellStyle.Font, textBrush, cellBounds, sf);
                    }
                }
            }
        }
    }
}