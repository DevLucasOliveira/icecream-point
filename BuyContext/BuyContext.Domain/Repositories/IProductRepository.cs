using System;
using System.Collections.Generic;
using BuyContext.Domain.Entities;

namespace BuyContext.Domain.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get(IEnumerable<Guid> ids);
    }
}