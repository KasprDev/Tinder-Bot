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
    public partial class ContactCards : Form
    {
        public ContactCards()
        {
            InitializeComponent();
        }

        private void ContactCards_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Instances.API.SetContactCard(comboTypes.Text.ToLower(), txtUsername.Text);
            MessageBox.Show("Contact card saved successfully!");
            this.Close();
        }
    }
}
