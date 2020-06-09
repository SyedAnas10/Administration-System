namespace LibraryManagementSystem
{
    partial class ChangePassword
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_PhoneNo = new System.Windows.Forms.Label();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.txtBox_PhoneNo = new System.Windows.Forms.TextBox();
            this.txtBox_NewPass = new System.Windows.Forms.TextBox();
            this.btn_UpdatePass = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(28, 17);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(77, 19);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_PhoneNo
            // 
            this.lbl_PhoneNo.AutoSize = true;
            this.lbl_PhoneNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneNo.Location = new System.Drawing.Point(28, 46);
            this.lbl_PhoneNo.Name = "lbl_PhoneNo";
            this.lbl_PhoneNo.Size = new System.Drawing.Size(77, 19);
            this.lbl_PhoneNo.TabIndex = 0;
            this.lbl_PhoneNo.Text = "Phone No";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPassword.Location = new System.Drawing.Point(28, 76);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(109, 19);
            this.lbl_newPassword.TabIndex = 0;
            this.lbl_newPassword.Text = "New Password";
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(149, 18);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(132, 20);
            this.txtBox_Username.TabIndex = 1;
            // 
            // txtBox_PhoneNo
            // 
            this.txtBox_PhoneNo.Location = new System.Drawing.Point(149, 45);
            this.txtBox_PhoneNo.Name = "txtBox_PhoneNo";
            this.txtBox_PhoneNo.Size = new System.Drawing.Size(132, 20);
            this.txtBox_PhoneNo.TabIndex = 2;
            // 
            // txtBox_NewPass
            // 
            this.txtBox_NewPass.Location = new System.Drawing.Point(149, 74);
            this.txtBox_NewPass.Name = "txtBox_NewPass";
            this.txtBox_NewPass.PasswordChar = '*';
            this.txtBox_NewPass.Size = new System.Drawing.Size(132, 20);
            this.txtBox_NewPass.TabIndex = 3;
            // 
            // btn_UpdatePass
            // 
            this.btn_UpdatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdatePass.Location = new System.Drawing.Point(32, 113);
            this.btn_UpdatePass.Name = "btn_UpdatePass";
            this.btn_UpdatePass.Size = new System.Drawing.Size(119, 23);
            this.btn_UpdatePass.TabIndex = 4;
            this.btn_UpdatePass.Text = "Update";
            this.btn_UpdatePass.UseVisualStyleBackColor = true;
            this.btn_UpdatePass.Click += new System.EventHandler(this.btn_UpdatePass_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(162, 113);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(119, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 159);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_UpdatePass);
            this.Controls.Add(this.txtBox_NewPass);
            this.Controls.Add(this.txtBox_PhoneNo);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.lbl_newPassword);
            this.Controls.Add(this.lbl_PhoneNo);
            this.Controls.Add(this.lbl_Username);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_PhoneNo;
        private System.Windows.Forms.Label lbl_newPassword;
        public System.Windows.Forms.TextBox txtBox_Username;
        public System.Windows.Forms.TextBox txtBox_PhoneNo;
        public System.Windows.Forms.TextBox txtBox_NewPass;
        private System.Windows.Forms.Button btn_UpdatePass;
        private System.Windows.Forms.Button btn_Cancel;
    }
}