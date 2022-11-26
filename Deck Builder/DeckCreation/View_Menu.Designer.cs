namespace Deck_Builder.DeckCreation
{
    partial class View_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Menu));
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_View = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(620, 412);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(150, 30);
            this.Button_Back.TabIndex = 0;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_View
            // 
            this.Button_View.Location = new System.Drawing.Point(464, 412);
            this.Button_View.Name = "Button_View";
            this.Button_View.Size = new System.Drawing.Size(150, 30);
            this.Button_View.TabIndex = 2;
            this.Button_View.Text = "View Deck";
            this.Button_View.UseVisualStyleBackColor = true;
            this.Button_View.Click += new System.EventHandler(this.Button_View_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(758, 393);
            this.DataGrid.TabIndex = 3;
            // 
            // View_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Button_View);
            this.Controls.Add(this.Button_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_Menu_FormClosing);
            this.Load += new System.EventHandler(this.View_Menu_Load);
            this.Resize += new System.EventHandler(this.View_Menu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_View;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}