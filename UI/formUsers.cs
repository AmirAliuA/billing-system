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
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Getting data from the UI
            u.first_name = textFirstName.Text;
            u.last_name = textLastName.Text;
            u.gender = comboBoxGender.Text;
            u.email = textEMail.Text;
            u.username = textUsername.Text;
            u.password = textPassword.Text;
            u.contact = textContact.Text;
            u.address = textAddress.Text;
            u.user_type = comboBoxUserType.Text;
            u.added_date = DateTime.Now;

            string loggedUser = formLogin.loggedInUsername;
            userBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.id;

            // Inserting data in the database
            bool success = dal.Insert(u);

            // if the data is successfully inserted then success -> true ELSE success -> false
            if(success = true)
            {
                MessageBox.Show("User successfully created.");
                Clear();
            } 
            else
            {
                MessageBox.Show("User was not created successfully.");
            }

            // Refresh Data Grid View
            DataTable dt = dal.Select();
            dataGridViewUsers.DataSource = dt;
        }

        private void formUsers_Load(object sender, EventArgs e)
        {
            // Refresh Data Grid View
            DataTable dt = dal.Select();
            dataGridViewUsers.DataSource = dt;
        }

        // Clear the data filled in the boxes after the data is registered
        private void Clear()
        {
            textUserID.Text = "";
            textFirstName.Text = "";
            textLastName.Text = "";
            comboBoxGender.Text = "";
            textEMail.Text = "";
            textUsername.Text = "";
            textPassword.Text = "";
            textContact.Text = "";
            textAddress.Text = "";
            comboBoxUserType.Text = "";
        }

        // Show the user details on the textboxes when you click on the DGV
        private void dataGridViewUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the index of the row
            int rowIndex = e.RowIndex;

            textUserID.Text = dataGridViewUsers.Rows[rowIndex].Cells[0].Value.ToString();
            textFirstName.Text = dataGridViewUsers.Rows[rowIndex].Cells[1].Value.ToString();
            textLastName.Text = dataGridViewUsers.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxGender.Text = dataGridViewUsers.Rows[rowIndex].Cells[3].Value.ToString();
            textEMail.Text = dataGridViewUsers.Rows[rowIndex].Cells[4].Value.ToString();
            textUsername.Text = dataGridViewUsers.Rows[rowIndex].Cells[5].Value.ToString();
            textPassword.Text = dataGridViewUsers.Rows[rowIndex].Cells[6].Value.ToString();
            textContact.Text = dataGridViewUsers.Rows[rowIndex].Cells[7].Value.ToString();
            textAddress.Text = dataGridViewUsers.Rows[rowIndex].Cells[8].Value.ToString();
            comboBoxUserType.Text = dataGridViewUsers.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Get the values from the User UI
            u.id = Convert.ToInt32(textUserID.Text);
            u.first_name = textFirstName.Text;
            u.last_name = textLastName.Text;
            u.email = textEMail.Text;
            u.username = textUsername.Text;
            u.password = textPassword.Text;
            u.contact = textContact.Text;
            u.address = textAddress.Text;
            u.gender = comboBoxGender.Text;
            u.user_type = comboBoxUserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Update(u);
            
            // If the data is updated successfully -> true ELSE -> false
            if(success == true)
            {
                MessageBox.Show("User successfully updated.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update the user.");
            }

            // Refresh Data Grid View
            DataTable dt = dal.Select();
            dataGridViewUsers.DataSource = dt;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Getting User ID from Form
            u.id = Convert.ToInt32(textUserID.Text);

            bool success = dal.Delete(u);
            
            if (success == true)
            {
                //User Deleted Successfully 
                MessageBox.Show("User deleted successfully");
                Clear();
            }
            else
            {
                //Failed to Delete User
                MessageBox.Show("Failed to delete user");

            }

            // Refresh Data Grid View
            DataTable dt = dal.Select();
            dataGridViewUsers.DataSource = dt;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            // Get keyword from the textbox
            string keywords = textSearch.Text;

            // Check if the keywords has value or not
            if(keywords != null)
            {
                // show the user based on the keywords
                DataTable dt = dal.Search(keywords);
                dataGridViewUsers.DataSource = dt;
            }
            else
            {
                // show all the users from the database
                DataTable dt = dal.Select();
                dataGridViewUsers.DataSource = dt;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
