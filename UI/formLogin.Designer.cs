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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.textLoginUsername = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginUserType = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.comboBoxLoginUserType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-90, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 439);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(373, 44);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(80, 26);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "LOGIN";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(373, 86);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(121, 25);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginPassword.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.labelLoginPassword.Location = new System.Drawing.Point(373, 150);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(114, 25);
            this.labelLoginPassword.TabIndex = 3;
            this.labelLoginPassword.Text = "Password";
            // 
            // textLoginUsername
            // 
            this.textLoginUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLoginUsername.Location = new System.Drawing.Point(380, 114);
            this.textLoginUsername.Name = "textLoginUsername";
            this.textLoginUsername.Size = new System.Drawing.Size(121, 16);
            this.textLoginUsername.TabIndex = 5;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(380, 178);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(121, 23);
            this.textBoxLoginPassword.TabIndex = 6;
            // 
            // labelLoginUserType
            // 
            this.labelLoginUserType.AutoSize = true;
            this.labelLoginUserType.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginUserType.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginUserType.ForeColor = System.Drawing.Color.Black;
            this.labelLoginUserType.Location = new System.Drawing.Point(373, 215);
            this.labelLoginUserType.Name = "labelLoginUserType";
            this.labelLoginUserType.Size = new System.Drawing.Size(116, 25);
            this.labelLoginUserType.TabIndex = 8;
            this.labelLoginUserType.Text = "User Type";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(449, 339);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(178, 59);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // comboBoxLoginUserType
            // 
            this.comboBoxLoginUserType.FormattingEnabled = true;
            this.comboBoxLoginUserType.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.comboBoxLoginUserType.Location = new System.Drawing.Point(380, 243);
            this.comboBoxLoginUserType.Name = "comboBoxLoginUserType";
            this.comboBoxLoginUserType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLoginUserType.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 532);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(707, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 443);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxLoginUserType);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelLoginUserType);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textLoginUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelLoginPassword);
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
        private Label labelUsername;
        private Label labelLoginPassword;
        private TextBox textLoginUsername;
        private TextBox textBoxLoginPassword;
        private Label labelLoginUserType;
        private Button buttonLogin;
        private ComboBox comboBoxLoginUserType;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}