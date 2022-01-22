
namespace DatabaseProject
{
    partial class Item
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete_linklbl = new System.Windows.Forms.LinkLabel();
            this.quantity_list = new System.Windows.Forms.CheckedListBox();
            this.price_lbl = new System.Windows.Forms.Label();
            this.Gate_lbl = new System.Windows.Forms.Label();
            this.PN_lbl = new System.Windows.Forms.Label();
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.delete_linklbl);
            this.panel2.Controls.Add(this.quantity_list);
            this.panel2.Controls.Add(this.price_lbl);
            this.panel2.Controls.Add(this.Gate_lbl);
            this.panel2.Controls.Add(this.PN_lbl);
            this.panel2.Controls.Add(this.pic_box);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 172);
            this.panel2.TabIndex = 7;
            // 
            // delete_linklbl
            // 
            this.delete_linklbl.AutoSize = true;
            this.delete_linklbl.Location = new System.Drawing.Point(366, 130);
            this.delete_linklbl.Name = "delete_linklbl";
            this.delete_linklbl.Size = new System.Drawing.Size(49, 17);
            this.delete_linklbl.TabIndex = 10;
            this.delete_linklbl.TabStop = true;
            this.delete_linklbl.Text = "Delete";
            // 
            // quantity_list
            // 
            this.quantity_list.FormattingEnabled = true;
            this.quantity_list.Items.AddRange(new object[] {
            "Quantity : 0",
            "Quantity : 1",
            "Quantity : 2",
            "Quantity : 3",
            "Quantity : 4",
            "Quantity : 5",
            "Quantity : 6",
            "Quantity : 7",
            "Quantity : 8",
            "Quantity : 9",
            "Quantity : +10"});
            this.quantity_list.Location = new System.Drawing.Point(220, 109);
            this.quantity_list.Name = "quantity_list";
            this.quantity_list.Size = new System.Drawing.Size(120, 38);
            this.quantity_list.TabIndex = 9;
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.price_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.price_lbl.Location = new System.Drawing.Point(1087, 0);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(68, 32);
            this.price_lbl.TabIndex = 8;
            this.price_lbl.Text = "Price";
            // 
            // Gate_lbl
            // 
            this.Gate_lbl.AutoSize = true;
            this.Gate_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Gate_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Gate_lbl.Location = new System.Drawing.Point(214, 57);
            this.Gate_lbl.Name = "Gate_lbl";
            this.Gate_lbl.Size = new System.Drawing.Size(189, 32);
            this.Gate_lbl.TabIndex = 7;
            this.Gate_lbl.Text = "Gategory Name";
            // 
            // PN_lbl
            // 
            this.PN_lbl.AutoSize = true;
            this.PN_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.PN_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.PN_lbl.Location = new System.Drawing.Point(214, 16);
            this.PN_lbl.Name = "PN_lbl";
            this.PN_lbl.Size = new System.Drawing.Size(172, 32);
            this.PN_lbl.TabIndex = 6;
            this.PN_lbl.Text = "Product Name";
            this.PN_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // pic_box
            // 
            this.pic_box.Location = new System.Drawing.Point(50, 16);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(158, 141);
            this.pic_box.TabIndex = 5;
            this.pic_box.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(14, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(20, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(1159, 177);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel delete_linklbl;
        private System.Windows.Forms.CheckedListBox quantity_list;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label Gate_lbl;
        private System.Windows.Forms.Label PN_lbl;
        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
