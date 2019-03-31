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
    public class CategoryController : ControllerBase
    {
        ICategoryRepository repo;

        public CategoryController(ICategoryRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Category>> Get()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] Category category)
        {
            repo.Add(category);
            return true;
        }
    }
}