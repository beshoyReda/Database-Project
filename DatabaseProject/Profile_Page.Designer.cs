namespace DatabaseProject
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProfileContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.ProfileContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileContainer
            // 
            this.ProfileContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.ProfileContainer.Controls.Add(this.panel3);
            this.ProfileContainer.Controls.Add(this.panel1);
            this.ProfileContainer.Location = new System.Drawing.Point(15, 17);
            this.ProfileContainer.Name = "ProfileContainer";
            this.ProfileContainer.Size = new System.Drawing.Size(1096, 685);
            this.ProfileContainer.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.panel3.Controls.Add(this.Addresslbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(15, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 385);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BalanceLabel);
            this.panel1.Controls.Add(this.usernamelbl);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.Namelbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 227);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(351, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "200";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BalanceLabel.Location = new System.Drawing.Point(242, 163);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(103, 31);
            this.BalanceLabel.TabIndex = 4;
            this.BalanceLabel.Text = "Balance:";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.usernamelbl.Location = new System.Drawing.Point(242, 92);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(277, 31);
            this.usernamelbl.TabIndex = 3;
            this.usernamelbl.Text = "Email: email@email.com";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.SystemColors.Control;
            this.Age.Location = new System.Drawing.Point(449, 19);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(70, 28);
            this.Age.TabIndex = 2;
            this.Age.Text = "22 yrs";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Namelbl.Location = new System.Drawing.Point(241, 19);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(147, 38);
            this.Namelbl.TabIndex = 1;
            this.Namelbl.Text = "Joe Smith";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 210);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Addresslbl.Location = new System.Drawing.Point(14, 68);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(70, 28);
            this.Addresslbl.TabIndex = 3;
            this.Addresslbl.Text = "22 yrs";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.ProfileContainer);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1126, 715);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ProfileContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProfileContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label label2;
    }
}