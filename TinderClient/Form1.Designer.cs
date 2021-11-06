namespace TinderClient
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.checkUseProxy = new System.Windows.Forms.CheckBox();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.platformCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkSetLocation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-Auth Token:";
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorize.Location = new System.Drawing.Point(16, 260);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.Size = new System.Drawing.Size(189, 35);
            this.btnAuthorize.TabIndex = 2;
            this.btnAuthorize.Text = "Authorize";
            this.btnAuthorize.UseVisualStyleBackColor = true;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccessToken.Location = new System.Drawing.Point(16, 32);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(187, 25);
            this.txtAccessToken.TabIndex = 3;
            // 
            // checkUseProxy
            // 
            this.checkUseProxy.AutoSize = true;
            this.checkUseProxy.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUseProxy.Location = new System.Drawing.Point(16, 120);
            this.checkUseProxy.Name = "checkUseProxy";
            this.checkUseProxy.Size = new System.Drawing.Size(105, 23);
            this.checkUseProxy.TabIndex = 4;
            this.checkUseProxy.Text = "HTTP Proxy?";
            this.checkUseProxy.UseVisualStyleBackColor = true;
            this.checkUseProxy.CheckedChanged += new System.EventHandler(this.checkUseProxy_CheckedChanged);
            // 
            // txtProxy
            // 
            this.txtProxy.Enabled = false;
            this.txtProxy.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxy.Location = new System.Drawing.Point(16, 144);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(124, 25);
            this.txtProxy.TabIndex = 5;
            this.txtProxy.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // platformCombo
            // 
            this.platformCombo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformCombo.FormattingEnabled = true;
            this.platformCombo.Items.AddRange(new object[] {
            "web",
            "ios",
            "android"});
            this.platformCombo.Location = new System.Drawing.Point(16, 86);
            this.platformCombo.Name = "platformCombo";
            this.platformCombo.Size = new System.Drawing.Size(187, 27);
            this.platformCombo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Platform:";
            // 
            // txtPort
            // 
            this.txtPort.AccessibleName = "";
            this.txtPort.Enabled = false;
            this.txtPort.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(155, 144);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(48, 25);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "8080";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stay up to date! Join our";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(144, 303);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Discord";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // txtLon
            // 
            this.txtLon.Enabled = false;
            this.txtLon.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLon.Location = new System.Drawing.Point(119, 229);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(86, 25);
            this.txtLon.TabIndex = 16;
            // 
            // txtLat
            // 
            this.txtLat.Enabled = false;
            this.txtLat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.Location = new System.Drawing.Point(16, 229);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(86, 25);
            this.txtLat.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lat:";
            // 
            // checkSetLocation
            // 
            this.checkSetLocation.AutoSize = true;
            this.checkSetLocation.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSetLocation.Location = new System.Drawing.Point(16, 185);
            this.checkSetLocation.Name = "checkSetLocation";
            this.checkSetLocation.Size = new System.Drawing.Size(166, 23);
            this.checkSetLocation.TabIndex = 17;
            this.checkSetLocation.Text = "Set Location On Login";
            this.checkSetLocation.UseVisualStyleBackColor = true;
            this.checkSetLocation.CheckedChanged += new System.EventHandler(this.checkSetLocation_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 325);
            this.Controls.Add(this.checkSetLocation);
            this.Controls.Add(this.txtLon);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.platformCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtProxy);
            this.Controls.Add(this.checkUseProxy);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.btnAuthorize);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login to Tinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAuthorize;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.CheckBox checkUseProxy;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox platformCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkSetLocation;
    }
}

