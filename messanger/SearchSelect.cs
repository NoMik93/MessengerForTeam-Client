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

namespace messanger
{
    public partial class SearchSelect : Form
    {
        ChatInfo chatInfo = new ChatInfo();
        public Basic parent;

        public SearchSelect()
        {
            InitializeComponent();
        }

        private void bt_JoinRoom_Click(object sender, EventArgs e)
        {
            chatInfo.Type = (int)PacketType.채팅방가입; // 채팅방 가입은 chatText인데, chatText에는 PW받는 게 없어서 chatInfo 사용
            chatInfo.chatPW = tb_Password.Text;
            parent.send(Packet.Serialize(chatInfo));
            if (tb_Password.Text.ToString() == chatInfo.chatPW.ToString())
            {
                // return;//방에 가입했다고 서버에 전송으로 변경.
                parent.Invoke((MethodInvoker)delegate () { parent.addChatRoom(chatInfo); });
            }
            this.Close();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setChatInfo(ChatInfo chatInfo)
        {
            this.chatInfo = chatInfo;
        }

        public void setLabel()
        {
            lb_Leader.Text = chatInfo.leaderID;
            lb_StartDate.Text = chatInfo.chatStartDate.Substring(0, 10);
            lb_EndDate.Text = chatInfo.chatEndDate.Substring(0, 10);
            lb_Intro.Text = chatInfo.chatIntro;
        }

        private void tb_Password_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Password.Text = "";
            tb_Password.ForeColor = Color.Black;
        }
    }
}
