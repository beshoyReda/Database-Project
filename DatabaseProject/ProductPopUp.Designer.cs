namespace DatabaseProject
{
    partial class ProductPopUp
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
            this.ProductPageCon = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ProductPageCon
            // 
            this.ProductPageCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPageCon.Location = new System.Drawing.Point(0, 0);
            this.ProductPageCon.Name = "ProductPageCon";
            this.ProductPageCon.Size = new System.Drawing.Size(1146, 530);
            this.ProductPageCon.TabIndex = 0;
            this.ProductPageCon.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductPageCon_Paint);
            // 
            // ProductPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1146, 530);
            this.Controls.Add(this.ProductPageCon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductPopUp";
            this.Load += new System.EventHandler(this.ProductPopUp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProductPageCon;
    }
}