﻿using Bulky.Models;
using Bulky.Models;

namespace Bylky.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
