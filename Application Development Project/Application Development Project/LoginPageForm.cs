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
using System.Xml.Linq;

namespace Application_Development_Project
{
    public partial class LoginPageForm : Form
    {

        private Admin admin;
        private int loginAtempts;
        public LoginPageForm()
        {
            InitializeComponent();

            try
            {
                admin = Admin.LoadAdmin("AdminFile.ser");
            }
            catch
            {
                admin = new Admin("John", "Password123","2000-04-04","514-888-9999");
                Admin.SaveAdmin(admin, "AdminFile.ser");
            }
            
            if (File.Exists("attemptFile.txt"))
            {
                using (StreamReader reader = new StreamReader("attemptFile.txt"))
                {
                    loginAtempts = int.Parse(reader.ReadLine());
                }
            } 
            else
            {
                loginAtempts = 5;
                using (StreamWriter writer = new StreamWriter("attemptFile.txt"))
                {
                    writer.Write("5");
                }
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredName = nameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;

            if (enteredName == admin.Name && enteredPassword == admin.Password && loginAtempts >= 0)
            {
                MainPageForm mainPageForm = new MainPageForm();
                mainPageForm.Show();
                this.Hide();
            }
            else if(loginAtempts > 0)
            {
                errorLabel.Text = "Invalid Name or Password ! " + loginAtempts +" Attempts Left";
                loginAtempts--;
            } else
            {
                errorLabel.Text = "Too many Failed Atempts, You are locked out, restart the syetem to try again";
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            string enteredBirthYear = birthYearTextBox.Text;
            string enteredPhone = phoneNumberTextBox.Text;
            
            if (enteredPhone == admin.PhoneNumber && enteredBirthYear == admin.Birthday.Substring(0,4))
            {
                admin = new Admin("John", newPasswordTextBox.Text, "2000-04-04", "514-888-9999");
                Admin.SaveAdmin(admin, "AdminFile.ser");
                Application.Exit();
            }
            else
            {
                resetErrorLabel.Text = "Invalid Phone Number and/or Birth Year";
            }
        }
            
    }
}


