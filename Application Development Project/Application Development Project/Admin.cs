using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Application_Development_Project
{
    [Serializable]
    internal class Admin
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }

        public Admin(string name, string password, string birthday, string phoneNumber)
        {
            Name = name;
            Password = password;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
        }

        public static void SaveAdmin(Admin admin, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, admin);
            }
        }

        public static Admin LoadAdmin(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                return (Admin)formatter.Deserialize(stream);
            }
        }
    }
}
