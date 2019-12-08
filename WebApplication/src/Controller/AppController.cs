using Microsoft.AspNetCore.Mvc;
using WebApplication.Service;

namespace WebApplication.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppController: ControllerBase
    {
        private readonly AppService _appService;

        public AppController(AppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public ActionResult SayHello()
        {
            return new OkObjectResult(new
            {
                message = _appService.SayHello()
            } );
        }
    }
}