using billing_system.BusinessLogicLayer;
using billing_system.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_system.UI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        public static string loggedInUsername; 

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            l.username = textLoginUsername.Text.Trim();
            l.password = textBoxLoginPassword.Text.Trim();
            l.user_type = comboBoxLoginUserType.Text.Trim();

            bool success = dal.loginCheck(l);

            if(success == true)
            {
                MessageBox.Show("Login successful.");
                loggedInUsername = l.username;
                
                switch(l.user_type)
                {
                    case "Admin":
                    {
                        adminDashboard admin = new adminDashboard();
                        admin.Show();
                        this.Hide();
                    }
                    break;

                    case "User":
                    {
                        userDashboard user = new userDashboard();
                        user.Show();
                        this.Hide();
                    }
                    break;

                    default:
                    {
                        MessageBox.Show("Invalid User Type");
                    }
                    break;
                }
            }
            else
            {
                MessageBox.Show("Login failed.WSXEDWX ");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
