using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private Repository<Category> _catrqories;
        private Repository<Product> _products;
        private Repository<Order> _orders;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IRepository<Category> Categories => _catrqories ??= new Repository<Category>(_context);


        public IRepository<Product> Products => _products ??= new Repository<Product>(_context);


        public IRepository<Order> Orders => _orders ??= new Repository<Order>(_context);
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}