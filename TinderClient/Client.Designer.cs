namespace TinderClient
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoLikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUnmatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportFakeAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goldAutoLikerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem,
            this.blacklistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem,
            this.autoLikeToolStripMenuItem,
            this.goldAutoLikerToolStripMenuItem,
            this.messageMatchesToolStripMenuItem,
            this.contactCardsToolStripMenuItem,
            this.changeLocationToolStripMenuItem,
            this.autoUnmatcherToolStripMenuItem,
            this.searchPreferencesToolStripMenuItem,
            this.reportFakeAccountsToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // autoLikeToolStripMenuItem
            // 
            this.autoLikeToolStripMenuItem.Name = "autoLikeToolStripMenuItem";
            this.autoLikeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.autoLikeToolStripMenuItem.Text = "Auto Liker";
            this.autoLikeToolStripMenuItem.Click += new System.EventHandler(this.autoLikeToolStripMenuItem_Click);
            // 
            // autoUnmatcherToolStripMenuItem
            // 
            this.autoUnmatcherToolStripMenuItem.Name = "autoUnmatcherToolStripMenuItem";
            this.autoUnmatcherToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.autoUnmatcherToolStripMenuItem.Text = "Unmatcher";
            this.autoUnmatcherToolStripMenuItem.Click += new System.EventHandler(this.autoUnmatcherToolStripMenuItem_Click);
            // 
            // messageMatchesToolStripMenuItem
            // 
            this.messageMatchesToolStripMenuItem.Name = "messageMatchesToolStripMenuItem";
            this.messageMatchesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.messageMatchesToolStripMenuItem.Text = "Messenger";
            this.messageMatchesToolStripMenuItem.Click += new System.EventHandler(this.messageMatchesToolStripMenuItem_Click);
            // 
            // changeLocationToolStripMenuItem
            // 
            this.changeLocationToolStripMenuItem.Name = "changeLocationToolStripMenuItem";
            this.changeLocationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.changeLocationToolStripMenuItem.Text = "Location";
            this.changeLocationToolStripMenuItem.Click += new System.EventHandler(this.changeLocationToolStripMenuItem_Click);
            // 
            // searchPreferencesToolStripMenuItem
            // 
            this.searchPreferencesToolStripMenuItem.Name = "searchPreferencesToolStripMenuItem";
            this.searchPreferencesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.searchPreferencesToolStripMenuItem.Text = "Search Preferences";
            this.searchPreferencesToolStripMenuItem.Click += new System.EventHandler(this.searchPreferencesToolStripMenuItem_Click);
            // 
            // reportFakeAccountsToolStripMenuItem
            // 
            this.reportFakeAccountsToolStripMenuItem.Enabled = false;
            this.reportFakeAccountsToolStripMenuItem.Name = "reportFakeAccountsToolStripMenuItem";
            this.reportFakeAccountsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reportFakeAccountsToolStripMenuItem.Text = "Report Fake Accounts";
            this.reportFakeAccountsToolStripMenuItem.Click += new System.EventHandler(this.reportFakeAccountsToolStripMenuItem_Click);
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editProfileToolStripMenuItem.Text = "Profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // goldAutoLikerToolStripMenuItem
            // 
            this.goldAutoLikerToolStripMenuItem.Name = "goldAutoLikerToolStripMenuItem";
            this.goldAutoLikerToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.goldAutoLikerToolStripMenuItem.Text = "\"Gold\" Auto Liker";
            this.goldAutoLikerToolStripMenuItem.Click += new System.EventHandler(this.goldAutoLikerToolStripMenuItem_Click);
            // 
            // contactCardsToolStripMenuItem
            // 
            this.contactCardsToolStripMenuItem.Name = "contactCardsToolStripMenuItem";
            this.contactCardsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.contactCardsToolStripMenuItem.Text = "Contact Cards";
            this.contactCardsToolStripMenuItem.Click += new System.EventHandler(this.contactCardsToolStripMenuItem_Click);
            // 
            // blacklistToolStripMenuItem
            // 
            this.blacklistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.blacklistToolStripMenuItem.Name = "blacklistToolStripMenuItem";
            this.blacklistToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.blacklistToolStripMenuItem.Text = "Blacklist";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(95, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblBio
            // 
            this.lblBio.Location = new System.Drawing.Point(97, 53);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(170, 53);
            this.lblBio.TabIndex = 3;
            this.lblBio.Text = "Bio";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 116);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Client";
            this.Text = "Waifu\'s Tinder Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoLikeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem messageMatchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportFakeAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoUnmatcherToolStripMenuItem;
        public System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.ToolStripMenuItem blacklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goldAutoLikerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactCardsToolStripMenuItem;
    }
}