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
    public partial class formCategories : Form
    {
        public formCategories()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();

        // Add Button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            c.title = textTitleCategories.Text;
            c.description = textCategoriesDescription.Text;
            c.added_date = DateTime.Now;

            string loggedUser = formLogin.loggedInUsername;
            userBLL usr = udal.GetIDFromUsername(loggedUser);

            c.added_by = usr.id;

            bool success = dal.Insert(c);

            if(success == true)
            {
                MessageBox.Show("Created a category successfully.");
                Clear();

                DataTable dt = dal.Select();
                dataGridViewCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to create a category.");
            }
        }

        // Update Button
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(textCategoriesID.Text);
            c.title = textTitleCategories.Text;
            c.description = textCategoriesDescription.Text;
            c.added_date = DateTime.Now;

            string loggedUser = formLogin.loggedInUsername;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;

            bool success = dal.Update(c);

            if(success == true)
            {
                MessageBox.Show("Category updated successfully.");
                Clear();

                DataTable dt = dal.Select();
                dataGridViewCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update the category.");
            }
        }

        // Delete Button
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(textCategoriesID.Text);

            bool success = dal.Delete(c);

            if(success == true)
            {
                MessageBox.Show("Category deleted successfully.");
                Clear();

                DataTable dt = dal.Select();
                dataGridViewCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete the category.");
            }
        }

        public void Clear()
        {
            textCategoriesID.Text = "";
            textTitleCategories.Text = "";
            textCategoriesDescription.Text = "";
            textSearchCategories.Text = "";
        }

        private void formCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dataGridViewCategories.DataSource = dt;
        }

        private void dataGridViewCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textCategoriesID.Text = dataGridViewCategories.Rows[rowIndex].Cells[0].Value.ToString();
            textTitleCategories.Text = dataGridViewCategories.Rows[rowIndex].Cells[1].Value.ToString();
            textCategoriesDescription.Text = dataGridViewCategories.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void textSearchCategories_TextChanged(object sender, EventArgs e)
        {
            string keywords = textSearchCategories.Text;

            if(keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dataGridViewCategories.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dataGridViewCategories.DataSource = dt;
            }
        }
    }
}
