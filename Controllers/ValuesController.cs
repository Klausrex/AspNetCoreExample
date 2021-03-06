﻿using System;
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
            BusyWait(TimeSpan.FromSeconds(4));
            
            Globals.values.Add(Globals.values.Last() + 10);
            return Globals.values.Last().ToString();
        }
        
        private void BusyWait(TimeSpan duration)
        {
            var start = DateTime.Now;
            while (start + duration > DateTime.Now)
                ;
        }
    }
}
