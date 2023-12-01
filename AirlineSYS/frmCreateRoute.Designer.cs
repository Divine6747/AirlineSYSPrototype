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
            this.lblOperatorCode = new System.Windows.Forms.Label();
            this.txtOperatorCode = new System.Windows.Forms.TextBox();
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.txtOperatortName = new System.Windows.Forms.TextBox();
            this.lblOperatorPhone = new System.Windows.Forms.Label();
            this.txtOperatorPhone = new System.Windows.Forms.TextBox();
            this.grpOperatorDetails = new System.Windows.Forms.GroupBox();
            this.btnOperatorConfirm = new System.Windows.Forms.Button();
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
            this.lblAddAirport.Location = new System.Drawing.Point(334, 27);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(133, 30);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Create Route";
            // 
            // lblOperatorCode
            // 
            this.lblOperatorCode.AutoSize = true;
            this.lblOperatorCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCode.Location = new System.Drawing.Point(113, 83);
            this.lblOperatorCode.Name = "lblOperatorCode";
            this.lblOperatorCode.Size = new System.Drawing.Size(133, 21);
            this.lblOperatorCode.TabIndex = 7;
            this.lblOperatorCode.Text = "Departure Airport";
            // 
            // txtOperatorCode
            // 
            this.txtOperatorCode.Location = new System.Drawing.Point(262, 79);
            this.txtOperatorCode.Name = "txtOperatorCode";
            this.txtOperatorCode.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorCode.TabIndex = 8;
            // 
            // lblOperatorName
            // 
            this.lblOperatorName.AutoSize = true;
            this.lblOperatorName.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorName.Location = new System.Drawing.Point(113, 142);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(106, 20);
            this.lblOperatorName.TabIndex = 9;
            this.lblOperatorName.Text = "Arrival Airport";
            // 
            // txtOperatortName
            // 
            this.txtOperatortName.Location = new System.Drawing.Point(262, 140);
            this.txtOperatortName.Name = "txtOperatortName";
            this.txtOperatortName.Size = new System.Drawing.Size(173, 29);
            this.txtOperatortName.TabIndex = 10;
            // 
            // lblOperatorPhone
            // 
            this.lblOperatorPhone.AutoSize = true;
            this.lblOperatorPhone.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorPhone.Location = new System.Drawing.Point(113, 200);
            this.lblOperatorPhone.Name = "lblOperatorPhone";
            this.lblOperatorPhone.Size = new System.Drawing.Size(70, 20);
            this.lblOperatorPhone.TabIndex = 17;
            this.lblOperatorPhone.Text = "Duration";
            this.lblOperatorPhone.Click += new System.EventHandler(this.lblOperatorPhone_Click);
            // 
            // txtOperatorPhone
            // 
            this.txtOperatorPhone.Location = new System.Drawing.Point(262, 201);
            this.txtOperatorPhone.Name = "txtOperatorPhone";
            this.txtOperatorPhone.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorPhone.TabIndex = 17;
            // 
            // grpOperatorDetails
            // 
            this.grpOperatorDetails.Controls.Add(this.txtOperatorPhone);
            this.grpOperatorDetails.Controls.Add(this.lblOperatorPhone);
            this.grpOperatorDetails.Controls.Add(this.txtOperatortName);
            this.grpOperatorDetails.Controls.Add(this.lblOperatorName);
            this.grpOperatorDetails.Controls.Add(this.txtOperatorCode);
            this.grpOperatorDetails.Controls.Add(this.lblOperatorCode);
            this.grpOperatorDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperatorDetails.Location = new System.Drawing.Point(129, 78);
            this.grpOperatorDetails.Name = "grpOperatorDetails";
            this.grpOperatorDetails.Size = new System.Drawing.Size(542, 304);
            this.grpOperatorDetails.TabIndex = 15;
            this.grpOperatorDetails.TabStop = false;
            this.grpOperatorDetails.Text = "Route Details";
            this.grpOperatorDetails.Enter += new System.EventHandler(this.grpOperatorDetails_Enter);
            // 
            // btnOperatorConfirm
            // 
            this.btnOperatorConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnOperatorConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperatorConfirm.Location = new System.Drawing.Point(313, 399);
            this.btnOperatorConfirm.Name = "btnOperatorConfirm";
            this.btnOperatorConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnOperatorConfirm.TabIndex = 16;
            this.btnOperatorConfirm.Text = "CONFIRM";
            this.btnOperatorConfirm.UseVisualStyleBackColor = false;
            // 
            // frmCreateRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOperatorConfirm);
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
        private System.Windows.Forms.Label lblOperatorCode;
        private System.Windows.Forms.TextBox txtOperatorCode;
        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.TextBox txtOperatortName;
        private System.Windows.Forms.Label lblOperatorPhone;
        private System.Windows.Forms.TextBox txtOperatorPhone;
        private System.Windows.Forms.GroupBox grpOperatorDetails;
        private System.Windows.Forms.Button btnOperatorConfirm;
    }
}