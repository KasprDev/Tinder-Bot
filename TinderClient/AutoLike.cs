using SharpTinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinderClient
{
    public partial class AutoLike : Form
    {
        public int Liked = 0;
        public AutoLike()
        {
            InitializeComponent();
            milesLimit.Maximum = 100;
            milesLimit.Minimum = 1;
        }

        public CancellationTokenSource CancelTokenSource { get; set; }

        private void AutoLike_Load(object sender, EventArgs e)
        {

        }

        public async Task LikeUsersAsync(IList<TinderRecommendedUser> recommendations, int chance, CancellationToken token)
        {
            foreach (TinderRecommendedUser result in recommendations)
            {
                if (token.IsCancellationRequested)
                    break;

                if (checkAutomation.Checked)
                {
                    if (numMaxLikes.Value <= Liked)
                    {
                        lblLiked.Text = $"Taking a break! Restarting in {numRestartDelay.Value} minute(s).";
                        await Task.Delay(TimeSpan.FromMinutes(Convert.ToInt32(numRestartDelay.Value)));
                        Liked = 0;
                    }
                }

                try
                {

                    int age = DateTime.UtcNow.Year - result.User.BirthDate.Year;

                    personPhoto.Load(result.User.Photos.FirstOrDefault().Url);
                    lblPersonName.Text = result.User.Name + " (" + age.ToString() + ")";
                    lblPersonDistance.Text = result.Distance.ToString() + " miles away";

                    if (milesCheck.Checked)
                    {
                        if (result.User.DistanceMi <= Convert.ToInt32(milesLimit.Value))
                        {
                            var r = new Random();
                            
                            if (r.Next(0, 100) >= chance)
                            {
                                await Instances.API.LikeUser(result.User.Id);
                                Liked++;
                                lblLiked.Text = "Liked " + Liked.ToString() + " users.";
                            }
                        }
                    }
                    else
                    {
                        var r = new Random();

                        if (r.Next(0, 100) >= chance)
                        {
                            await Instances.API.LikeUser(result.User.Id);
                            Liked++;
                            lblLiked.Text = "Liked " + Liked.ToString() + " users.";
                        }
                    }

                    int wait = new Random().Next(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    await Task.Delay(wait * 1000);
                }
                catch (Exception)
                {

                }
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                Liked = 0;
                button1.Text = "Stop";
                CancelTokenSource = new CancellationTokenSource();

                while (true)
                {
                    if (CancelTokenSource.IsCancellationRequested)
                        break;

                    var recommendations = await Instances.API.GetRecommendations();

                    if (recommendations.Data.Results != null)
                    {
                        await LikeUsersAsync(recommendations.Data.Results, Convert.ToInt32(SwipeChance.Value), CancelTokenSource.Token);
                    }
                    else
                        if (recommendations.Message == "recs timeout")
                        MessageBox.Show("You've ran out of swipes for the day.");
                }

                button1.Text = "Start";

                MessageBox.Show("Successfully 'liked' " + Liked.ToString() + " users!");
            }
            else
            {
                CancelTokenSource.Cancel();
                button1.Text = "Start";
            }
        }

        private void checkMessage_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void milesCheck_CheckedChanged(object sender, EventArgs e)
        {
            milesLimit.Enabled = milesCheck.Enabled;
        }

        private void AutoLike_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CancelTokenSource != null)
                CancelTokenSource.Cancel();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If the user that the bot is currently swiping on has a username (Snapchat, Instagram, etc.) in their bio, we will attempt to extract it for you.");
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The amount of minutes to wait before restarting the auto liker.");
        }

        private void checkAutomation_CheckedChanged(object sender, EventArgs e)
        {
            groupAutomation.Enabled = checkAutomation.Checked;
        }

        private void numRestartDelay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
