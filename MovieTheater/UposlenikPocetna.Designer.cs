namespace MovieTheater
{
    partial class UposlenikPocetna
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
            this.uposlenikUsername_label = new System.Windows.Forms.Label();
            this.odjava_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uposlenikUsername_label
            // 
            this.uposlenikUsername_label.AutoSize = true;
            this.uposlenikUsername_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uposlenikUsername_label.Location = new System.Drawing.Point(464, 9);
            this.uposlenikUsername_label.Name = "uposlenikUsername_label";
            this.uposlenikUsername_label.Size = new System.Drawing.Size(134, 31);
            this.uposlenikUsername_label.TabIndex = 0;
            this.uposlenikUsername_label.Text = "Uposlenik";
            // 
            // odjava_button
            // 
            this.odjava_button.Location = new System.Drawing.Point(501, 267);
            this.odjava_button.Name = "odjava_button";
            this.odjava_button.Size = new System.Drawing.Size(97, 41);
            this.odjava_button.TabIndex = 1;
            this.odjava_button.Text = "Odjava";
            this.odjava_button.UseVisualStyleBackColor = true;
            this.odjava_button.Click += new System.EventHandler(this.odjava_button_Click);
            // 
            // UposlenikPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 333);
            this.Controls.Add(this.odjava_button);
            this.Controls.Add(this.uposlenikUsername_label);
            this.Name = "UposlenikPocetna";
            this.Text = "UposlenikPocetna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uposlenikUsername_label;
        private System.Windows.Forms.Button odjava_button;
    }
}