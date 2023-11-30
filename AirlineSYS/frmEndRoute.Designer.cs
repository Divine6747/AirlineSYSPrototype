namespace AirlineSYS
{
    partial class frmEndRoute
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
            this.munBack = new System.Windows.Forms.Label();
            this.mnuEndRoute = new System.Windows.Forms.MenuStrip();
            this.btnOperatorConfirm = new System.Windows.Forms.Button();
            this.grpOperatorDetails = new System.Windows.Forms.GroupBox();
            this.txtOperatorPhone = new System.Windows.Forms.TextBox();
            this.lblOperatorPhone = new System.Windows.Forms.Label();
            this.txtOperatortName = new System.Windows.Forms.TextBox();
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.txtOperatorCode = new System.Windows.Forms.TextBox();
            this.lblOperatorCode = new System.Windows.Forms.Label();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpOperatorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(740, 1);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuEndRoute
            // 
            this.mnuEndRoute.BackColor = System.Drawing.Color.Plum;
            this.mnuEndRoute.Location = new System.Drawing.Point(0, 0);
            this.mnuEndRoute.Name = "mnuEndRoute";
            this.mnuEndRoute.Padding = new System.Windows.Forms.Padding(0);
            this.mnuEndRoute.Size = new System.Drawing.Size(800, 24);
            this.mnuEndRoute.TabIndex = 4;
            // 
            // btnOperatorConfirm
            // 
            this.btnOperatorConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnOperatorConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperatorConfirm.Location = new System.Drawing.Point(313, 399);
            this.btnOperatorConfirm.Name = "btnOperatorConfirm";
            this.btnOperatorConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnOperatorConfirm.TabIndex = 19;
            this.btnOperatorConfirm.Text = "CONFIRM";
            this.btnOperatorConfirm.UseVisualStyleBackColor = false;
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
            this.grpOperatorDetails.Location = new System.Drawing.Point(129, 128);
            this.grpOperatorDetails.Name = "grpOperatorDetails";
            this.grpOperatorDetails.Size = new System.Drawing.Size(542, 254);
            this.grpOperatorDetails.TabIndex = 18;
            this.grpOperatorDetails.TabStop = false;
            this.grpOperatorDetails.Text = "End Route Details";
            // 
            // txtOperatorPhone
            // 
            this.txtOperatorPhone.Location = new System.Drawing.Point(262, 201);
            this.txtOperatorPhone.Name = "txtOperatorPhone";
            this.txtOperatorPhone.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorPhone.TabIndex = 17;
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
            // 
            // txtOperatortName
            // 
            this.txtOperatortName.Location = new System.Drawing.Point(262, 140);
            this.txtOperatortName.Name = "txtOperatortName";
            this.txtOperatortName.Size = new System.Drawing.Size(173, 29);
            this.txtOperatortName.TabIndex = 10;
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
            // txtOperatorCode
            // 
            this.txtOperatorCode.Location = new System.Drawing.Point(262, 79);
            this.txtOperatorCode.Name = "txtOperatorCode";
            this.txtOperatorCode.Size = new System.Drawing.Size(173, 29);
            this.txtOperatorCode.TabIndex = 8;
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
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(334, 27);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(108, 30);
            this.lblAddAirport.TabIndex = 17;
            this.lblAddAirport.Text = "End Route";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Route ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(374, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 29);
            this.textBox1.TabIndex = 21;
            // 
            // frmEndRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOperatorConfirm);
            this.Controls.Add(this.grpOperatorDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuEndRoute);
            this.Name = "frmEndRoute";
            this.Text = "End Route";
            this.Load += new System.EventHandler(this.frmEndRoute_Load);
            this.grpOperatorDetails.ResumeLayout(false);
            this.grpOperatorDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuEndRoute;
        private System.Windows.Forms.Button btnOperatorConfirm;
        private System.Windows.Forms.GroupBox grpOperatorDetails;
        private System.Windows.Forms.TextBox txtOperatorPhone;
        private System.Windows.Forms.Label lblOperatorPhone;
        private System.Windows.Forms.TextBox txtOperatortName;
        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.TextBox txtOperatorCode;
        private System.Windows.Forms.Label lblOperatorCode;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}