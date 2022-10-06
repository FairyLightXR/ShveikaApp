using ShveikaApp.Model;
using ShveikaApp.Utils;
using ShveikaApp.Views;
using ShveikaApp.Views.UserCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShveikaApp
{
    public partial class MainForm : Form
    {
        List<Product> products = new List<Product>();
        public MainForm()
        {
            InitializeComponent();
            products = DbContext.Context.Product.ToList();
            Sortcmb.SelectedIndex = 0;
            FiltrCmb.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerateProductsCards(products);
        }
        public void GenerateProductsCards(List<Product> products)
        {
            ProdLayoutPanel.Controls.Clear();
            foreach (var pr in products )
            {
                ProductCard card = new ProductCard();
                card.GenerateProductCard(pr);
                ProdLayoutPanel.Controls.Add(card);
                card.DoubleClick += Card_DoubleClick;
            }
            
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            ProductCard card = sender as ProductCard;
            AddEditForm edd = new AddEditForm(DbContext.Context.Product.First(puk => puk.ProductArticleNumber == card.IDLbl.Text));
            DialogResult dr = edd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                SearchFiltrSort();
            }
        }

        

        public void SearchFiltrSort()
        {
            List<Product> ListUpdate = DbContext.Context.Product.ToList();
            #region Searching

            if (SearchTxt.Text !="" && SearchTxt.Text !="Введите для поиска")
            {
                ListUpdate = ListUpdate.Where(s => s.ProductName.ToLower().Contains(SearchTxt.Text.ToLower())).ToList();
            }
            #endregion

            #region Sorting

            if (Sortcmb.SelectedIndex>0)
            {
                if (DescChk.Checked)
                {
                    ListUpdate = ListUpdate.OrderByDescending(o => o.ProductCost).ToList();
                }
                else
                {
                    ListUpdate = ListUpdate.OrderBy(s => s.ProductCost).ToList();
                }
            }

            #endregion

            #region Filtr
            switch (FiltrCmb.SelectedIndex)
            {
                case 1:
                   ListUpdate = ListUpdate.Where(i => i.ProductDiscountAmount <= 9.99).ToList();
                    break;
                case 2:
                   ListUpdate = ListUpdate.Where(i => i.ProductDiscountAmount >= 10 && i.ProductDiscountAmount <=14.99).ToList();
                    break;
                case 3:
                   ListUpdate = ListUpdate.Where(i => i.ProductDiscountAmount >= 15).ToList();
                    break;

            }
            #endregion

            ProdCountLbl.Text = ListUpdate.Count + " из " + products.Count.ToString();
            GenerateProductsCards(ListUpdate);
        }


        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            SearchFiltrSort();
        }

        private void SearchTxt_MouseClick(object sender, MouseEventArgs e)
        {
            SearchTxt.Text = "";
        }

        private void Sortcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFiltrSort();
        }

        private void FiltrCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFiltrSort();
        }

        private void DescChk_CheckedChanged(object sender, EventArgs e)
        {
            SearchFiltrSort();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEditForm add = new AddEditForm(null);
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.OK)
            {
                SearchFiltrSort();
            }

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
