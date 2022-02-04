namespace DatabaseProject
{
    partial class inv
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
            this.button1 = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(908, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(16, 15);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(44, 16);
            this.Item.TabIndex = 1;
            this.Item.Text = "label1";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(676, 15);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(44, 16);
            this.Total.TabIndex = 2;
            this.Total.Text = "label1";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(352, 15);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(44, 16);
            this.Date.TabIndex = 3;
            this.Date.Text = "label1";
            // 
            // inv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.button1);
            this.Name = "inv";
            this.Size = new System.Drawing.Size(999, 44);
            this.Load += new System.EventHandler(this.inv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Date;
    }
}
