﻿namespace ADBMSpro01
{//author NuwanSudusinghe @ArcReactive
    partial class SalesDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Top5Chart = new LiveCharts.WinForms.CartesianChart();
            this.SearchProductTotChart = new LiveCharts.WinForms.CartesianChart();
            this.ProductYearCBox = new System.Windows.Forms.ComboBox();
            this.ProductSearchTxt = new System.Windows.Forms.TextBox();
            this.SearchProductQtyChart = new LiveCharts.WinForms.CartesianChart();
            this.SearchBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top 5 Product Sales";
            // 
            // Top5Chart
            // 
            this.Top5Chart.Location = new System.Drawing.Point(12, 25);
            this.Top5Chart.Name = "Top5Chart";
            this.Top5Chart.Size = new System.Drawing.Size(962, 206);
            this.Top5Chart.TabIndex = 1;
            this.Top5Chart.Text = "Top5Chart";
            this.Top5Chart.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.Top5Chart_ChildChanged);
            // 
            // SearchProductTotChart
            // 
            this.SearchProductTotChart.Location = new System.Drawing.Point(12, 360);
            this.SearchProductTotChart.Name = "SearchProductTotChart";
            this.SearchProductTotChart.Size = new System.Drawing.Size(960, 110);
            this.SearchProductTotChart.TabIndex = 9;
            this.SearchProductTotChart.Text = "SearchProductTotChart";
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
            this.ProductYearCBox.Location = new System.Drawing.Point(129, 256);
            this.ProductYearCBox.Name = "ProductYearCBox";
            this.ProductYearCBox.Size = new System.Drawing.Size(66, 26);
            this.ProductYearCBox.TabIndex = 8;
            this.ProductYearCBox.SelectedIndexChanged += new System.EventHandler(this.ProductYearCBox_SelectedIndexChanged);
            // 
            // ProductSearchTxt
            // 
            this.ProductSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchTxt.Location = new System.Drawing.Point(12, 256);
            this.ProductSearchTxt.Name = "ProductSearchTxt";
            this.ProductSearchTxt.Size = new System.Drawing.Size(113, 24);
            this.ProductSearchTxt.TabIndex = 7;
            // 
            // SearchProductQtyChart
            // 
            this.SearchProductQtyChart.Location = new System.Drawing.Point(201, 237);
            this.SearchProductQtyChart.Name = "SearchProductQtyChart";
            this.SearchProductQtyChart.Size = new System.Drawing.Size(771, 117);
            this.SearchProductQtyChart.TabIndex = 6;
            this.SearchProductQtyChart.Text = "SearchProductQtyChart";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::ADBMSpro01.Properties.Resources.searchBtn;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.Location = new System.Drawing.Point(41, 307);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(113, 37);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.TabStop = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SalesDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 470);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchProductTotChart);
            this.Controls.Add(this.ProductYearCBox);
            this.Controls.Add(this.ProductSearchTxt);
            this.Controls.Add(this.SearchProductQtyChart);
            this.Controls.Add(this.Top5Chart);
            this.Controls.Add(this.label1);
            this.Name = "SalesDetailsForm";
            this.Text = "SalesDetailsForm";
            this.Load += new System.EventHandler(this.SalesDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart Top5Chart;
        private LiveCharts.WinForms.CartesianChart SearchProductTotChart;
        private System.Windows.Forms.ComboBox ProductYearCBox;
        private System.Windows.Forms.TextBox ProductSearchTxt;
        private LiveCharts.WinForms.CartesianChart SearchProductQtyChart;
        private System.Windows.Forms.PictureBox SearchBtn;
    }
}