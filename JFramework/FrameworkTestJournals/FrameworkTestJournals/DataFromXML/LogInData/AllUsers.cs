using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FrameworkTestJournals.DataFromXML
{
    [Serializable]
    public class AllUsers
    {

        [XmlElement("user")]
        public List<User> Users { get; set; }

        public static AllUsers DeserialiseLogInData(string filePath)
        {
            var catalogSerialiser = new XmlSerializer(typeof(AllUsers));
            return (AllUsers)catalogSerialiser.Deserialize(new XmlTextReader(filePath));
        }
    }
}
