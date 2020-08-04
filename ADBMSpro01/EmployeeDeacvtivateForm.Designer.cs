namespace ADBMSpro01
{
    partial class EmployeeDeacvtivateForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.showEmployeeTableDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeactivateEmployeePB = new System.Windows.Forms.PictureBox();
            this.btnDeleteEmployee = new System.Windows.Forms.PictureBox();
            this.btnActivateDeactivateEmployee = new System.Windows.Forms.PictureBox();
            this.btnEmployeeSearchPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showEmployeeTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeactivateEmployeePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActivateDeactivateEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmployeeSearchPB)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(120, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(858, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // showEmployeeTableDataGridView
            // 
            this.showEmployeeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showEmployeeTableDataGridView.Location = new System.Drawing.Point(9, 46);
            this.showEmployeeTableDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showEmployeeTableDataGridView.Name = "showEmployeeTableDataGridView";
            this.showEmployeeTableDataGridView.RowHeadersWidth = 51;
            this.showEmployeeTableDataGridView.RowTemplate.Height = 24;
            this.showEmployeeTableDataGridView.Size = new System.Drawing.Size(968, 347);
            this.showEmployeeTableDataGridView.TabIndex = 2;
            this.showEmployeeTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowEmployeeTableDataGridView_CellContentClick);
            // 
            // btnDeactivateEmployeePB
            // 
            this.btnDeactivateEmployeePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeactivateEmployeePB.BackgroundImage = global::ADBMSpro01.Properties.Resources.deactivateBtn;
            this.btnDeactivateEmployeePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeactivateEmployeePB.Location = new System.Drawing.Point(627, 419);
            this.btnDeactivateEmployeePB.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeactivateEmployeePB.Name = "btnDeactivateEmployeePB";
            this.btnDeactivateEmployeePB.Size = new System.Drawing.Size(114, 41);
            this.btnDeactivateEmployeePB.TabIndex = 8;
            this.btnDeactivateEmployeePB.TabStop = false;
            this.btnDeactivateEmployeePB.Click += new System.EventHandler(this.BtnDeactivateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmployee.BackgroundImage = global::ADBMSpro01.Properties.Resources.deleteBtn;
            this.btnDeleteEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(745, 419);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(114, 41);
            this.btnDeleteEmployee.TabIndex = 7;
            this.btnDeleteEmployee.TabStop = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // btnActivateDeactivateEmployee
            // 
            this.btnActivateDeactivateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivateDeactivateEmployee.BackgroundImage = global::ADBMSpro01.Properties.Resources.activateBtn;
            this.btnActivateDeactivateEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivateDeactivateEmployee.Location = new System.Drawing.Point(863, 419);
            this.btnActivateDeactivateEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivateDeactivateEmployee.Name = "btnActivateDeactivateEmployee";
            this.btnActivateDeactivateEmployee.Size = new System.Drawing.Size(114, 41);
            this.btnActivateDeactivateEmployee.TabIndex = 6;
            this.btnActivateDeactivateEmployee.TabStop = false;
            this.btnActivateDeactivateEmployee.Click += new System.EventHandler(this.BtnActivateDeactivateEmployee_Click);
            // 
            // btnEmployeeSearchPB
            // 
            this.btnEmployeeSearchPB.BackgroundImage = global::ADBMSpro01.Properties.Resources.searchBtn;
            this.btnEmployeeSearchPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeSearchPB.Location = new System.Drawing.Point(9, 5);
            this.btnEmployeeSearchPB.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployeeSearchPB.Name = "btnEmployeeSearchPB";
            this.btnEmployeeSearchPB.Size = new System.Drawing.Size(107, 37);
            this.btnEmployeeSearchPB.TabIndex = 5;
            this.btnEmployeeSearchPB.TabStop = false;
            this.btnEmployeeSearchPB.Click += new System.EventHandler(this.BtnEmployeeSearchPB_Click);
            // 
            // EmployeeDeacvtivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 470);
            this.Controls.Add(this.btnDeactivateEmployeePB);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnActivateDeactivateEmployee);
            this.Controls.Add(this.btnEmployeeSearchPB);
            this.Controls.Add(this.showEmployeeTableDataGridView);
            this.Controls.Add(this.txtSearch);
            this.Name = "EmployeeDeacvtivateForm";
            this.Text = "EmployeeDeavtivateForm";
            this.Load += new System.EventHandler(this.EmployeeDeacvtivateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showEmployeeTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeactivateEmployeePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActivateDeactivateEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmployeeSearchPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView showEmployeeTableDataGridView;
        private System.Windows.Forms.PictureBox btnEmployeeSearchPB;
        private System.Windows.Forms.PictureBox btnActivateDeactivateEmployee;
        private System.Windows.Forms.PictureBox btnDeleteEmployee;
        private System.Windows.Forms.PictureBox btnDeactivateEmployeePB;
    }
}