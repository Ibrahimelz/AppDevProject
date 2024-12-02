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
            this.searchMemberTabPage = new System.Windows.Forms.TabPage();
            this.enterMemberIdLabel = new System.Windows.Forms.Label();
            this.labelLookupDate = new System.Windows.Forms.Label();
            this.labelLookupTime = new System.Windows.Forms.Label();
            this.reactivateMemberButton = new System.Windows.Forms.Button();
            this.deactivateMemberButton = new System.Windows.Forms.Button();
            this.renewButton2 = new System.Windows.Forms.Button();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.expirationTabPage = new System.Windows.Forms.TabPage();
            this.labelExpiringDate = new System.Windows.Forms.Label();
            this.labelExpiringTime = new System.Windows.Forms.Label();
            this.renewButton = new System.Windows.Forms.Button();
            this.expiringMembersListBox = new System.Windows.Forms.ListBox();
            this.revenueTabPage = new System.Windows.Forms.TabPage();
            this.labelRevenueDate = new System.Windows.Forms.Label();
            this.labelRevenueTime = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.aboveTargetLabel = new System.Windows.Forms.Label();
            this.onTargetLabel = new System.Windows.Forms.Label();
            this.belowTargetLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.deactivationReasonTabPage = new System.Windows.Forms.TabPage();
            this.labelDeactivationDate = new System.Windows.Forms.Label();
            this.labelDeactivationTime = new System.Windows.Forms.Label();
            this.deactivationReasonLabel = new System.Windows.Forms.Label();
            this.deactivationReasonsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SecurityTabPage = new System.Windows.Forms.TabPage();
            this.labelSystemDate = new System.Windows.Forms.Label();
            this.labelSystemTime = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.changeAttemptsButton2 = new System.Windows.Forms.Button();
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
            this.tutorialTabPage = new System.Windows.Forms.TabPage();
            this.labelTutorialDate = new System.Windows.Forms.Label();
            this.labelTutorialTime = new System.Windows.Forms.Label();
            this.linkLabelTutorial = new System.Windows.Forms.LinkLabel();
            this.pleaseWatchLabel = new System.Windows.Forms.Label();
            this.toolTipHover = new System.Windows.Forms.ToolTip(this.components);
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.MainTabControl.SuspendLayout();
            this.mainFormTabPage.SuspendLayout();
            this.viewAllGymMemberTab.SuspendLayout();
            this.searchMemberTabPage.SuspendLayout();
            this.expirationTabPage.SuspendLayout();
            this.revenueTabPage.SuspendLayout();
            this.deactivationReasonTabPage.SuspendLayout();
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
            this.MainTabControl.Controls.Add(this.searchMemberTabPage);
            this.MainTabControl.Controls.Add(this.expirationTabPage);
            this.MainTabControl.Controls.Add(this.revenueTabPage);
            this.MainTabControl.Controls.Add(this.deactivationReasonTabPage);
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
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.EmptySecurityBoxes);
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
            // labelRegisterDate
            // 
            this.labelRegisterDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegisterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterDate.Location = new System.Drawing.Point(633, 28);
            this.labelRegisterDate.Name = "labelRegisterDate";
            this.labelRegisterDate.Size = new System.Drawing.Size(180, 25);
            this.labelRegisterDate.TabIndex = 16;
            this.labelRegisterDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegisterTime
            // 
            this.labelRegisterTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegisterTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterTime.Location = new System.Drawing.Point(685, 0);
            this.labelRegisterTime.Name = "labelRegisterTime";
            this.labelRegisterTime.Size = new System.Drawing.Size(125, 22);
            this.labelRegisterTime.TabIndex = 15;
            this.labelRegisterTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.creditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardNumber.Location = new System.Drawing.Point(13, 270);
            this.creditCardNumber.Name = "creditCardNumber";
            this.creditCardNumber.Size = new System.Drawing.Size(144, 18);
            this.creditCardNumber.TabIndex = 11;
            this.creditCardNumber.Text = "Credit Card Number:";
            // 
            // tosLabel
            // 
            this.tosLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosLabel.Location = new System.Drawing.Point(223, 25);
            this.tosLabel.Name = "tosLabel";
            this.tosLabel.Size = new System.Drawing.Size(409, 313);
            this.tosLabel.TabIndex = 10;
            this.tosLabel.Text = resources.GetString("tosLabel.Text");
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agreeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeCheckBox.Location = new System.Drawing.Point(17, 338);
            this.agreeCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(209, 52);
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
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(13, 175);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 18);
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
            this.emailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(13, 119);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(107, 18);
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
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(13, 60);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(112, 18);
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
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 2);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // createGymMemberButton
            // 
            this.createGymMemberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createGymMemberButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.createGymMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGymMemberButton.Location = new System.Drawing.Point(8, 402);
            this.createGymMemberButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createGymMemberButton.Name = "createGymMemberButton";
            this.createGymMemberButton.Size = new System.Drawing.Size(224, 52);
            this.createGymMemberButton.TabIndex = 0;
            this.createGymMemberButton.Text = "Create Gym Member";
            this.createGymMemberButton.UseVisualStyleBackColor = false;
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
            // searchMemberTabPage
            // 
            this.searchMemberTabPage.Controls.Add(this.enterMemberIdLabel);
            this.searchMemberTabPage.Controls.Add(this.labelLookupDate);
            this.searchMemberTabPage.Controls.Add(this.labelLookupTime);
            this.searchMemberTabPage.Controls.Add(this.reactivateMemberButton);
            this.searchMemberTabPage.Controls.Add(this.deactivateMemberButton);
            this.searchMemberTabPage.Controls.Add(this.renewButton2);
            this.searchMemberTabPage.Controls.Add(this.searchResultListBox);
            this.searchMemberTabPage.Controls.Add(this.searchButton);
            this.searchMemberTabPage.Controls.Add(this.searchTextBox);
            this.searchMemberTabPage.Location = new System.Drawing.Point(4, 25);
            this.searchMemberTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.searchMemberTabPage.Name = "searchMemberTabPage";
            this.searchMemberTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.searchMemberTabPage.Size = new System.Drawing.Size(813, 467);
            this.searchMemberTabPage.TabIndex = 5;
            this.searchMemberTabPage.Text = "Lookup";
            this.searchMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // enterMemberIdLabel
            // 
            this.enterMemberIdLabel.AutoSize = true;
            this.enterMemberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterMemberIdLabel.Location = new System.Drawing.Point(11, 51);
            this.enterMemberIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterMemberIdLabel.Name = "enterMemberIdLabel";
            this.enterMemberIdLabel.Size = new System.Drawing.Size(124, 18);
            this.enterMemberIdLabel.TabIndex = 19;
            this.enterMemberIdLabel.Text = "Enter Member ID:";
            // 
            // labelLookupDate
            // 
            this.labelLookupDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLookupDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLookupDate.Location = new System.Drawing.Point(630, 33);
            this.labelLookupDate.Name = "labelLookupDate";
            this.labelLookupDate.Size = new System.Drawing.Size(180, 25);
            this.labelLookupDate.TabIndex = 18;
            this.labelLookupDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLookupTime
            // 
            this.labelLookupTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLookupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLookupTime.Location = new System.Drawing.Point(685, 2);
            this.labelLookupTime.Name = "labelLookupTime";
            this.labelLookupTime.Size = new System.Drawing.Size(125, 22);
            this.labelLookupTime.TabIndex = 17;
            this.labelLookupTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactivateMemberButton
            // 
            this.reactivateMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactivateMemberButton.Location = new System.Drawing.Point(533, 392);
            this.reactivateMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.reactivateMemberButton.Name = "reactivateMemberButton";
            this.reactivateMemberButton.Size = new System.Drawing.Size(263, 40);
            this.reactivateMemberButton.TabIndex = 5;
            this.reactivateMemberButton.Text = "Reactivate Membership";
            this.reactivateMemberButton.UseVisualStyleBackColor = true;
            this.reactivateMemberButton.Click += new System.EventHandler(this.reactivateMemberButton_Click);
            // 
            // deactivateMemberButton
            // 
            this.deactivateMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivateMemberButton.Location = new System.Drawing.Point(254, 392);
            this.deactivateMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.deactivateMemberButton.Name = "deactivateMemberButton";
            this.deactivateMemberButton.Size = new System.Drawing.Size(263, 40);
            this.deactivateMemberButton.TabIndex = 4;
            this.deactivateMemberButton.Text = "Deactivate Membership";
            this.deactivateMemberButton.UseVisualStyleBackColor = true;
            this.deactivateMemberButton.Click += new System.EventHandler(this.deactivateMemberButton_Click);
            // 
            // renewButton2
            // 
            this.renewButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewButton2.Location = new System.Drawing.Point(14, 392);
            this.renewButton2.Margin = new System.Windows.Forms.Padding(2);
            this.renewButton2.Name = "renewButton2";
            this.renewButton2.Size = new System.Drawing.Size(215, 40);
            this.renewButton2.TabIndex = 3;
            this.renewButton2.Text = "Renew Membership";
            this.renewButton2.UseVisualStyleBackColor = true;
            this.renewButton2.Click += new System.EventHandler(this.renewButton2_Click);
            // 
            // searchResultListBox
            // 
            this.searchResultListBox.FormattingEnabled = true;
            this.searchResultListBox.HorizontalScrollbar = true;
            this.searchResultListBox.ItemHeight = 16;
            this.searchResultListBox.Location = new System.Drawing.Point(14, 84);
            this.searchResultListBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchResultListBox.Name = "searchResultListBox";
            this.searchResultListBox.Size = new System.Drawing.Size(784, 276);
            this.searchResultListBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(367, 42);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(144, 34);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(203, 47);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(153, 27);
            this.searchTextBox.TabIndex = 0;
            // 
            // expirationTabPage
            // 
            this.expirationTabPage.Controls.Add(this.labelExpiringDate);
            this.expirationTabPage.Controls.Add(this.labelExpiringTime);
            this.expirationTabPage.Controls.Add(this.renewButton);
            this.expirationTabPage.Controls.Add(this.expiringMembersListBox);
            this.expirationTabPage.Location = new System.Drawing.Point(4, 25);
            this.expirationTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.expirationTabPage.Name = "expirationTabPage";
            this.expirationTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.expirationTabPage.Size = new System.Drawing.Size(813, 467);
            this.expirationTabPage.TabIndex = 6;
            this.expirationTabPage.Text = "Expiring Soon";
            this.expirationTabPage.UseVisualStyleBackColor = true;
            this.expirationTabPage.Enter += new System.EventHandler(this.ExpirationTabPage_Enter);
            // 
            // labelExpiringDate
            // 
            this.labelExpiringDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExpiringDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpiringDate.Location = new System.Drawing.Point(630, 41);
            this.labelExpiringDate.Name = "labelExpiringDate";
            this.labelExpiringDate.Size = new System.Drawing.Size(180, 25);
            this.labelExpiringDate.TabIndex = 20;
            this.labelExpiringDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExpiringTime
            // 
            this.labelExpiringTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExpiringTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpiringTime.Location = new System.Drawing.Point(685, 2);
            this.labelExpiringTime.Name = "labelExpiringTime";
            this.labelExpiringTime.Size = new System.Drawing.Size(125, 22);
            this.labelExpiringTime.TabIndex = 19;
            this.labelExpiringTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // renewButton
            // 
            this.renewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewButton.Location = new System.Drawing.Point(295, 390);
            this.renewButton.Margin = new System.Windows.Forms.Padding(2);
            this.renewButton.Name = "renewButton";
            this.renewButton.Size = new System.Drawing.Size(207, 60);
            this.renewButton.TabIndex = 1;
            this.renewButton.Text = "Renew Membership";
            this.renewButton.UseVisualStyleBackColor = true;
            this.renewButton.Click += new System.EventHandler(this.renewButton_Click);
            // 
            // expiringMembersListBox
            // 
            this.expiringMembersListBox.FormattingEnabled = true;
            this.expiringMembersListBox.HorizontalScrollbar = true;
            this.expiringMembersListBox.ItemHeight = 16;
            this.expiringMembersListBox.Location = new System.Drawing.Point(19, 68);
            this.expiringMembersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.expiringMembersListBox.Name = "expiringMembersListBox";
            this.expiringMembersListBox.Size = new System.Drawing.Size(779, 292);
            this.expiringMembersListBox.TabIndex = 0;
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
            this.revenueTabPage.Location = new System.Drawing.Point(4, 25);
            this.revenueTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.revenueTabPage.Name = "revenueTabPage";
            this.revenueTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.revenueTabPage.Size = new System.Drawing.Size(813, 467);
            this.revenueTabPage.TabIndex = 8;
            this.revenueTabPage.Text = "Revenue";
            this.revenueTabPage.UseVisualStyleBackColor = true;
            this.revenueTabPage.Enter += new System.EventHandler(this.revenueTabPage_Enter);
            // 
            // labelRevenueDate
            // 
            this.labelRevenueDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRevenueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenueDate.Location = new System.Drawing.Point(630, 38);
            this.labelRevenueDate.Name = "labelRevenueDate";
            this.labelRevenueDate.Size = new System.Drawing.Size(180, 25);
            this.labelRevenueDate.TabIndex = 20;
            this.labelRevenueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRevenueTime
            // 
            this.labelRevenueTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRevenueTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenueTime.Location = new System.Drawing.Point(685, 2);
            this.labelRevenueTime.Name = "labelRevenueTime";
            this.labelRevenueTime.Size = new System.Drawing.Size(125, 22);
            this.labelRevenueTime.TabIndex = 19;
            this.labelRevenueTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profitLabel
            // 
            this.profitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitLabel.Location = new System.Drawing.Point(312, 277);
            this.profitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(193, 87);
            this.profitLabel.TabIndex = 7;
            this.profitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboveTargetLabel
            // 
            this.aboveTargetLabel.AutoSize = true;
            this.aboveTargetLabel.Location = new System.Drawing.Point(89, 180);
            this.aboveTargetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboveTargetLabel.Name = "aboveTargetLabel";
            this.aboveTargetLabel.Size = new System.Drawing.Size(90, 16);
            this.aboveTargetLabel.TabIndex = 6;
            this.aboveTargetLabel.Text = "Above Target";
            // 
            // onTargetLabel
            // 
            this.onTargetLabel.AutoSize = true;
            this.onTargetLabel.Location = new System.Drawing.Point(89, 152);
            this.onTargetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.onTargetLabel.Name = "onTargetLabel";
            this.onTargetLabel.Size = new System.Drawing.Size(67, 16);
            this.onTargetLabel.TabIndex = 5;
            this.onTargetLabel.Text = "On Target";
            // 
            // belowTargetLabel
            // 
            this.belowTargetLabel.AutoSize = true;
            this.belowTargetLabel.Location = new System.Drawing.Point(89, 124);
            this.belowTargetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.belowTargetLabel.Name = "belowTargetLabel";
            this.belowTargetLabel.Size = new System.Drawing.Size(87, 16);
            this.belowTargetLabel.TabIndex = 4;
            this.belowTargetLabel.Text = "Below Target";
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.Green;
            this.greenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenLabel.Location = new System.Drawing.Point(29, 168);
            this.greenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(34, 28);
            this.greenLabel.TabIndex = 3;
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowLabel.Location = new System.Drawing.Point(29, 141);
            this.yellowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(34, 28);
            this.yellowLabel.TabIndex = 2;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redLabel.Location = new System.Drawing.Point(29, 113);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(34, 28);
            this.redLabel.TabIndex = 1;
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.AutoSize = true;
            this.totalRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenueLabel.Location = new System.Drawing.Point(333, 38);
            this.totalRevenueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(139, 25);
            this.totalRevenueLabel.TabIndex = 0;
            this.totalRevenueLabel.Text = "Total Revenue";
            // 
            // deactivationReasonTabPage
            // 
            this.deactivationReasonTabPage.Controls.Add(this.labelDeactivationDate);
            this.deactivationReasonTabPage.Controls.Add(this.labelDeactivationTime);
            this.deactivationReasonTabPage.Controls.Add(this.deactivationReasonLabel);
            this.deactivationReasonTabPage.Controls.Add(this.deactivationReasonsRichTextBox);
            this.deactivationReasonTabPage.Location = new System.Drawing.Point(4, 25);
            this.deactivationReasonTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.deactivationReasonTabPage.Name = "deactivationReasonTabPage";
            this.deactivationReasonTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.deactivationReasonTabPage.Size = new System.Drawing.Size(813, 467);
            this.deactivationReasonTabPage.TabIndex = 7;
            this.deactivationReasonTabPage.Text = "Cancel Reason";
            this.deactivationReasonTabPage.UseVisualStyleBackColor = true;
            this.deactivationReasonTabPage.Enter += new System.EventHandler(this.deactivationReasonTabPage_Enter);
            // 
            // labelDeactivationDate
            // 
            this.labelDeactivationDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDeactivationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeactivationDate.Location = new System.Drawing.Point(630, 36);
            this.labelDeactivationDate.Name = "labelDeactivationDate";
            this.labelDeactivationDate.Size = new System.Drawing.Size(180, 25);
            this.labelDeactivationDate.TabIndex = 20;
            this.labelDeactivationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeactivationTime
            // 
            this.labelDeactivationTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDeactivationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeactivationTime.Location = new System.Drawing.Point(685, 2);
            this.labelDeactivationTime.Name = "labelDeactivationTime";
            this.labelDeactivationTime.Size = new System.Drawing.Size(125, 22);
            this.labelDeactivationTime.TabIndex = 19;
            this.labelDeactivationTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deactivationReasonLabel
            // 
            this.deactivationReasonLabel.AutoSize = true;
            this.deactivationReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivationReasonLabel.Location = new System.Drawing.Point(235, 67);
            this.deactivationReasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deactivationReasonLabel.Name = "deactivationReasonLabel";
            this.deactivationReasonLabel.Size = new System.Drawing.Size(314, 25);
            this.deactivationReasonLabel.TabIndex = 1;
            this.deactivationReasonLabel.Text = "Membership Deactivation Reasons";
            // 
            // deactivationReasonsRichTextBox
            // 
            this.deactivationReasonsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deactivationReasonsRichTextBox.Location = new System.Drawing.Point(5, 93);
            this.deactivationReasonsRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.deactivationReasonsRichTextBox.Name = "deactivationReasonsRichTextBox";
            this.deactivationReasonsRichTextBox.ReadOnly = true;
            this.deactivationReasonsRichTextBox.Size = new System.Drawing.Size(803, 365);
            this.deactivationReasonsRichTextBox.TabIndex = 0;
            this.deactivationReasonsRichTextBox.Text = "";
            // 
            // SecurityTabPage
            // 
            this.SecurityTabPage.Controls.Add(this.labelSystemDate);
            this.SecurityTabPage.Controls.Add(this.labelSystemTime);
            this.SecurityTabPage.Controls.Add(this.errorLabel);
            this.SecurityTabPage.Controls.Add(this.changeAttemptsButton2);
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
            // labelSystemDate
            // 
            this.labelSystemDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSystemDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemDate.Location = new System.Drawing.Point(633, 28);
            this.labelSystemDate.Name = "labelSystemDate";
            this.labelSystemDate.Size = new System.Drawing.Size(180, 25);
            this.labelSystemDate.TabIndex = 26;
            this.labelSystemDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSystemTime
            // 
            this.labelSystemTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSystemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemTime.Location = new System.Drawing.Point(688, 0);
            this.labelSystemTime.Name = "labelSystemTime";
            this.labelSystemTime.Size = new System.Drawing.Size(125, 22);
            this.labelSystemTime.TabIndex = 25;
            this.labelSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(222, 125);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(415, 28);
            this.errorLabel.TabIndex = 24;
            // 
            // changeAttemptsButton2
            // 
            this.changeAttemptsButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAttemptsButton2.Location = new System.Drawing.Point(36, 90);
            this.changeAttemptsButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeAttemptsButton2.Name = "changeAttemptsButton2";
            this.changeAttemptsButton2.Size = new System.Drawing.Size(129, 63);
            this.changeAttemptsButton2.TabIndex = 23;
            this.changeAttemptsButton2.Text = "Change Attempts";
            this.changeAttemptsButton2.UseVisualStyleBackColor = true;
            this.changeAttemptsButton2.Click += new System.EventHandler(this.ChangeAttemptsLabel_Click);
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
            this.AttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptsLabel.Location = new System.Drawing.Point(31, 28);
            this.AttemptsLabel.Name = "AttemptsLabel";
            this.AttemptsLabel.Size = new System.Drawing.Size(197, 59);
            this.AttemptsLabel.TabIndex = 20;
            this.AttemptsLabel.Text = "New Allowed Number of Attempts: ";
            // 
            // resetErrorLabel
            // 
            this.resetErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetErrorLabel.Location = new System.Drawing.Point(222, 340);
            this.resetErrorLabel.Name = "resetErrorLabel";
            this.resetErrorLabel.Size = new System.Drawing.Size(415, 28);
            this.resetErrorLabel.TabIndex = 19;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(227, 194);
            this.oldPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.oldPasswordTextBox.TabIndex = 18;
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassLabel.Location = new System.Drawing.Point(29, 194);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(165, 28);
            this.oldPassLabel.TabIndex = 17;
            this.oldPassLabel.Text = "Old Password: ";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(187, 261);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(459, 65);
            this.instructionLabel.TabIndex = 15;
            this.instructionLabel.Text = "New System password will be aplied on next start up";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(227, 233);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.newPasswordTextBox.TabIndex = 14;
            // 
            // newPassLabel
            // 
            this.newPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // labelCustomizeDate
            // 
            this.labelCustomizeDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomizeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomizeDate.Location = new System.Drawing.Point(633, 32);
            this.labelCustomizeDate.Name = "labelCustomizeDate";
            this.labelCustomizeDate.Size = new System.Drawing.Size(180, 25);
            this.labelCustomizeDate.TabIndex = 10;
            this.labelCustomizeDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCustomizeTime
            // 
            this.labelCustomizeTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomizeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomizeTime.Location = new System.Drawing.Point(688, 0);
            this.labelCustomizeTime.Name = "labelCustomizeTime";
            this.labelCustomizeTime.Size = new System.Drawing.Size(125, 22);
            this.labelCustomizeTime.TabIndex = 9;
            this.labelCustomizeTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonToIcon.Location = new System.Drawing.Point(401, 375);
            this.buttonToIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonToIcon.Name = "buttonToIcon";
            this.buttonToIcon.Size = new System.Drawing.Size(149, 54);
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
            this.loadPicture.Size = new System.Drawing.Size(149, 54);
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
            // labelTutorialDate
            // 
            this.labelTutorialDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTutorialDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutorialDate.Location = new System.Drawing.Point(633, 33);
            this.labelTutorialDate.Name = "labelTutorialDate";
            this.labelTutorialDate.Size = new System.Drawing.Size(180, 25);
            this.labelTutorialDate.TabIndex = 10;
            this.labelTutorialDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTutorialTime
            // 
            this.labelTutorialTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTutorialTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutorialTime.Location = new System.Drawing.Point(685, 2);
            this.labelTutorialTime.Name = "labelTutorialTime";
            this.labelTutorialTime.Size = new System.Drawing.Size(125, 22);
            this.labelTutorialTime.TabIndex = 9;
            this.labelTutorialTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.searchMemberTabPage.ResumeLayout(false);
            this.searchMemberTabPage.PerformLayout();
            this.expirationTabPage.ResumeLayout(false);
            this.revenueTabPage.ResumeLayout(false);
            this.revenueTabPage.PerformLayout();
            this.deactivationReasonTabPage.ResumeLayout(false);
            this.deactivationReasonTabPage.PerformLayout();
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
        private Button changeAttemptsButton2;
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
        private Label enterMemberIdLabel;
    }
}