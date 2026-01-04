using Assignment.DAL.Interface;
using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BLL.Services
{
    public class ProductService
    {
        private readonly IProductRepository _Repository;

        public ProductService(IProductRepository repository)
        {
           _Repository = repository;
        }

        public Task<List<Product>> GetAllAsync()
            => _Repository.GetAllAsync();

        public Task<Product?> GetByIdAsync(int id)
            => _Repository.GetByIdAsync(id);

        public Task AddAsync(Product product)
            => _Repository.AddAsync(product);

        public Task UpdateAsync(Product product)
            => _Repository.UpdateAsync(product);

        public Task DeleteAsync(int id)
            => _Repository.DeleteAsync(id);
    }
}
