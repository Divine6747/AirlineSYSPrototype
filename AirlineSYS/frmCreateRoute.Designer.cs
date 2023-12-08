namespace AirlineSYS
{
    partial class frmCreateRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateRoute));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuCreateRoute = new System.Windows.Forms.MenuStrip();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.lblDepartAirport = new System.Windows.Forms.Label();
            this.lblArrAirport = new System.Windows.Forms.Label();
            this.lblRouteDuration = new System.Windows.Forms.Label();
            this.txtDurationRoute = new System.Windows.Forms.TextBox();
            this.grpOperatorDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboArrAirportCreteRoute = new System.Windows.Forms.ComboBox();
            this.cboDeptAirportCreteRoute = new System.Windows.Forms.ComboBox();
            this.btnCreateRouteConfirm = new System.Windows.Forms.Button();
            this.grpOperatorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(985, -1);
            this.munBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(13, 2, 13, 2);
            this.munBack.Size = new System.Drawing.Size(77, 29);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuCreateRoute
            // 
            this.mnuCreateRoute.BackColor = System.Drawing.Color.Plum;
            this.mnuCreateRoute.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCreateRoute.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateRoute.Name = "mnuCreateRoute";
            this.mnuCreateRoute.Padding = new System.Windows.Forms.Padding(0);
            this.mnuCreateRoute.Size = new System.Drawing.Size(1067, 24);
            this.mnuCreateRoute.TabIndex = 4;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(445, 37);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(170, 37);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Create Route";
            // 
            // lblDepartAirport
            // 
            this.lblDepartAirport.AutoSize = true;
            this.lblDepartAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartAirport.Location = new System.Drawing.Point(109, 102);
            this.lblDepartAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartAirport.Name = "lblDepartAirport";
            this.lblDepartAirport.Size = new System.Drawing.Size(168, 28);
            this.lblDepartAirport.TabIndex = 7;
            this.lblDepartAirport.Text = "Departure Airport";
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(109, 175);
            this.lblArrAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(122, 24);
            this.lblArrAirport.TabIndex = 9;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // lblRouteDuration
            // 
            this.lblRouteDuration.AutoSize = true;
            this.lblRouteDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteDuration.Location = new System.Drawing.Point(109, 246);
            this.lblRouteDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRouteDuration.Name = "lblRouteDuration";
            this.lblRouteDuration.Size = new System.Drawing.Size(80, 24);
            this.lblRouteDuration.TabIndex = 17;
            this.lblRouteDuration.Text = "Duration";
            this.lblRouteDuration.Click += new System.EventHandler(this.lblOperatorPhone_Click);
            // 
            // txtDurationRoute
            // 
            this.txtDurationRoute.Location = new System.Drawing.Point(359, 241);
            this.txtDurationRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDurationRoute.Name = "txtDurationRoute";
            this.txtDurationRoute.Size = new System.Drawing.Size(195, 34);
            this.txtDurationRoute.TabIndex = 17;
            // 
            // grpOperatorDetails
            // 
            this.grpOperatorDetails.Controls.Add(this.label1);
            this.grpOperatorDetails.Controls.Add(this.cboArrAirportCreteRoute);
            this.grpOperatorDetails.Controls.Add(this.cboDeptAirportCreteRoute);
            this.grpOperatorDetails.Controls.Add(this.txtDurationRoute);
            this.grpOperatorDetails.Controls.Add(this.lblRouteDuration);
            this.grpOperatorDetails.Controls.Add(this.lblArrAirport);
            this.grpOperatorDetails.Controls.Add(this.lblDepartAirport);
            this.grpOperatorDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperatorDetails.Location = new System.Drawing.Point(201, 96);
            this.grpOperatorDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOperatorDetails.Name = "grpOperatorDetails";
            this.grpOperatorDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOperatorDetails.Size = new System.Drawing.Size(665, 351);
            this.grpOperatorDetails.TabIndex = 15;
            this.grpOperatorDetails.TabStop = false;
            this.grpOperatorDetails.Text = "Route Details";
            this.grpOperatorDetails.Enter += new System.EventHandler(this.grpOperatorDetails_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 19;
            // 
            // cboArrAirportCreteRoute
            // 
            this.cboArrAirportCreteRoute.FormattingEnabled = true;
            this.cboArrAirportCreteRoute.Items.AddRange(new object[] {
            "JFK",
            "CDG",
            "DXB",
            "PEK",
            "NRT",
            "YYZ",
            "FRA",
            "HKG",
            "ICN",
            "MIA",
            "CGK",
            "SNN",
            "DUB",
            "SHA",
            "FCO",
            "BGY"});
            this.cboArrAirportCreteRoute.Location = new System.Drawing.Point(359, 170);
            this.cboArrAirportCreteRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboArrAirportCreteRoute.Name = "cboArrAirportCreteRoute";
            this.cboArrAirportCreteRoute.Size = new System.Drawing.Size(195, 36);
            this.cboArrAirportCreteRoute.TabIndex = 18;
            // 
            // cboDeptAirportCreteRoute
            // 
            this.cboDeptAirportCreteRoute.FormattingEnabled = true;
            this.cboDeptAirportCreteRoute.Items.AddRange(new object[] {
            "JFK",
            "CDG",
            "DXB",
            "PEK",
            "NRT",
            "YYZ",
            "FRA",
            "HKG",
            "ICN",
            "MIA",
            "CGK",
            "SNN",
            "DUB",
            "SHA",
            "FCO",
            "BGY"});
            this.cboDeptAirportCreteRoute.Location = new System.Drawing.Point(359, 97);
            this.cboDeptAirportCreteRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDeptAirportCreteRoute.Name = "cboDeptAirportCreteRoute";
            this.cboDeptAirportCreteRoute.Size = new System.Drawing.Size(195, 36);
            this.cboDeptAirportCreteRoute.TabIndex = 17;
            // 
            // btnCreateRouteConfirm
            // 
            this.btnCreateRouteConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnCreateRouteConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRouteConfirm.Location = new System.Drawing.Point(417, 491);
            this.btnCreateRouteConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateRouteConfirm.Name = "btnCreateRouteConfirm";
            this.btnCreateRouteConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnCreateRouteConfirm.TabIndex = 16;
            this.btnCreateRouteConfirm.Text = "CONFIRM";
            this.btnCreateRouteConfirm.UseVisualStyleBackColor = false;
            this.btnCreateRouteConfirm.Click += new System.EventHandler(this.btnCreateRouteConfirm_Click);
            // 
            // frmCreateRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCreateRouteConfirm);
            this.Controls.Add(this.grpOperatorDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuCreateRoute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCreateRoute";
            this.Text = "Create Route";
            this.Load += new System.EventHandler(this.frmCreateRoute_Load);
            this.grpOperatorDetails.ResumeLayout(false);
            this.grpOperatorDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuCreateRoute;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label lblDepartAirport;
        private System.Windows.Forms.Label lblArrAirport;
        private System.Windows.Forms.Label lblRouteDuration;
        private System.Windows.Forms.TextBox txtDurationRoute;
        private System.Windows.Forms.GroupBox grpOperatorDetails;
        private System.Windows.Forms.Button btnCreateRouteConfirm;
        private System.Windows.Forms.ComboBox cboArrAirportCreteRoute;
        private System.Windows.Forms.ComboBox cboDeptAirportCreteRoute;
        private System.Windows.Forms.Label label1;
    }
}