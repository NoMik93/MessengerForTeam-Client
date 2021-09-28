using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Net;
using System.Threading;
using PacketClass;


//Invoke((MethodInvoker)delegate () { //여기다 넣기 });

namespace messanger
{
    public partial class Basic : Form
    {
        clientWithID _client;
        Thread clientHendler;

        TcpClient client = new TcpClient();

        NetworkStream stream;
        public static string result;

        Point start;

        public string userID;

        public ChattingRoom chattingRoom;
        public Calendar calendar;
        public Search search;
        public Setting setting;
        public JoinUser joinUser;
        public MakeChattingRoom makeChattingRoom;
        public ChatInfo chatinfo;

        int chatRoom_num = 0;

        public Basic()
        {
            InitializeComponent();
            pn_board.MouseWheel += new MouseEventHandler(pn_board_MouseWheelMove);

            CheckForIllegalCrossThreadCalls = false;
        }

        private void Basic_FormClosing(object sender, FormClosingEventArgs e) // 창닫기
        {
            if (_client._Client.Connected)
            {
                _client._Client.Close();
                clientHendler.Abort();
            }
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();

            userInfo.Type = (int)PacketType.로그인;
            userInfo.m_strID = tb_Id.Text;
            userInfo.m_strPass = tb_Pw.Text;

            send(Packet.Serialize(userInfo));
        }


        private void bt_Join_Click(object sender, EventArgs e)
        {
            joinUser = new JoinUser();
            joinUser.parent = this;
            joinUser.StartPosition = FormStartPosition.CenterParent;
            joinUser.ShowDialog();
        }

        private void pn_board_MouseWheelMove(object sender, MouseEventArgs e) // 마우스 휠로 스크롤 이동
        {
            if (e.Delta > 0)
                pn_board.AutoScrollPosition = new Point(0, pn_board.AutoScrollPosition.Y + 200);
            else
                pn_board.AutoScrollPosition = new Point(0, pn_board.AutoScrollPosition.Y - 200);
        }

        private void tb_Id_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Id.Text = "";
            tb_Id.ForeColor = Color.Black;
        }

        private void tb_Pw_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Pw.Text = "";
            tb_Pw.ForeColor = Color.Black;

        }

        private void pb_makeChattingRoom_Click(object sender, EventArgs e) // 채팅방 만들기 누르면
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            makeChattingRoom = new MakeChattingRoom();
            makeChattingRoom.parent = this;
            makeChattingRoom.StartPosition = FormStartPosition.CenterParent;
            makeChattingRoom.setLeaderID(userID);
            makeChattingRoom.setStartDate(date);
            makeChattingRoom.ShowDialog(); // 만들기 폼 보여줌
        }

        //버튼 클릭시, 서버에게 UserID 패킷 전송!!
        private void pb_search_Click(object sender, EventArgs e) // 방검색 들어가기
        {
            search = new Search();
            search.StartPosition = FormStartPosition.CenterParent;
            search.setUserID(userID);
            search.parent = this;
            search.Search_Load();
            search.ShowDialog();
        }

        private void pb_setting_Click(object sender, EventArgs e) // 설정창 띄우기
        {
            setting = new Setting();
            setting.StartPosition = FormStartPosition.CenterParent;
            setting.parent = this;
            setting.ShowDialog();
        }

        //서버에게 UserID 패킷 전송
        public void logout()
        {
            pn_login.Visible = true;
            tb_Id.Text = "계정";
            tb_Id.ForeColor = Color.Gray;
            tb_Pw.Text = "암호";
            tb_Pw.ForeColor = Color.Gray;
            pn_dialogue.Controls.Clear();
            chatRoom_num = 0;
            _client._Client.Close();

        }

        private void pb_makeChattingRoom_MouseEnter(object sender, EventArgs e)
        {
            pb_makeChattingRoom.BackColor = Color.SkyBlue;
        }

        private void pb_search_MouseEnter(object sender, EventArgs e)
        {
            pb_search.BackColor = Color.SkyBlue;
        }

        private void pb_setting_MouseEnter(object sender, EventArgs e)
        {
            pb_setting.BackColor = Color.SkyBlue;
        }

        private void pb_makeChattingRoom_MouseLeave(object sender, EventArgs e)
        {
            pb_makeChattingRoom.BackColor = Color.Transparent;
        }

        private void pb_search_MouseLeave(object sender, EventArgs e)
        {
            pb_search.BackColor = Color.Transparent;
        }

        private void pb_setting_MouseLeave(object sender, EventArgs e)
        {
            pb_setting.BackColor = Color.Transparent;
        }

        //버튼 클릭시, 서버와 연결!
        private void bt_Connect_Click(object sender, EventArgs e)
        {
            /*
            client.Connect(tb_IP.Text.ToString(), int.Parse(tb_Port.Text));
            stream = client.GetStream();*/
 
            if (tb_Port.Text == string.Empty)
                tb_Port.Text = "4000";
            try
            {
                _client = new clientWithID(new TcpClient());
                _client._Client.Connect(IPAddress.Parse(tb_IP.Text), Int32.Parse(tb_Port.Text));

                clientHendler = new Thread(new ThreadStart(ClientHandler));
                clientHendler.Start();
            }
            catch
            {
            }
        }

        private byte[] ObjectToBytes(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_board_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
        }

        private void pn_board_MouseMove(object sender, MouseEventArgs e) //윗부분 마우스 클릭해서 창 이동시키기
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - start.X, this.Location.Y + e.Y - start.Y);
            }
        }

        private void tb_Id_Leave(object sender, EventArgs e)
        {
            if(tb_Id.Text == "")
            {
                tb_Id.Text = "계정";
                tb_Id.ForeColor = Color.Gray;
            }
        }

        private void tb_Pw_Leave(object sender, EventArgs e)
        {
            if (tb_Pw.Text == "")
            {
                tb_Pw.Text = "암호";
                tb_Pw.ForeColor = Color.Gray;
            }
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
        public void addChatRoom(ChatInfo chatInfo) // 채팅방 추가
        {
            chatRoom_num++; // 갯수 증가
            PictureBox pb = new PictureBox(); // 픽처박스 생성
            pb.Name = chatInfo.chatTitle;
            pb.Tag = chatInfo.chatID; // 태그에 채팅방 ID 저장
            pb.Size = new Size(180, 180);
            pb.Image = messanger.Properties.Resources.ChattingRoom;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Location = chatRoomLocation(chatRoom_num);

            
            Label title = makeTitleLabel(chatInfo.chatTitle); // 제목 만들기
            title.Click += new EventHandler(roomLabel_Click);
            pb.Controls.Add(title);

            Label startDate = makeStartDateLabel(chatInfo.chatStartDate); // 시작일
            startDate.Click += new EventHandler(roomLabel_Click);
            pb.Controls.Add(startDate);

            Label wave = makeWaveLabel(); // 물결표시
            wave.Click += new EventHandler(roomLabel_Click);
            pb.Controls.Add(wave);

            Label EndDate = makeEndDateLabel(chatInfo.chatStartDate); // 종료일
            EndDate.Click += new EventHandler(roomLabel_Click);
            pb.Controls.Add(EndDate);

            pb.Click += new EventHandler(room_Click); //방 클릭 이벤트 추가
            pb.MouseEnter += new EventHandler(room_MouseEnter); // 색 변경 이벤트 추가
            pb.MouseLeave += new EventHandler(room_MouseLeave); // 색 변경 이벤트 추가

            CheckForIllegalCrossThreadCalls = false;
            pn_dialogue.Controls.Add(pb);
        }

        private Label makeTitleLabel(string title) // 방 제목 라벨 만들기
        {
            Label label = new Label();
            label.Text = title;
            label.ForeColor = Color.SkyBlue;
            label.BackColor = Color.Transparent;
            label.Location = new Point(10, 20);
            label.MaximumSize = new Size(170,0);
            label.AutoSize = true;
            return label;
        }

        private Label makeStartDateLabel(string startDate) // 시작일 라벨 만들기
        {
            Label label = new Label();
            label.Text = startDate.Substring(0,10);
            label.ForeColor = Color.SkyBlue;
            label.BackColor = Color.Transparent;
            label.Location = new Point(30, 90);
            label.MaximumSize = new Size(170, 0);
            label.AutoSize = true;
            return label;
        }

        private Label makeEndDateLabel(string EndDate) // 종료일 라벨 만들기
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

        private Label makeWaveLabel() // 물결표시 라벨 만들기
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

        private Point chatRoomLocation(int num) // 채팅방 갯수에 따라 위치 계산
        {
            Point point = new Point();
            if (num % 2 == 1)
                point.X = 10;
            else
                point.X = 195;
            point.Y = 10 + (((int)((num-1) / 2)) * 190);
            return point;
        }

        private void roomLabel_Click(object sender, EventArgs e) // 내부 라벨을 클릭하는 경우에도 똑같이 취급
        {
            Label label = sender as Label;
            room_Click(label.Parent, e);
        }

        
        private void room_Click(object sender, EventArgs e) // 방을 클릭하는 경우 방 들어가기
        {
            PictureBox pb = sender as PictureBox;
            string title = pb.Name;
            if (title.Length > 9)
                title = title.Substring(0, 9) + "...";
            chattingRoom = new ChattingRoom();
            chattingRoom.parent = this;
            chattingRoom.StartPosition = FormStartPosition.Manual;
            chattingRoom.Location = this.Location;
            chattingRoom.setUserID(userID);
            chattingRoom.setTitle(title);
            chattingRoom.setChatID(pb.Tag.ToString());
            chattingRoom.Show();

            ChatText chatText = new ChatText();
            chatText.Type = (int)PacketType.채팅방접속;
            chatText.chatID = pb.Tag.ToString();
            send(Packet.Serialize(chatText));
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

        //서버로 부터 패킷 받기 ***
        public void ClientHandler()
        {
            _client._Stream = _client._Client.GetStream();
            CheckForIllegalCrossThreadCalls = false;
            byte[] readBuffer = new byte[1024 * 4];
            int received = 0;

            while (_client._Client.Connected)
            {
                try
                {
                    received = _client._Stream.Read(readBuffer, 0, 1024 * 4);
                }
                catch (System.IO.IOException e)
                {
                    _client._Client.Close();
                    return;
                }
                catch
                {
                    return;
                }
                Packet packet = (Packet)Packet.Desserialize(readBuffer);

                switch (packet.Type)                    //////Data 시리얼라이즈 후 _sendbuffer에 넣고 SendData() 실행하면 전송가능////
                {
                    case (int)PacketType.채팅내용:
                        {
                            ChatContents(readBuffer);
                            break;
                        }
                    case (int)PacketType.채팅파일:
                        {
                            ChatFiles(readBuffer);
                            break;
                        }
                    case (int)PacketType.로그인:
                        {
                            Login(readBuffer);
                            break;
                        }
                    case (int)PacketType.회원가입:
                        {
                            Join(readBuffer);
                            break;
                        }
                    case (int)PacketType.회원탈퇴:
                        {
                            Withdrawal(readBuffer);
                            break;
                        }
                    case (int)PacketType.내채팅방검색:
                        {
                            MyChatRoomSearch(readBuffer);
                            break;
                        }
                    case (int)PacketType.전체채팅방검색:
                        {
                            AllChatRoomSearch(readBuffer);
                            break;
                        }
                    case (int)PacketType.제목채팅방검색:
                        {
                            TitleChatRoomSearch(readBuffer);
                            break;
                        }
                    case (int)PacketType.초대코드검색:
                        {
                            CodeChatRoomSearch(readBuffer);
                            break;
                        }
                    case (int)PacketType.채팅방가입:
                        {
                            JoinChatRoom(readBuffer);
                            break;
                        }
                    case (int)PacketType.채팅방생성:
                        {
                            MakeChatRoom(readBuffer);
                            break;
                        }
                    case (int)PacketType.채팅방일정:
                        {
                            ChatRoomCalendar(readBuffer);
                            break;
                        }
                    case (int)PacketType.일정추가:
                        {
                            AddCalendar(readBuffer);
                            break;
                        }
                    case (int)PacketType.일정삭제:
                        {
                            DeleteCalendar(readBuffer);
                            break;
                        }
                    case (int)PacketType.개인일정:
                        {
                            MyCalendar(readBuffer);
                            break;
                        }
                    case (int)PacketType.일정전송:
                        {
                            CalendarText(readBuffer);
                            break;
                        }
                    case (int)PacketType.채팅방전송:
                        {
                            ChatRoomText(readBuffer);
                            break;
                        }
                }

            }
            Thread.CurrentThread.Abort();
        }

        public void ChatContents(byte[] data)
        {
            ChatText chatText = (ChatText)Packet.Desserialize(data);
            string id = chatText.userID;
            string message = chatText.chatText;

            if (id == userID)
                Invoke((MethodInvoker)delegate () { chattingRoom.addMyChat(message); });
            else
                try
                {
                    Invoke((MethodInvoker)delegate () { chattingRoom.addChat(id, message); });
                }
                catch { }
                
        }

        public void ChatFiles(byte[] data)
        {

        }

        public void Login(byte[] data)
        {
            QueryResult queryResult = (QueryResult)Packet.Desserialize(data);
            if (queryResult.result == 0)
            {
                MessageBox.Show("로그인에 실패하였습니다.");
            }
            else
            {
                userID = tb_Id.Text;
                UserInfo info = new UserInfo();
                info.m_strID = userID;
                info.Type = (int)PacketType.내채팅방검색;
                byte[] senddata = Packet.Serialize(info);
                send(senddata);
                pn_login.Visible = false;
            }
        }

        public void Join(byte[] data)
        {
            QueryResult queryResult = (QueryResult)Packet.Desserialize(data);
            if (queryResult.result == 0)
                MessageBox.Show("가입에 실패하였습니다.");
            else
            {
                //MessageBox.Show("가입에 성공하였습니다.");
                joinUser.Close();
            }
        }

        public void Withdrawal(byte[] data)
        {
            QueryResult queryResult = (QueryResult)Packet.Desserialize(data);
            if (queryResult.result == 0)
                MessageBox.Show("탈퇴에 실패하였습니다.");
            else
            {
                MessageBox.Show("탈퇴에 성공하였습니다.");
                logout();
                setting.Close();
            }
        }

        public void MyChatRoomSearch(byte[] data)
        {
            ChatInfo chatInfo = (ChatInfo)Packet.Desserialize(data);
            
            Invoke((MethodInvoker)delegate () { addChatRoom(chatInfo); });
        }

        public void AllChatRoomSearch(byte[] data)
        {
            ChatInfo chatInfo = (ChatInfo)Packet.Desserialize(data);

            search.addRooms(chatInfo);
        }

        public void TitleChatRoomSearch(byte[] data)
        {
            ChatInfo chatInfo = (ChatInfo)Packet.Desserialize(data);
        }

        public void CodeChatRoomSearch(byte[] data)
        {
            ChatInfo chatInfo = (ChatInfo)Packet.Desserialize(data);
        }

        public void MakeChatRoom(byte[] data)
        {
            QueryResult queryResult = (QueryResult)Packet.Desserialize(data);
            if (queryResult.result == 0)
                MessageBox.Show("채팅방 생성에 실패하였습니다.");
            else
            {
                makeChattingRoom.Close();

                chatinfo.chatID = chatinfo.chatTitle;

                Invoke((MethodInvoker)delegate () { addChatRoom(chatinfo); });
            }
        }

        public void JoinChatRoom(byte[] data)
        {
            QueryResult queryResult = (QueryResult)Packet.Desserialize(data);
            if (queryResult.result == 0)
                MessageBox.Show("채팅방 가입에 실패하였습니다.");
            else
                MessageBox.Show("채팅방 가입에 성공하였습니다.");
        }

        public void ChatRoomCalendar(byte[] data)
        {
            CalendarInfo calendarInfo = (CalendarInfo)Packet.Desserialize(data);
            calendar.Calendar_Load(calendarInfo);
        }

        public void AddCalendar(byte[] data)
        {
            QueryResult queryResult = (QueryResult)Packet.Desserialize(data);
            if (queryResult.result == 0)
                MessageBox.Show("캘린더 추가에 실패하였습니다.");
            else
                MessageBox.Show("캘린더 추가에 성공하였습니다.");
        }

        public void DeleteCalendar(byte[] data)
        {
            QueryResult queryResult = (QueryResult)Packet.Desserialize(data);
            if (queryResult.result == 0)
                ;// MessageBox.Show("캘린더 삭제에 실패하였습니다.");
            else
                MessageBox.Show("캘린더 삭제에 성공하였습니다.");
        }

        public void MyCalendar(byte[] data)
        {
            CalendarInfo calendarInfo = (CalendarInfo)Packet.Desserialize(data);
        }

        public void CalendarText(byte[] data)
        {
            CalendarInfo calendarInfo = (CalendarInfo)Packet.Desserialize(data);
        }

        public void ChatRoomText(byte[] data)
        {
            ChatText chatText = (ChatText)Packet.Desserialize(data);
        }


        //클라이언트가 서버에 데이터 보내주기
        public void send(byte[] data)
        {
            try
            {
                _client._Stream.Write(data, 0, data.Length);
                _client._Stream.Flush();
            }
            catch
            {
                _client._Client.Close();
                //txtLog.Text += "send 에러발생 disconnect\r\n";
            }
        }

        public class clientWithID
        {
            public TcpClient _Client { get; set; }
            public string _ID { get; set; }
            public NetworkStream _Stream { get; set; }
            public clientWithID(TcpClient client)
            {
                this._Client = client;
            }
        }
    }
}