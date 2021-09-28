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
    public partial class CalendarEdit : Form
    {
        public Basic parent;
        public Calendar calendar;

        string chatID, day, time;

        public CalendarEdit()
        {
            InitializeComponent();
        }

        public void setText(string text)
        {
            tb_CalendarText.Text = text;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Edit_Click(object sender, EventArgs e) // 일정 추가
        {
            CalendarInfo calendarInfo = new CalendarInfo();
            calendarInfo.Type = (int)PacketType.일정추가;
            calendarInfo.chatID = chatID;
            calendarInfo.Day = day;
            calendarInfo.Time = time;
            calendarInfo.Text = tb_CalendarText.Text.ToString();

            parent.send(Packet.Serialize(calendarInfo));
            calendar.addCalendar(calendarInfo);
            this.Close();
        }

        private void bt_delete_Click(object sender, EventArgs e) // 일정 삭제
        {
            CalendarInfo calendarInfo = new CalendarInfo();
            calendarInfo.Type = (int)PacketType.일정삭제;
            calendarInfo.chatID = chatID;
            calendarInfo.Day = day;
            calendarInfo.Time = time;
            //calendarInfo.Text = tb_CalendarText.Text.ToString();

            parent.send(Packet.Serialize(calendarInfo));
            calendar.delCalendar();
            this.Close();
        }

        public void setChatID(string chatID)
        {
            this.chatID = chatID;
        }

        public void setDay(string day)
        {
            this.day = day;
        }

        public void setTime(string time)
        {
            this.time = time;
        }

        public void setLabel()
        {
            switch (day)
            {
                case "Mon":
                    lb_Day.Text = "월요일";
                    break;
                case "Tue":
                    lb_Day.Text = "화요일";
                    break;
                case "Wed":
                    lb_Day.Text = "수요일";
                    break;
                case "Thu":
                    lb_Day.Text = "목요일";
                    break;
                case "Fri":
                    lb_Day.Text = "금요일";
                    break;
                case "Sat":
                    lb_Day.Text = "토요일";
                    break;
                case "Sun":
                    lb_Day.Text = "일요일";
                    break;
            }
            switch (time)
            {
                case "1":
                    lb_Time.Text ="09:00~10:30";
                    break;
                case "2":
                    lb_Time.Text = "10:30~12:00";
                    break;
                case "3":
                    lb_Time.Text = "12:00~01:30";
                    break;
                case "4":
                    lb_Time.Text = "01:30~03:00";
                    break;
                case "5":
                    lb_Time.Text = "03:00~04:30";
                    break;
                case "6":
                    lb_Time.Text = "04:30~06:00";
                    break;
                case "7":
                    lb_Time.Text = "06:00~07:30";
                    break;
                case "8":
                    lb_Time.Text = "07:30~09:00";
                    break;
            }
        }

        public void setTextBox(string text)
        {
            tb_CalendarText.Text = text;
        }
    }
}
