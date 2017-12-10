namespace WinFormsForSwypConvert
{
    partial class frmTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimerID = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBodyTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCloseTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinalTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStopTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWriteJSONFile = new System.Windows.Forms.Button();
            this.btnReadJSONFile = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTimerID
            // 
            this.txtTimerID.Location = new System.Drawing.Point(194, 44);
            this.txtTimerID.Name = "txtTimerID";
            this.txtTimerID.Size = new System.Drawing.Size(207, 20);
            this.txtTimerID.TabIndex = 1;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(194, 94);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(207, 20);
            this.txtInterval.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timer Interval in milliseconds:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(194, 140);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.Size = new System.Drawing.Size(207, 20);
            this.txtTotalTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total time (milliseconds):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBodyTime
            // 
            this.txtBodyTime.Location = new System.Drawing.Point(194, 166);
            this.txtBodyTime.Name = "txtBodyTime";
            this.txtBodyTime.Size = new System.Drawing.Size(207, 20);
            this.txtBodyTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Body time (milliseconds):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCloseTime
            // 
            this.txtCloseTime.Location = new System.Drawing.Point(194, 192);
            this.txtCloseTime.Name = "txtCloseTime";
            this.txtCloseTime.Size = new System.Drawing.Size(207, 20);
            this.txtCloseTime.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Close time (milliseconds):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFinalTime
            // 
            this.txtFinalTime.Location = new System.Drawing.Point(194, 218);
            this.txtFinalTime.Name = "txtFinalTime";
            this.txtFinalTime.Size = new System.Drawing.Size(207, 20);
            this.txtFinalTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Final time (milliseconds):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStopTime
            // 
            this.txtStopTime.Location = new System.Drawing.Point(194, 244);
            this.txtStopTime.Name = "txtStopTime";
            this.txtStopTime.Size = new System.Drawing.Size(207, 20);
            this.txtStopTime.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Stop time (milliseconds):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnWriteJSONFile
            // 
            this.btnWriteJSONFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteJSONFile.Location = new System.Drawing.Point(421, 81);
            this.btnWriteJSONFile.Name = "btnWriteJSONFile";
            this.btnWriteJSONFile.Size = new System.Drawing.Size(162, 45);
            this.btnWriteJSONFile.TabIndex = 14;
            this.btnWriteJSONFile.Text = "Write JSON File";
            this.btnWriteJSONFile.UseVisualStyleBackColor = true;
            this.btnWriteJSONFile.Click += new System.EventHandler(this.btnWriteJSONFile_Click);
            // 
            // btnReadJSONFile
            // 
            this.btnReadJSONFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadJSONFile.Location = new System.Drawing.Point(421, 30);
            this.btnReadJSONFile.Name = "btnReadJSONFile";
            this.btnReadJSONFile.Size = new System.Drawing.Size(162, 45);
            this.btnReadJSONFile.TabIndex = 16;
            this.btnReadJSONFile.Text = "Read JSON File";
            this.btnReadJSONFile.UseVisualStyleBackColor = true;
            this.btnReadJSONFile.Click += new System.EventHandler(this.btnReadJSONFile_Click);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(421, 140);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(237, 158);
            this.lblError.TabIndex = 87;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(194, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(207, 20);
            this.txtDescription.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "Timer Description:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(687, 307);
            this.ControlBox = false;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnReadJSONFile);
            this.Controls.Add(this.btnWriteJSONFile);
            this.Controls.Add(this.txtStopTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFinalTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCloseTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBodyTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimerID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimer";
            this.Text = "Timer Specifications";
            this.Load += new System.EventHandler(this.frmTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimerID;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBodyTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCloseTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFinalTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStopTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWriteJSONFile;
        private System.Windows.Forms.Button btnReadJSONFile;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
    }
}