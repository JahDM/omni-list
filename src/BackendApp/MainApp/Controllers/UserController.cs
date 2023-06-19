using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OmniAPI.Domain.Models;

namespace OmniAPI.Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: UserController
        [HttpGet]
        public ActionResult Index()
        {
            return Ok();
            //TODO
        }
    }
}
