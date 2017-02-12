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
            this.projekcijeDataGridView = new System.Windows.Forms.DataGridView();
            this.prodajaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uposlenikUsername_label
            // 
            this.uposlenikUsername_label.AutoSize = true;
            this.uposlenikUsername_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uposlenikUsername_label.Location = new System.Drawing.Point(851, 17);
            this.uposlenikUsername_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uposlenikUsername_label.Name = "uposlenikUsername_label";
            this.uposlenikUsername_label.Size = new System.Drawing.Size(229, 54);
            this.uposlenikUsername_label.TabIndex = 0;
            this.uposlenikUsername_label.Text = "Uposlenik";
            // 
            // odjava_button
            // 
            this.odjava_button.Location = new System.Drawing.Point(919, 493);
            this.odjava_button.Margin = new System.Windows.Forms.Padding(6);
            this.odjava_button.Name = "odjava_button";
            this.odjava_button.Size = new System.Drawing.Size(178, 76);
            this.odjava_button.TabIndex = 1;
            this.odjava_button.Text = "Odjava";
            this.odjava_button.UseVisualStyleBackColor = true;
            this.odjava_button.Click += new System.EventHandler(this.odjava_button_Click);
            // 
            // projekcijeDataGridView
            // 
            this.projekcijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projekcijeDataGridView.Location = new System.Drawing.Point(26, 26);
            this.projekcijeDataGridView.Name = "projekcijeDataGridView";
            this.projekcijeDataGridView.RowTemplate.Height = 31;
            this.projekcijeDataGridView.Size = new System.Drawing.Size(793, 347);
            this.projekcijeDataGridView.TabIndex = 2;
            // 
            // prodajaButton
            // 
            this.prodajaButton.Location = new System.Drawing.Point(26, 411);
            this.prodajaButton.Name = "prodajaButton";
            this.prodajaButton.Size = new System.Drawing.Size(178, 63);
            this.prodajaButton.TabIndex = 3;
            this.prodajaButton.Text = "Prodaja";
            this.prodajaButton.UseVisualStyleBackColor = true;
            this.prodajaButton.Click += new System.EventHandler(this.prodajaButton_Click);
            // 
            // UposlenikPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 615);
            this.Controls.Add(this.prodajaButton);
            this.Controls.Add(this.projekcijeDataGridView);
            this.Controls.Add(this.odjava_button);
            this.Controls.Add(this.uposlenikUsername_label);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UposlenikPocetna";
            this.Text = "UposlenikPocetna";
            this.Load += new System.EventHandler(this.UposlenikPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projekcijeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uposlenikUsername_label;
        private System.Windows.Forms.Button odjava_button;
        private System.Windows.Forms.DataGridView projekcijeDataGridView;
        private System.Windows.Forms.Button prodajaButton;
    }
}