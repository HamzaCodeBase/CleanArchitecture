using Application.Misc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MiscController : ControllerBase
    {
        [HttpGet]
        public string GetWorkerProcessName()
        {
            return Misc.GetWorkerProcessName();
        }
    }
}
