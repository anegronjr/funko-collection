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
        IFunkoRepository funkoRepo;

        public FunkoController(IFunkoRepository funkoRepo)
        {
            this.funkoRepo = funkoRepo;
        }

        [HttpGet]
        public ActionResult<List<Funko>> Get()
        {
            return funkoRepo.GetAll();
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] Funko funko)
        {
            funkoRepo.Add(funko);
            return true;
        }
    }
}