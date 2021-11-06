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
    public partial class GoldLiker : Form
    {
        public GoldLiker()
        {
            InitializeComponent();
        }
        public CancellationTokenSource CancelTokenSource { get; set; }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                button1.Text = "Stop";

                CancelTokenSource = new CancellationTokenSource();

                if (checkAutomation.Checked)
                {
                    while (true)
                    {
                        if (CancelTokenSource.IsCancellationRequested)
                            break;

                        var recommendations = await Instances.API.GetUsersWhoLikedYou(Convert.ToInt32(numUsersToLike.Value));

                        int count = 0;
                        foreach (var user in recommendations.Data.Results)
                        {
                            if (CancelTokenSource.IsCancellationRequested)
                                break;

                            if (count >= numUsersToLike.Value)
                            {
                                labelStatus.Text = $"Checking in {numRestartDelay.Value} minute(s) again.";
                                await Task.Delay(TimeSpan.FromMinutes(Convert.ToInt32(numRestartDelay.Value)));
                                count = 0;
                            }

                            labelStatus.Text = $"Status: Liking {user.User.Name}!";
                            await Instances.API.LikeFastMatchUser(user.SNumber, user.User.Id);
                            await Task.Delay(TimeSpan.FromMinutes(Convert.ToInt32(numRestartDelay.Value)));

                            count++;
                        }

                        labelStatus.Text = $"Checking in {numRestartDelay.Value} minute(s) again.";
                        await Task.Delay(TimeSpan.FromMinutes(Convert.ToInt32(numRestartDelay.Value)));
                    }
                }
                else
                {
                    var recommendations = await Instances.API.GetUsersWhoLikedYou(Convert.ToInt32(numUsersToLike.Value));

                    int count = 0;
                    foreach (var user in recommendations.Data.Results)
                    {
                        if (CancelTokenSource.IsCancellationRequested)
                            break;

                        if (count >= numUsersToLike.Value)
                            return;

                        labelStatus.Text = $"Status: Liking {user.User.Name}!";
                        await Instances.API.LikeFastMatchUser(user.SNumber, user.User.Id);
                        await Task.Delay(Convert.ToInt32(numSecondsBetweenLikes.Value) * 1000);

                        count++;
                    }

                    CancelTokenSource.Cancel();
                }
            }
            else if (button1.Text == "Stop")
            {
                CancelTokenSource.Cancel();
                button1.Text = "Start";
            }

            labelStatus.Text = $"Status: Complete!";
        }

        private void checkAutomation_CheckedChanged(object sender, EventArgs e)
        {
            groupAutomation.Enabled = checkAutomation.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The amount of minutes to wait before restarting the auto liker.");
        }
    }
}
