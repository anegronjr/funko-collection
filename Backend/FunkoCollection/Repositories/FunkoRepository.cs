using FunkoCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunkoCollection.Repositories
{
    public class FunkoRepository : IFunkoRepository
    {
        FunkoContext db;

        public FunkoRepository(FunkoContext db)
        {
            this.db = db;
        }

        public List<Funko> GetAll()
        {
            return db.Funkos.ToList();
        }

        public void Add(Funko funko)
        {
            db.Funkos.Add(funko);
            db.SaveChanges();
        }
    }
}
