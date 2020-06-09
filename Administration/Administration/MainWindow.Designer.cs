namespace Administration
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Societies_box = new System.Windows.Forms.PictureBox();
            this.EmployeesBox = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Societies_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Societies_box
            // 
            this.Societies_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Societies_box.Image = ((System.Drawing.Image)(resources.GetObject("Societies_box.Image")));
            this.Societies_box.InitialImage = null;
            this.Societies_box.Location = new System.Drawing.Point(105, 165);
            this.Societies_box.Name = "Societies_box";
            this.Societies_box.Size = new System.Drawing.Size(209, 218);
            this.Societies_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Societies_box.TabIndex = 0;
            this.Societies_box.TabStop = false;
            this.Societies_box.Click += new System.EventHandler(this.Societies_box_Click);
            // 
            // EmployeesBox
            // 
            this.EmployeesBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeesBox.Image = ((System.Drawing.Image)(resources.GetObject("EmployeesBox.Image")));
            this.EmployeesBox.Location = new System.Drawing.Point(333, 165);
            this.EmployeesBox.Name = "EmployeesBox";
            this.EmployeesBox.Size = new System.Drawing.Size(209, 218);
            this.EmployeesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeesBox.TabIndex = 1;
            this.EmployeesBox.TabStop = false;
            this.EmployeesBox.Click += new System.EventHandler(this.EmployeesBox_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(312, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(196, 53);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SOCIETIES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "EMPLOYEES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(548, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 227);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.EmployeesBox);
            this.Controls.Add(this.Societies_box);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.Societies_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Societies_box;
        private System.Windows.Forms.PictureBox EmployeesBox;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}