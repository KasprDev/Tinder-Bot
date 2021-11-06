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
    public partial class LocationChanger : Form
    {
        public LocationChanger()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Instances.API.ChangeLocation(textBox1.Text, textBox2.Text);
            this.Close();
        }
    }
}
