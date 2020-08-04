namespace ADBMSpro01
{
    partial class EmployeeDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.employeesRegisteredPerYear = new LiveCharts.WinForms.CartesianChart();
            this.lblShowEmployeesDetailsCartisianChart = new System.Windows.Forms.Label();
            this.employeeStatusChart = new LiveCharts.WinForms.CartesianChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalActiveandDeactiveEmployees = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesRegisteredPerYear
            // 
            this.employeesRegisteredPerYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesRegisteredPerYear.Location = new System.Drawing.Point(3, 54);
            this.employeesRegisteredPerYear.Name = "employeesRegisteredPerYear";
            this.employeesRegisteredPerYear.Size = new System.Drawing.Size(943, 497);
            this.employeesRegisteredPerYear.TabIndex = 1;
            this.employeesRegisteredPerYear.Text = "employeesRegisteredPerMonth";
            this.employeesRegisteredPerYear.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.CartesianChart1_ChildChanged);
            // 
            // lblShowEmployeesDetailsCartisianChart
            // 
            this.lblShowEmployeesDetailsCartisianChart.AutoSize = true;
            this.lblShowEmployeesDetailsCartisianChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowEmployeesDetailsCartisianChart.Location = new System.Drawing.Point(13, 12);
            this.lblShowEmployeesDetailsCartisianChart.Name = "lblShowEmployeesDetailsCartisianChart";
            this.lblShowEmployeesDetailsCartisianChart.Size = new System.Drawing.Size(286, 25);
            this.lblShowEmployeesDetailsCartisianChart.TabIndex = 2;
            this.lblShowEmployeesDetailsCartisianChart.Text = "Employees Registered per Year";
            this.lblShowEmployeesDetailsCartisianChart.Click += new System.EventHandler(this.Label1_Click);
            // 
            // employeeStatusChart
            // 
            this.employeeStatusChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeStatusChart.Location = new System.Drawing.Point(969, 54);
            this.employeeStatusChart.Name = "employeeStatusChart";
            this.employeeStatusChart.Size = new System.Drawing.Size(319, 497);
            this.employeeStatusChart.TabIndex = 4;
            this.employeeStatusChart.Text = "employeeStatusChart";
            this.employeeStatusChart.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.CartesianChart2_ChildChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalActiveandDeactiveEmployees);
            this.panel1.Controls.Add(this.employeesRegisteredPerYear);
            this.panel1.Controls.Add(this.lblShowEmployeesDetailsCartisianChart);
            this.panel1.Controls.Add(this.employeeStatusChart);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 554);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblTotalActiveandDeactiveEmployees
            // 
            this.lblTotalActiveandDeactiveEmployees.AutoSize = true;
            this.lblTotalActiveandDeactiveEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalActiveandDeactiveEmployees.Location = new System.Drawing.Point(964, 12);
            this.lblTotalActiveandDeactiveEmployees.Name = "lblTotalActiveandDeactiveEmployees";
            this.lblTotalActiveandDeactiveEmployees.Size = new System.Drawing.Size(336, 25);
            this.lblTotalActiveandDeactiveEmployees.TabIndex = 5;
            this.lblTotalActiveandDeactiveEmployees.Text = "Total Active and Deactive Employees";
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 578);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeDetailsForm";
            this.Text = "EmployeeDetailsForm";
            this.Load += new System.EventHandler(this.EmployeeDetailsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart employeesRegisteredPerYear;
        private System.Windows.Forms.Label lblShowEmployeesDetailsCartisianChart;
        private LiveCharts.WinForms.CartesianChart employeeStatusChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalActiveandDeactiveEmployees;
    }
}