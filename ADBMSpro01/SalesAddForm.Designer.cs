namespace ADBMSpro01
{//author NuwanSudusinghe @ArcReactive
    partial class SalesAddForm
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
            this.PnameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SdateDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PcostTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PqtyTxt = new System.Windows.Forms.TextBox();
            this.SalesDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchSalesTxt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.PictureBox();
            this.updateBtn = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.PictureBox();
            this.SearchSalesPBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchSalesPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PnameTxt
            // 
            this.PnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnameTxt.Location = new System.Drawing.Point(113, 7);
            this.PnameTxt.Name = "PnameTxt";
            this.PnameTxt.Size = new System.Drawing.Size(235, 24);
            this.PnameTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SdateDTP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PcostTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PqtyTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PnameTxt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 90);
            this.panel1.TabIndex = 2;
            // 
            // SdateDTP
            // 
            this.SdateDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SdateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SdateDTP.Location = new System.Drawing.Point(487, 46);
            this.SdateDTP.Name = "SdateDTP";
            this.SdateDTP.Size = new System.Drawing.Size(257, 24);
            this.SdateDTP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sales Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Cost";
            // 
            // PcostTxt
            // 
            this.PcostTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PcostTxt.Location = new System.Drawing.Point(113, 48);
            this.PcostTxt.Name = "PcostTxt";
            this.PcostTxt.Size = new System.Drawing.Size(235, 24);
            this.PcostTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Quantity";
            // 
            // PqtyTxt
            // 
            this.PqtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PqtyTxt.Location = new System.Drawing.Point(487, 7);
            this.PqtyTxt.Name = "PqtyTxt";
            this.PqtyTxt.Size = new System.Drawing.Size(257, 24);
            this.PqtyTxt.TabIndex = 2;
            // 
            // SalesDataGridView
            // 
            this.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDataGridView.Location = new System.Drawing.Point(12, 108);
            this.SalesDataGridView.Name = "SalesDataGridView";
            this.SalesDataGridView.Size = new System.Drawing.Size(962, 315);
            this.SalesDataGridView.TabIndex = 3;
            this.SalesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SalesDataGridView_CellMouseClick);
            this.SalesDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SalesDataGridView_MouseClick);
            // 
            // SearchSalesTxt
            // 
            this.SearchSalesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSalesTxt.Location = new System.Drawing.Point(772, 19);
            this.SearchSalesTxt.Name = "SearchSalesTxt";
            this.SearchSalesTxt.Size = new System.Drawing.Size(202, 24);
            this.SearchSalesTxt.TabIndex = 9;
            // 
            // clearBtn
            // 
            this.clearBtn.BackgroundImage = global::ADBMSpro01.Properties.Resources.clearBtn;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.Location = new System.Drawing.Point(614, 429);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(116, 40);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.TabStop = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackgroundImage = global::ADBMSpro01.Properties.Resources.updateBtn;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.Location = new System.Drawing.Point(736, 429);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(116, 40);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.TabStop = false;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = global::ADBMSpro01.Properties.Resources.saveBtn;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Location = new System.Drawing.Point(858, 429);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 40);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.TabStop = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SearchSalesPBox
            // 
            this.SearchSalesPBox.BackgroundImage = global::ADBMSpro01.Properties.Resources.searchBtn;
            this.SearchSalesPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchSalesPBox.Location = new System.Drawing.Point(829, 52);
            this.SearchSalesPBox.Name = "SearchSalesPBox";
            this.SearchSalesPBox.Size = new System.Drawing.Size(104, 32);
            this.SearchSalesPBox.TabIndex = 10;
            this.SearchSalesPBox.TabStop = false;
            this.SearchSalesPBox.Click += new System.EventHandler(this.SearchSalesPBox_Click);
            // 
            // SalesAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 470);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.SearchSalesPBox);
            this.Controls.Add(this.SearchSalesTxt);
            this.Controls.Add(this.SalesDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "SalesAddForm";
            this.Text = "SalesAddForm";
            this.Load += new System.EventHandler(this.SalesAddForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchSalesPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PnameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PqtyTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PcostTxt;
        private System.Windows.Forms.DateTimePicker SdateDTP;
        private System.Windows.Forms.DataGridView SalesDataGridView;
        private System.Windows.Forms.TextBox SearchSalesTxt;
        private System.Windows.Forms.PictureBox SearchSalesPBox;
        private System.Windows.Forms.PictureBox saveBtn;
        private System.Windows.Forms.PictureBox updateBtn;
        private System.Windows.Forms.PictureBox clearBtn;
    }
}