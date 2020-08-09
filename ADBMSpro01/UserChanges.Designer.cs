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
            this.UserManageTab = new System.Windows.Forms.TabPage();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRe = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.PictureBox();
            this.userManagetabControl.SuspendLayout();
            this.PassChangeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).BeginInit();
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
            // UserManageTab
            // 
            this.UserManageTab.Location = new System.Drawing.Point(4, 22);
            this.UserManageTab.Name = "UserManageTab";
            this.UserManageTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserManageTab.Size = new System.Drawing.Size(1024, 400);
            this.UserManageTab.TabIndex = 1;
            this.UserManageTab.Text = "User Manage";
            this.UserManageTab.UseVisualStyleBackColor = true;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(432, 72);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(330, 24);
            this.txtCurrent.TabIndex = 0;
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
    }
}