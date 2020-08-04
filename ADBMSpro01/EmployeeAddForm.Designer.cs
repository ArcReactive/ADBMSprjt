namespace ADBMSpro01
{
    partial class EmployeeAddForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.RDTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DOBTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblRD = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.showEmployeeTableDataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showEmployeeTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.RDTimePicker);
            this.panel.Controls.Add(this.DOBTimePicker);
            this.panel.Controls.Add(this.lblRD);
            this.panel.Controls.Add(this.lblDoB);
            this.panel.Controls.Add(this.lblLname);
            this.panel.Controls.Add(this.txtLname);
            this.panel.Controls.Add(this.lblFname);
            this.panel.Controls.Add(this.txtFname);
            this.panel.Location = new System.Drawing.Point(9, 10);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(968, 81);
            this.panel.TabIndex = 0;
            // 
            // RDTimePicker
            // 
            this.RDTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDTimePicker.Location = new System.Drawing.Point(630, 40);
            this.RDTimePicker.Name = "RDTimePicker";
            this.RDTimePicker.Size = new System.Drawing.Size(279, 24);
            this.RDTimePicker.TabIndex = 9;
            // 
            // DOBTimePicker
            // 
            this.DOBTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBTimePicker.Location = new System.Drawing.Point(144, 41);
            this.DOBTimePicker.Name = "DOBTimePicker";
            this.DOBTimePicker.Size = new System.Drawing.Size(283, 24);
            this.DOBTimePicker.TabIndex = 8;
            // 
            // lblRD
            // 
            this.lblRD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRD.AutoSize = true;
            this.lblRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRD.Location = new System.Drawing.Point(470, 46);
            this.lblRD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRD.Name = "lblRD";
            this.lblRD.Size = new System.Drawing.Size(126, 18);
            this.lblRD.TabIndex = 6;
            this.lblRD.Text = "Ragistration Date:";
            // 
            // lblDoB
            // 
            this.lblDoB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(10, 47);
            this.lblDoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(94, 18);
            this.lblDoB.TabIndex = 4;
            this.lblDoB.Text = "Date of Birth:";
            this.lblDoB.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblLname
            // 
            this.lblLname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(470, 14);
            this.lblLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(84, 18);
            this.lblLname.TabIndex = 2;
            this.lblLname.Text = "Last Name:";
            // 
            // txtLname
            // 
            this.txtLname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(630, 6);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(279, 24);
            this.txtLname.TabIndex = 3;
            this.txtLname.TextChanged += new System.EventHandler(this.TxtLname_TextChanged);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(10, 15);
            this.lblFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(85, 18);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // txtFname
            // 
            this.txtFname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(144, 6);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(283, 24);
            this.txtFname.TabIndex = 1;
            this.txtFname.TextChanged += new System.EventHandler(this.TxtFname_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(922, 431);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // showEmployeeTableDataGridView
            // 
            this.showEmployeeTableDataGridView.AllowUserToAddRows = false;
            this.showEmployeeTableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showEmployeeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showEmployeeTableDataGridView.Location = new System.Drawing.Point(10, 125);
            this.showEmployeeTableDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.showEmployeeTableDataGridView.Name = "showEmployeeTableDataGridView";
            this.showEmployeeTableDataGridView.RowHeadersWidth = 51;
            this.showEmployeeTableDataGridView.RowTemplate.Height = 24;
            this.showEmployeeTableDataGridView.Size = new System.Drawing.Size(968, 292);
            this.showEmployeeTableDataGridView.TabIndex = 3;
            this.showEmployeeTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.showEmployeeTableDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowEmployeeTableDataGridView_CellMouseClick);
            this.showEmployeeTableDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(8, 95);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(867, 24);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(801, 431);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 29);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSearch.Location = new System.Drawing.Point(879, 93);
            this.btnEmployeeSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(96, 26);
            this.btnEmployeeSearch.TabIndex = 14;
            this.btnEmployeeSearch.Text = "Search";
            this.btnEmployeeSearch.UseVisualStyleBackColor = true;
            this.btnEmployeeSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(862, 431);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 28);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 470);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEmployeeSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.showEmployeeTableDataGridView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel);
            this.Name = "EmployeeAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeAddForm";
            this.Load += new System.EventHandler(this.EmployeeAddForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showEmployeeTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblRD;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView showEmployeeTableDataGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEmployeeSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker RDTimePicker;
        private System.Windows.Forms.DateTimePicker DOBTimePicker;
    }
}