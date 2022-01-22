
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.btntopup = new System.Windows.Forms.Button();
            this.purchases = new System.Windows.Forms.Label();
            this.Installments = new System.Windows.Forms.Label();
            this.PurchasesPanal = new System.Windows.Forms.FlowLayoutPanel();
            this.InstallmentsPanal = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Balance);
            this.panel1.Location = new System.Drawing.Point(26, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(604, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "20";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Balance.Location = new System.Drawing.Point(463, 28);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(122, 38);
            this.Balance.TabIndex = 0;
            this.Balance.Text = "Balance:";
            // 
            // btntopup
            // 
            this.btntopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.btntopup.FlatAppearance.BorderSize = 0;
            this.btntopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntopup.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntopup.ForeColor = System.Drawing.Color.White;
            this.btntopup.Location = new System.Drawing.Point(26, 161);
            this.btntopup.Name = "btntopup";
            this.btntopup.Size = new System.Drawing.Size(158, 41);
            this.btntopup.TabIndex = 5;
            this.btntopup.Text = "Top Up";
            this.btntopup.UseVisualStyleBackColor = false;
            // 
            // purchases
            // 
            this.purchases.AutoSize = true;
            this.purchases.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.purchases.Location = new System.Drawing.Point(21, 290);
            this.purchases.Name = "purchases";
            this.purchases.Size = new System.Drawing.Size(103, 28);
            this.purchases.TabIndex = 8;
            this.purchases.Text = "Purchases";
            // 
            // Installments
            // 
            this.Installments.AutoSize = true;
            this.Installments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Installments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Installments.Location = new System.Drawing.Point(585, 290);
            this.Installments.Name = "Installments";
            this.Installments.Size = new System.Drawing.Size(123, 28);
            this.Installments.TabIndex = 9;
            this.Installments.Text = "Installments";
            // 
            // PurchasesPanal
            // 
            this.PurchasesPanal.BackColor = System.Drawing.Color.White;
            this.PurchasesPanal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurchasesPanal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PurchasesPanal.Location = new System.Drawing.Point(26, 338);
            this.PurchasesPanal.Name = "PurchasesPanal";
            this.PurchasesPanal.Size = new System.Drawing.Size(474, 205);
            this.PurchasesPanal.TabIndex = 10;
            // 
            // InstallmentsPanal
            // 
            this.InstallmentsPanal.BackColor = System.Drawing.Color.White;
            this.InstallmentsPanal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstallmentsPanal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InstallmentsPanal.Location = new System.Drawing.Point(590, 338);
            this.InstallmentsPanal.Name = "InstallmentsPanal";
            this.InstallmentsPanal.Size = new System.Drawing.Size(517, 205);
            this.InstallmentsPanal.TabIndex = 11;
            // 
            // wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.InstallmentsPanal);
            this.Controls.Add(this.PurchasesPanal);
            this.Controls.Add(this.Installments);
            this.Controls.Add(this.purchases);
            this.Controls.Add(this.btntopup);
            this.Controls.Add(this.panel1);
            this.Name = "wallet";
            this.Size = new System.Drawing.Size(1135, 559);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Button btntopup;
        private System.Windows.Forms.Label purchases;
        private System.Windows.Forms.Label Installments;
        private System.Windows.Forms.FlowLayoutPanel PurchasesPanal;
        private System.Windows.Forms.FlowLayoutPanel InstallmentsPanal;
        private System.Windows.Forms.Label label1;
    }
}
