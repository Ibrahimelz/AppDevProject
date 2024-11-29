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
            this.labelRegisterDate = new System.Windows.Forms.Label();
            this.labelRegisterTime = new System.Windows.Forms.Label();
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
            this.labelSystemDate = new System.Windows.Forms.Label();
            this.labelSystemTime = new System.Windows.Forms.Label();
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
            this.labelCustomizeDate = new System.Windows.Forms.Label();
            this.labelCustomizeTime = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonToIcon = new System.Windows.Forms.Button();
            this.changeIconImageLabel = new System.Windows.Forms.Label();
            this.loadPicture = new System.Windows.Forms.Button();
            this.searchMemberTabPage = new System.Windows.Forms.TabPage();
            this.reactivateMemberButton = new System.Windows.Forms.Button();
            this.deactivateMemberButton = new System.Windows.Forms.Button();
            this.renewButton2 = new System.Windows.Forms.Button();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.expirationTabPage = new System.Windows.Forms.TabPage();
            this.renewButton = new System.Windows.Forms.Button();
            this.expiringMembersListBox = new System.Windows.Forms.ListBox();
            this.tutorialTabPage = new System.Windows.Forms.TabPage();
            this.labelTutorialDate = new System.Windows.Forms.Label();
            this.labelTutorialTime = new System.Windows.Forms.Label();
            this.linkLabelTutorial = new System.Windows.Forms.LinkLabel();
            this.pleaseWatchLabel = new System.Windows.Forms.Label();
            this.toolTipHover = new System.Windows.Forms.ToolTip(this.components);
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.deactivationReasonTabPage = new System.Windows.Forms.TabPage();
            this.deactivationReasonsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.deactivationReasonLabel = new System.Windows.Forms.Label();
            this.revenueTabPage = new System.Windows.Forms.TabPage();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.belowTargetLabel = new System.Windows.Forms.Label();
            this.onTargetLabel = new System.Windows.Forms.Label();
            this.aboveTargetLabel = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.labelLookupDate = new System.Windows.Forms.Label();
            this.labelLookupTime = new System.Windows.Forms.Label();
            this.labelExpiringDate = new System.Windows.Forms.Label();
            this.labelExpiringTime = new System.Windows.Forms.Label();
            this.labelDeactivationDate = new System.Windows.Forms.Label();
            this.labelDeactivationTime = new System.Windows.Forms.Label();
            this.labelRevenueDate = new System.Windows.Forms.Label();
            this.labelRevenueTime = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.mainFormTabPage.SuspendLayout();
            this.viewAllGymMemberTab.SuspendLayout();
            this.SecurityTabPage.SuspendLayout();
            this.customizeLogoApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.searchMemberTabPage.SuspendLayout();
            this.expirationTabPage.SuspendLayout();
            this.tutorialTabPage.SuspendLayout();
            this.deactivationReasonTabPage.SuspendLayout();
            this.revenueTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.mainFormTabPage);
            this.MainTabControl.Controls.Add(this.viewAllGymMemberTab);
            this.MainTabControl.Controls.Add(this.searchMemberTabPage);
            this.MainTabControl.Controls.Add(this.expirationTabPage);
            this.MainTabControl.Controls.Add(this.revenueTabPage);
            this.MainTabControl.Controls.Add(this.deactivationReasonTabPage);
            this.MainTabControl.Controls.Add(this.SecurityTabPage);
            this.MainTabControl.Controls.Add(this.customizeLogoApp);
            this.MainTabControl.Controls.Add(this.tutorialTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1232, 775);
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
            this.mainFormTabPage.Location = new System.Drawing.Point(8, 39);
            this.mainFormTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainFormTabPage.Name = "mainFormTabPage";
            this.mainFormTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainFormTabPage.Size = new System.Drawing.Size(1216, 728);
            this.mainFormTabPage.TabIndex = 0;
            this.mainFormTabPage.Text = "Register member";
            this.mainFormTabPage.UseVisualStyleBackColor = true;
            // 
            // labelRegisterDate
            // 
            this.labelRegisterDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegisterDate.Location = new System.Drawing.Point(981, 50);
            this.labelRegisterDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegisterDate.Name = "labelRegisterDate";
            this.labelRegisterDate.Size = new System.Drawing.Size(231, 39);
            this.labelRegisterDate.TabIndex = 16;
            this.labelRegisterDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRegisterTime
            // 
            this.labelRegisterTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegisterTime.Location = new System.Drawing.Point(1028, 0);
            this.labelRegisterTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegisterTime.Name = "labelRegisterTime";
            this.labelRegisterTime.Size = new System.Drawing.Size(188, 34);
            this.labelRegisterTime.TabIndex = 15;
            this.labelRegisterTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gymMemberCreateDetails
            // 
            this.gymMemberCreateDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gymMemberCreateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymMemberCreateDetails.Location = new System.Drawing.Point(356, 528);
            this.gymMemberCreateDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gymMemberCreateDetails.Name = "gymMemberCreateDetails";
            this.gymMemberCreateDetails.Size = new System.Drawing.Size(620, 183);
            this.gymMemberCreateDetails.TabIndex = 14;
            // 
            // removeScreenButton
            // 
            this.removeScreenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeScreenButton.Location = new System.Drawing.Point(1004, 628);
            this.removeScreenButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeScreenButton.Name = "removeScreenButton";
            this.removeScreenButton.Size = new System.Drawing.Size(202, 81);
            this.removeScreenButton.TabIndex = 13;
            this.removeScreenButton.Text = "Ok";
            this.removeScreenButton.UseVisualStyleBackColor = true;
            this.removeScreenButton.Visible = false;
            this.removeScreenButton.Click += new System.EventHandler(this.removeScreenButton_Click);
            // 
            // creditCardTextBox
            // 
            this.creditCardTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creditCardTextBox.Location = new System.Drawing.Point(26, 459);
            this.creditCardTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.creditCardTextBox.Name = "creditCardTextBox";
            this.creditCardTextBox.Size = new System.Drawing.Size(240, 31);
            this.creditCardTextBox.TabIndex = 12;
            // 
            // creditCardNumber
            // 
            this.creditCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creditCardNumber.AutoSize = true;
            this.creditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardNumber.Location = new System.Drawing.Point(20, 422);
            this.creditCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditCardNumber.Name = "creditCardNumber";
            this.creditCardNumber.Size = new System.Drawing.Size(284, 33);
            this.creditCardNumber.TabIndex = 11;
            this.creditCardNumber.Text = "Credit Card Number:";
            // 
            // tosLabel
            // 
            this.tosLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosLabel.Location = new System.Drawing.Point(296, 41);
            this.tosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tosLabel.Name = "tosLabel";
            this.tosLabel.Size = new System.Drawing.Size(614, 489);
            this.tosLabel.TabIndex = 10;
            this.tosLabel.Text = resources.GetString("tosLabel.Text");
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agreeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeCheckBox.Location = new System.Drawing.Point(26, 528);
            this.agreeCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(274, 81);
            this.agreeCheckBox.TabIndex = 9;
            this.agreeCheckBox.Text = "I Agree To terms Of Srevice ";
            this.agreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Location = new System.Drawing.Point(26, 311);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(240, 101);
            this.addressTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(20, 273);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(130, 33);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address:";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailAddressTextBox.Location = new System.Drawing.Point(26, 225);
            this.emailAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(240, 31);
            this.emailAddressTextBox.TabIndex = 6;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(20, 186);
            this.emailAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(212, 33);
            this.emailAddressLabel.TabIndex = 5;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(26, 133);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(240, 31);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(20, 94);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(218, 33);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(26, 44);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 31);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(20, 3);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(101, 33);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // createGymMemberButton
            // 
            this.createGymMemberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createGymMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGymMemberButton.Location = new System.Drawing.Point(12, 628);
            this.createGymMemberButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createGymMemberButton.Name = "createGymMemberButton";
            this.createGymMemberButton.Size = new System.Drawing.Size(336, 81);
            this.createGymMemberButton.TabIndex = 0;
            this.createGymMemberButton.Text = "Create Gym Member";
            this.createGymMemberButton.UseVisualStyleBackColor = true;
            this.createGymMemberButton.Click += new System.EventHandler(this.createGymMemberButton_Click);
            // 
            // viewAllGymMemberTab
            // 
            this.viewAllGymMemberTab.Controls.Add(this.gymMemberListTextBox);
            this.viewAllGymMemberTab.Location = new System.Drawing.Point(8, 39);
            this.viewAllGymMemberTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewAllGymMemberTab.Name = "viewAllGymMemberTab";
            this.viewAllGymMemberTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewAllGymMemberTab.Size = new System.Drawing.Size(1216, 728);
            this.viewAllGymMemberTab.TabIndex = 1;
            this.viewAllGymMemberTab.Text = "Members";
            this.viewAllGymMemberTab.UseVisualStyleBackColor = true;
            // 
            // gymMemberListTextBox
            // 
            this.gymMemberListTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gymMemberListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymMemberListTextBox.Location = new System.Drawing.Point(4, 3);
            this.gymMemberListTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gymMemberListTextBox.Multiline = true;
            this.gymMemberListTextBox.Name = "gymMemberListTextBox";
            this.gymMemberListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gymMemberListTextBox.Size = new System.Drawing.Size(1208, 722);
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
            this.SecurityTabPage.Location = new System.Drawing.Point(8, 39);
            this.SecurityTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SecurityTabPage.Name = "SecurityTabPage";
            this.SecurityTabPage.Size = new System.Drawing.Size(1216, 728);
            this.SecurityTabPage.TabIndex = 2;
            this.SecurityTabPage.Text = "System Security";
            this.SecurityTabPage.UseVisualStyleBackColor = true;
            // 
            // labelSystemDate
            // 
            this.labelSystemDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSystemDate.Location = new System.Drawing.Point(986, 50);
            this.labelSystemDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSystemDate.Name = "labelSystemDate";
            this.labelSystemDate.Size = new System.Drawing.Size(231, 39);
            this.labelSystemDate.TabIndex = 26;
            this.labelSystemDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSystemTime
            // 
            this.labelSystemTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSystemTime.Location = new System.Drawing.Point(1032, 0);
            this.labelSystemTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSystemTime.Name = "labelSystemTime";
            this.labelSystemTime.Size = new System.Drawing.Size(188, 34);
            this.labelSystemTime.TabIndex = 25;
            this.labelSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(334, 181);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(622, 44);
            this.errorLabel.TabIndex = 24;
            // 
            // ChangeAttemptsLabel
            // 
            this.ChangeAttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAttemptsLabel.Location = new System.Drawing.Point(54, 141);
            this.ChangeAttemptsLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChangeAttemptsLabel.Name = "ChangeAttemptsLabel";
            this.ChangeAttemptsLabel.Size = new System.Drawing.Size(194, 98);
            this.ChangeAttemptsLabel.TabIndex = 23;
            this.ChangeAttemptsLabel.Text = "Change Attempts";
            this.ChangeAttemptsLabel.UseVisualStyleBackColor = true;
            this.ChangeAttemptsLabel.Click += new System.EventHandler(this.ChangeAttemptsLabel_Click);
            // 
            // attemtsTextBox
            // 
            this.attemtsTextBox.Location = new System.Drawing.Point(342, 92);
            this.attemtsTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attemtsTextBox.Name = "attemtsTextBox";
            this.attemtsTextBox.Size = new System.Drawing.Size(528, 31);
            this.attemtsTextBox.TabIndex = 21;
            // 
            // AttemptsLabel
            // 
            this.AttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptsLabel.Location = new System.Drawing.Point(46, 44);
            this.AttemptsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttemptsLabel.Name = "AttemptsLabel";
            this.AttemptsLabel.Size = new System.Drawing.Size(296, 92);
            this.AttemptsLabel.TabIndex = 20;
            this.AttemptsLabel.Text = "New Allowed Number of Attempts: ";
            // 
            // resetErrorLabel
            // 
            this.resetErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetErrorLabel.Location = new System.Drawing.Point(448, 556);
            this.resetErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resetErrorLabel.Name = "resetErrorLabel";
            this.resetErrorLabel.Size = new System.Drawing.Size(622, 44);
            this.resetErrorLabel.TabIndex = 19;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(286, 303);
            this.oldPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(528, 31);
            this.oldPasswordTextBox.TabIndex = 18;
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassLabel.Location = new System.Drawing.Point(44, 303);
            this.oldPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(248, 44);
            this.oldPassLabel.TabIndex = 17;
            this.oldPassLabel.Text = "Old Password: ";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.Location = new System.Drawing.Point(54, 411);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(194, 98);
            this.changePasswordButton.TabIndex = 16;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(280, 408);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(688, 44);
            this.instructionLabel.TabIndex = 15;
            this.instructionLabel.Text = "New System password will be aplied on next start up";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(286, 364);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(528, 31);
            this.newPasswordTextBox.TabIndex = 14;
            // 
            // newPassLabel
            // 
            this.newPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.Location = new System.Drawing.Point(44, 364);
            this.newPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(248, 44);
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
            this.customizeLogoApp.Location = new System.Drawing.Point(8, 39);
            this.customizeLogoApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customizeLogoApp.Name = "customizeLogoApp";
            this.customizeLogoApp.Size = new System.Drawing.Size(1216, 728);
            this.customizeLogoApp.TabIndex = 4;
            this.customizeLogoApp.Text = "Customize";
            this.customizeLogoApp.UseVisualStyleBackColor = true;
            // 
            // labelCustomizeDate
            // 
            this.labelCustomizeDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomizeDate.Location = new System.Drawing.Point(986, 50);
            this.labelCustomizeDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomizeDate.Name = "labelCustomizeDate";
            this.labelCustomizeDate.Size = new System.Drawing.Size(231, 39);
            this.labelCustomizeDate.TabIndex = 10;
            this.labelCustomizeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomizeTime
            // 
            this.labelCustomizeTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomizeTime.Location = new System.Drawing.Point(1032, 0);
            this.labelCustomizeTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomizeTime.Name = "labelCustomizeTime";
            this.labelCustomizeTime.Size = new System.Drawing.Size(188, 34);
            this.labelCustomizeTime.TabIndex = 9;
            this.labelCustomizeTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Location = new System.Drawing.Point(372, 159);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(452, 396);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // buttonToIcon
            // 
            this.buttonToIcon.Location = new System.Drawing.Point(628, 586);
            this.buttonToIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonToIcon.Name = "buttonToIcon";
            this.buttonToIcon.Size = new System.Drawing.Size(198, 56);
            this.buttonToIcon.TabIndex = 2;
            this.buttonToIcon.Text = "Add as icon";
            this.buttonToIcon.UseVisualStyleBackColor = true;
            this.buttonToIcon.Click += new System.EventHandler(this.buttonToIcon_Click);
            // 
            // changeIconImageLabel
            // 
            this.changeIconImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeIconImageLabel.Location = new System.Drawing.Point(346, 78);
            this.changeIconImageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeIconImageLabel.Name = "changeIconImageLabel";
            this.changeIconImageLabel.Size = new System.Drawing.Size(504, 75);
            this.changeIconImageLabel.TabIndex = 1;
            this.changeIconImageLabel.Text = "Choose a new icon image for GMMS *must be .ico type image*";
            this.changeIconImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadPicture
            // 
            this.loadPicture.Location = new System.Drawing.Point(370, 586);
            this.loadPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(208, 56);
            this.loadPicture.TabIndex = 0;
            this.loadPicture.Text = "Load picture";
            this.loadPicture.UseVisualStyleBackColor = true;
            this.loadPicture.Click += new System.EventHandler(this.loadPicture_Click);
            // 
            // searchMemberTabPage
            // 
            this.searchMemberTabPage.Controls.Add(this.labelLookupDate);
            this.searchMemberTabPage.Controls.Add(this.labelLookupTime);
            this.searchMemberTabPage.Controls.Add(this.reactivateMemberButton);
            this.searchMemberTabPage.Controls.Add(this.deactivateMemberButton);
            this.searchMemberTabPage.Controls.Add(this.renewButton2);
            this.searchMemberTabPage.Controls.Add(this.searchResultListBox);
            this.searchMemberTabPage.Controls.Add(this.searchButton);
            this.searchMemberTabPage.Controls.Add(this.searchTextBox);
            this.searchMemberTabPage.Location = new System.Drawing.Point(8, 39);
            this.searchMemberTabPage.Name = "searchMemberTabPage";
            this.searchMemberTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchMemberTabPage.Size = new System.Drawing.Size(1216, 728);
            this.searchMemberTabPage.TabIndex = 5;
            this.searchMemberTabPage.Text = "Lookup";
            this.searchMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // reactivateMemberButton
            // 
            this.reactivateMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactivateMemberButton.Location = new System.Drawing.Point(800, 613);
            this.reactivateMemberButton.Name = "reactivateMemberButton";
            this.reactivateMemberButton.Size = new System.Drawing.Size(395, 63);
            this.reactivateMemberButton.TabIndex = 5;
            this.reactivateMemberButton.Text = "Reactivate Membership";
            this.reactivateMemberButton.UseVisualStyleBackColor = true;
            this.reactivateMemberButton.Click += new System.EventHandler(this.reactivateMemberButton_Click);
            // 
            // deactivateMemberButton
            // 
            this.deactivateMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivateMemberButton.Location = new System.Drawing.Point(381, 613);
            this.deactivateMemberButton.Name = "deactivateMemberButton";
            this.deactivateMemberButton.Size = new System.Drawing.Size(395, 63);
            this.deactivateMemberButton.TabIndex = 4;
            this.deactivateMemberButton.Text = "Deactivate Membership";
            this.deactivateMemberButton.UseVisualStyleBackColor = true;
            this.deactivateMemberButton.Click += new System.EventHandler(this.deactivateMemberButton_Click);
            // 
            // renewButton2
            // 
            this.renewButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewButton2.Location = new System.Drawing.Point(21, 613);
            this.renewButton2.Name = "renewButton2";
            this.renewButton2.Size = new System.Drawing.Size(323, 63);
            this.renewButton2.TabIndex = 3;
            this.renewButton2.Text = "Renew Membership";
            this.renewButton2.UseVisualStyleBackColor = true;
            this.renewButton2.Click += new System.EventHandler(this.renewButton2_Click);
            // 
            // searchResultListBox
            // 
            this.searchResultListBox.FormattingEnabled = true;
            this.searchResultListBox.HorizontalScrollbar = true;
            this.searchResultListBox.ItemHeight = 25;
            this.searchResultListBox.Location = new System.Drawing.Point(21, 132);
            this.searchResultListBox.Name = "searchResultListBox";
            this.searchResultListBox.Size = new System.Drawing.Size(1174, 429);
            this.searchResultListBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(293, 24);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(148, 47);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(21, 29);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(228, 38);
            this.searchTextBox.TabIndex = 0;
            // 
            // expirationTabPage
            // 
            this.expirationTabPage.Controls.Add(this.labelExpiringDate);
            this.expirationTabPage.Controls.Add(this.labelExpiringTime);
            this.expirationTabPage.Controls.Add(this.renewButton);
            this.expirationTabPage.Controls.Add(this.expiringMembersListBox);
            this.expirationTabPage.Location = new System.Drawing.Point(8, 39);
            this.expirationTabPage.Name = "expirationTabPage";
            this.expirationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.expirationTabPage.Size = new System.Drawing.Size(1216, 728);
            this.expirationTabPage.TabIndex = 6;
            this.expirationTabPage.Text = "Expiring Soon";
            this.expirationTabPage.UseVisualStyleBackColor = true;
            this.expirationTabPage.Enter += new System.EventHandler(this.ExpirationTabPage_Enter);
            // 
            // renewButton
            // 
            this.renewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewButton.Location = new System.Drawing.Point(443, 609);
            this.renewButton.Name = "renewButton";
            this.renewButton.Size = new System.Drawing.Size(311, 93);
            this.renewButton.TabIndex = 1;
            this.renewButton.Text = "Renew Membership";
            this.renewButton.UseVisualStyleBackColor = true;
            this.renewButton.Click += new System.EventHandler(this.renewButton_Click);
            // 
            // expiringMembersListBox
            // 
            this.expiringMembersListBox.FormattingEnabled = true;
            this.expiringMembersListBox.HorizontalScrollbar = true;
            this.expiringMembersListBox.ItemHeight = 25;
            this.expiringMembersListBox.Location = new System.Drawing.Point(29, 107);
            this.expiringMembersListBox.Name = "expiringMembersListBox";
            this.expiringMembersListBox.Size = new System.Drawing.Size(1166, 454);
            this.expiringMembersListBox.TabIndex = 0;
            // 
            // tutorialTabPage
            // 
            this.tutorialTabPage.Controls.Add(this.labelTutorialDate);
            this.tutorialTabPage.Controls.Add(this.labelTutorialTime);
            this.tutorialTabPage.Controls.Add(this.linkLabelTutorial);
            this.tutorialTabPage.Controls.Add(this.pleaseWatchLabel);
            this.tutorialTabPage.Location = new System.Drawing.Point(8, 39);
            this.tutorialTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tutorialTabPage.Name = "tutorialTabPage";
            this.tutorialTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tutorialTabPage.Size = new System.Drawing.Size(1216, 728);
            this.tutorialTabPage.TabIndex = 3;
            this.tutorialTabPage.Text = "Tutorial";
            this.tutorialTabPage.UseVisualStyleBackColor = true;
            // 
            // labelTutorialDate
            // 
            this.labelTutorialDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTutorialDate.Location = new System.Drawing.Point(984, 53);
            this.labelTutorialDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTutorialDate.Name = "labelTutorialDate";
            this.labelTutorialDate.Size = new System.Drawing.Size(231, 39);
            this.labelTutorialDate.TabIndex = 10;
            this.labelTutorialDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTutorialTime
            // 
            this.labelTutorialTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTutorialTime.Location = new System.Drawing.Point(1028, 3);
            this.labelTutorialTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTutorialTime.Name = "labelTutorialTime";
            this.labelTutorialTime.Size = new System.Drawing.Size(188, 34);
            this.labelTutorialTime.TabIndex = 9;
            this.labelTutorialTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelTutorial
            // 
            this.linkLabelTutorial.AutoSize = true;
            this.linkLabelTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTutorial.Location = new System.Drawing.Point(506, 347);
            this.linkLabelTutorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelTutorial.Name = "linkLabelTutorial";
            this.linkLabelTutorial.Size = new System.Drawing.Size(179, 32);
            this.linkLabelTutorial.TabIndex = 1;
            this.linkLabelTutorial.TabStop = true;
            this.linkLabelTutorial.Text = "Click this link";
            this.linkLabelTutorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTutorial_LinkClicked);
            // 
            // pleaseWatchLabel
            // 
            this.pleaseWatchLabel.AutoSize = true;
            this.pleaseWatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseWatchLabel.Location = new System.Drawing.Point(180, 269);
            this.pleaseWatchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pleaseWatchLabel.Name = "pleaseWatchLabel";
            this.pleaseWatchLabel.Size = new System.Drawing.Size(970, 32);
            this.pleaseWatchLabel.TabIndex = 0;
            this.pleaseWatchLabel.Text = "Please watch the following tutorial to familiarize yourself with the application";
            // 
            // toolTipHover
            // 
            this.toolTipHover.AutomaticDelay = 200;
            // 
            // deactivationReasonTabPage
            // 
            this.deactivationReasonTabPage.Controls.Add(this.labelDeactivationDate);
            this.deactivationReasonTabPage.Controls.Add(this.labelDeactivationTime);
            this.deactivationReasonTabPage.Controls.Add(this.deactivationReasonLabel);
            this.deactivationReasonTabPage.Controls.Add(this.deactivationReasonsRichTextBox);
            this.deactivationReasonTabPage.Location = new System.Drawing.Point(8, 39);
            this.deactivationReasonTabPage.Name = "deactivationReasonTabPage";
            this.deactivationReasonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deactivationReasonTabPage.Size = new System.Drawing.Size(1216, 728);
            this.deactivationReasonTabPage.TabIndex = 7;
            this.deactivationReasonTabPage.Text = "Cancel Reason";
            this.deactivationReasonTabPage.UseVisualStyleBackColor = true;
            this.deactivationReasonTabPage.Enter += new System.EventHandler(this.deactivationReasonTabPage_Enter);
            // 
            // deactivationReasonsRichTextBox
            // 
            this.deactivationReasonsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deactivationReasonsRichTextBox.Location = new System.Drawing.Point(7, 145);
            this.deactivationReasonsRichTextBox.Name = "deactivationReasonsRichTextBox";
            this.deactivationReasonsRichTextBox.ReadOnly = true;
            this.deactivationReasonsRichTextBox.Size = new System.Drawing.Size(1203, 568);
            this.deactivationReasonsRichTextBox.TabIndex = 0;
            this.deactivationReasonsRichTextBox.Text = "";
            // 
            // deactivationReasonLabel
            // 
            this.deactivationReasonLabel.AutoSize = true;
            this.deactivationReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivationReasonLabel.Location = new System.Drawing.Point(353, 105);
            this.deactivationReasonLabel.Name = "deactivationReasonLabel";
            this.deactivationReasonLabel.Size = new System.Drawing.Size(510, 37);
            this.deactivationReasonLabel.TabIndex = 1;
            this.deactivationReasonLabel.Text = "Membership Deactivation Reasons";
            // 
            // revenueTabPage
            // 
            this.revenueTabPage.Controls.Add(this.labelRevenueDate);
            this.revenueTabPage.Controls.Add(this.labelRevenueTime);
            this.revenueTabPage.Controls.Add(this.profitLabel);
            this.revenueTabPage.Controls.Add(this.aboveTargetLabel);
            this.revenueTabPage.Controls.Add(this.onTargetLabel);
            this.revenueTabPage.Controls.Add(this.belowTargetLabel);
            this.revenueTabPage.Controls.Add(this.greenLabel);
            this.revenueTabPage.Controls.Add(this.yellowLabel);
            this.revenueTabPage.Controls.Add(this.redLabel);
            this.revenueTabPage.Controls.Add(this.totalRevenueLabel);
            this.revenueTabPage.Location = new System.Drawing.Point(8, 39);
            this.revenueTabPage.Name = "revenueTabPage";
            this.revenueTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.revenueTabPage.Size = new System.Drawing.Size(1216, 728);
            this.revenueTabPage.TabIndex = 8;
            this.revenueTabPage.Text = "Revenue";
            this.revenueTabPage.UseVisualStyleBackColor = true;
            this.revenueTabPage.Enter += new System.EventHandler(this.revenueTabPage_Enter);
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.AutoSize = true;
            this.totalRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenueLabel.Location = new System.Drawing.Point(499, 59);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(222, 37);
            this.totalRevenueLabel.TabIndex = 0;
            this.totalRevenueLabel.Text = "Total Revenue";
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redLabel.Location = new System.Drawing.Point(43, 177);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(50, 43);
            this.redLabel.TabIndex = 1;
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowLabel.Location = new System.Drawing.Point(43, 220);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(50, 43);
            this.yellowLabel.TabIndex = 2;
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.Green;
            this.greenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenLabel.Location = new System.Drawing.Point(43, 263);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(50, 43);
            this.greenLabel.TabIndex = 3;
            // 
            // belowTargetLabel
            // 
            this.belowTargetLabel.AutoSize = true;
            this.belowTargetLabel.Location = new System.Drawing.Point(133, 194);
            this.belowTargetLabel.Name = "belowTargetLabel";
            this.belowTargetLabel.Size = new System.Drawing.Size(138, 25);
            this.belowTargetLabel.TabIndex = 4;
            this.belowTargetLabel.Text = "Below Target";
            // 
            // onTargetLabel
            // 
            this.onTargetLabel.AutoSize = true;
            this.onTargetLabel.Location = new System.Drawing.Point(133, 238);
            this.onTargetLabel.Name = "onTargetLabel";
            this.onTargetLabel.Size = new System.Drawing.Size(108, 25);
            this.onTargetLabel.TabIndex = 5;
            this.onTargetLabel.Text = "On Target";
            // 
            // aboveTargetLabel
            // 
            this.aboveTargetLabel.AutoSize = true;
            this.aboveTargetLabel.Location = new System.Drawing.Point(133, 281);
            this.aboveTargetLabel.Name = "aboveTargetLabel";
            this.aboveTargetLabel.Size = new System.Drawing.Size(141, 25);
            this.aboveTargetLabel.TabIndex = 6;
            this.aboveTargetLabel.Text = "Above Target";
            // 
            // profitLabel
            // 
            this.profitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitLabel.Location = new System.Drawing.Point(468, 433);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(289, 136);
            this.profitLabel.TabIndex = 7;
            this.profitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLookupDate
            // 
            this.labelLookupDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLookupDate.Location = new System.Drawing.Point(981, 53);
            this.labelLookupDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLookupDate.Name = "labelLookupDate";
            this.labelLookupDate.Size = new System.Drawing.Size(231, 39);
            this.labelLookupDate.TabIndex = 18;
            this.labelLookupDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLookupTime
            // 
            this.labelLookupTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLookupTime.Location = new System.Drawing.Point(1028, 3);
            this.labelLookupTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLookupTime.Name = "labelLookupTime";
            this.labelLookupTime.Size = new System.Drawing.Size(188, 34);
            this.labelLookupTime.TabIndex = 17;
            this.labelLookupTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelExpiringDate
            // 
            this.labelExpiringDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExpiringDate.Location = new System.Drawing.Point(981, 53);
            this.labelExpiringDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpiringDate.Name = "labelExpiringDate";
            this.labelExpiringDate.Size = new System.Drawing.Size(231, 39);
            this.labelExpiringDate.TabIndex = 20;
            this.labelExpiringDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelExpiringTime
            // 
            this.labelExpiringTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExpiringTime.Location = new System.Drawing.Point(1028, 3);
            this.labelExpiringTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpiringTime.Name = "labelExpiringTime";
            this.labelExpiringTime.Size = new System.Drawing.Size(188, 34);
            this.labelExpiringTime.TabIndex = 19;
            this.labelExpiringTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDeactivationDate
            // 
            this.labelDeactivationDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDeactivationDate.Location = new System.Drawing.Point(981, 53);
            this.labelDeactivationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeactivationDate.Name = "labelDeactivationDate";
            this.labelDeactivationDate.Size = new System.Drawing.Size(231, 39);
            this.labelDeactivationDate.TabIndex = 20;
            this.labelDeactivationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDeactivationTime
            // 
            this.labelDeactivationTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDeactivationTime.Location = new System.Drawing.Point(1028, 3);
            this.labelDeactivationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeactivationTime.Name = "labelDeactivationTime";
            this.labelDeactivationTime.Size = new System.Drawing.Size(188, 34);
            this.labelDeactivationTime.TabIndex = 19;
            this.labelDeactivationTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRevenueDate
            // 
            this.labelRevenueDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRevenueDate.Location = new System.Drawing.Point(981, 53);
            this.labelRevenueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRevenueDate.Name = "labelRevenueDate";
            this.labelRevenueDate.Size = new System.Drawing.Size(231, 39);
            this.labelRevenueDate.TabIndex = 20;
            this.labelRevenueDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRevenueTime
            // 
            this.labelRevenueTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRevenueTime.Location = new System.Drawing.Point(1028, 3);
            this.labelRevenueTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRevenueTime.Name = "labelRevenueTime";
            this.labelRevenueTime.Size = new System.Drawing.Size(188, 34);
            this.labelRevenueTime.TabIndex = 19;
            this.labelRevenueTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 775);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.searchMemberTabPage.ResumeLayout(false);
            this.searchMemberTabPage.PerformLayout();
            this.expirationTabPage.ResumeLayout(false);
            this.tutorialTabPage.ResumeLayout(false);
            this.tutorialTabPage.PerformLayout();
            this.deactivationReasonTabPage.ResumeLayout(false);
            this.deactivationReasonTabPage.PerformLayout();
            this.revenueTabPage.ResumeLayout(false);
            this.revenueTabPage.PerformLayout();
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
        private TabPage searchMemberTabPage;
        private Button searchButton;
        private TextBox searchTextBox;
        private TabPage expirationTabPage;
        private ListBox expiringMembersListBox;
        private Button renewButton;
        private Button reactivateMemberButton;
        private Button deactivateMemberButton;
        private Button renewButton2;
        private ListBox searchResultListBox;
        private TabPage deactivationReasonTabPage;
        private Label deactivationReasonLabel;
        private RichTextBox deactivationReasonsRichTextBox;
        private TabPage revenueTabPage;
        private Label redLabel;
        private Label totalRevenueLabel;
        private Label profitLabel;
        private Label aboveTargetLabel;
        private Label onTargetLabel;
        private Label belowTargetLabel;
        private Label greenLabel;
        private Label yellowLabel;
        private Label labelLookupDate;
        private Label labelLookupTime;
        private Label labelExpiringDate;
        private Label labelExpiringTime;
        private Label labelDeactivationDate;
        private Label labelDeactivationTime;
        private Label labelRevenueDate;
        private Label labelRevenueTime;
    }
}