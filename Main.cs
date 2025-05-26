using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaterChain
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //   lblWelcome.Text = $"Welcome to CaterChain, {_firstName}!";

            toolTip1.SetToolTip(btnReport, "Something went wrong?");
            //toolTip1.SetToolTip(menustripSetting, "Settings");
            // toolTip1.SetToolTip(btnExit, "Exit");
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            About dform = new About();
            dform.Show();
            this.Hide();
        }

        private void Fb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit our Facebook Page: https/CaterChain/facebook.com");
        }

        private void Ig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit our Instagram Page: https/CaterChain/instagram.com");
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   NTAccount sform = new Account();
            //   sform.Show();
            //   this.Hide();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Booking dform = new Booking();
            dform.Show();

        }

        private void btnVenue_Click(object sender, EventArgs e)
        {
            //Venue
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Feedback dform = new Feedback();
            dform.Show();

        }
    }
}
