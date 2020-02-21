using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Repository : IRepository
    {
        private List<Product> products;

        public Repository()
        {
            products = new List<Product>();
            new List<Product>
            {
                new Product { Name = "Basketball", Price = 2.99M},
                new Product { Name = "Shirt", Price = 4.99M},
                new Product { Name = "Pants", Price = 15.99M}
            }.ForEach(x => AddProduct(x));
        }

        public IEnumerable<Product> Products => products;

        public void AddProduct(Product product) => products.Add(product);

        public void DeleteProduct(Product product) => products.Remove(product);

    }
}
