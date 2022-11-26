namespace Deck_Builder.DeckCreation
{
    partial class Import_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import_Menu));
            this.textBox_Directory = new System.Windows.Forms.TextBox();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Test = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Directory
            // 
            this.textBox_Directory.Location = new System.Drawing.Point(122, 207);
            this.textBox_Directory.Name = "textBox_Directory";
            this.textBox_Directory.Size = new System.Drawing.Size(321, 22);
            this.textBox_Directory.TabIndex = 0;
            this.textBox_Directory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Directory_KeyDown);
            // 
            // Button_Submit
            // 
            this.Button_Submit.Location = new System.Drawing.Point(497, 203);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(150, 30);
            this.Button_Submit.TabIndex = 1;
            this.Button_Submit.Text = "Submit";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Directory for Archidekt Export File";
            // 
            // Label_Test
            // 
            this.Label_Test.AutoSize = true;
            this.Label_Test.Location = new System.Drawing.Point(329, 337);
            this.Label_Test.Name = "Label_Test";
            this.Label_Test.Size = new System.Drawing.Size(0, 17);
            this.Label_Test.TabIndex = 3;
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(497, 275);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(150, 30);
            this.Button_Back.TabIndex = 4;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_Browse
            // 
            this.Button_Browse.Location = new System.Drawing.Point(497, 239);
            this.Button_Browse.Name = "Button_Browse";
            this.Button_Browse.Size = new System.Drawing.Size(150, 30);
            this.Button_Browse.TabIndex = 5;
            this.Button_Browse.Text = "Browse";
            this.Button_Browse.UseVisualStyleBackColor = true;
            this.Button_Browse.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // Import_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Browse);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Label_Test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.textBox_Directory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Import_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Import_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Import_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Directory;
        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Test;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_Browse;
    }
}