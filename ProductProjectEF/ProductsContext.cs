using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjectEF
{ // EntityFramework daha iyi,daha kısa kodla veri tabanaıyla bağlantı kurmayı sağlamak amacı
    public class ProductsContext:DbContext // EF Contexti olabilmesi için DbContext inherit olur.// Veri tabanı ismi olucak.
    {

        public DbSet<Product> Products { get; set; } // Veri tabanındaki tablo ismi olması lazım.

    }
}
