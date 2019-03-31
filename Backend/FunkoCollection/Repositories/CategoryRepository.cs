using FunkoCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunkoCollection.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        FunkoContext db;

        public CategoryRepository(FunkoContext db)
        {
            this.db = db;
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public void Add(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }
    }
}
