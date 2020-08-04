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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.lblShowEmployeesDetailsCartisianChart = new System.Windows.Forms.Label();
            this.showEmployeeTableDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showEmployeeTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(12, 52);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1291, 239);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "employeeStatusChart";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.CartesianChart1_ChildChanged);
            // 
            // lblShowEmployeesDetailsCartisianChart
            // 
            this.lblShowEmployeesDetailsCartisianChart.AutoSize = true;
            this.lblShowEmployeesDetailsCartisianChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowEmployeesDetailsCartisianChart.Location = new System.Drawing.Point(12, 9);
            this.lblShowEmployeesDetailsCartisianChart.Name = "lblShowEmployeesDetailsCartisianChart";
            this.lblShowEmployeesDetailsCartisianChart.Size = new System.Drawing.Size(258, 25);
            this.lblShowEmployeesDetailsCartisianChart.TabIndex = 2;
            this.lblShowEmployeesDetailsCartisianChart.Text = "Employees status per month";
            this.lblShowEmployeesDetailsCartisianChart.Click += new System.EventHandler(this.Label1_Click);
            // 
            // showEmployeeTableDataGridView
            // 
            this.showEmployeeTableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showEmployeeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showEmployeeTableDataGridView.Location = new System.Drawing.Point(12, 312);
            this.showEmployeeTableDataGridView.Name = "showEmployeeTableDataGridView";
            this.showEmployeeTableDataGridView.RowHeadersWidth = 51;
            this.showEmployeeTableDataGridView.RowTemplate.Height = 24;
            this.showEmployeeTableDataGridView.Size = new System.Drawing.Size(1291, 254);
            this.showEmployeeTableDataGridView.TabIndex = 3;
            this.showEmployeeTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowEmployeeTableDataGridView_CellContentClick);
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 578);
            this.Controls.Add(this.showEmployeeTableDataGridView);
            this.Controls.Add(this.lblShowEmployeesDetailsCartisianChart);
            this.Controls.Add(this.cartesianChart1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeDetailsForm";
            this.Text = "EmployeeDetailsForm";
            this.Load += new System.EventHandler(this.EmployeeDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showEmployeeTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label lblShowEmployeesDetailsCartisianChart;
        private System.Windows.Forms.DataGridView showEmployeeTableDataGridView;
    }
}