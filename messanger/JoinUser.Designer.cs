namespace messanger
{
    partial class JoinUser
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
            this.bt_Join = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_PW = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_PW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Join
            // 
            this.bt_Join.Location = new System.Drawing.Point(12, 165);
            this.bt_Join.Name = "bt_Join";
            this.bt_Join.Size = new System.Drawing.Size(75, 23);
            this.bt_Join.TabIndex = 0;
            this.bt_Join.Text = "회원가입";
            this.bt_Join.UseVisualStyleBackColor = true;
            this.bt_Join.Click += new System.EventHandler(this.bt_Join_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(113, 165);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 1;
            this.bt_Cancel.Text = "취소";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(8, 31);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(29, 12);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "이름";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(8, 73);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(41, 12);
            this.lb_ID.TabIndex = 3;
            this.lb_ID.Text = "아이디";
            // 
            // lb_PW
            // 
            this.lb_PW.AutoSize = true;
            this.lb_PW.Location = new System.Drawing.Point(8, 114);
            this.lb_PW.Name = "lb_PW";
            this.lb_PW.Size = new System.Drawing.Size(29, 12);
            this.lb_PW.TabIndex = 4;
            this.lb_PW.Text = "암호";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(61, 28);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(127, 21);
            this.tb_Name.TabIndex = 5;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(61, 70);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(127, 21);
            this.tb_ID.TabIndex = 6;
            // 
            // tb_PW
            // 
            this.tb_PW.Location = new System.Drawing.Point(61, 111);
            this.tb_PW.Name = "tb_PW";
            this.tb_PW.Size = new System.Drawing.Size(127, 21);
            this.tb_PW.TabIndex = 7;
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.tb_PW);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_PW);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Join);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Join";
            this.Text = "Join";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Join;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_PW;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_PW;
    }
}