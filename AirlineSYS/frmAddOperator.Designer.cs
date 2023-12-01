namespace AirlineSYS
{
    partial class frmAddOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOperator));
            this.mnuAddOperator = new System.Windows.Forms.MenuStrip();
            this.btnOperatorConfirm = new System.Windows.Forms.Button();
            this.grpOperatorDetails = new System.Windows.Forms.GroupBox();
            this.txtOperatorEmail = new System.Windows.Forms.TextBox();
            this.lblOperatorEmail = new System.Windows.Forms.Label();
            this.txtOperatorPhone = new System.Windows.Forms.TextBox();
            this.lblOperatorPhone = new System.Windows.Forms.Label();
            this.grpAirportAddress = new System.Windows.Forms.GroupBox();
            this.txtOperatorEircode = new System.Windows.Forms.TextBox();
            this.lblOperatorEircode = new System.Windows.Forms.Label();
            this.lblOperatorStreet = new System.Windows.Forms.Label();
            this.txtOperatorCountry = new System.Windows.Forms.TextBox();
            this.txtOperatorStreet = new System.Windows.Forms.TextBox();
            this.lblOperatorCountry = new System.Windows.Forms.Label();
            this.lblOperatorCity = new System.Windows.Forms.Label();
            this.txtAirportCity = new System.Windows.Forms.TextBox();
            this.txtOperatortName = new System.Windows.Forms.TextBox();
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.txtOperatorCode = new System.Windows.Forms.TextBox();
            this.lblOperatorCode = new System.Windows.Forms.Label();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.munBack = new System.Windows.Forms.Label();
            this.grpOperatorDetails.SuspendLayout();
            this.grpAirportAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddOperator
            // 
            this.mnuAddOperator.BackColor = System.Drawing.Color.Plum;
            this.mnuAddOperator.Location = new System.Drawing.Point(0, 0);
            this.mnuAddOperator.Name = "mnuAddOperator";
            this.mnuAddOperator.Padding = new System.Windows.Forms.Padding(0);
            this.mnuAddOperator.Size = new System.Drawing.Size(800, 24);
            this.mnuAddOperator.TabIndex = 4;
            this.mnuAddOperator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuAddOperator_ItemClicked);
            // 
            // btnOperatorConfirm
            // 
            this.btnOperatorConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnOperatorConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperatorConfirm.Location = new System.Drawing.Point(311, 398);
            this.btnOperatorConfirm.Name = "btnOperatorConfirm";
            this.btnOperatorConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnOperatorConfirm.TabIndex = 13;
            this.btnOperatorConfirm.Text = "CONFIRM";
            this.btnOperatorConfirm.UseVisualStyleBackColor = false;
            // 
            // grpOperatorDetails
            // 
            this.grpOperatorDetails.Controls.Add(this.txtOperatorEmail);
            this.grpOperatorDetails.Controls.Add(this.lblOperatorEmail);
            this.grpOperatorDetails.Controls.Add(this.txtOperatorPhone);
            this.grpOperatorDetails.Controls.Add(this.lblOperatorPhone);
            this.grpOperatorDetails.Controls.Add(this.grpAirportAddress);
            this.grpOperatorDetails.Controls.Add(this.txtOperatortName);
            this.grpOperatorDetails.Controls.Add(this.lblOperatorName);
            this.grpOperatorDetails.Controls.Add(this.txtOperatorCode);
            this.grpOperatorDetails.Controls.Add(this.lblOperatorCode);
            this.grpOperatorDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperatorDetails.Location = new System.Drawing.Point(31, 77);
            this.grpOperatorDetails.Name = "grpOperatorDetails";
            this.grpOperatorDetails.Size = new System.Drawing.Size(749, 304);
            this.grpOperatorDetails.TabIndex = 12;
            this.grpOperatorDetails.TabStop = false;
            this.grpOperatorDetails.Text = "Operator Details";
            // 
            // txtOperatorEmail
            // 
            this.txtOperatorEmail.Location = new System.Drawing.Point(470, 233);
            this.txtOperatorEmail.Name = "txtOperatorEmail";
            this.txtOperatorEmail.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorEmail.TabIndex = 18;
            // 
            // lblOperatorEmail
            // 
            this.lblOperatorEmail.AutoSize = true;
            this.lblOperatorEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorEmail.Location = new System.Drawing.Point(388, 236);
            this.lblOperatorEmail.Name = "lblOperatorEmail";
            this.lblOperatorEmail.Size = new System.Drawing.Size(48, 21);
            this.lblOperatorEmail.TabIndex = 19;
            this.lblOperatorEmail.Text = "Email";
            // 
            // txtOperatorPhone
            // 
            this.txtOperatorPhone.Location = new System.Drawing.Point(148, 232);
            this.txtOperatorPhone.Name = "txtOperatorPhone";
            this.txtOperatorPhone.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorPhone.TabIndex = 17;
            // 
            // lblOperatorPhone
            // 
            this.lblOperatorPhone.AutoSize = true;
            this.lblOperatorPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorPhone.Location = new System.Drawing.Point(52, 236);
            this.lblOperatorPhone.Name = "lblOperatorPhone";
            this.lblOperatorPhone.Size = new System.Drawing.Size(54, 21);
            this.lblOperatorPhone.TabIndex = 17;
            this.lblOperatorPhone.Text = "Phone";
            // 
            // grpAirportAddress
            // 
            this.grpAirportAddress.Controls.Add(this.txtOperatorEircode);
            this.grpAirportAddress.Controls.Add(this.lblOperatorEircode);
            this.grpAirportAddress.Controls.Add(this.lblOperatorStreet);
            this.grpAirportAddress.Controls.Add(this.txtOperatorCountry);
            this.grpAirportAddress.Controls.Add(this.txtOperatorStreet);
            this.grpAirportAddress.Controls.Add(this.lblOperatorCountry);
            this.grpAirportAddress.Controls.Add(this.lblOperatorCity);
            this.grpAirportAddress.Controls.Add(this.txtAirportCity);
            this.grpAirportAddress.Location = new System.Drawing.Point(35, 76);
            this.grpAirportAddress.Name = "grpAirportAddress";
            this.grpAirportAddress.Size = new System.Drawing.Size(642, 146);
            this.grpAirportAddress.TabIndex = 11;
            this.grpAirportAddress.TabStop = false;
            this.grpAirportAddress.Text = "Address";
            // 
            // txtOperatorEircode
            // 
            this.txtOperatorEircode.Location = new System.Drawing.Point(434, 74);
            this.txtOperatorEircode.Name = "txtOperatorEircode";
            this.txtOperatorEircode.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorEircode.TabIndex = 16;
            // 
            // lblOperatorEircode
            // 
            this.lblOperatorEircode.AutoSize = true;
            this.lblOperatorEircode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorEircode.Location = new System.Drawing.Point(353, 76);
            this.lblOperatorEircode.Name = "lblOperatorEircode";
            this.lblOperatorEircode.Size = new System.Drawing.Size(61, 21);
            this.lblOperatorEircode.TabIndex = 15;
            this.lblOperatorEircode.Text = "Eircode";
            // 
            // lblOperatorStreet
            // 
            this.lblOperatorStreet.AutoSize = true;
            this.lblOperatorStreet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorStreet.Location = new System.Drawing.Point(17, 34);
            this.lblOperatorStreet.Name = "lblOperatorStreet";
            this.lblOperatorStreet.Size = new System.Drawing.Size(50, 21);
            this.lblOperatorStreet.TabIndex = 9;
            this.lblOperatorStreet.Text = "Street";
            // 
            // txtOperatorCountry
            // 
            this.txtOperatorCountry.Location = new System.Drawing.Point(113, 73);
            this.txtOperatorCountry.Name = "txtOperatorCountry";
            this.txtOperatorCountry.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorCountry.TabIndex = 14;
            this.txtOperatorCountry.TextChanged += new System.EventHandler(this.txtOperatorCountry_TextChanged);
            // 
            // txtOperatorStreet
            // 
            this.txtOperatorStreet.Location = new System.Drawing.Point(113, 25);
            this.txtOperatorStreet.Name = "txtOperatorStreet";
            this.txtOperatorStreet.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorStreet.TabIndex = 12;
            this.txtOperatorStreet.TextChanged += new System.EventHandler(this.txtOperatorStreet_TextChanged);
            // 
            // lblOperatorCountry
            // 
            this.lblOperatorCountry.AutoSize = true;
            this.lblOperatorCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCountry.Location = new System.Drawing.Point(17, 77);
            this.lblOperatorCountry.Name = "lblOperatorCountry";
            this.lblOperatorCountry.Size = new System.Drawing.Size(66, 21);
            this.lblOperatorCountry.TabIndex = 13;
            this.lblOperatorCountry.Text = "Country";
            // 
            // lblOperatorCity
            // 
            this.lblOperatorCity.AutoSize = true;
            this.lblOperatorCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCity.Location = new System.Drawing.Point(353, 34);
            this.lblOperatorCity.Name = "lblOperatorCity";
            this.lblOperatorCity.Size = new System.Drawing.Size(37, 21);
            this.lblOperatorCity.TabIndex = 13;
            this.lblOperatorCity.Text = "City";
            // 
            // txtAirportCity
            // 
            this.txtAirportCity.Location = new System.Drawing.Point(434, 31);
            this.txtAirportCity.Name = "txtAirportCity";
            this.txtAirportCity.Size = new System.Drawing.Size(173, 29);
            this.txtAirportCity.TabIndex = 14;
            // 
            // txtOperatortName
            // 
            this.txtOperatortName.Location = new System.Drawing.Point(469, 43);
            this.txtOperatortName.Name = "txtOperatortName";
            this.txtOperatortName.Size = new System.Drawing.Size(173, 29);
            this.txtOperatortName.TabIndex = 10;
            // 
            // lblOperatorName
            // 
            this.lblOperatorName.AutoSize = true;
            this.lblOperatorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorName.Location = new System.Drawing.Point(388, 46);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(52, 21);
            this.lblOperatorName.TabIndex = 9;
            this.lblOperatorName.Text = "Name";
            // 
            // txtOperatorCode
            // 
            this.txtOperatorCode.Location = new System.Drawing.Point(148, 39);
            this.txtOperatorCode.Name = "txtOperatorCode";
            this.txtOperatorCode.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorCode.TabIndex = 8;
            // 
            // lblOperatorCode
            // 
            this.lblOperatorCode.AutoSize = true;
            this.lblOperatorCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCode.Location = new System.Drawing.Point(29, 43);
            this.lblOperatorCode.Name = "lblOperatorCode";
            this.lblOperatorCode.Size = new System.Drawing.Size(113, 21);
            this.lblOperatorCode.TabIndex = 7;
            this.lblOperatorCode.Text = "Operator Code";
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(26, 26);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(140, 30);
            this.lblAddAirport.TabIndex = 11;
            this.lblAddAirport.Text = "Add Operator";
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
            // frmAddOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOperatorConfirm);
            this.Controls.Add(this.grpOperatorDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuAddOperator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddOperator";
            this.Text = "Add Operator";
            this.Load += new System.EventHandler(this.frmAddOperator_Load);
            this.grpOperatorDetails.ResumeLayout(false);
            this.grpOperatorDetails.PerformLayout();
            this.grpAirportAddress.ResumeLayout(false);
            this.grpAirportAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuAddOperator;
        private System.Windows.Forms.Button btnOperatorConfirm;
        private System.Windows.Forms.GroupBox grpOperatorDetails;
        private System.Windows.Forms.TextBox txtOperatorEmail;
        private System.Windows.Forms.Label lblOperatorEmail;
        private System.Windows.Forms.TextBox txtOperatorPhone;
        private System.Windows.Forms.Label lblOperatorPhone;
        private System.Windows.Forms.GroupBox grpAirportAddress;
        private System.Windows.Forms.TextBox txtOperatorEircode;
        private System.Windows.Forms.Label lblOperatorEircode;
        private System.Windows.Forms.Label lblOperatorStreet;
        private System.Windows.Forms.TextBox txtOperatorCountry;
        private System.Windows.Forms.TextBox txtOperatorStreet;
        private System.Windows.Forms.Label lblOperatorCountry;
        private System.Windows.Forms.Label lblOperatorCity;
        private System.Windows.Forms.TextBox txtAirportCity;
        private System.Windows.Forms.TextBox txtOperatortName;
        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.TextBox txtOperatorCode;
        private System.Windows.Forms.Label lblOperatorCode;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label munBack;
    }
}