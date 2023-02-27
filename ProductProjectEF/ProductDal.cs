using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Net.Configuration;
using System.Runtime.Remoting.Contexts;

namespace ProductProjectEF
{
    public class ProductDal
    {
        
        public List<Product> GetAll()
        {
            using (ProductsContext context = new ProductsContext())
            {
                return context.Products.ToList();
            }
            
            


                
        }
        public void Add(Product product)
        {
            using (ProductsContext context = new ProductsContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ProductsContext context = new ProductsContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            
            using (ProductsContext context = new ProductsContext())
            { 
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
            
        }
    }
}
