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
            this.ProductNameControl = new System.Windows.Forms.Label();
            this.RankContainer = new System.Windows.Forms.Panel();
            this.Rank = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PriceContainer = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Price = new System.Windows.Forms.Label();
            this.Favorite = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
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
            // ProductNameControl
            // 
            this.ProductNameControl.AutoSize = true;
            this.ProductNameControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ProductNameControl.Location = new System.Drawing.Point(2, 143);
            this.ProductNameControl.Name = "ProductNameControl";
            this.ProductNameControl.Size = new System.Drawing.Size(121, 23);
            this.ProductNameControl.TabIndex = 1;
            this.ProductNameControl.Text = "Product Name";
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
            // Favorite
            // 
            this.Favorite.BackColor = System.Drawing.SystemColors.Control;
            this.Favorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Favorite.BackgroundImage")));
            this.Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Favorite.FlatAppearance.BorderSize = 0;
            this.Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Favorite.Location = new System.Drawing.Point(178, 141);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(31, 25);
            this.Favorite.TabIndex = 4;
            this.Favorite.UseVisualStyleBackColor = false;
            this.Favorite.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(8, 225);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(162, 40);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.Location = new System.Drawing.Point(174, 228);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(35, 39);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.PriceContainer);
            this.Controls.Add(this.RankContainer);
            this.Controls.Add(this.ProductNameControl);
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
        private System.Windows.Forms.Label ProductNameControl;
        private System.Windows.Forms.Panel RankContainer;
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PriceContainer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button Favorite;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAddToCart;
    }
}
