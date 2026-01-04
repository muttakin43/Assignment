using Assignment.DAL.Context;
using Assignment.DAL.Interface;
using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DAL.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly AssignDbContext _context;
       

        public ProductRepository(AssignDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
