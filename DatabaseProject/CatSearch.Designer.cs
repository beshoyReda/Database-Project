namespace DatabaseProject
{
    partial class CatSearch
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
            this.Categ = new System.Windows.Forms.ComboBox();
            this.SubCateg = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Categ
            // 
            this.Categ.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Categ.FormattingEnabled = true;
            this.Categ.Location = new System.Drawing.Point(75, 47);
            this.Categ.Name = "Categ";
            this.Categ.Size = new System.Drawing.Size(404, 39);
            this.Categ.TabIndex = 0;
            this.Categ.SelectedIndexChanged += new System.EventHandler(this.Categ_SelectedIndexChanged);
            // 
            // SubCateg
            // 
            this.SubCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.SubCateg.FormattingEnabled = true;
            this.SubCateg.Location = new System.Drawing.Point(539, 47);
            this.SubCateg.Name = "SubCateg";
            this.SubCateg.Size = new System.Drawing.Size(348, 39);
            this.SubCateg.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(976, 39);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(117, 47);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CatSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SubCateg);
            this.Controls.Add(this.Categ);
            this.Name = "CatSearch";
            this.Size = new System.Drawing.Size(1126, 118);
            this.Load += new System.EventHandler(this.CatSearch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Categ;
        private System.Windows.Forms.ComboBox SubCateg;
        private System.Windows.Forms.Button SearchButton;
    }
}
