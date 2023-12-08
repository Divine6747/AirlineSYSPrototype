namespace AirlineSYS
{
    partial class chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblLibraryPopularity = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.chtLibraryPopularity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtLibraryPopularity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLibraryPopularity
            // 
            this.lblLibraryPopularity.AutoSize = true;
            this.lblLibraryPopularity.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryPopularity.Location = new System.Drawing.Point(63, 25);
            this.lblLibraryPopularity.Name = "lblLibraryPopularity";
            this.lblLibraryPopularity.Size = new System.Drawing.Size(318, 41);
            this.lblLibraryPopularity.TabIndex = 91;
            this.lblLibraryPopularity.Text = "Library Popularity";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnConfirm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(536, 591);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 37);
            this.btnConfirm.TabIndex = 90;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(703, 75);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 37);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cboMonth
            // 
            this.cboMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July"});
            this.cboMonth.Location = new System.Drawing.Point(476, 81);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(199, 26);
            this.cboMonth.TabIndex = 87;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(380, 87);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(62, 20);
            this.lblMonth.TabIndex = 88;
            this.lblMonth.Text = "Month";
            // 
            // chtLibraryPopularity
            // 
            chartArea1.Name = "ChartArea1";
            this.chtLibraryPopularity.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtLibraryPopularity.Legends.Add(legend1);
            this.chtLibraryPopularity.Location = new System.Drawing.Point(203, 148);
            this.chtLibraryPopularity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chtLibraryPopularity.Name = "chtLibraryPopularity";
            this.chtLibraryPopularity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtLibraryPopularity.Series.Add(series1);
            this.chtLibraryPopularity.Size = new System.Drawing.Size(800, 431);
            this.chtLibraryPopularity.TabIndex = 86;
            this.chtLibraryPopularity.Text = "Library Popularity Chart";
            this.chtLibraryPopularity.Visible = false;
            // 
            // chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 698);
            this.Controls.Add(this.lblLibraryPopularity);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.chtLibraryPopularity);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "chart";
            this.Text = "chart";
            ((System.ComponentModel.ISupportInitialize)(this.chtLibraryPopularity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibraryPopularity;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtLibraryPopularity;
    }
}