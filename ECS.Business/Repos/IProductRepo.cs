using ECS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Business.Repos
{
    interface IProductRepo
    {
        Product? GetProduct(int productId);

        List<Product> GetAll();

        int Save(Product product);

        int Update(Product product);

        void Delete(Product product);

        void Delete(int productId);
    }
}
