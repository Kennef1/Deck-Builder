namespace Deck_Builder.DeckCreation
{
    partial class Menu_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Delete));
            this.Button_Back = new System.Windows.Forms.Button();
            this.Label_Placeholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(317, 229);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(150, 30);
            this.Button_Back.TabIndex = 0;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Label_Placeholder
            // 
            this.Label_Placeholder.AutoSize = true;
            this.Label_Placeholder.Location = new System.Drawing.Point(349, 209);
            this.Label_Placeholder.Name = "Label_Placeholder";
            this.Label_Placeholder.Size = new System.Drawing.Size(83, 17);
            this.Label_Placeholder.TabIndex = 1;
            this.Label_Placeholder.Text = "Placeholder";
            // 
            // Delete_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Placeholder);
            this.Controls.Add(this.Button_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delete_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Menu";
            this.Load += new System.EventHandler(this.Delete_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Label Label_Placeholder;
    }
}