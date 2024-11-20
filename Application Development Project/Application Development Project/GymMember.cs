using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Application_Development_Project
{
    [Serializable]
    internal class GymMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ExpiringDate { get; set; }
        public bool IsActiveMembership { get; set; }

        public GymMember(int id, string name, string phoneNumber, string emailAddress, string address)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Address = address;
            DateCreated = DateTime.Now;
            ExpiringDate = DateTime.Now.AddYears(1);
            IsActiveMembership = true;
        }

        public static void SaveGymMembers(List<GymMember> gymMembers, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, gymMembers);
            }
        }

        public static List<GymMember> LoadGymMembers(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                return (List<GymMember>)formatter.Deserialize(stream);
            }
        }

        public override string ToString()
        {
            return $"Gym Member: ID: {Id}, Name: {Name}, Phone Number: {PhoneNumber}, Address: {Address}, Email Address: {EmailAddress}, Date Created: {DateCreated:yyyy-MM-dd}, Expiring Date: {ExpiringDate:yyyy-MM-dd}, Active Membership: {(IsActiveMembership ? "Yes" : "No")}";
        }

    }
}
