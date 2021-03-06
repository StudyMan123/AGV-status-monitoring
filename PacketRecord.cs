using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace AGVS
{
    public class PacketRecord
    {
        public enum PacketType
        {
            String,
            X16,
        }

        PacketType type = PacketType.String;

        string packet;
        //private Window bianji1;

        [DataMember]
        public string Name { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }

        [DataMember]
        public PacketType Type { get => type; set => type = value; }

        //[DataMember]
        //public string Packet { get => packet; set => packet = value; }
        //[DataMember]
        //public string Com { get; set; }

        public PacketRecord(string _name,string _ip,string _port,PacketType _type)
        {
            this.Name = _name;
            this.Ip = _ip;
            this.Port = _port;
        }
        
    }

    [DataContract]
    public class PacketRecordList
    {
        //field
        ObservableCollection<PacketRecord> records = new ObservableCollection<PacketRecord>();

        //perproty
        [DataMember]
        public ObservableCollection<PacketRecord> Records
        {
            get
            {
                return records;
            }
            set
            {
                records = value;
            }
        }

        private readonly object lockRecords = new object();

        //增
        public void RecordsAdd(PacketRecord record)
        {
            lock(lockRecords)
            {
                if(!Records.Contains(record))
                {
                    Records.Add(record);
                }
            }

        }

        public void RecordsRemove(PacketRecord record)
        {
            lock (lockRecords)
            {
                if (Records.Contains(record))
                {
                    Records.Remove(record);
                }
            }
        }

        //改
        public PacketRecord RecordsIndexOf(string name)
        {
            lock (lockRecords)
            {
                PacketRecord recordSelect = null;
                foreach (var record in Records)
                {
                    if (record.Name == name)
                    {
                        recordSelect = record;
                        break;
                    }
                }

                return recordSelect;
            }
        }
 
        public PacketRecord RecordsCheckOf(string IP)
        {
            lock (lockRecords)
            {
                PacketRecord recordSelect = null;
                foreach (var record in Records)
                {
                    if (record.Ip == IP )
                    {
                        recordSelect = record;
                        break;
                        //return recordSelect;
                    }
                }
                return recordSelect;
            }
        }

        public PacketRecord RecordsComOf(string COM)
        {
            lock (lockRecords)
            {
                PacketRecord recordSelect = null;
                foreach (var record in Records)
                {
                    if (record.Port == COM)
                    {
                        recordSelect = record;
                        break;
                        //return recordSelect;
                    }
                }
                return recordSelect;
            }
        }

        //删
        public void RecordsRemoveByName(string name)
        {
            lock (lockRecords)
            {
                PacketRecord recordSelect = null;
                foreach(var record in Records)
                {
                    if(record.Name == name)
                    {
                        recordSelect = record;
                        break;
                    }
                }

                if(recordSelect != null)
                {
                    Records.Remove(recordSelect);
                }
            }
        }

        public void RecordsClear()
        {
            lock (lockRecords)
            {
                Records.Clear();
            }
        }

        public bool SaveRecordsToFile(string fileName)
        {
            if(!File.Exists(fileName))
            {
                return false;
            }

            if(Records == null)
            {
                return false;
            }

            string recordsStr = JsonConvert.SerializeObject(Records, Formatting.Indented);

            File.WriteAllText(fileName, recordsStr);

            return true;
        }

        public bool LoadRecordsFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return false;
            }

            string recordsStr = File.ReadAllText(fileName);

            try
            {
                Records = JsonConvert.DeserializeObject<ObservableCollection<PacketRecord>>(recordsStr);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public PacketRecordList()
        {

        }
    }
}
