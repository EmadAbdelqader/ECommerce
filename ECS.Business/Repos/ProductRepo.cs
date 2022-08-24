using ECS.DataAccess;
using ECS.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Business.Repos
{
    public class ProductRepo : IProductRepo
    {
        private readonly ApplicationContext _dc;

        public ProductRepo()
        {
            _dc = new ApplicationContext();
        }

        public void Delete(Product product)
        {
            _dc.Products.Remove(product);
            _dc.SaveChanges();
        }

        public void Delete(int productId)
        {
            var delProduct = _dc.Products.Find(productId);

            if (delProduct == null) return;

            _dc.Products.Remove(delProduct);
            _dc.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _dc.Products.ToList();
        }

        public Product? GetProduct(int productId)
        {
            return _dc.Products.Find(productId);
        }

        public int Save(Product product)
        {
            _dc.Products.Add(product);
            _dc.SaveChanges();

            return product.Id;
        }

        public int Update(Product product)
        {
            _dc.Products.Update(product);
            _dc.SaveChanges();

            return product.Id;
        }
    }
}
