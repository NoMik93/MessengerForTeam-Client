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
    public partial class Setting : Form
    {
        public Basic parent;

        public Setting()
        {
            InitializeComponent();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            //로그아웃 서버 전송

            parent.logout();
            this.Close();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_leave_Click(object sender, EventArgs e) //회원탈퇴
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Type = (int)PacketType.회원탈퇴;
            userInfo.m_strID = parent.userID; // Basic 폼에서 UserID로 저장해놓은 것 가져오기
            parent.send(Packet.Serialize(userInfo));
        }
    }
}
