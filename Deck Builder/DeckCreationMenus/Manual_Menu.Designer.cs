namespace Deck_Builder.DeckCreation
{
    partial class Manual_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual_Menu));
            this.Button_Success = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Success
            // 
            this.Button_Success.Location = new System.Drawing.Point(315, 167);
            this.Button_Success.Name = "Button_Success";
            this.Button_Success.Size = new System.Drawing.Size(150, 30);
            this.Button_Success.TabIndex = 0;
            this.Button_Success.Text = "Success";
            this.Button_Success.UseVisualStyleBackColor = true;
            this.Button_Success.Click += new System.EventHandler(this.Button_Success_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(315, 203);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(150, 30);
            this.Button_Back.TabIndex = 1;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "You\'re Insane";
            // 
            // Manual_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_Success);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manual_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual_Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manual_Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Success;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Label label1;
    }
}