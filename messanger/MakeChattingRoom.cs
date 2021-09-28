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
    public partial class MakeChattingRoom : Form
    {
        public Basic parent;

        public MakeChattingRoom()
        {
            InitializeComponent();
            dtp_EndDate.Value = DateTime.Now;
        }

        private void bt_Make_Click(object sender, EventArgs e)
        {
            DateTime dt = dtp_EndDate.Value;
            string month = dt.Month.ToString();

            month = (month.Length < 2) ? "0" + month : month;

            ChatInfo chatInfo = new ChatInfo();
            chatInfo.Type = (int)PacketType.채팅방생성;
            chatInfo.chatStartDate = tb_StartDate.Text + " 00:00:01";
            chatInfo.chatEndDate = dt.Year.ToString() + "-" + month + "-" + dt.Day.ToString() + " 00:00:01";
            chatInfo.chatIntro = tb_Intro.Text.ToString();
            chatInfo.chatTitle = tb_Title.Text;
            chatInfo.chatPW = tb_PW.Text.ToString();
            chatInfo.leaderID = tb_LeaderID.Text;

            parent.chatinfo = chatInfo;
            parent.send(Packet.Serialize(chatInfo));
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setLeaderID(string id)
        {
            tb_LeaderID.Text = id;
            tb_LeaderID.ReadOnly = true;
        }

        public void setStartDate(string date)
        {
            tb_StartDate.Text = date;
            tb_StartDate.ReadOnly = true;
        }
    }
}
