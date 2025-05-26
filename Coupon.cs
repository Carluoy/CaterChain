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
    public partial class Coupon : Form
    {


        bool couponGenerated = false;
        Random random = new Random();
        // At the top of the class
        private int randomDiscount;
        private bool isProgrammaticallyUpdating = false;


        Dictionary<string, decimal> packagePrices = new Dictionary<string, decimal>
{
    { "Basic Package", 2000m },
    { "Standard Package", 3500m },
    { "Premium Package", 5000m },
    { "Deluxe Package", 7000m }
};

        public Coupon()
        {
            InitializeComponent();
        }

        private void Coupon_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var kvp in packagePrices)
            {
                comboBox1.Items.Add($"{kvp.Key} - ₱{kvp.Value:0.00}");
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (couponGenerated)
            {
                MessageBox.Show("You can only generate a coupon once!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int[] discountOptions = { 10, 15, 18 };
            randomDiscount = discountOptions[random.Next(discountOptions.Length)];

            isProgrammaticallyUpdating = true;
            txtDiscount.Text = randomDiscount.ToString();
            txtCouponCode.Text = GenerateRandomCouponCode();
            txtSave.Text = $"SAVE{randomDiscount}";
            isProgrammaticallyUpdating = false;

            couponGenerated = true;

        }

        private string GenerateRandomCouponCode(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void txtSave_TextChanged(object sender, EventArgs e)
        {
            if (isProgrammaticallyUpdating) return;

            txtSave.Text = $"SAVE{randomDiscount}";

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text) ||
       string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                MessageBox.Show("Please make sure both the package price and discount are provided.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal originalPrice))
            {
                MessageBox.Show("Invalid package price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtDiscount.Text, out decimal discountPercentage))
            {
                MessageBox.Show("Invalid discount value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal discountAmount = originalPrice * (discountPercentage / 100);
            decimal discountedPrice = originalPrice - discountAmount;

            txtDiscounted.Text = discountedPrice.ToString("0.00");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is not string selectedItemText)
                return;

            string selectedPackage = selectedItemText.Split('-')[0].Trim();

            if (packagePrices.TryGetValue(selectedPackage, out decimal price))
            {
                txtPrice.Text = price.ToString("0.00");
            }
            else
            {
                txtPrice.Text = "0.00";
            }

            // Clear previous discounts when switching package
            txtDiscounted.Text = "";
            txtDiscount.Text = "";
            txtSave.Text = "";
            txtCouponCode.Text = "";
            couponGenerated = false;
        }
    }
}
