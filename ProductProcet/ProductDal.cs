using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ProductProcet
{
    public class ProductDal
    {
        // List<Product> products;

        // List<Product> products; Data listeleme işine yarar.

        // Sql Connection hazır bir sintax yapısıdır

        //SqlConnection connection new SqlConnection yeni bir bağlantı yapmamızı sağlar
        SqlConnection _connection = new SqlConnection("server =(localdb)\\MSSQLLocalDB;initial catalog =Products;integrated security=true");
        // bağlantıyı diğer claslarda kullana bilmek için _connection olarak yazılır. sadece küçük connectionların başına _ koyulur
        public List<Product> GetAll()
        {
            // ilk servis ismi sonra veri tabanı için temel bağlantı. intial catalog veri tabanının isminin yazıldığı kısım
            // integrated security yerel bağlantı için true yapılır, false olursa uzaktan bağlanır passaword ve user ister 
            // SqlConnection _connection = new SqlConnection("server =(localdb)\\MSSQLlocalDB;inital catalog =Products;integrated security=true");

            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Products", _connection); // Veri tabanındaki dataları listeler
            SqlDataReader reader = command.ExecuteReader(); //sql den gelen datayı okumaya yarar
            List<Product> products = new List<Product>(); // okunan datayı product listesine atar
            while (reader.Read()) // satyır sonuna kadar okumak iiçin tanımlandı
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]), // reader bütün satırları alır
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])

                };

                products.Add(product);

            }
            reader.Close();
            _connection.Close();


            return products;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            // her sayfaya geçildiğinde veri tabanı açılmaması için açık olan durum var kontrolu yapılı eğer zaten veritabnı bağlantısı tekrar açılmaz. Bağlantı yoksa bağlantıyı sağlar. Varsa bağlantı devam eder.
            {
                _connection.Open();
            }
        }
        public void Add(Product product)
        {
            // DATAYA VERİ EKLEME
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Products values(@Name,@UnitPrice,@StockAmount)", _connection); // @ işareti koymak o alanları string olarak geç demek
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.ExecuteNonQuery(); // Çalıştır
            _connection.Close();
        }


        public void Update(Product product)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand
           ("Update Products set Name=@name,UnitPrice=@unitPrice,StockAmount =@stockAmount where Id =@Id", _connection); // @ işareti koymak o alanları string olarak geç demek
            command.Parameters.AddWithValue("@name", product.Name);// texten gelen name değerini @name parametresine atarr
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Id", product.Id);
            
            command.ExecuteNonQuery(); // Birden çok satırı Çalıştır
            _connection.Close();

        }
        public void Delete(int Id)
        {
            
            ConnectionControl();
            SqlCommand command = new SqlCommand
            ("Delete from Products where Id =@Id", _connection);
            command.Parameters.AddWithValue("@Id", Id);

            command.ExecuteNonQuery();
            _connection.Close();
        }


    }
}
