using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Controllers
{
    public class SampleControler : Controller
    {
        // GET api/sample/load
        [HttpGet]
        [Authorize(Roles = "admin,manager")]
        public ActionResult<IEnumerable<string>> Load()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/sample/loadone/{id}
        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<string> LoadOne(int id)
        {
            return "value";
        }
    }
}
