using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaterChain
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main dform = new Main();
            dform.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
