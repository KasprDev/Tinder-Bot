namespace TinderClient
{
    partial class GoldLiker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoldLiker));
            this.button1 = new System.Windows.Forms.Button();
            this.numUsersToLike = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSecondsBetweenLikes = new System.Windows.Forms.NumericUpDown();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkAutomation = new System.Windows.Forms.CheckBox();
            this.groupAutomation = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.numRestartDelay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUsersToLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondsBetweenLikes)).BeginInit();
            this.groupAutomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numUsersToLike
            // 
            this.numUsersToLike.Location = new System.Drawing.Point(144, 11);
            this.numUsersToLike.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUsersToLike.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUsersToLike.Name = "numUsersToLike";
            this.numUsersToLike.Size = new System.Drawing.Size(64, 20);
            this.numUsersToLike.TabIndex = 1;
            this.numUsersToLike.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max users to like";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seconds between likes";
            // 
            // numSecondsBetweenLikes
            // 
            this.numSecondsBetweenLikes.Location = new System.Drawing.Point(144, 38);
            this.numSecondsBetweenLikes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSecondsBetweenLikes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSecondsBetweenLikes.Name = "numSecondsBetweenLikes";
            this.numSecondsBetweenLikes.Size = new System.Drawing.Size(64, 20);
            this.numSecondsBetweenLikes.TabIndex = 3;
            this.numSecondsBetweenLikes.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(14, 172);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(63, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status: N/A";
            // 
            // checkAutomation
            // 
            this.checkAutomation.AutoSize = true;
            this.checkAutomation.Location = new System.Drawing.Point(14, 71);
            this.checkAutomation.Name = "checkAutomation";
            this.checkAutomation.Size = new System.Drawing.Size(115, 17);
            this.checkAutomation.TabIndex = 21;
            this.checkAutomation.Text = "Enable Automation";
            this.checkAutomation.UseVisualStyleBackColor = true;
            this.checkAutomation.CheckedChanged += new System.EventHandler(this.checkAutomation_CheckedChanged);
            // 
            // groupAutomation
            // 
            this.groupAutomation.Controls.Add(this.label7);
            this.groupAutomation.Controls.Add(this.linkLabel1);
            this.groupAutomation.Controls.Add(this.numRestartDelay);
            this.groupAutomation.Controls.Add(this.label6);
            this.groupAutomation.Enabled = false;
            this.groupAutomation.Location = new System.Drawing.Point(14, 88);
            this.groupAutomation.Name = "groupAutomation";
            this.groupAutomation.Size = new System.Drawing.Size(194, 46);
            this.groupAutomation.TabIndex = 20;
            this.groupAutomation.TabStop = false;
            this.groupAutomation.Text = "Automation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "minutes";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(76, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(13, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // numRestartDelay
            // 
            this.numRestartDelay.Location = new System.Drawing.Point(96, 16);
            this.numRestartDelay.Name = "numRestartDelay";
            this.numRestartDelay.Size = new System.Drawing.Size(40, 20);
            this.numRestartDelay.TabIndex = 18;
            this.numRestartDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Restart Delay";
            // 
            // GoldLiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(220, 194);
            this.Controls.Add(this.checkAutomation);
            this.Controls.Add(this.groupAutomation);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSecondsBetweenLikes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUsersToLike);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoldLiker";
            this.Text = "Gold Liker";
            ((System.ComponentModel.ISupportInitialize)(this.numUsersToLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondsBetweenLikes)).EndInit();
            this.groupAutomation.ResumeLayout(false);
            this.groupAutomation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numUsersToLike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSecondsBetweenLikes;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkAutomation;
        private System.Windows.Forms.GroupBox groupAutomation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown numRestartDelay;
        private System.Windows.Forms.Label label6;
    }
}