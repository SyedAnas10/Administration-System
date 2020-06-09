namespace MSystem
{
    partial class ReadData
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
            this.lbl_RollNum = new System.Windows.Forms.Label();
            this.txtBox_RollNum = new System.Windows.Forms.TextBox();
            this.txtBox_FirstName = new System.Windows.Forms.TextBox();
            this.txtBox_LastName = new System.Windows.Forms.TextBox();
            this.txtBox_PhoneNo = new System.Windows.Forms.TextBox();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.grpBox_SearchRecords = new System.Windows.Forms.GroupBox();
            this.grpBox_SearchRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_RollNum
            // 
            this.lbl_RollNum.AutoSize = true;
            this.lbl_RollNum.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RollNum.Location = new System.Drawing.Point(25, 44);
            this.lbl_RollNum.Name = "lbl_RollNum";
            this.lbl_RollNum.Size = new System.Drawing.Size(68, 23);
            this.lbl_RollNum.TabIndex = 0;
            this.lbl_RollNum.Text = "Roll No";
            // 
            // txtBox_RollNum
            // 
            this.txtBox_RollNum.Location = new System.Drawing.Point(136, 46);
            this.txtBox_RollNum.Name = "txtBox_RollNum";
            this.txtBox_RollNum.Size = new System.Drawing.Size(136, 20);
            this.txtBox_RollNum.TabIndex = 1;
            // 
            // txtBox_FirstName
            // 
            this.txtBox_FirstName.Location = new System.Drawing.Point(136, 88);
            this.txtBox_FirstName.Name = "txtBox_FirstName";
            this.txtBox_FirstName.Size = new System.Drawing.Size(136, 20);
            this.txtBox_FirstName.TabIndex = 2;
            // 
            // txtBox_LastName
            // 
            this.txtBox_LastName.Location = new System.Drawing.Point(136, 130);
            this.txtBox_LastName.Name = "txtBox_LastName";
            this.txtBox_LastName.Size = new System.Drawing.Size(136, 20);
            this.txtBox_LastName.TabIndex = 3;
            // 
            // txtBox_PhoneNo
            // 
            this.txtBox_PhoneNo.Location = new System.Drawing.Point(136, 173);
            this.txtBox_PhoneNo.Name = "txtBox_PhoneNo";
            this.txtBox_PhoneNo.Size = new System.Drawing.Size(136, 20);
            this.txtBox_PhoneNo.TabIndex = 4;
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(136, 215);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(136, 20);
            this.txtBox_Email.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(53, 256);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(157, 256);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // grpBox_SearchRecords
            // 
            this.grpBox_SearchRecords.Controls.Add(this.btn_Cancel);
            this.grpBox_SearchRecords.Controls.Add(this.label1);
            this.grpBox_SearchRecords.Controls.Add(this.btn_Search);
            this.grpBox_SearchRecords.Controls.Add(this.lbl_RollNum);
            this.grpBox_SearchRecords.Controls.Add(this.txtBox_Email);
            this.grpBox_SearchRecords.Controls.Add(this.label2);
            this.grpBox_SearchRecords.Controls.Add(this.txtBox_PhoneNo);
            this.grpBox_SearchRecords.Controls.Add(this.label3);
            this.grpBox_SearchRecords.Controls.Add(this.txtBox_LastName);
            this.grpBox_SearchRecords.Controls.Add(this.label4);
            this.grpBox_SearchRecords.Controls.Add(this.txtBox_FirstName);
            this.grpBox_SearchRecords.Controls.Add(this.txtBox_RollNum);
            this.grpBox_SearchRecords.Location = new System.Drawing.Point(530, 205);
            this.grpBox_SearchRecords.Name = "grpBox_SearchRecords";
            this.grpBox_SearchRecords.Size = new System.Drawing.Size(297, 299);
            this.grpBox_SearchRecords.TabIndex = 7;
            this.grpBox_SearchRecords.TabStop = false;
            this.grpBox_SearchRecords.Text = "Search Records";
            // 
            // ReadData
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 696);
            this.Controls.Add(this.grpBox_SearchRecords);
            this.Name = "ReadData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadData";
            this.Load += new System.EventHandler(this.ReadData_Load);
            this.grpBox_SearchRecords.ResumeLayout(false);
            this.grpBox_SearchRecords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_RollNum;
        private System.Windows.Forms.TextBox txtBox_RollNum;
        private System.Windows.Forms.TextBox txtBox_FirstName;
        private System.Windows.Forms.TextBox txtBox_LastName;
        private System.Windows.Forms.TextBox txtBox_PhoneNo;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox grpBox_SearchRecords;
    }
}