namespace CaterChain
{
    partial class Coupon
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
            btnGenerate = new Button();
            btnApply = new Button();
            txtDiscount = new TextBox();
            txtCouponCode = new TextBox();
            txtSave = new TextBox();
            txtPrice = new TextBox();
            txtDiscounted = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(403, 264);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(203, 35);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(403, 355);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(203, 35);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(403, 231);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(204, 27);
            txtDiscount.TabIndex = 2;
            // 
            // txtCouponCode
            // 
            txtCouponCode.Location = new Point(403, 322);
            txtCouponCode.Name = "txtCouponCode";
            txtCouponCode.Size = new Size(204, 27);
            txtCouponCode.TabIndex = 3;
            // 
            // txtSave
            // 
            txtSave.Location = new Point(635, 288);
            txtSave.Name = "txtSave";
            txtSave.Size = new Size(204, 27);
            txtSave.TabIndex = 4;
            txtSave.TextChanged += txtSave_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(635, 231);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(204, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtDiscounted
            // 
            txtDiscounted.Location = new Point(137, 322);
            txtDiscounted.Name = "txtDiscounted";
            txtDiscounted.Size = new Size(204, 27);
            txtDiscounted.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(414, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Coupon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 498);
            Controls.Add(comboBox1);
            Controls.Add(txtDiscounted);
            Controls.Add(txtPrice);
            Controls.Add(txtSave);
            Controls.Add(txtCouponCode);
            Controls.Add(txtDiscount);
            Controls.Add(btnApply);
            Controls.Add(btnGenerate);
            Name = "Coupon";
            Text = "Coupon";
            Load += Coupon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Button btnApply;
        private TextBox txtDiscount;
        private TextBox txtCouponCode;
        private TextBox txtSave;
        private TextBox txtPrice;
        private TextBox txtDiscounted;
        private ComboBox comboBox1;
    }
}