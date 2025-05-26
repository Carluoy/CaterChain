using MySql.Data.MySqlClient;
using System.Xml.Linq;


namespace CaterChain
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both email and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=accounts");

            try
            {
                con.Open();
                string sql = "SELECT * FROM users WHERE Email = @Email AND Password = @Password";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Email", txtUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text); // Hash this if you're hashing during registration

                MySqlDataReader reader = cmd.ExecuteReader();



                if (reader.Read())
                {
                    string firstName = reader["FirstName"].ToString()!; // Assuming it's never null

                    Main dForm = new Main(/*firstName*/);
                    dForm.Show();
                    this.Hide();

                    MessageBox.Show("Login successful", "Success");

                    txtUser.Text = "";
                    txtPassword.Text = "";
                }




                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void lblToRegister_Click(object sender, EventArgs e)
        {
            Signup sform = new Signup();
            sform.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
