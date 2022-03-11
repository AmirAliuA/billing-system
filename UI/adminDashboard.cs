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

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProducts products = new formProducts();
            products.Show();

            // Don't allow the formUsers to open more than once
            if (Application.OpenForms.OfType<formProducts>().Count() == 2)
                Application.OpenForms.OfType<formProducts>().First().Close();
        }

        // Users image
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            formUsers user = new formUsers();
            user.Show();
        }

        // Categories image
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formCategories categories = new formCategories();
            categories.Show();
        }

        // Products image
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            formProducts products = new formProducts();
            products.Show();
        }

        // Transactions image
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            /*formTransactions transactions = new formTransactions();
            transactions.Show();*/
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            formLogin login = new formLogin();
            login.ShowDialog();
        }
    }
}