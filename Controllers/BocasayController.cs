using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bocasay.BAL;
using Bocasay.BAL.Handlers;
using Bocasay.Model;
using Bocasay.Model.ManageData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static Bocasay.Delegate.Delegate;

namespace Bocasay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BocasayController : ControllerBase
    {     
        private readonly ILogger<BocasayController> _logger;
        private readonly IHandler handler;

        public BocasayController(ILogger<BocasayController> logger, ServiceResolver serviceResolver)
        {
            _logger = logger;
            this.handler = serviceResolver(nameof(ManageDataHandler));
        }

        [HttpPost("stored")]
        public IActionResult Stored(object param)
        {
            var test = new ManageDataRequest();
            test.Param = param;

            var respone = handler.Execute<ManageDataRequest,BaseResponse>(test);

            return Ok(respone);
        }
    }
}
