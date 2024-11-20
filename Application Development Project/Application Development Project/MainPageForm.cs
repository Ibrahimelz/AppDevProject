using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development_Project
{
    public partial class MainPageForm : Form
    {
        private Admin admin = Admin.LoadAdmin("AdminFile.ser");
        private int loginAtempts;
        private List<GymMember> members = new List<GymMember>();
        private int profit = 0;
        public MainPageForm()
        {
            InitializeComponent();
            properClose();
            if (File.Exists("Gym Member List.ser"))
            {
               members = GymMember.LoadGymMembers("Gym Member List.ser");
            }

            if (File.Exists("ProfitFile.txt"))
            {
                profit = LoadProfit("ProfitFile.txt");
            }
            else
            {
                SaveProfit("ProfitFile.txt");
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (oldPasswordTextBox.Text == admin.Password)
            {
                admin = new Admin("John", newPasswordTextBox.Text, "2000-04-04", "514-888-9999");
                Admin.SaveAdmin(admin, "AdminFile.ser");
            }
            else
            {
                resetErrorLabel.Text = "Invalid Phone Number and/or Birth Year";
            }
        }

        private void ChangeAttemptsLabel_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("attemptFile.txt"))
            {
                writer.Write(attemtsTextBox.Text);
            }
            errorLabel.Text = "Changed Successfully";
            attemtsTextBox.Text = "";
        }

        private void createGymMemberButton_Click(object sender, EventArgs e)
        {
            if (agreeCheckBox.Checked)
            {
                int id = members.Count;
                string name = nameTextBox.Text;
                string phoneNumber = phoneNumberTextBox.Text;
                string emailAddress = emailAddressTextBox.Text;
                string address = addressTextBox.Text;

                GymMember newMember = new GymMember(++id, name, phoneNumber, emailAddress, address);

                members.Add(newMember);

                GymMember.SaveGymMembers(members, "Gym Member List.ser");
                gymMemberCreateDetails.Text = newMember.ToString();

                profit += 120;
                SaveProfit("ProfitFile.txt");
            } 
            else
            {
                MessageBox.Show("Client Must Agree to the Terms Of Service");
            }
        }

        private void removeScreenButton_Click(object sender, EventArgs e)
        {
            gymMemberCreateDetails.Text = "";
        }

        private void viewAllGymMemberTab_Click(object sender, EventArgs e)
        {
            string memberListString = "";
            for (int i = 0; i < members.Count; i++) {
                memberListString += members[i].ToString() + Environment.NewLine + Environment.NewLine;
            }
            gymMemberListTextBox.Text = memberListString;
        }

        private void SaveProfit(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(profit);
            }
        }

        private int LoadProfit(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return int.Parse(reader.ReadToEnd());
            }
        }
    }
}
