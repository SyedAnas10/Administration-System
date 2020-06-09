namespace Administration
{
    partial class Societies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Societies));
            this.gridtable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblCoHead = new System.Windows.Forms.Label();
            this.lblPresident = new System.Windows.Forms.Label();
            this.lblVice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.txtCo = new System.Windows.Forms.TextBox();
            this.txtPresident = new System.Windows.Forms.TextBox();
            this.txtVp = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridtable)).BeginInit();
            this.SuspendLayout();
            // 
            // gridtable
            // 
            this.gridtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtable.Location = new System.Drawing.Point(12, 59);
            this.gridtable.Name = "gridtable";
            this.gridtable.RowTemplate.Height = 24;
            this.gridtable.Size = new System.Drawing.Size(397, 278);
            this.gridtable.TabIndex = 0;
            this.gridtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridtable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Societies List";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(479, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name :";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(425, 105);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(113, 17);
            this.lblHead.TabIndex = 3;
            this.lblHead.Text = "Faculty Head :";
            // 
            // lblCoHead
            // 
            this.lblCoHead.AutoSize = true;
            this.lblCoHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoHead.Location = new System.Drawing.Point(457, 147);
            this.lblCoHead.Name = "lblCoHead";
            this.lblCoHead.Size = new System.Drawing.Size(81, 17);
            this.lblCoHead.TabIndex = 4;
            this.lblCoHead.Text = "Co-Head :";
            // 
            // lblPresident
            // 
            this.lblPresident.AutoSize = true;
            this.lblPresident.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresident.Location = new System.Drawing.Point(451, 187);
            this.lblPresident.Name = "lblPresident";
            this.lblPresident.Size = new System.Drawing.Size(87, 17);
            this.lblPresident.TabIndex = 5;
            this.lblPresident.Text = "President :";
            // 
            // lblVice
            // 
            this.lblVice.AutoSize = true;
            this.lblVice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVice.Location = new System.Drawing.Point(415, 237);
            this.lblVice.Name = "lblVice";
            this.lblVice.Size = new System.Drawing.Size(123, 17);
            this.lblVice.TabIndex = 5;
            this.lblVice.Text = "Vice President :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(544, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtHead
            // 
            this.txtHead.Location = new System.Drawing.Point(544, 102);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(217, 22);
            this.txtHead.TabIndex = 6;
            // 
            // txtCo
            // 
            this.txtCo.Location = new System.Drawing.Point(544, 144);
            this.txtCo.Name = "txtCo";
            this.txtCo.Size = new System.Drawing.Size(217, 22);
            this.txtCo.TabIndex = 6;
            this.txtCo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPresident
            // 
            this.txtPresident.Location = new System.Drawing.Point(544, 184);
            this.txtPresident.Name = "txtPresident";
            this.txtPresident.Size = new System.Drawing.Size(217, 22);
            this.txtPresident.TabIndex = 6;
            this.txtPresident.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtVp
            // 
            this.txtVp.Location = new System.Drawing.Point(544, 234);
            this.txtVp.Name = "txtVp";
            this.txtVp.Size = new System.Drawing.Size(217, 22);
            this.txtVp.TabIndex = 6;
            this.txtVp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(507, 275);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 61);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit Data";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(649, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 61);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(457, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(650, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Events List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Societies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtVp);
            this.Controls.Add(this.txtPresident);
            this.Controls.Add(this.txtCo);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblVice);
            this.Controls.Add(this.lblPresident);
            this.Controls.Add(this.lblCoHead);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridtable);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Societies";
            this.Text = "Societies";
            this.Load += new System.EventHandler(this.Societies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblCoHead;
        private System.Windows.Forms.Label lblPresident;
        private System.Windows.Forms.Label lblVice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.TextBox txtCo;
        private System.Windows.Forms.TextBox txtPresident;
        private System.Windows.Forms.TextBox txtVp;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}