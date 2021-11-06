using KasprBot.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasprBot
{
    class KasprDev
    {
        public static string Identifier = "tinder-bot";
        public static double Version = 1.00;

        public static bool IsLatestVersion()
        {
            using (WebClient c = new WebClient())
            {
                ProductInfo product = JsonConvert.DeserializeObject<ProductInfo>(c.DownloadString("https://peachysnap.com/product/" + Identifier + "/version"));

                if (product.Version == Version)
                    return true;
                else
                    return false;
            }
        }

        public static void ShowErrorDialog(string code)
        {
            DialogResult dialogResult = MessageBox.Show("Code: " + code + ". Would you like to view more information on this code?", "KasprDev", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("https://peachysnap.com/help/" + Identifier + "/" + code);
            }
        }

        public static void DownloadLatest()
        {

        }
    }
}
