using SharpTinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinderClient.Tinder;

namespace TinderClient
{
    public partial class MessageMatches : Form
    {
        public IList<Match> Matches { get; set; }
        public string MatchList { get; set; }
        public MessageMatches()
        {
            MatchList = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            MatchList = Path.Combine(MatchList, "TinderMatchIDs.txt");

            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(MatchList))
                File.WriteAllText(MatchList, null);

            string[] matchIds = File.ReadAllLines(MatchList);

            if (string.IsNullOrEmpty(txtDirectory.Text))
            {
                return;
            }

            button1.Enabled = false;

            foreach (Match userMatch in Matches)
            {
                //if (matchIds.Contains(userMatch.MatchId))
                //    continue;
                //else
                //    File.AppendAllText(MatchList, userMatch.MatchId + Environment.NewLine);

                string[] replies = File.ReadAllLines(txtDirectory.Text);
                string message = replies[new Random().Next(0, replies.Length - 1)];

                if (checkNewMatches.Checked)
                {
                    if (!userMatch.MatchSeen.Seen)
                    {
                        lblStatus.Text = "Status: Messaging " + userMatch.Person.Name;

                        if (checkContactCard.Checked)
                        {
                            await Instances.API.SendContactCard(contactSelector.Text.ToLower(), "s", userMatch.MatchId);
                        }
                        else
                        {
                            await Instances.API.SendMessage(userMatch.MatchId, MessageHelpers.ParseSpintax(new Random(), message));
                        }
                    }
                }
                else
                {
                    lblStatus.Text = "Status: Messaging " + userMatch.Person.Name;

                    if (checkContactCard.Checked)
                    {
                        await Instances.API.SendContactCard(contactSelector.Text.ToLower(), "s", userMatch.MatchId);
                    }
                    else
                    {
                        await Instances.API.SendMessage(userMatch.MatchId, MessageHelpers.ParseSpintax(new Random(), message));
                    }
                }

                await Task.Delay(new Random().Next(Convert.ToInt32(minWaitSeconds.Value) * 1000, Convert.ToInt32(maxWaitSeconds.Value) * 1000));
            }

            MessageBox.Show("All messages successfully sent!");

            button1.Enabled = true;
        }

        private async void MessageMatches_Load(object sender, EventArgs e)
        {
            var matches = await Instances.API.GetMatches();
            Matches = matches.Data.Matches;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();

            if (f.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = f.FileName;
            }
        }

        private void checkContactCard_CheckedChanged(object sender, EventArgs e)
        {
            contactSelector.Enabled = checkContactCard.Checked;
        }
    }
}
