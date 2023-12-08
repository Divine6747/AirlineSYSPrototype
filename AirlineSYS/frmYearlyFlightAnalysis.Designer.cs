namespace AirlineSYS
{
    partial class frmYearlyFlightAnalysis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyFlightAnalysis));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuYearlyFlightAnalysis = new System.Windows.Forms.MenuStrip();
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.ry = new System.Windows.Forms.Button();
            this.grpYearlyFlightAnalysisDetails = new System.Windows.Forms.GroupBox();
            this.lblEndRouteDetails = new System.Windows.Forms.Label();
            this.btnYearlyFlightAnalysisSearch = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpYearlyFlightAnalysisDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(740, 2);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
            this.munBack.TabIndex = 9;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuYearlyFlightAnalysis
            // 
            this.mnuYearlyFlightAnalysis.BackColor = System.Drawing.Color.Plum;
            this.mnuYearlyFlightAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuYearlyFlightAnalysis.Name = "mnuYearlyFlightAnalysis";
            this.mnuYearlyFlightAnalysis.Padding = new System.Windows.Forms.Padding(0);
            this.mnuYearlyFlightAnalysis.Size = new System.Drawing.Size(800, 24);
            this.mnuYearlyFlightAnalysis.TabIndex = 8;
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYear.Location = new System.Drawing.Point(193, 50);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(92, 21);
            this.lblSelectYear.TabIndex = 10;
            this.lblSelectYear.Text = "Selects Year";
            // 
            // ry
            // 
            this.ry.BackColor = System.Drawing.Color.Plum;
            this.ry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ry.Location = new System.Drawing.Point(327, 394);
            this.ry.Name = "ry";
            this.ry.Size = new System.Drawing.Size(174, 38);
            this.ry.TabIndex = 21;
            this.ry.Text = "CONFIRM";
            this.ry.UseVisualStyleBackColor = false;
            // 
            // grpYearlyFlightAnalysisDetails
            // 
            this.grpYearlyFlightAnalysisDetails.Controls.Add(this.lblEndRouteDetails);
            this.grpYearlyFlightAnalysisDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpYearlyFlightAnalysisDetails.Location = new System.Drawing.Point(143, 118);
            this.grpYearlyFlightAnalysisDetails.Name = "grpYearlyFlightAnalysisDetails";
            this.grpYearlyFlightAnalysisDetails.Size = new System.Drawing.Size(542, 268);
            this.grpYearlyFlightAnalysisDetails.TabIndex = 20;
            this.grpYearlyFlightAnalysisDetails.TabStop = false;
            this.grpYearlyFlightAnalysisDetails.Text = "Yearly Flight Analysis Details";
            this.grpYearlyFlightAnalysisDetails.Visible = false;
            // 
            // lblEndRouteDetails
            // 
            this.lblEndRouteDetails.AutoSize = true;
            this.lblEndRouteDetails.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblEndRouteDetails.Location = new System.Drawing.Point(109, 50);
            this.lblEndRouteDetails.Name = "lblEndRouteDetails";
            this.lblEndRouteDetails.Size = new System.Drawing.Size(324, 31);
            this.lblEndRouteDetails.TabIndex = 0;
            this.lblEndRouteDetails.Text = "NO YEAR HAS BEEN SELECTED";
            // 
            // btnYearlyFlightAnalysisSearch
            // 
            this.btnYearlyFlightAnalysisSearch.BackColor = System.Drawing.Color.Plum;
            this.btnYearlyFlightAnalysisSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnYearlyFlightAnalysisSearch.Location = new System.Drawing.Point(491, 45);
            this.btnYearlyFlightAnalysisSearch.Name = "btnYearlyFlightAnalysisSearch";
            this.btnYearlyFlightAnalysisSearch.Size = new System.Drawing.Size(117, 30);
            this.btnYearlyFlightAnalysisSearch.TabIndex = 25;
            this.btnYearlyFlightAnalysisSearch.Text = "SEARCH";
            this.btnYearlyFlightAnalysisSearch.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(76, 29);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // frmYearlyFlightAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnYearlyFlightAnalysisSearch);
            this.Controls.Add(this.ry);
            this.Controls.Add(this.grpYearlyFlightAnalysisDetails);
            this.Controls.Add(this.lblSelectYear);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuYearlyFlightAnalysis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYearlyFlightAnalysis";
            this.Text = "Yearly Flight Analysis";
            this.Load += new System.EventHandler(this.frmYearlyFlightAnalysis_Load);
            this.grpYearlyFlightAnalysisDetails.ResumeLayout(false);
            this.grpYearlyFlightAnalysisDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuYearlyFlightAnalysis;
        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.Button ry;
        private System.Windows.Forms.GroupBox grpYearlyFlightAnalysisDetails;
        private System.Windows.Forms.Label lblEndRouteDetails;
        private System.Windows.Forms.Button btnYearlyFlightAnalysisSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}