namespace ProjectPracticeV2
{
    partial class Registration
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
            this.ExitForm = new System.Windows.Forms.Button();
            this.RollUpForm = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.PassVisibleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitForm
            // 
            this.ExitForm.BackColor = System.Drawing.Color.Transparent;
            this.ExitForm.BackgroundImage = global::ProjectPracticeV2.Properties.Resources.Exit;
            this.ExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitForm.Location = new System.Drawing.Point(739, 12);
            this.ExitForm.Name = "ExitForm";
            this.ExitForm.Size = new System.Drawing.Size(33, 33);
            this.ExitForm.TabIndex = 0;
            this.ExitForm.UseVisualStyleBackColor = false;
            this.ExitForm.Click += new System.EventHandler(this.ExitForm_Click);
            // 
            // RollUpForm
            // 
            this.RollUpForm.BackColor = System.Drawing.Color.Transparent;
            this.RollUpForm.BackgroundImage = global::ProjectPracticeV2.Properties.Resources.RollUp;
            this.RollUpForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollUpForm.Location = new System.Drawing.Point(675, 20);
            this.RollUpForm.Name = "RollUpForm";
            this.RollUpForm.Size = new System.Drawing.Size(47, 17);
            this.RollUpForm.TabIndex = 1;
            this.RollUpForm.UseVisualStyleBackColor = false;
            this.RollUpForm.Click += new System.EventHandler(this.RollUpForm_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.LoginTextBox.Location = new System.Drawing.Point(89, 157);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(214, 20);
            this.LoginTextBox.TabIndex = 2;
            this.LoginTextBox.Text = "Логин";
            // 
            // PassTextBox
            // 
            this.PassTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.PassTextBox.Location = new System.Drawing.Point(89, 214);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(214, 20);
            this.PassTextBox.TabIndex = 3;
            this.PassTextBox.Text = "Пароль";
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.BackColor = System.Drawing.Color.Transparent;
            this.AuthorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorizationButton.ForeColor = System.Drawing.Color.Yellow;
            this.AuthorizationButton.Location = new System.Drawing.Point(108, 280);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(178, 45);
            this.AuthorizationButton.TabIndex = 4;
            this.AuthorizationButton.Text = "Авторизация";
            this.AuthorizationButton.UseVisualStyleBackColor = false;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.ForeColor = System.Drawing.Color.Yellow;
            this.RegistrationButton.Location = new System.Drawing.Point(108, 345);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(178, 45);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // PassVisibleButton
            // 
            this.PassVisibleButton.BackColor = System.Drawing.Color.Transparent;
            this.PassVisibleButton.BackgroundImage = global::ProjectPracticeV2.Properties.Resources.PassVisibleButton;
            this.PassVisibleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassVisibleButton.Location = new System.Drawing.Point(309, 208);
            this.PassVisibleButton.Name = "PassVisibleButton";
            this.PassVisibleButton.Size = new System.Drawing.Size(32, 30);
            this.PassVisibleButton.TabIndex = 6;
            this.PassVisibleButton.UseVisualStyleBackColor = false;
            this.PassVisibleButton.Click += new System.EventHandler(this.PassVisibleButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPracticeV2.Properties.Resources.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PassVisibleButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.AuthorizationButton);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.RollUpForm);
            this.Controls.Add(this.ExitForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitForm;
        private System.Windows.Forms.Button RollUpForm;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button PassVisibleButton;
    }
}

