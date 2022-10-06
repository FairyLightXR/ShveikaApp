using ShveikaApp.Model;
using ShveikaApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShveikaApp.Views
{
    public partial class AddEditForm : Form
    {

        Product product { get; set; } = null;
        public AddEditForm(Product current)
        {
            InitializeComponent();
            if (current != null)
            {
                product = current;

            }
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            supplierBindingSource.DataSource = DbContext.Context.Supplier.ToList();

            
            if (product == null)
            {
                productBindingSource.AddNew();
                product = new Product();
                productArticleNumberTextBox.Enabled = true;
            }
            else
            {
                productBindingSource.Add(product);
                if (product.ProductPhoto.Length > 0)
                {
                    
                    productPhotoPictureBox.ImageLocation = $@".\Products\" + product.ProductPhoto;
                }
                else
                {
                    product.ProductPhoto = $@"..\..\Images\picture.png";
                    productPhotoPictureBox.ImageLocation = product.ProductPhoto;
                }

                product.ProductCost = Math.Round(product.ProductCost, 2);
            }
        }

        private void ImagePicBtn_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = $@"{path}\Products\";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file;
                int index;
                file = ofd.FileName;
                index = file.IndexOf("Products");
                productPhotoPictureBox.ImageLocation = $@"{file.Substring(index)}";
                file = file.Substring(index+9);
                product.ProductPhoto = file;

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (productArticleNumberTextBox.Enabled)
            {
                foreach ( var item in )
                {

                }
                if (DbContext.Context.Product.First( a => a.ProductArticleNumber.ToLower() == ((Product)productBindingSource.Current).ProductArticleNumber.ToLower()) !=null )
                {
                    MessageBox.Show("Текущий артикул существует");
                    return;
                }
                productBindingSource.Add(product);
            }
            if (product.ProductPhoto == $@"..\..\Images\picture.png")
            {
                product.ProductPhoto = null;
            }

            try
            {
              DbContext.Context.SaveChanges();
                MessageBox.Show("Сохранение прошло успешно!", "Сохранение продукта");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
