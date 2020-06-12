using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cw10.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    public class Enrollments : ControllerBase
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
