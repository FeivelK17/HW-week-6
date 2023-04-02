namespace HW_week_6
{
    partial class Form1
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
            this.label_Product = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_CatName = new System.Windows.Forms.Label();
            this.label_Details = new System.Windows.Forms.Label();
            this.label_Nama = new System.Windows.Forms.Label();
            this.label_DetCategory = new System.Windows.Forms.Label();
            this.label_Harga = new System.Windows.Forms.Label();
            this.label_Stock = new System.Windows.Forms.Label();
            this.txtBox_CatNama = new System.Windows.Forms.TextBox();
            this.txtBox_DetNama = new System.Windows.Forms.TextBox();
            this.txtBox_Harga = new System.Windows.Forms.TextBox();
            this.txtBox_Stock = new System.Windows.Forms.TextBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.btn_AddCat = new System.Windows.Forms.Button();
            this.btn_RemoveCat = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_ALL = new System.Windows.Forms.Button();
            this.btn_FILTER = new System.Windows.Forms.Button();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.pictureBox_GUCCI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GUCCI)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.BackColor = System.Drawing.Color.Firebrick;
            this.label_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Product.Location = new System.Drawing.Point(23, 20);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(86, 25);
            this.label_Product.TabIndex = 0;
            this.label_Product.Text = "Product";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.BackColor = System.Drawing.Color.Firebrick;
            this.label_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Category.ForeColor = System.Drawing.Color.White;
            this.label_Category.Location = new System.Drawing.Point(918, 24);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(100, 25);
            this.label_Category.TabIndex = 1;
            this.label_Category.Text = "Category";
            // 
            // label_CatName
            // 
            this.label_CatName.AutoSize = true;
            this.label_CatName.Location = new System.Drawing.Point(888, 347);
            this.label_CatName.Name = "label_CatName";
            this.label_CatName.Size = new System.Drawing.Size(50, 16);
            this.label_CatName.TabIndex = 2;
            this.label_CatName.Text = "Nama :";
            // 
            // label_Details
            // 
            this.label_Details.AutoSize = true;
            this.label_Details.BackColor = System.Drawing.Color.Firebrick;
            this.label_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Details.ForeColor = System.Drawing.Color.White;
            this.label_Details.Location = new System.Drawing.Point(46, 407);
            this.label_Details.Name = "label_Details";
            this.label_Details.Size = new System.Drawing.Size(69, 20);
            this.label_Details.TabIndex = 3;
            this.label_Details.Text = "Details";
            // 
            // label_Nama
            // 
            this.label_Nama.AutoSize = true;
            this.label_Nama.Location = new System.Drawing.Point(33, 452);
            this.label_Nama.Name = "label_Nama";
            this.label_Nama.Size = new System.Drawing.Size(50, 16);
            this.label_Nama.TabIndex = 4;
            this.label_Nama.Text = "Nama :";
            // 
            // label_DetCategory
            // 
            this.label_DetCategory.AutoSize = true;
            this.label_DetCategory.Location = new System.Drawing.Point(33, 490);
            this.label_DetCategory.Name = "label_DetCategory";
            this.label_DetCategory.Size = new System.Drawing.Size(68, 16);
            this.label_DetCategory.TabIndex = 5;
            this.label_DetCategory.Text = "Category :";
            // 
            // label_Harga
            // 
            this.label_Harga.AutoSize = true;
            this.label_Harga.Location = new System.Drawing.Point(33, 529);
            this.label_Harga.Name = "label_Harga";
            this.label_Harga.Size = new System.Drawing.Size(51, 16);
            this.label_Harga.TabIndex = 6;
            this.label_Harga.Text = "Harga :";
            // 
            // label_Stock
            // 
            this.label_Stock.AutoSize = true;
            this.label_Stock.Location = new System.Drawing.Point(33, 566);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(47, 16);
            this.label_Stock.TabIndex = 7;
            this.label_Stock.Text = "Stock :";
            // 
            // txtBox_CatNama
            // 
            this.txtBox_CatNama.Location = new System.Drawing.Point(953, 341);
            this.txtBox_CatNama.Name = "txtBox_CatNama";
            this.txtBox_CatNama.Size = new System.Drawing.Size(178, 22);
            this.txtBox_CatNama.TabIndex = 8;
            // 
            // txtBox_DetNama
            // 
            this.txtBox_DetNama.Location = new System.Drawing.Point(128, 446);
            this.txtBox_DetNama.Name = "txtBox_DetNama";
            this.txtBox_DetNama.Size = new System.Drawing.Size(304, 22);
            this.txtBox_DetNama.TabIndex = 9;
            // 
            // txtBox_Harga
            // 
            this.txtBox_Harga.Location = new System.Drawing.Point(128, 523);
            this.txtBox_Harga.Name = "txtBox_Harga";
            this.txtBox_Harga.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Harga.TabIndex = 10;
            // 
            // txtBox_Stock
            // 
            this.txtBox_Stock.Location = new System.Drawing.Point(128, 560);
            this.txtBox_Stock.Name = "txtBox_Stock";
            this.txtBox_Stock.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Stock.TabIndex = 11;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Items.AddRange(new object[] {
            "Jas",
            "Sepatu",
            "Kaos",
            "Jeans",
            "Jaket"});
            this.comboBox_Category.Location = new System.Drawing.Point(128, 482);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Category.TabIndex = 12;
            // 
            // dgv_Product
            // 
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(28, 64);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 24;
            this.dgv_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Product.Size = new System.Drawing.Size(751, 299);
            this.dgv_Product.TabIndex = 13;
            this.dgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellClick);
            // 
            // dgv_Category
            // 
            this.dgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category.Location = new System.Drawing.Point(846, 64);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.RowHeadersWidth = 51;
            this.dgv_Category.RowTemplate.Height = 24;
            this.dgv_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Category.Size = new System.Drawing.Size(389, 223);
            this.dgv_Category.TabIndex = 14;
            // 
            // btn_AddCat
            // 
            this.btn_AddCat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_AddCat.Location = new System.Drawing.Point(953, 388);
            this.btn_AddCat.Name = "btn_AddCat";
            this.btn_AddCat.Size = new System.Drawing.Size(83, 61);
            this.btn_AddCat.TabIndex = 15;
            this.btn_AddCat.Text = "Add Category";
            this.btn_AddCat.UseVisualStyleBackColor = false;
            this.btn_AddCat.Click += new System.EventHandler(this.btn_AddCat_Click);
            // 
            // btn_RemoveCat
            // 
            this.btn_RemoveCat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_RemoveCat.Location = new System.Drawing.Point(1048, 388);
            this.btn_RemoveCat.Name = "btn_RemoveCat";
            this.btn_RemoveCat.Size = new System.Drawing.Size(83, 61);
            this.btn_RemoveCat.TabIndex = 16;
            this.btn_RemoveCat.Text = "Remove Category";
            this.btn_RemoveCat.UseVisualStyleBackColor = false;
            this.btn_RemoveCat.Click += new System.EventHandler(this.btn_RemoveCat_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_AddProduct.Location = new System.Drawing.Point(295, 523);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(84, 61);
            this.btn_AddProduct.TabIndex = 17;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_Remove.Location = new System.Drawing.Point(475, 523);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(84, 61);
            this.button_Remove.TabIndex = 18;
            this.button_Remove.Text = "Remove Product";
            this.button_Remove.UseVisualStyleBackColor = false;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Location = new System.Drawing.Point(385, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 61);
            this.button3.TabIndex = 19;
            this.button3.Text = "Edit Product";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_ALL
            // 
            this.btn_ALL.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_ALL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ALL.Location = new System.Drawing.Point(270, 29);
            this.btn_ALL.Name = "btn_ALL";
            this.btn_ALL.Size = new System.Drawing.Size(75, 23);
            this.btn_ALL.TabIndex = 20;
            this.btn_ALL.Text = "ALL";
            this.btn_ALL.UseVisualStyleBackColor = false;
            this.btn_ALL.Click += new System.EventHandler(this.btn_ALL_Click);
            // 
            // btn_FILTER
            // 
            this.btn_FILTER.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_FILTER.ForeColor = System.Drawing.Color.Black;
            this.btn_FILTER.Location = new System.Drawing.Point(351, 29);
            this.btn_FILTER.Name = "btn_FILTER";
            this.btn_FILTER.Size = new System.Drawing.Size(75, 23);
            this.btn_FILTER.TabIndex = 21;
            this.btn_FILTER.Text = "FILTER";
            this.btn_FILTER.UseVisualStyleBackColor = false;
            this.btn_FILTER.Click += new System.EventHandler(this.btn_FILTER_Click);
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.Enabled = false;
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Items.AddRange(new object[] {
            "Jas",
            "Sepatu",
            "Kaos",
            "Jeans",
            "Jaket"});
            this.comboBox_Filter.Location = new System.Drawing.Point(432, 28);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(117, 24);
            this.comboBox_Filter.TabIndex = 22;
            this.comboBox_Filter.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Filter_SelectionChangeCommitted);
            // 
            // pictureBox_GUCCI
            // 
            this.pictureBox_GUCCI.Image = global::HW_week_6.Properties.Resources.Gucci_logo;
            this.pictureBox_GUCCI.Location = new System.Drawing.Point(1015, 500);
            this.pictureBox_GUCCI.Name = "pictureBox_GUCCI";
            this.pictureBox_GUCCI.Size = new System.Drawing.Size(191, 182);
            this.pictureBox_GUCCI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_GUCCI.TabIndex = 23;
            this.pictureBox_GUCCI.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1265, 706);
            this.Controls.Add(this.pictureBox_GUCCI);
            this.Controls.Add(this.comboBox_Filter);
            this.Controls.Add(this.btn_FILTER);
            this.Controls.Add(this.btn_ALL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.btn_RemoveCat);
            this.Controls.Add(this.btn_AddCat);
            this.Controls.Add(this.dgv_Category);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.txtBox_Stock);
            this.Controls.Add(this.txtBox_Harga);
            this.Controls.Add(this.txtBox_DetNama);
            this.Controls.Add(this.txtBox_CatNama);
            this.Controls.Add(this.label_Stock);
            this.Controls.Add(this.label_Harga);
            this.Controls.Add(this.label_DetCategory);
            this.Controls.Add(this.label_Nama);
            this.Controls.Add(this.label_Details);
            this.Controls.Add(this.label_CatName);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_Product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GUCCI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_CatName;
        private System.Windows.Forms.Label label_Details;
        private System.Windows.Forms.Label label_Nama;
        private System.Windows.Forms.Label label_DetCategory;
        private System.Windows.Forms.Label label_Harga;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.TextBox txtBox_CatNama;
        private System.Windows.Forms.TextBox txtBox_DetNama;
        private System.Windows.Forms.TextBox txtBox_Harga;
        private System.Windows.Forms.TextBox txtBox_Stock;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.DataGridView dgv_Category;
        private System.Windows.Forms.Button btn_AddCat;
        private System.Windows.Forms.Button btn_RemoveCat;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_ALL;
        private System.Windows.Forms.Button btn_FILTER;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.PictureBox pictureBox_GUCCI;
    }
}

