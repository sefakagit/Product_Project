using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductProjectEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            //using (ProductsContext context = new ProductsContext())
            //{
            //    DgwProducts.DataSource = context.Products.ToList();
            //}
            LoadProducts().DataSource = _productDal.GetAll(); // producdal.GetAll dan gelen verileri DataSource atılır.
        }

        private DataGridView LoadProducts()
        {
            return DgwProducts;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            { 
            Name = tbxName.Text, 
            UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
            StockAmount = Convert.ToInt32(tbxStockAmount.Text) });
            LoadProducts();
            MessageBox.Show("ürün Eklendi");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                
                Id = Convert.ToInt32(DgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
                


            });
            
            LoadProducts();
            MessageBox.Show("ürününüz güncellendi");



        }

        private void DgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = DgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = DgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = DgwProducts.CurrentRow.Cells[3].Value.ToString();   
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id=Convert.ToInt32(DgwProducts.CurrentRow.Cells[0].Value)
               


            });
            LoadProducts();
            MessageBox.Show("ürününüz silindi");
        }
    }



   
}

