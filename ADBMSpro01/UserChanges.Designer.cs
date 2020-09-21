namespace ADBMSpro01
{
    partial class UserChanges
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
            this.userManagetabControl = new System.Windows.Forms.TabControl();
            this.PassChangeTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.UserManageTab = new System.Windows.Forms.TabPage();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.privilageCBox = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.RadioButton();
            this.deactive = new System.Windows.Forms.RadioButton();
            this.cancal = new System.Windows.Forms.PictureBox();
            this.BtnUserSave = new System.Windows.Forms.PictureBox();
            this.BtnUserUpdate = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.PictureBox();
            this.userManagetabControl.SuspendLayout();
            this.PassChangeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).BeginInit();
            this.UserManageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUserSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUserUpdate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // userManagetabControl
            // 
            this.userManagetabControl.Controls.Add(this.PassChangeTab);
            this.userManagetabControl.Controls.Add(this.UserManageTab);
            this.userManagetabControl.Location = new System.Drawing.Point(12, 12);
            this.userManagetabControl.Name = "userManagetabControl";
            this.userManagetabControl.SelectedIndex = 0;
            this.userManagetabControl.Size = new System.Drawing.Size(1032, 426);
            this.userManagetabControl.TabIndex = 0;
            // 
            // PassChangeTab
            // 
            this.PassChangeTab.Controls.Add(this.pictureBox1);
            this.PassChangeTab.Controls.Add(this.saveBtn);
            this.PassChangeTab.Controls.Add(this.label3);
            this.PassChangeTab.Controls.Add(this.txtRe);
            this.PassChangeTab.Controls.Add(this.label2);
            this.PassChangeTab.Controls.Add(this.txtNew);
            this.PassChangeTab.Controls.Add(this.label1);
            this.PassChangeTab.Controls.Add(this.txtCurrent);
            this.PassChangeTab.Location = new System.Drawing.Point(4, 22);
            this.PassChangeTab.Name = "PassChangeTab";
            this.PassChangeTab.Padding = new System.Windows.Forms.Padding(3);
            this.PassChangeTab.Size = new System.Drawing.Size(1024, 400);
            this.PassChangeTab.TabIndex = 0;
            this.PassChangeTab.Text = "Password Change";
            this.PassChangeTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ADBMSpro01.Properties.Resources.BtnCancel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(672, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 40);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = global::ADBMSpro01.Properties.Resources.saveBtn;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Location = new System.Drawing.Point(549, 253);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 40);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.TabStop = false;
            this.saveBtn.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re-Password";
            // 
            // txtRe
            // 
            this.txtRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRe.Location = new System.Drawing.Point(432, 195);
            this.txtRe.Name = "txtRe";
            this.txtRe.Size = new System.Drawing.Size(330, 24);
            this.txtRe.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // txtNew
            // 
            this.txtNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew.Location = new System.Drawing.Point(432, 151);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(330, 24);
            this.txtNew.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(432, 72);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(330, 24);
            this.txtCurrent.TabIndex = 0;
            // 
            // UserManageTab
            // 
            this.UserManageTab.Controls.Add(this.clearBtn);
            this.UserManageTab.Controls.Add(this.groupBox1);
            this.UserManageTab.Controls.Add(this.BtnUserUpdate);
            this.UserManageTab.Controls.Add(this.cancal);
            this.UserManageTab.Controls.Add(this.BtnUserSave);
            this.UserManageTab.Controls.Add(this.label7);
            this.UserManageTab.Controls.Add(this.label6);
            this.UserManageTab.Controls.Add(this.label5);
            this.UserManageTab.Controls.Add(this.label4);
            this.UserManageTab.Controls.Add(this.SearchBtn);
            this.UserManageTab.Controls.Add(this.privilageCBox);
            this.UserManageTab.Controls.Add(this.txtSearch);
            this.UserManageTab.Controls.Add(this.txtPass);
            this.UserManageTab.Controls.Add(this.txtName);
            this.UserManageTab.Controls.Add(this.UsersDataGridView);
            this.UserManageTab.Location = new System.Drawing.Point(4, 22);
            this.UserManageTab.Name = "UserManageTab";
            this.UserManageTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserManageTab.Size = new System.Drawing.Size(1024, 400);
            this.UserManageTab.TabIndex = 1;
            this.UserManageTab.Text = "User Manage";
            this.UserManageTab.UseVisualStyleBackColor = true;
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Location = new System.Drawing.Point(123, 113);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.Size = new System.Drawing.Size(701, 281);
            this.UsersDataGridView.TabIndex = 0;
            this.UsersDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersDataGridView_CellMouseClick);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(60, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 24);
            this.txtName.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(368, 31);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(204, 24);
            this.txtPass.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(123, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(591, 24);
            this.txtSearch.TabIndex = 4;
            // 
            // privilageCBox
            // 
            this.privilageCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilageCBox.FormattingEnabled = true;
            this.privilageCBox.Items.AddRange(new object[] {
            "admin",
            "marketing",
            "sales",
            "hr"});
            this.privilageCBox.Location = new System.Drawing.Point(852, 31);
            this.privilageCBox.Name = "privilageCBox";
            this.privilageCBox.Size = new System.Drawing.Size(154, 26);
            this.privilageCBox.TabIndex = 5;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::ADBMSpro01.Properties.Resources.searchBtn;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.Location = new System.Drawing.Point(720, 78);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(104, 32);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.TabStop = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Privilage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(614, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active.Location = new System.Drawing.Point(6, 5);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(64, 22);
            this.active.TabIndex = 16;
            this.active.TabStop = true;
            this.active.Text = "active";
            this.active.UseVisualStyleBackColor = true;
            this.active.CheckedChanged += new System.EventHandler(this.Active_CheckedChanged);
            // 
            // deactive
            // 
            this.deactive.AutoSize = true;
            this.deactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactive.Location = new System.Drawing.Point(6, 33);
            this.deactive.Name = "deactive";
            this.deactive.Size = new System.Drawing.Size(80, 22);
            this.deactive.TabIndex = 17;
            this.deactive.TabStop = true;
            this.deactive.Text = "deactive";
            this.deactive.UseVisualStyleBackColor = true;
            // 
            // cancal
            // 
            this.cancal.BackgroundImage = global::ADBMSpro01.Properties.Resources.BtnCancel;
            this.cancal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancal.Location = new System.Drawing.Point(882, 345);
            this.cancal.Name = "cancal";
            this.cancal.Size = new System.Drawing.Size(107, 40);
            this.cancal.TabIndex = 19;
            this.cancal.TabStop = false;
            this.cancal.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnUserSave
            // 
            this.BtnUserSave.BackgroundImage = global::ADBMSpro01.Properties.Resources.saveBtn;
            this.BtnUserSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUserSave.Location = new System.Drawing.Point(882, 207);
            this.BtnUserSave.Name = "BtnUserSave";
            this.BtnUserSave.Size = new System.Drawing.Size(108, 40);
            this.BtnUserSave.TabIndex = 18;
            this.BtnUserSave.TabStop = false;
            this.BtnUserSave.Click += new System.EventHandler(this.BtnUserSave_Click);
            // 
            // BtnUserUpdate
            // 
            this.BtnUserUpdate.BackgroundImage = global::ADBMSpro01.Properties.Resources.updateBtn;
            this.BtnUserUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUserUpdate.Location = new System.Drawing.Point(882, 253);
            this.BtnUserUpdate.Name = "BtnUserUpdate";
            this.BtnUserUpdate.Size = new System.Drawing.Size(108, 40);
            this.BtnUserUpdate.TabIndex = 20;
            this.BtnUserUpdate.TabStop = false;
            this.BtnUserUpdate.Click += new System.EventHandler(this.BtnUserUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.active);
            this.groupBox1.Controls.Add(this.deactive);
            this.groupBox1.Location = new System.Drawing.Point(670, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 56);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackgroundImage = global::ADBMSpro01.Properties.Resources.clearBtn;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.Location = new System.Drawing.Point(882, 299);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 40);
            this.clearBtn.TabIndex = 22;
            this.clearBtn.TabStop = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // UserChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.userManagetabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserChanges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserChanges";
            this.Load += new System.EventHandler(this.UserChanges_Load);
            this.userManagetabControl.ResumeLayout(false);
            this.PassChangeTab.ResumeLayout(false);
            this.PassChangeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).EndInit();
            this.UserManageTab.ResumeLayout(false);
            this.UserManageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUserSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUserUpdate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl userManagetabControl;
        private System.Windows.Forms.TabPage PassChangeTab;
        private System.Windows.Forms.TabPage UserManageTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox saveBtn;
        private System.Windows.Forms.ComboBox privilageCBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox SearchBtn;
        private System.Windows.Forms.RadioButton deactive;
        private System.Windows.Forms.RadioButton active;
        private System.Windows.Forms.PictureBox cancal;
        private System.Windows.Forms.PictureBox BtnUserSave;
        private System.Windows.Forms.PictureBox BtnUserUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox clearBtn;
    }
}