namespace billing_system.UI
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.comboBoxLoginUserType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelSoftwareName = new System.Windows.Forms.Label();
            this.labelWelcomeMessage1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textLoginUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUserType = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelSupportMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(371, 44);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(80, 26);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "LOGIN";
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginPassword.Location = new System.Drawing.Point(375, 201);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(347, 22);
            this.textBoxLoginPassword.TabIndex = 6;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(456, 344);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(178, 59);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // comboBoxLoginUserType
            // 
            this.comboBoxLoginUserType.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxLoginUserType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLoginUserType.FormattingEnabled = true;
            this.comboBoxLoginUserType.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.comboBoxLoginUserType.Location = new System.Drawing.Point(373, 286);
            this.comboBoxLoginUserType.Name = "comboBoxLoginUserType";
            this.comboBoxLoginUserType.Size = new System.Drawing.Size(349, 29);
            this.comboBoxLoginUserType.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.labelCopyright);
            this.panel1.Controls.Add(this.labelSoftwareName);
            this.panel1.Controls.Add(this.labelWelcomeMessage1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 532);
            this.panel1.TabIndex = 0;
            // 
            // labelCopyright
            // 
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(135, 428);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(109, 21);
            this.labelCopyright.TabIndex = 14;
            this.labelCopyright.Text = "Software Inc., 2022";
            // 
            // labelSoftwareName
            // 
            this.labelSoftwareName.BackColor = System.Drawing.Color.Transparent;
            this.labelSoftwareName.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSoftwareName.ForeColor = System.Drawing.Color.White;
            this.labelSoftwareName.Location = new System.Drawing.Point(145, 413);
            this.labelSoftwareName.Name = "labelSoftwareName";
            this.labelSoftwareName.Size = new System.Drawing.Size(89, 15);
            this.labelSoftwareName.TabIndex = 13;
            this.labelSoftwareName.Text = "Billing Software";
            // 
            // labelWelcomeMessage1
            // 
            this.labelWelcomeMessage1.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcomeMessage1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcomeMessage1.ForeColor = System.Drawing.Color.White;
            this.labelWelcomeMessage1.Location = new System.Drawing.Point(73, 321);
            this.labelWelcomeMessage1.Name = "labelWelcomeMessage1";
            this.labelWelcomeMessage1.Size = new System.Drawing.Size(240, 34);
            this.labelWelcomeMessage1.TabIndex = 12;
            this.labelWelcomeMessage1.Text = "We Create for You!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(719, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.panel3.Location = new System.Drawing.Point(373, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 10);
            this.panel3.TabIndex = 17;
            // 
            // textLoginUsername
            // 
            this.textLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLoginUsername.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLoginUsername.Location = new System.Drawing.Point(373, 114);
            this.textLoginUsername.Name = "textLoginUsername";
            this.textLoginUsername.Size = new System.Drawing.Size(349, 27);
            this.textLoginUsername.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(371, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(373, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.panel2.Location = new System.Drawing.Point(375, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 10);
            this.panel2.TabIndex = 19;
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.BackColor = System.Drawing.Color.Transparent;
            this.labelUserType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserType.ForeColor = System.Drawing.Color.Black;
            this.labelUserType.Location = new System.Drawing.Point(371, 262);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(83, 21);
            this.labelUserType.TabIndex = 22;
            this.labelUserType.Text = "User Type";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.panel4.Location = new System.Drawing.Point(373, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 10);
            this.panel4.TabIndex = 21;
            // 
            // labelSupportMessage
            // 
            this.labelSupportMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelSupportMessage.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSupportMessage.ForeColor = System.Drawing.Color.Black;
            this.labelSupportMessage.Location = new System.Drawing.Point(414, 406);
            this.labelSupportMessage.Name = "labelSupportMessage";
            this.labelSupportMessage.Size = new System.Drawing.Size(298, 33);
            this.labelSupportMessage.TabIndex = 13;
            this.labelSupportMessage.Text = "To obtain access to this app or for any questions about its use, submit an email " +
    "to software@email.com";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(751, 443);
            this.Controls.Add(this.labelUserType);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLoginUsername);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelSupportMessage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxLoginUserType);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label labelLogin;
        private TextBox textBoxLoginPassword;
        private Button buttonLogin;
        private ComboBox comboBoxLoginUserType;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label labelWelcomeMessage1;
        private Panel panel3;
        private Label labelCopyright;
        private Label labelSoftwareName;
        private TextBox textLoginUsername;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label labelUserType;
        private Panel panel4;
        private Label labelSupportMessage;
    }
}