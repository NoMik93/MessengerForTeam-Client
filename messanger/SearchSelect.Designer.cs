namespace messanger
{
    partial class SearchSelect
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
            this.lb_Leaderf = new System.Windows.Forms.Label();
            this.lb_timef = new System.Windows.Forms.Label();
            this.lb_Leader = new System.Windows.Forms.Label();
            this.lb_StartDate = new System.Windows.Forms.Label();
            this.lb_Wave = new System.Windows.Forms.Label();
            this.lb_EndDate = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.bt_JoinRoom = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.pb_SearchSelect = new System.Windows.Forms.PictureBox();
            this.lb_Intro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SearchSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Leaderf
            // 
            this.lb_Leaderf.AutoSize = true;
            this.lb_Leaderf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(96)))), ((int)(((byte)(134)))));
            this.lb_Leaderf.ForeColor = System.Drawing.Color.White;
            this.lb_Leaderf.Location = new System.Drawing.Point(22, 22);
            this.lb_Leaderf.Name = "lb_Leaderf";
            this.lb_Leaderf.Size = new System.Drawing.Size(49, 12);
            this.lb_Leaderf.TabIndex = 1;
            this.lb_Leaderf.Text = "팀장명 :";
            // 
            // lb_timef
            // 
            this.lb_timef.AutoSize = true;
            this.lb_timef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(96)))), ((int)(((byte)(134)))));
            this.lb_timef.ForeColor = System.Drawing.Color.White;
            this.lb_timef.Location = new System.Drawing.Point(22, 62);
            this.lb_timef.Name = "lb_timef";
            this.lb_timef.Size = new System.Drawing.Size(85, 12);
            this.lb_timef.TabIndex = 2;
            this.lb_timef.Text = "프로젝트 기한:";
            // 
            // lb_Leader
            // 
            this.lb_Leader.AutoSize = true;
            this.lb_Leader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(96)))), ((int)(((byte)(134)))));
            this.lb_Leader.ForeColor = System.Drawing.Color.White;
            this.lb_Leader.Location = new System.Drawing.Point(76, 22);
            this.lb_Leader.Name = "lb_Leader";
            this.lb_Leader.Size = new System.Drawing.Size(0, 12);
            this.lb_Leader.TabIndex = 3;
            // 
            // lb_StartDate
            // 
            this.lb_StartDate.AutoSize = true;
            this.lb_StartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(96)))), ((int)(((byte)(134)))));
            this.lb_StartDate.ForeColor = System.Drawing.Color.White;
            this.lb_StartDate.Location = new System.Drawing.Point(113, 62);
            this.lb_StartDate.Name = "lb_StartDate";
            this.lb_StartDate.Size = new System.Drawing.Size(0, 12);
            this.lb_StartDate.TabIndex = 4;
            // 
            // lb_Wave
            // 
            this.lb_Wave.AutoSize = true;
            this.lb_Wave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(96)))), ((int)(((byte)(134)))));
            this.lb_Wave.ForeColor = System.Drawing.Color.White;
            this.lb_Wave.Location = new System.Drawing.Point(184, 62);
            this.lb_Wave.Name = "lb_Wave";
            this.lb_Wave.Size = new System.Drawing.Size(14, 12);
            this.lb_Wave.TabIndex = 5;
            this.lb_Wave.Text = "~";
            // 
            // lb_EndDate
            // 
            this.lb_EndDate.AutoSize = true;
            this.lb_EndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(96)))), ((int)(((byte)(134)))));
            this.lb_EndDate.ForeColor = System.Drawing.Color.White;
            this.lb_EndDate.Location = new System.Drawing.Point(175, 80);
            this.lb_EndDate.Name = "lb_EndDate";
            this.lb_EndDate.Size = new System.Drawing.Size(0, 12);
            this.lb_EndDate.TabIndex = 6;
            // 
            // tb_Password
            // 
            this.tb_Password.ForeColor = System.Drawing.Color.Gray;
            this.tb_Password.Location = new System.Drawing.Point(12, 253);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(151, 21);
            this.tb_Password.TabIndex = 7;
            this.tb_Password.Text = "비밀번호를 입력하세요";
            this.tb_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Password_MouseClick);
            // 
            // bt_JoinRoom
            // 
            this.bt_JoinRoom.Location = new System.Drawing.Point(169, 253);
            this.bt_JoinRoom.Name = "bt_JoinRoom";
            this.bt_JoinRoom.Size = new System.Drawing.Size(50, 23);
            this.bt_JoinRoom.TabIndex = 8;
            this.bt_JoinRoom.Text = "가입";
            this.bt_JoinRoom.UseVisualStyleBackColor = true;
            this.bt_JoinRoom.Click += new System.EventHandler(this.bt_JoinRoom_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(225, 253);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(50, 23);
            this.bt_Close.TabIndex = 9;
            this.bt_Close.Text = "닫기";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // pb_SearchSelect
            // 
            this.pb_SearchSelect.BackColor = System.Drawing.Color.Transparent;
            this.pb_SearchSelect.Image = global::messanger.Properties.Resources.SearchSelect;
            this.pb_SearchSelect.Location = new System.Drawing.Point(0, 0);
            this.pb_SearchSelect.Name = "pb_SearchSelect";
            this.pb_SearchSelect.Size = new System.Drawing.Size(300, 300);
            this.pb_SearchSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_SearchSelect.TabIndex = 0;
            this.pb_SearchSelect.TabStop = false;
            // 
            // lb_Intro
            // 
            this.lb_Intro.AutoSize = true;
            this.lb_Intro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(96)))), ((int)(((byte)(134)))));
            this.lb_Intro.ForeColor = System.Drawing.Color.White;
            this.lb_Intro.Location = new System.Drawing.Point(22, 125);
            this.lb_Intro.MaximumSize = new System.Drawing.Size(257, 110);
            this.lb_Intro.Name = "lb_Intro";
            this.lb_Intro.Size = new System.Drawing.Size(0, 12);
            this.lb_Intro.TabIndex = 10;
            // 
            // SearchSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lb_Intro);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_JoinRoom);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lb_EndDate);
            this.Controls.Add(this.lb_Wave);
            this.Controls.Add(this.lb_StartDate);
            this.Controls.Add(this.lb_Leader);
            this.Controls.Add(this.lb_timef);
            this.Controls.Add(this.lb_Leaderf);
            this.Controls.Add(this.pb_SearchSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchSelect";
            this.Text = "SearchSelect";
            ((System.ComponentModel.ISupportInitialize)(this.pb_SearchSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_SearchSelect;
        private System.Windows.Forms.Label lb_Leaderf;
        private System.Windows.Forms.Label lb_timef;
        private System.Windows.Forms.Label lb_Leader;
        private System.Windows.Forms.Label lb_StartDate;
        private System.Windows.Forms.Label lb_Wave;
        private System.Windows.Forms.Label lb_EndDate;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button bt_JoinRoom;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Label lb_Intro;
    }
}