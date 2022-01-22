namespace DatabaseProject
{
    partial class ProductControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.RankContainer = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Rank = new System.Windows.Forms.Label();
            this.PriceContainer = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RankContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PriceContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ProductName.Location = new System.Drawing.Point(2, 143);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(121, 23);
            this.ProductName.TabIndex = 1;
            this.ProductName.Text = "Product Name";
            // 
            // RankContainer
            // 
            this.RankContainer.Controls.Add(this.Rank);
            this.RankContainer.Controls.Add(this.pictureBox2);
            this.RankContainer.Location = new System.Drawing.Point(3, 177);
            this.RankContainer.Name = "RankContainer";
            this.RankContainer.Size = new System.Drawing.Size(71, 30);
            this.RankContainer.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank.Location = new System.Drawing.Point(30, 4);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(36, 25);
            this.Rank.TabIndex = 1;
            this.Rank.Text = "5.0";
            // 
            // PriceContainer
            // 
            this.PriceContainer.Controls.Add(this.pictureBox3);
            this.PriceContainer.Controls.Add(this.Price);
            this.PriceContainer.Location = new System.Drawing.Point(80, 177);
            this.PriceContainer.Name = "PriceContainer";
            this.PriceContainer.Size = new System.Drawing.Size(105, 32);
            this.PriceContainer.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(3, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 20);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Price.Location = new System.Drawing.Point(20, 3);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(60, 23);
            this.Price.TabIndex = 1;
            this.Price.Text = "10000";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(178, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 25);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(8, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(174, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 39);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceContainer);
            this.Controls.Add(this.RankContainer);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(212, 274);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RankContainer.ResumeLayout(false);
            this.RankContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PriceContainer.ResumeLayout(false);
            this.PriceContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Panel RankContainer;
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PriceContainer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
