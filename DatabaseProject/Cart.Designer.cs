
namespace DatabaseProject
{
    partial class Cart
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
            this.Shopping_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.Deselect_linklbl = new System.Windows.Forms.LinkLabel();
            this.Shopping_panel = new System.Windows.Forms.Panel();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.Shopping_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Shopping_lbl
            // 
            this.Shopping_lbl.AutoSize = true;
            this.Shopping_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Shopping_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Shopping_lbl.Location = new System.Drawing.Point(0, 10);
            this.Shopping_lbl.Name = "Shopping_lbl";
            this.Shopping_lbl.Size = new System.Drawing.Size(172, 32);
            this.Shopping_lbl.TabIndex = 0;
            this.Shopping_lbl.Text = "Shopping Cart";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.price_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.price_lbl.Location = new System.Drawing.Point(1087, 39);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(68, 32);
            this.price_lbl.TabIndex = 1;
            this.price_lbl.Text = "Price";
            this.price_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Deselect_linklbl
            // 
            this.Deselect_linklbl.AutoSize = true;
            this.Deselect_linklbl.Location = new System.Drawing.Point(3, 51);
            this.Deselect_linklbl.Name = "Deselect_linklbl";
            this.Deselect_linklbl.Size = new System.Drawing.Size(118, 17);
            this.Deselect_linklbl.TabIndex = 2;
            this.Deselect_linklbl.TabStop = true;
            this.Deselect_linklbl.Text = "Deselect all items";
            // 
            // Shopping_panel
            // 
            this.Shopping_panel.Controls.Add(this.Deselect_linklbl);
            this.Shopping_panel.Controls.Add(this.price_lbl);
            this.Shopping_panel.Controls.Add(this.Shopping_lbl);
            this.Shopping_panel.Location = new System.Drawing.Point(3, 3);
            this.Shopping_panel.Name = "Shopping_panel";
            this.Shopping_panel.Size = new System.Drawing.Size(1158, 77);
            this.Shopping_panel.TabIndex = 3;
            // 
            // checkout_btn
            // 
            this.checkout_btn.AutoSize = true;
            this.checkout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout_btn.ForeColor = System.Drawing.Color.White;
            this.checkout_btn.Location = new System.Drawing.Point(1079, 412);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(81, 29);
            this.checkout_btn.TabIndex = 8;
            this.checkout_btn.Text = "Checkout";
            this.checkout_btn.UseVisualStyleBackColor = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.Shopping_panel);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(1164, 444);
            this.Load += new System.EventHandler(this.Cart_Load);
            this.Shopping_panel.ResumeLayout(false);
            this.Shopping_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Shopping_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.LinkLabel Deselect_linklbl;
        private System.Windows.Forms.Panel Shopping_panel;
        private System.Windows.Forms.Button checkout_btn;
    }
}
