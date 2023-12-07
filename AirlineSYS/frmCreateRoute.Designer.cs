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
            this.cboArrAirportCreteRoute = new System.Windows.Forms.ComboBox();
            this.cboDeptAirportCreteRoute = new System.Windows.Forms.ComboBox();
            this.btnCreateRouteConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOperatorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(739, -1);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.munBack.Size = new System.Drawing.Size(60, 24);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuCreateRoute
            // 
            this.mnuCreateRoute.BackColor = System.Drawing.Color.Plum;
            this.mnuCreateRoute.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateRoute.Name = "mnuCreateRoute";
            this.mnuCreateRoute.Padding = new System.Windows.Forms.Padding(0);
            this.mnuCreateRoute.Size = new System.Drawing.Size(800, 24);
            this.mnuCreateRoute.TabIndex = 4;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(334, 30);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(133, 30);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Create Route";
            // 
            // lblDepartAirport
            // 
            this.lblDepartAirport.AutoSize = true;
            this.lblDepartAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartAirport.Location = new System.Drawing.Point(82, 83);
            this.lblDepartAirport.Name = "lblDepartAirport";
            this.lblDepartAirport.Size = new System.Drawing.Size(133, 21);
            this.lblDepartAirport.TabIndex = 7;
            this.lblDepartAirport.Text = "Departure Airport";
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(82, 142);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(106, 20);
            this.lblArrAirport.TabIndex = 9;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // lblRouteDuration
            // 
            this.lblRouteDuration.AutoSize = true;
            this.lblRouteDuration.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteDuration.Location = new System.Drawing.Point(82, 200);
            this.lblRouteDuration.Name = "lblRouteDuration";
            this.lblRouteDuration.Size = new System.Drawing.Size(70, 20);
            this.lblRouteDuration.TabIndex = 17;
            this.lblRouteDuration.Text = "Duration";
            this.lblRouteDuration.Click += new System.EventHandler(this.lblOperatorPhone_Click);
            // 
            // txtDurationRoute
            // 
            this.txtDurationRoute.Location = new System.Drawing.Point(269, 196);
            this.txtDurationRoute.Name = "txtDurationRoute";
            this.txtDurationRoute.Size = new System.Drawing.Size(147, 29);
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
            this.grpOperatorDetails.Location = new System.Drawing.Point(151, 78);
            this.grpOperatorDetails.Name = "grpOperatorDetails";
            this.grpOperatorDetails.Size = new System.Drawing.Size(499, 285);
            this.grpOperatorDetails.TabIndex = 15;
            this.grpOperatorDetails.TabStop = false;
            this.grpOperatorDetails.Text = "Route Details";
            this.grpOperatorDetails.Enter += new System.EventHandler(this.grpOperatorDetails_Enter);
            // 
            // cboArrAirportCreteRoute
            // 
            this.cboArrAirportCreteRoute.FormattingEnabled = true;
            this.cboArrAirportCreteRoute.Items.AddRange(new object[] {
            "JFK",
            "LHR",
            "CDG",
            "SYD",
            "DXB",
            "PEK",
            "NRT",
            "AMS",
            "YYZ",
            "FRA",
            "SIN",
            "HKG",
            "ICN",
            "MEX",
            "IST",
            "DFW",
            "MIA",
            "SFO",
            "ATL",
            "BKK",
            "MUC",
            "YVR",
            "LAX",
            "ORD",
            "MAD",
            "CGK",
            "SNN",
            "DUB",
            "SHA",
            "FCO",
            "BGY"});
            this.cboArrAirportCreteRoute.Location = new System.Drawing.Point(269, 138);
            this.cboArrAirportCreteRoute.Name = "cboArrAirportCreteRoute";
            this.cboArrAirportCreteRoute.Size = new System.Drawing.Size(147, 29);
            this.cboArrAirportCreteRoute.TabIndex = 18;
            // 
            // cboDeptAirportCreteRoute
            // 
            this.cboDeptAirportCreteRoute.FormattingEnabled = true;
            this.cboDeptAirportCreteRoute.Items.AddRange(new object[] {
            "JFK",
            "LHR",
            "CDG",
            "SYD",
            "DXB",
            "PEK",
            "NRT",
            "AMS",
            "YYZ",
            "FRA",
            "SIN",
            "HKG",
            "ICN",
            "MEX",
            "IST",
            "DFW",
            "MIA",
            "SFO",
            "ATL",
            "BKK",
            "MUC",
            "YVR",
            "LAX",
            "ORD",
            "MAD",
            "CGK",
            "SNN",
            "DUB",
            "SHA",
            "FCO",
            "BGY"});
            this.cboDeptAirportCreteRoute.Location = new System.Drawing.Point(269, 79);
            this.cboDeptAirportCreteRoute.Name = "cboDeptAirportCreteRoute";
            this.cboDeptAirportCreteRoute.Size = new System.Drawing.Size(147, 29);
            this.cboDeptAirportCreteRoute.TabIndex = 17;
            // 
            // btnCreateRouteConfirm
            // 
            this.btnCreateRouteConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnCreateRouteConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRouteConfirm.Location = new System.Drawing.Point(313, 399);
            this.btnCreateRouteConfirm.Name = "btnCreateRouteConfirm";
            this.btnCreateRouteConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnCreateRouteConfirm.TabIndex = 16;
            this.btnCreateRouteConfirm.Text = "CONFIRM";
            this.btnCreateRouteConfirm.UseVisualStyleBackColor = false;
            this.btnCreateRouteConfirm.Click += new System.EventHandler(this.btnCreateRouteConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 19;
            // 
            // frmCreateRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateRouteConfirm);
            this.Controls.Add(this.grpOperatorDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuCreateRoute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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