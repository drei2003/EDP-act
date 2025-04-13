
namespace EDPact7
{
    partial class logs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Label lblLogTime;
        private System.Windows.Forms.DateTimePicker dtpLogTime;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblRecordId;
        private System.Windows.Forms.TextBox txtRecordId;
        private System.Windows.Forms.Label lblProjectId;
        private System.Windows.Forms.TextBox txtProjectId;
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
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.lblLogTime = new System.Windows.Forms.Label();
            this.dtpLogTime = new System.Windows.Forms.DateTimePicker();
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.txtRecordId = new System.Windows.Forms.TextBox();
            this.lblProjectId = new System.Windows.Forms.Label();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(20, 20);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(47, 15);
            this.lblUserId.Text = "User ID:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(120, 20);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(200, 23);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(20, 60);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(45, 15);
            this.lblAction.Text = "Action:";
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(120, 60);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(200, 23);
            // 
            // lblLogTime
            // 
            this.lblLogTime.AutoSize = true;
            this.lblLogTime.Location = new System.Drawing.Point(20, 100);
            this.lblLogTime.Name = "lblLogTime";
            this.lblLogTime.Size = new System.Drawing.Size(58, 15);
            this.lblLogTime.Text = "Log Time:";
            // 
            // dtpLogTime
            // 
            this.dtpLogTime.Location = new System.Drawing.Point(120, 100);
            this.dtpLogTime.Name = "dtpLogTime";
            this.dtpLogTime.Size = new System.Drawing.Size(200, 23);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(20, 140);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(74, 15);
            this.lblTableName.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(120, 140);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(200, 23);
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(20, 180);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(61, 15);
            this.lblRecordId.Text = "Record ID:";
            // 
            // txtRecordId
            // 
            this.txtRecordId.Location = new System.Drawing.Point(120, 180);
            this.txtRecordId.Name = "txtRecordId";
            this.txtRecordId.Size = new System.Drawing.Size(200, 23);
            // 
            // lblProjectId
            // 
            this.lblProjectId.AutoSize = true;
            this.lblProjectId.Location = new System.Drawing.Point(20, 220);
            this.lblProjectId.Name = "lblProjectId";
            this.lblProjectId.Size = new System.Drawing.Size(59, 15);
            this.lblProjectId.Text = "Project ID:";
            // 
            // txtProjectId
            // 
            this.txtProjectId.Location = new System.Drawing.Point(120, 220);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(200, 23);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.lblLogTime);
            this.Controls.Add(this.dtpLogTime);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.txtRecordId);
            this.Controls.Add(this.lblProjectId);
            this.Controls.Add(this.txtProjectId);
            this.Controls.Add(this.btnSave);
            this.Name = "logs";
            this.Text = "Logs";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}