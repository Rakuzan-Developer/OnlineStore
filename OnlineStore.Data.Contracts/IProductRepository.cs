using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Data.Contracts
{
    public interface IProductRepository : IRepository<Product,int>
    {
    }
}
