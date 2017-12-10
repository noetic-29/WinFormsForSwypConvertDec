namespace WinFormsForSwypConvert
{
    partial class frmTestKonversion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConvertLeftToRight = new System.Windows.Forms.Button();
            this.btnRightToLeft = new System.Windows.Forms.Button();
            this.lbGroup = new System.Windows.Forms.ListBox();
            this.lbLeftUnit = new System.Windows.Forms.ListBox();
            this.lbRightUnit = new System.Windows.Forms.ListBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Conversion Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Left Unit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Right Unit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConvertLeftToRight
            // 
            this.btnConvertLeftToRight.Location = new System.Drawing.Point(249, 138);
            this.btnConvertLeftToRight.Name = "btnConvertLeftToRight";
            this.btnConvertLeftToRight.Size = new System.Drawing.Size(116, 37);
            this.btnConvertLeftToRight.TabIndex = 5;
            this.btnConvertLeftToRight.Text = "Left to Right";
            this.btnConvertLeftToRight.UseVisualStyleBackColor = true;
            this.btnConvertLeftToRight.Click += new System.EventHandler(this.btnConvertLeftToRight_Click);
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.Location = new System.Drawing.Point(435, 138);
            this.btnRightToLeft.Name = "btnRightToLeft";
            this.btnRightToLeft.Size = new System.Drawing.Size(116, 37);
            this.btnRightToLeft.TabIndex = 6;
            this.btnRightToLeft.Text = "Rigbt to Left";
            this.btnRightToLeft.UseVisualStyleBackColor = true;
            this.btnRightToLeft.Click += new System.EventHandler(this.btnRightToLeft_Click);
            // 
            // lbGroup
            // 
            this.lbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroup.FormattingEnabled = true;
            this.lbGroup.ItemHeight = 20;
            this.lbGroup.Location = new System.Drawing.Point(491, 20);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(189, 24);
            this.lbGroup.TabIndex = 1;
            this.lbGroup.SelectedIndexChanged += new System.EventHandler(this.lbGroup_SelectedIndexChanged);
            // 
            // lbLeftUnit
            // 
            this.lbLeftUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeftUnit.FormattingEnabled = true;
            this.lbLeftUnit.ItemHeight = 20;
            this.lbLeftUnit.Location = new System.Drawing.Point(249, 64);
            this.lbLeftUnit.Name = "lbLeftUnit";
            this.lbLeftUnit.Size = new System.Drawing.Size(189, 24);
            this.lbLeftUnit.TabIndex = 2;
            // 
            // lbRightUnit
            // 
            this.lbRightUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRightUnit.FormattingEnabled = true;
            this.lbRightUnit.ItemHeight = 20;
            this.lbRightUnit.Location = new System.Drawing.Point(675, 64);
            this.lbRightUnit.Name = "lbRightUnit";
            this.lbRightUnit.Size = new System.Drawing.Size(189, 24);
            this.lbRightUnit.TabIndex = 3;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(249, 106);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(189, 26);
            this.txtNum.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(245, 193);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(602, 25);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTestKonversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 240);
            this.ControlBox = false;
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lbRightUnit);
            this.Controls.Add(this.lbLeftUnit);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.btnRightToLeft);
            this.Controls.Add(this.btnConvertLeftToRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTestKonversion";
            this.Text = "Perform Test Konversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConvertLeftToRight;
        private System.Windows.Forms.Button btnRightToLeft;
        private System.Windows.Forms.ListBox lbGroup;
        private System.Windows.Forms.ListBox lbLeftUnit;
        private System.Windows.Forms.ListBox lbRightUnit;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblResult;
    }
}