using Microsoft.AspNetCore.Mvc;

namespace LiamRussell.Api.Controllers {
    [Route(""), ApiExplorerSettings(IgnoreApi = true)]
    public class HomeController : Controller {
        [HttpGet("")]
        public ActionResult Index() => Redirect("/docs");
    }
}
