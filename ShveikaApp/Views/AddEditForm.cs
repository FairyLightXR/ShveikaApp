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
            }
            else
            {
                productBindingSource.Add(product);
                if (product.ProductPhoto.Length > 0)
                {
                    productPhotoPictureBox.ImageLocation =
                }
                else
                {
                    product.ProductPhoto = 
                }


            }
        }

        private void ImagePicBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
