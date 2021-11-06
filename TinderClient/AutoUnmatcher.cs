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
using TinderClient.Tinder;

namespace TinderClient
{
    public partial class AutoUnmatcher : Form
    {
        public static TinderMatches Matches { get; set; }
        public AutoUnmatcher()
        {
            InitializeComponent();
        }

        private async void AutoUnmatcher_Load(object sender, EventArgs e)
        {
            Matches = await Instances.API.GetMatches();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

                foreach (Match m in Matches.Data.Matches)
                {
                    // Remove inactive accounts
                    if (radioButton1.Checked)
                    {
                        if (m.Dead)
                        {
                            await Instances.API.Unmatch(m.MatchId);
                            lblStatus.Text = "Status: Bye, " + m.Person.Name + "!";
                        }
                    }
                    // Remove all accounts
                    else if (radioButton2.Checked)
                    {
                        await Instances.API.Unmatch(m.MatchId);
                        lblStatus.Text = "Status: Bye, " + m.Person.Name + "!";
                    }

                    Task.Delay(5000).Wait();
                }

            button1.Enabled = true;

            MessageBox.Show("The specified users have been unfollowed!");
        }
    }
}
