namespace DatabaseProject
{
    partial class LoginPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginContainer = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Panel();
            this.LoginPickerContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LoginContainer.SuspendLayout();
            this.LoginPickerContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(517, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 238);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginContainer
            // 
            this.LoginContainer.Controls.Add(this.LoginPickerContainer);
            this.LoginContainer.Controls.Add(this.Login);
            this.LoginContainer.Location = new System.Drawing.Point(517, 187);
            this.LoginContainer.Name = "LoginContainer";
            this.LoginContainer.Size = new System.Drawing.Size(503, 570);
            this.LoginContainer.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Login.Location = new System.Drawing.Point(0, 106);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(503, 464);
            this.Login.TabIndex = 0;
            this.Login.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            // 
            // LoginPickerContainer
            // 
            this.LoginPickerContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.LoginPickerContainer.Controls.Add(this.btnUser);
            this.LoginPickerContainer.Controls.Add(this.button2);
            this.LoginPickerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPickerContainer.Location = new System.Drawing.Point(0, 0);
            this.LoginPickerContainer.Name = "LoginPickerContainer";
            this.LoginPickerContainer.Size = new System.Drawing.Size(503, 100);
            this.LoginPickerContainer.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(3, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(245, 97);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(254, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1439, 761);
            this.Controls.Add(this.LoginContainer);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LoginContainer.ResumeLayout(false);
            this.LoginPickerContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LoginContainer;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.FlowLayoutPanel LoginPickerContainer;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button button2;
    }
}