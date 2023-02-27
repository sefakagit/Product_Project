using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductProcet
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
            LoadProduct();
        }

        private void LoadProduct()
        {
           DgwProducts.DataSource = _productDal.GetAll();
        }

        private void DgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbxNameUpdate.Text = DgwProducts.CurrentRow.Cells[1].Value.ToString();// Bastığınız veriyi string dönüştürerek texte atar.
            TbxUnitPriceUpdate.Text = DgwProducts.CurrentRow.Cells[2].Value.ToString();
            TbxAmountUpdate.Text = DgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //DATAYA VERİ GİRME
            _productDal.Add(new Product
            {
                Name = TextBox1.Text,
                UnitPrice = Convert.ToDecimal(TextBox2.Text),
                StockAmount = Convert.ToInt32(TextBox3.Text)

            });
            LoadProduct(); // Edit ==> refactor ==> extract methood
            MessageBox.Show("Ürün eklendi"); // ürün eklendi yazısını getirir.
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(DgwProducts.CurrentRow.Cells[0].Value),
                Name = TbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(TbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(TbxAmountUpdate.Text)
            };
          _productDal.Update(product);
            LoadProduct();
            
             


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            int Id = Convert.ToInt32(DgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(Id);
            LoadProduct();
            MessageBox.Show("Kayıt silindi");
            
            
        }
    }
}
