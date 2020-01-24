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
        [HttpGet("next")]
        public ActionResult<string> Next()
        {
            //System.Threading.Thread.Sleep(2000);
            BusyWait(1000);
            
            var last = Globals.values.Last();
            var next = last + (int)d;
            Globals.values.Add(next);
            return Globals.values.Count.ToString();
        }
        
        private BusyWait(
    }
}
