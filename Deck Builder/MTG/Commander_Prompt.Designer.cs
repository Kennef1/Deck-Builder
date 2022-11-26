namespace Deck_Builder.MTG
{
    partial class Commander_Prompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commander_Prompt));
            this.listBox_Legendary = new System.Windows.Forms.ListBox();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Legendary
            // 
            this.listBox_Legendary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.listBox_Legendary.FormattingEnabled = true;
            this.listBox_Legendary.ItemHeight = 18;
            this.listBox_Legendary.Location = new System.Drawing.Point(12, 12);
            this.listBox_Legendary.Name = "listBox_Legendary";
            this.listBox_Legendary.Size = new System.Drawing.Size(358, 94);
            this.listBox_Legendary.TabIndex = 0;
            // 
            // Button_Submit
            // 
            this.Button_Submit.Location = new System.Drawing.Point(220, 118);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(150, 30);
            this.Button_Submit.TabIndex = 1;
            this.Button_Submit.Text = "Submit";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(64, 118);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(150, 30);
            this.Button_Close.TabIndex = 2;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            // 
            // Commander_Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.listBox_Legendary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Commander_Prompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commander_Prompt";
            this.Load += new System.EventHandler(this.Commander_Prompt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Legendary;
        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.Button Button_Close;
    }
}