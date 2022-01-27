namespace DatabaseProject
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.LogoContainer = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.ProductContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.Header = new System.Windows.Forms.Panel();
            this.SidePanelContainer = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.LogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.SidePanel.Controls.Add(this.SidePanelContainer);
            this.SidePanel.Controls.Add(this.LogoContainer);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(275, 761);
            this.SidePanel.TabIndex = 0;
            // 
            // LogoContainer
            // 
            this.LogoContainer.Controls.Add(this.Logo);
            this.LogoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoContainer.Location = new System.Drawing.Point(0, 0);
            this.LogoContainer.Name = "LogoContainer";
            this.LogoContainer.Size = new System.Drawing.Size(275, 129);
            this.LogoContainer.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(275, 129);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Content
            // 
            this.Content.AutoScroll = true;
            this.Content.Controls.Add(this.ProductContainer);
            this.Content.Controls.Add(this.Header);
            this.Content.Dock = System.Windows.Forms.DockStyle.Top;
            this.Content.Location = new System.Drawing.Point(275, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1164, 749);
            this.Content.TabIndex = 1;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // ProductContainer
            // 
            this.ProductContainer.AutoScroll = true;
            this.ProductContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductContainer.Location = new System.Drawing.Point(0, 287);
            this.ProductContainer.Name = "ProductContainer";
            this.ProductContainer.Size = new System.Drawing.Size(1164, 462);
            this.ProductContainer.TabIndex = 1;
            this.ProductContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductContainer_Paint_1);
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1164, 287);
            this.Header.TabIndex = 0;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // SidePanelContainer
            // 
            this.SidePanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanelContainer.Location = new System.Drawing.Point(0, 129);
            this.SidePanelContainer.Name = "SidePanelContainer";
            this.SidePanelContainer.Size = new System.Drawing.Size(275, 632);
            this.SidePanelContainer.TabIndex = 1;
            this.SidePanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1439, 761);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.SidePanel.ResumeLayout(false);
            this.LogoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel LogoContainer;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.FlowLayoutPanel ProductContainer;
        private System.Windows.Forms.Panel SidePanelContainer;
    }
}

