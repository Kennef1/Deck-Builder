namespace Deck_Builder.MTG
{
    partial class Loading_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_Screen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Progress_Box = new System.Windows.Forms.TextBox();
            this.Progress_Bar = new System.Windows.Forms.ProgressBar();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Deck_Builder.Properties.Resources.mmm;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Progress_Box
            // 
            this.Progress_Box.Enabled = false;
            this.Progress_Box.Location = new System.Drawing.Point(11, 239);
            this.Progress_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Progress_Box.Name = "Progress_Box";
            this.Progress_Box.Size = new System.Drawing.Size(220, 22);
            this.Progress_Box.TabIndex = 2;
            // 
            // Progress_Bar
            // 
            this.Progress_Bar.Location = new System.Drawing.Point(11, 264);
            this.Progress_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Progress_Bar.Name = "Progress_Bar";
            this.Progress_Bar.Size = new System.Drawing.Size(220, 22);
            this.Progress_Bar.TabIndex = 3;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(12, 291);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(220, 30);
            this.Button_Cancel.TabIndex = 4;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Loading_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 333);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Progress_Bar);
            this.Controls.Add(this.Progress_Box);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Loading_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loading_Screen_FormClosing);
            this.Load += new System.EventHandler(this.Loading_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Progress_Box;
        private System.Windows.Forms.ProgressBar Progress_Bar;
        private System.Windows.Forms.Button Button_Cancel;
    }
}