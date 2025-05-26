namespace CaterChain
{
    partial class Main
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
            btnBooking = new Button();
            btnVenue = new Button();
            btnFeedback = new Button();
            btnCoupon = new Button();
            btnReport = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            myProfileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            galleryToolStripMenuItem = new ToolStripMenuItem();
            lblWelcome = new Label();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            panel2 = new Panel();
            Fb = new PictureBox();
            Ig = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Fb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ig).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(btnBooking);
            panel1.Controls.Add(btnVenue);
            panel1.Controls.Add(btnFeedback);
            panel1.Controls.Add(btnCoupon);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(menuStrip2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 1055);
            panel1.TabIndex = 1;
            // 
            // btnBooking
            // 
            btnBooking.Location = new Point(51, 419);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(102, 37);
            btnBooking.TabIndex = 12;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnVenue
            // 
            btnVenue.Location = new Point(51, 344);
            btnVenue.Name = "btnVenue";
            btnVenue.Size = new Size(102, 37);
            btnVenue.TabIndex = 11;
            btnVenue.Text = "Venue";
            btnVenue.UseVisualStyleBackColor = true;
            btnVenue.Click += btnVenue_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.Location = new Point(51, 583);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(102, 37);
            btnFeedback.TabIndex = 10;
            btnFeedback.Text = "Feedbacks";
            btnFeedback.UseVisualStyleBackColor = true;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnCoupon
            // 
            btnCoupon.Location = new Point(51, 495);
            btnCoupon.Name = "btnCoupon";
            btnCoupon.Size = new Size(102, 37);
            btnCoupon.TabIndex = 9;
            btnCoupon.Text = "Coupons";
            btnCoupon.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(51, 991);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(102, 37);
            btnReport.TabIndex = 3;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoo;
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(51, 190);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(102, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { myProfileToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(77, 29);
            toolStripMenuItem1.Text = "Account";
            // 
            // myProfileToolStripMenuItem
            // 
            myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            myProfileToolStripMenuItem.Size = new Size(159, 26);
            myProfileToolStripMenuItem.Text = "My Profile";
            myProfileToolStripMenuItem.Click += myProfileToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.White;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            menuStrip2.Location = new Point(51, 264);
            menuStrip2.Margin = new Padding(10);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(102, 33);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.White;
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, galleryToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(79, 29);
            toolStripMenuItem2.Text = "Catering";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(135, 6);
            // 
            // galleryToolStripMenuItem
            // 
            galleryToolStripMenuItem.Name = "galleryToolStripMenuItem";
            galleryToolStripMenuItem.Size = new Size(138, 26);
            galleryToolStripMenuItem.Text = "Gallery";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(272, 225);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(462, 43);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome to CaterChain, ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 41);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 3;
            label1.Text = "About us";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(212, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1712, 16);
            panel2.TabIndex = 4;
            // 
            // Fb
            // 
            Fb.Image = Properties.Resources.vvnyrtnr;
            Fb.Location = new Point(1022, 34);
            Fb.Name = "Fb";
            Fb.Size = new Size(33, 27);
            Fb.SizeMode = PictureBoxSizeMode.StretchImage;
            Fb.TabIndex = 5;
            Fb.TabStop = false;
            Fb.Click += Fb_Click;
            // 
            // Ig
            // 
            Ig.Image = Properties.Resources.dad;
            Ig.Location = new Point(1131, 34);
            Ig.Name = "Ig";
            Ig.Size = new Size(33, 27);
            Ig.SizeMode = PictureBoxSizeMode.StretchImage;
            Ig.TabIndex = 6;
            Ig.TabStop = false;
            Ig.Click += Ig_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1924, 1055);
            Controls.Add(Ig);
            Controls.Add(Fb);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Fb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem myProfileToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip5;
        private MenuStrip menuStrip6;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem birthdayToolStripMenuItem;
        private ToolStripMenuItem weddingToolStripMenuItem;
        private ToolStripMenuItem reunionToolStripMenuItem;
        private ToolStripMenuItem fundraiserToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem galleryToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem bookForBirthdayToolStripMenuItem;
        private ToolStripMenuItem bookForWeddingToolStripMenuItem;
        private ToolStripMenuItem bookForReunionToolStripMenuItem;
        private ToolStripMenuItem bookForFundraisingToolStripMenuItem;
        private MenuStrip menuStrip4;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private Label lblWelcome;
        private Button btnReport;
        private Button btnCoupon;
        private ToolTip toolTip1;
        private Label label1;
        private Panel panel2;
        private PictureBox Fb;
        private PictureBox Ig;
        private Button btnBooking;
        private Button btnVenue;
        private Button btnFeedback;
    }
}