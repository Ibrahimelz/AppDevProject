using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public string DeactivationReason { get; set; }

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

        // Method to check if membership is expiring within 30 days
        public bool IsExpiringSoon()
        {
            return IsActiveMembership && (ExpiringDate - DateTime.Now).Days <= 30;
        }

        // Method to renew memberships expiring in 30 days or less
        public void RenewMembership(string filePath, List<GymMember> gymMembers)
        {
            if (IsExpiringSoon())
            {
                if (ExpiringDate > DateTime.Now)
                {
                    ExpiringDate = ExpiringDate.AddYears(1);
                    SaveGymMembers(gymMembers, filePath);

                } else
                {
                    ExpiringDate = DateTime.Now.AddYears(1);
                    SaveGymMembers(gymMembers, filePath);
                }
            }
            else {
                MessageBox.Show("Cannot renew membership");
            }
        }

        // Method to deactivate a member
        public void DeactivateMembership(string reason, string filePath, List<GymMember> gymMembers)
        {
            if (IsActiveMembership)
            {
                IsActiveMembership = false;
                DeactivationReason = reason;
                MessageBox.Show($"{this.Name} has been deactivated.");
                SaveGymMembers(gymMembers, filePath);
            }
            else
            {
                MessageBox.Show($"{this.Name} membership is Deactivated already!");
            }

        }

        // Helper method to display a prompt dialog for input
        public string PromptForReason(string message)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 400;
                prompt.Height = 200;
                prompt.Text = "Deactivation Reason";

                Label textLabel = new Label() { Left = 20, Top = 20, Text = message, Width = 350 };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 350 };
                Button confirmationButton = new Button() { Text = "OK", Left = 250, Top = 100, Width = 100 };

                confirmationButton.Click += (sender, e) => { prompt.Close(); };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmationButton);
                prompt.ShowDialog();

                return inputBox.Text;
            }
        }

        // Method to reactivate a member
        public void ReactivateMembership(string filePath, List<GymMember> gymMembers)
        {
            if (!IsActiveMembership)
            {
                IsActiveMembership = true;
                DeactivationReason = null;
                MessageBox.Show($"{this.Name} has been reactivated.");
                SaveGymMembers(gymMembers, filePath);
            }
            else
            {
                MessageBox.Show($"{this.Name} is an Active member already!");
            }
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
            return $"Gym Member: ID: {Id}, Name: {Name}, Phone Number: {PhoneNumber}, Address: {Address}, Email Address: {EmailAddress}, Date Created: {DateCreated:yyyy-MM-dd}, Expiring Date: {ExpiringDate:yyyy-MM-dd}, Active Membership: {(IsActiveMembership ? "Yes" : "No")}" +
                (IsActiveMembership ? "" : $", Deactivation Reason: {DeactivationReason}"); ;
        }

    }
}
