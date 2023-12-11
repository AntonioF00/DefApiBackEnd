﻿using DefApiBackEnd.Dto.Models;
using System.Xml.Serialization;

namespace DefApiBackEnd.Infrastructure.Settings
{
    public class Setting
    {
        private static Setting _istance;
        private Configuration _configuration;
        public Configuration Configuration { get => _configuration; set => _configuration = value; }
        public static Setting Istance
        {
            get
            {
                if (_istance == null)
                {
                    _istance = new Setting();
                }
                return _istance;
            }
        }
        private Setting()
        {
            Deserialize(@"Configuration.xml");
        }
        private void Deserialize(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
            Configuration i;
            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                i = (Configuration)serializer.Deserialize(reader);
            }
            Configuration = i;
        }

        public bool SaveConfigData()
        {
            if (!File.Exists(@"Configuration.xml")) return false;

            File.WriteAllText(@"Configuration.xml", string.Empty);
            using (FileStream fs = new FileStream(@"Configuration.xml", FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Configuration));
                xs.Serialize(fs, _configuration);
                return true;
            }
        }
    }
}
