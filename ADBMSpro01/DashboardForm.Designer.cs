﻿namespace ADBMSpro01
{//author NuwanSudusinghe @ArcReactive
    partial class DashboardForm
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
            this.SalesChart = new LiveCharts.WinForms.CartesianChart();
            this.MarketingPBox = new System.Windows.Forms.PictureBox();
            this.EmpPBox = new System.Windows.Forms.PictureBox();
            this.RevenuePBox = new System.Windows.Forms.PictureBox();
            this.AllproductChart = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.RevenueLbl = new System.Windows.Forms.Label();
            this.EmpLbl = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MarketingPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevenuePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesChart
            // 
            this.SalesChart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SalesChart.Location = new System.Drawing.Point(12, 12);
            this.SalesChart.Name = "SalesChart";
            this.SalesChart.Size = new System.Drawing.Size(764, 252);
            this.SalesChart.TabIndex = 17;
            this.SalesChart.Text = "SalesChart";
            this.SalesChart.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.SalesChart_ChildChanged);
            // 
            // MarketingPBox
            // 
            this.MarketingPBox.BackgroundImage = global::ADBMSpro01.Properties.Resources.marketing;
            this.MarketingPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarketingPBox.Location = new System.Drawing.Point(782, 170);
            this.MarketingPBox.Name = "MarketingPBox";
            this.MarketingPBox.Size = new System.Drawing.Size(192, 73);
            this.MarketingPBox.TabIndex = 20;
            this.MarketingPBox.TabStop = false;
            // 
            // EmpPBox
            // 
            this.EmpPBox.BackgroundImage = global::ADBMSpro01.Properties.Resources.emp;
            this.EmpPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmpPBox.Location = new System.Drawing.Point(782, 91);
            this.EmpPBox.Name = "EmpPBox";
            this.EmpPBox.Size = new System.Drawing.Size(192, 73);
            this.EmpPBox.TabIndex = 19;
            this.EmpPBox.TabStop = false;
            // 
            // RevenuePBox
            // 
            this.RevenuePBox.BackgroundImage = global::ADBMSpro01.Properties.Resources.rev1;
            this.RevenuePBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RevenuePBox.Location = new System.Drawing.Point(782, 12);
            this.RevenuePBox.Name = "RevenuePBox";
            this.RevenuePBox.Size = new System.Drawing.Size(192, 73);
            this.RevenuePBox.TabIndex = 18;
            this.RevenuePBox.TabStop = false;
            // 
            // AllproductChart
            // 
            this.AllproductChart.Location = new System.Drawing.Point(12, 270);
            this.AllproductChart.Name = "AllproductChart";
            this.AllproductChart.Size = new System.Drawing.Size(962, 188);
            this.AllproductChart.TabIndex = 21;
            this.AllproductChart.Text = "AllproductChart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Products";
            // 
            // RevenueLbl
            // 
            this.RevenueLbl.AutoSize = true;
            this.RevenueLbl.BackColor = System.Drawing.Color.Transparent;
            this.RevenueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueLbl.Location = new System.Drawing.Point(860, 46);
            this.RevenueLbl.Name = "RevenueLbl";
            this.RevenueLbl.Size = new System.Drawing.Size(16, 18);
            this.RevenueLbl.TabIndex = 23;
            this.RevenueLbl.Text = "0";
            // 
            // EmpLbl
            // 
            this.EmpLbl.AutoSize = true;
            this.EmpLbl.BackColor = System.Drawing.Color.Transparent;
            this.EmpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLbl.Location = new System.Drawing.Point(843, 128);
            this.EmpLbl.Name = "EmpLbl";
            this.EmpLbl.Size = new System.Drawing.Size(16, 18);
            this.EmpLbl.TabIndex = 24;
            this.EmpLbl.Text = "0";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.BackColor = System.Drawing.Color.Transparent;
            this.CostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLbl.Location = new System.Drawing.Point(860, 203);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(16, 18);
            this.CostLbl.TabIndex = 25;
            this.CostLbl.Text = "0";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 470);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.EmpLbl);
            this.Controls.Add(this.RevenueLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllproductChart);
            this.Controls.Add(this.MarketingPBox);
            this.Controls.Add(this.EmpPBox);
            this.Controls.Add(this.RevenuePBox);
            this.Controls.Add(this.SalesChart);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarketingPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevenuePBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MarketingPBox;
        private System.Windows.Forms.PictureBox EmpPBox;
        private System.Windows.Forms.PictureBox RevenuePBox;
        private LiveCharts.WinForms.CartesianChart SalesChart;
        private LiveCharts.WinForms.CartesianChart AllproductChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RevenueLbl;
        private System.Windows.Forms.Label EmpLbl;
        private System.Windows.Forms.Label CostLbl;
    }
}