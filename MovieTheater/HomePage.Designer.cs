namespace MovieTheater
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(304, 198);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(94, 42);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "Prijava";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // closeAppButton
            // 
            this.closeAppButton.Location = new System.Drawing.Point(421, 198);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(105, 42);
            this.closeAppButton.TabIndex = 2;
            this.closeAppButton.Text = "Izadji";
            this.closeAppButton.UseVisualStyleBackColor = true;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);

            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 284);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "HomePage1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button closeAppButton;
    }
}