namespace billing_system.UI
{
    partial class formProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProducts));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProducts = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textSearchProducts = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textProductsID = new System.Windows.Forms.TextBox();
            this.labelProductsID = new System.Windows.Forms.Label();
            this.textNameProducts = new System.Windows.Forms.TextBox();
            this.textCategoriesDescription = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(765, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 56;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProducts.ForeColor = System.Drawing.Color.White;
            this.labelProducts.Location = new System.Drawing.Point(365, 16);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(106, 25);
            this.labelProducts.TabIndex = 1;
            this.labelProducts.Text = "PRODUCTS";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(245, 375);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 47);
            this.buttonDelete.TabIndex = 68;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(122, 375);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 47);
            this.buttonUpdate.TabIndex = 67;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(365, 105);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowTemplate.Height = 25;
            this.dataGridViewProducts.Size = new System.Drawing.Size(423, 317);
            this.dataGridViewProducts.TabIndex = 63;
            this.dataGridViewProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProducts_RowHeaderMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 375);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 47);
            this.buttonAdd.TabIndex = 66;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(12, 105);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 21);
            this.labelName.TabIndex = 57;
            this.labelName.Text = "Name";
            // 
            // textSearchProducts
            // 
            this.textSearchProducts.Location = new System.Drawing.Point(422, 74);
            this.textSearchProducts.Name = "textSearchProducts";
            this.textSearchProducts.Size = new System.Drawing.Size(366, 23);
            this.textSearchProducts.TabIndex = 65;
            this.textSearchProducts.TextChanged += new System.EventHandler(this.textSearchProducts_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(12, 163);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(89, 21);
            this.labelDescription.TabIndex = 58;
            this.labelDescription.Text = "Description";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(359, 74);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(57, 21);
            this.labelSearch.TabIndex = 64;
            this.labelSearch.Text = "Search";
            // 
            // textProductsID
            // 
            this.textProductsID.Location = new System.Drawing.Point(122, 74);
            this.textProductsID.Name = "textProductsID";
            this.textProductsID.ReadOnly = true;
            this.textProductsID.Size = new System.Drawing.Size(205, 23);
            this.textProductsID.TabIndex = 62;
            // 
            // labelProductsID
            // 
            this.labelProductsID.AutoSize = true;
            this.labelProductsID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProductsID.Location = new System.Drawing.Point(12, 74);
            this.labelProductsID.Name = "labelProductsID";
            this.labelProductsID.Size = new System.Drawing.Size(83, 21);
            this.labelProductsID.TabIndex = 61;
            this.labelProductsID.Text = "Product ID";
            // 
            // textNameProducts
            // 
            this.textNameProducts.Location = new System.Drawing.Point(122, 105);
            this.textNameProducts.Name = "textNameProducts";
            this.textNameProducts.Size = new System.Drawing.Size(205, 23);
            this.textNameProducts.TabIndex = 59;
            // 
            // textCategoriesDescription
            // 
            this.textCategoriesDescription.Location = new System.Drawing.Point(122, 163);
            this.textCategoriesDescription.Multiline = true;
            this.textCategoriesDescription.Name = "textCategoriesDescription";
            this.textCategoriesDescription.Size = new System.Drawing.Size(205, 167);
            this.textCategoriesDescription.TabIndex = 60;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRate.Location = new System.Drawing.Point(12, 336);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(41, 21);
            this.labelRate.TabIndex = 69;
            this.labelRate.Text = "Rate";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(12, 134);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(73, 21);
            this.labelCategory.TabIndex = 71;
            this.labelCategory.Text = "Category";
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.FormattingEnabled = true;
            this.comboBoxProductCategory.Location = new System.Drawing.Point(122, 134);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(205, 23);
            this.comboBoxProductCategory.TabIndex = 72;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(122, 336);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(205, 23);
            this.textBoxRate.TabIndex = 73;
            // 
            // formProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.comboBoxProductCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textSearchProducts);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textProductsID);
            this.Controls.Add(this.labelProductsID);
            this.Controls.Add(this.textNameProducts);
            this.Controls.Add(this.textCategoriesDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProducts";
            this.Load += new System.EventHandler(this.formProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label labelProducts;
        private Button buttonDelete;
        private Button buttonUpdate;
        private DataGridView dataGridViewProducts;
        private Button buttonAdd;
        private Label labelName;
        private TextBox textSearchProducts;
        private Label labelDescription;
        private Label labelSearch;
        private TextBox textProductsID;
        private Label labelProductsID;
        private TextBox textNameProducts;
        private TextBox textCategoriesDescription;
        private Label labelRate;
        private Label labelCategory;
        private ComboBox comboBoxProductCategory;
        private TextBox textBoxRate;
    }
}