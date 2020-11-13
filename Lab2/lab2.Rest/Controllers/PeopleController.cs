using lab2.Rest.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab2.Rest.Controllers
{
    [ApiController]
    [Route("[api/people]")]
    class PeopleController : ControllerBase
    {
        private readonly AzureDbContext db;
        public PeopleController(AzureDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.People);
        }

    }
}
