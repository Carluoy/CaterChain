namespace CaterChain
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtUsername = new TextBox();
            txtContact = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRegister = new Button();
            btnClear = new Button();
            label8 = new Label();
            label9 = new Label();
            toolTip1 = new ToolTip(components);
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Location = new Point(480, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 651);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 81);
            label1.Name = "label1";
            label1.Size = new Size(339, 32);
            label1.TabIndex = 1;
            label1.Text = "Welcome our new User!";
            // 
            // txtFname
            // 
            txtFname.BackColor = Color.White;
            txtFname.Font = new Font("Arial Rounded MT Bold", 9F);
            txtFname.Location = new Point(62, 172);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(339, 25);
            txtFname.TabIndex = 2;
            txtFname.TextChanged += txtFname_TextChanged;
            txtFname.KeyPress += txtFname_KeyPress;
            // 
            // txtLname
            // 
            txtLname.BackColor = Color.White;
            txtLname.Font = new Font("Arial Rounded MT Bold", 9F);
            txtLname.Location = new Point(62, 235);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(339, 25);
            txtLname.TabIndex = 3;
            txtLname.KeyPress += txtLname_KeyPress;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Arial Rounded MT Bold", 9F);
            txtUsername.Location = new Point(62, 298);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(339, 25);
            txtUsername.TabIndex = 4;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Arial Rounded MT Bold", 9F);
            txtContact.Location = new Point(62, 480);
            txtContact.MaxLength = 13;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(339, 25);
            txtContact.TabIndex = 7;
            txtContact.KeyPress += txtContact_KeyPress;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.Font = new Font("Arial Rounded MT Bold", 9F);
            txtConfirmPassword.Location = new Point(62, 419);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(339, 25);
            txtConfirmPassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Arial Rounded MT Bold", 9F);
            txtPassword.Location = new Point(62, 360);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(339, 25);
            txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label2.Location = new Point(62, 160);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 8;
            label2.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label3.Location = new Point(62, 225);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 9;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label4.Location = new Point(62, 351);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label5.Location = new Point(62, 407);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 11;
            label5.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label6.Location = new Point(62, 285);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 12;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label7.Location = new Point(62, 467);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 13;
            label7.Text = "Contact no.";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Bisque;
            btnRegister.Font = new Font("Times New Roman", 10.8F);
            btnRegister.Location = new Point(79, 525);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(153, 29);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.OrangeRed;
            btnClear.Font = new Font("Times New Roman", 10.8F);
            btnClear.Location = new Point(307, 525);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 606);
            label8.Name = "label8";
            label8.Size = new Size(178, 20);
            label8.TabIndex = 16;
            label8.Text = "Already have an account?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(289, 606);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 17;
            label9.Text = "Login Here";
            label9.Click += label9_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(763, 46);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.red_white_power_button_symbol_icon_30;
            pictureBox1.Location = new Point(714, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 14);
            label10.Name = "label10";
            label10.Size = new Size(152, 20);
            label10.TabIndex = 1;
            label10.Text = "REGISTRATION FORM";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(762, 651);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtContact);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtUsername;
        private TextBox txtContact;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnRegister;
        private Button btnClear;
        private Label label8;
        private Label label9;
        private ToolTip toolTip1;
        private Panel panel2;
        private Label label10;
        private PictureBox pictureBox1;
    }
}