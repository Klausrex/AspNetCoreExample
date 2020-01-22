using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private List<int> values;

        ValuesController()
        {
            values = new List<int>();
        }

        // GET api/GetLastAndAddNextToList
        [HttpGet]
        public int GetLastAndAddNextToList()
        {
            var last = values.Last();
            values.Add(last++);
            return last;
        }
    }
}
