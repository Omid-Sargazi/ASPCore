using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Category> Categories { get; }
        IRepository<Product> Products { get; }
        IRepository<Order> Orders { get; }
        Task SaveChangesAsync();
    }
}