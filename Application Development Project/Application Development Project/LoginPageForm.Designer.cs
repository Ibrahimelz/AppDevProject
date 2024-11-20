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
            this.loginTabControl = new System.Windows.Forms.TabControl();
            this.loginPageTab = new System.Windows.Forms.TabPage();
            this.errorLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.resetPageTab = new System.Windows.Forms.TabPage();
            this.resetErrorLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.birthYearTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.resetPasswordlabel = new System.Windows.Forms.Label();
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
            this.loginTabControl.Name = "loginTabControl";
            this.loginTabControl.SelectedIndex = 0;
            this.loginTabControl.Size = new System.Drawing.Size(651, 257);
            this.loginTabControl.TabIndex = 0;
            // 
            // loginPageTab
            // 
            this.loginPageTab.Controls.Add(this.errorLabel);
            this.loginPageTab.Controls.Add(this.loginButton);
            this.loginPageTab.Controls.Add(this.passwordTextBox);
            this.loginPageTab.Controls.Add(this.nameTextBox);
            this.loginPageTab.Controls.Add(this.PasswordLabel);
            this.loginPageTab.Controls.Add(this.nameLabel);
            this.loginPageTab.Controls.Add(this.titleLabel);
            this.loginPageTab.Location = new System.Drawing.Point(4, 25);
            this.loginPageTab.Name = "loginPageTab";
            this.loginPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginPageTab.Size = new System.Drawing.Size(643, 228);
            this.loginPageTab.TabIndex = 0;
            this.loginPageTab.Text = "Login";
            this.loginPageTab.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(138, 160);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(499, 63);
            this.errorLabel.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(24, 152);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(99, 45);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(132, 108);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(353, 22);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(353, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(19, 108);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 28);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password: ";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(19, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 28);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(127, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(398, 28);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to the Gym Management System login page";
            // 
            // resetPageTab
            // 
            this.resetPageTab.Controls.Add(this.resetErrorLabel);
            this.resetPageTab.Controls.Add(this.changePasswordButton);
            this.resetPageTab.Controls.Add(this.label1);
            this.resetPageTab.Controls.Add(this.newPasswordTextBox);
            this.resetPageTab.Controls.Add(this.newPassLabel);
            this.resetPageTab.Controls.Add(this.phoneNumberTextBox);
            this.resetPageTab.Controls.Add(this.birthYearTextBox);
            this.resetPageTab.Controls.Add(this.PhoneNumberLabel);
            this.resetPageTab.Controls.Add(this.BirthLabel);
            this.resetPageTab.Controls.Add(this.resetPasswordlabel);
            this.resetPageTab.Location = new System.Drawing.Point(4, 25);
            this.resetPageTab.Name = "resetPageTab";
            this.resetPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.resetPageTab.Size = new System.Drawing.Size(643, 228);
            this.resetPageTab.TabIndex = 1;
            this.resetPageTab.Text = "Reset Password";
            this.resetPageTab.UseVisualStyleBackColor = true;
            // 
            // resetErrorLabel
            // 
            this.resetErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetErrorLabel.Location = new System.Drawing.Point(220, 180);
            this.resetErrorLabel.Name = "resetErrorLabel";
            this.resetErrorLabel.Size = new System.Drawing.Size(415, 28);
            this.resetErrorLabel.TabIndex = 13;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.Location = new System.Drawing.Point(70, 145);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(129, 63);
            this.changePasswordButton.TabIndex = 12;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "If succesful application will restart ";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(225, 114);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.newPasswordTextBox.TabIndex = 10;
            // 
            // newPassLabel
            // 
            this.newPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.Location = new System.Drawing.Point(63, 114);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(165, 28);
            this.newPassLabel.TabIndex = 9;
            this.newPassLabel.Text = "New Password: ";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(225, 76);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(353, 22);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // birthYearTextBox
            // 
            this.birthYearTextBox.Location = new System.Drawing.Point(225, 34);
            this.birthYearTextBox.Name = "birthYearTextBox";
            this.birthYearTextBox.Size = new System.Drawing.Size(353, 22);
            this.birthYearTextBox.TabIndex = 7;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(58, 72);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(170, 28);
            this.PhoneNumberLabel.TabIndex = 6;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // BirthLabel
            // 
            this.BirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthLabel.Location = new System.Drawing.Point(63, 28);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(136, 28);
            this.BirthLabel.TabIndex = 5;
            this.BirthLabel.Text = "Year of Birth: ";
            // 
            // resetPasswordlabel
            // 
            this.resetPasswordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordlabel.Location = new System.Drawing.Point(205, 3);
            this.resetPasswordlabel.Name = "resetPasswordlabel";
            this.resetPasswordlabel.Size = new System.Drawing.Size(207, 28);
            this.resetPasswordlabel.TabIndex = 1;
            this.resetPasswordlabel.Text = "Reset Password Page";
            // 
            // LoginPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 257);
            this.Controls.Add(this.loginTabControl);
            this.Name = "LoginPageForm";
            this.Text = "Gym System Login Page";
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
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.Label resetPasswordlabel;
        private System.Windows.Forms.Label resetErrorLabel;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Label label1;
    }
}

