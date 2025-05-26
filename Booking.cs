using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CaterChain
{
    public partial class Booking : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=accounts");


        //for coupon

        bool couponGenerated = false;
        Random random = new Random();
        // At the top of the class
        private int randomDiscount;
        private bool isProgrammaticallyUpdating = false;


        Dictionary<string, decimal> packagePrices = new Dictionary<string, decimal>
{
    { "Happy Feast Package", 25000 },
    { "Kiddie Fiesta Package", 15000 },
    { "Elegant Birthday Buffet", 40000 }
};
        //venue

        private Dictionary<string, List<string>> venueData = new Dictionary<string, List<string>>()
{
    { "Quezon City", new List<string> {
        "Artson Events Place (Wheatberry)",
        "Avire Tower",
        "Bulwagang San Vicente",
        "First Greenmeadows",
        "Gazebo Royale" }
    },
    { "Antipolo City", new List<string> {
        "The Mango Farm",
        "Jardin de Miramar",
        "L'Aquinum Gardens",
        "L'Orchard Garden Venue",
        "The Garden Hive Events Place" }
    },
    { "Cainta / Rizal", new List<string> {
        "Villa Ardin Events Place",
        "Emperor Events Center",
        "Villa Milagros Events Venue" }
    },
    { "Makati", new List<string> {
        "Green Sun - The Hotel",
        "Brio Tower Sky Lounge",
        "The Balmori Tent at Rockwell"}
    },
    { "Manila / South / Alabang", new List<string> {
        "SMX Convention Center Manila",
        "The Madison Events Place / Madison Galeries",
        "Fairway Terraces Sky Lounge",
        "The Tent by Acacia Estates" }
    }
};

        // Venue details dictionary: Venue Name -> Details text
        private Dictionary<string, string> venueDetails = new Dictionary<string, string>()
{
    { "Artson Events Place (Wheatberry)", "Located along Roces Avenue, this venue offers fully air-conditioned halls, PWD access, and ample parking." },
    { "Avire Tower", "7-story commercial building in Project 4, suitable for events and offices." },
    { "Bulwagang San Vicente", "Events venue inside Santuario de San Vicente de Paul Parish, ideal for weddings and seminars." },
    { "First Greenmeadows", "Located in Greenmeadows Subdivision, offering event spaces in a residential area." },
    { "Gazebo Royale", "Special event venue with Champagne Hall, Phoenix Avenue, and Bamboo Grove." },

    { "The Mango Farm", "Family-run farm and bird sanctuary on Cainta-Antipolo border, pet-friendly events." },
    { "Jardin de Miramar", "13 uniquely themed venues on a 3-hectare property for weddings and more." },
    { "L'Aquinum Gardens", "Rustic garden weddings venue with breathtaking outdoor settings." },
    { "L'Orchard Garden Venue", "Relaxing garden venue in Kingsville Court for personal celebrations." },
    { "The Garden Hive Events Place", "Three distinct spaces in Antipolo for versatile events." },

    { "Villa Ardin Events Place", "Picturesque venue in Valley Golf Hills for weddings and corporate events." },
    { "Emperor Events Center", "Exclusive venue with Glass Hall and Empress Garden in Valley Golf CC." },
    { "Villa Milagros Events Venue", "Elegant former ancestral house for weddings in Rodriguez, Rizal." },

    { "Green Sun - The Hotel", "3-star hotel with industrial architecture in Makati, event spaces available." },
    { "Brio Tower Sky Lounge", "Sky lounge in Brio Tower offering panoramic city views." },
    { "The Balmori Tent at Rockwell", "Tented venue in Rockwell Center suitable for various events." },


    { "SMX Convention Center Manila", "Premier convention and exhibition center with modern facilities." },
    { "The Madison Events Place / Madison Galeries", "Stylish events place within Madison Galeries." },
    { "Fairway Terraces Sky Lounge", "Serene sky lounge with panoramic views for small events." },
    { "The Tent by Acacia Estates", "Spacious events venue within Acacia Estates for weddings and corporate events." }
};


        private Dictionary<string, string> venueImages = new Dictionary<string, string>()
{
    { "Artson Events Place (Wheatberry)", "artson.jpg" },
    { "Avire Tower", "avire.jpg" },
    { "Bulwagang San Vicente", "bulg.jpg" },
    { "First Greenmeadows", "green.jpg" },
    { "Gazebo Royale", "gazeb.jpg" },
    { "The Mango Farm", "mango.jpg" },
    { "Jardin de Miramar", "jardin.jpg" },
    { "L'Aquinum Gardens", "aquinum.jpg" },
    { "L'Orchard Garden Venue", "Orchard.jpg" },
    { "The Garden Hive Events Place", "gardenhive.jpg" },
    { "Villa Ardin Events Place", "villaardin.jpg" },
    { "Emperor Events Center", "emperor.jpg" },
    { "Villa Milagros Events Venue", "millagros.jpg" },
    { "Green Sun – The Hotel", "green.jpg" },
    { "Brio Tower Sky Lounge", "brio.jpg" },
    { "The Balmori Tent at Rockwell", "rockwell.jpg" },
    { "SMX Convention Center Manila", "smx.jpg" },
    { "The Madison Events Place / Madison Galeries", "madison.jpg" },
    { "Fairway Terraces Sky Lounge", "fairway.jpg" },
    { "The Tent by Acacia Estates", "tent.jpg" }
};



        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            //for coupon
            cboPackages.Items.Clear();
            foreach (var kvp in packagePrices)
            {
                cboPackages.Items.Add($"{kvp.Key} - ₱{kvp.Value:0.00}");
            }

            //venue
            cboPlace.Items.Clear();
            foreach (var place in venueData.Keys)
            {
                cboPlace.Items.Add(place);
            }
            toolTip1.SetToolTip(picLogo, "Go to Main Page");


            chckCateringOnly.Checked = false;


        }

        private void cboCater_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCatering.SelectedItem is not string selectedItem)
            {
                txtCatering.Text = "No item selected.";
                return;
            }

            selectedItem = selectedItem.Trim();

            if (selectedItem.Equals("Fiesta Buffet Co.", StringComparison.OrdinalIgnoreCase))
            {
                txtCatering.Text = "Cuisine: Street Food Fusion\r\n\r\nAppearance: Colorful food carts, string lights, themed staff shirts\r\n\r\nIdeal For: Kid’s or teen birthdays";
            }
            else if (selectedItem.Equals("Sweet & Savory Catering", StringComparison.OrdinalIgnoreCase))
            {
                txtCatering.Text = "Cuisine: Filipino Comfort Food + Desserts\r\n\r\nAppearance: Balloon-themed table decor, staff in pastel polos\r\n\r\nIdeal For: Family and kids’ birthdays";
            }
            else if (selectedItem.Equals("Bayan Banquet Services", StringComparison.OrdinalIgnoreCase))
            {
                txtCatering.Text = "Cuisine: Filipino + Asian\r\n\r\nAppearance: Basic setup, party-themed table covers, DIY-style\r\n\r\nIdeal For: Budget-friendly birthdays\r\n\r\n";
            }
            else if (selectedItem.Equals("Celebration Platers", StringComparison.OrdinalIgnoreCase))
            {
                txtCatering.Text = "Cuisine: Mixed Grill + Custom Cakes\r\n\r\nAppearance: Grilled food stations, cupcake towers, fun uniforms\r\n\r\nIdeal For: Outdoor or backyard birthdays\r\n\r\n";
            }
            else if (selectedItem.Equals("Party Spoon Catering", StringComparison.OrdinalIgnoreCase))
            {
                txtCatering.Text = "Cuisine: Snack Buffet + Mini Meals\r\n\r\nAppearance: Themed utensils and party hats, cheerful staff\r\n\r\nIdeal For: Kids’ parties and youth events";
            }
            else
            {
                txtCatering.Text = "Please select a valid catering service.";
            }
        }
        //Packages
        private void cboPackages_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Avoid resetting the text here – it interferes with selection.
            if (cboPackages.SelectedItem is not string selectedItemText)
            {
                txtPackageDetails.Text = "No package selected.";
                txtPrice.Text = "0.00";
                return;
            }

            // Extract the package name (before dash, if applicable)
            string selectedPackage = selectedItemText.Split('-')[0].Trim();

            // Show details based on package
            if (selectedPackage.Equals("Happy Feast Package", StringComparison.OrdinalIgnoreCase))
            {
                txtPackageDetails.Text = "₱12,000 – ₱25,000 | 30–80 pax\n\n" +
                    "Main Dishes (choose 4):\n" +
                    "Spaghetti / Baked Macaroni\n" +
                    "Fried Chicken / Chicken Lollipop\n" +
                    "Pork BBQ / Lumpiang Shanghai\n" +
                    "Sweet & Sour Fish / Breaded Fish\n\n" +
                    "Rice: Garlic Rice or Plain Rice\n\n" +
                    "Desserts (choose 2): Leche Flan, Mini Cupcakes, Gelatin, Maja Blanca\n" +
                    "Drinks: Iced Tea or Fruit Punch\n\n" +
                    "Add-ons: Backdrop, Balloons, Birthday Cake, Party Host (optional)";
            }
            else if (selectedPackage.Equals("Kiddie Fiesta Package", StringComparison.OrdinalIgnoreCase))
            {
                txtPackageDetails.Text = "₱8,000 – ₱15,000 | 20–50 kids\n\n" +
                    "Menu:\n" +
                    "Spaghetti / Mac & Cheese\n" +
                    "Chicken Nuggets / Hotdog with Marshmallows\n" +
                    "Mini Burgers / Fries / Cheese Sticks\n\n" +
                    "Drinks: Juice in cups\n\n" +
                    "Add-ons: Loot bags, Themed table decor, Clown or Magician (optional)";
            }
            else if (selectedPackage.Equals("Elegant Birthday Buffet", StringComparison.OrdinalIgnoreCase))
            {
                txtPackageDetails.Text = "₱20,000 – ₱40,000 | 50–120 pax\n\n" +
                    "Main Dishes (choose 6): Filipino or International cuisine\n\n" +
                    "Add-ons: Carving Station, Premium Dessert Table, Signature Drinks\n\n" +
                    "Decor: LED signage, Buffet Styling, Photographer (optional)";
            }
            else
            {
                txtPackageDetails.Text = "Please select a valid birthday package.";
            }

            // Set price from dictionary
            if (packagePrices.TryGetValue(selectedPackage, out decimal price))
            {
                txtPrice.Text = price.ToString("0.00");
            }
            else
            {
                txtPrice.Text = "0.00";
            }

            // Reset discount/coupon values
            txtDiscounted.Text = "";
            txtDiscount.Text = "";
            txtSave.Text = "";
            txtCouponCode.Text = "";
            couponGenerated = false;
        }

        private void cboVenue_SelectedIndexChanged(object sender, EventArgs e)
        {


            string? selectedVenue = cboVenue.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedVenue))
            {
                // Show venue details
                if (venueDetails.ContainsKey(selectedVenue))
                {
                    txtVenueInfo.Text = venueDetails[selectedVenue];  // 📋 Show info
                }
                else
                {
                    txtVenueInfo.Text = "❌ No details available for the selected venue.";
                }

                // Show venue image
                if (venueImages.ContainsKey(selectedVenue))
                {
                    try
                    {
                        string imagePath = Path.Combine(Application.StartupPath, "Images", venueImages[selectedVenue]);

                        if (File.Exists(imagePath))
                        {
                            picBox1.Image = Image.FromFile(imagePath);
                            picBox1.SizeMode = PictureBoxSizeMode.StretchImage; // or Zoom
                        }
                        else
                        {
                            picBox1.Image = null;
                            MessageBox.Show($"⚠️ Image file not found:\n{imagePath}");
                        }
                    }
                    catch (Exception ex)
                    {
                        picBox1.Image = null;
                        MessageBox.Show($"⚠️ Failed to load image:\n{ex.Message}");
                    }
                }
                else
                {
                    picBox1.Image = null;  // Clear picture if no image for venue
                }
            }
            else
            {
                txtVenueInfo.Text = "❌ No venue selected.";
                picBox1.Image = null;
            }


        }

        private void cboPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboVenue.Items.Clear();
            txtVenueInfo.Clear();
            picBox1.Image = null;

            string? selectedPlace = cboPlace.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedPlace) && venueData.ContainsKey(selectedPlace))
            {
                foreach (var venue in venueData[selectedPlace])
                {
                    cboVenue.Items.Add(venue);  // Add venue names only
                }
            }

        }

        private void cboOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboOccasion.Text = "BIRTHDAY";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();

            }
        }
        //for coupon
        private string GenerateRandomCouponCode(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
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

        private void txtSave_TextChanged(object sender, EventArgs e)
        {
            if (isProgrammaticallyUpdating) return;

            txtSave.Text = $"SAVE{randomDiscount}";
        }

        private void btnApplyCoupon_Click(object sender, EventArgs e)
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

        private void chckCateringOnly_CheckedChanged(object sender, EventArgs e)
        {
            bool cateringOnly = chckCateringOnly.Checked;

            // Disable or hide package-related controls
            txtCustomerName.Enabled = !cateringOnly;
            cboPackages.Enabled = !cateringOnly;
            txtPrice.Enabled = !cateringOnly;
            txtDiscounted.Enabled = !cateringOnly;
            btnGenerate.Enabled = !cateringOnly;
            btnApplyCoupon.Enabled = !cateringOnly;
            txtCouponCode.Enabled = !cateringOnly;
            txtDiscount.Enabled = !cateringOnly;
            txtPackageDetails.Enabled = !cateringOnly;

            // Disable or hide venue-related controls
            cboPlace.Enabled = !cateringOnly;
            cboVenue.Enabled = !cateringOnly;
            picBox1.Enabled = !cateringOnly;
            txtVenueInfo.Enabled = !cateringOnly;

            // Disable occasion/event inputs
            cboOccasion.Enabled = !cateringOnly;
            txtEventName.Enabled = !cateringOnly;
            dtpDate.Enabled = !cateringOnly;

            // Optional: change UI labels if needed


            // Now handle catering section
            txtName.Enabled = cateringOnly;
            cboProvince.Enabled = cateringOnly;
            cboCity.Enabled = cateringOnly;
            cboStreet.Enabled = cateringOnly;
            txtCatering.Enabled = cateringOnly;


            btnConfirmBooking.Text = cateringOnly ? "Confirm Catering" : "Confirm Booking";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            cboCatering.SelectedIndex = -1;
            cboPackages.SelectedIndex = -1;
            txtPrice.Clear();
            txtDiscounted.Clear();
            txtCouponCode.Clear();
            txtDiscount.Clear();
            txtSave.Clear();
            txtPackageDetails.Clear();
            txtVenueInfo.Clear();
            picBox1.Image = null;
            cboPlace.SelectedIndex = -1;
            cboVenue.SelectedIndex = -1;
            cboOccasion.SelectedIndex = -1;
            txtEventName.Clear();
            dtpDate.Value = DateTime.Now;

        }
    }
}
