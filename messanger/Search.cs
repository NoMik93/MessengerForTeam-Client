using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketClass;
using System.Collections;

namespace messanger
{
    public partial class Search : Form
    {
        ArrayList rooms = new ArrayList();
        int chatRoom_num = 0;
        string userID;

        public Basic parent;

        public Search()
        {
            InitializeComponent();
        }

        public void Search_Load()
        {
            int index = 0;
            UserID userId = new UserID();
            userId.Type = (int)PacketType.전체채팅방검색;
            userId.m_strID = userID;

            parent.send(Packet.Serialize(userId));

            foreach (ChatInfo room in rooms)
            {
                addRoom(room, index);
                index++;
            }
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Search_Enter(object sender, EventArgs e)
        {
            tb_Search.Text = "";
            tb_Search.ForeColor = Color.Black;
        }

        private void tb_Search_Leave(object sender, EventArgs e)
        {
            if(tb_Search.Text == "")
            {
                tb_Search.Text = "프로젝트 또는 팀장의 이름을 입력하세요.";
                tb_Search.ForeColor = Color.Gray;
            }
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            if (tb_Search.Text != "" && tb_Search.Text != "프로젝트 또는 팀장의 이름을 입력하세요.")
            {
                ChatTitle chatTitle = new ChatTitle();
                chatTitle.Type = (int)PacketType.제목채팅방검색;
                chatTitle.chatTitle = tb_Search.Text;

                parent.send(Packet.Serialize(chatTitle));

                findRoom(tb_Search.Text.ToString()); // ??
            }
        }

        public void addRooms(ChatInfo chatInfo)
        {
            rooms.Add(chatInfo);
        }

        private void findRoom(string name)
        {
            chatRoom_num = 0;
            int index = 0;
            foreach (ChatInfo room in rooms)
            {
                if (room.chatTitle == name || room.leaderID == name)
                    addRoom(room, index);
                index++;
            }
        }

        private void addRoom(ChatInfo chatInfo, int index)
        {
            chatRoom_num++;
            PictureBox pb = new PictureBox();
            pb.Name = chatInfo.chatTitle;
            pb.Size = new Size(180, 180);
            pb.Tag = index;
            pb.Image = messanger.Properties.Resources.ChattingRoom;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Location = chatRoomLocation(chatRoom_num);

            Label title = makeTitleLabel(chatInfo.chatTitle);
            title.Click += new EventHandler(roomLabel_Click);
            pb.Controls.Add(title);

            Label startDate = makeStartDateLabel(chatInfo.chatStartDate);
            startDate.Click += new EventHandler(roomLabel_Click);
            pb.Controls.Add(startDate);

            Label wave = makeWaveLabel();
            wave.Click += new EventHandler(roomLabel_Click);
            pb.Controls.Add(wave);

            Label EndDate = makeEndDateLabel(chatInfo.chatStartDate);
            EndDate.Click += new EventHandler(roomLabel_Click);
            pb.Controls.Add(EndDate);

            pb.Click += new EventHandler(room_Click);
            pb.MouseEnter += new EventHandler(room_MouseEnter);
            pb.MouseLeave += new EventHandler(room_MouseLeave);
            pn_SearchResult.Controls.Add(pb);

            pb.Update();
        }

        private Label makeTitleLabel(string title)
        {
            Label label = new Label();
            label.Text = title;
            label.ForeColor = Color.SkyBlue;
            label.BackColor = Color.Transparent;
            label.Location = new Point(10, 20);
            label.MaximumSize = new Size(170, 0);
            label.AutoSize = true;
            return label;
        }

        private Label makeStartDateLabel(string startDate)
        {
            Label label = new Label();
            label.Text = startDate.Substring(0, 10);
            label.ForeColor = Color.SkyBlue;
            label.BackColor = Color.Transparent;
            label.Location = new Point(30, 90);
            label.MaximumSize = new Size(170, 0);
            label.AutoSize = true;
            return label;
        }

        private Label makeEndDateLabel(string EndDate)
        {
            Label label = new Label();
            label.Text = EndDate.Substring(0, 10);
            label.ForeColor = Color.SkyBlue;
            label.BackColor = Color.Transparent;
            label.Location = new Point(70, 130);
            label.MaximumSize = new Size(170, 0);
            label.AutoSize = true;
            return label;
        }

        private Label makeWaveLabel()
        {
            Label label = new Label();
            label.Text = "~";
            label.ForeColor = Color.SkyBlue;
            label.BackColor = Color.Transparent;
            label.Location = new Point(80, 110);
            label.MaximumSize = new Size(170, 0);
            label.AutoSize = true;
            return label;
        }

        private Point chatRoomLocation(int num)
        {
            Point point = new Point();
            if (num % 2 == 1)
                point.X = 10;
            else
                point.X = 195;
            point.Y = 10 + (((int)((num - 1) / 2)) * 190);
            return point;
        }

        public void setUserID(string userID)
        {
            this.userID = userID;
        }

        private void roomLabel_Click(object sender, EventArgs e) // 내부 라벨을 클릭하는 경우에도 똑같이 취급
        {
            Label label = sender as Label;
            room_Click(label.Parent, e);
        }

        private void room_Click(object sender, EventArgs e) // 방을 클릭하는 경우 방 설명 띄우기
        {
            PictureBox pb = sender as PictureBox;
            ChatInfo chatInfo = rooms[int.Parse(pb.Tag.ToString())] as ChatInfo;

            SearchSelect searchSelect = new SearchSelect();
            searchSelect.parent = this.parent;
            searchSelect.StartPosition = FormStartPosition.CenterParent;
            searchSelect.setChatInfo(chatInfo);
            searchSelect.setLabel();

            searchSelect.ShowDialog();
        }

        private void room_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Image = messanger.Properties.Resources.ChattingRoom_selected;
        }

        private void room_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Image = messanger.Properties.Resources.ChattingRoom;
        }
    }
}
