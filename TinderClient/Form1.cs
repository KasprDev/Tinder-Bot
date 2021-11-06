using SharpTinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinderClient.Tinder;

namespace TinderClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            platformCombo.Text = "web";
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            Instances.API = new API();
            Instances.API.AuthToken = txtAccessToken.Text;

            if (checkUseProxy.Checked)
            {
                Instances.API.Platform = platformCombo.Text;
                Instances.API.UseProxy = true;
                Instances.API.ProxyIP = txtProxy.Text;
                Instances.API.ProxyPort = Convert.ToInt32(txtPort.Text);
            }

            if (checkSetLocation.Checked)
            {
                Instances.API.LocationOnLogin = true;
                Instances.API.Lon = txtLon.Text;
                Instances.API.Lat = txtLat.Text;
            }

            Client c = new Client();
            c.Show();

            this.Hide();
            this.ShowInTaskbar = false;
            this.Size = new Size(0, 0);
        }

        private void checkUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            txtProxy.Enabled = checkUseProxy.Checked;
            txtPort.Enabled = checkUseProxy.Checked;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/SJTbpg9");
        }

        private void checkSetLocation_CheckedChanged(object sender, EventArgs e)
        {
            txtLat.Enabled = checkSetLocation.Checked;
            txtLon.Enabled = checkSetLocation.Checked;
        }
    }
}
