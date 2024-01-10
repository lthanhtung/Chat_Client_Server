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
            KhoitaoBtnEmoji();

            
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
        private bool SendMes;


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
               
                SendMes = true;

                
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
                    SendMes = false;

                    //Gọi hàm có chức thêm tin nhắn lên ListView để xem tin nhắn

                    parts = message.Split(':');
                    receivedName = parts[0];
                    receivedMessage = parts[1];

                    AddMessage(message);

                   



                    
                }
            }
            catch
            {
                close();
            }
        }

        //biến thực hiện tách tên
        string[] parts;
        string receivedName;
        string receivedMessage ;


        //Thêm tin nhắn lên text box
        void AddMessage(string message)
        {
            

            //Lấy tên client
            listViewCLient1.Columns[0].Text = receivedName;
            


            ListViewItem item1 = new ListViewItem("");
            
            item1.SubItems.Add( "[" + labelTime.Text +  "]"   + ":"   +     message);
           


            ListViewItem item2 = new ListViewItem(  "[" +   labelTime.Text + "]"   +":"   +  receivedMessage);
           // item2.SubItems.Add(message);
            item2.SubItems.Add("");
            

            if (SendMes == true)
            {
                listViewCLient1.Items.Add(item1);

            }
            else
            {
                listViewCLient1.Items.Add(item2);
            }
            //listViewCLient1.Items.Add(new ListViewItem() { Text = message });












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


        //Phần Emoji
        private List<string> ListEmoji = new List<string>
        {
            "😊", "👍", "❤️", "🎉", "🌟"
        };

       private void KhoitaoBtnEmoji()
        {
            foreach (string item in ListEmoji)
            {
                Button BtnEmoji = new Button
                {

                    Text = item,
                    Font = new System.Drawing.Font("Segoe UI Emoji", 12),
                    Size = new System.Drawing.Size(30,30),
                    Margin = new System.Windows.Forms.Padding(5)
                };
                BtnEmoji.Click += buttonEmoji_Click;
                flowLayoutPanel1.Controls.Add(BtnEmoji);

            }
        }





        private void buttonEmoji_Click(object sender, EventArgs e)
        {
            if (sender is Button BtnEmoji)
            {
                string SelectEmoji = BtnEmoji.Text;
                textBoxClient.AppendText(SelectEmoji);
            }
        }

        //hàm lấy thời gian 
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");

        }







        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBoxNameClient.Text;
            listViewCLient1.Columns[1].Text = "Me";
            textBoxNameClient.Enabled = false;
            textBoxNameClient.Visible = false;
            bnt_DatTen.Visible = false;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            timerTime.Enabled = true;
        }
    }
}
