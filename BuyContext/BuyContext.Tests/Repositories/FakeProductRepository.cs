using System;
using System.Collections.Generic;
using BuyContext.Domain.Entities;
using BuyContext.Domain.Repositories.Interfaces;

namespace BuyContext.Tests.Repositories
{
    public class FakeProductRepository : IProductRepository
    {

        public IEnumerable<Product> Get(IEnumerable<Guid> ids)
        {
            IList<Product> products = new List<Product>();
            products.Add(new Product("Produto 01", 5, 3));
            products.Add(new Product("Produto 02", 5, 3));
            products.Add(new Product("Produto 03", 5, 3));
            products.Add(new Product("Produto 04", 5, 1));
            products.Add(new Product("Produto 05", 5, 1));

            return products;
        }
    }
}