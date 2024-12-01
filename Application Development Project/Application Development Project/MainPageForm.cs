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
using static System.Net.Mime.MediaTypeNames;

namespace Application_Development_Project
{
    public partial class MainPageForm : Form
    {
        private Admin admin = Admin.LoadAdmin("AdminFile.ser"); // Load admin details from file
        private int loginAtempts; // Count of login attempts
        private List<GymMember> members = new List<GymMember>(); // List of gym members
        private int profit = 0; // Store profit value
        private ToolTip tabToolTip; // Tooltip for tabs
        private string fileName; // File name placeholder
        public MainPageForm(Icon icon) // Constructor for MainPageForm
        {
            InitializeComponent(); // Initialize form components
            InitializeTabTooltips(); // Set tooltips for tabs
            this.KeyPreview = true; // Enable form to process key events before any other
            this.KeyDown += new KeyEventHandler(MainPageForm_KeyDown); // Event handler for key down events
            properClose(); // Proper closure setup
            if (File.Exists("Gym Member List.ser")) // Load members from file if it exists
            {
                members = GymMember.LoadGymMembers("Gym Member List.ser");
            }
            // Load profit from file if it exists, otherwise save a new file
            if (File.Exists("ProfitFile.txt"))
            {
                profit = LoadProfit("ProfitFile.txt");
            }
            else
            {
                SaveProfit("ProfitFile.txt");
            }
            Icon = icon;  // Set the form icon
        }
        private void InitializeTabTooltips() // Initialize tooltips for tabs
        {
            tabToolTip = new ToolTip(); // Create Tooltip object

            // Set different tooltips for each tab
            tabToolTip.SetToolTip(MainTabControl, ""); // Clear default tooltip on TabControl itself

            MainTabControl.MouseMove += TabControl1_MouseMove;// Add MouseMove event to show tooltips for each tab


        }

        private void TabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            // Loop through each tab to determine which tab the mouse is over
            for (int i = 0; i < MainTabControl.TabCount; i++)
            {
                Rectangle tabRect = MainTabControl.GetTabRect(i); // Get the rectangle area of the current tab
                if (tabRect.Contains(e.Location))
                {
                    string toolTipText = ""; // Initialize tooltip text
                                             // Set tooltip text based on the index of the hovered tab
                    switch (i)
                    {
                        case 0:
                            if (AppLanguage.CurrentCulture.Equals("en-CA"))
                            {
                                toolTipText = "Put in member info and purchase membership"; // Tooltip text in English
                            }
                            else if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                toolTipText = "Entrer les informations du membre et achetez un abonnement"; // Tooltip text in French
                            }
                            break;
                        case 1:
                            if (AppLanguage.CurrentCulture.Equals("en-CA"))
                            {
                                toolTipText = "Display all gym members in the system";
                            }
                            else if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                toolTipText = "Afficher tous les membres du gym dans le système";
                            }
                            break;
                        case 2:
                            if (AppLanguage.CurrentCulture.Equals("en-CA"))
                            {
                                toolTipText = "Search for a member in the system";
                            }
                            else if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                toolTipText = "Rechercher un membre dans le système";
                            }
                            break;
                        case 3:
                            if (AppLanguage.CurrentCulture.Equals("en-CA"))
                            {
                                toolTipText = "Renew memberships that are expiring soon";
                            }
                            else if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                toolTipText = "Renouveler les abonnements qui expirent bientôt";
                            }
                            break;
                        case 4:
                            if (AppLanguage.CurrentCulture.Equals("en-CA"))
                            {
                                toolTipText = "Show the total revenue of the gym";
                            }
                            else if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                toolTipText = "Afficher le revenu total du gymnase";
                            }
                            break;
                        case 5:
                            if (AppLanguage.CurrentCulture.Equals("en-CA"))
                            {
                                toolTipText = "Display the reasons for all membership deactivations";
                            }
                            else if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                toolTipText = "Afficher les raisons de toutes les désactivations d'abonnement";
                            }
                            break;
                        case 6:
                            if (AppLanguage.CurrentCulture.Equals("en-CA"))
                            {
                                toolTipText = "Customize system robustness";
                            }
                            else if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                toolTipText = "Personnaliser la robustesse du système";
                            }
                            break;
                        case 7:
                            if (AppLanguage.CurrentCulture.Equals("en-CA"))
                            {
                                toolTipText = "Change the logo of the app";
                            }
                            else if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                toolTipText = "Changer le logo de l'application";
                            }
                            break;
                        case 8:
                            if (AppLanguage.CurrentCulture.Equals("en-CA"))
                            {
                                toolTipText = "tutorial to learn to use the app";
                            }
                            else if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                toolTipText = "Tutoriel pour apprendre à utiliser l'application";
                            }
                            break;
                    }
                    // Show the tooltip only if the mouse is over a new tab
                    if (tabToolTip.GetToolTip(MainTabControl) != toolTipText)
                    {
                        tabToolTip.SetToolTip(MainTabControl, toolTipText);
                    }
                    return; // Exit after finding the correct tab
                }
            }
            tabToolTip.SetToolTip(MainTabControl, ""); // Clear the tooltip if not over any tab
        }

        // Handles key down events for the form
        private void MainPageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Check if the Esc key is pressed
            {
                // Show confirmation dialog in appropriate language
                DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    MessageBox.Show("Êtes-vous sûr de vouloir fermer l’application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) :
                    MessageBox.Show("Are you sure you want to close the app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close(); // Close the form if user confirms
                }
            }
            else if (e.Alt) // Check if the Alt key is pressed
            {
                // Switch tab based on Alt key combination
                switch (e.KeyCode)
                {
                    case Keys.R:
                        MainTabControl.SelectedTab = mainFormTabPage; // Alt+R: Register Member tab
                        break;
                    case Keys.M:
                        MainTabControl.SelectedTab = viewAllGymMemberTab; // Alt+M: Members tab
                        break;
                    case Keys.S:
                        MainTabControl.SelectedTab = SecurityTabPage; // Alt+S: System Security tab
                        break;
                    case Keys.C:
                        MainTabControl.SelectedTab = customizeLogoApp; // Alt+C: Customize tab
                        break;
                    case Keys.T:
                        MainTabControl.SelectedTab = tutorialTabPage; // Alt+T: Tutorial tab
                        break;
                }
            }
        }

        // Handles password change event
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            // Check if the text box is empty
            if (string.IsNullOrEmpty(oldPasswordTextBox.Text) || string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
            {
                resetErrorLabel.Text = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    "Les zones de texte sont vides !" :
                    "The text boxes are empty!";
                return;
            }

            // Check if the old password matches the admin's password
            if (oldPasswordTextBox.Text == admin.Password)
            {
                // Update admin details and save to file
                admin = new Admin("John", newPasswordTextBox.Text, "2000-04-04", "514-888-9999");
                Admin.SaveAdmin(admin, "AdminFile.ser");
            }
            else
            {
                // Show error message if old password is incorrect
                resetErrorLabel.Text = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    "Numéro de téléphone et/ou année de naissance invalides" :
                    "Invalid Phone Number and/ or Birth Year";
                    
            }
        }

        // Handles changing attempts count
        private void ChangeAttemptsLabel_Click(object sender, EventArgs e)
        {
            // Check if the text box is empty
            if (string.IsNullOrEmpty(attemtsTextBox.Text))
            {
                errorLabel.Text = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    "La boîte de texte est vide !" :
                    "The text box is empty!";
                return;
            }

            // Check if the value is numeric
            if (!int.TryParse(attemtsTextBox.Text, out int numericValue)) // checks if value is numeric
            {
                errorLabel.Text = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    "Veuillez entrer une valeur numérique valide !" :
                    "Please enter a valid numeric value!";
                return;
            }

            // Write new attempts count to file
            using (StreamWriter writer = new StreamWriter("attemptFile.txt"))
            {
                writer.Write(attemtsTextBox.Text);
            }
            // Show success message
            errorLabel.Text = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    "Modifié avec succès" :
                    "Changed Successfully";
            attemtsTextBox.Text = ""; // Clear text box
        }

        // Handles creating a gym member
        private void createGymMemberButton_Click(object sender, EventArgs e)
        {
            // Ensure all textboxes are filled
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(creditCardTextBox.Text))
            {
                MessageBox.Show(
                    AppLanguage.CurrentCulture.Equals("fr-CA") ?
                    "Veuillez remplir tous les champs obligatoires." :
                    "Please fill in all required fields.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (agreeCheckBox.Checked) // Check if terms of service are agreed
            {
                // Show purchase confirmation dialog in appropriate language
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    MessageBox.Show("Confirmez-vous l'achat de 120$?", "Confirmation", messageBoxButtons, icon) :
                    MessageBox.Show("Do you confirm the 120$ purchase?", "Confirmation", messageBoxButtons, icon);

                switch (result)
                {
                    case DialogResult.OK:
                        // Create new gym member and add to list
                        int id = members.Count;
                        string name = nameTextBox.Text;
                        string phoneNumber = phoneNumberTextBox.Text;
                        string emailAddress = emailAddressTextBox.Text;
                        string address = addressTextBox.Text;

                        GymMember newMember = new GymMember(++id, name, phoneNumber, emailAddress, address);
                        members.Add(newMember);
                        GymMember.SaveGymMembers(members, "Gym Member List.ser");

                        gymMemberCreateDetails.Text = newMember.ToString(); // Show new member details
                        profit += 120; // Update profit
                        SaveProfit("ProfitFile.txt");
                        removeScreenButton.Visible = true; // Show remove button
                        nameTextBox.Text = "";
                        phoneNumberTextBox.Text = "";
                        emailAddressTextBox.Text = "";
                        addressTextBox.Text = "";
                        creditCardTextBox.Text = "";
                        break;
                    case DialogResult.Cancel:
                        MainTabControl.SelectedTab = MainTabControl.TabPages["mainFormTabPage"]; // Go back to login tab
                        break;
                }
            }
            else
            {
                // Show message if terms are not agreed
                if (AppLanguage.CurrentCulture.Equals("en-CA"))
                {
                    MessageBox.Show("Client Must Agree to the Terms Of Service");
                }
                else
                {
                    MessageBox.Show("Le client doit accepter les conditions d’utilisation");
                }
            }
        }

        // Handles removing the screen button
        private void removeScreenButton_Click(object sender, EventArgs e)
        {
            gymMemberCreateDetails.Text = ""; // Clear member details
        }

        // Handles viewing all gym members
        private void viewAllGymMemberTab_Click(object sender, EventArgs e)
        {
            string memberListString = ""; // Initialize member list string
            for (int i = 0; i < members.Count; i++)
            {
                // Append each member's details to the list string
                memberListString += members[i].ToString() + Environment.NewLine + Environment.NewLine;
            }
            gymMemberListTextBox.Text = memberListString; // Display the list in the textbox
        }

        // Saves the current profit value to a specified file.
        private void SaveProfit(string filePath)
        {
            // Use StreamWriter to write the profit value to the given file path.
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(profit);  // Write the profit to the file.
            }
        }

        // Loads the profit value from a specified file.
        private int LoadProfit(string filePath)
        {
            // Use StreamReader to read the profit value from the given file path.
            using (StreamReader reader = new StreamReader(filePath))
            {
                return int.Parse(reader.ReadToEnd());  // Parse and return the profit value as an integer.
            }
        }

        // Event handler for clicking the tutorial link; opens the tutorial YouTube channel in the default web browser.
        private void linkLabelTutorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelTutorial.LinkVisited = true;  // Mark the link as visited.
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCga77LEM3YbINDqkUwdCxpQ");  // Open the YouTube channel.
        }

        // Event handler for loading a picture from a file into the PictureBox and saving the file path to a local text file.
        private void loadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();  // Create a new OpenFileDialog.
            openFileDialog.Filter = "Image Files|*.ico";  // Filter for .ico files.
            openFileDialog.Title = "Select a Picture";  // Set the title of the dialog.

            if (openFileDialog.ShowDialog() == DialogResult.OK)  // If a file is selected.
            {
                fileName = openFileDialog.FileName;  // Store the selected file path.

                // Write the file path to a local file.
                File.WriteAllText(@"../../data/iconpath.txt", fileName);

                // Load and display the selected image in the PictureBox.
                logoPictureBox.Image = System.Drawing.Image.FromFile(fileName);
            }
        }

        // Event handler for converting the loaded image in the PictureBox into an application icon.
        private void buttonToIcon_Click(object sender, EventArgs e)
        {
            if (logoPictureBox.Image != null)  // Check if an image is loaded in the PictureBox.
            {
                Icon = new Icon(fileName);  // Set the icon to the loaded image.
            }
            else
            {
                string message = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                                 "Veuillez d'abord charger une image dans le PictureBox." :
                                 "Please load an image into the PictureBox first.";  // Choose the message based on the language.

                MessageBox.Show(message);  // Display the message.
            }
        }

        // Event handler for loading the main page form; applies language settings and starts the date/time timer.
        private void MainPageForm_Load(object sender, EventArgs e)
        {
            AppLanguage.ApplyLanguage(this);  // Apply the current language settings.
            timerDateTime.Interval = 100;  // Set the timer interval to 100 ms.
            timerDateTime.Tick += new EventHandler(timerDateTime_Tick);  // Attach the timer's Tick event to the handler.
            timerDateTime.Start();  // Start the timer.
        }

        // Event handler for updating the system date and time on various labels every time the timer ticks.
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update various labels to display the current date and time.
            labelRegisterDate.Text = DateTime.Now.ToLongDateString();
            labelRegisterTime.Text = DateTime.Now.ToLongTimeString();
            labelSystemDate.Text = DateTime.Now.ToLongDateString();
            labelSystemTime.Text = DateTime.Now.ToLongTimeString();
            labelCustomizeDate.Text = DateTime.Now.ToLongDateString();
            labelCustomizeTime.Text = DateTime.Now.ToLongTimeString();
            labelTutorialDate.Text = DateTime.Now.ToLongDateString();
            labelTutorialTime.Text = DateTime.Now.ToLongTimeString();
            labelRevenueDate.Text = DateTime.Now.ToLongDateString();
            labelRevenueTime.Text = DateTime.Now.ToLongTimeString();
            labelExpiringDate.Text = DateTime.Now.ToLongDateString();
            labelExpiringTime.Text = DateTime.Now.ToLongTimeString();
            labelDeactivationDate.Text = DateTime.Now.ToLongDateString();
            labelDeactivationTime.Text = DateTime.Now.ToLongTimeString();
            labelLookupDate.Text = DateTime.Now.ToLongDateString();
            labelLookupTime.Text = DateTime.Now.ToLongTimeString();
        }

        // Event handler for searching a gym member by ID; updates the search result list box.
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResultListBox.Items.Clear();  // Clear previous search results.

            if (int.TryParse(searchTextBox.Text, out int searchID))  // Attempt to parse the entered ID.
            {
                GymMember member = members.Find(m => m.Id == searchID);  // Search for the member by ID.

                if (member != null)
                {
                    searchResultListBox.Items.Add(member);  // If the member is found, add to the result list.
                }
                else
                {
                    // Display a message if the member is not found.
                    if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                    {
                        MessageBox.Show("Membre non trouvé");
                    }
                    else
                    {
                        MessageBox.Show("Member not found!");
                    }
                }
            }
            else
            {
                // Display a message if the ID is invalid.
                if (AppLanguage.CurrentCulture.Equals("en-CA"))
                {
                    MessageBox.Show("Please enter a valid ID");
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un ID valide.");
                }
            }
        }

        // Event handler for renewing a membership when the 'Renew' button is clicked in the Expiring Soon tab.
        private void renewButton_Click(object sender, EventArgs e)
        {
            if (expiringMembersListBox.SelectedItem is GymMember member)
            {
                // Confirm the purchase with a dialog box.
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ? MessageBox.Show("Confirmez-vous l’achat de 120 $ ?", "Confirmation", messageBoxButtons, icon) :
                                                                                             MessageBox.Show("Do you confirm the 120$ purchase?", "Confirmation", messageBoxButtons, icon);

                switch (result)
                {
                    case DialogResult.OK:
                        member.RenewMembership("Gym Member List.ser", members);  // Renew the membership.
                        expiringMembersListBox.Items.Remove(member);  // Remove the member from the expiring list.
                        profit += 120;  // Add the renewal fee to the profit.
                        SaveProfit("ProfitFile.txt");  // Save the updated profit.
                        removeScreenButton.Visible = true;  // Make the remove button visible.

                        // Show a success message.
                        if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                        {
                            MessageBox.Show($"Abonnement renouvelé jusqu’à {member.ExpiringDate:yyyy-MM-dd}.");
                        }
                        else
                        {
                            MessageBox.Show($"Membership renewed until {member.ExpiringDate:yyyy-MM-dd}.");
                        }
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        // Event handler for renewing a membership when the 'Renew' button is clicked in the Lookup tab.
        private void renewButton2_Click(object sender, EventArgs e)
        {
            if (searchResultListBox.SelectedItem is GymMember member)
            {
                if (member.IsExpiringSoon())  // Check if the membership is expiring soon.
                {
                    // Confirm the renewal purchase.
                    MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
                    MessageBoxIcon icon = MessageBoxIcon.Question;
                    DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ? MessageBox.Show("Confirmez-vous l’achat de 120 $ ?", "Confirmation", messageBoxButtons, icon) :
                                                                                                 MessageBox.Show("Do you confirm the 120$ purchase?", "Confirmation", messageBoxButtons, icon);

                    switch (result)
                    {
                        case DialogResult.OK:
                            member.RenewMembership("Gym Member List.ser", members);  // Renew the membership.
                            profit += 120;  // Add the renewal fee to the profit.
                            SaveProfit("ProfitFile.txt");  // Save the updated profit.
                            searchResultListBox.Items.Remove(member);  // Remove the member from the list.
                            searchResultListBox.Items.Add(member);  // Add the member back to update the list.
                            removeScreenButton.Visible = true;  // Make the remove button visible.

                            // Show success message.
                            if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                MessageBox.Show($"Abonnement renouvelé jusqu’à {member.ExpiringDate:yyyy-MM-dd}.");
                            }
                            else
                            {
                                MessageBox.Show($"Membership renewed until {member.ExpiringDate:yyyy-MM-dd}.");
                            }
                            break;

                        case DialogResult.Cancel:
                            break;
                    }
                }
                else
                {
                    // Display a message if the membership is not expiring soon.
                    if (AppLanguage.CurrentCulture.Equals("en-CA"))
                    {
                        MessageBox.Show("Membership is not expiring soon. Cannot renew Membership at this time");
                    }
                    else
                    {
                        MessageBox.Show("L’abonnement n’expire pas bientôt. Impossible de renouveler l’abonnement pour le moment.");
                    }
                }
            }
        }

        // Event handler for entering the Expiration tab; updates the expiring members list box with members whose memberships are expiring soon.
        private void ExpirationTabPage_Enter(object sender, EventArgs e)
        {
            expiringMembersListBox.Items.Clear();  // Clear the existing list of expiring members.

            foreach (GymMember member in members)  // Loop through all gym members.
            {
                if (member.IsExpiringSoon())  // Check if the member's membership is expiring soon.
                {
                    expiringMembersListBox.Items.Add(member);  // Add the expiring member to the list box.
                }
            }
        }

        // Event handler for deactivating a gym member's membership when the deactivate button is clicked.
        private void deactivateMemberButton_Click(object sender, EventArgs e)
        {
            // Check if no member is selected from the search result list.
            if (searchResultListBox.SelectedItem == null)
            {
                // Show a message prompting the user to select a member before proceeding.
                if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                {
                    MessageBox.Show("Veuillez sélectionner un membre avant d’effectuer cette action.");
                }
                else
                {
                    MessageBox.Show("Please select a member before performing this action.");
                }
                return;
            }
            else if (searchResultListBox.SelectedItem is GymMember member)
            {
                // Prompt for the reason to deactivate the selected member's membership.
                string reason = (AppLanguage.CurrentCulture.Equals("fr-CA")) ?
                    member.PromptForReason("Entrez la raison pour désactiver ce membre.") :
                    member.PromptForReason("Enter the reason for deactivating this member");

                // If a reason is provided, deactivate the membership and update the list.
                if (!string.IsNullOrWhiteSpace(reason))
                {
                    member.DeactivateMembership(reason, "Gym Member List.ser", members);  // Deactivate membership and save to file.
                    searchResultListBox.Items.Remove(member);  // Remove the member from the list box.
                    searchResultListBox.Items.Add(member);  // Add the updated member back to the list box.
                }
                else
                {
                    // Show a message if the reason for deactivation is empty.
                    if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                    {
                        MessageBox.Show("La raison de la désactivation ne peut pas être vide.");
                    }
                    else
                    {
                        MessageBox.Show("Deactivation reason cannot be empty");
                    }
                }
            }
        }

        // Event handler for reactivating a gym member's membership when the reactivate button is clicked.
        private void reactivateMemberButton_Click(object sender, EventArgs e)
        {
            // Check if no member is selected from the search result list.
            if (searchResultListBox.SelectedItem == null)
            {
                // Show a message prompting the user to select a member before proceeding.
                if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                {
                    MessageBox.Show("Veuillez sélectionner un membre avant d’effectuer cette action.");
                }
                else
                {
                    MessageBox.Show("Please select a member before performing this action.");
                }
                return;
            }
            else if (searchResultListBox.SelectedItem is GymMember member)
            {
                // Reactivate the selected member's membership and update the list.
                member.ReactivateMembership("Gym Member List.ser", members);  // Reactivate membership and save to file.
                searchResultListBox.Items.Remove(member);  // Remove the member from the list box.
                searchResultListBox.Items.Add(member);  // Add the updated member back to the list box.
            }
        }

        // Event handler for displaying deactivated members and their deactivation reasons when the deactivation tab is entered.
        private void deactivationReasonTabPage_Enter(object sender, EventArgs e)
        {
            deactivationReasonsRichTextBox.Clear();  // Clear the rich text box before adding new data.

            // Loop through all members and display those with deactivated memberships and a recorded deactivation reason.
            foreach (var member in members)
            {
                if (!member.IsActiveMembership && !string.IsNullOrEmpty(member.DeactivationReason))
                {
                    // Append member details to the rich text box in the format: ID - Name - DeactivationReason.
                    deactivationReasonsRichTextBox.AppendText($"{member.Id} - {member.Name} - {member.DeactivationReason}\n\n");
                }
            }
        }

        // Event handler for displaying the current profit on the revenue tab when it is entered.
        private void revenueTabPage_Enter(object sender, EventArgs e)
        {
            int profit = LoadProfit("ProfitFile.txt");  // Load the current profit from a file.
            profitLabel.Text = profit.ToString("C");  // Display the profit value in currency format.

            // Set the background color of the profit label based on the profit value range.
            if (profit > 0 && profit <= 1000)
            {
                profitLabel.BackColor = Color.Red;  // Red for low profit.
            }
            else if (profit > 1000 && profit <= 3000)
            {
                profitLabel.BackColor = Color.Yellow;  // Yellow for moderate profit.
            }
            else
            {
                profitLabel.BackColor = Color.Green;  // Green for high profit.
            }
        }
    }
}