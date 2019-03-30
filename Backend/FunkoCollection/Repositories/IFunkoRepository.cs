using FunkoCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunkoCollection.Repositories
{
    public interface IFunkoRepository
    {
        List<Funko> GetAll();
        void Add(Funko funko);
    }
}
