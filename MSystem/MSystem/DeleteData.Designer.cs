namespace MSystem
{
    partial class DeleteData
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_RollNum
            // 
            this.lbl_RollNum.AutoSize = true;
            this.lbl_RollNum.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RollNum.Location = new System.Drawing.Point(45, 25);
            this.lbl_RollNum.Name = "lbl_RollNum";
            this.lbl_RollNum.Size = new System.Drawing.Size(68, 23);
            this.lbl_RollNum.TabIndex = 2;
            this.lbl_RollNum.Text = "Roll No";
            // 
            // txtBox_RollNum
            // 
            this.txtBox_RollNum.Location = new System.Drawing.Point(124, 27);
            this.txtBox_RollNum.Name = "txtBox_RollNum";
            this.txtBox_RollNum.Size = new System.Drawing.Size(136, 20);
            this.txtBox_RollNum.TabIndex = 3;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(65, 64);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(166, 64);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // DeleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 113);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_RollNum);
            this.Controls.Add(this.txtBox_RollNum);
            this.Name = "DeleteData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Data";
            this.Load += new System.EventHandler(this.DeleteData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RollNum;
        private System.Windows.Forms.TextBox txtBox_RollNum;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
    }
}