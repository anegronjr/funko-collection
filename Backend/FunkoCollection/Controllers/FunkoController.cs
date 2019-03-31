using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunkoCollection.Models;
using FunkoCollection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FunkoCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunkoController : ControllerBase
    {
        IFunkoRepository repo;

        public FunkoController(IFunkoRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Funko>> Get()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] Funko funko)
        {
            repo.Add(funko);
            return true;
        }

        [HttpPost("{id}")]
        public ActionResult<bool> Post(int id, [FromBody] Funko funko)
        {
            repo.Edit(funko);
            return true;
        }
    }
}