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
    public partial class Catering : Form
    {
        public Catering()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Booking sform = new Booking();
            sform.Show();
            this.Hide();
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            Birthday sform = new Birthday();
            sform.Show();
            this.Hide();
        }

        private void btnWedding_Click(object sender, EventArgs e)
        {
            Wedding sform = new Wedding();
            sform.Show();
            this.Hide();
        }

        private void btnReunion_Click(object sender, EventArgs e)
        {
            Reunion sform = new Reunion();
            sform.Show();
            this.Hide();
        }

        private void btnFundraising_Click(object sender, EventArgs e)
        {
            Fundraising sform = new Fundraising();
            sform.Show();
            this.Hide();
        }
    }
}
