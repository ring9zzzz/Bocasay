using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bocasay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowMyOrigin")]
    public class BocasayController : ControllerBase
    {     
        private readonly ILogger<BocasayController> _logger;

        public BocasayController(ILogger<BocasayController> logger)
        {
            _logger = logger;
        }

        [HttpPost("stored")]
        public IActionResult Stored(object param)
        {
            return Ok(param);
        }
    }
}
