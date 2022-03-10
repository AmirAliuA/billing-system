using billing_system.UI;
using System.Windows.Forms;

namespace billing_system
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsers user = new formUsers();
            user.Show();

            // Don't allow the formUsers to open more than once
            if (Application.OpenForms.OfType<formUsers>().Count() == 2)
                Application.OpenForms.OfType<formUsers>().First().Close();
        }

        private void adminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            labelLoggedInUsername.Text = formLogin.loggedInUsername;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategories categories = new formCategories();
            categories.Show();

            // Don't allow the formUsers to open more than once
            if (Application.OpenForms.OfType<formCategories>().Count() == 2)
                Application.OpenForms.OfType<formCategories>().First().Close();
        }
    }
}