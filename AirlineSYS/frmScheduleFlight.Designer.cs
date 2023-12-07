namespace AirlineSYS
{
    partial class frmScheduleFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleFlight));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuScheduleFlight = new System.Windows.Forms.MenuStrip();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.lblAirportCode = new System.Windows.Forms.Label();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.lblAirportPhone = new System.Windows.Forms.Label();
            this.lblAirportEmail = new System.Windows.Forms.Label();
            this.lblOperatorCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFlightSeats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTicketPriceFlight = new System.Windows.Forms.TextBox();
            this.grpAirportDetails = new System.Windows.Forms.GroupBox();
            this.dtpDeptFlight = new System.Windows.Forms.DateTimePicker();
            this.cboArrAirportFlight = new System.Windows.Forms.ComboBox();
            this.cboDeptAirportFlight = new System.Windows.Forms.ComboBox();
            this.btnAirportConfirm = new System.Windows.Forms.Button();
            this.cboDeptTime = new System.Windows.Forms.ComboBox();
            this.cboOperatorCodeFlight = new System.Windows.Forms.ComboBox();
            this.grpAirportDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(987, 2);
            this.munBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.munBack.Size = new System.Drawing.Size(77, 25);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuScheduleFlight
            // 
            this.mnuScheduleFlight.BackColor = System.Drawing.Color.Plum;
            this.mnuScheduleFlight.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuScheduleFlight.Location = new System.Drawing.Point(0, 0);
            this.mnuScheduleFlight.Name = "mnuScheduleFlight";
            this.mnuScheduleFlight.Padding = new System.Windows.Forms.Padding(0);
            this.mnuScheduleFlight.Size = new System.Drawing.Size(1067, 30);
            this.mnuScheduleFlight.TabIndex = 4;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(33, 34);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(198, 37);
            this.lblAddAirport.TabIndex = 11;
            this.lblAddAirport.Text = "Schedule Flight";
            this.lblAddAirport.Click += new System.EventHandler(this.lblAddAirport_Click);
            // 
            // lblAirportCode
            // 
            this.lblAirportCode.AutoSize = true;
            this.lblAirportCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportCode.Location = new System.Drawing.Point(41, 54);
            this.lblAirportCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportCode.Name = "lblAirportCode";
            this.lblAirportCode.Size = new System.Drawing.Size(153, 24);
            this.lblAirportCode.TabIndex = 7;
            this.lblAirportCode.Text = "Departure Airport";
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportName.Location = new System.Drawing.Point(571, 57);
            this.lblAirportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(122, 24);
            this.lblAirportName.TabIndex = 9;
            this.lblAirportName.Text = "Arrival Airport";
            // 
            // lblAirportPhone
            // 
            this.lblAirportPhone.AutoSize = true;
            this.lblAirportPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportPhone.Location = new System.Drawing.Point(41, 196);
            this.lblAirportPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportPhone.Name = "lblAirportPhone";
            this.lblAirportPhone.Size = new System.Drawing.Size(136, 24);
            this.lblAirportPhone.TabIndex = 17;
            this.lblAirportPhone.Text = "Departure Date";
            this.lblAirportPhone.Click += new System.EventHandler(this.lblAirportPhone_Click);
            // 
            // lblAirportEmail
            // 
            this.lblAirportEmail.AutoSize = true;
            this.lblAirportEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportEmail.Location = new System.Drawing.Point(571, 187);
            this.lblAirportEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportEmail.Name = "lblAirportEmail";
            this.lblAirportEmail.Size = new System.Drawing.Size(141, 24);
            this.lblAirportEmail.TabIndex = 19;
            this.lblAirportEmail.Text = "Departure Time";
            this.lblAirportEmail.Click += new System.EventHandler(this.lblAirportEmail_Click);
            // 
            // lblOperatorCode
            // 
            this.lblOperatorCode.AutoSize = true;
            this.lblOperatorCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCode.Location = new System.Drawing.Point(41, 124);
            this.lblOperatorCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatorCode.Name = "lblOperatorCode";
            this.lblOperatorCode.Size = new System.Drawing.Size(143, 28);
            this.lblOperatorCode.TabIndex = 20;
            this.lblOperatorCode.Text = "Operator Code";
            this.lblOperatorCode.Click += new System.EventHandler(this.lblOperatorCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Number of Seats";
            // 
            // txtNumFlightSeats
            // 
            this.txtNumFlightSeats.Location = new System.Drawing.Point(755, 118);
            this.txtNumFlightSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumFlightSeats.Name = "txtNumFlightSeats";
            this.txtNumFlightSeats.Size = new System.Drawing.Size(177, 34);
            this.txtNumFlightSeats.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ticket Price";
            // 
            // txtTicketPriceFlight
            // 
            this.txtTicketPriceFlight.Location = new System.Drawing.Point(256, 255);
            this.txtTicketPriceFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTicketPriceFlight.Name = "txtTicketPriceFlight";
            this.txtTicketPriceFlight.Size = new System.Drawing.Size(177, 34);
            this.txtTicketPriceFlight.TabIndex = 27;
            // 
            // grpAirportDetails
            // 
            this.grpAirportDetails.Controls.Add(this.cboOperatorCodeFlight);
            this.grpAirportDetails.Controls.Add(this.cboDeptTime);
            this.grpAirportDetails.Controls.Add(this.dtpDeptFlight);
            this.grpAirportDetails.Controls.Add(this.cboArrAirportFlight);
            this.grpAirportDetails.Controls.Add(this.txtTicketPriceFlight);
            this.grpAirportDetails.Controls.Add(this.cboDeptAirportFlight);
            this.grpAirportDetails.Controls.Add(this.label3);
            this.grpAirportDetails.Controls.Add(this.txtNumFlightSeats);
            this.grpAirportDetails.Controls.Add(this.label2);
            this.grpAirportDetails.Controls.Add(this.lblOperatorCode);
            this.grpAirportDetails.Controls.Add(this.lblAirportEmail);
            this.grpAirportDetails.Controls.Add(this.lblAirportPhone);
            this.grpAirportDetails.Controls.Add(this.lblAirportName);
            this.grpAirportDetails.Controls.Add(this.lblAirportCode);
            this.grpAirportDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAirportDetails.Location = new System.Drawing.Point(39, 100);
            this.grpAirportDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAirportDetails.Name = "grpAirportDetails";
            this.grpAirportDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAirportDetails.Size = new System.Drawing.Size(999, 385);
            this.grpAirportDetails.TabIndex = 12;
            this.grpAirportDetails.TabStop = false;
            this.grpAirportDetails.Text = "Schedule Flight Details";
            this.grpAirportDetails.Enter += new System.EventHandler(this.grpAirportDetails_Enter);
            // 
            // dtpDeptFlight
            // 
            this.dtpDeptFlight.CustomFormat = "dd-MM-yyyy";
            this.dtpDeptFlight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeptFlight.Location = new System.Drawing.Point(256, 187);
            this.dtpDeptFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDeptFlight.Name = "dtpDeptFlight";
            this.dtpDeptFlight.Size = new System.Drawing.Size(177, 34);
            this.dtpDeptFlight.TabIndex = 29;
            // 
            // cboArrAirportFlight
            // 
            this.cboArrAirportFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArrAirportFlight.FormattingEnabled = true;
            this.cboArrAirportFlight.Items.AddRange(new object[] {
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
            this.cboArrAirportFlight.Location = new System.Drawing.Point(755, 52);
            this.cboArrAirportFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboArrAirportFlight.Name = "cboArrAirportFlight";
            this.cboArrAirportFlight.Size = new System.Drawing.Size(177, 36);
            this.cboArrAirportFlight.TabIndex = 20;
            // 
            // cboDeptAirportFlight
            // 
            this.cboDeptAirportFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptAirportFlight.FormattingEnabled = true;
            this.cboDeptAirportFlight.Items.AddRange(new object[] {
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
            this.cboDeptAirportFlight.Location = new System.Drawing.Point(256, 46);
            this.cboDeptAirportFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDeptAirportFlight.Name = "cboDeptAirportFlight";
            this.cboDeptAirportFlight.Size = new System.Drawing.Size(177, 36);
            this.cboDeptAirportFlight.TabIndex = 19;
            // 
            // btnAirportConfirm
            // 
            this.btnAirportConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnAirportConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirportConfirm.Location = new System.Drawing.Point(413, 492);
            this.btnAirportConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAirportConfirm.Name = "btnAirportConfirm";
            this.btnAirportConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnAirportConfirm.TabIndex = 13;
            this.btnAirportConfirm.Text = "CONFIRM";
            this.btnAirportConfirm.UseVisualStyleBackColor = false;
            this.btnAirportConfirm.Click += new System.EventHandler(this.btnAirportConfirm_Click);
            // 
            // cboDeptTime
            // 
            this.cboDeptTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptTime.FormattingEnabled = true;
            this.cboDeptTime.Items.AddRange(new object[] {
            "18:00 PM",
            "06:00 AM",
            "19:00 PM",
            "07:00 AM",
            "20:00 PM",
            "08:00 AM",
            "21:00 PM",
            "09:00 AM",
            "22:00 PM",
            "10:00 AM",
            "23:00 PM",
            "11:00 AM",
            "00:00 AM",
            "12:00 PM"});
            this.cboDeptTime.Location = new System.Drawing.Point(755, 181);
            this.cboDeptTime.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeptTime.Name = "cboDeptTime";
            this.cboDeptTime.Size = new System.Drawing.Size(177, 36);
            this.cboDeptTime.TabIndex = 30;
            // 
            // cboOperatorCodeFlight
            // 
            this.cboOperatorCodeFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperatorCodeFlight.FormattingEnabled = true;
            this.cboOperatorCodeFlight.Items.AddRange(new object[] {
            "AA: American Airlines",
            "DL: Delta Air Lines",
            "EK: Emirates",
            "LH: Lufthansa",
            "BA: British Airways",
            "AC: Air Canada",
            "QF: Qantas",
            "SQ: Singapore Airlines",
            "CX: Cathay Pacific",
            "WN: Southwest Airlines",
            "AF: Air France",
            "JL: Japan Airlines",
            "TK: Turkish Airlines",
            "UA: United Airlines",
            "FR: Ryanair"});
            this.cboOperatorCodeFlight.Location = new System.Drawing.Point(256, 118);
            this.cboOperatorCodeFlight.Margin = new System.Windows.Forms.Padding(4);
            this.cboOperatorCodeFlight.Name = "cboOperatorCodeFlight";
            this.cboOperatorCodeFlight.Size = new System.Drawing.Size(177, 36);
            this.cboOperatorCodeFlight.TabIndex = 31;
            // 
            // frmScheduleFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAirportConfirm);
            this.Controls.Add(this.grpAirportDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuScheduleFlight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmScheduleFlight";
            this.Text = "Schedule Flight";
            this.Load += new System.EventHandler(this.frmScheduleFlight_Load);
            this.grpAirportDetails.ResumeLayout(false);
            this.grpAirportDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuScheduleFlight;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label lblAirportCode;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.Label lblAirportPhone;
        private System.Windows.Forms.Label lblAirportEmail;
        private System.Windows.Forms.Label lblOperatorCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFlightSeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTicketPriceFlight;
        private System.Windows.Forms.GroupBox grpAirportDetails;
        private System.Windows.Forms.Button btnAirportConfirm;
        private System.Windows.Forms.ComboBox cboArrAirportFlight;
        private System.Windows.Forms.ComboBox cboDeptAirportFlight;
        private System.Windows.Forms.DateTimePicker dtpDeptFlight;
        private System.Windows.Forms.ComboBox cboDeptTime;
        private System.Windows.Forms.ComboBox cboOperatorCodeFlight;
    }
}