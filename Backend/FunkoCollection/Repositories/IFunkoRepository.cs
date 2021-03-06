﻿using FunkoCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunkoCollection.Repositories
{
    public interface IFunkoRepository
    {
        List<Funko> GetAll();
        Funko GetById(int id);
        void Add(Funko funko);
        void Edit(Funko funko);
        void Delete(Funko funko);
    }
}
