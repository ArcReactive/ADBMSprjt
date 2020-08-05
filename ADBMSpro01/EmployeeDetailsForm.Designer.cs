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
            this.EmpNamesDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.PictureBox();
            this.EmpSearchTxt = new System.Windows.Forms.TextBox();
            this.EmpWorkingHoursChart = new LiveCharts.WinForms.CartesianChart();
            this.lblTotalActiveandDeactiveEmployees = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNamesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesRegisteredPerYear
            // 
            this.employeesRegisteredPerYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesRegisteredPerYear.Location = new System.Drawing.Point(2, 44);
            this.employeesRegisteredPerYear.Margin = new System.Windows.Forms.Padding(2);
            this.employeesRegisteredPerYear.Name = "employeesRegisteredPerYear";
            this.employeesRegisteredPerYear.Size = new System.Drawing.Size(707, 212);
            this.employeesRegisteredPerYear.TabIndex = 1;
            this.employeesRegisteredPerYear.Text = "employeesRegisteredPerMonth";
            this.employeesRegisteredPerYear.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.CartesianChart1_ChildChanged);
            // 
            // lblShowEmployeesDetailsCartisianChart
            // 
            this.lblShowEmployeesDetailsCartisianChart.AutoSize = true;
            this.lblShowEmployeesDetailsCartisianChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowEmployeesDetailsCartisianChart.Location = new System.Drawing.Point(10, 10);
            this.lblShowEmployeesDetailsCartisianChart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowEmployeesDetailsCartisianChart.Name = "lblShowEmployeesDetailsCartisianChart";
            this.lblShowEmployeesDetailsCartisianChart.Size = new System.Drawing.Size(263, 20);
            this.lblShowEmployeesDetailsCartisianChart.TabIndex = 2;
            this.lblShowEmployeesDetailsCartisianChart.Text = "Employees Registered per Year";
            this.lblShowEmployeesDetailsCartisianChart.Click += new System.EventHandler(this.Label1_Click);
            // 
            // employeeStatusChart
            // 
            this.employeeStatusChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeStatusChart.Location = new System.Drawing.Point(727, 44);
            this.employeeStatusChart.Margin = new System.Windows.Forms.Padding(2);
            this.employeeStatusChart.Name = "employeeStatusChart";
            this.employeeStatusChart.Size = new System.Drawing.Size(239, 212);
            this.employeeStatusChart.TabIndex = 4;
            this.employeeStatusChart.Text = "employeeStatusChart";
            this.employeeStatusChart.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.CartesianChart2_ChildChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmpNamesDataGridView);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.EmpSearchTxt);
            this.panel1.Controls.Add(this.EmpWorkingHoursChart);
            this.panel1.Controls.Add(this.lblTotalActiveandDeactiveEmployees);
            this.panel1.Controls.Add(this.employeesRegisteredPerYear);
            this.panel1.Controls.Add(this.lblShowEmployeesDetailsCartisianChart);
            this.panel1.Controls.Add(this.employeeStatusChart);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 450);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // EmpNamesDataGridView
            // 
            this.EmpNamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpNamesDataGridView.Location = new System.Drawing.Point(2, 310);
            this.EmpNamesDataGridView.Name = "EmpNamesDataGridView";
            this.EmpNamesDataGridView.Size = new System.Drawing.Size(250, 137);
            this.EmpNamesDataGridView.TabIndex = 12;
            this.EmpNamesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmpNamesDataGridView_CellMouseClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::ADBMSpro01.Properties.Resources.searchBtn;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.Location = new System.Drawing.Point(158, 261);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 32);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.TabStop = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // EmpSearchTxt
            // 
            this.EmpSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSearchTxt.Location = new System.Drawing.Point(2, 269);
            this.EmpSearchTxt.Name = "EmpSearchTxt";
            this.EmpSearchTxt.Size = new System.Drawing.Size(150, 24);
            this.EmpSearchTxt.TabIndex = 7;
            // 
            // EmpWorkingHoursChart
            // 
            this.EmpWorkingHoursChart.Location = new System.Drawing.Point(259, 279);
            this.EmpWorkingHoursChart.Name = "EmpWorkingHoursChart";
            this.EmpWorkingHoursChart.Size = new System.Drawing.Size(706, 168);
            this.EmpWorkingHoursChart.TabIndex = 6;
            this.EmpWorkingHoursChart.Text = "EmpWorkingHoursChart";
            // 
            // lblTotalActiveandDeactiveEmployees
            // 
            this.lblTotalActiveandDeactiveEmployees.AutoSize = true;
            this.lblTotalActiveandDeactiveEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalActiveandDeactiveEmployees.Location = new System.Drawing.Point(663, 10);
            this.lblTotalActiveandDeactiveEmployees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalActiveandDeactiveEmployees.Name = "lblTotalActiveandDeactiveEmployees";
            this.lblTotalActiveandDeactiveEmployees.Size = new System.Drawing.Size(305, 20);
            this.lblTotalActiveandDeactiveEmployees.TabIndex = 5;
            this.lblTotalActiveandDeactiveEmployees.Text = "Total Active and Deactive Employees";
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 470);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeDetailsForm";
            this.Text = "EmployeeDetailsForm";
            this.Load += new System.EventHandler(this.EmployeeDetailsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNamesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart employeesRegisteredPerYear;
        private System.Windows.Forms.Label lblShowEmployeesDetailsCartisianChart;
        private LiveCharts.WinForms.CartesianChart employeeStatusChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalActiveandDeactiveEmployees;
        private System.Windows.Forms.TextBox EmpSearchTxt;
        private LiveCharts.WinForms.CartesianChart EmpWorkingHoursChart;
        private System.Windows.Forms.DataGridView EmpNamesDataGridView;
        private System.Windows.Forms.PictureBox SearchBtn;
    }
}