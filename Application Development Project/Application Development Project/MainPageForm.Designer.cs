using System.Windows.Forms;

namespace Application_Development_Project
{
    partial class MainPageForm
    {
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void properClose()
        {
            this.FormClosing += MainForm_FormClosing;
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.mainFormTabPage = new System.Windows.Forms.TabPage();
            this.gymMemberCreateDetails = new System.Windows.Forms.Label();
            this.removeScreenButton = new System.Windows.Forms.Button();
            this.creditCardTextBox = new System.Windows.Forms.TextBox();
            this.creditCardNumber = new System.Windows.Forms.Label();
            this.tosLabel = new System.Windows.Forms.Label();
            this.agreeCheckBox = new System.Windows.Forms.CheckBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.createGymMemberButton = new System.Windows.Forms.Button();
            this.viewAllGymMemberTab = new System.Windows.Forms.TabPage();
            this.gymMemberListTextBox = new System.Windows.Forms.TextBox();
            this.SecurityTabPage = new System.Windows.Forms.TabPage();
            this.errorLabel = new System.Windows.Forms.Label();
            this.ChangeAttemptsLabel = new System.Windows.Forms.Button();
            this.attemtsTextBox = new System.Windows.Forms.TextBox();
            this.AttemptsLabel = new System.Windows.Forms.Label();
            this.resetErrorLabel = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.customizeLogoApp = new System.Windows.Forms.TabPage();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonToIcon = new System.Windows.Forms.Button();
            this.changeIconImageLabel = new System.Windows.Forms.Label();
            this.loadPicture = new System.Windows.Forms.Button();
            this.tutorialTabPage = new System.Windows.Forms.TabPage();
            this.linkLabelTutorial = new System.Windows.Forms.LinkLabel();
            this.pleaseWatchLabel = new System.Windows.Forms.Label();
            this.toolTipHover = new System.Windows.Forms.ToolTip(this.components);
            this.labelRegisterDate = new System.Windows.Forms.Label();
            this.labelRegisterTime = new System.Windows.Forms.Label();
            this.labelSystemDate = new System.Windows.Forms.Label();
            this.labelSystemTime = new System.Windows.Forms.Label();
            this.labelCustomizeDate = new System.Windows.Forms.Label();
            this.labelCustomizeTime = new System.Windows.Forms.Label();
            this.labelTutorialDate = new System.Windows.Forms.Label();
            this.labelTutorialTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.MainTabControl.SuspendLayout();
            this.mainFormTabPage.SuspendLayout();
            this.viewAllGymMemberTab.SuspendLayout();
            this.SecurityTabPage.SuspendLayout();
            this.customizeLogoApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.tutorialTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.mainFormTabPage);
            this.MainTabControl.Controls.Add(this.viewAllGymMemberTab);
            this.MainTabControl.Controls.Add(this.SecurityTabPage);
            this.MainTabControl.Controls.Add(this.customizeLogoApp);
            this.MainTabControl.Controls.Add(this.tutorialTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(821, 496);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.Click += new System.EventHandler(this.viewAllGymMemberTab_Click);
            // 
            // mainFormTabPage
            // 
            this.mainFormTabPage.Controls.Add(this.labelRegisterDate);
            this.mainFormTabPage.Controls.Add(this.labelRegisterTime);
            this.mainFormTabPage.Controls.Add(this.gymMemberCreateDetails);
            this.mainFormTabPage.Controls.Add(this.removeScreenButton);
            this.mainFormTabPage.Controls.Add(this.creditCardTextBox);
            this.mainFormTabPage.Controls.Add(this.creditCardNumber);
            this.mainFormTabPage.Controls.Add(this.tosLabel);
            this.mainFormTabPage.Controls.Add(this.agreeCheckBox);
            this.mainFormTabPage.Controls.Add(this.addressTextBox);
            this.mainFormTabPage.Controls.Add(this.addressLabel);
            this.mainFormTabPage.Controls.Add(this.emailAddressTextBox);
            this.mainFormTabPage.Controls.Add(this.emailAddressLabel);
            this.mainFormTabPage.Controls.Add(this.phoneNumberTextBox);
            this.mainFormTabPage.Controls.Add(this.phoneNumberLabel);
            this.mainFormTabPage.Controls.Add(this.nameTextBox);
            this.mainFormTabPage.Controls.Add(this.nameLabel);
            this.mainFormTabPage.Controls.Add(this.createGymMemberButton);
            this.mainFormTabPage.Location = new System.Drawing.Point(4, 25);
            this.mainFormTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainFormTabPage.Name = "mainFormTabPage";
            this.mainFormTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainFormTabPage.Size = new System.Drawing.Size(813, 467);
            this.mainFormTabPage.TabIndex = 0;
            this.mainFormTabPage.Text = "Register member";
            this.mainFormTabPage.UseVisualStyleBackColor = true;
            // 
            // gymMemberCreateDetails
            // 
            this.gymMemberCreateDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gymMemberCreateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymMemberCreateDetails.Location = new System.Drawing.Point(237, 338);
            this.gymMemberCreateDetails.Name = "gymMemberCreateDetails";
            this.gymMemberCreateDetails.Size = new System.Drawing.Size(413, 117);
            this.gymMemberCreateDetails.TabIndex = 14;
            // 
            // removeScreenButton
            // 
            this.removeScreenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeScreenButton.Location = new System.Drawing.Point(669, 402);
            this.removeScreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeScreenButton.Name = "removeScreenButton";
            this.removeScreenButton.Size = new System.Drawing.Size(135, 52);
            this.removeScreenButton.TabIndex = 13;
            this.removeScreenButton.Text = "Ok";
            this.removeScreenButton.UseVisualStyleBackColor = true;
            this.removeScreenButton.Visible = false;
            this.removeScreenButton.Click += new System.EventHandler(this.removeScreenButton_Click);
            // 
            // creditCardTextBox
            // 
            this.creditCardTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creditCardTextBox.Location = new System.Drawing.Point(17, 294);
            this.creditCardTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditCardTextBox.Name = "creditCardTextBox";
            this.creditCardTextBox.Size = new System.Drawing.Size(161, 22);
            this.creditCardTextBox.TabIndex = 12;
            // 
            // creditCardNumber
            // 
            this.creditCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creditCardNumber.AutoSize = true;
            this.creditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardNumber.Location = new System.Drawing.Point(13, 270);
            this.creditCardNumber.Name = "creditCardNumber";
            this.creditCardNumber.Size = new System.Drawing.Size(175, 22);
            this.creditCardNumber.TabIndex = 11;
            this.creditCardNumber.Text = "Credit Card Number:";
            // 
            // tosLabel
            // 
            this.tosLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosLabel.Location = new System.Drawing.Point(197, 26);
            this.tosLabel.Name = "tosLabel";
            this.tosLabel.Size = new System.Drawing.Size(409, 313);
            this.tosLabel.TabIndex = 10;
            this.tosLabel.Text = resources.GetString("tosLabel.Text");
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agreeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeCheckBox.Location = new System.Drawing.Point(17, 338);
            this.agreeCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(183, 52);
            this.agreeCheckBox.TabIndex = 9;
            this.agreeCheckBox.Text = "I Agree To terms Of Srevice ";
            this.agreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Location = new System.Drawing.Point(17, 199);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(161, 66);
            this.addressTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(13, 175);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(81, 22);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address:";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailAddressTextBox.Location = new System.Drawing.Point(17, 144);
            this.emailAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(161, 22);
            this.emailAddressTextBox.TabIndex = 6;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(13, 119);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(130, 22);
            this.emailAddressLabel.TabIndex = 5;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(17, 85);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(161, 22);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(13, 60);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(135, 22);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(17, 28);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(161, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 2);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // createGymMemberButton
            // 
            this.createGymMemberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createGymMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGymMemberButton.Location = new System.Drawing.Point(8, 402);
            this.createGymMemberButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createGymMemberButton.Name = "createGymMemberButton";
            this.createGymMemberButton.Size = new System.Drawing.Size(224, 52);
            this.createGymMemberButton.TabIndex = 0;
            this.createGymMemberButton.Text = "Create Gym Member";
            this.createGymMemberButton.UseVisualStyleBackColor = true;
            this.createGymMemberButton.Click += new System.EventHandler(this.createGymMemberButton_Click);
            // 
            // viewAllGymMemberTab
            // 
            this.viewAllGymMemberTab.Controls.Add(this.gymMemberListTextBox);
            this.viewAllGymMemberTab.Location = new System.Drawing.Point(4, 25);
            this.viewAllGymMemberTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewAllGymMemberTab.Name = "viewAllGymMemberTab";
            this.viewAllGymMemberTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewAllGymMemberTab.Size = new System.Drawing.Size(813, 467);
            this.viewAllGymMemberTab.TabIndex = 1;
            this.viewAllGymMemberTab.Text = "Members";
            this.viewAllGymMemberTab.UseVisualStyleBackColor = true;
            // 
            // gymMemberListTextBox
            // 
            this.gymMemberListTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gymMemberListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymMemberListTextBox.Location = new System.Drawing.Point(3, 2);
            this.gymMemberListTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gymMemberListTextBox.Multiline = true;
            this.gymMemberListTextBox.Name = "gymMemberListTextBox";
            this.gymMemberListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gymMemberListTextBox.Size = new System.Drawing.Size(807, 463);
            this.gymMemberListTextBox.TabIndex = 0;
            // 
            // SecurityTabPage
            // 
            this.SecurityTabPage.Controls.Add(this.labelSystemDate);
            this.SecurityTabPage.Controls.Add(this.labelSystemTime);
            this.SecurityTabPage.Controls.Add(this.errorLabel);
            this.SecurityTabPage.Controls.Add(this.ChangeAttemptsLabel);
            this.SecurityTabPage.Controls.Add(this.attemtsTextBox);
            this.SecurityTabPage.Controls.Add(this.AttemptsLabel);
            this.SecurityTabPage.Controls.Add(this.resetErrorLabel);
            this.SecurityTabPage.Controls.Add(this.oldPasswordTextBox);
            this.SecurityTabPage.Controls.Add(this.oldPassLabel);
            this.SecurityTabPage.Controls.Add(this.changePasswordButton);
            this.SecurityTabPage.Controls.Add(this.instructionLabel);
            this.SecurityTabPage.Controls.Add(this.newPasswordTextBox);
            this.SecurityTabPage.Controls.Add(this.newPassLabel);
            this.SecurityTabPage.Location = new System.Drawing.Point(4, 25);
            this.SecurityTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecurityTabPage.Name = "SecurityTabPage";
            this.SecurityTabPage.Size = new System.Drawing.Size(813, 467);
            this.SecurityTabPage.TabIndex = 2;
            this.SecurityTabPage.Text = "System Security";
            this.SecurityTabPage.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(223, 116);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(415, 28);
            this.errorLabel.TabIndex = 24;
            // 
            // ChangeAttemptsLabel
            // 
            this.ChangeAttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAttemptsLabel.Location = new System.Drawing.Point(36, 90);
            this.ChangeAttemptsLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeAttemptsLabel.Name = "ChangeAttemptsLabel";
            this.ChangeAttemptsLabel.Size = new System.Drawing.Size(129, 63);
            this.ChangeAttemptsLabel.TabIndex = 23;
            this.ChangeAttemptsLabel.Text = "Change Attempts";
            this.ChangeAttemptsLabel.UseVisualStyleBackColor = true;
            this.ChangeAttemptsLabel.Click += new System.EventHandler(this.ChangeAttemptsLabel_Click);
            // 
            // attemtsTextBox
            // 
            this.attemtsTextBox.Location = new System.Drawing.Point(228, 59);
            this.attemtsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attemtsTextBox.Name = "attemtsTextBox";
            this.attemtsTextBox.Size = new System.Drawing.Size(353, 22);
            this.attemtsTextBox.TabIndex = 21;
            // 
            // AttemptsLabel
            // 
            this.AttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptsLabel.Location = new System.Drawing.Point(31, 28);
            this.AttemptsLabel.Name = "AttemptsLabel";
            this.AttemptsLabel.Size = new System.Drawing.Size(197, 59);
            this.AttemptsLabel.TabIndex = 20;
            this.AttemptsLabel.Text = "New Allowed Number of Attempts: ";
            // 
            // resetErrorLabel
            // 
            this.resetErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetErrorLabel.Location = new System.Drawing.Point(299, 356);
            this.resetErrorLabel.Name = "resetErrorLabel";
            this.resetErrorLabel.Size = new System.Drawing.Size(415, 28);
            this.resetErrorLabel.TabIndex = 19;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(191, 194);
            this.oldPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.oldPasswordTextBox.TabIndex = 18;
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassLabel.Location = new System.Drawing.Point(29, 194);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(165, 28);
            this.oldPassLabel.TabIndex = 17;
            this.oldPassLabel.Text = "Old Password: ";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.Location = new System.Drawing.Point(36, 263);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(129, 63);
            this.changePasswordButton.TabIndex = 16;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(187, 261);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(459, 28);
            this.instructionLabel.TabIndex = 15;
            this.instructionLabel.Text = "New System password will be aplied on next start up";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(191, 233);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.newPasswordTextBox.TabIndex = 14;
            // 
            // newPassLabel
            // 
            this.newPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.Location = new System.Drawing.Point(29, 233);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(165, 28);
            this.newPassLabel.TabIndex = 13;
            this.newPassLabel.Text = "New Password: ";
            // 
            // customizeLogoApp
            // 
            this.customizeLogoApp.Controls.Add(this.labelCustomizeDate);
            this.customizeLogoApp.Controls.Add(this.labelCustomizeTime);
            this.customizeLogoApp.Controls.Add(this.logoPictureBox);
            this.customizeLogoApp.Controls.Add(this.buttonToIcon);
            this.customizeLogoApp.Controls.Add(this.changeIconImageLabel);
            this.customizeLogoApp.Controls.Add(this.loadPicture);
            this.customizeLogoApp.Location = new System.Drawing.Point(4, 25);
            this.customizeLogoApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customizeLogoApp.Name = "customizeLogoApp";
            this.customizeLogoApp.Size = new System.Drawing.Size(813, 467);
            this.customizeLogoApp.TabIndex = 4;
            this.customizeLogoApp.Text = "Customize";
            this.customizeLogoApp.UseVisualStyleBackColor = true;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Location = new System.Drawing.Point(248, 102);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(302, 254);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // buttonToIcon
            // 
            this.buttonToIcon.Location = new System.Drawing.Point(419, 375);
            this.buttonToIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonToIcon.Name = "buttonToIcon";
            this.buttonToIcon.Size = new System.Drawing.Size(132, 36);
            this.buttonToIcon.TabIndex = 2;
            this.buttonToIcon.Text = "Add as icon";
            this.buttonToIcon.UseVisualStyleBackColor = true;
            this.buttonToIcon.Click += new System.EventHandler(this.buttonToIcon_Click);
            // 
            // changeIconImageLabel
            // 
            this.changeIconImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeIconImageLabel.Location = new System.Drawing.Point(231, 50);
            this.changeIconImageLabel.Name = "changeIconImageLabel";
            this.changeIconImageLabel.Size = new System.Drawing.Size(336, 48);
            this.changeIconImageLabel.TabIndex = 1;
            this.changeIconImageLabel.Text = "Choose a new icon image for GMMS *must be .ico type image*";
            this.changeIconImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadPicture
            // 
            this.loadPicture.Location = new System.Drawing.Point(247, 375);
            this.loadPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(139, 36);
            this.loadPicture.TabIndex = 0;
            this.loadPicture.Text = "Load picture";
            this.loadPicture.UseVisualStyleBackColor = true;
            this.loadPicture.Click += new System.EventHandler(this.loadPicture_Click);
            // 
            // tutorialTabPage
            // 
            this.tutorialTabPage.Controls.Add(this.labelTutorialDate);
            this.tutorialTabPage.Controls.Add(this.labelTutorialTime);
            this.tutorialTabPage.Controls.Add(this.linkLabelTutorial);
            this.tutorialTabPage.Controls.Add(this.pleaseWatchLabel);
            this.tutorialTabPage.Location = new System.Drawing.Point(4, 25);
            this.tutorialTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tutorialTabPage.Name = "tutorialTabPage";
            this.tutorialTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tutorialTabPage.Size = new System.Drawing.Size(813, 467);
            this.tutorialTabPage.TabIndex = 3;
            this.tutorialTabPage.Text = "Tutorial";
            this.tutorialTabPage.UseVisualStyleBackColor = true;
            // 
            // linkLabelTutorial
            // 
            this.linkLabelTutorial.AutoSize = true;
            this.linkLabelTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTutorial.Location = new System.Drawing.Point(337, 222);
            this.linkLabelTutorial.Name = "linkLabelTutorial";
            this.linkLabelTutorial.Size = new System.Drawing.Size(108, 20);
            this.linkLabelTutorial.TabIndex = 1;
            this.linkLabelTutorial.TabStop = true;
            this.linkLabelTutorial.Text = "Click this link";
            this.linkLabelTutorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTutorial_LinkClicked);
            // 
            // pleaseWatchLabel
            // 
            this.pleaseWatchLabel.AutoSize = true;
            this.pleaseWatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseWatchLabel.Location = new System.Drawing.Point(120, 172);
            this.pleaseWatchLabel.Name = "pleaseWatchLabel";
            this.pleaseWatchLabel.Size = new System.Drawing.Size(576, 20);
            this.pleaseWatchLabel.TabIndex = 0;
            this.pleaseWatchLabel.Text = "Please watch the following tutorial to familiarize yourself with the application";
            // 
            // toolTipHover
            // 
            this.toolTipHover.AutomaticDelay = 200;
            // 
            // labelRegisterDate
            // 
            this.labelRegisterDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegisterDate.Location = new System.Drawing.Point(654, 32);
            this.labelRegisterDate.Name = "labelRegisterDate";
            this.labelRegisterDate.Size = new System.Drawing.Size(154, 25);
            this.labelRegisterDate.TabIndex = 16;
            this.labelRegisterDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRegisterTime
            // 
            this.labelRegisterTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegisterTime.Location = new System.Drawing.Point(685, 0);
            this.labelRegisterTime.Name = "labelRegisterTime";
            this.labelRegisterTime.Size = new System.Drawing.Size(125, 22);
            this.labelRegisterTime.TabIndex = 15;
            this.labelRegisterTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSystemDate
            // 
            this.labelSystemDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSystemDate.Location = new System.Drawing.Point(657, 32);
            this.labelSystemDate.Name = "labelSystemDate";
            this.labelSystemDate.Size = new System.Drawing.Size(154, 25);
            this.labelSystemDate.TabIndex = 26;
            this.labelSystemDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSystemTime
            // 
            this.labelSystemTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSystemTime.Location = new System.Drawing.Point(688, 0);
            this.labelSystemTime.Name = "labelSystemTime";
            this.labelSystemTime.Size = new System.Drawing.Size(125, 22);
            this.labelSystemTime.TabIndex = 25;
            this.labelSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomizeDate
            // 
            this.labelCustomizeDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomizeDate.Location = new System.Drawing.Point(657, 32);
            this.labelCustomizeDate.Name = "labelCustomizeDate";
            this.labelCustomizeDate.Size = new System.Drawing.Size(154, 25);
            this.labelCustomizeDate.TabIndex = 10;
            this.labelCustomizeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomizeTime
            // 
            this.labelCustomizeTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomizeTime.Location = new System.Drawing.Point(688, 0);
            this.labelCustomizeTime.Name = "labelCustomizeTime";
            this.labelCustomizeTime.Size = new System.Drawing.Size(125, 22);
            this.labelCustomizeTime.TabIndex = 9;
            this.labelCustomizeTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTutorialDate
            // 
            this.labelTutorialDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTutorialDate.Location = new System.Drawing.Point(656, 34);
            this.labelTutorialDate.Name = "labelTutorialDate";
            this.labelTutorialDate.Size = new System.Drawing.Size(154, 25);
            this.labelTutorialDate.TabIndex = 10;
            this.labelTutorialDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTutorialTime
            // 
            this.labelTutorialTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTutorialTime.Location = new System.Drawing.Point(685, 2);
            this.labelTutorialTime.Name = "labelTutorialTime";
            this.labelTutorialTime.Size = new System.Drawing.Size(125, 22);
            this.labelTutorialTime.TabIndex = 9;
            this.labelTutorialTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 496);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPageForm";
            this.Text = "GMMS Main Page ";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainPageForm_KeyDown);
            this.MainTabControl.ResumeLayout(false);
            this.mainFormTabPage.ResumeLayout(false);
            this.mainFormTabPage.PerformLayout();
            this.viewAllGymMemberTab.ResumeLayout(false);
            this.viewAllGymMemberTab.PerformLayout();
            this.SecurityTabPage.ResumeLayout(false);
            this.SecurityTabPage.PerformLayout();
            this.customizeLogoApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.tutorialTabPage.ResumeLayout(false);
            this.tutorialTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage mainFormTabPage;
        private TabPage viewAllGymMemberTab;
        private TabPage SecurityTabPage;
        private TextBox oldPasswordTextBox;
        private Label oldPassLabel;
        private Button changePasswordButton;
        private Label instructionLabel;
        private TextBox newPasswordTextBox;
        private Label newPassLabel;
        private Label resetErrorLabel;
        private Label errorLabel;
        private Button ChangeAttemptsLabel;
        private TextBox attemtsTextBox;
        private Label AttemptsLabel;
        private Label nameLabel;
        private Button createGymMemberButton;
        private TextBox nameTextBox;
        private TextBox emailAddressTextBox;
        private Label emailAddressLabel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private CheckBox agreeCheckBox;
        private TextBox creditCardTextBox;
        private Label creditCardNumber;
        private Label tosLabel;
        private Label gymMemberCreateDetails;
        private Button removeScreenButton;
        private TextBox gymMemberListTextBox;
        private TabPage tutorialTabPage;
        private LinkLabel linkLabelTutorial;
        private Label pleaseWatchLabel;
        private ToolTip toolTipHover;
        private TabPage customizeLogoApp;
        private Label changeIconImageLabel;
        private Button loadPicture;
        private Button buttonToIcon;
        private PictureBox logoPictureBox;
        private Label labelRegisterDate;
        private Label labelRegisterTime;
        private Label labelSystemDate;
        private Label labelSystemTime;
        private Label labelCustomizeDate;
        private Label labelCustomizeTime;
        private Label labelTutorialDate;
        private Label labelTutorialTime;
        private Timer timerDateTime;
    }
}