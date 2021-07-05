using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AGVS
{
    public class TCPClientCenter : TCPIPCenterBase
    {
        
        TcpClient m_client = null;
        Form3 main = null;

        public TcpClient Client
        {
            get
            {
                return m_client;
            }
        }
        public Form3 Main
        {
            set
            {
                main = value;
            }
        }



        public override bool TcpClientCreate(string ip, int port)
        {

            m_client = new TcpClient(ip, port);

            //给服务器增加接收数据事件
           // m_client.RecvData += new NetClient.NetEvent(Client_RecvData);

            //给服务器增加客户端连接事件
            m_client.ConnectServer += new NetClient.NetEvent(Client_ClientConnect);

            //给服务器增加客户端断开事件
            m_client.DisconnectServer += new NetClient.NetEvent(Client_ClientDisconnect);
            
            return true;
        }

        //public void Client_RecvData(object sender, NetEventArgs e)
        //{
        //    main.callback(System.Text.Encoding.UTF8.GetString(e.Client.RecvBuf));
        //}
        
        public override bool TcpipCenterSendData(Session session, byte[] data, int len)
        {
            if (session != null)
            {
                return m_client.SendData(session, data, len);
            }

            return false;
        }

        private void Client_ClientConnect(object sender, NetEventArgs e)
        {
           

        }

        private void Client_ClientDisconnect(object sender, NetEventArgs e)
        {
            try
            {
               
            }
            catch
            {

            }

        }


        public override bool ClientStart()
        {
            return m_client.Connect();
        }

        public override bool ClientStart(string locaIP,int localPort)
        {
            return m_client.ConnectWithBindLocalEP(locaIP, localPort);
        }

        


        public override void Stop()
        {
            if (m_client != null)
            {
                m_client.Close();
            }
        }

        public TCPClientCenter()
        {


        }

    }
}
