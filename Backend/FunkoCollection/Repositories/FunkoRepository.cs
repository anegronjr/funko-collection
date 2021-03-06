﻿using FunkoCollection.Models;
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

        public Funko GetById(int id)
        {
            return db.Funkos.Single(funko => funko.FunkoId == id);
        }

        public void Add(Funko funko)
        {
            db.Funkos.Add(funko);
            db.SaveChanges();
        }

        public void Edit(Funko funko)
        {
            db.Update(funko);
            db.SaveChanges();
        }

        public void Delete(Funko funko)
        {
            db.Remove(funko);
            db.SaveChanges();
        }
    }
}
