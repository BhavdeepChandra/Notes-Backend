using Microsoft.AspNetCore.Mvc;

namespace Notebook_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotebooksController : ControllerBase
    {

        [HttpGet]
        public ActionResult<object> Get()
        {
            return null;
        }
    }
}
