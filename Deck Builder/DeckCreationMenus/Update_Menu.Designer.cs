namespace Deck_Builder.DeckCreation
{
    partial class Update_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Menu));
            this.Label_Placeholder = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Placeholder
            // 
            this.Label_Placeholder.AutoSize = true;
            this.Label_Placeholder.Location = new System.Drawing.Point(359, 187);
            this.Label_Placeholder.Name = "Label_Placeholder";
            this.Label_Placeholder.Size = new System.Drawing.Size(83, 17);
            this.Label_Placeholder.TabIndex = 0;
            this.Label_Placeholder.Text = "Placeholder";
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(324, 207);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(150, 30);
            this.Button_Back.TabIndex = 1;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Update_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Label_Placeholder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Update_Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Placeholder;
        private System.Windows.Forms.Button Button_Back;
    }
}