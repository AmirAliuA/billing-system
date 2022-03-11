namespace billing_system.UI
{
    partial class formCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCategories));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCategories = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textSearchCategories = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.textCategoriesID = new System.Windows.Forms.TextBox();
            this.labelCategoryID = new System.Windows.Forms.Label();
            this.textCategoriesDescription = new System.Windows.Forms.TextBox();
            this.textTitleCategories = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(767, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategories.ForeColor = System.Drawing.Color.White;
            this.labelCategories.Location = new System.Drawing.Point(365, 16);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(118, 25);
            this.labelCategories.TabIndex = 1;
            this.labelCategories.Text = "CATEGORIES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(245, 375);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 47);
            this.buttonDelete.TabIndex = 55;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(122, 375);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 47);
            this.buttonUpdate.TabIndex = 54;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 375);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 47);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textSearchCategories
            // 
            this.textSearchCategories.Location = new System.Drawing.Point(422, 74);
            this.textSearchCategories.Name = "textSearchCategories";
            this.textSearchCategories.Size = new System.Drawing.Size(366, 23);
            this.textSearchCategories.TabIndex = 52;
            this.textSearchCategories.TextChanged += new System.EventHandler(this.textSearchCategories_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(359, 72);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(57, 21);
            this.labelSearch.TabIndex = 51;
            this.labelSearch.Text = "Search";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(365, 105);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowTemplate.Height = 25;
            this.dataGridViewCategories.Size = new System.Drawing.Size(423, 319);
            this.dataGridViewCategories.TabIndex = 50;
            this.dataGridViewCategories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCategories_RowHeaderMouseClick);
            // 
            // textCategoriesID
            // 
            this.textCategoriesID.BackColor = System.Drawing.SystemColors.Window;
            this.textCategoriesID.Location = new System.Drawing.Point(122, 74);
            this.textCategoriesID.Name = "textCategoriesID";
            this.textCategoriesID.ReadOnly = true;
            this.textCategoriesID.Size = new System.Drawing.Size(205, 23);
            this.textCategoriesID.TabIndex = 49;
            // 
            // labelCategoryID
            // 
            this.labelCategoryID.AutoSize = true;
            this.labelCategoryID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategoryID.Location = new System.Drawing.Point(12, 74);
            this.labelCategoryID.Name = "labelCategoryID";
            this.labelCategoryID.Size = new System.Drawing.Size(92, 21);
            this.labelCategoryID.TabIndex = 48;
            this.labelCategoryID.Text = "Category ID";
            // 
            // textCategoriesDescription
            // 
            this.textCategoriesDescription.Location = new System.Drawing.Point(122, 132);
            this.textCategoriesDescription.Multiline = true;
            this.textCategoriesDescription.Name = "textCategoriesDescription";
            this.textCategoriesDescription.Size = new System.Drawing.Size(205, 237);
            this.textCategoriesDescription.TabIndex = 38;
            // 
            // textTitleCategories
            // 
            this.textTitleCategories.Location = new System.Drawing.Point(122, 103);
            this.textTitleCategories.Name = "textTitleCategories";
            this.textTitleCategories.Size = new System.Drawing.Size(205, 23);
            this.textTitleCategories.TabIndex = 37;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(15, 132);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(89, 21);
            this.labelDescription.TabIndex = 31;
            this.labelDescription.Text = "Description";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 103);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 21);
            this.labelTitle.TabIndex = 30;
            this.labelTitle.Text = "Title";
            // 
            // formCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textSearchCategories);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textCategoriesID);
            this.Controls.Add(this.labelCategoryID);
            this.Controls.Add(this.textTitleCategories);
            this.Controls.Add(this.textCategoriesDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCategories";
            this.Load += new System.EventHandler(this.formCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelCategories;
        private Panel panel1;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox textSearchCategories;
        private Label labelSearch;
        private DataGridView dataGridViewCategories;
        private TextBox textCategoriesID;
        private Label labelCategoryID;
        private TextBox textCategoriesDescription;
        private TextBox textTitleCategories;
        private Label labelDescription;
        private Label labelTitle;
    }
}