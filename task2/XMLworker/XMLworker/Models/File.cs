using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLworker.models
{
    [Serializable]
    public class File
    {
        public int Id { get; set; }

        [XmlAttribute]
        public string FileVersion { get; set; }

        public string Name { get; set; }

        public DateTime DateTime { get; set; }
    }
}
