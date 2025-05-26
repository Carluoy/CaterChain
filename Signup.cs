using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CaterChain
{
    public partial class Signup : Form
    {

        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=accounts");
        MySqlCommand cmd = new MySqlCommand();



        public Signup()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFname.Text) ||
              string.IsNullOrWhiteSpace(txtLname.Text) ||
              string.IsNullOrWhiteSpace(txtUsername.Text) ||
              string.IsNullOrWhiteSpace(txtPassword.Text) ||
              string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
              string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password match
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm action
            if (MessageBox.Show("Do you want to register this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            // DB Connection
            string connectionString = "server=localhost;uid=root;pwd=;database=accounts;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Check for duplicate email
                    string checkEmailSql = "SELECT COUNT(*) FROM users WHERE Email = @Email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkEmailSql, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", txtUsername.Text);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            MessageBox.Show("Email already exists. Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert into the correct table: users
                    string insertSql = "INSERT INTO users (Firstname, Lastname,  Email, Password, Contact) VALUES (@Firstname, @Lastname, @Email, @Password, @Contact)";
                    using (MySqlCommand cmd = new MySqlCommand(insertSql, con))
                    {
                        cmd.Parameters.AddWithValue("@Firstname", txtFname.Text);
                        cmd.Parameters.AddWithValue("@Lastname", txtLname.Text);
                        cmd.Parameters.AddWithValue("@Email", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text); // Optional: hash this!
                        cmd.Parameters.AddWithValue("@Contact", txtContact.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear fields
                        txtFname.Clear();
                        txtLname.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                        txtContact.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtContact.Clear();
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            int selStart = txtFname.SelectionStart;
            string[] words = txtFname.Text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            txtFname.Text = string.Join(" ", words);
            txtLname.SelectionStart = selStart; // keep cursor position
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            int selStart = txtLname.SelectionStart;
            string[] words = txtLname.Text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            txtLname.Text = string.Join(" ", words);
            txtLname.SelectionStart = selStart; // keep cursor position
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Loginpage sform = new Loginpage();
            sform.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
