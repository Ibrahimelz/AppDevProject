using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development_Project
{
    public partial class MainPageForm : Form
    {
        private Admin admin = Admin.LoadAdmin("AdminFile.ser");
        private int loginAtempts; 

        public MainPageForm()
        {
            InitializeComponent();
            properClose();
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
    }
}
