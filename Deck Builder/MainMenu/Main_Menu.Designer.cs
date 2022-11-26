namespace Deck_Builder
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Button_Create = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_View = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Create
            // 
            this.Button_Create.Location = new System.Drawing.Point(12, 12);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(150, 30);
            this.Button_Create.TabIndex = 0;
            this.Button_Create.Text = "Create New Deck";
            this.Button_Create.UseVisualStyleBackColor = true;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point(12, 48);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(150, 30);
            this.Button_Update.TabIndex = 1;
            this.Button_Update.Text = "Update Existing Deck";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_View
            // 
            this.Button_View.Location = new System.Drawing.Point(12, 84);
            this.Button_View.Name = "Button_View";
            this.Button_View.Size = new System.Drawing.Size(150, 30);
            this.Button_View.TabIndex = 2;
            this.Button_View.Text = "View Existing Deck";
            this.Button_View.UseVisualStyleBackColor = true;
            this.Button_View.Click += new System.EventHandler(this.Button_View_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(12, 120);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(150, 30);
            this.Button_Delete.TabIndex = 3;
            this.Button_Delete.Text = "Delete Existing Deck";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(12, 156);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(150, 30);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "PICK AN OPTION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 379);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_View);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.Button_Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_View;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

