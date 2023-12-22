using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

            Connect();
        }
        //Gủi tin đi
        private void GuiTin_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(textBoxClient.Text);
        }

        //Cần:
        /* Socket để các client có thể kết nối đến server
         * IP để gủi và nhận tin
         */
        IPEndPoint IP;   //Tạo IP để phầm mền biết là phầm mền nào truyền tin đến
        Socket client;
        //Kết nối sever
        void Connect()
        {
            //IP: địa chỉ sever
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);

            }
            catch
            {
                MessageBox.Show("Không thể kết nối sever!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //tạo luồng ngồi lắng nghe
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

        }
        //Đóng kết nối
        void close()
        {
            client.Close();
        }

        //Gủi tin
        void Send()
        {
            string Name = textBoxNameClient.Text;
            if (textBoxClient.Text != string.Empty)
            {
                if (Name != null)
                {


                    client.Send(Serialize(Name + ":" + textBoxClient.Text));
                }
                else
                {
                    client.Send(Serialize(textBoxClient.Text));
                }
            }
          

        }

        //nhận tin
        void Receive()
        {

            try
            {
                while (true)
                {


                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);

                    AddMessage(message);
                }
            }
            catch
            {
                close();
            }
        }


        //add tin lên text box
        void AddMessage(string message)
        {
            listViewCLient.Items.Add(new ListViewItem() { Text = message });

            textBoxClient.Clear();


        }
        //Phân mảnh (Chuyển các ký tự thành mảng byte để truyền tin đi

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj); // phân mảnh tin
            return stream.ToArray(); // trả về 1 mảng byte
        }

        //Gom mảnh (Gom mảng byte lại để xử lý gửi và nhận tin)
        object Deserialize(byte[] data)
        {

            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }
    }
}
