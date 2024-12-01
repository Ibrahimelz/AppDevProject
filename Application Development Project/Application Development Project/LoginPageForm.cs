using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private ToolTip tabToolTip;
        public LoginPageForm()
        {
            InitializeComponent();
            InitializeTabTooltips();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(LoginPageForm_KeyDown);

            try
            {
                admin = Admin.LoadAdmin("AdminFile.ser");
            }
            catch
            {
                admin = new Admin("John", "Password123", "2000-04-04", "514-888-9999");
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

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelLoginDate.Text = DateTime.Now.ToLongDateString();
            labelLoginTime.Text = DateTime.Now.ToLongTimeString();
            labelResetPswdDate.Text = DateTime.Now.ToLongDateString();
            labelResetPswdTime.Text = DateTime.Now.ToLongTimeString();
        }
        private void InitializeTabTooltips()
        {
            tabToolTip = new ToolTip();

            // Set different tooltips for each tab
            tabToolTip.SetToolTip(loginTabControl, ""); // Clear default tooltip on TabControl itself
            
            loginTabControl.MouseMove += TabControl1_MouseMove;// Add MouseMove event to show tooltips for each tab
            try
            {
                Icon = new Icon(File.ReadAllText(@"../../data/iconpath.txt"));
            }
            catch (Exception ex)
            {

            }

        }

        private void TabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < loginTabControl.TabCount; i++) // Determine which tab the mouse is over
            {
                Rectangle tabRect = loginTabControl.GetTabRect(i);
                if (tabRect.Contains(e.Location))
                {
                    string toolTipText = "";// Set tooltip text based on the hovered tab index
                    switch (i)
                    {
                        case 0:
                            toolTipText = "Use name and password to login";
                            break;
                        case 1:
                            toolTipText = "Enter details to reset password";
                            break;
                    }

                    
                    if (tabToolTip.GetToolTip(loginTabControl) != toolTipText) // Show tooltip only if the mouse is over a new tab
                    {
                        tabToolTip.SetToolTip(loginTabControl, toolTipText);
                    }
                    return; // Exit after finding the correct tab
                }
            }
            tabToolTip.SetToolTip(loginTabControl, "");// Clear tooltip if not over any tab
        }

        private void LoginPageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result =(AppLanguage.CurrentCulture.Equals("en-CA")) ? MessageBox.Show("Are you sure you want to close the app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question):
                                                                                    MessageBox.Show("Êtes-vous sûr de vouloir fermer l’application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close(); // Closes the form
                }
            }
            else if (e.Alt) // Check if Alt key is pressed
            {
                switch (e.KeyCode)
                {
                    case Keys.L:
                        loginTabControl.SelectedTab = loginPageTab; // Alt+L goes to Login tab
                        break;
                    case Keys.R:
                        loginTabControl.SelectedTab = resetPageTab; // Alt+R goes to Reset Password tab
                        break;
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredName = nameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;

            if (enteredName == admin.Name && enteredPassword == admin.Password && loginAtempts > 0)
            {
                MainPageForm mainPageForm = new MainPageForm(Icon);
                mainPageForm.Show();
                this.Hide();
            }
            else if (loginAtempts > 1)
            {
                if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                {
                    loginAtempts--;
                    errorLabel.Text = "Nom ou mot de passe invalide! " + loginAtempts + " tentatives restantes";
                }
                else
                {
                    loginAtempts--;
                    errorLabel.Text = "Invalid Name or Password ! " + loginAtempts + " attempts Left";
                }
                
            }
            else
            {
                if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                {
                    loginAtempts--;
                    errorLabel.Text = "Trop de tentatives échouées, vous êtes bloqué. Redémarrez le système pour réessayer.";
                }
                else
                {
                    loginAtempts--;
                    errorLabel.Text = "Too many Failed Atempts, You are locked out. Restart the syetem to try again";
                }               
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            string enteredBirthYear = birthYearTextBox.Text;
            string enteredPhone = phoneNumberTextBox.Text;

            if (enteredPhone == admin.PhoneNumber && enteredBirthYear == admin.Birthday.Substring(0, 4))
            {
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ? MessageBox.Show("Êtes - vous sûr de vouloir réinitialiser votre mot de passe ?", "Réinitialiser le mot de passe", messageBoxButtons, icon) :
                                                                                     MessageBox.Show("Are you sure you want to proceed with resetting your password?", "Reset Password", messageBoxButtons, icon);
                switch (result)
                {
                    case DialogResult.OK:
                        admin = new Admin("John", newPasswordTextBox.Text, "2000-04-04", "514-888-9999");
                        Admin.SaveAdmin(admin, "AdminFile.ser");
                        Application.Exit();
                        break;
                    case DialogResult.Cancel:
                        birthYearTextBox.Text = "";
                        phoneNumberTextBox.Text = "";
                        newPasswordTextBox.Text = "";
                        loginTabControl.SelectedTab = loginTabControl.TabPages["loginPageTab"]; //Goes back to loginTab
                        break;
                }
            }
            else
            {
                resetErrorLabel.Text = (AppLanguage.CurrentCulture.Equals("fr-CA")) ? "Numéro de téléphone et/ou année de naissance invalide" : "Invalid Phone Number and/or Birth Year";
            }
        }

        private void LoginPageForm_Load(object sender, EventArgs e)
        {
            languageComboBox.SelectedIndex = 0;
            AppLanguage.ApplyLanguage(this);
            timerDateTime.Interval = 100;
            timerDateTime.Tick += new EventHandler(timerDateTime_Tick);
            timerDateTime.Start();
        }

        // language comboBox event handler
        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLang = languageComboBox.SelectedItem.ToString();
            AppLanguage.CurrentCulture = selectedLang == "English" ? "en-CA" : "fr-CA";
            AppLanguage.ApplyLanguage(this);
            Refresh();
        }

        
        
    }
}


