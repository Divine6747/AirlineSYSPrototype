namespace AirlineSYS
{
    partial class frmAddAirport
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
            this.mnuAddAiport = new System.Windows.Forms.MenuStrip();
            this.munBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mnuAddAiport
            // 
            this.mnuAddAiport.BackColor = System.Drawing.Color.Plum;
            this.mnuAddAiport.Location = new System.Drawing.Point(0, 0);
            this.mnuAddAiport.Name = "mnuAddAiport";
            this.mnuAddAiport.Padding = new System.Windows.Forms.Padding(0);
            this.mnuAddAiport.Size = new System.Drawing.Size(800, 24);
            this.mnuAddAiport.TabIndex = 2;
            this.mnuAddAiport.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuAddAiport_ItemClicked);
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(738, 2);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
            this.munBack.TabIndex = 3;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // frmAddAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuAddAiport);
            this.Name = "frmAddAirport";
            this.Text = "Add Airport";
            this.Load += new System.EventHandler(this.frmAddAirport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddAiport;
        private System.Windows.Forms.Label munBack;
    }
}