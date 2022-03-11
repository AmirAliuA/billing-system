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
    public partial class formProducts : Form
    {
        public formProducts()
        {
            InitializeComponent();
        }

        categoriesDAL cdal = new categoriesDAL();
        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();

        private void formProducts_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();
            comboBoxProductCategory.DataSource = categoriesDT;
            comboBoxProductCategory.DisplayMember = "title";
            comboBoxProductCategory.ValueMember = "title";

            DataTable dt = pdal.Select();
            dataGridViewProducts.DataSource = dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            p.name = textNameProducts.Text;
            p.category = comboBoxProductCategory.Text;
            p.description = textCategoriesDescription.Text;
            p.rate = (int)decimal.Parse(textBoxRate.Text);
            p.quantity = 0;
            p.added_date = DateTime.Now;

            String loggedUser = formLogin.loggedInUsername;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            p.added_by = usr.id;

            bool success = pdal.Insert(p);

            if (success == true)
            {
                MessageBox.Show("Product was added successfully.");
                Clear();

                DataTable dt = pdal.Select();
                dataGridViewProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to add a new product.");
            }
        }

        public void Clear()
        {
            textProductsID.Text = "";
            textNameProducts.Text = "";
            comboBoxProductCategory.Text = "";
            textCategoriesDescription.Text = "";
            textBoxRate.Text = "";
            textSearchProducts.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(textProductsID.Text);
            p.name = textNameProducts.Text;
            p.category = comboBoxProductCategory.Text;
            p.rate = (int)decimal.Parse(textBoxRate.Text);
            p.added_date = DateTime.Now;

            String loggedUser = formLogin.loggedInUsername;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            p.added_by = usr.id;

            bool success = pdal.Update(p);
            if(success == true)
            {
                MessageBox.Show("Product was updated successfully.");
                Clear();

                DataTable dt = pdal.Select();
                dataGridViewProducts.DataSource = dt;
                
            }
            else
            {
                MessageBox.Show("Failed to update a product.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(textProductsID.Text);

            bool success = pdal.Delete(p);

            if(success == true)
            {
                MessageBox.Show("Product was successfully deleted.");
                Clear();

                DataTable dt = pdal.Select();
                dataGridViewProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete the product.");
            }
        }

        private void dataGridViewProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textProductsID.Text = dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString();
            textNameProducts.Text = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxProductCategory.Text = dataGridViewProducts.Rows[rowIndex].Cells[2].Value.ToString();
            textCategoriesDescription.Text = dataGridViewProducts.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxRate.Text = dataGridViewProducts.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void textSearchProducts_TextChanged(object sender, EventArgs e)
        {
            string keywords = textSearchProducts.Text;

            if(keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dataGridViewProducts.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dataGridViewProducts.DataSource = dt;
            }
        }
    }
}
