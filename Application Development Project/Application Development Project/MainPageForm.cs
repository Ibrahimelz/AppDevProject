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
        private Admin admin = Admin.LoadAdmin("AdminFile.ser");
        private int loginAtempts;
        private List<GymMember> members = new List<GymMember>();
        private int profit = 0;
        private ToolTip tabToolTip; // Declare ToolTip object
        private string fileName;
        public MainPageForm(Icon icon)
        {
            InitializeComponent();
            InitializeTabTooltips();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MainPageForm_KeyDown);

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
            Icon = icon;
        }

        private void InitializeTabTooltips()
        {
            tabToolTip = new ToolTip();

            // Set different tooltips for each tab
            tabToolTip.SetToolTip(MainTabControl, ""); // Clear default tooltip on TabControl itself

            MainTabControl.MouseMove += TabControl1_MouseMove;// Add MouseMove event to show tooltips for each tab


        }

        private void TabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < MainTabControl.TabCount; i++)// Determine which tab the mouse is over
            {
                Rectangle tabRect = MainTabControl.GetTabRect(i);
                if (tabRect.Contains(e.Location))
                {
                    string toolTipText = "";// Set tooltip text based on the hovered tab index
                    switch (i)
                    {
                        case 0:
                            toolTipText = "Put in member info and purchase membership";
                            break;
                        case 1:
                            toolTipText = "Displays all gym members in the system";
                            break;
                        case 2:
                            toolTipText = "Customize system robusteness";
                            break;
                        case 3:
                            toolTipText = "Change the logo of the app";
                            break;
                        case 4:
                            toolTipText = "Video tutorial to learn to use app";
                            break;
                    }
                    if (tabToolTip.GetToolTip(MainTabControl) != toolTipText)// Show tooltip only if the mouse is over a new tab
                    {
                        tabToolTip.SetToolTip(MainTabControl, toolTipText);
                    }
                    return; // Exit after finding the correct tab
                }
            }
            tabToolTip.SetToolTip(MainTabControl, "");// Clear tooltip if not over any tab
        }

        private void MainPageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ? MessageBox.Show("Are you sure you want to close the app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) :
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
                    case Keys.R:
                        MainTabControl.SelectedTab = mainFormTabPage; // Alt+R goes to Register Member tab
                        break;
                    case Keys.M:
                        MainTabControl.SelectedTab = viewAllGymMemberTab; // Alt+M goes to Members tab
                        break;
                    case Keys.S:
                        MainTabControl.SelectedTab = SecurityTabPage; // Alt+S goes to System Security tab
                        break;
                    case Keys.C:
                        MainTabControl.SelectedTab = customizeLogoApp; // Alt+C goes to Customize tab
                        break;
                    case Keys.T:
                        MainTabControl.SelectedTab = tutorialTabPage; // Alt+T goes to Tutorial tab
                        break;
                }
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
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ? MessageBox.Show("Do you confirm the 120$ purchase?", "Confirmation", messageBoxButtons, icon) : 
                    MessageBox.Show("Do you confirm the 120$ purchase?", "Confirmation", messageBoxButtons, icon);
                switch (result)
                {
                    case DialogResult.OK:
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
                        removeScreenButton.Visible = true;
                        break;
                    case DialogResult.Cancel:
                        MainTabControl.SelectedTab = MainTabControl.TabPages["mainFormTabPage"]; //Goes back to loginTab
                        break;
                }

            }
            else
            {
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

        private void removeScreenButton_Click(object sender, EventArgs e)
        {
            gymMemberCreateDetails.Text = "";
        }

        private void viewAllGymMemberTab_Click(object sender, EventArgs e)
        {
            string memberListString = "";
            for (int i = 0; i < members.Count; i++)
            {
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

        private void linkLabelTutorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelTutorial.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCga77LEM3YbINDqkUwdCxpQ");
        }

        private void loadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.ico";
            openFileDialog.Title = "Select a Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;

                // write the path into a local file 
                File.WriteAllText(@"../../data/iconpath.txt", fileName);

                logoPictureBox.Image = System.Drawing.Image.FromFile(fileName);
            }
        }

        private void buttonToIcon_Click(object sender, EventArgs e)
        {
            if (logoPictureBox.Image != null)
            {
                Icon = new Icon(fileName);
            }
            else
            {
                MessageBox.Show("Please load an image into the PictureBox first.");
            }
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            AppLanguage.ApplyLanguage(this);
            timerDateTime.Interval = 100;
            timerDateTime.Tick += new EventHandler(timerDateTime_Tick);
            timerDateTime.Start();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
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

        // searchButton event handler
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResultListBox.Items.Clear();
            if (int.TryParse(searchTextBox.Text, out int searchID))
            {
                GymMember member = members.Find(m => m.Id == searchID);

                if (member != null)
                {
                    searchResultListBox.Items.Add(member);
                }
                else
                {
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
            else {
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

        // Renew Button in Expiring Soon tab, event handler
        private void renewButton_Click(object sender, EventArgs e)
        {
            if (expiringMembersListBox.SelectedItem is GymMember member) 
            {
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ? MessageBox.Show("Confirmez-vous l’achat de 120 $ ?", "Confirmation", messageBoxButtons, icon) : 
                                                                                     MessageBox.Show("Do you confirm the 120$ purchase?", "Confirmation", messageBoxButtons, icon);
                switch (result)
                {
                    case DialogResult.OK:
                        member.RenewMembership("Gym Member List.ser", members);
                        expiringMembersListBox.Items.Remove(member);
                        profit += 120;
                        SaveProfit("ProfitFile.txt");
                        removeScreenButton.Visible = true;
                        if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                        {
                            MessageBox.Show($"Abonnement renouvelé jusqu’à {member.ExpiringDate:yyyy-MM-dd}.");
                            }
                        else
                        {
                            MessageBox.Show($"Membership renewed unlil {member.ExpiringDate:yyyy-MM-dd}.");
                            }
                        break;
                    case DialogResult.Cancel:
                        break;
                }

                }
        }

        // Renew Button in Lookup Tab, event handler
        private void renewButton2_Click(object sender, EventArgs e)
        {
            if (searchResultListBox.SelectedItem is GymMember member)
            {
                if (member.IsExpiringSoon())
                {

                    MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
                    MessageBoxIcon icon = MessageBoxIcon.Question;
                    DialogResult result = (AppLanguage.CurrentCulture.Equals("fr-CA")) ? MessageBox.Show("Confirmez-vous l’achat de 120 $ ?", "Confirmation", messageBoxButtons, icon) : 
                                                                                         MessageBox.Show("Do you confirm the 120$ purchase?", "Confirmation", messageBoxButtons, icon);
                    switch (result)
                    {
                        case DialogResult.OK:
                            member.RenewMembership("Gym Member List.ser", members);
                            profit += 120;
                            SaveProfit("ProfitFile.txt");
                            searchResultListBox.Items.Remove(member);
                            searchResultListBox.Items.Add(member);
                            removeScreenButton.Visible = true;
                            if (AppLanguage.CurrentCulture.Equals("fr-CA"))
                            {
                                MessageBox.Show($"Abonnement renouvelé jusqu’à {member.ExpiringDate:yyyy-MM-dd}.");
                            }
                            else
                            {
                                MessageBox.Show($"Membership renewed unlil {member.ExpiringDate:yyyy-MM-dd}.");
                            }
                            break ;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                else
                {
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
        private void ExpirationTabPage_Enter(object sender, EventArgs e)
        {
            expiringMembersListBox.Items.Clear();
            foreach (var member in members)
            {
                if (member.IsExpiringSoon())
                {
                    expiringMembersListBox.Items.Add(member);
                }
            }
        }

        // Deactivate button event handler
        private void deactivateMemberButton_Click(object sender, EventArgs e)
        {
            if (searchResultListBox.SelectedItem == null)
            {
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
                string reason = (AppLanguage.CurrentCulture.Equals("fr-CA")) ? member.PromptForReason("Entrez la raison pour désactiver ce membre.") : member.PromptForReason("Enter the reason for deactivating this member");
                if (!string.IsNullOrWhiteSpace(reason))
                {
                    member.DeactivateMembership(reason, "Gym Member List.ser", members);
                    searchResultListBox.Items.Remove(member);
                    searchResultListBox.Items.Add(member);
                }
                else
                {
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

        // Reactivate button event handler
        private void reactivateMemberButton_Click(object sender, EventArgs e)
        {
            if (searchResultListBox.SelectedItem == null)
            {
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
                member.ReactivateMembership("Gym Member List.ser", members);
                searchResultListBox.Items.Remove(member);
                searchResultListBox.Items.Add(member);
            }
        }

        private void deactivationReasonTabPage_Enter(object sender, EventArgs e)
        {
            deactivationReasonsRichTextBox.Clear();
            foreach (var member in members)
            {
                if (!member.IsActiveMembership && !string.IsNullOrEmpty(member.DeactivationReason))
                {
                    deactivationReasonsRichTextBox.AppendText($"{member.Id} - {member.Name} - {member.DeactivationReason}\n\n");
                }
            }
        }

        private void revenueTabPage_Enter(object sender, EventArgs e)
        {
            int profit = LoadProfit("ProfitFile.txt");
            profitLabel.Text = profit.ToString("C");
            if (profit > 0 && profit <= 1000)
            {
                profitLabel.BackColor = Color.Red;
            }
            else if (profit > 1000 && profit <= 3000)
            {
                profitLabel.BackColor = Color.Yellow;
            }
            else
            {
                profitLabel.BackColor= Color.Green;
            }
            
        }
    }
}
