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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainFormTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SecurityTabPage = new System.Windows.Forms.TabPage();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.resetErrorLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.ChangeAttemptsLabel = new System.Windows.Forms.Button();
            this.attemtsTextBox = new System.Windows.Forms.TextBox();
            this.AttemptsLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SecurityTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainFormTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.SecurityTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // mainFormTabPage
            // 
            this.mainFormTabPage.Location = new System.Drawing.Point(4, 25);
            this.mainFormTabPage.Name = "mainFormTabPage";
            this.mainFormTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainFormTabPage.Size = new System.Drawing.Size(1026, 481);
            this.mainFormTabPage.TabIndex = 0;
            this.mainFormTabPage.Text = "tabPage1";
            this.mainFormTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1026, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SecurityTabPage
            // 
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
            this.SecurityTabPage.Name = "SecurityTabPage";
            this.SecurityTabPage.Size = new System.Drawing.Size(1026, 481);
            this.SecurityTabPage.TabIndex = 2;
            this.SecurityTabPage.Text = "System Security";
            this.SecurityTabPage.UseVisualStyleBackColor = true;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.Location = new System.Drawing.Point(56, 358);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(129, 63);
            this.changePasswordButton.TabIndex = 16;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(211, 327);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.newPasswordTextBox.TabIndex = 14;
            // 
            // newPassLabel
            // 
            this.newPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.Location = new System.Drawing.Point(49, 327);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(165, 28);
            this.newPassLabel.TabIndex = 13;
            this.newPassLabel.Text = "New Password: ";
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(206, 355);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(458, 28);
            this.instructionLabel.TabIndex = 15;
            this.instructionLabel.Text = "New System password will be aplied on next start up";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(211, 289);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.oldPasswordTextBox.TabIndex = 18;
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassLabel.Location = new System.Drawing.Point(49, 289);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(165, 28);
            this.oldPassLabel.TabIndex = 17;
            this.oldPassLabel.Text = "Old Password: ";
            // 
            // resetErrorLabel
            // 
            this.resetErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetErrorLabel.Location = new System.Drawing.Point(206, 393);
            this.resetErrorLabel.Name = "resetErrorLabel";
            this.resetErrorLabel.Size = new System.Drawing.Size(415, 28);
            this.resetErrorLabel.TabIndex = 19;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(206, 179);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(415, 28);
            this.errorLabel.TabIndex = 24;
            // 
            // ChangeAttemptsLabel
            // 
            this.ChangeAttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAttemptsLabel.Location = new System.Drawing.Point(56, 144);
            this.ChangeAttemptsLabel.Name = "ChangeAttemptsLabel";
            this.ChangeAttemptsLabel.Size = new System.Drawing.Size(129, 63);
            this.ChangeAttemptsLabel.TabIndex = 23;
            this.ChangeAttemptsLabel.Text = "Change Attempts";
            this.ChangeAttemptsLabel.UseVisualStyleBackColor = true;
            this.ChangeAttemptsLabel.Click += new System.EventHandler(this.ChangeAttemptsLabel_Click);
            // 
            // attemtsTextBox
            // 
            this.attemtsTextBox.Location = new System.Drawing.Point(211, 113);
            this.attemtsTextBox.Name = "attemtsTextBox";
            this.attemtsTextBox.Size = new System.Drawing.Size(353, 22);
            this.attemtsTextBox.TabIndex = 21;
            // 
            // AttemptsLabel
            // 
            this.AttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptsLabel.Location = new System.Drawing.Point(8, 82);
            this.AttemptsLabel.Name = "AttemptsLabel";
            this.AttemptsLabel.Size = new System.Drawing.Size(197, 59);
            this.AttemptsLabel.TabIndex = 20;
            this.AttemptsLabel.Text = "New Allowed Number of Attempts: ";
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainPageForm";
            this.Text = "Gym System Main Page ";
            this.tabControl1.ResumeLayout(false);
            this.SecurityTabPage.ResumeLayout(false);
            this.SecurityTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage mainFormTabPage;
        private TabPage tabPage2;
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
    }
}