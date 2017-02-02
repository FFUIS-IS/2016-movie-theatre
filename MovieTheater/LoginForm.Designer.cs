namespace MovieTheater
{
    partial class LoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelLoginButton = new System.Windows.Forms.Button();
            this.loginTypeComboBox = new System.Windows.Forms.ComboBox();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(233, 268);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(138, 42);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(339, 185);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(180, 29);
            this.passwordTextBox.TabIndex = 1;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(339, 120);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(180, 29);
            this.userNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // cancelLoginButton
            // 
            this.cancelLoginButton.Location = new System.Drawing.Point(385, 268);
            this.cancelLoginButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelLoginButton.Name = "cancelLoginButton";
            this.cancelLoginButton.Size = new System.Drawing.Size(138, 42);
            this.cancelLoginButton.TabIndex = 5;
            this.cancelLoginButton.Text = "Cancel";
            this.cancelLoginButton.UseVisualStyleBackColor = true;
            this.cancelLoginButton.Click += new System.EventHandler(this.cancelLoginButton_Click);
            // 
            // loginTypeComboBox
            // 
            this.loginTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.jobsBindingSource, "jobName", true));
            this.loginTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jobsBindingSource, "jobId", true));
            this.loginTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "jobName", true));
            this.loginTypeComboBox.FormattingEnabled = true;
            this.loginTypeComboBox.Location = new System.Drawing.Point(233, 44);
            this.loginTypeComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginTypeComboBox.Name = "loginTypeComboBox";
            this.loginTypeComboBox.Size = new System.Drawing.Size(286, 32);
            this.loginTypeComboBox.TabIndex = 6;
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataSource = typeof(MovieTheater.ViewModels.Jobs);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 506);
            this.Controls.Add(this.loginTypeComboBox);
            this.Controls.Add(this.cancelLoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelLoginButton;
        private System.Windows.Forms.ComboBox loginTypeComboBox;
        private System.Windows.Forms.BindingSource jobsBindingSource;
    }
}