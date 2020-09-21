namespace ADBMSpro01
{
    partial class MarketingDetailsForm
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
            this.MarketingMonthChart = new LiveCharts.WinForms.CartesianChart();
            this.Product5Chart = new LiveCharts.WinForms.CartesianChart();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductYearCBox = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MarketingMonthChart
            // 
            this.MarketingMonthChart.Location = new System.Drawing.Point(219, 259);
            this.MarketingMonthChart.Name = "MarketingMonthChart";
            this.MarketingMonthChart.Size = new System.Drawing.Size(756, 184);
            this.MarketingMonthChart.TabIndex = 0;
            this.MarketingMonthChart.Text = "cartesianChart1";
            // 
            // Product5Chart
            // 
            this.Product5Chart.Location = new System.Drawing.Point(12, 12);
            this.Product5Chart.Name = "Product5Chart";
            this.Product5Chart.Size = new System.Drawing.Size(962, 225);
            this.Product5Chart.TabIndex = 1;
            this.Product5Chart.Text = "Product5Chart";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTxt.Location = new System.Drawing.Point(12, 293);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(132, 24);
            this.ProductNameTxt.TabIndex = 2;
            this.ProductNameTxt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ProductYearCBox
            // 
            this.ProductYearCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductYearCBox.FormattingEnabled = true;
            this.ProductYearCBox.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020"});
            this.ProductYearCBox.Location = new System.Drawing.Point(150, 291);
            this.ProductYearCBox.Name = "ProductYearCBox";
            this.ProductYearCBox.Size = new System.Drawing.Size(63, 26);
            this.ProductYearCBox.TabIndex = 9;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::ADBMSpro01.Properties.Resources.searchBtn;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.Location = new System.Drawing.Point(60, 357);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(113, 37);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.TabStop = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Top 5 Product Cost";
            // 
            // MarketingDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ProductYearCBox);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.Product5Chart);
            this.Controls.Add(this.MarketingMonthChart);
            this.Name = "MarketingDetailsForm";
            this.Text = "MarketingDetailsForm";
            this.Load += new System.EventHandler(this.MarketingDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart MarketingMonthChart;
        private LiveCharts.WinForms.CartesianChart Product5Chart;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.ComboBox ProductYearCBox;
        private System.Windows.Forms.PictureBox SearchBtn;
        private System.Windows.Forms.Label label1;
    }
}