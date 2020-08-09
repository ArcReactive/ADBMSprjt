namespace ADBMSpro01
{
    partial class Login
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
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegisterPB = new System.Windows.Forms.PictureBox();
            this.ClosePBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginPBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(57, 102);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(218, 26);
            this.UsernameTxt.TabIndex = 3;
            this.UsernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(57, 142);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(218, 26);
            this.PasswordTxt.TabIndex = 4;
            this.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ADBMSpro01.Properties.Resources.officeWorkGif;
            this.pictureBox1.Location = new System.Drawing.Point(352, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterPB
            // 
            this.RegisterPB.BackgroundImage = global::ADBMSpro01.Properties.Resources.registerUserBtn;
            this.RegisterPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterPB.Location = new System.Drawing.Point(137, 234);
            this.RegisterPB.Name = "RegisterPB";
            this.RegisterPB.Size = new System.Drawing.Size(64, 58);
            this.RegisterPB.TabIndex = 5;
            this.RegisterPB.TabStop = false;
            this.RegisterPB.Click += new System.EventHandler(this.RegisterPB_Click);
            // 
            // ClosePBox
            // 
            this.ClosePBox.BackgroundImage = global::ADBMSpro01.Properties.Resources.close_icon;
            this.ClosePBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClosePBox.Location = new System.Drawing.Point(300, 12);
            this.ClosePBox.Name = "ClosePBox";
            this.ClosePBox.Size = new System.Drawing.Size(37, 35);
            this.ClosePBox.TabIndex = 2;
            this.ClosePBox.TabStop = false;
            this.ClosePBox.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ADBMSpro01.Properties.Resources.log_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(121, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 84);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // LoginPBox
            // 
            this.LoginPBox.BackgroundImage = global::ADBMSpro01.Properties.Resources.login;
            this.LoginPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginPBox.Location = new System.Drawing.Point(121, 174);
            this.LoginPBox.Name = "LoginPBox";
            this.LoginPBox.Size = new System.Drawing.Size(94, 37);
            this.LoginPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoginPBox.TabIndex = 0;
            this.LoginPBox.TabStop = false;
            this.LoginPBox.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(719, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterPB);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.ClosePBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginPBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginPBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ClosePBox;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.PictureBox RegisterPB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

