using DeviceId;
using KasprBot;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinderClient
{
    public partial class Authenticate : Form
    {
        public Authenticate()
        {
            InitializeComponent();
        }

        private async void btnValidate_Click(object sender, EventArgs e)
        {
            btnValidate.Enabled = false;
            btnValidate.Text = "Validating..";

            if (await ValidateLicense(txtEmail.Text, txtPassword.Text))
            {
                Form1 f = new Form1();
                f.Show();

                this.Hide();
                this.ShowInTaskbar = false;
                this.Size = new Size(0, 0);
            }
            else
            {
                btnValidate.Enabled = true;
                btnValidate.Text = "Login";
            }
        }
        public static HttpClient client = new HttpClient();
        public async Task<bool> ValidateLicense(string username, string password)
        {
            try
            {
                var hardwareID = new DeviceIdBuilder()
                       .AddMachineName()
                       .AddMacAddress()
                       .AddProcessorId()
                       .AddMotherboardSerialNumber()
                       .ToString();

                var values = new Dictionary<string, string>
            {
                { "Username", username },
                { "Password", password },
                { "HWID", hardwareID },
                { "Product", "09448d8c" }
            };

                var response = await client.PostAsync("https://peachysnap.com/auth", new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json"));
                var responseString = await response.Content.ReadAsStringAsync();

                AuthDto authResponse = JsonConvert.DeserializeObject<AuthDto>(responseString);

                if (authResponse.Status == "Fail")
                {
                    MessageBox.Show(authResponse.Message, "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (authResponse.Status == "Success")
                {
                    File.WriteAllText("auth.txt", username + ":" + password);
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Unable to access our authorization server. Please try again later.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private async void Authenticate_Load(object sender, EventArgs e)
        {
            if (File.Exists("auth.txt"))
            {
                string username = File.ReadAllText("auth.txt").Split(':')[0];
                string password = File.ReadAllText("auth.txt").Split(':')[1];

                if (await ValidateLicense(username, password))
                {
                    Form1 f = new Form1();
                    f.Show();

                    this.Hide();
                    this.ShowInTaskbar = false;
                    this.Size = new Size(0, 0);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hackforums.net/showthread.php?tid=6091882");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            MessageBox.Show("Please check your spam and promotions folder in your email. Gmail has been putting Sendgrid emails in the 'Promotions' folder on some email providers.", "Please Beware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Enabled = true;
        }
    }
}
