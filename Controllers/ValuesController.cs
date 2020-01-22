using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/GetLastAndAddNextToList
        [HttpGet("getlast")]
        public ActionResult<string> GetLastAndAddNextToList()
        {
            var last = Globals.values.Last();
            Globals.values.Add(++last);
            return last.ToString();
        }
    }
}
