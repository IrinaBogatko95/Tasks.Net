using System.Xml.Serialization;

namespace FrameworkTestJournals.DataFromXML
{
    public class User
    {
        [XmlElement("username")]
        public string Username { get; set; }

        [XmlElement("password")]
        public string Password { get; set; }


        public User()
        {

        }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

    }
}
