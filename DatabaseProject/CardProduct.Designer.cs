namespace DatabaseProject
{
    partial class CartProduct
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
            this.ProdName = new System.Windows.Forms.Label();
            this.ProdQ = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProdName
            // 
            this.ProdName.AutoSize = true;
            this.ProdName.Location = new System.Drawing.Point(20, 14);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(93, 16);
            this.ProdName.TabIndex = 0;
            this.ProdName.Text = "Product Name";
            // 
            // ProdQ
            // 
            this.ProdQ.AutoSize = true;
            this.ProdQ.Location = new System.Drawing.Point(441, 14);
            this.ProdQ.Name = "ProdQ";
            this.ProdQ.Size = new System.Drawing.Size(101, 16);
            this.ProdQ.TabIndex = 1;
            this.ProdQ.Text = "ProductQuantity";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(812, 14);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(38, 16);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1014, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CartProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.ProdQ);
            this.Controls.Add(this.ProdName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CartProduct";
            this.Size = new System.Drawing.Size(1135, 45);
            this.Load += new System.EventHandler(this.CardProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProdName;
        private System.Windows.Forms.Label ProdQ;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button button1;
    }
}
