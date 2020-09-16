namespace WindowsSystem625
{
    partial class FormStatus
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
            this.rtbStatusInfo = new System.Windows.Forms.RichTextBox();
            this.mbStatusClose = new MetroFramework.Controls.MetroButton();
            this.mbResetWarnings = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // rtbStatusInfo
            // 
            this.rtbStatusInfo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStatusInfo.Location = new System.Drawing.Point(34, 77);
            this.rtbStatusInfo.Name = "rtbStatusInfo";
            this.rtbStatusInfo.Size = new System.Drawing.Size(595, 231);
            this.rtbStatusInfo.TabIndex = 0;
            this.rtbStatusInfo.Text = "";
            // 
            // mbStatusClose
            // 
            this.mbStatusClose.Location = new System.Drawing.Point(482, 320);
            this.mbStatusClose.Name = "mbStatusClose";
            this.mbStatusClose.Size = new System.Drawing.Size(147, 49);
            this.mbStatusClose.TabIndex = 30;
            this.mbStatusClose.Text = "Close";
            this.mbStatusClose.UseSelectable = true;
            this.mbStatusClose.Click += new System.EventHandler(this.mbStatusClose_Click);
            // 
            // mbResetWarnings
            // 
            this.mbResetWarnings.Location = new System.Drawing.Point(301, 320);
            this.mbResetWarnings.Name = "mbResetWarnings";
            this.mbResetWarnings.Size = new System.Drawing.Size(119, 49);
            this.mbResetWarnings.TabIndex = 31;
            this.mbResetWarnings.Text = "Reset Warnings";
            this.mbResetWarnings.UseSelectable = true;
            this.mbResetWarnings.Visible = false;
            this.mbResetWarnings.Click += new System.EventHandler(this.mbResetWarnings_Click);
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 392);
            this.Controls.Add(this.mbResetWarnings);
            this.Controls.Add(this.mbStatusClose);
            this.Controls.Add(this.rtbStatusInfo);
            this.Name = "FormStatus";
            this.Text = "Status Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbStatusInfo;
        private MetroFramework.Controls.MetroButton mbStatusClose;
        private MetroFramework.Controls.MetroButton mbResetWarnings;
    }
}