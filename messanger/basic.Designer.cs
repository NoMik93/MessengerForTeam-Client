namespace messanger
{
    partial class Basic
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basic));
            this.pn_login = new System.Windows.Forms.Panel();
            this.bt_Join = new System.Windows.Forms.Button();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.pb_Cover = new System.Windows.Forms.PictureBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.pn_basic = new System.Windows.Forms.Panel();
            this.pb_makeChattingRoom = new System.Windows.Forms.PictureBox();
            this.pb_search = new System.Windows.Forms.PictureBox();
            this.pb_setting = new System.Windows.Forms.PictureBox();
            this.pn_dialogue = new System.Windows.Forms.Panel();
            this.pn_board = new System.Windows.Forms.Panel();
            this.lb_Logo = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pb_Minimize = new System.Windows.Forms.PictureBox();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.pn_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cover)).BeginInit();
            this.pn_basic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_makeChattingRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_setting)).BeginInit();
            this.pn_board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_login
            // 
            this.pn_login.AutoSize = true;
            this.pn_login.BackColor = System.Drawing.Color.DarkCyan;
            this.pn_login.Controls.Add(this.bt_Join);
            this.pn_login.Controls.Add(this.tb_Port);
            this.pn_login.Controls.Add(this.bt_Connect);
            this.pn_login.Controls.Add(this.tb_IP);
            this.pn_login.Controls.Add(this.pb_Cover);
            this.pn_login.Controls.Add(this.bt_Login);
            this.pn_login.Controls.Add(this.tb_Pw);
            this.pn_login.Controls.Add(this.tb_Id);
            this.pn_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_login.Location = new System.Drawing.Point(0, 0);
            this.pn_login.Margin = new System.Windows.Forms.Padding(6);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(400, 600);
            this.pn_login.TabIndex = 0;
            // 
            // bt_Join
            // 
            this.bt_Join.Location = new System.Drawing.Point(330, 414);
            this.bt_Join.Name = "bt_Join";
            this.bt_Join.Size = new System.Drawing.Size(55, 55);
            this.bt_Join.TabIndex = 7;
            this.bt_Join.Text = "가입";
            this.bt_Join.UseVisualStyleBackColor = true;
            this.bt_Join.Click += new System.EventHandler(this.bt_Join_Click);
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(86, 513);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(171, 35);
            this.tb_Port.TabIndex = 6;
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(269, 479);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(55, 55);
            this.bt_Connect.TabIndex = 5;
            this.bt_Connect.Text = "연결";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(86, 479);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(171, 35);
            this.tb_IP.TabIndex = 4;
            // 
            // pb_Cover
            // 
            this.pb_Cover.BackColor = System.Drawing.Color.Transparent;
            this.pb_Cover.Image = global::messanger.Properties.Resources.logo;
            this.pb_Cover.Location = new System.Drawing.Point(82, 137);
            this.pb_Cover.Margin = new System.Windows.Forms.Padding(6);
            this.pb_Cover.Name = "pb_Cover";
            this.pb_Cover.Size = new System.Drawing.Size(242, 271);
            this.pb_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cover.TabIndex = 3;
            this.pb_Cover.TabStop = false;
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(269, 414);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(6);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(55, 55);
            this.bt_Login.TabIndex = 2;
            this.bt_Login.Text = "로그인";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // tb_Pw
            // 
            this.tb_Pw.ForeColor = System.Drawing.Color.Gray;
            this.tb_Pw.Location = new System.Drawing.Point(86, 447);
            this.tb_Pw.Margin = new System.Windows.Forms.Padding(6);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(171, 35);
            this.tb_Pw.TabIndex = 1;
            this.tb_Pw.Text = "암호";
            this.tb_Pw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Pw_MouseClick);
            this.tb_Pw.Leave += new System.EventHandler(this.tb_Pw_Leave);
            // 
            // tb_Id
            // 
            this.tb_Id.ForeColor = System.Drawing.Color.Gray;
            this.tb_Id.Location = new System.Drawing.Point(86, 414);
            this.tb_Id.Margin = new System.Windows.Forms.Padding(6);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(171, 35);
            this.tb_Id.TabIndex = 0;
            this.tb_Id.Text = "계정";
            this.tb_Id.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Id_MouseClick);
            this.tb_Id.Leave += new System.EventHandler(this.tb_Id_Leave);
            // 
            // pn_basic
            // 
            this.pn_basic.BackColor = System.Drawing.Color.DarkCyan;
            this.pn_basic.Controls.Add(this.pb_makeChattingRoom);
            this.pn_basic.Controls.Add(this.pb_search);
            this.pn_basic.Controls.Add(this.pb_setting);
            this.pn_basic.Controls.Add(this.pn_dialogue);
            this.pn_basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_basic.Location = new System.Drawing.Point(0, 0);
            this.pn_basic.Margin = new System.Windows.Forms.Padding(6);
            this.pn_basic.Name = "pn_basic";
            this.pn_basic.Size = new System.Drawing.Size(400, 600);
            this.pn_basic.TabIndex = 1;
            // 
            // pb_makeChattingRoom
            // 
            this.pb_makeChattingRoom.BackColor = System.Drawing.Color.Transparent;
            this.pb_makeChattingRoom.Image = global::messanger.Properties.Resources.plus;
            this.pb_makeChattingRoom.Location = new System.Drawing.Point(276, 37);
            this.pb_makeChattingRoom.Margin = new System.Windows.Forms.Padding(6);
            this.pb_makeChattingRoom.Name = "pb_makeChattingRoom";
            this.pb_makeChattingRoom.Size = new System.Drawing.Size(40, 40);
            this.pb_makeChattingRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_makeChattingRoom.TabIndex = 3;
            this.pb_makeChattingRoom.TabStop = false;
            this.pb_makeChattingRoom.Click += new System.EventHandler(this.pb_makeChattingRoom_Click);
            this.pb_makeChattingRoom.MouseEnter += new System.EventHandler(this.pb_makeChattingRoom_MouseEnter);
            this.pb_makeChattingRoom.MouseLeave += new System.EventHandler(this.pb_makeChattingRoom_MouseLeave);
            // 
            // pb_search
            // 
            this.pb_search.BackColor = System.Drawing.Color.Transparent;
            this.pb_search.Image = global::messanger.Properties.Resources.search;
            this.pb_search.Location = new System.Drawing.Point(318, 37);
            this.pb_search.Margin = new System.Windows.Forms.Padding(6);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(40, 40);
            this.pb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_search.TabIndex = 2;
            this.pb_search.TabStop = false;
            this.pb_search.Click += new System.EventHandler(this.pb_search_Click);
            this.pb_search.MouseEnter += new System.EventHandler(this.pb_search_MouseEnter);
            this.pb_search.MouseLeave += new System.EventHandler(this.pb_search_MouseLeave);
            // 
            // pb_setting
            // 
            this.pb_setting.BackColor = System.Drawing.Color.Transparent;
            this.pb_setting.Image = global::messanger.Properties.Resources.setting;
            this.pb_setting.Location = new System.Drawing.Point(360, 37);
            this.pb_setting.Margin = new System.Windows.Forms.Padding(6);
            this.pb_setting.Name = "pb_setting";
            this.pb_setting.Size = new System.Drawing.Size(40, 40);
            this.pb_setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_setting.TabIndex = 1;
            this.pb_setting.TabStop = false;
            this.pb_setting.Click += new System.EventHandler(this.pb_setting_Click);
            this.pb_setting.MouseEnter += new System.EventHandler(this.pb_setting_MouseEnter);
            this.pb_setting.MouseLeave += new System.EventHandler(this.pb_setting_MouseLeave);
            // 
            // pn_dialogue
            // 
            this.pn_dialogue.AutoScroll = true;
            this.pn_dialogue.BackColor = System.Drawing.Color.RoyalBlue;
            this.pn_dialogue.Location = new System.Drawing.Point(0, 78);
            this.pn_dialogue.Margin = new System.Windows.Forms.Padding(6);
            this.pn_dialogue.Name = "pn_dialogue";
            this.pn_dialogue.Padding = new System.Windows.Forms.Padding(10);
            this.pn_dialogue.Size = new System.Drawing.Size(400, 522);
            this.pn_dialogue.TabIndex = 0;
            // 
            // pn_board
            // 
            this.pn_board.BackColor = System.Drawing.Color.IndianRed;
            this.pn_board.Controls.Add(this.lb_Logo);
            this.pn_board.Controls.Add(this.pb_Logo);
            this.pn_board.Controls.Add(this.pb_Minimize);
            this.pn_board.Controls.Add(this.pb_Close);
            this.pn_board.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_board.Location = new System.Drawing.Point(0, 0);
            this.pn_board.Name = "pn_board";
            this.pn_board.Size = new System.Drawing.Size(400, 35);
            this.pn_board.TabIndex = 9;
            this.pn_board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseDown);
            this.pn_board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseMove);
            // 
            // lb_Logo
            // 
            this.lb_Logo.AutoSize = true;
            this.lb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_Logo.Font = new System.Drawing.Font("휴먼모음T", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Logo.ForeColor = System.Drawing.Color.Black;
            this.lb_Logo.Location = new System.Drawing.Point(31, 3);
            this.lb_Logo.Name = "lb_Logo";
            this.lb_Logo.Size = new System.Drawing.Size(587, 65);
            this.lb_Logo.TabIndex = 3;
            this.lb_Logo.Text = "Messenger For Team";
            this.lb_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseDown);
            this.lb_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseMove);
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
            this.pb_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseDown);
            this.pb_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_board_MouseMove);
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
            // Basic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.pn_board);
            this.Controls.Add(this.pn_login);
            this.Controls.Add(this.pn_basic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Basic";
            this.Text = "Messanger";
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cover)).EndInit();
            this.pn_basic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_makeChattingRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_setting)).EndInit();
            this.pn_board.ResumeLayout(false);
            this.pn_board.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pn_login;
        private System.Windows.Forms.TextBox tb_Pw;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Panel pn_basic;
        private System.Windows.Forms.PictureBox pb_search;
        private System.Windows.Forms.PictureBox pb_setting;
        private System.Windows.Forms.Panel pn_dialogue;
        private System.Windows.Forms.PictureBox pb_Cover;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.Panel pn_board;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.Label lb_Logo;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button bt_Join;
        private System.Windows.Forms.PictureBox pb_makeChattingRoom;
    }
}

