namespace DVDS
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.mainLogin = new System.Windows.Forms.PictureBox();
            this.passwordAvatar = new System.Windows.Forms.PictureBox();
            this.loginAvatar = new System.Windows.Forms.PictureBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.passwordToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.mainLogin);
            this.panel1.Controls.Add(this.passwordAvatar);
            this.panel1.Controls.Add(this.loginAvatar);
            this.panel1.Controls.Add(this.loginTextBox);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 429);
            this.panel1.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginLabel.Location = new System.Drawing.Point(294, 121);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(148, 28);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Вход в систему";
            // 
            // mainLogin
            // 
            this.mainLogin.InitialImage = global::DVDS.Properties.Resources.LoginMain;
            this.mainLogin.Location = new System.Drawing.Point(238, 101);
            this.mainLogin.Name = "mainLogin";
            this.mainLogin.Size = new System.Drawing.Size(50, 50);
            this.mainLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainLogin.TabIndex = 6;
            this.mainLogin.TabStop = false;
            // 
            // passwordAvatar
            // 
            this.passwordAvatar.InitialImage = global::DVDS.Properties.Resources.LoginPassword;
            this.passwordAvatar.Location = new System.Drawing.Point(209, 197);
            this.passwordAvatar.Name = "passwordAvatar";
            this.passwordAvatar.Size = new System.Drawing.Size(23, 23);
            this.passwordAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordAvatar.TabIndex = 5;
            this.passwordAvatar.TabStop = false;
            // 
            // loginAvatar
            // 
            this.loginAvatar.InitialImage = global::DVDS.Properties.Resources.LoginAvatar;
            this.loginAvatar.Location = new System.Drawing.Point(209, 157);
            this.loginAvatar.Name = "loginAvatar";
            this.loginAvatar.Size = new System.Drawing.Size(23, 23);
            this.loginAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginAvatar.TabIndex = 4;
            this.loginAvatar.TabStop = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(238, 157);
            this.loginTextBox.MaximumSize = new System.Drawing.Size(225, 34);
            this.loginTextBox.MinimumSize = new System.Drawing.Size(225, 34);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(225, 22);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDownEnterLogin);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(238, 237);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(225, 34);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginUserInSystem);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(238, 197);
            this.passwordTextBox.MaximumSize = new System.Drawing.Size(225, 34);
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(225, 34);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(225, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDownEnterLogin);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 453);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 500);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прокат дисков";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox passwordAvatar;
        private System.Windows.Forms.PictureBox loginAvatar;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox mainLogin;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ToolTip loginToolTip;
        private System.Windows.Forms.ToolTip passwordToolTip;
    }
}

