using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }

        //Gủi tin cho tất cả Client
        private void GuiTin_Click(object sender, EventArgs e)
        {
            foreach (Socket item in ClientList)
            {
                Send(item);
            }
            AddMessage(textBoxServer.Text);
            textBoxServer.Clear();
        }

        IPEndPoint IP;   //Tạo IP để phầm mền biết là phầm mền nào truyền tin đến
        Socket server;

        List<Socket> ClientList; //danh sách các client kết nối
        void Connect()
        {
            ClientList = new List<Socket>();
            //IP: địa chỉ sever
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {


                    while (true)
                    {

                        server.Listen(100);// đợi lắng nghe nghe hàng đợi kết nối (100 là hàng đợi tối đa 100 Client)
                        Socket client = server.Accept();
                        ClientList.Add(client);

                        Thread reveive = new Thread(Receive);
                        reveive.IsBackground = true;
                        reveive.Start(client);
                    }
                }
                catch // nếu Cố gắng lắng nghe không được thì 
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }


        //Đóng kết nối
        void close()
        {
            server.Close();
        }


        //Gủi tin
        void Send(Socket client)
        {
            string Name = textBoxNameServer.Text;
            if (client!=null && textBoxServer.Text != string.Empty)
            {
                if (Name != null)
                {
                    client.Send(Serialize(Name + ":" + textBoxServer.Text));
                }
                else if (Name == null)
                {
                    client.Send(Serialize(textBoxServer.Text));
                }

               
                
            }
        }

        //Nhận tin
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {


                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);

                    foreach (Socket item in ClientList) // vòng lặp để nhận các tin nhắn đến từ nhiều client
                    {
                        if (item != null && item != client)
                        {


                            item.Send(Serialize(message));
                        }   

                    }
                        AddMessage(message);
                
                }
            }
            catch
            {
                ClientList.Remove(client);
                client.Close();
            }
        }


        //hàm cập nhập thời gian
        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            
        
        }



        //add tin lên text box
        void AddMessage(string message)
        {
          
            listViewServer.Items.Add(new ListViewItem() { Text = message + " " + "Vào lúc:" + " " + labelTime.Text });

        }

        //Phân mảnh (Chuyển các ký tự thành mảng byte để truyền tin đi)

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj); // phân mảnh tin
            return stream.ToArray(); // trả về 1 mảng byte
        }
        //Gom mảnh (Gom mảng byte lại để xử lý, gửi và nhận tin)
        object Deserialize(byte[] data)
        {

            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        //Hàm chạy timer khi khởi động chương trình
        private void Server_Load(object sender, EventArgs e)
        {
            timerTime.Enabled = true;
        }


        //Đóng kết nối khi đóng form
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();

        }

        
    }
}
