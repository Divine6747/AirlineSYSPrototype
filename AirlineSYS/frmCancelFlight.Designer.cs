namespace AirlineSYS
{
    partial class frmCancelFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelFlight));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuCancelFlight = new System.Windows.Forms.MenuStrip();
            this.txtCancelFlightNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAirportConfirm = new System.Windows.Forms.Button();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.btnFlightSearch = new System.Windows.Forms.Button();
            this.grpCancelFlightDetails = new System.Windows.Forms.GroupBox();
            this.lblCancelFlightDetails = new System.Windows.Forms.Label();
            this.grpCancelFlightDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(987, 5);
            this.munBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.munBack.Size = new System.Drawing.Size(77, 25);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuCancelFlight
            // 
            this.mnuCancelFlight.BackColor = System.Drawing.Color.Plum;
            this.mnuCancelFlight.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCancelFlight.Location = new System.Drawing.Point(0, 0);
            this.mnuCancelFlight.Name = "mnuCancelFlight";
            this.mnuCancelFlight.Padding = new System.Windows.Forms.Padding(0);
            this.mnuCancelFlight.Size = new System.Drawing.Size(1067, 30);
            this.mnuCancelFlight.TabIndex = 4;
            // 
            // txtCancelFlightNumber
            // 
            this.txtCancelFlightNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelFlightNumber.Location = new System.Drawing.Point(387, 75);
            this.txtCancelFlightNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCancelFlightNumber.Name = "txtCancelFlightNumber";
            this.txtCancelFlightNumber.Size = new System.Drawing.Size(229, 34);
            this.txtCancelFlightNumber.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Flight Number";
            // 
            // btnAirportConfirm
            // 
            this.btnAirportConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnAirportConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirportConfirm.Location = new System.Drawing.Point(417, 562);
            this.btnAirportConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAirportConfirm.Name = "btnAirportConfirm";
            this.btnAirportConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnAirportConfirm.TabIndex = 26;
            this.btnAirportConfirm.Text = "CONFIRM";
            this.btnAirportConfirm.UseVisualStyleBackColor = false;
            this.btnAirportConfirm.Click += new System.EventHandler(this.btnAirportConfirm_Click);
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(33, 34);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(170, 37);
            this.lblAddAirport.TabIndex = 24;
            this.lblAddAirport.Text = "Cancel Flight";
            // 
            // btnFlightSearch
            // 
            this.btnFlightSearch.BackColor = System.Drawing.Color.Plum;
            this.btnFlightSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFlightSearch.Location = new System.Drawing.Point(672, 75);
            this.btnFlightSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlightSearch.Name = "btnFlightSearch";
            this.btnFlightSearch.Size = new System.Drawing.Size(168, 34);
            this.btnFlightSearch.TabIndex = 29;
            this.btnFlightSearch.Text = "SEARCH";
            this.btnFlightSearch.UseVisualStyleBackColor = false;
            this.btnFlightSearch.Click += new System.EventHandler(this.btnFlightSearch_Click);
            // 
            // grpCancelFlightDetails
            // 
            this.grpCancelFlightDetails.Controls.Add(this.lblCancelFlightDetails);
            this.grpCancelFlightDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCancelFlightDetails.Location = new System.Drawing.Point(111, 139);
            this.grpCancelFlightDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpCancelFlightDetails.Name = "grpCancelFlightDetails";
            this.grpCancelFlightDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpCancelFlightDetails.Size = new System.Drawing.Size(844, 415);
            this.grpCancelFlightDetails.TabIndex = 30;
            this.grpCancelFlightDetails.TabStop = false;
            this.grpCancelFlightDetails.Text = "Cancel Flight Details";
            this.grpCancelFlightDetails.Visible = false;
            this.grpCancelFlightDetails.Enter += new System.EventHandler(this.grpCancelFlightDetails_Enter);
            // 
            // lblCancelFlightDetails
            // 
            this.lblCancelFlightDetails.AutoSize = true;
            this.lblCancelFlightDetails.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblCancelFlightDetails.Location = new System.Drawing.Point(208, 46);
            this.lblCancelFlightDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelFlightDetails.Name = "lblCancelFlightDetails";
            this.lblCancelFlightDetails.Size = new System.Drawing.Size(428, 40);
            this.lblCancelFlightDetails.TabIndex = 1;
            this.lblCancelFlightDetails.Text = "NO FLIGHT HAS BEEN ENTERED";
            // 
            // frmCancelFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 622);
            this.Controls.Add(this.grpCancelFlightDetails);
            this.Controls.Add(this.btnFlightSearch);
            this.Controls.Add(this.txtCancelFlightNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAirportConfirm);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuCancelFlight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCancelFlight";
            this.Text = "Cancel Flight";
            this.Load += new System.EventHandler(this.frmCancelFlight_Load);
            this.grpCancelFlightDetails.ResumeLayout(false);
            this.grpCancelFlightDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuCancelFlight;
        private System.Windows.Forms.TextBox txtCancelFlightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAirportConfirm;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Button btnFlightSearch;
        private System.Windows.Forms.GroupBox grpCancelFlightDetails;
        private System.Windows.Forms.Label lblCancelFlightDetails;
    }
}