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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            Instances.ClientForm = this;
        }

        private void autoLikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoLike l = new AutoLike();
            l.Show();
        }

        private async void Client_Load(object sender, EventArgs e)
        {
            try
            {
                if (Instances.API.LocationOnLogin)
                {
                    await Instances.API.ChangeLocation(Instances.API.Lat, Instances.API.Lon);
                }

                var user = await Instances.API.GetCurrentUser();

                lblName.Text = user.Name;
                lblBio.Text = user.Bio;
                pictureBox1.Load(user.Photos.FirstOrDefault().Url);
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Unable to authorize your Tinder session. Please make sure your auth token is valid and try again.", "TinderBot", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void messageMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageMatches m = new MessageMatches();
            m.Show();
        }

        private void changeLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocationChanger c = new LocationChanger();
            c.ShowDialog();
        }

        private void searchPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSettings s = new SearchSettings();
            s.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProfile p = new EditProfile();
            p.Show();
        }

        private void autoUnmatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoUnmatcher m = new AutoUnmatcher();
            m.Show();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void reportFakeAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAccounts c = new ReportAccounts();
            c.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blacklist b = new Blacklist();
            b.Show();
        }

        private void goldAutoLikerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoldLiker g = new GoldLiker();
            g.Show();
        }

        private void contactCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactCards c = new ContactCards();
            c.Show();
        }
    }
}
