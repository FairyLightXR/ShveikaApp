using ShveikaApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShveikaApp.Views.UserCtrl
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

       public void GenerateProductCard(Product prod)
        {
            TitleLbl.Text = prod.ProductName;
            DescrTxt.Text = prod.ProductDescription;
            CostLbl.Text = $"{Math.Round(prod.ProductCost, 2)} руб";
            ManufacturerLbl.Text = prod.ProductManufacturer;
            DiscountLbl.Text = $"{prod.ProductDiscountAmount} %";
            if (prod.ProductPhoto.Length > 0)
            {
                ProductPic.ImageLocation = $@".\Products\{prod.ProductPhoto}";
            }
            if (prod.ProductDiscountAmount > 15)
            {
                DiscountLbl.BackColor = Color.Chartreuse;
            }
        }
    }
}
