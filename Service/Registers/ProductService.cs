﻿
using Models.Register;
using Persistences.Dall.Registers;
using System.Linq;

namespace Service.Registration
{
    public class ProductService
    {
        private ProductDall dal = new ProductDall();
        public IQueryable<Product> GetProductsOrderByForName()
        {
            return dal.GetProductsOrdereByForName();
        }
        public Product GetProductById(long id)
        {
            return dal.GetProductForId(id);
        }
        public void SaveProduct(Product product)
        {
            dal.SaveProduct(product);
        }
        public Product DeleteProductForId(long id)
        {
            return dal.DeleteProductForId(id);
        }
    }
}
