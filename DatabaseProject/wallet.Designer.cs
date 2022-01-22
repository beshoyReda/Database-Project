
namespace DatabaseProject
{
    partial class wallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wallet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Balance = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.btntopup = new System.Windows.Forms.Button();
            this.Installmentsbox = new System.Windows.Forms.RichTextBox();
            this.purchases = new System.Windows.Forms.Label();
            this.Installments = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pricetag = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pricetag);
            this.panel1.Controls.Add(this.balanceBox);
            this.panel1.Controls.Add(this.Balance);
            this.panel1.Location = new System.Drawing.Point(31, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 107);
            this.panel1.TabIndex = 0;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(52, 32);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(115, 38);
            this.Balance.TabIndex = 0;
            this.Balance.Text = "Balance";
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(231, 46);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(266, 22);
            this.balanceBox.TabIndex = 1;
            // 
            // btntopup
            // 
            this.btntopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.btntopup.FlatAppearance.BorderSize = 0;
            this.btntopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntopup.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntopup.ForeColor = System.Drawing.Color.White;
            this.btntopup.Location = new System.Drawing.Point(31, 173);
            this.btntopup.Name = "btntopup";
            this.btntopup.Size = new System.Drawing.Size(158, 41);
            this.btntopup.TabIndex = 5;
            this.btntopup.Text = "Top Up";
            this.btntopup.UseVisualStyleBackColor = false;
            // 
            // Installmentsbox
            // 
            this.Installmentsbox.Location = new System.Drawing.Point(582, 316);
            this.Installmentsbox.Name = "Installmentsbox";
            this.Installmentsbox.Size = new System.Drawing.Size(359, 210);
            this.Installmentsbox.TabIndex = 7;
            this.Installmentsbox.Text = "";
            // 
            // purchases
            // 
            this.purchases.AutoSize = true;
            this.purchases.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchases.Location = new System.Drawing.Point(54, 276);
            this.purchases.Name = "purchases";
            this.purchases.Size = new System.Drawing.Size(103, 28);
            this.purchases.TabIndex = 8;
            this.purchases.Text = "Purchases";
            // 
            // Installments
            // 
            this.Installments.AutoSize = true;
            this.Installments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Installments.Location = new System.Drawing.Point(577, 276);
            this.Installments.Name = "Installments";
            this.Installments.Size = new System.Drawing.Size(123, 28);
            this.Installments.TabIndex = 9;
            this.Installments.Text = "Installments";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(59, 316);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(359, 210);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // pricetag
            // 
            this.pricetag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.pricetag.FlatAppearance.BorderSize = 0;
            this.pricetag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pricetag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pricetag.Image = ((System.Drawing.Image)(resources.GetObject("pricetag.Image")));
            this.pricetag.Location = new System.Drawing.Point(551, 34);
            this.pricetag.Name = "pricetag";
            this.pricetag.Size = new System.Drawing.Size(79, 47);
            this.pricetag.TabIndex = 2;
            this.pricetag.UseVisualStyleBackColor = false;
            // 
            // wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Installments);
            this.Controls.Add(this.purchases);
            this.Controls.Add(this.Installmentsbox);
            this.Controls.Add(this.btntopup);
            this.Controls.Add(this.panel1);
            this.Name = "wallet";
            this.Size = new System.Drawing.Size(1037, 559);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Button btntopup;
        private System.Windows.Forms.RichTextBox Installmentsbox;
        private System.Windows.Forms.Label purchases;
        private System.Windows.Forms.Label Installments;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button pricetag;
    }
}
