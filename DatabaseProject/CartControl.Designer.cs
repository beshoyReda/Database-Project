
namespace DatabaseProject
{
    partial class CartControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartControl));
            this.Shopping_lbl = new System.Windows.Forms.Label();
            this.Shopping_panel = new System.Windows.Forms.Panel();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.ProdCon = new System.Windows.Forms.FlowLayoutPanel();
            this.total = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalCash = new System.Windows.Forms.Label();
            this.Shopping_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Shopping_lbl
            // 
            this.Shopping_lbl.AutoSize = true;
            this.Shopping_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Shopping_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Shopping_lbl.Location = new System.Drawing.Point(0, 10);
            this.Shopping_lbl.Name = "Shopping_lbl";
            this.Shopping_lbl.Size = new System.Drawing.Size(165, 31);
            this.Shopping_lbl.TabIndex = 0;
            this.Shopping_lbl.Text = "Shopping Cart";
            // 
            // Shopping_panel
            // 
            this.Shopping_panel.Controls.Add(this.Shopping_lbl);
            this.Shopping_panel.Location = new System.Drawing.Point(3, 3);
            this.Shopping_panel.Name = "Shopping_panel";
            this.Shopping_panel.Size = new System.Drawing.Size(1149, 77);
            this.Shopping_panel.TabIndex = 3;
            // 
            // checkout_btn
            // 
            this.checkout_btn.AutoSize = true;
            this.checkout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.checkout_btn.FlatAppearance.BorderSize = 0;
            this.checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_btn.ForeColor = System.Drawing.Color.White;
            this.checkout_btn.Location = new System.Drawing.Point(1021, 384);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(126, 45);
            this.checkout_btn.TabIndex = 8;
            this.checkout_btn.Text = "Checkout";
            this.checkout_btn.UseVisualStyleBackColor = false;
            // 
            // ProdCon
            // 
            this.ProdCon.AutoScroll = true;
            this.ProdCon.Location = new System.Drawing.Point(3, 86);
            this.ProdCon.Name = "ProdCon";
            this.ProdCon.Size = new System.Drawing.Size(1149, 291);
            this.ProdCon.TabIndex = 9;
            this.ProdCon.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(3, 5);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(71, 31);
            this.total.TabIndex = 0;
            this.total.Text = "Total:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(80, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TotalCash);
            this.panel1.Controls.Add(this.total);
            this.panel1.Location = new System.Drawing.Point(791, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 49);
            this.panel1.TabIndex = 10;
            // 
            // TotalCash
            // 
            this.TotalCash.AutoSize = true;
            this.TotalCash.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCash.Location = new System.Drawing.Point(96, 6);
            this.TotalCash.Name = "TotalCash";
            this.TotalCash.Size = new System.Drawing.Size(62, 31);
            this.TotalCash.TabIndex = 2;
            this.TotalCash.Text = "1000";
            // 
            // CartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProdCon);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.Shopping_panel);
            this.Name = "CartControl";
            this.Size = new System.Drawing.Size(1155, 444);
            this.Load += new System.EventHandler(this.Cart_Load);
            this.Shopping_panel.ResumeLayout(false);
            this.Shopping_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Shopping_lbl;
        private System.Windows.Forms.Panel Shopping_panel;
        private System.Windows.Forms.Button checkout_btn;
        private System.Windows.Forms.FlowLayoutPanel ProdCon;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalCash;
    }
}
