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
    public partial class SearchSettings : Form
    {
        public SearchSettings()
        {
            InitializeComponent();
        }


    private async void SearchSettings_Load(object sender, EventArgs e)
        {
            var user = await Instances.API.GetCurrentUser();

            if (user.AgeFilterMax > 54)
            {
                ageMax.Value = 55;
            } else {
                ageMax.Value = user.AgeFilterMax;
            }

            ageMin.Value = user.AgeFilterMin;
            distanceFilter.Value = user.DistanceFilter;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int ageMaxInt = Convert.ToInt32(ageMax.Value);
            if (ageMaxInt > 54)
            {
                ageMaxInt = 1000;
            }

            await Instances.API.SaveSettings(new {
                age_filter_min = ageMin.Value,
                age_filter_max = ageMaxInt,
                distance_filter = distanceFilter.Value
            });

            MessageBox.Show("Settings successfully saved!");
            this.Close();
        }
    }
}
