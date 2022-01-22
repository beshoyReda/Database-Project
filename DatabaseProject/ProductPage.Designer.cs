namespace DatabaseProject
{
    partial class ProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
            this.ProdContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductNamePage = new System.Windows.Forms.Label();
            this.DiscLabel = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Quantitylbl = new System.Windows.Forms.Label();
            this.Qnumber = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QuantityContainer = new System.Windows.Forms.Panel();
            this.ImageBorder = new System.Windows.Forms.Panel();
            this.AddToCart = new System.Windows.Forms.Button();
            this.Totallbl = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Statelbl = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ProdContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.QuantityContainer.SuspendLayout();
            this.ImageBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdContainer
            // 
            this.ProdContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ProdContainer.Controls.Add(this.pictureBox3);
            this.ProdContainer.Controls.Add(this.pictureBox2);
            this.ProdContainer.Controls.Add(this.State);
            this.ProdContainer.Controls.Add(this.Statelbl);
            this.ProdContainer.Controls.Add(this.TotalAmount);
            this.ProdContainer.Controls.Add(this.Totallbl);
            this.ProdContainer.Controls.Add(this.AddToCart);
            this.ProdContainer.Controls.Add(this.ImageBorder);
            this.ProdContainer.Controls.Add(this.QuantityContainer);
            this.ProdContainer.Controls.Add(this.Description);
            this.ProdContainer.Controls.Add(this.Pricelbl);
            this.ProdContainer.Controls.Add(this.DiscLabel);
            this.ProdContainer.Controls.Add(this.ProductNamePage);
            this.ProdContainer.Location = new System.Drawing.Point(59, 50);
            this.ProdContainer.Name = "ProdContainer";
            this.ProdContainer.Size = new System.Drawing.Size(1037, 443);
            this.ProdContainer.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 174);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProductNamePage
            // 
            this.ProductNamePage.AutoSize = true;
            this.ProductNamePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNamePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ProductNamePage.Location = new System.Drawing.Point(240, 41);
            this.ProductNamePage.Name = "ProductNamePage";
            this.ProductNamePage.Size = new System.Drawing.Size(206, 38);
            this.ProductNamePage.TabIndex = 1;
            this.ProductNamePage.Text = "Product Name";
            // 
            // DiscLabel
            // 
            this.DiscLabel.AutoSize = true;
            this.DiscLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.DiscLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DiscLabel.Location = new System.Drawing.Point(240, 164);
            this.DiscLabel.Name = "DiscLabel";
            this.DiscLabel.Size = new System.Drawing.Size(134, 31);
            this.DiscLabel.TabIndex = 2;
            this.DiscLabel.Text = "Description";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Pricelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Pricelbl.Location = new System.Drawing.Point(275, 107);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(75, 31);
            this.Pricelbl.TabIndex = 3;
            this.Pricelbl.Text = "10000";
            // 
            // Description
            // 
            this.Description.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Enabled = false;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Description.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Description.Location = new System.Drawing.Point(246, 198);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(666, 117);
            this.Description.TabIndex = 4;
            this.Description.TabStop = false;
            this.Description.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(246, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 39);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Quantitylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Quantitylbl.Location = new System.Drawing.Point(48, 9);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(103, 31);
            this.Quantitylbl.TabIndex = 6;
            this.Quantitylbl.Text = "Quantity";
            // 
            // Qnumber
            // 
            this.Qnumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qnumber.Location = new System.Drawing.Point(83, 50);
            this.Qnumber.Name = "Qnumber";
            this.Qnumber.Size = new System.Drawing.Size(23, 27);
            this.Qnumber.TabIndex = 7;
            this.Qnumber.Text = "1";
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Addbtn.Location = new System.Drawing.Point(112, 43);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(31, 44);
            this.Addbtn.TabIndex = 8;
            this.Addbtn.Text = "+";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.button1.Location = new System.Drawing.Point(46, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuantityContainer
            // 
            this.QuantityContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.QuantityContainer.Controls.Add(this.Quantitylbl);
            this.QuantityContainer.Controls.Add(this.button1);
            this.QuantityContainer.Controls.Add(this.Qnumber);
            this.QuantityContainer.Controls.Add(this.Addbtn);
            this.QuantityContainer.Location = new System.Drawing.Point(13, 201);
            this.QuantityContainer.Name = "QuantityContainer";
            this.QuantityContainer.Size = new System.Drawing.Size(210, 114);
            this.QuantityContainer.TabIndex = 10;
            // 
            // ImageBorder
            // 
            this.ImageBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ImageBorder.Controls.Add(this.pictureBox1);
            this.ImageBorder.Location = new System.Drawing.Point(13, 11);
            this.ImageBorder.Name = "ImageBorder";
            this.ImageBorder.Size = new System.Drawing.Size(210, 184);
            this.ImageBorder.TabIndex = 11;
            // 
            // AddToCart
            // 
            this.AddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.AddToCart.FlatAppearance.BorderSize = 0;
            this.AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.AddToCart.ForeColor = System.Drawing.Color.White;
            this.AddToCart.Image = ((System.Drawing.Image)(resources.GetObject("AddToCart.Image")));
            this.AddToCart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddToCart.Location = new System.Drawing.Point(827, 375);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddToCart.Size = new System.Drawing.Size(190, 48);
            this.AddToCart.TabIndex = 12;
            this.AddToCart.Text = " Add To Cart";
            this.AddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddToCart.UseVisualStyleBackColor = false;
            // 
            // Totallbl
            // 
            this.Totallbl.AutoSize = true;
            this.Totallbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Totallbl.Location = new System.Drawing.Point(564, 382);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(89, 38);
            this.Totallbl.TabIndex = 13;
            this.Totallbl.Text = "Total:";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.TotalAmount.Location = new System.Drawing.Point(692, 382);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(81, 38);
            this.TotalAmount.TabIndex = 14;
            this.TotalAmount.Text = "1000";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(656, 382);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 39);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // Statelbl
            // 
            this.Statelbl.AutoSize = true;
            this.Statelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Statelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Statelbl.Location = new System.Drawing.Point(12, 329);
            this.Statelbl.Name = "Statelbl";
            this.Statelbl.Size = new System.Drawing.Size(72, 31);
            this.Statelbl.TabIndex = 16;
            this.Statelbl.Text = "State:";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.State.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.State.Location = new System.Drawing.Point(80, 329);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(61, 31);
            this.State.TabIndex = 17;
            this.State.Text = "New";
            this.State.Click += new System.EventHandler(this.State_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.button2.Location = new System.Drawing.Point(1103, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProdContainer);
            this.Name = "ProductPage";
            this.Size = new System.Drawing.Size(1164, 542);
            this.ProdContainer.ResumeLayout(false);
            this.ProdContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.QuantityContainer.ResumeLayout(false);
            this.QuantityContainer.PerformLayout();
            this.ImageBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProdContainer;
        private System.Windows.Forms.Label DiscLabel;
        private System.Windows.Forms.Label ProductNamePage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Panel ImageBorder;
        private System.Windows.Forms.Panel QuantityContainer;
        private System.Windows.Forms.Label Quantitylbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Qnumber;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label Statelbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label Totallbl;
        private System.Windows.Forms.Button button2;
    }
}
