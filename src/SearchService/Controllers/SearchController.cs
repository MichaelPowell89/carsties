using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SearchService.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class SearchController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Item>> YourActionMethodNameHere()
        {
            
        }
    }
}
