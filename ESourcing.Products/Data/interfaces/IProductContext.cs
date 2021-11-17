using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Data.interfaces
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
