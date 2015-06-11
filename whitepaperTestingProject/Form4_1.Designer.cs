namespace whitepaperTestingProject
{
    partial class Form4_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.symLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.avgBox = new System.Windows.Forms.TextBox();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dailyVwap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.transNoBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChangeView = new System.Windows.Forms.Button();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // symLabel
            // 
            this.symLabel.AutoSize = true;
            this.symLabel.Location = new System.Drawing.Point(13, 13);
            this.symLabel.Name = "symLabel";
            this.symLabel.Size = new System.Drawing.Size(41, 13);
            this.symLabel.TabIndex = 0;
            this.symLabel.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name:";
            // 
            // compLabel
            // 
            this.compLabel.AutoSize = true;
            this.compLabel.Location = new System.Drawing.Point(38, 66);
            this.compLabel.Name = "compLabel";
            this.compLabel.Size = new System.Drawing.Size(74, 13);
            this.compLabel.TabIndex = 2;
            this.compLabel.Text = "Name go here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Avg Price";
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(66, 120);
            this.minBox.Name = "minBox";
            this.minBox.ReadOnly = true;
            this.minBox.Size = new System.Drawing.Size(64, 20);
            this.minBox.TabIndex = 6;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(66, 146);
            this.maxBox.Name = "maxBox";
            this.maxBox.ReadOnly = true;
            this.maxBox.Size = new System.Drawing.Size(64, 20);
            this.maxBox.TabIndex = 7;
            // 
            // avgBox
            // 
            this.avgBox.Location = new System.Drawing.Point(66, 173);
            this.avgBox.Name = "avgBox";
            this.avgBox.ReadOnly = true;
            this.avgBox.Size = new System.Drawing.Size(64, 20);
            this.avgBox.TabIndex = 8;
            // 
            // reportChart
            // 
            chartArea6.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.reportChart.Legends.Add(legend6);
            this.reportChart.Location = new System.Drawing.Point(137, 13);
            this.reportChart.Name = "reportChart";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Color = System.Drawing.Color.Red;
            series21.Legend = "Legend1";
            series21.Name = "avg";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Color = System.Drawing.Color.Green;
            series22.Legend = "Legend1";
            series22.Name = "vwap";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series23.Legend = "Legend1";
            series23.Name = "dailyAvg";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Color = System.Drawing.Color.Blue;
            series24.Legend = "Legend1";
            series24.Name = "dailyVwap";
            this.reportChart.Series.Add(series21);
            this.reportChart.Series.Add(series22);
            this.reportChart.Series.Add(series23);
            this.reportChart.Series.Add(series24);
            this.reportChart.Size = new System.Drawing.Size(958, 417);
            this.reportChart.TabIndex = 9;
            this.reportChart.Text = "chart1";
            // 
            // dailyVwap
            // 
            this.dailyVwap.Location = new System.Drawing.Point(66, 200);
            this.dailyVwap.Name = "dailyVwap";
            this.dailyVwap.ReadOnly = true;
            this.dailyVwap.Size = new System.Drawing.Size(64, 20);
            this.dailyVwap.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vwap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Daily Values";
            // 
            // transNoBox
            // 
            this.transNoBox.Location = new System.Drawing.Point(67, 226);
            this.transNoBox.Name = "transNoBox";
            this.transNoBox.ReadOnly = true;
            this.transNoBox.Size = new System.Drawing.Size(64, 20);
            this.transNoBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "No. Trans";
            // 
            // ChangeView
            // 
            this.ChangeView.Location = new System.Drawing.Point(16, 267);
            this.ChangeView.Name = "ChangeView";
            this.ChangeView.Size = new System.Drawing.Size(114, 23);
            this.ChangeView.TabIndex = 15;
            this.ChangeView.Text = "Change to Grid";
            this.ChangeView.UseVisualStyleBackColor = true;
            this.ChangeView.Click += new System.EventHandler(this.ChangeView_Click);
            // 
            // resultsGridView
            // 
            this.resultsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Location = new System.Drawing.Point(137, 13);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.ReadOnly = true;
            this.resultsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsGridView.Size = new System.Drawing.Size(958, 417);
            this.resultsGridView.TabIndex = 16;
            this.resultsGridView.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 442);
            this.Controls.Add(this.resultsGridView);
            this.Controls.Add(this.ChangeView);
            this.Controls.Add(this.transNoBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dailyVwap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportChart);
            this.Controls.Add(this.avgBox);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.symLabel);
            this.Name = "Form3";
            this.Text = "Detailed Tab";
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label symLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label compLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox avgBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        public System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox dailyVwap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox transNoBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ChangeView;
        private System.Windows.Forms.DataGridView resultsGridView;
    }
}