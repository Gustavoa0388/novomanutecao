using System;

namespace ManutencaoOrtobio.Forms
{
    partial class MaintenanceScheduleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewMaintenanceSchedule;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaintenanceDate;
        private System.Windows.Forms.Button buttonUpdate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewMaintenanceSchedule = new System.Windows.Forms.DataGridView();
            this.dateTimePickerMaintenanceDate = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaintenanceSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaintenanceSchedule
            // 
            this.dataGridViewMaintenanceSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaintenanceSchedule.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMaintenanceSchedule.Name = "dataGridViewMaintenanceSchedule";
            this.dataGridViewMaintenanceSchedule.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewMaintenanceSchedule.TabIndex = 0;
            // 
            // dateTimePickerMaintenanceDate
            // 
            this.dateTimePickerMaintenanceDate.Location = new System.Drawing.Point(12, 180);
            this.dateTimePickerMaintenanceDate.Name = "dateTimePickerMaintenanceDate";
            this.dateTimePickerMaintenanceDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerMaintenanceDate.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(713, 180);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // MaintenanceScheduleForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dateTimePickerMaintenanceDate);
            this.Controls.Add(this.dataGridViewMaintenanceSchedule);
            this.Name = "MaintenanceScheduleForm";
            this.Text = "Maintenance Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaintenanceSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            // Implementation of buttonUpdate_Click
        }
    }
}
