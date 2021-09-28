using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketClass;

namespace messanger
{
    public partial class ChattingRoom : Form
    {
        Point start = new Point();
        Point end = new Point(0, 0);
        string userID = "이름 없음", chatID;
        //ChatText[]

        public Basic parent;
        public Calendar calendar;

        public ChattingRoom()
        {
            InitializeComponent();
            pn_chatting.MouseWheel += new MouseEventHandler(wheel_Move); // 마우스 휠로 스크롤 이동 추가

            CheckForIllegalCrossThreadCalls = false;
        }

        private void wheel_Move(object sender, MouseEventArgs e) // 마우스 휠로 스크롤 이동
        {
            Panel panel = sender as Panel;
            if (e.Delta < 0)
                if (panel.AutoScrollPosition.Y > 100)
                {
                    int y = panel.AutoScrollPosition.Y - 100;
                    panel.AutoScrollPosition = new Point(0, y);
                }
            else if (e.Delta > 0)
                    if (panel.AutoScrollPosition.Y < panel.Height - 100)
                    {
                        int y = panel.AutoScrollPosition.Y + 100;
                        panel.AutoScrollPosition = new Point(0, y);
                    }
        }

        private void pb_Close_Click(object sender, EventArgs e) // 창 닫기
        {
            this.Close();
        }

        private void pb_Minimize_Click(object sender, EventArgs e) // 창 최소화
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pb_Minimize_MouseEnter(object sender, EventArgs e) // 최소화 버튼 색 변경
        {
            pb_Minimize.BackColor = Color.SkyBlue;
        }

        private void pb_Close_MouseEnter(object sender, EventArgs e) // 닫기 버튼 색 변경
        {
            pb_Close.BackColor = Color.SkyBlue;
        }

        private void pb_Minimize_MouseLeave(object sender, EventArgs e) // 최소화 버튼 색 변경
        {
            pb_Minimize.BackColor = Color.Transparent;
        }

        private void pb_Close_MouseLeave(object sender, EventArgs e) // 닫기 버튼 색 변경
        {
            pb_Close.BackColor = Color.Transparent;
        }

        private void pn_board_MouseDown(object sender, MouseEventArgs e) //윗부분 클릭시 위치 저장
        {
            start = e.Location;
        }

        private void pn_board_MouseMove(object sender, MouseEventArgs e) //윗부분 마우스 클릭해서 창 이동시키기
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - start.X, this.Location.Y + e.Y - start.Y);
            }
        }

        public void addChat(string name,string message) // 내가 쓰지 않은 채팅 내용 추가
        {
            Panel panel = new Panel(); // 패널 만들기
            int line = (int)(message.Length / 19);
            panel.BackColor = Color.Transparent;
            panel.Size = new Size(383, (line * 12) + 40);
            panel.Location = end;
            end = new Point(0, end.Y + (line * 12) + 40);

            Label lb_name = new Label(); // 사람 이름 만들기
            lb_name.Text = name;
            lb_name.Location = new Point(5, 10);
            lb_name.MaximumSize = new Size(65, 0);
            lb_name.AutoSize = true;

            PictureBox pb = new PictureBox(); // 말풍선 만들기
            pb.Image = messanger.Properties.Resources.bulloon_SkyBlue;
            pb.Size = new Size(270, line * 12 + 30);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Location = new Point(70, 5);

            Label lb_message = new Label(); // 메세지 만들기
            lb_message.Text = message;
            lb_message.Location = new Point(30, 10);
            lb_message.MaximumSize = new Size(233, 0);
            lb_message.BackColor = Color.Transparent;
            lb_message.AutoSize = true;

            panel.Controls.Add(pb); // 말풍선 붙이고
            panel.Controls.Add(lb_name); // 사람이름 붙이고
            pb.Controls.Add(lb_message); // 말풍선에 메세지 붙여서

            Invoke((MethodInvoker)delegate () { pn_chatting.Controls.Add(panel); });// 패널을 채팅창에 추가
            //pn_chatting.AutoScrollPosition = new Point(0, pn_chatting.Height); // 새로 붙인 위치로 이동
        }

        public void addMyChat(string message) // 내가 쓴 채팅 내용 추가
        {
            Panel panel = new Panel(); // 패널 만들기
            int line = (int)(message.Length / 19);
            panel.BackColor = Color.Transparent;
            panel.Size = new Size(383, (line * 12) + 40);
            panel.Location = end;
            end = new Point(0, end.Y + (line * 12) + 40);

            Label lb_message = new Label(); // 메세지 만들기
            lb_message.Text = message;
            lb_message.Location = new Point(5, 10);
            lb_message.MaximumSize = new Size(233, 0);
            lb_message.AutoSize = true;

            PictureBox pb = new PictureBox(); // 말풍선 만들기
            pb.Image = messanger.Properties.Resources.bulloon_Blue;
            pb.Size = new Size(270, line * 12 + 30);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Location = new Point(30, 5);

            Label lb_name = new Label(); // 이름 만들기
            lb_name.Text = userID; // 이름은 내 ID
            lb_name.Location = new Point(313, 10);
            lb_name.MaximumSize = new Size(65, 0);
            lb_name.AutoSize = true;

            panel.Controls.Add(pb); // 말풍선 붙이고
            panel.Controls.Add(lb_name); // 사람이름 붙이고
            pb.Controls.Add(lb_message); // 말풍선에 메세지 붙여서

            pn_chatting.Controls.Add(panel); // 패널을 채팅창에 추가
            //pn_chatting.AutoScrollPosition = new Point(0, pn_chatting.Height); // 새로 붙인 위치로 이동
        }

        public void setTitle(string title) // 채팅방 제목 설정
        {
            lb_Title.Text = title;
        }

        public void setUserID(string name) // 내 ID 설정
        {
            userID = name;
        }

        public void setChatID(string chatID) // 채팅방 ID 설정
        {
            this.chatID = chatID;
        }

        private void pb_Calendar_Click(object sender, EventArgs e) // 캘린더 클릭하면 캘린더 새로 만들어서 열기
        {
            calendar = new Calendar();
            calendar.parent = this.parent;
            calendar.StartPosition = FormStartPosition.CenterScreen;
            calendar.setUserID(userID);
            calendar.setChatID(chatID);
            parent.calendar = calendar;
            calendar.Show();

            ChatInfo chatInfo = new ChatInfo(); //캘린더 열었으니 정보 달라고 서버에 요청
            chatInfo.Type = (int)PacketType.채팅방일정;
            chatInfo.chatID = this.chatID;
            parent.send(Packet.Serialize(chatInfo));

        }

        private void pb_Calendar_MouseEnter(object sender, EventArgs e) // 캘린더 버튼 색 변경
        {
            pb_Calendar.BackColor = Color.SkyBlue;
        }

        private void pb_Calendar_MouseLeave(object sender, EventArgs e) // 캘린더 버튼 색 변경
        {
            pb_Calendar.BackColor = Color.Transparent;
        }

        private void bt_send_Click(object sender, EventArgs e) // 보내기 버튼 누르면
        {
            addMyChat(tb_send.Text); // 채팅창에 내용 추가하고

            ChatText chatText = new ChatText();
            chatText.Type = (int)PacketType.채팅내용;
            chatText.chatText = tb_send.Text;
            chatText.chatID = chatID;
            chatText.userID = userID;

            parent.send(Packet.Serialize(chatText));

            tb_send.Text = "";
        }
    }
}
