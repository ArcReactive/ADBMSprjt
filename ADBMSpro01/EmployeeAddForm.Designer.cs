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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.lblRD = new System.Windows.Forms.Label();
            this.txtRD = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDBMSpro1DataSet = new ADBMSpro01.ADBMSpro1DataSet();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ebodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eregiterdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new ADBMSpro01.ADBMSpro1DataSetTableAdapters.EmployeeTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDBMSpro1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblRD);
            this.panel.Controls.Add(this.txtRD);
            this.panel.Controls.Add(this.lblDoB);
            this.panel.Controls.Add(this.txtDoB);
            this.panel.Controls.Add(this.lblLname);
            this.panel.Controls.Add(this.txtLname);
            this.panel.Controls.Add(this.lblFname);
            this.panel.Controls.Add(this.txtFname);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1291, 124);
            this.panel.TabIndex = 0;
            // 
            // lblRD
            // 
            this.lblRD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRD.AutoSize = true;
            this.lblRD.Location = new System.Drawing.Point(13, 95);
            this.lblRD.Name = "lblRD";
            this.lblRD.Size = new System.Drawing.Size(122, 17);
            this.lblRD.TabIndex = 6;
            this.lblRD.Text = "Ragistration Date:";
            // 
            // txtRD
            // 
            this.txtRD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Eregiterdate", true));
            this.txtRD.Location = new System.Drawing.Point(192, 92);
            this.txtRD.Name = "txtRD";
            this.txtRD.Size = new System.Drawing.Size(1087, 22);
            this.txtRD.TabIndex = 7;
            this.txtRD.TextChanged += new System.EventHandler(this.TxtRD_TextChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.aDBMSpro1DataSet;
            // 
            // aDBMSpro1DataSet
            // 
            this.aDBMSpro1DataSet.DataSetName = "ADBMSpro1DataSet";
            this.aDBMSpro1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDoB
            // 
            this.lblDoB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(13, 67);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(91, 17);
            this.lblDoB.TabIndex = 4;
            this.lblDoB.Text = "Date of Birth:";
            this.lblDoB.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtDoB
            // 
            this.txtDoB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDoB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Ebod", true));
            this.txtDoB.Location = new System.Drawing.Point(192, 64);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(1087, 22);
            this.txtDoB.TabIndex = 5;
            this.txtDoB.TextChanged += new System.EventHandler(this.TxtDoB_TextChanged);
            // 
            // lblLname
            // 
            this.lblLname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(13, 39);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(80, 17);
            this.lblLname.TabIndex = 2;
            this.lblLname.Text = "Last Name:";
            // 
            // txtLname
            // 
            this.txtLname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Elname", true));
            this.txtLname.Location = new System.Drawing.Point(192, 36);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(1087, 22);
            this.txtLname.TabIndex = 3;
            this.txtLname.TextChanged += new System.EventHandler(this.TxtLname_TextChanged);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(13, 11);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(80, 17);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // txtFname
            // 
            this.txtFname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Efname", true));
            this.txtFname.Location = new System.Drawing.Point(192, 8);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(1087, 22);
            this.txtFname.TabIndex = 1;
            this.txtFname.TextChanged += new System.EventHandler(this.TxtFname_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1230, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidDataGridViewTextBoxColumn,
            this.efnameDataGridViewTextBoxColumn,
            this.elnameDataGridViewTextBoxColumn,
            this.ebodDataGridViewTextBoxColumn,
            this.eregiterdateDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.employeeBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 177);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1291, 338);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "Eid";
            this.eidDataGridViewTextBoxColumn.HeaderText = "Eid";
            this.eidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            this.eidDataGridViewTextBoxColumn.ReadOnly = true;
            this.eidDataGridViewTextBoxColumn.Width = 135;
            // 
            // efnameDataGridViewTextBoxColumn
            // 
            this.efnameDataGridViewTextBoxColumn.DataPropertyName = "Efname";
            this.efnameDataGridViewTextBoxColumn.HeaderText = "Efname";
            this.efnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.efnameDataGridViewTextBoxColumn.Name = "efnameDataGridViewTextBoxColumn";
            this.efnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // elnameDataGridViewTextBoxColumn
            // 
            this.elnameDataGridViewTextBoxColumn.DataPropertyName = "Elname";
            this.elnameDataGridViewTextBoxColumn.HeaderText = "Elname";
            this.elnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elnameDataGridViewTextBoxColumn.Name = "elnameDataGridViewTextBoxColumn";
            this.elnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // ebodDataGridViewTextBoxColumn
            // 
            this.ebodDataGridViewTextBoxColumn.DataPropertyName = "Ebod";
            this.ebodDataGridViewTextBoxColumn.HeaderText = "Ebod";
            this.ebodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ebodDataGridViewTextBoxColumn.Name = "ebodDataGridViewTextBoxColumn";
            this.ebodDataGridViewTextBoxColumn.Width = 200;
            // 
            // eregiterdateDataGridViewTextBoxColumn
            // 
            this.eregiterdateDataGridViewTextBoxColumn.DataPropertyName = "Eregiterdate";
            this.eregiterdateDataGridViewTextBoxColumn.HeaderText = "Eregiterdate";
            this.eregiterdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eregiterdateDataGridViewTextBoxColumn.Name = "eregiterdateDataGridViewTextBoxColumn";
            this.eregiterdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.Width = 200;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(25, 149);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(84, 146);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1219, 22);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(1149, 530);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 36);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Location = new System.Drawing.Point(1068, 530);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 36);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 578);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeAddForm";
            this.Load += new System.EventHandler(this.EmployeeAddForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDBMSpro1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblRD;
        private System.Windows.Forms.TextBox txtRD;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private ADBMSpro1DataSet aDBMSpro1DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ADBMSpro1DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ebodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eregiterdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}