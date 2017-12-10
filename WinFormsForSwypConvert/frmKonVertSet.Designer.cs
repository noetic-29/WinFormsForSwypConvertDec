namespace WinFormsForSwypConvert
{
    partial class frmKonVertSet
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
            this.label25 = new System.Windows.Forms.Label();
            this.lblBaseDir = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnReadJSONFile = new System.Windows.Forms.Button();
            this.btnWriteJSONFile = new System.Windows.Forms.Button();
            this.txtRelease = new System.Windows.Forms.TextBox();
            this.txtSwypConvertName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGroupList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.lbPrevKonversions = new System.Windows.Forms.ListBox();
            this.lbGroupKonversions = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReadUserParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(338, 24);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(217, 15);
            this.label25.TabIndex = 80;
            this.label25.Text = "Set File names are <SwypConvert Name>";
            // 
            // lblBaseDir
            // 
            this.lblBaseDir.Location = new System.Drawing.Point(338, 9);
            this.lblBaseDir.Name = "lblBaseDir";
            this.lblBaseDir.Size = new System.Drawing.Size(217, 15);
            this.lblBaseDir.TabIndex = 79;
            this.lblBaseDir.Text = "All Data Files in C:\\SwypConvert\\Data";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(341, 102);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(343, 118);
            this.lblError.TabIndex = 78;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReadJSONFile
            // 
            this.btnReadJSONFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadJSONFile.Location = new System.Drawing.Point(341, 51);
            this.btnReadJSONFile.Name = "btnReadJSONFile";
            this.btnReadJSONFile.Size = new System.Drawing.Size(162, 45);
            this.btnReadJSONFile.TabIndex = 67;
            this.btnReadJSONFile.Text = "Read JSON File";
            this.btnReadJSONFile.UseVisualStyleBackColor = true;
            this.btnReadJSONFile.Click += new System.EventHandler(this.btnReadJSONFile_Click);
            // 
            // btnWriteJSONFile
            // 
            this.btnWriteJSONFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteJSONFile.Location = new System.Drawing.Point(522, 51);
            this.btnWriteJSONFile.Name = "btnWriteJSONFile";
            this.btnWriteJSONFile.Size = new System.Drawing.Size(162, 45);
            this.btnWriteJSONFile.TabIndex = 66;
            this.btnWriteJSONFile.Text = "Write JSON File";
            this.btnWriteJSONFile.UseVisualStyleBackColor = true;
            this.btnWriteJSONFile.Click += new System.EventHandler(this.btnWriteJSONFile_Click);
            // 
            // txtRelease
            // 
            this.txtRelease.Location = new System.Drawing.Point(135, 79);
            this.txtRelease.Name = "txtRelease";
            this.txtRelease.Size = new System.Drawing.Size(200, 20);
            this.txtRelease.TabIndex = 58;
            // 
            // txtSwypConvertName
            // 
            this.txtSwypConvertName.Location = new System.Drawing.Point(135, 54);
            this.txtSwypConvertName.Name = "txtSwypConvertName";
            this.txtSwypConvertName.Size = new System.Drawing.Size(200, 20);
            this.txtSwypConvertName.TabIndex = 57;
            this.txtSwypConvertName.Text = "ZwypConvertTraveler";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 70;
            this.label3.Text = "Release";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 69;
            this.label2.Text = "SwypConvert Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "Build KonVertSet";
            // 
            // lbGroupList
            // 
            this.lbGroupList.FormattingEnabled = true;
            this.lbGroupList.Location = new System.Drawing.Point(32, 137);
            this.lbGroupList.Name = "lbGroupList";
            this.lbGroupList.Size = new System.Drawing.Size(164, 173);
            this.lbGroupList.TabIndex = 81;
            this.lbGroupList.SelectedIndexChanged += new System.EventHandler(this.lbGroupList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 82;
            this.label4.Text = "Included Groups";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.Location = new System.Drawing.Point(32, 408);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(162, 45);
            this.btnAddGroup.TabIndex = 83;
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(32, 331);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(164, 20);
            this.txtGroupName.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(32, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 88;
            this.label6.Text = "Group Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGroup.Location = new System.Drawing.Point(32, 357);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(162, 45);
            this.btnRemoveGroup.TabIndex = 86;
            this.btnRemoveGroup.Text = "Remove Group";
            this.btnRemoveGroup.UseVisualStyleBackColor = true;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // lbPrevKonversions
            // 
            this.lbPrevKonversions.FormattingEnabled = true;
            this.lbPrevKonversions.Location = new System.Drawing.Point(341, 297);
            this.lbPrevKonversions.Name = "lbPrevKonversions";
            this.lbPrevKonversions.Size = new System.Drawing.Size(162, 95);
            this.lbPrevKonversions.TabIndex = 89;
            // 
            // lbGroupKonversions
            // 
            this.lbGroupKonversions.FormattingEnabled = true;
            this.lbGroupKonversions.Location = new System.Drawing.Point(522, 297);
            this.lbGroupKonversions.Name = "lbGroupKonversions";
            this.lbGroupKonversions.Size = new System.Drawing.Size(162, 95);
            this.lbGroupKonversions.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(338, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 91;
            this.label5.Text = "Previous Conversions";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(519, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 15);
            this.label7.TabIndex = 92;
            this.label7.Text = "Group Conversions";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReadUserParams
            // 
            this.btnReadUserParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadUserParams.Location = new System.Drawing.Point(341, 399);
            this.btnReadUserParams.Name = "btnReadUserParams";
            this.btnReadUserParams.Size = new System.Drawing.Size(162, 45);
            this.btnReadUserParams.TabIndex = 93;
            this.btnReadUserParams.Text = "Read User Params";
            this.btnReadUserParams.UseVisualStyleBackColor = true;
            this.btnReadUserParams.Click += new System.EventHandler(this.btnReadUserParams_Click);
            // 
            // frmKonVertSet
            // 
            this.AcceptButton = this.btnReadJSONFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(755, 460);
            this.ControlBox = false;
            this.Controls.Add(this.btnReadUserParams);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbGroupKonversions);
            this.Controls.Add(this.lbPrevKonversions);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemoveGroup);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbGroupList);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lblBaseDir);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnReadJSONFile);
            this.Controls.Add(this.btnWriteJSONFile);
            this.Controls.Add(this.txtRelease);
            this.Controls.Add(this.txtSwypConvertName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKonVertSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Build KonVertSet";
            this.Shown += new System.EventHandler(this.frmKonVertSet_Shown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblBaseDir;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnReadJSONFile;
        private System.Windows.Forms.Button btnWriteJSONFile;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.TextBox txtSwypConvertName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbGroupList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.ListBox lbPrevKonversions;
        private System.Windows.Forms.ListBox lbGroupKonversions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReadUserParams;
    }
}