namespace RECOMANAGESYS
{
    partial class ResidencyRegisterfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidencyRegisterfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.residentlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contactnumtxt = new System.Windows.Forms.TextBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Residentbtn = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.MiddleNametxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emergencyPersontxt = new System.Windows.Forms.TextBox();
            this.ResidentIDtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.emergencyNumtxt = new System.Windows.Forms.TextBox();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.cmbUnitNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.btnUploadProof = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(131, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstNametxt.Location = new System.Drawing.Point(136, 164);
            this.FirstNametxt.Multiline = true;
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(359, 38);
            this.FirstNametxt.TabIndex = 8;
            this.FirstNametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // residentlbl
            // 
            this.residentlbl.AutoSize = true;
            this.residentlbl.BackColor = System.Drawing.Color.Transparent;
            this.residentlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.residentlbl.Location = new System.Drawing.Point(133, 418);
            this.residentlbl.Name = "residentlbl";
            this.residentlbl.Size = new System.Drawing.Size(135, 27);
            this.residentlbl.TabIndex = 11;
            this.residentlbl.Text = "Resident ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(562, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contact Number:";
            // 
            // contactnumtxt
            // 
            this.contactnumtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactnumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contactnumtxt.Location = new System.Drawing.Point(567, 310);
            this.contactnumtxt.Multiline = true;
            this.contactnumtxt.Name = "contactnumtxt";
            this.contactnumtxt.Size = new System.Drawing.Size(359, 38);
            this.contactnumtxt.TabIndex = 16;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.Cancelbtn.FlatAppearance.BorderSize = 0;
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.Black;
            this.Cancelbtn.Location = new System.Drawing.Point(732, 598);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(120, 44);
            this.Cancelbtn.TabIndex = 18;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.cancelvisitor_Click);
            // 
            // Residentbtn
            // 
            this.Residentbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Residentbtn.FlatAppearance.BorderSize = 0;
            this.Residentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Residentbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.Residentbtn.ForeColor = System.Drawing.Color.White;
            this.Residentbtn.Location = new System.Drawing.Point(862, 598);
            this.Residentbtn.Name = "Residentbtn";
            this.Residentbtn.Size = new System.Drawing.Size(120, 44);
            this.Residentbtn.TabIndex = 19;
            this.Residentbtn.Text = "Save";
            this.Residentbtn.UseVisualStyleBackColor = false;
            this.Residentbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // cmbType
            // 
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(138, 380);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(359, 33);
            this.cmbType.TabIndex = 29;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            // 
            // MiddleNametxt
            // 
            this.MiddleNametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MiddleNametxt.Location = new System.Drawing.Point(136, 310);
            this.MiddleNametxt.Multiline = true;
            this.MiddleNametxt.Name = "MiddleNametxt";
            this.MiddleNametxt.Size = new System.Drawing.Size(359, 38);
            this.MiddleNametxt.TabIndex = 31;
            this.MiddleNametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lastNametxt
            // 
            this.lastNametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lastNametxt.Location = new System.Drawing.Point(136, 237);
            this.lastNametxt.Multiline = true;
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(359, 38);
            this.lastNametxt.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(131, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Middle Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(131, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 27);
            this.label7.TabIndex = 34;
            this.label7.Text = "Last Name:";
            // 
            // Emailtxt
            // 
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Emailtxt.Location = new System.Drawing.Point(567, 383);
            this.Emailtxt.Multiline = true;
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(359, 38);
            this.Emailtxt.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(562, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 27);
            this.label8.TabIndex = 36;
            this.label8.Text = "Email:";
            // 
            // emergencyPersontxt
            // 
            this.emergencyPersontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emergencyPersontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emergencyPersontxt.Location = new System.Drawing.Point(567, 164);
            this.emergencyPersontxt.Multiline = true;
            this.emergencyPersontxt.Name = "emergencyPersontxt";
            this.emergencyPersontxt.Size = new System.Drawing.Size(359, 38);
            this.emergencyPersontxt.TabIndex = 37;
            // 
            // ResidentIDtxt
            // 
            this.ResidentIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResidentIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResidentIDtxt.Location = new System.Drawing.Point(138, 446);
            this.ResidentIDtxt.Multiline = true;
            this.ResidentIDtxt.Name = "ResidentIDtxt";
            this.ResidentIDtxt.Size = new System.Drawing.Size(359, 25);
            this.ResidentIDtxt.TabIndex = 39;
            this.ResidentIDtxt.TextChanged += new System.EventHandler(this.ResidentIDtxt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(133, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 27);
            this.label11.TabIndex = 41;
            this.label11.Text = "Residency Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(562, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(283, 27);
            this.label13.TabIndex = 42;
            this.label13.Text = "Emergency contact person:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(562, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(293, 27);
            this.label14.TabIndex = 43;
            this.label14.Text = "Emergency contact number:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // emergencyNumtxt
            // 
            this.emergencyNumtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emergencyNumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emergencyNumtxt.Location = new System.Drawing.Point(567, 237);
            this.emergencyNumtxt.Multiline = true;
            this.emergencyNumtxt.Name = "emergencyNumtxt";
            this.emergencyNumtxt.Size = new System.Drawing.Size(359, 38);
            this.emergencyNumtxt.TabIndex = 44;
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clearbtn.FlatAppearance.BorderSize = 0;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.Clearbtn.Location = new System.Drawing.Point(601, 598);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(120, 44);
            this.Clearbtn.TabIndex = 46;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // cmbUnitNum
            // 
            this.cmbUnitNum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbUnitNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitNum.FormattingEnabled = true;
            this.cmbUnitNum.Location = new System.Drawing.Point(252, 483);
            this.cmbUnitNum.Name = "cmbUnitNum";
            this.cmbUnitNum.Size = new System.Drawing.Size(110, 33);
            this.cmbUnitNum.TabIndex = 47;
            this.cmbUnitNum.SelectedIndexChanged += new System.EventHandler(this.cmbUnitNum_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Unit Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Block";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbBlock
            // 
            this.cmbBlock.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(431, 483);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(75, 33);
            this.cmbBlock.TabIndex = 49;
            this.cmbBlock.SelectedIndexChanged += new System.EventHandler(this.cmbBlock_SelectedIndexChanged);
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.BackColor = System.Drawing.Color.Transparent;
            this.lblValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidation.Location = new System.Drawing.Point(135, 512);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(26, 18);
            this.lblValidation.TabIndex = 51;
            this.lblValidation.Text = "⚠️";
            this.lblValidation.Click += new System.EventHandler(this.lblValidation_Click);
            // 
            // btnUploadProof
            // 
            this.btnUploadProof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadProof.Location = new System.Drawing.Point(180, 598);
            this.btnUploadProof.Name = "btnUploadProof";
            this.btnUploadProof.Size = new System.Drawing.Size(226, 25);
            this.btnUploadProof.TabIndex = 52;
            this.btnUploadProof.Text = "Upload Proof Of Residency";
            this.btnUploadProof.UseVisualStyleBackColor = true;
            this.btnUploadProof.Click += new System.EventHandler(this.btnUploadProof_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.Transparent;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(161, 626);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(276, 25);
            this.lblFileName.TabIndex = 53;
            this.lblFileName.Text = "No File Selected:";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFileName.Click += new System.EventHandler(this.lblFileName_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(135, 542);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(58, 16);
            this.lblAdd.TabIndex = 54;
            this.lblAdd.Text = "Address";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // ResidencyRegisterfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 715);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnUploadProof);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUnitNum);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.emergencyNumtxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ResidentIDtxt);
            this.Controls.Add(this.emergencyPersontxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.MiddleNametxt);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.Residentbtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.contactnumtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.residentlbl);
            this.Controls.Add(this.FirstNametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValidation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResidencyRegisterfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNametxt;
        private System.Windows.Forms.Label residentlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactnumtxt;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Residentbtn;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox MiddleNametxt;
        private System.Windows.Forms.TextBox lastNametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emergencyPersontxt;
        private System.Windows.Forms.TextBox ResidentIDtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox emergencyNumtxt;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.ComboBox cmbUnitNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Button btnUploadProof;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblAdd;
    }
}