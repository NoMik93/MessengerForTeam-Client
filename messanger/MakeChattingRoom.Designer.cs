namespace messanger
{
    partial class MakeChattingRoom
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
            this.bt_Make = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.lb_StartDate = new System.Windows.Forms.Label();
            this.lb_EndDate = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Intro = new System.Windows.Forms.Label();
            this.lb_PW = new System.Windows.Forms.Label();
            this.lb_LeaderID = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.tb_LeaderID = new System.Windows.Forms.TextBox();
            this.tb_StartDate = new System.Windows.Forms.TextBox();
            this.tb_Intro = new System.Windows.Forms.TextBox();
            this.tb_PW = new System.Windows.Forms.TextBox();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.lb_MakeChattingRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Make
            // 
            this.bt_Make.Location = new System.Drawing.Point(82, 359);
            this.bt_Make.Name = "bt_Make";
            this.bt_Make.Size = new System.Drawing.Size(100, 25);
            this.bt_Make.TabIndex = 0;
            this.bt_Make.Text = "만들기";
            this.bt_Make.UseVisualStyleBackColor = true;
            this.bt_Make.Click += new System.EventHandler(this.bt_Make_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(238, 359);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(100, 25);
            this.bt_Cancel.TabIndex = 1;
            this.bt_Cancel.Text = "취소";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // lb_StartDate
            // 
            this.lb_StartDate.AutoSize = true;
            this.lb_StartDate.Location = new System.Drawing.Point(31, 111);
            this.lb_StartDate.Name = "lb_StartDate";
            this.lb_StartDate.Size = new System.Drawing.Size(41, 12);
            this.lb_StartDate.TabIndex = 2;
            this.lb_StartDate.Text = "시작일";
            // 
            // lb_EndDate
            // 
            this.lb_EndDate.AutoSize = true;
            this.lb_EndDate.Location = new System.Drawing.Point(31, 141);
            this.lb_EndDate.Name = "lb_EndDate";
            this.lb_EndDate.Size = new System.Drawing.Size(41, 12);
            this.lb_EndDate.TabIndex = 3;
            this.lb_EndDate.Text = "종료일";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(31, 51);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(29, 12);
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "제목";
            // 
            // lb_Intro
            // 
            this.lb_Intro.AutoSize = true;
            this.lb_Intro.Location = new System.Drawing.Point(31, 165);
            this.lb_Intro.Name = "lb_Intro";
            this.lb_Intro.Size = new System.Drawing.Size(29, 12);
            this.lb_Intro.TabIndex = 5;
            this.lb_Intro.Text = "소개";
            // 
            // lb_PW
            // 
            this.lb_PW.AutoSize = true;
            this.lb_PW.Location = new System.Drawing.Point(31, 329);
            this.lb_PW.Name = "lb_PW";
            this.lb_PW.Size = new System.Drawing.Size(29, 12);
            this.lb_PW.TabIndex = 6;
            this.lb_PW.Text = "암호";
            // 
            // lb_LeaderID
            // 
            this.lb_LeaderID.AutoSize = true;
            this.lb_LeaderID.Location = new System.Drawing.Point(31, 81);
            this.lb_LeaderID.Name = "lb_LeaderID";
            this.lb_LeaderID.Size = new System.Drawing.Size(69, 12);
            this.lb_LeaderID.TabIndex = 7;
            this.lb_LeaderID.Text = "리더 아이디";
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(102, 48);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(250, 21);
            this.tb_Title.TabIndex = 8;
            // 
            // tb_LeaderID
            // 
            this.tb_LeaderID.Location = new System.Drawing.Point(102, 78);
            this.tb_LeaderID.Name = "tb_LeaderID";
            this.tb_LeaderID.Size = new System.Drawing.Size(133, 21);
            this.tb_LeaderID.TabIndex = 9;
            // 
            // tb_StartDate
            // 
            this.tb_StartDate.Location = new System.Drawing.Point(102, 108);
            this.tb_StartDate.Name = "tb_StartDate";
            this.tb_StartDate.Size = new System.Drawing.Size(188, 21);
            this.tb_StartDate.TabIndex = 10;
            // 
            // tb_Intro
            // 
            this.tb_Intro.Location = new System.Drawing.Point(33, 180);
            this.tb_Intro.Multiline = true;
            this.tb_Intro.Name = "tb_Intro";
            this.tb_Intro.Size = new System.Drawing.Size(346, 133);
            this.tb_Intro.TabIndex = 12;
            // 
            // tb_PW
            // 
            this.tb_PW.Location = new System.Drawing.Point(66, 326);
            this.tb_PW.Name = "tb_PW";
            this.tb_PW.Size = new System.Drawing.Size(116, 21);
            this.tb_PW.TabIndex = 13;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(102, 135);
            this.dtp_EndDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtp_EndDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(188, 21);
            this.dtp_EndDate.TabIndex = 14;
            // 
            // lb_MakeChattingRoom
            // 
            this.lb_MakeChattingRoom.AutoSize = true;
            this.lb_MakeChattingRoom.BackColor = System.Drawing.Color.Transparent;
            this.lb_MakeChattingRoom.Font = new System.Drawing.Font("휴먼모음T", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_MakeChattingRoom.Location = new System.Drawing.Point(132, 10);
            this.lb_MakeChattingRoom.Name = "lb_MakeChattingRoom";
            this.lb_MakeChattingRoom.Size = new System.Drawing.Size(125, 27);
            this.lb_MakeChattingRoom.TabIndex = 15;
            this.lb_MakeChattingRoom.Text = "채팅방 생성";
            // 
            // MakeChattingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lb_MakeChattingRoom);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.tb_PW);
            this.Controls.Add(this.tb_Intro);
            this.Controls.Add(this.tb_StartDate);
            this.Controls.Add(this.tb_LeaderID);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.lb_LeaderID);
            this.Controls.Add(this.lb_PW);
            this.Controls.Add(this.lb_Intro);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.lb_EndDate);
            this.Controls.Add(this.lb_StartDate);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Make);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeChattingRoom";
            this.Text = "MakeChattingRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Make;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label lb_StartDate;
        private System.Windows.Forms.Label lb_EndDate;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Intro;
        private System.Windows.Forms.Label lb_PW;
        private System.Windows.Forms.Label lb_LeaderID;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.TextBox tb_LeaderID;
        private System.Windows.Forms.TextBox tb_StartDate;
        private System.Windows.Forms.TextBox tb_Intro;
        private System.Windows.Forms.TextBox tb_PW;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label lb_MakeChattingRoom;
    }
}