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
        private ToolTip tabToolTip; // Declare ToolTip object
        public MainPageForm()
        {
            InitializeComponent();
            InitializeTabTooltips();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MainPageForm_KeyDown);

            this.mainFormTabPage.Text = "&Register Member"; // Alt+R shortcut
            this.viewAllGymMemberTab.Text = "&Members"; // Alt+M shortcut
            this.SecurityTabPage.Text = "System &Security"; // Alt+S shortcut
            this.customizeLogoApp.Text = "&Customize"; // Alt+C shortcut
            this.tutorialTabPage.Text = "&Tutorial"; // Alt+T shortcut

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
                this.Close(); // Closes the form
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
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select a Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logoPictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonToIcon_Click(object sender, EventArgs e)
        {
            if (logoPictureBox.Image != null)
            {
                Icon icon = ConvertImageToIcon(logoPictureBox.Image, new Size(32, 32)); // Converts Image to Icon and the Icon size is 32x32 because its recommended

                LoginPageForm loginPageForm = new LoginPageForm();// Set icon for Form2
                loginPageForm.Icon = icon;
                loginPageForm.Show();
            }
            else
            {
                MessageBox.Show("Please load an image into the PictureBox first.");
            }
        }
        private Icon ConvertImageToIcon(Image image, Size size)
        {
            Bitmap bitmap = new Bitmap(image, size); // Resize the image
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Saves the bitmap as a .ico format in memory stream and temporary save as PNG
                ms.Seek(0, SeekOrigin.Begin); // Reset stream position

                return new Icon(ms);// Convert to icon using Icon constructor
            }
        }


    }
}
