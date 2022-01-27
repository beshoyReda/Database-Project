namespace DatabaseProject
{
    partial class AdminUsers
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
            this.HeaderAdmin = new System.Windows.Forms.Panel();
            this.Ttllbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.ControlCont = new System.Windows.Forms.Panel();
            this.HeaderAdmin.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderAdmin
            // 
            this.HeaderAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.HeaderAdmin.Controls.Add(this.Ttllbl);
            this.HeaderAdmin.Controls.Add(this.flowLayoutPanel1);
            this.HeaderAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderAdmin.Location = new System.Drawing.Point(0, 0);
            this.HeaderAdmin.Name = "HeaderAdmin";
            this.HeaderAdmin.Size = new System.Drawing.Size(1164, 176);
            this.HeaderAdmin.TabIndex = 1;
            // 
            // Ttllbl
            // 
            this.Ttllbl.AutoSize = true;
            this.Ttllbl.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ttllbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ttllbl.Location = new System.Drawing.Point(464, 47);
            this.Ttllbl.Name = "Ttllbl";
            this.Ttllbl.Size = new System.Drawing.Size(229, 38);
            this.Ttllbl.TabIndex = 1;
            this.Ttllbl.Text = "USER MANAGER";
            this.Ttllbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Searchbtn);
            this.flowLayoutPanel1.Controls.Add(this.Addbtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1164, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.Searchbtn.FlatAppearance.BorderSize = 0;
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Searchbtn.Location = new System.Drawing.Point(3, 3);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(576, 44);
            this.Searchbtn.TabIndex = 0;
            this.Searchbtn.Text = "SEARCH";
            this.Searchbtn.UseVisualStyleBackColor = false;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbtn.Location = new System.Drawing.Point(585, 3);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(576, 44);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "MANAGE";
            this.Addbtn.UseVisualStyleBackColor = false;
            // 
            // ControlCont
            // 
            this.ControlCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlCont.Location = new System.Drawing.Point(0, 176);
            this.ControlCont.Name = "ControlCont";
            this.ControlCont.Size = new System.Drawing.Size(1164, 573);
            this.ControlCont.TabIndex = 2;
            // 
            // AdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.ControlCont);
            this.Controls.Add(this.HeaderAdmin);
            this.Name = "AdminUsers";
            this.Size = new System.Drawing.Size(1164, 749);
            this.HeaderAdmin.ResumeLayout(false);
            this.HeaderAdmin.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderAdmin;
        private System.Windows.Forms.Label Ttllbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Panel ControlCont;
    }
}
