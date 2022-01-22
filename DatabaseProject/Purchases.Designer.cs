
namespace DatabaseProject
{
    partial class Purchases
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
            this.Date_lbl = new System.Windows.Forms.Label();
            this.amount_lbl = new System.Windows.Forms.Label();
            this.btndetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Date_lbl.Location = new System.Drawing.Point(22, 8);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(67, 32);
            this.Date_lbl.TabIndex = 0;
            this.Date_lbl.Text = "Date";
            this.Date_lbl.Click += new System.EventHandler(this.Date_lbl_Click);
            // 
            // amount_lbl
            // 
            this.amount_lbl.AutoSize = true;
            this.amount_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.amount_lbl.Location = new System.Drawing.Point(132, 7);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(103, 32);
            this.amount_lbl.TabIndex = 1;
            this.amount_lbl.Text = "Amount";
            // 
            // btndetails
            // 
            this.btndetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.btndetails.FlatAppearance.BorderSize = 0;
            this.btndetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetails.ForeColor = System.Drawing.Color.White;
            this.btndetails.Location = new System.Drawing.Point(283, 3);
            this.btndetails.Name = "btndetails";
            this.btndetails.Size = new System.Drawing.Size(162, 40);
            this.btndetails.TabIndex = 6;
            this.btndetails.Text = "Details";
            this.btndetails.UseVisualStyleBackColor = false;
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btndetails);
            this.Controls.Add(this.amount_lbl);
            this.Controls.Add(this.Date_lbl);
            this.Name = "Purchases";
            this.Size = new System.Drawing.Size(474, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.Label amount_lbl;
        private System.Windows.Forms.Button btndetails;
    }
}
