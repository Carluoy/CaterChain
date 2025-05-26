namespace CaterChain
{
    partial class Loginpage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnCancel = new Button();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            lblToRegister = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnLogin.Location = new Point(300, 504);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 41);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnCancel.Location = new Point(414, 504);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 41);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtUser.Location = new Point(137, 332);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(355, 27);
            txtUser.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtPassword.Location = new Point(137, 398);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(355, 27);
            txtPassword.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(140, 446);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 27);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 628);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 7;
            label3.Text = "Don't have an account yet?";
            // 
            // lblToRegister
            // 
            lblToRegister.AutoSize = true;
            lblToRegister.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToRegister.Location = new Point(358, 628);
            lblToRegister.Name = "lblToRegister";
            lblToRegister.Size = new Size(123, 20);
            lblToRegister.TabIndex = 8;
            lblToRegister.Text = "Register Here";
            lblToRegister.Click += lblToRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.OIP__4__removebg_preview;
            pictureBox1.Location = new Point(462, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.password_icon_png_19;
            pictureBox2.Location = new Point(462, 398);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logoo;
            pictureBox3.Location = new Point(188, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(269, 199);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(lblToRegister);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 685);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 44);
            panel2.TabIndex = 12;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.red_white_power_button_symbol_icon_30;
            pictureBox4.Location = new Point(601, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 15);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 1;
            label10.Text = "LOGIN FORM";
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.red_white_power_button_symbol_icon_30;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(709, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 37);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Loginpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 687);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loginpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Loginpage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnCancel;
        private TextBox txtUser;
        private TextBox txtPassword;
        private CheckBox checkBox1;
        private Label label3;
        private Label lblToRegister;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Label label10;
        private Button btnExit;
        private PictureBox pictureBox4;
    }
}
