namespace ShveikaApp.Views
{
    partial class AddEditForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productArticleNumberLabel;
            System.Windows.Forms.Label productCategoryLabel;
            System.Windows.Forms.Label productCostLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            System.Windows.Forms.Label productDiscountAmountLabel;
            System.Windows.Forms.Label productManufacturerLabel;
            System.Windows.Forms.Label productMaxDiscountLabel;
            System.Windows.Forms.Label productMeasureLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productQuantityInStockLabel;
            System.Windows.Forms.Label productSupplierIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            this.productArticleNumberTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.productCostTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productDiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.productManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.productMaxDiscountTextBox = new System.Windows.Forms.TextBox();
            this.productMeasureTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.productQuantityInStockTextBox = new System.Windows.Forms.TextBox();
            this.productSupplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImagePicBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            productArticleNumberLabel = new System.Windows.Forms.Label();
            productCategoryLabel = new System.Windows.Forms.Label();
            productCostLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            productDiscountAmountLabel = new System.Windows.Forms.Label();
            productManufacturerLabel = new System.Windows.Forms.Label();
            productMaxDiscountLabel = new System.Windows.Forms.Label();
            productMeasureLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productQuantityInStockLabel = new System.Windows.Forms.Label();
            productSupplierIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productArticleNumberLabel
            // 
            productArticleNumberLabel.AutoSize = true;
            productArticleNumberLabel.Location = new System.Drawing.Point(222, 169);
            productArticleNumberLabel.Name = "productArticleNumberLabel";
            productArticleNumberLabel.Size = new System.Drawing.Size(124, 18);
            productArticleNumberLabel.TabIndex = 1;
            productArticleNumberLabel.Text = "Артикул продукта:";
            // 
            // productArticleNumberTextBox
            // 
            this.productArticleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductArticleNumber", true));
            this.productArticleNumberTextBox.Enabled = false;
            this.productArticleNumberTextBox.Location = new System.Drawing.Point(354, 161);
            this.productArticleNumberTextBox.Name = "productArticleNumberTextBox";
            this.productArticleNumberTextBox.Size = new System.Drawing.Size(121, 26);
            this.productArticleNumberTextBox.TabIndex = 2;
            // 
            // productCategoryLabel
            // 
            productCategoryLabel.AutoSize = true;
            productCategoryLabel.Location = new System.Drawing.Point(20, 241);
            productCategoryLabel.Name = "productCategoryLabel";
            productCategoryLabel.Size = new System.Drawing.Size(137, 18);
            productCategoryLabel.TabIndex = 3;
            productCategoryLabel.Text = "Категория продукта:";
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCategory", true));
            this.productCategoryTextBox.Location = new System.Drawing.Point(199, 238);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(121, 26);
            this.productCategoryTextBox.TabIndex = 4;
            // 
            // productCostLabel
            // 
            productCostLabel.AutoSize = true;
            productCostLabel.Location = new System.Drawing.Point(20, 272);
            productCostLabel.Name = "productCostLabel";
            productCostLabel.Size = new System.Drawing.Size(104, 18);
            productCostLabel.TabIndex = 5;
            productCostLabel.Text = "Цена продукта:";
            // 
            // productCostTextBox
            // 
            this.productCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCost", true));
            this.productCostTextBox.Location = new System.Drawing.Point(199, 269);
            this.productCostTextBox.Name = "productCostTextBox";
            this.productCostTextBox.Size = new System.Drawing.Size(121, 26);
            this.productCostTextBox.TabIndex = 6;
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new System.Drawing.Point(20, 303);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(135, 18);
            productDescriptionLabel.TabIndex = 7;
            productDescriptionLabel.Text = "Описание продукта:";
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductDescription", true));
            this.productDescriptionTextBox.Location = new System.Drawing.Point(199, 300);
            this.productDescriptionTextBox.Multiline = true;
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(206, 62);
            this.productDescriptionTextBox.TabIndex = 8;
            // 
            // productDiscountAmountLabel
            // 
            productDiscountAmountLabel.AutoSize = true;
            productDiscountAmountLabel.Location = new System.Drawing.Point(20, 377);
            productDiscountAmountLabel.Name = "productDiscountAmountLabel";
            productDiscountAmountLabel.Size = new System.Drawing.Size(164, 18);
            productDiscountAmountLabel.TabIndex = 9;
            productDiscountAmountLabel.Text = "Размер скидки продукта:";
            // 
            // productDiscountAmountTextBox
            // 
            this.productDiscountAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductDiscountAmount", true));
            this.productDiscountAmountTextBox.Location = new System.Drawing.Point(199, 374);
            this.productDiscountAmountTextBox.Name = "productDiscountAmountTextBox";
            this.productDiscountAmountTextBox.Size = new System.Drawing.Size(121, 26);
            this.productDiscountAmountTextBox.TabIndex = 10;
            // 
            // productManufacturerLabel
            // 
            productManufacturerLabel.AutoSize = true;
            productManufacturerLabel.Location = new System.Drawing.Point(20, 410);
            productManufacturerLabel.Name = "productManufacturerLabel";
            productManufacturerLabel.Size = new System.Drawing.Size(172, 18);
            productManufacturerLabel.TabIndex = 11;
            productManufacturerLabel.Text = "Производитель продукта:";
            // 
            // productManufacturerTextBox
            // 
            this.productManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductManufacturer", true));
            this.productManufacturerTextBox.Location = new System.Drawing.Point(199, 407);
            this.productManufacturerTextBox.Name = "productManufacturerTextBox";
            this.productManufacturerTextBox.Size = new System.Drawing.Size(121, 26);
            this.productManufacturerTextBox.TabIndex = 12;
            // 
            // productMaxDiscountLabel
            // 
            productMaxDiscountLabel.AutoSize = true;
            productMaxDiscountLabel.Location = new System.Drawing.Point(20, 447);
            productMaxDiscountLabel.Name = "productMaxDiscountLabel";
            productMaxDiscountLabel.Size = new System.Drawing.Size(149, 18);
            productMaxDiscountLabel.TabIndex = 13;
            productMaxDiscountLabel.Text = "Максимальная скидка:";
            // 
            // productMaxDiscountTextBox
            // 
            this.productMaxDiscountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductMaxDiscount", true));
            this.productMaxDiscountTextBox.Location = new System.Drawing.Point(199, 439);
            this.productMaxDiscountTextBox.Name = "productMaxDiscountTextBox";
            this.productMaxDiscountTextBox.Size = new System.Drawing.Size(121, 26);
            this.productMaxDiscountTextBox.TabIndex = 14;
            // 
            // productMeasureLabel
            // 
            productMeasureLabel.AutoSize = true;
            productMeasureLabel.Location = new System.Drawing.Point(20, 478);
            productMeasureLabel.Name = "productMeasureLabel";
            productMeasureLabel.Size = new System.Drawing.Size(137, 18);
            productMeasureLabel.TabIndex = 15;
            productMeasureLabel.Text = "Единица измерения:";
            // 
            // productMeasureTextBox
            // 
            this.productMeasureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductMeasure", true));
            this.productMeasureTextBox.Location = new System.Drawing.Point(199, 475);
            this.productMeasureTextBox.Name = "productMeasureTextBox";
            this.productMeasureTextBox.Size = new System.Drawing.Size(121, 26);
            this.productMeasureTextBox.TabIndex = 16;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(20, 206);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(132, 18);
            productNameLabel.TabIndex = 17;
            productNameLabel.Text = "Название продукта:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(199, 203);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(121, 26);
            this.productNameTextBox.TabIndex = 18;
            // 
            // productPhotoPictureBox
            // 
            this.productPhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "ProductPhoto", true));
            this.productPhotoPictureBox.Location = new System.Drawing.Point(499, 206);
            this.productPhotoPictureBox.Name = "productPhotoPictureBox";
            this.productPhotoPictureBox.Size = new System.Drawing.Size(173, 168);
            this.productPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPhotoPictureBox.TabIndex = 20;
            this.productPhotoPictureBox.TabStop = false;
            // 
            // productQuantityInStockLabel
            // 
            productQuantityInStockLabel.AutoSize = true;
            productQuantityInStockLabel.Location = new System.Drawing.Point(20, 512);
            productQuantityInStockLabel.Name = "productQuantityInStockLabel";
            productQuantityInStockLabel.Size = new System.Drawing.Size(127, 18);
            productQuantityInStockLabel.TabIndex = 21;
            productQuantityInStockLabel.Text = "Остаток на складе:";
            // 
            // productQuantityInStockTextBox
            // 
            this.productQuantityInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductQuantityInStock", true));
            this.productQuantityInStockTextBox.Location = new System.Drawing.Point(199, 509);
            this.productQuantityInStockTextBox.Name = "productQuantityInStockTextBox";
            this.productQuantityInStockTextBox.Size = new System.Drawing.Size(121, 26);
            this.productQuantityInStockTextBox.TabIndex = 22;
            // 
            // productSupplierIDLabel
            // 
            productSupplierIDLabel.AutoSize = true;
            productSupplierIDLabel.Location = new System.Drawing.Point(20, 547);
            productSupplierIDLabel.Name = "productSupplierIDLabel";
            productSupplierIDLabel.Size = new System.Drawing.Size(134, 18);
            productSupplierIDLabel.TabIndex = 23;
            productSupplierIDLabel.Text = "Product Supplier ID:";
            // 
            // productSupplierIDComboBox
            // 
            this.productSupplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductSupplierID", true));
            this.productSupplierIDComboBox.DataSource = this.supplierBindingSource;
            this.productSupplierIDComboBox.DisplayMember = "SupplierName";
            this.productSupplierIDComboBox.FormattingEnabled = true;
            this.productSupplierIDComboBox.Location = new System.Drawing.Point(199, 544);
            this.productSupplierIDComboBox.Name = "productSupplierIDComboBox";
            this.productSupplierIDComboBox.Size = new System.Drawing.Size(121, 26);
            this.productSupplierIDComboBox.TabIndex = 24;
            this.productSupplierIDComboBox.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ShveikaApp.Model.Product);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(ShveikaApp.Model.Supplier);
            // 
            // ImagePicBtn
            // 
            this.ImagePicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(205)))));
            this.ImagePicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImagePicBtn.ForeColor = System.Drawing.Color.White;
            this.ImagePicBtn.Location = new System.Drawing.Point(527, 380);
            this.ImagePicBtn.Name = "ImagePicBtn";
            this.ImagePicBtn.Size = new System.Drawing.Size(111, 37);
            this.ImagePicBtn.TabIndex = 25;
            this.ImagePicBtn.Text = "Выбрать фото";
            this.ImagePicBtn.UseVisualStyleBackColor = false;
            this.ImagePicBtn.Click += new System.EventHandler(this.ImagePicBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 128);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 69);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "ИС \"Швейка\"";
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 657);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ImagePicBtn);
            this.Controls.Add(productArticleNumberLabel);
            this.Controls.Add(this.productArticleNumberTextBox);
            this.Controls.Add(productCategoryLabel);
            this.Controls.Add(this.productCategoryTextBox);
            this.Controls.Add(productCostLabel);
            this.Controls.Add(this.productCostTextBox);
            this.Controls.Add(productDescriptionLabel);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(productDiscountAmountLabel);
            this.Controls.Add(this.productDiscountAmountTextBox);
            this.Controls.Add(productManufacturerLabel);
            this.Controls.Add(this.productManufacturerTextBox);
            this.Controls.Add(productMaxDiscountLabel);
            this.Controls.Add(this.productMaxDiscountTextBox);
            this.Controls.Add(productMeasureLabel);
            this.Controls.Add(this.productMeasureTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productPhotoPictureBox);
            this.Controls.Add(productQuantityInStockLabel);
            this.Controls.Add(this.productQuantityInStockTextBox);
            this.Controls.Add(productSupplierIDLabel);
            this.Controls.Add(this.productSupplierIDComboBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditForm";
            this.Text = "Форма изменения и добавления продуктов ИС \"Швейка\"";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox productArticleNumberTextBox;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.TextBox productCostTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productDiscountAmountTextBox;
        private System.Windows.Forms.TextBox productManufacturerTextBox;
        private System.Windows.Forms.TextBox productMaxDiscountTextBox;
        private System.Windows.Forms.TextBox productMeasureTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.PictureBox productPhotoPictureBox;
        private System.Windows.Forms.TextBox productQuantityInStockTextBox;
        private System.Windows.Forms.ComboBox productSupplierIDComboBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button ImagePicBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}