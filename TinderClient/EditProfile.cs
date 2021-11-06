using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinderClient
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            var bioResp = await Instances.API.EditBio(txtBio.Text);

            Instances.ClientForm.lblBio.Text = txtBio.Text;

            MessageBox.Show("Profile sucessfully saved!");
            button1.Enabled = true;
        }

        private async void EditProfile_Load(object sender, EventArgs e)
        {
            var user = await Instances.API.GetCurrentUser();

            txtBio.Text = user.Bio;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            await Instances.API.EditSpotify(textBox1.Text);
            MessageBox.Show("Spotify anthem updated!");
            button2.Enabled = true;
        }
    }
}
