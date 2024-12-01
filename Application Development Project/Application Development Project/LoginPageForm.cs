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
        private Admin admin; // Admin object to store admin details
        private int loginAtempts; // Counter for login attempts
        private ToolTip tabToolTip; // ToolTip object for displaying tooltips on tabs

        // Constructor to initialize components and handle initial setup
        public LoginPageForm()
        {
            InitializeComponent();
            InitializeTabTooltips(); // Initialize tooltips for the tabs
            this.KeyPreview = true; // Enable key preview for form
            this.KeyDown += new KeyEventHandler(LoginPageForm_KeyDown); // Register KeyDown event for keyboard shortcuts

            try
            {
                // Attempt to load the admin from a file, create a new admin if loading fails
                admin = Admin.LoadAdmin("AdminFile.ser");
            }
            catch
            {
                admin = new Admin("John", "Password123", "2000-04-04", "514-888-9999");
                Admin.SaveAdmin(admin, "AdminFile.ser"); // Save the newly created admin to file
            }

            // Check if login attempts file exists, else initialize it with 5 attempts
            if (File.Exists("attemptFile.txt"))
            {
                using (StreamReader reader = new StreamReader("attemptFile.txt"))
                {
                    loginAtempts = int.Parse(reader.ReadLine()); // Load the number of attempts
                }
            }
            else
            {
                loginAtempts = 5;
                using (StreamWriter writer = new StreamWriter("attemptFile.txt"))
                {
                    writer.Write("5"); // Initialize file with 5 attempts
                }
            }
        }

        // Timer event to update date and time labels periodically
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelLoginDate.Text = DateTime.Now.ToLongDateString(); // Update date
            labelLoginTime.Text = DateTime.Now.ToLongTimeString(); // Update time
            labelResetPswdDate.Text = DateTime.Now.ToLongDateString(); // Update reset password date
            labelResetPswdTime.Text = DateTime.Now.ToLongTimeString(); // Update reset password time
        }

        // Method to initialize tooltips for each tab
        private void InitializeTabTooltips()
        {
            tabToolTip = new ToolTip();

            // Clear default tooltip on TabControl
            tabToolTip.SetToolTip(loginTabControl, "");
            loginTabControl.MouseMove += TabControl1_MouseMove; // Add MouseMove event to display tooltips
            try
            {
                // Attempt to load the app icon from a file
                Icon = new Icon(File.ReadAllText(@"../../data/iconpath.txt"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}"); // Log any error that occurs
            }
        }

        // MouseMove event handler for displaying tooltips on tabs
        private void TabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            // Loop through all the tabs to determine which one the mouse is over
            for (int i = 0; i < loginTabControl.TabCount; i++)
            {
                Rectangle tabRect = loginTabControl.GetTabRect(i);
                if (tabRect.Contains(e.Location)) // If the mouse is over this tab
                {
                    string toolTipText = ""; // Default tooltip text
                    // Set tooltip text based on the hovered tab index
                    switch (i)
                    {
                        case 0:
                            toolTipText = (AppLanguage.CurrentCulture.Equals("en-CA")) ? "Use name and password to login" : "Utilisez le nom et le mot de passe pour vous connecter";
                            break;
                        case 1:
                            toolTipText = (AppLanguage.CurrentCulture.Equals("en-CA")) ? "Enter details to reset password" : "Entrez les détails pour réinitialiser le mot de passe";
                            break;
                    }
                    // Show tooltip only if it's different from the current one
                    if (tabToolTip.GetToolTip(loginTabControl) != toolTipText)
                    {
                        tabToolTip.SetToolTip(loginTabControl, toolTipText);
                    }
                    return; // Exit after finding the correct tab
                }
            }
            tabToolTip.SetToolTip(loginTabControl, ""); // Clear tooltip if mouse is not over any tab
        }

        // KeyDown event handler for keyboard shortcuts
        private void LoginPageForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Escape key is pressed, prompt for confirmation to close the app
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = (AppLanguage.CurrentCulture.Equals("en-CA")) ?
                    MessageBox.Show("Are you sure you want to close the app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) :
                    MessageBox.Show("Êtes-vous sûr de vouloir fermer l’application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close(); // Close the form if Yes is clicked
                }
            }
            else if (e.Alt) // Check if Alt key is pressed for tab navigation
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

        // Click event handler for the login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredName = nameTextBox.Text; // Get entered username
            string enteredPassword = passwordTextBox.Text; // Get entered password

            // Check if entered credentials are valid
            if (enteredName == admin.Name && enteredPassword == admin.Password && loginAtempts > 0)
            {
                MainPageForm mainPageForm = new MainPageForm(Icon); // Create MainPageForm instance
                mainPageForm.Show(); // Show the main page form
                this.Hide(); // Hide the login form
            }
            else if (loginAtempts > 1)
            {
                // Decrease login attempts and show an error message
                loginAtempts--;
                errorLabel.Text = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    "Nom ou mot de passe invalide! " + loginAtempts + " tentatives restantes" :
                    "Invalid Name or Password ! " + loginAtempts + " attempts Left";
            }
            else
            {
                // Lockout message when too many failed attempts
                loginAtempts--;
                errorLabel.Text = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    "Trop de tentatives échouées, vous êtes bloqué. Redémarrez le système pour réessayer." :
                    "Too many Failed Attempts, You are locked out. Restart the system to try again";
            }
        }

        // Click event handler for the change password button
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            string enteredBirthYear = birthYearTextBox.Text; // Get entered birth year
            string enteredPhone = phoneNumberTextBox.Text; // Get entered phone number

            // Check if entered phone number and birth year match admin's details
            if (enteredPhone == admin.PhoneNumber && enteredBirthYear == admin.Birthday.Substring(0, 4))
            {
                // Prompt for password reset confirmation
                DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    MessageBox.Show("Êtes-vous sûr de vouloir réinitialiser votre mot de passe ?", "Réinitialiser le mot de passe", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) :
                    MessageBox.Show("Are you sure you want to proceed with resetting your password?", "Reset Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.OK:
                        admin = new Admin("John", newPasswordTextBox.Text, "2000-04-04", "514-888-9999");
                        Admin.SaveAdmin(admin, "AdminFile.ser"); // Save the new password
                        Application.Exit(); // Exit the application after password reset
                        break;
                    case DialogResult.Cancel:
                        // Clear the entered fields and return to login tab if Cancel is clicked
                        birthYearTextBox.Text = "";
                        phoneNumberTextBox.Text = "";
                        newPasswordTextBox.Text = "";
                        loginTabControl.SelectedTab = loginTabControl.TabPages["loginPageTab"];
                        break;
                }
            }
            else
            {
                // Show error if phone number or birth year is incorrect
                resetErrorLabel.Text = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    "Numéro de téléphone et/ou année de naissance invalide" :
                    "Invalid Phone Number and/or Birth Year";
            }
        }

        // Form Load event handler to initialize language settings and start the timer
        private void LoginPageForm_Load(object sender, EventArgs e)
        {
            languageComboBox.SelectedIndex = 0; // Set default language to English
            AppLanguage.ApplyLanguage(this); // Apply the selected language to the form
            timerDateTime.Interval = 100; // Set the timer interval
            timerDateTime.Tick += new EventHandler(timerDateTime_Tick); // Register timer tick event
            timerDateTime.Start(); // Start the timer
        }

        // Event handler for the language comboBox selection change
        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected language from the comboBox
            string selectedLang = languageComboBox.SelectedItem.ToString();

            // Set the current culture based on the selected language
            // If "English" is selected, set culture to "en-CA", otherwise set to "fr-CA"
            AppLanguage.CurrentCulture = selectedLang == "English" ? "en-CA" : "fr-CA";

            // Apply the selected language to the form's UI
            AppLanguage.ApplyLanguage(this);

            // Refresh the form to update UI elements with the new language
            Refresh();
        }

    }
}


