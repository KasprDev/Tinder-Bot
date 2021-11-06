namespace TinderClient
{
    partial class MessageMatches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageMatches));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.checkNewMatches = new System.Windows.Forms.CheckBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.minWaitSeconds = new System.Windows.Forms.NumericUpDown();
            this.maxWaitSeconds = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkContactCard = new System.Windows.Forms.CheckBox();
            this.contactSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.minWaitSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWaitSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message List (Supports Spintax)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Message Your Matches";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: N/A";
            // 
            // checkNewMatches
            // 
            this.checkNewMatches.AutoSize = true;
            this.checkNewMatches.Location = new System.Drawing.Point(15, 12);
            this.checkNewMatches.Name = "checkNewMatches";
            this.checkNewMatches.Size = new System.Drawing.Size(250, 17);
            this.checkNewMatches.TabIndex = 4;
            this.checkNewMatches.Text = "Don\'t DM people you already contacted before.";
            this.checkNewMatches.UseVisualStyleBackColor = true;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(13, 56);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(226, 20);
            this.txtDirectory.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // minWaitSeconds
            // 
            this.minWaitSeconds.Location = new System.Drawing.Point(13, 103);
            this.minWaitSeconds.Name = "minWaitSeconds";
            this.minWaitSeconds.Size = new System.Drawing.Size(52, 20);
            this.minWaitSeconds.TabIndex = 7;
            this.minWaitSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxWaitSeconds
            // 
            this.maxWaitSeconds.Location = new System.Drawing.Point(81, 103);
            this.maxWaitSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.maxWaitSeconds.Name = "maxWaitSeconds";
            this.maxWaitSeconds.Size = new System.Drawing.Size(53, 20);
            this.maxWaitSeconds.TabIndex = 8;
            this.maxWaitSeconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seconds to wait between messages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "-";
            // 
            // checkContactCard
            // 
            this.checkContactCard.AutoSize = true;
            this.checkContactCard.Location = new System.Drawing.Point(12, 131);
            this.checkContactCard.Name = "checkContactCard";
            this.checkContactCard.Size = new System.Drawing.Size(116, 17);
            this.checkContactCard.TabIndex = 12;
            this.checkContactCard.Text = "Send Contact Card";
            this.checkContactCard.UseVisualStyleBackColor = true;
            this.checkContactCard.CheckedChanged += new System.EventHandler(this.checkContactCard_CheckedChanged);
            // 
            // contactSelector
            // 
            this.contactSelector.Enabled = false;
            this.contactSelector.FormattingEnabled = true;
            this.contactSelector.Items.AddRange(new object[] {
            "Snapchat",
            "Instagram",
            "Facebook",
            "KakaoTalk",
            "Line",
            "Kik",
            "WeChat",
            "VK",
            "WhatsApp"});
            this.contactSelector.Location = new System.Drawing.Point(12, 152);
            this.contactSelector.Name = "contactSelector";
            this.contactSelector.Size = new System.Drawing.Size(155, 21);
            this.contactSelector.TabIndex = 13;
            // 
            // MessageMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 244);
            this.Controls.Add(this.contactSelector);
            this.Controls.Add(this.checkContactCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxWaitSeconds);
            this.Controls.Add(this.minWaitSeconds);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.checkNewMatches);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageMatches";
            this.Text = "Match Messenger";
            this.Load += new System.EventHandler(this.MessageMatches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minWaitSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWaitSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox checkNewMatches;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown minWaitSeconds;
        private System.Windows.Forms.NumericUpDown maxWaitSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkContactCard;
        private System.Windows.Forms.ComboBox contactSelector;
    }
}