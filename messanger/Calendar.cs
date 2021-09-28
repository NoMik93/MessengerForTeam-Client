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
    public partial class Calendar : Form
    {
        string userID, chatID;
        Point start;
        static Label nowLabel = new Label();

        public Basic parent;

        public Calendar()
        {
            InitializeComponent();
        }

        public void Calendar_Load(CalendarInfo calendarInfo)
        {
            switch (calendarInfo.Day)
            {
                case "Mon":
                    switch(calendarInfo.Time)
                    {
                        case "1":
                            lb_Mon1.Text = calendarInfo.Text;
                            break;
                        case "2":
                            lb_Mon2.Text = calendarInfo.Text;
                            break;
                        case "3":
                            lb_Mon3.Text = calendarInfo.Text;
                            break;
                        case "4":
                            lb_Mon4.Text = calendarInfo.Text;
                            break;
                        case "5":
                            lb_Mon5.Text = calendarInfo.Text;
                            break;
                        case "6":
                            lb_Mon6.Text = calendarInfo.Text;
                            break;
                        case "7":
                            lb_Mon7.Text = calendarInfo.Text;
                            break;
                        case "8":
                            lb_Mon8.Text = calendarInfo.Text;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Tue":
                    switch (calendarInfo.Time)
                    {
                        case "1":
                            lb_Tue1.Text = calendarInfo.Text;
                            break;
                        case "2":
                            lb_Tue2.Text = calendarInfo.Text;
                            break;
                        case "3":
                            lb_Tue3.Text = calendarInfo.Text;
                            break;
                        case "4":
                            lb_Tue4.Text = calendarInfo.Text;
                            break;
                        case "5":
                            lb_Tue5.Text = calendarInfo.Text;
                            break;
                        case "6":
                            lb_Tue6.Text = calendarInfo.Text;
                            break;
                        case "7":
                            lb_Tue7.Text = calendarInfo.Text;
                            break;
                        case "8":
                            lb_Tue8.Text = calendarInfo.Text;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Wed":
                    switch (calendarInfo.Time)
                    {
                        case "1":
                            lb_Wed1.Text = calendarInfo.Text;
                            break;
                        case "2":
                            lb_Wed2.Text = calendarInfo.Text;
                            break;
                        case "3":
                            lb_Wed3.Text = calendarInfo.Text;
                            break;
                        case "4":
                            lb_Wed4.Text = calendarInfo.Text;
                            break;
                        case "5":
                            lb_Wed5.Text = calendarInfo.Text;
                            break;
                        case "6":
                            lb_Wed6.Text = calendarInfo.Text;
                            break;
                        case "7":
                            lb_Wed7.Text = calendarInfo.Text;
                            break;
                        case "8":
                            lb_Wed8.Text = calendarInfo.Text;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Thu":
                    switch (calendarInfo.Time)
                    {
                        case "1":
                            lb_Thu1.Text = calendarInfo.Text;
                            break;
                        case "2":
                            lb_Thu2.Text = calendarInfo.Text;
                            break;
                        case "3":
                            lb_Thu3.Text = calendarInfo.Text;
                            break;
                        case "4":
                            lb_Thu4.Text = calendarInfo.Text;
                            break;
                        case "5":
                            lb_Thu5.Text = calendarInfo.Text;
                            break;
                        case "6":
                            lb_Thu6.Text = calendarInfo.Text;
                            break;
                        case "7":
                            lb_Thu7.Text = calendarInfo.Text;
                            break;
                        case "8":
                            lb_Thu8.Text = calendarInfo.Text;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Fri":
                    switch (calendarInfo.Time)
                    {
                        case "1":
                            lb_Fri1.Text = calendarInfo.Text;
                            break;
                        case "2":
                            lb_Fri2.Text = calendarInfo.Text;
                            break;
                        case "3":
                            lb_Fri3.Text = calendarInfo.Text;
                            break;
                        case "4":
                            lb_Fri4.Text = calendarInfo.Text;
                            break;
                        case "5":
                            lb_Fri5.Text = calendarInfo.Text;
                            break;
                        case "6":
                            lb_Fri6.Text = calendarInfo.Text;
                            break;
                        case "7":
                            lb_Fri7.Text = calendarInfo.Text;
                            break;
                        case "8":
                            lb_Fri8.Text = calendarInfo.Text;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Sat":
                    switch (calendarInfo.Time)
                    {
                        case "1":
                            lb_Sat1.Text = calendarInfo.Text;
                            break;
                        case "2":
                            lb_Sat2.Text = calendarInfo.Text;
                            break;
                        case "3":
                            lb_Sat3.Text = calendarInfo.Text;
                            break;
                        case "4":
                            lb_Sat4.Text = calendarInfo.Text;
                            break;
                        case "5":
                            lb_Sat5.Text = calendarInfo.Text;
                            break;
                        case "6":
                            lb_Sat6.Text = calendarInfo.Text;
                            break;
                        case "7":
                            lb_Sat7.Text = calendarInfo.Text;
                            break;
                        case "8":
                            lb_Sat8.Text = calendarInfo.Text;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Sun":
                    switch (calendarInfo.Time)
                    {
                        case "1":
                            lb_Sun1.Text = calendarInfo.Text;
                            break;
                        case "2":
                            lb_Sun2.Text = calendarInfo.Text;
                            break;
                        case "3":
                            lb_Sun3.Text = calendarInfo.Text;
                            break;
                        case "4":
                            lb_Sun4.Text = calendarInfo.Text;
                            break;
                        case "5":
                            lb_Sun5.Text = calendarInfo.Text;
                            break;
                        case "6":
                            lb_Sun6.Text = calendarInfo.Text;
                            break;
                        case "7":
                            lb_Sun7.Text = calendarInfo.Text;
                            break;
                        case "8":
                            lb_Sun8.Text = calendarInfo.Text;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public void setUserID(string userID)
        {
            this.userID = userID;
        }

        public void setChatID(string chatID)
        {
            this.chatID = chatID;
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pb_Minimize_MouseEnter(object sender, EventArgs e)
        {
            pb_Minimize.BackColor = Color.SkyBlue;
        }

        private void pb_Close_MouseEnter(object sender, EventArgs e)
        {
            pb_Close.BackColor = Color.SkyBlue;
        }

        private void pb_Minimize_MouseLeave(object sender, EventArgs e)
        {
            pb_Minimize.BackColor = Color.Transparent;
        }

        private void pb_Close_MouseLeave(object sender, EventArgs e)
        {
            pb_Close.BackColor = Color.Transparent;
        }

        private void pn_board_MouseDown(object sender, MouseEventArgs e)
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

        public void addCalendar(CalendarInfo calendarInfo)
        {
            nowLabel.Text = calendarInfo.Text;
        }

        public void delCalendar()
        {
            nowLabel.Text = "";
        }

        private void lb_DoubleClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            nowLabel = label;
            string[] tag = label.Tag.ToString().Split(',');
            CalendarEdit calendarEdit = new CalendarEdit();
            calendarEdit.parent = this.parent;
            calendarEdit.calendar = this;
            calendarEdit.StartPosition = FormStartPosition.CenterParent;
            calendarEdit.setChatID(chatID);
            calendarEdit.setDay(tag[0]);
            calendarEdit.setTime(tag[1]);
            calendarEdit.setLabel();
            calendarEdit.setTextBox(label.Text.ToString());

            calendarEdit.ShowDialog();
        }
    }
}
