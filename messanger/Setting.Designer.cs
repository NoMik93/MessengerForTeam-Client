namespace messanger
{
    partial class Setting
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
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_leave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(99, 326);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(216, 61);
            this.bt_logout.TabIndex = 0;
            this.bt_logout.Text = "로그아웃";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(99, 493);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(216, 64);
            this.bt_Close.TabIndex = 1;
            this.bt_Close.Text = "닫기";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_leave
            // 
            this.bt_leave.Location = new System.Drawing.Point(99, 405);
            this.bt_leave.Name = "bt_leave";
            this.bt_leave.Size = new System.Drawing.Size(216, 61);
            this.bt_leave.TabIndex = 2;
            this.bt_leave.Text = "회원탈퇴";
            this.bt_leave.UseVisualStyleBackColor = true;
            this.bt_leave.Click += new System.EventHandler(this.bt_leave_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.bt_leave);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_leave;
    }
}