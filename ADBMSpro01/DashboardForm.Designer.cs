namespace ADBMSpro01
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
            ((System.ComponentModel.ISupportInitialize)(this.MarketingPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevenuePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesChart
            // 
            this.SalesChart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SalesChart.Location = new System.Drawing.Point(16, 15);
            this.SalesChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalesChart.Name = "SalesChart";
            this.SalesChart.Size = new System.Drawing.Size(1019, 310);
            this.SalesChart.TabIndex = 17;
            this.SalesChart.Text = "SalesChart";
            this.SalesChart.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.SalesChart_ChildChanged);
            // 
            // MarketingPBox
            // 
            this.MarketingPBox.BackgroundImage = global::ADBMSpro01.Properties.Resources.marketing;
            this.MarketingPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarketingPBox.Location = new System.Drawing.Point(1043, 209);
            this.MarketingPBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MarketingPBox.Name = "MarketingPBox";
            this.MarketingPBox.Size = new System.Drawing.Size(256, 90);
            this.MarketingPBox.TabIndex = 20;
            this.MarketingPBox.TabStop = false;
            // 
            // EmpPBox
            // 
            this.EmpPBox.BackgroundImage = global::ADBMSpro01.Properties.Resources.emp;
            this.EmpPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmpPBox.Location = new System.Drawing.Point(1043, 112);
            this.EmpPBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpPBox.Name = "EmpPBox";
            this.EmpPBox.Size = new System.Drawing.Size(256, 90);
            this.EmpPBox.TabIndex = 19;
            this.EmpPBox.TabStop = false;
            // 
            // RevenuePBox
            // 
            this.RevenuePBox.BackgroundImage = global::ADBMSpro01.Properties.Resources.rev1;
            this.RevenuePBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RevenuePBox.Location = new System.Drawing.Point(1043, 15);
            this.RevenuePBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RevenuePBox.Name = "RevenuePBox";
            this.RevenuePBox.Size = new System.Drawing.Size(256, 90);
            this.RevenuePBox.TabIndex = 18;
            this.RevenuePBox.TabStop = false;
            // 
            // AllproductChart
            // 
            this.AllproductChart.Location = new System.Drawing.Point(16, 332);
            this.AllproductChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllproductChart.Name = "AllproductChart";
            this.AllproductChart.Size = new System.Drawing.Size(1283, 231);
            this.AllproductChart.TabIndex = 21;
            this.AllproductChart.Text = "AllproductChart";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 578);
            this.Controls.Add(this.AllproductChart);
            this.Controls.Add(this.MarketingPBox);
            this.Controls.Add(this.EmpPBox);
            this.Controls.Add(this.RevenuePBox);
            this.Controls.Add(this.SalesChart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarketingPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevenuePBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MarketingPBox;
        private System.Windows.Forms.PictureBox EmpPBox;
        private System.Windows.Forms.PictureBox RevenuePBox;
        private LiveCharts.WinForms.CartesianChart SalesChart;
        private LiveCharts.WinForms.CartesianChart AllproductChart;
    }
}