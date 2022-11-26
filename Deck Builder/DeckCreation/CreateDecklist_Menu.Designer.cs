namespace Deck_Builder.DeckCreation
{
    partial class CreateDecklist_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDecklist_Menu));
            this.Button_Import = new System.Windows.Forms.Button();
            this.Button_Manual = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Import
            // 
            this.Button_Import.Location = new System.Drawing.Point(12, 12);
            this.Button_Import.Name = "Button_Import";
            this.Button_Import.Size = new System.Drawing.Size(150, 30);
            this.Button_Import.TabIndex = 0;
            this.Button_Import.Text = "From Import";
            this.Button_Import.UseVisualStyleBackColor = true;
            this.Button_Import.Click += new System.EventHandler(this.Button_Import_Click);
            // 
            // Button_Manual
            // 
            this.Button_Manual.Location = new System.Drawing.Point(12, 48);
            this.Button_Manual.Name = "Button_Manual";
            this.Button_Manual.Size = new System.Drawing.Size(150, 30);
            this.Button_Manual.TabIndex = 1;
            this.Button_Manual.Text = "Manual Entry";
            this.Button_Manual.UseVisualStyleBackColor = true;
            this.Button_Manual.Click += new System.EventHandler(this.Button_Manual_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(12, 84);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(150, 30);
            this.Button_Back.TabIndex = 2;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 283);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CreateDecklist_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_Manual);
            this.Controls.Add(this.Button_Import);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateDecklist_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Decklist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateDecklist_Menu_FormClosing);
            this.Load += new System.EventHandler(this.CreateDecklist_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Import;
        private System.Windows.Forms.Button Button_Manual;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}