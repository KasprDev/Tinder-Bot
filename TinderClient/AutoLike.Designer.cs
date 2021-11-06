namespace TinderClient
{
    partial class AutoLike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoLike));
            this.milesCheck = new System.Windows.Forms.CheckBox();
            this.milesLimit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fakeCheck = new System.Windows.Forms.CheckBox();
            this.personPhoto = new System.Windows.Forms.PictureBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblPersonDistance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLiked = new System.Windows.Forms.Label();
            this.SwipeChance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxLikes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupAutomation = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.numRestartDelay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkAutomation = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.milesLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLikes)).BeginInit();
            this.groupAutomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // milesCheck
            // 
            this.milesCheck.AutoSize = true;
            this.milesCheck.Location = new System.Drawing.Point(14, 85);
            this.milesCheck.Name = "milesCheck";
            this.milesCheck.Size = new System.Drawing.Size(136, 17);
            this.milesCheck.TabIndex = 0;
            this.milesCheck.Text = "Maximum Swipe radius:";
            this.milesCheck.UseVisualStyleBackColor = true;
            this.milesCheck.CheckedChanged += new System.EventHandler(this.milesCheck_CheckedChanged);
            // 
            // milesLimit
            // 
            this.milesLimit.Enabled = false;
            this.milesLimit.Location = new System.Drawing.Point(146, 84);
            this.milesLimit.Name = "milesLimit";
            this.milesLimit.Size = new System.Drawing.Size(49, 20);
            this.milesLimit.TabIndex = 1;
            this.milesLimit.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "miles from me.";
            // 
            // fakeCheck
            // 
            this.fakeCheck.AutoSize = true;
            this.fakeCheck.Location = new System.Drawing.Point(14, 107);
            this.fakeCheck.Name = "fakeCheck";
            this.fakeCheck.Size = new System.Drawing.Size(152, 17);
            this.fakeCheck.TabIndex = 3;
            this.fakeCheck.Text = "Ignore Other Bot Accounts";
            this.fakeCheck.UseVisualStyleBackColor = true;
            // 
            // personPhoto
            // 
            this.personPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personPhoto.Location = new System.Drawing.Point(12, 10);
            this.personPhoto.Name = "personPhoto";
            this.personPhoto.Size = new System.Drawing.Size(70, 69);
            this.personPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personPhoto.TabIndex = 5;
            this.personPhoto.TabStop = false;
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.Location = new System.Drawing.Point(88, 10);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(36, 19);
            this.lblPersonName.TabIndex = 6;
            this.lblPersonName.Text = "N/A";
            // 
            // lblPersonDistance
            // 
            this.lblPersonDistance.AutoSize = true;
            this.lblPersonDistance.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonDistance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPersonDistance.Location = new System.Drawing.Point(90, 27);
            this.lblPersonDistance.Name = "lblPersonDistance";
            this.lblPersonDistance.Size = new System.Drawing.Size(74, 16);
            this.lblPersonDistance.TabIndex = 7;
            this.lblPersonDistance.Text = "0 miles away";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLiked
            // 
            this.lblLiked.AutoSize = true;
            this.lblLiked.Location = new System.Drawing.Point(11, 279);
            this.lblLiked.Name = "lblLiked";
            this.lblLiked.Size = new System.Drawing.Size(73, 13);
            this.lblLiked.TabIndex = 10;
            this.lblLiked.Text = "Liked 0 users.";
            // 
            // SwipeChance
            // 
            this.SwipeChance.Location = new System.Drawing.Point(14, 130);
            this.SwipeChance.Name = "SwipeChance";
            this.SwipeChance.Size = new System.Drawing.Size(40, 20);
            this.SwipeChance.TabIndex = 11;
            this.SwipeChance.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "% chance to Swipe left";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "s  delay between likes.";
            // 
            // numMaxLikes
            // 
            this.numMaxLikes.Location = new System.Drawing.Point(94, 16);
            this.numMaxLikes.Name = "numMaxLikes";
            this.numMaxLikes.Size = new System.Drawing.Size(40, 20);
            this.numMaxLikes.TabIndex = 16;
            this.numMaxLikes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Max users to like";
            // 
            // groupAutomation
            // 
            this.groupAutomation.Controls.Add(this.label7);
            this.groupAutomation.Controls.Add(this.linkLabel1);
            this.groupAutomation.Controls.Add(this.numRestartDelay);
            this.groupAutomation.Controls.Add(this.label6);
            this.groupAutomation.Controls.Add(this.numMaxLikes);
            this.groupAutomation.Controls.Add(this.label5);
            this.groupAutomation.Enabled = false;
            this.groupAutomation.Location = new System.Drawing.Point(14, 176);
            this.groupAutomation.Name = "groupAutomation";
            this.groupAutomation.Size = new System.Drawing.Size(248, 67);
            this.groupAutomation.TabIndex = 18;
            this.groupAutomation.TabStop = false;
            this.groupAutomation.Text = "Automation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "minutes";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(74, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(13, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // numRestartDelay
            // 
            this.numRestartDelay.Location = new System.Drawing.Point(94, 42);
            this.numRestartDelay.Name = "numRestartDelay";
            this.numRestartDelay.Size = new System.Drawing.Size(40, 20);
            this.numRestartDelay.TabIndex = 18;
            this.numRestartDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numRestartDelay.ValueChanged += new System.EventHandler(this.numRestartDelay_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Restart Delay";
            // 
            // checkAutomation
            // 
            this.checkAutomation.AutoSize = true;
            this.checkAutomation.Location = new System.Drawing.Point(15, 157);
            this.checkAutomation.Name = "checkAutomation";
            this.checkAutomation.Size = new System.Drawing.Size(115, 17);
            this.checkAutomation.TabIndex = 19;
            this.checkAutomation.Text = "Enable Automation";
            this.checkAutomation.UseVisualStyleBackColor = true;
            this.checkAutomation.CheckedChanged += new System.EventHandler(this.checkAutomation_CheckedChanged);
            // 
            // AutoLike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 300);
            this.Controls.Add(this.checkAutomation);
            this.Controls.Add(this.groupAutomation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SwipeChance);
            this.Controls.Add(this.lblLiked);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPersonDistance);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.personPhoto);
            this.Controls.Add(this.fakeCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.milesLimit);
            this.Controls.Add(this.milesCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoLike";
            this.Text = "Auto Liker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoLike_FormClosing);
            this.Load += new System.EventHandler(this.AutoLike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.milesLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLikes)).EndInit();
            this.groupAutomation.ResumeLayout(false);
            this.groupAutomation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox milesCheck;
        private System.Windows.Forms.NumericUpDown milesLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fakeCheck;
        private System.Windows.Forms.PictureBox personPhoto;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblPersonDistance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLiked;
        private System.Windows.Forms.NumericUpDown SwipeChance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxLikes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupAutomation;
        private System.Windows.Forms.CheckBox checkAutomation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown numRestartDelay;
        private System.Windows.Forms.Label label6;
    }
}