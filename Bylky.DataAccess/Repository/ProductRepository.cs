﻿using Bulky.DataAccess.Data;
using Bulky.Models;
using Bylky.DataAccess.Repository.IRepository;

namespace Bylky.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
