
namespace MetadataEditor
{
    partial class Form1
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
            this.PhotoUploadButton = new System.Windows.Forms.Button();
            this.FlightDataUploadButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.photoDirLocationLabel = new System.Windows.Forms.Label();
            this.flightDataDirLocationLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhotoUploadButton
            // 
            this.PhotoUploadButton.Location = new System.Drawing.Point(75, 157);
            this.PhotoUploadButton.Name = "PhotoUploadButton";
            this.PhotoUploadButton.Size = new System.Drawing.Size(208, 80);
            this.PhotoUploadButton.TabIndex = 0;
            this.PhotoUploadButton.Text = "Choose Photos";
            this.PhotoUploadButton.UseVisualStyleBackColor = true;
            this.PhotoUploadButton.Click += new System.EventHandler(this.PhotoUploadButton_Click);
            // 
            // FlightDataUploadButton
            // 
            this.FlightDataUploadButton.Location = new System.Drawing.Point(506, 157);
            this.FlightDataUploadButton.Name = "FlightDataUploadButton";
            this.FlightDataUploadButton.Size = new System.Drawing.Size(208, 80);
            this.FlightDataUploadButton.TabIndex = 1;
            this.FlightDataUploadButton.Text = "Choose Flight Data";
            this.FlightDataUploadButton.UseVisualStyleBackColor = true;
            this.FlightDataUploadButton.Click += new System.EventHandler(this.FlightDataUploadButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "Go!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adfgToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adfgToolStripMenuItem
            // 
            this.adfgToolStripMenuItem.Name = "adfgToolStripMenuItem";
            this.adfgToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.adfgToolStripMenuItem.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the folder containing the drone photos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select the file containing the drone flight data (GPS coordinates, etc)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // photoDirLocationLabel
            // 
            this.photoDirLocationLabel.AutoSize = true;
            this.photoDirLocationLabel.Location = new System.Drawing.Point(72, 253);
            this.photoDirLocationLabel.Name = "photoDirLocationLabel";
            this.photoDirLocationLabel.Size = new System.Drawing.Size(0, 13);
            this.photoDirLocationLabel.TabIndex = 5;
            // 
            // flightDataDirLocationLabel
            // 
            this.flightDataDirLocationLabel.AutoSize = true;
            this.flightDataDirLocationLabel.Location = new System.Drawing.Point(503, 253);
            this.flightDataDirLocationLabel.Name = "flightDataDirLocationLabel";
            this.flightDataDirLocationLabel.Size = new System.Drawing.Size(0, 13);
            this.flightDataDirLocationLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flightDataDirLocationLabel);
            this.Controls.Add(this.photoDirLocationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FlightDataUploadButton);
            this.Controls.Add(this.PhotoUploadButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PhotoUploadButton;
        private System.Windows.Forms.Button FlightDataUploadButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adfgToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label photoDirLocationLabel;
        private System.Windows.Forms.Label flightDataDirLocationLabel;
    }
}

