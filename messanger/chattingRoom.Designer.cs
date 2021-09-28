namespace messanger
{
    partial class ChattingRoom
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
            this.pn_board = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pn_chatting = new System.Windows.Forms.Panel();
            this.pn_send = new System.Windows.Forms.Panel();
            this.bt_send = new System.Windows.Forms.Button();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.pb_Calendar = new System.Windows.Forms.PictureBox();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pb_Minimize = new System.Windows.Forms.PictureBox();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.pn_board.SuspendLayout();
            this.pn_send.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_board
            // 
            this.pn_board.BackColor = System.Drawing.Color.IndianRed;
            this.pn_board.Controls.Add(this.pb_Calendar);
            this.pn_board.Controls.Add(this.lb_Title);
            this.pn_board.Controls.Add(this.pb_Logo);
            this.pn_board.Controls.Add(this.pb_Minimize);
            this.pn_board.Controls.Add(this.pb_Close);
            this.pn_board.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_board.Location = new System.Drawing.Point(0, 0);
            this.pn_board.Name = "pn_board";
            this.pn_board.Size = new System.Drawing.Size(400, 35);
            this.pn_board.TabIndex = 10;
            this.pn_board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseDown);
            this.pn_board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseMove);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.lb_Title.Font = new System.Drawing.Font("휴먼모음T", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Title.ForeColor = System.Drawing.Color.Black;
            this.lb_Title.Location = new System.Drawing.Point(36, 2);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(0, 32);
            this.lb_Title.TabIndex = 3;
            this.lb_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseDown);
            this.lb_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseMove);
            // 
            // pn_chatting
            // 
            this.pn_chatting.AutoScroll = true;
            this.pn_chatting.BackColor = System.Drawing.Color.LightPink;
            this.pn_chatting.Location = new System.Drawing.Point(0, 35);
            this.pn_chatting.Name = "pn_chatting";
            this.pn_chatting.Size = new System.Drawing.Size(400, 520);
            this.pn_chatting.TabIndex = 11;
            // 
            // pn_send
            // 
            this.pn_send.BackColor = System.Drawing.Color.SteelBlue;
            this.pn_send.Controls.Add(this.bt_send);
            this.pn_send.Controls.Add(this.tb_send);
            this.pn_send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_send.Location = new System.Drawing.Point(0, 555);
            this.pn_send.Name = "pn_send";
            this.pn_send.Size = new System.Drawing.Size(400, 45);
            this.pn_send.TabIndex = 12;
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(319, 12);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 1;
            this.bt_send.Text = "보내기";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(5, 12);
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(308, 21);
            this.tb_send.TabIndex = 0;
            // 
            // pb_Calendar
            // 
            this.pb_Calendar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Calendar.Image = global::messanger.Properties.Resources.calendar;
            this.pb_Calendar.Location = new System.Drawing.Point(295, 3);
            this.pb_Calendar.Name = "pb_Calendar";
            this.pb_Calendar.Size = new System.Drawing.Size(30, 30);
            this.pb_Calendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Calendar.TabIndex = 4;
            this.pb_Calendar.TabStop = false;
            this.pb_Calendar.Click += new System.EventHandler(this.pb_Calendar_Click);
            this.pb_Calendar.MouseEnter += new System.EventHandler(this.pb_Calendar_MouseEnter);
            this.pb_Calendar.MouseLeave += new System.EventHandler(this.pb_Calendar_MouseLeave);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_Logo.Image = global::messanger.Properties.Resources.ico;
            this.pb_Logo.Location = new System.Drawing.Point(5, 5);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(25, 25);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 2;
            this.pb_Logo.TabStop = false;
            // 
            // pb_Minimize
            // 
            this.pb_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.pb_Minimize.Image = global::messanger.Properties.Resources.minimize;
            this.pb_Minimize.Location = new System.Drawing.Point(331, 3);
            this.pb_Minimize.Name = "pb_Minimize";
            this.pb_Minimize.Size = new System.Drawing.Size(30, 30);
            this.pb_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Minimize.TabIndex = 1;
            this.pb_Minimize.TabStop = false;
            this.pb_Minimize.Click += new System.EventHandler(this.pb_Minimize_Click);
            this.pb_Minimize.MouseEnter += new System.EventHandler(this.pb_Minimize_MouseEnter);
            this.pb_Minimize.MouseLeave += new System.EventHandler(this.pb_Minimize_MouseLeave);
            // 
            // pb_Close
            // 
            this.pb_Close.BackColor = System.Drawing.Color.Transparent;
            this.pb_Close.Image = global::messanger.Properties.Resources.exit;
            this.pb_Close.Location = new System.Drawing.Point(367, 3);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(30, 30);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Close.TabIndex = 0;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            this.pb_Close.MouseEnter += new System.EventHandler(this.pb_Close_MouseEnter);
            this.pb_Close.MouseLeave += new System.EventHandler(this.pb_Close_MouseLeave);
            // 
            // ChattingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.pn_send);
            this.Controls.Add(this.pn_chatting);
            this.Controls.Add(this.pn_board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChattingRoom";
            this.Text = "chattingRoom";
            this.pn_board.ResumeLayout(false);
            this.pn_board.PerformLayout();
            this.pn_send.ResumeLayout(false);
            this.pn_send.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_board;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.Panel pn_chatting;
        private System.Windows.Forms.Panel pn_send;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.PictureBox pb_Calendar;
    }
}