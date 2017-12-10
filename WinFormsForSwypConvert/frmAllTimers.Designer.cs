namespace WinFormsForSwypConvert
{
    partial class frmAllTimers
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
            this.btnReadJSONFile = new System.Windows.Forms.Button();
            this.btnWriteJSONFile = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTimerSetID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTimerList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtTimerName = new System.Windows.Forms.TextBox();
            this.btnRemoveTimer = new System.Windows.Forms.Button();
            this.btnAddTimer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewTimer = new System.Windows.Forms.Button();
            this.txtRelease = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAlwaysShowElapsedTime = new System.Windows.Forms.CheckBox();
            this.cbShowDiagonalOnPause = new System.Windows.Forms.CheckBox();
            this.cbSoundBellWhenOverGracePeriod = new System.Windows.Forms.CheckBox();
            this.cbFlashAtColorChange = new System.Windows.Forms.CheckBox();
            this.txtLastTimerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVibrateAtColorChange = new System.Windows.Forms.CheckBox();
            this.txtVibrateIncrementMills = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInitialTimerID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBaseDir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadJSONFile
            // 
            this.btnReadJSONFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadJSONFile.Location = new System.Drawing.Point(386, 42);
            this.btnReadJSONFile.Name = "btnReadJSONFile";
            this.btnReadJSONFile.Size = new System.Drawing.Size(162, 45);
            this.btnReadJSONFile.TabIndex = 1;
            this.btnReadJSONFile.Text = "Read JSON File";
            this.btnReadJSONFile.UseVisualStyleBackColor = true;
            this.btnReadJSONFile.Click += new System.EventHandler(this.btnReadJSONFile_Click);
            // 
            // btnWriteJSONFile
            // 
            this.btnWriteJSONFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteJSONFile.Location = new System.Drawing.Point(567, 42);
            this.btnWriteJSONFile.Name = "btnWriteJSONFile";
            this.btnWriteJSONFile.Size = new System.Drawing.Size(162, 45);
            this.btnWriteJSONFile.TabIndex = 68;
            this.btnWriteJSONFile.Text = "Write JSON File";
            this.btnWriteJSONFile.UseVisualStyleBackColor = true;
            this.btnWriteJSONFile.Click += new System.EventHandler(this.btnWriteJSONFile_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(158, 67);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtTimerSetID
            // 
            this.txtTimerSetID.Location = new System.Drawing.Point(158, 42);
            this.txtTimerSetID.Name = "txtTimerSetID";
            this.txtTimerSetID.Size = new System.Drawing.Size(200, 20);
            this.txtTimerSetID.TabIndex = 2;
            this.txtTimerSetID.Text = "ToastMasters";
            this.txtTimerSetID.TextChanged += new System.EventHandler(this.txtTimerSetName_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 74;
            this.label3.Text = "Timer Set Description:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(39, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Default Timer Set:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 85;
            this.label4.Text = "Included Timers";
            // 
            // lbTimerList
            // 
            this.lbTimerList.FormattingEnabled = true;
            this.lbTimerList.Location = new System.Drawing.Point(565, 267);
            this.lbTimerList.Name = "lbTimerList";
            this.lbTimerList.Size = new System.Drawing.Size(164, 147);
            this.lbTimerList.TabIndex = 84;
            this.lbTimerList.SelectedIndexChanged += new System.EventHandler(this.lbTimerList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 83;
            this.label1.Text = "Build Default Timer Set";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(386, 107);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(343, 118);
            this.lblError.TabIndex = 86;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimerName
            // 
            this.txtTimerName.Location = new System.Drawing.Point(39, 359);
            this.txtTimerName.Name = "txtTimerName";
            this.txtTimerName.Size = new System.Drawing.Size(164, 20);
            this.txtTimerName.TabIndex = 14;
            // 
            // btnRemoveTimer
            // 
            this.btnRemoveTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTimer.Location = new System.Drawing.Point(39, 386);
            this.btnRemoveTimer.Name = "btnRemoveTimer";
            this.btnRemoveTimer.Size = new System.Drawing.Size(122, 45);
            this.btnRemoveTimer.TabIndex = 89;
            this.btnRemoveTimer.Text = "Remove Timer";
            this.btnRemoveTimer.UseVisualStyleBackColor = true;
            this.btnRemoveTimer.Click += new System.EventHandler(this.btnRemoveTimer_Click);
            // 
            // btnAddTimer
            // 
            this.btnAddTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimer.Location = new System.Drawing.Point(167, 386);
            this.btnAddTimer.Name = "btnAddTimer";
            this.btnAddTimer.Size = new System.Drawing.Size(122, 45);
            this.btnAddTimer.TabIndex = 88;
            this.btnAddTimer.Text = "Add Timer";
            this.btnAddTimer.UseVisualStyleBackColor = true;
            this.btnAddTimer.Click += new System.EventHandler(this.btnAddTimer_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 91;
            this.label6.Text = "Timer Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNewTimer
            // 
            this.btnNewTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTimer.Location = new System.Drawing.Point(295, 386);
            this.btnNewTimer.Name = "btnNewTimer";
            this.btnNewTimer.Size = new System.Drawing.Size(122, 45);
            this.btnNewTimer.TabIndex = 92;
            this.btnNewTimer.Text = "New Timer";
            this.btnNewTimer.UseVisualStyleBackColor = true;
            this.btnNewTimer.Click += new System.EventHandler(this.btnNewTimer_Click);
            // 
            // txtRelease
            // 
            this.txtRelease.Location = new System.Drawing.Point(158, 93);
            this.txtRelease.Name = "txtRelease";
            this.txtRelease.Size = new System.Drawing.Size(200, 20);
            this.txtRelease.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(52, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 94;
            this.label5.Text = "Release:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Location = new System.Drawing.Point(158, 119);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(200, 20);
            this.txtGracePeriod.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(35, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 15);
            this.label7.TabIndex = 96;
            this.label7.Text = "Grace Period (Mills):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbAlwaysShowElapsedTime
            // 
            this.cbAlwaysShowElapsedTime.AutoSize = true;
            this.cbAlwaysShowElapsedTime.Location = new System.Drawing.Point(158, 173);
            this.cbAlwaysShowElapsedTime.Name = "cbAlwaysShowElapsedTime";
            this.cbAlwaysShowElapsedTime.Size = new System.Drawing.Size(156, 17);
            this.cbAlwaysShowElapsedTime.TabIndex = 7;
            this.cbAlwaysShowElapsedTime.Text = "Always Show Elapsed Time";
            this.cbAlwaysShowElapsedTime.UseVisualStyleBackColor = true;
            // 
            // cbShowDiagonalOnPause
            // 
            this.cbShowDiagonalOnPause.AutoSize = true;
            this.cbShowDiagonalOnPause.Location = new System.Drawing.Point(158, 196);
            this.cbShowDiagonalOnPause.Name = "cbShowDiagonalOnPause";
            this.cbShowDiagonalOnPause.Size = new System.Drawing.Size(148, 17);
            this.cbShowDiagonalOnPause.TabIndex = 8;
            this.cbShowDiagonalOnPause.Text = "Show Diagonal On Pause";
            this.cbShowDiagonalOnPause.UseVisualStyleBackColor = true;
            // 
            // cbSoundBellWhenOverGracePeriod
            // 
            this.cbSoundBellWhenOverGracePeriod.AutoSize = true;
            this.cbSoundBellWhenOverGracePeriod.Location = new System.Drawing.Point(158, 219);
            this.cbSoundBellWhenOverGracePeriod.Name = "cbSoundBellWhenOverGracePeriod";
            this.cbSoundBellWhenOverGracePeriod.Size = new System.Drawing.Size(200, 17);
            this.cbSoundBellWhenOverGracePeriod.TabIndex = 9;
            this.cbSoundBellWhenOverGracePeriod.Text = "Sound Bell When Over Grace Period";
            this.cbSoundBellWhenOverGracePeriod.UseVisualStyleBackColor = true;
            // 
            // cbFlashAtColorChange
            // 
            this.cbFlashAtColorChange.AutoSize = true;
            this.cbFlashAtColorChange.Location = new System.Drawing.Point(158, 242);
            this.cbFlashAtColorChange.Name = "cbFlashAtColorChange";
            this.cbFlashAtColorChange.Size = new System.Drawing.Size(131, 17);
            this.cbFlashAtColorChange.TabIndex = 10;
            this.cbFlashAtColorChange.Text = "Flash At Color Change";
            this.cbFlashAtColorChange.UseVisualStyleBackColor = true;
            // 
            // txtLastTimerID
            // 
            this.txtLastTimerID.Location = new System.Drawing.Point(158, 288);
            this.txtLastTimerID.Name = "txtLastTimerID";
            this.txtLastTimerID.Size = new System.Drawing.Size(200, 20);
            this.txtLastTimerID.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(35, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 98;
            this.label8.Text = "Default Timer ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbVibrateAtColorChange
            // 
            this.cbVibrateAtColorChange.AutoSize = true;
            this.cbVibrateAtColorChange.Location = new System.Drawing.Point(158, 265);
            this.cbVibrateAtColorChange.Name = "cbVibrateAtColorChange";
            this.cbVibrateAtColorChange.Size = new System.Drawing.Size(139, 17);
            this.cbVibrateAtColorChange.TabIndex = 11;
            this.cbVibrateAtColorChange.Text = "Vibrate At Color Change";
            this.cbVibrateAtColorChange.UseVisualStyleBackColor = true;
            // 
            // txtVibrateIncrementMills
            // 
            this.txtVibrateIncrementMills.Location = new System.Drawing.Point(158, 145);
            this.txtVibrateIncrementMills.Name = "txtVibrateIncrementMills";
            this.txtVibrateIncrementMills.Size = new System.Drawing.Size(200, 20);
            this.txtVibrateIncrementMills.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 15);
            this.label9.TabIndex = 101;
            this.label9.Text = "Vibrate Increment (Mills):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInitialTimerID
            // 
            this.txtInitialTimerID.Location = new System.Drawing.Point(158, 314);
            this.txtInitialTimerID.Name = "txtInitialTimerID";
            this.txtInitialTimerID.Size = new System.Drawing.Size(200, 20);
            this.txtInitialTimerID.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(35, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 15);
            this.label10.TabIndex = 103;
            this.label10.Text = "Initial Timer ID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBaseDir
            // 
            this.lblBaseDir.AutoSize = true;
            this.lblBaseDir.Location = new System.Drawing.Point(388, 11);
            this.lblBaseDir.Name = "lblBaseDir";
            this.lblBaseDir.Size = new System.Drawing.Size(54, 13);
            this.lblBaseDir.TabIndex = 104;
            this.lblBaseDir.Text = "lblBaseDir";
            // 
            // frmAllTimers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(764, 443);
            this.ControlBox = false;
            this.Controls.Add(this.lblBaseDir);
            this.Controls.Add(this.txtInitialTimerID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVibrateIncrementMills);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbVibrateAtColorChange);
            this.Controls.Add(this.txtLastTimerID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbFlashAtColorChange);
            this.Controls.Add(this.cbSoundBellWhenOverGracePeriod);
            this.Controls.Add(this.cbShowDiagonalOnPause);
            this.Controls.Add(this.cbAlwaysShowElapsedTime);
            this.Controls.Add(this.txtGracePeriod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRelease);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNewTimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimerName);
            this.Controls.Add(this.btnRemoveTimer);
            this.Controls.Add(this.btnAddTimer);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTimerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTimerSetID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReadJSONFile);
            this.Controls.Add(this.btnWriteJSONFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllTimers";
            this.Text = "All Specified Timers";
            this.Load += new System.EventHandler(this.frmAllTimers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadJSONFile;
        private System.Windows.Forms.Button btnWriteJSONFile;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTimerSetID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbTimerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtTimerName;
        private System.Windows.Forms.Button btnRemoveTimer;
        private System.Windows.Forms.Button btnAddTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewTimer;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbAlwaysShowElapsedTime;
        private System.Windows.Forms.CheckBox cbShowDiagonalOnPause;
        private System.Windows.Forms.CheckBox cbSoundBellWhenOverGracePeriod;
        private System.Windows.Forms.CheckBox cbFlashAtColorChange;
        private System.Windows.Forms.TextBox txtLastTimerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbVibrateAtColorChange;
        private System.Windows.Forms.TextBox txtVibrateIncrementMills;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInitialTimerID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBaseDir;
    }
}