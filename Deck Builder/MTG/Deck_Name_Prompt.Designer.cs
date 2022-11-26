namespace Deck_Builder.MTG
{
    partial class Deck_Name_Prompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deck_Name_Prompt));
            this.Button_Submit = new System.Windows.Forms.Button();
            this.TextBox_SetName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Submit
            // 
            this.Button_Submit.Location = new System.Drawing.Point(117, 78);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(150, 30);
            this.Button_Submit.TabIndex = 0;
            this.Button_Submit.Text = "Submit";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // TextBox_SetName
            // 
            this.TextBox_SetName.Location = new System.Drawing.Point(77, 50);
            this.TextBox_SetName.Name = "TextBox_SetName";
            this.TextBox_SetName.Size = new System.Drawing.Size(224, 22);
            this.TextBox_SetName.TabIndex = 1;
            this.TextBox_SetName.Text = "Enter Decklist Name Here";
            this.TextBox_SetName.Enter += new System.EventHandler(this.TextBox_SetName_Enter);
            this.TextBox_SetName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_SetName_KeyDown);
            // 
            // User_Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.TextBox_SetName);
            this.Controls.Add(this.Button_Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_Prompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prompt";
            this.Load += new System.EventHandler(this.Deck_Name_Prompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.TextBox TextBox_SetName;
    }
}