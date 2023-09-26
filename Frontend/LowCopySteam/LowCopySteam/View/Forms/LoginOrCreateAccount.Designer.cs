namespace LowCopySteam.View.Forms
{
    partial class LoginOrCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOrCreateAccount));
            SignIn_panel = new Panel();
            checkPassword_panel = new Panel();
            signIn_button = new Button();
            remember_checkBox = new CheckBox();
            logoSteam_panel = new Panel();
            password_textBox = new TextBox();
            password_label = new Label();
            login_textBox = new TextBox();
            login_label = new Label();
            signIn_label = new Label();
            SignIn_panel.SuspendLayout();
            SuspendLayout();
            // 
            // SignIn_panel
            // 
            SignIn_panel.Controls.Add(checkPassword_panel);
            SignIn_panel.Controls.Add(signIn_button);
            SignIn_panel.Controls.Add(remember_checkBox);
            SignIn_panel.Controls.Add(logoSteam_panel);
            SignIn_panel.Controls.Add(password_textBox);
            SignIn_panel.Controls.Add(password_label);
            SignIn_panel.Controls.Add(login_textBox);
            SignIn_panel.Controls.Add(login_label);
            SignIn_panel.Controls.Add(signIn_label);
            SignIn_panel.ForeColor = Color.FromArgb(253, 253, 253);
            SignIn_panel.Location = new Point(12, 12);
            SignIn_panel.Name = "SignIn_panel";
            SignIn_panel.Size = new Size(571, 272);
            SignIn_panel.TabIndex = 0;
            // 
            // checkPassword_panel
            // 
            checkPassword_panel.BackgroundImage = (Image)resources.GetObject("checkPassword_panel.BackgroundImage");
            checkPassword_panel.BackgroundImageLayout = ImageLayout.Zoom;
            checkPassword_panel.Location = new Point(279, 142);
            checkPassword_panel.Name = "checkPassword_panel";
            checkPassword_panel.Size = new Size(34, 27);
            checkPassword_panel.TabIndex = 8;
            checkPassword_panel.Click += checkPassword_panel_Click;
            // 
            // signIn_button
            // 
            signIn_button.BackColor = Color.FromArgb(25, 155, 255);
            signIn_button.FlatStyle = FlatStyle.Popup;
            signIn_button.Font = new Font("Sans Serif Collection", 7F, FontStyle.Bold, GraphicsUnit.Point);
            signIn_button.Location = new Point(87, 212);
            signIn_button.Name = "signIn_button";
            signIn_button.Size = new Size(125, 36);
            signIn_button.TabIndex = 7;
            signIn_button.Text = "Sign in";
            signIn_button.UseVisualStyleBackColor = false;
            signIn_button.Click += signIn_button_Click;
            // 
            // remember_checkBox
            // 
            remember_checkBox.AutoSize = true;
            remember_checkBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            remember_checkBox.ForeColor = Color.FromArgb(175, 175, 171);
            remember_checkBox.Location = new Point(29, 175);
            remember_checkBox.Name = "remember_checkBox";
            remember_checkBox.Size = new Size(93, 19);
            remember_checkBox.TabIndex = 6;
            remember_checkBox.Text = "Remeber me";
            remember_checkBox.UseVisualStyleBackColor = true;
            // 
            // logoSteam_panel
            // 
            logoSteam_panel.BackgroundImage = (Image)resources.GetObject("logoSteam_panel.BackgroundImage");
            logoSteam_panel.BackgroundImageLayout = ImageLayout.Stretch;
            logoSteam_panel.Location = new Point(346, 37);
            logoSteam_panel.Name = "logoSteam_panel";
            logoSteam_panel.Size = new Size(200, 200);
            logoSteam_panel.TabIndex = 5;
            // 
            // password_textBox
            // 
            password_textBox.BackColor = Color.FromArgb(50, 53, 60);
            password_textBox.BorderStyle = BorderStyle.FixedSingle;
            password_textBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            password_textBox.ForeColor = Color.FromArgb(253, 253, 253);
            password_textBox.Location = new Point(29, 142);
            password_textBox.MaxLength = 150;
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(246, 27);
            password_textBox.TabIndex = 4;
            password_textBox.UseSystemPasswordChar = true;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            password_label.ForeColor = Color.FromArgb(175, 175, 171);
            password_label.Location = new Point(29, 115);
            password_label.Name = "password_label";
            password_label.Padding = new Padding(0, 0, 0, 5);
            password_label.Size = new Size(97, 24);
            password_label.TabIndex = 3;
            password_label.Text = "PASSWORD";
            // 
            // login_textBox
            // 
            login_textBox.BackColor = Color.FromArgb(50, 53, 60);
            login_textBox.BorderStyle = BorderStyle.FixedSingle;
            login_textBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            login_textBox.ForeColor = Color.FromArgb(253, 253, 253);
            login_textBox.Location = new Point(29, 73);
            login_textBox.MaxLength = 100;
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(246, 27);
            login_textBox.TabIndex = 2;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            login_label.ForeColor = Color.FromArgb(24, 119, 255);
            login_label.Location = new Point(29, 46);
            login_label.Name = "login_label";
            login_label.Padding = new Padding(0, 0, 0, 5);
            login_label.Size = new Size(57, 24);
            login_label.TabIndex = 1;
            login_label.Text = "LOGIN";
            // 
            // signIn_label
            // 
            signIn_label.AutoSize = true;
            signIn_label.BackColor = Color.FromArgb(24, 26, 33);
            signIn_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signIn_label.ForeColor = Color.FromArgb(253, 253, 253);
            signIn_label.Location = new Point(249, 9);
            signIn_label.Name = "signIn_label";
            signIn_label.Size = new Size(74, 25);
            signIn_label.TabIndex = 0;
            signIn_label.Text = "Sign in";
            // 
            // LoginOrCreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 33);
            ClientSize = new Size(595, 296);
            Controls.Add(SignIn_panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginOrCreateAccount";
            Text = "Steam";
            SignIn_panel.ResumeLayout(false);
            SignIn_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SignIn_panel;
        private Label login_label;
        private Label signIn_label;
        private Label password_label;
        private TextBox login_textBox;
        private Panel logoSteam_panel;
        private TextBox password_textBox;
        private CheckBox remember_checkBox;
        private Button signIn_button;
        private Panel checkPassword_panel;
    }
}