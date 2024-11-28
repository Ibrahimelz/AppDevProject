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
                DialogResult result = MessageBox.Show("Are you sure you want to close the app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                DialogResult result = MessageBox.Show("Do you confirm the 120$ purchase?", "Confirmation", messageBoxButtons, icon);
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
        }
    }
}
