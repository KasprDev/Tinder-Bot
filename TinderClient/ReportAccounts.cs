using SharpTinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinderClient
{
    public partial class ReportAccounts : Form
    {
        public static int SearchedAccounts = 0;
        public static int ReportedAccounts = 0;

        public ReportAccounts()
        {
            InitializeComponent();
        }

        private void ReportAccounts_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            await Task.Factory.StartNew(async () => { 
                while (true)
                {
                    var recommendations = await Instances.API.GetRecommendations();

                    foreach (TinderRecommendedUser result in recommendations.Data.Results)
                    {
                        if (result.User.Bio.Contains("lonely babe") || result.User.Bio.Contains("lovely babe") || result.User.Bio.Contains("care to chat"))
                        {
                            ReportedAccounts++;

                            await Instances.API.ReportUser(result.User.Id);

                            if (label2.InvokeRequired)
                                label2.Invoke(new Action(() => label1.Text = "Reported Users: " + ReportedAccounts.ToString()));
                            else
                                label2.Text += "Reported Users: " + ReportedAccounts.ToString();
                        }

                        SearchedAccounts++;

                        if (label1.InvokeRequired)
                            label1.Invoke(new Action(() => label1.Text = "Searched Users: " + SearchedAccounts.ToString()));
                        else
                            label1.Text += "Searched Users: " + SearchedAccounts.ToString();

                        await Task.Delay(15000);
                    }
                }
            });
        }
    }
}
