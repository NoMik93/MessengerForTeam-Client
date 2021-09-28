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
    public partial class JoinUser : Form
    {
        public Basic parent;

        public JoinUser()
        {
            InitializeComponent();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Join_Click(object sender, EventArgs e)
        {
            //회원가입
            Join join = new Join();
            join.Type = (int)PacketType.회원가입;
            join.m_strID = tb_ID.Text;
            join.m_strPass = tb_PW.Text;
            join.m_strName = tb_Name.Text;
            parent.send(Packet.Serialize(join));
        }
    }
}
