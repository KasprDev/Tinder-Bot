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

namespace TinderClient
{
    public partial class Blacklist : Form
    {
        public Blacklist()
        {
            InitializeComponent();
        }

        private void Blacklist_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "tinder-blacklist.txt");
            if (File.Exists(path))
            {
                listBox1.Items.AddRange(File.ReadAllLines(path));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "tinder-blacklist.txt");

            File.AppendAllText(path, textBox1.Text + Environment.NewLine);
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "tinder-blacklist.txt");

            File.WriteAllText(path, "");

            listBox1.Items.Clear();
        }
    }
}
