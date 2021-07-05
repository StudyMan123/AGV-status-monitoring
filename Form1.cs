using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVS
{
    public partial class Form1 : Form
    {
        public Socket mysocket = null;
        byte[] TCPBuffer = new byte[32];//缓存数据的数组
        PacketRecordList pack = null;
        private string STR = null;
        
        string[] lines = System.IO.File.ReadAllLines("texttxt.txt");

        #region 计算屏幕无操作时间
        [StructLayout(LayoutKind.Sequential)]
        struct LASTINPUTINFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public uint dwTime;
        }
        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        static long GetLastInputTime()
        {
            LASTINPUTINFO vLastInputInfo = new LASTINPUTINFO();
            vLastInputInfo.cbSize = Marshal.SizeOf(vLastInputInfo);
            if (!GetLastInputInfo(ref vLastInputInfo)) return 0;
            return Environment.TickCount - (long)vLastInputInfo.dwTime;
        }
        #endregion
        public Socket Mysocket
        {
            get
            {
                return mysocket;
            }
            set
            {
                mysocket = value;
            }
        }
        public byte[] tcpbuffer
        {
            get
            {
                return TCPBuffer;
            }
            set
            {
                TCPBuffer = value;
            }
        }
        public PacketRecordList Pack
        {
            get
            {
                return pack;
            }
            set
            {
                pack = value;
            }
        }
        public string AGVcombox
        {
            get { return AGVcomboBox.Text; }
            set { AGVcomboBox.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
            string localip = GetLocalIP();
            IPbox.Text = localip;  
        }
        
        internal Dictionary<string, Form3> Useredite
        {
            get
            {
                return userEdite;
            }
            set
            {
                userEdite = value;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void warning_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {   
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            label3.Text = DateTime.Now.ToString("HH:mm:ss");

            #region 报警信息
            warning.Items.Clear();
            if (GetLastInputTime() / 1000 > 180)
            {
               
                panel5.Visible = true;
               
            }
            #endregion
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.Location.X - this.oldX;
                //新的鼠标位置                
                this.Top += e.Location.Y - this.oldY;
            }
        }
        private int oldX = 0;
        private int oldY = 0;
        private Dictionary<string, Form3> userEdite;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.oldX = e.Location.X;
                //鼠标原来位置                
                this.oldY = e.Location.Y;
            }
        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            if (connectbutton.Text == "连接")
            {
                if (string.IsNullOrEmpty(IPbox.Text) == false && string.IsNullOrEmpty(Combox.Text) == false)
                {
                    try
                    {
                        IPAddress ipAddress = IPAddress.Parse(IPbox.Text);//获取IP地址
                        int Port = Convert.ToInt32(Combox.Text);          //获取端口号

                        mysocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        mysocket.BeginConnect(ipAddress, Port, new AsyncCallback(ConnectedCallback), mysocket);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("IP地址或端口号错误!", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("IP地址或端口号错误!", "提示");
                }
            }
        }
        public void ConnectedCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            try
            {
                socket.EndConnect(ar);
                socket.BeginReceive(TCPBuffer, 0, TCPBuffer.Length, 0, new AsyncCallback(ReadCallback), socket);

                Invoke((new Action(() =>
                {
                    MessageBox.Show("成功连接AGV", "提示");
                })));
            }
            catch (Exception e)
            {
                Invoke((new Action(() =>
                {
                    MessageBox.Show("连接失败", "警告");
                })));
            }
        }
        public void ReadCallback(IAsyncResult ar)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Socket socket = (Socket)ar.AsyncState;//获取链接的Socket
            int CanReadLen = socket.EndReceive(ar);//结束异步读取回调,获取读取的数据个数

            if (CanReadLen > 0)
            {
                string str = Encoding.Default.GetString(TCPBuffer, 0, CanReadLen);//Byte值根据ASCII码表转为 String
                Invoke((new Action(() => //C# 3.0以后代替委托的新方法
                {
                    //ReceiveText.AppendText(byteToHexStr(TCPBuffer, CanReadLen));
                })));

                //设置异步读取数据,接收的数据缓存到TCPBuffer,接收完成跳转ReadCallback函数
                socket.BeginReceive(TCPBuffer, 0, TCPBuffer.Length, 0, new AsyncCallback(ReadCallback), socket); 
                if(TCPBuffer[4] == 0X21)
                {
                    warning.Items.Add(new ListViewItem(new string[] { "正常", DateTime.Now.ToString() }));
                }
                if (TCPBuffer[3] == 0X20)
                {
                    warning.Items.Add(new ListViewItem(new string[] { "出轨", DateTime.Now.ToString() }));
                }
            }
            else//异常
            {
                Invoke((new Action(() => //C# 3.0以后代替委托的新方法
                {
                    MessageBox.Show("异常断开", "提示");//对话框追加显示数据
                })));
                try
                {
                    mysocket.BeginDisconnect(false, null, null);//断开连接
                }
                catch (Exception) { }
            }
        }
        public static string GetLocalIP()
        {
            IPAddress loacl_ip = null;
            try
            {
                IPAddress[] ips;
                ips = Dns.GetHostAddresses(Dns.GetHostName());
                loacl_ip = ips.First(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                return loacl_ip.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void LstTxtItem(string item)
        {
            if (AGVcomboBox.Items.Contains(item))
            {
                MessageBox.Show("AGV编号重复，请重新输入！", "警告");
                return;
            }
            else
            {
                AGVcomboBox.Items.Add(item);
                MessageBox.Show("添加成功！", "提示");
            }

        }
        public void LstComBox(string strcode)
        {
            AGVcomboBox.Items.Add(strcode);
            
        }

        public void LstAgvIp(string items)
        {
            IPbox.AppendText(items);
        }
        public void LstAgvCom(string itemss)
        {
            IPbox.AppendText(itemss);
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Form3 Add = new Form3(this,pack);
            Add.Setlabel3("请输入要添加的AGV编号");
            Add.Show();
        }

        private void Deletbutton_Click(object sender, EventArgs e)
        {
           
            //string DeletAgvCode = AGVcomboBox.SelectedItem.ToString();
            if (AGVcomboBox.SelectedItem == null)
            {
                MessageBox.Show("请先选中需要删除的AGV编号", "警告");
            }
            else
            {
                int selectIndex = AGVcomboBox.SelectedIndex;
                AGVcomboBox.Items.RemoveAt(selectIndex);
                MessageBox.Show("删除成功", "提示");
            }
        }

        private void Disconnectbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Disconnectbutton.Text = "断开连接";
                mysocket.BeginDisconnect(false, null, null);
                MessageBox.Show("AGV断开", "提示");
            }
            catch (Exception) { }
        }

        private void Mainbutton_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < lines.Length; i += 3)
            {
                lines[i] = lines[i].ToString();
                AGVcomboBox.Items.Add(lines[i]);
            }
        }

        private void AGVcomboBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void AGVcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                int selectedIndex = AGVcomboBox.SelectedIndex;
                Object selectedItem = AGVcomboBox.SelectedItem;
                if (AGVcomboBox.SelectedItem.ToString() == selectedItem.ToString())
                {
                    for (int i = 1; i < lines.Length;)
                    {
                        lines[i] = lines[i].ToString();
                        IPbox.Text = lines[i];
                        break;
                    }

                }
                //MessageBox.Show(selectedItem.ToString());
                //for (int i = 0; i < lines.Length; i += 3)
                //{
                    //if (AGVcomboBox.SelectedIndex ==0)
                    //{
                    //    for (int j = 1; j < lines.Length; j += 3)
                    //    {
                    //        lines[j] = lines[j].ToString();
                    //        IPbox.Text = lines[j];
                    //        break;
                    //    }
                        //for (int k = 2; k < lines.Length; k += 3)
                        //{
                        //    lines[k] = lines[k].ToString();
                        //    Combox.Text = lines[k];
                            
                        //}
                        
                    //}  
                //}
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
        public void stringAdd(string stringCode,string stringIp,string stringPort)
        {

  
        }
    }
}
