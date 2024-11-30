namespace Application_Development_Project
{
    partial class LoginPageForm
    {
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPageForm));
            this.loginTabControl = new System.Windows.Forms.TabControl();
            this.loginPageTab = new System.Windows.Forms.TabPage();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.labelLoginDate = new System.Windows.Forms.Label();
            this.labelLoginTime = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.resetPageTab = new System.Windows.Forms.TabPage();
            this.labelResetPswdDate = new System.Windows.Forms.Label();
            this.labelResetPswdTime = new System.Windows.Forms.Label();
            this.resetErrorLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.newPassNotifLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.birthYearTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel2 = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.resetPasswordlabel = new System.Windows.Forms.Label();
            this.toolTipTab = new System.Windows.Forms.ToolTip(this.components);
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.loginTabControl.SuspendLayout();
            this.loginPageTab.SuspendLayout();
            this.resetPageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTabControl
            // 
            this.loginTabControl.Controls.Add(this.loginPageTab);
            this.loginTabControl.Controls.Add(this.resetPageTab);
            this.loginTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTabControl.Location = new System.Drawing.Point(0, 0);
            this.loginTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginTabControl.Name = "loginTabControl";
            this.loginTabControl.SelectedIndex = 0;
            this.loginTabControl.Size = new System.Drawing.Size(976, 402);
            this.loginTabControl.TabIndex = 0;
            // 
            // loginPageTab
            // 
            this.loginPageTab.Controls.Add(this.languageLabel);
            this.loginPageTab.Controls.Add(this.languageComboBox);
            this.loginPageTab.Controls.Add(this.labelLoginDate);
            this.loginPageTab.Controls.Add(this.labelLoginTime);
            this.loginPageTab.Controls.Add(this.errorLabel);
            this.loginPageTab.Controls.Add(this.loginButton);
            this.loginPageTab.Controls.Add(this.passwordTextBox);
            this.loginPageTab.Controls.Add(this.nameTextBox);
            this.loginPageTab.Controls.Add(this.PasswordLabel);
            this.loginPageTab.Controls.Add(this.nameLabel);
            this.loginPageTab.Controls.Add(this.titleLabel);
            this.loginPageTab.Location = new System.Drawing.Point(8, 39);
            this.loginPageTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginPageTab.Name = "loginPageTab";
            this.loginPageTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginPageTab.Size = new System.Drawing.Size(960, 355);
            this.loginPageTab.TabIndex = 0;
            this.loginPageTab.Text = "Login";
            this.loginPageTab.UseVisualStyleBackColor = true;
            // 
            // languageLabel
            // 
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(776, 229);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(176, 44);
            this.languageLabel.TabIndex = 10;
            this.languageLabel.Text = "Language:";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // languageComboBox
            // 
            this.languageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Français"});
            this.languageComboBox.Location = new System.Drawing.Point(772, 276);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(181, 39);
            this.languageComboBox.TabIndex = 9;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // labelLoginDate
            // 
            this.labelLoginDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLoginDate.Location = new System.Drawing.Point(729, 47);
            this.labelLoginDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginDate.Name = "labelLoginDate";
            this.labelLoginDate.Size = new System.Drawing.Size(231, 39);
            this.labelLoginDate.TabIndex = 8;
            this.labelLoginDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLoginTime
            // 
            this.labelLoginTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLoginTime.Location = new System.Drawing.Point(772, 3);
            this.labelLoginTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginTime.Name = "labelLoginTime";
            this.labelLoginTime.Size = new System.Drawing.Size(188, 34);
            this.labelLoginTime.TabIndex = 7;
            this.labelLoginTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(252, 250);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(508, 98);
            this.errorLabel.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(20, 250);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(224, 72);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(198, 168);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(447, 31);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(198, 78);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(447, 31);
            this.nameTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 169);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(232, 44);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 78);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(188, 44);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(69, 3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(652, 44);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to Gym Membership Managment System";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetPageTab
            // 
            this.resetPageTab.Controls.Add(this.labelResetPswdDate);
            this.resetPageTab.Controls.Add(this.labelResetPswdTime);
            this.resetPageTab.Controls.Add(this.resetErrorLabel);
            this.resetPageTab.Controls.Add(this.changePasswordButton);
            this.resetPageTab.Controls.Add(this.newPassNotifLabel);
            this.resetPageTab.Controls.Add(this.newPasswordTextBox);
            this.resetPageTab.Controls.Add(this.newPassLabel);
            this.resetPageTab.Controls.Add(this.phoneNumberTextBox);
            this.resetPageTab.Controls.Add(this.birthYearTextBox);
            this.resetPageTab.Controls.Add(this.phoneNumberLabel2);
            this.resetPageTab.Controls.Add(this.BirthLabel);
            this.resetPageTab.Controls.Add(this.resetPasswordlabel);
            this.resetPageTab.Location = new System.Drawing.Point(8, 39);
            this.resetPageTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetPageTab.Name = "resetPageTab";
            this.resetPageTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetPageTab.Size = new System.Drawing.Size(960, 355);
            this.resetPageTab.TabIndex = 1;
            this.resetPageTab.Text = "Reset Password";
            this.resetPageTab.UseVisualStyleBackColor = true;
            // 
            // labelResetPswdDate
            // 
            this.labelResetPswdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResetPswdDate.Location = new System.Drawing.Point(744, 47);
            this.labelResetPswdDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResetPswdDate.Name = "labelResetPswdDate";
            this.labelResetPswdDate.Size = new System.Drawing.Size(220, 39);
            this.labelResetPswdDate.TabIndex = 15;
            this.labelResetPswdDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelResetPswdTime
            // 
            this.labelResetPswdTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResetPswdTime.Location = new System.Drawing.Point(777, 3);
            this.labelResetPswdTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResetPswdTime.Name = "labelResetPswdTime";
            this.labelResetPswdTime.Size = new System.Drawing.Size(188, 34);
            this.labelResetPswdTime.TabIndex = 14;
            this.labelResetPswdTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resetErrorLabel
            // 
            this.resetErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetErrorLabel.Location = new System.Drawing.Point(239, 291);
            this.resetErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resetErrorLabel.Name = "resetErrorLabel";
            this.resetErrorLabel.Size = new System.Drawing.Size(622, 44);
            this.resetErrorLabel.TabIndex = 13;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.Location = new System.Drawing.Point(16, 227);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(194, 98);
            this.changePasswordButton.TabIndex = 12;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // newPassNotifLabel
            // 
            this.newPassNotifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassNotifLabel.Location = new System.Drawing.Point(240, 222);
            this.newPassNotifLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPassNotifLabel.Name = "newPassNotifLabel";
            this.newPassNotifLabel.Size = new System.Drawing.Size(536, 69);
            this.newPassNotifLabel.TabIndex = 11;
            this.newPassNotifLabel.Text = "If succesful application will restart ";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(246, 177);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(451, 31);
            this.newPasswordTextBox.TabIndex = 10;
            // 
            // newPassLabel
            // 
            this.newPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.Location = new System.Drawing.Point(2, 180);
            this.newPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(214, 44);
            this.newPassLabel.TabIndex = 9;
            this.newPassLabel.Text = "New Password: ";
            this.newPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(246, 117);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(451, 31);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // birthYearTextBox
            // 
            this.birthYearTextBox.Location = new System.Drawing.Point(246, 52);
            this.birthYearTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.birthYearTextBox.Name = "birthYearTextBox";
            this.birthYearTextBox.Size = new System.Drawing.Size(451, 31);
            this.birthYearTextBox.TabIndex = 7;
            // 
            // phoneNumberLabel2
            // 
            this.phoneNumberLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel2.Location = new System.Drawing.Point(2, 111);
            this.phoneNumberLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel2.Name = "phoneNumberLabel2";
            this.phoneNumberLabel2.Size = new System.Drawing.Size(236, 44);
            this.phoneNumberLabel2.TabIndex = 6;
            this.phoneNumberLabel2.Text = "Phone Number:";
            this.phoneNumberLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BirthLabel
            // 
            this.BirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthLabel.Location = new System.Drawing.Point(0, 52);
            this.BirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(237, 44);
            this.BirthLabel.TabIndex = 5;
            this.BirthLabel.Text = "Year of Birth: ";
            this.BirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resetPasswordlabel
            // 
            this.resetPasswordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordlabel.Location = new System.Drawing.Point(352, 3);
            this.resetPasswordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resetPasswordlabel.Name = "resetPasswordlabel";
            this.resetPasswordlabel.Size = new System.Drawing.Size(310, 44);
            this.resetPasswordlabel.TabIndex = 1;
            this.resetPasswordlabel.Text = "Reset Password Page";
            // 
            // toolTipTab
            // 
            this.toolTipTab.AutomaticDelay = 200;
            // 
            // LoginPageForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 402);
            this.Controls.Add(this.loginTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginPageForm";
            this.Text = "GMMS Login Page";
            this.Load += new System.EventHandler(this.LoginPageForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginPageForm_KeyDown);
            this.loginTabControl.ResumeLayout(false);
            this.loginPageTab.ResumeLayout(false);
            this.loginPageTab.PerformLayout();
            this.resetPageTab.ResumeLayout(false);
            this.resetPageTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl loginTabControl;
        private System.Windows.Forms.TabPage loginPageTab;
        private System.Windows.Forms.TabPage resetPageTab;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox birthYearTextBox;
        private System.Windows.Forms.Label phoneNumberLabel2;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.Label resetPasswordlabel;
        private System.Windows.Forms.Label resetErrorLabel;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Label newPassNotifLabel;
        private System.Windows.Forms.ToolTip toolTipTab;
        private System.Windows.Forms.Label labelLoginTime;
        private System.Windows.Forms.Label labelLoginDate;
        private System.Windows.Forms.Label labelResetPswdDate;
        private System.Windows.Forms.Label labelResetPswdTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
    }
}

