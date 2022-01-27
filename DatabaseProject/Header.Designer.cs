namespace DatabaseProject
{
    partial class Header
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DealsHeader = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.FavoritesHeader = new System.Windows.Forms.Button();
            this.SearchHeader = new System.Windows.Forms.Button();
            this.CategoriesHeader = new System.Windows.Forms.Button();
            this.SlideShow = new System.Windows.Forms.PictureBox();
            this.SlideShowTimer = new System.Windows.Forms.Timer(this.components);
            this.NextPic = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DealsHeader);
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.FavoritesHeader);
            this.panel1.Controls.Add(this.SearchHeader);
            this.panel1.Controls.Add(this.CategoriesHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 68);
            this.panel1.TabIndex = 0;
            // 
            // DealsHeader
            // 
            this.DealsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.DealsHeader.FlatAppearance.BorderSize = 0;
            this.DealsHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DealsHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealsHeader.ForeColor = System.Drawing.Color.White;
            this.DealsHeader.Location = new System.Drawing.Point(808, 0);
            this.DealsHeader.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.DealsHeader.Name = "DealsHeader";
            this.DealsHeader.Size = new System.Drawing.Size(271, 68);
            this.DealsHeader.TabIndex = 3;
            this.DealsHeader.Text = "Deals";
            this.DealsHeader.UseVisualStyleBackColor = false;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.Location = new System.Drawing.Point(1084, 0);
            this.LogOut.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(80, 68);
            this.LogOut.TabIndex = 4;
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // FavoritesHeader
            // 
            this.FavoritesHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.FavoritesHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.FavoritesHeader.FlatAppearance.BorderSize = 0;
            this.FavoritesHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavoritesHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoritesHeader.ForeColor = System.Drawing.Color.White;
            this.FavoritesHeader.Location = new System.Drawing.Point(542, 0);
            this.FavoritesHeader.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.FavoritesHeader.Name = "FavoritesHeader";
            this.FavoritesHeader.Size = new System.Drawing.Size(271, 68);
            this.FavoritesHeader.TabIndex = 2;
            this.FavoritesHeader.Text = "Favorites";
            this.FavoritesHeader.UseVisualStyleBackColor = false;
            // 
            // SearchHeader
            // 
            this.SearchHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.SearchHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchHeader.FlatAppearance.BorderSize = 0;
            this.SearchHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchHeader.ForeColor = System.Drawing.Color.White;
            this.SearchHeader.Location = new System.Drawing.Point(271, 0);
            this.SearchHeader.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.SearchHeader.Name = "SearchHeader";
            this.SearchHeader.Size = new System.Drawing.Size(271, 68);
            this.SearchHeader.TabIndex = 1;
            this.SearchHeader.Text = "Search";
            this.SearchHeader.UseVisualStyleBackColor = false;
            this.SearchHeader.Click += new System.EventHandler(this.SearchHeader_Click);
            // 
            // CategoriesHeader
            // 
            this.CategoriesHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.CategoriesHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoriesHeader.FlatAppearance.BorderSize = 0;
            this.CategoriesHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoriesHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesHeader.ForeColor = System.Drawing.Color.White;
            this.CategoriesHeader.Location = new System.Drawing.Point(0, 0);
            this.CategoriesHeader.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.CategoriesHeader.Name = "CategoriesHeader";
            this.CategoriesHeader.Size = new System.Drawing.Size(271, 68);
            this.CategoriesHeader.TabIndex = 0;
            this.CategoriesHeader.Text = "Categories";
            this.CategoriesHeader.UseVisualStyleBackColor = false;
            // 
            // SlideShow
            // 
            this.SlideShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlideShow.BackgroundImage")));
            this.SlideShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SlideShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.SlideShow.Location = new System.Drawing.Point(0, 0);
            this.SlideShow.Name = "SlideShow";
            this.SlideShow.Size = new System.Drawing.Size(1164, 213);
            this.SlideShow.TabIndex = 1;
            this.SlideShow.TabStop = false;
            this.SlideShow.Click += new System.EventHandler(this.SlideShow_Click);
            // 
            // SlideShowTimer
            // 
            this.SlideShowTimer.Enabled = true;
            this.SlideShowTimer.Interval = 3000;
            this.SlideShowTimer.Tick += new System.EventHandler(this.SlideShowTimer_Tick);
            // 
            // NextPic
            // 
            this.NextPic.BackColor = System.Drawing.Color.Gainsboro;
            this.NextPic.FlatAppearance.BorderSize = 0;
            this.NextPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NextPic.Image = ((System.Drawing.Image)(resources.GetObject("NextPic.Image")));
            this.NextPic.Location = new System.Drawing.Point(1084, 92);
            this.NextPic.Name = "NextPic";
            this.NextPic.Size = new System.Drawing.Size(80, 43);
            this.NextPic.TabIndex = 2;
            this.NextPic.UseVisualStyleBackColor = false;
            this.NextPic.Click += new System.EventHandler(this.NextPic_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(-1, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 43);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.button5);
            this.Controls.Add(this.NextPic);
            this.Controls.Add(this.SlideShow);
            this.Controls.Add(this.panel1);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1164, 287);
            this.Load += new System.EventHandler(this.Header_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SlideShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CategoriesHeader;
        private System.Windows.Forms.Button FavoritesHeader;
        private System.Windows.Forms.Button SearchHeader;
        private System.Windows.Forms.PictureBox SlideShow;
        private System.Windows.Forms.Timer SlideShowTimer;
        private System.Windows.Forms.Button NextPic;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button DealsHeader;
    }
}
