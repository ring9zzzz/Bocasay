using Bocasay.BAL;
using Bocasay.BAL.Handlers;
using Bocasay.Model;
using Bocasay.Model.ManageData;
using Microsoft.AspNetCore.Mvc;
using static Bocasay.Delegate.Delegate;

namespace Bocasay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BocasayController : ControllerBase
    {     
        private readonly IHandler handler;

        public BocasayController(ServiceResolver serviceResolver)
        {
            this.handler = serviceResolver(nameof(ManageDataHandler));
        }

        [HttpPost("stored")]
        public IActionResult Stored(object param)
        {
            var request = new ManageDataRequest
            {
                Param = param
            };

            var respone = handler.Execute<ManageDataRequest,BaseResponse>(request);

            return Ok(respone);
        }
    }
}
