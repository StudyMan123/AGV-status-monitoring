using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVS
{
    public partial class Form3 : Form
    {
        //Form1 _mw = new Form1();
        Form1 ma = null;
        PacketRecordList pack = null;
        //Dictionary<string,Form3> userEdite = new Dictionary<string,Form3>();
        //ObservableCollection<string> Info = new ObservableCollection<string>();
        //public string variable_ip;
        //public string  variable_port;
        Form1 fr = new Form1();
 
        public Form3(Form1 _mw, PacketRecordList _pack)
        {
            pack = _pack;
            ma = _mw;
            InitializeComponent();
        }
        //public Form3(string s,string d)
        //{
        //    variable_ip = s;
        //    variable_port = d;
        //}
        public void Setlabel3(string str)
        {
            AGVlabel.Text = str;
        }
        //private readonly object lockRecord = new object();
        //public void InfoAdd(string code,string codeip,string codeport)
        //{
        //    lock (lockRecord)
        //    {
        //        if (!Info.Contains(code))
        //        {
        //            Info.Add(code);
        //        }
        //        if(!Info.Contains(codeip))
        //        {
        //            Info.Add(codeip);
        //        }
        //        if(!Info.Contains(codeport))
        //        {
        //            Info.Add(codeport);
        //        }
        //    }
        //}
        
        void BtnOk_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("texttxt.txt",true);   
            string type = AGVlabel.Text.ToString();
            if (type == "请输入要添加的AGV编号")
            {
                string AGVCode = new PacketRecord(AgvCodeBox.Text, textIP.Text, textPort.Text, PacketRecord.PacketType.String).Name;
                string IP = new PacketRecord(AgvCodeBox.Text, textIP.Text, textPort.Text, PacketRecord.PacketType.String).Ip;
                string PORT = new PacketRecord(AgvCodeBox.Text, textIP.Text, textPort.Text, PacketRecord.PacketType.String).Port;  
                ma.LstTxtItem(AGVCode);
                sw.WriteLine(AGVCode);
                sw.WriteLine(IP);
                sw.WriteLine(PORT);
                sw.Flush();
                sw.Close();
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
