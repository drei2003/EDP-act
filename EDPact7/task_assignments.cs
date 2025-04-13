using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDPact7
{
    public partial class task_assignments : Form
    {
        public task_assignments()
        {
            InitializeComponent
                ();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskId.Text) || string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                MessageBox.Show("Task ID and User ID are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtTaskId.Text, out int taskId) || !int.TryParse(txtUserId.Text, out int userId))
            {
                MessageBox.Show("Task ID and User ID must be valid integers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime assignedDate = dtpAssignedDate.Value;

            // Logic to save the data to the database or perform other actions
            MessageBox.Show($"Task ID: {taskId}\nUser ID: {userId}\nAssigned Date: {assignedDate}", "Task Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
