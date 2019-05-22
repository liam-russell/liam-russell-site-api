using LiamRussell.Data;
using Microsoft.AspNetCore.Mvc;

namespace LiamRussell.Api.Controllers {
    [Route("api/v1/skillcategories")]
    [ApiController]
    public class SkillCategoriesController : ControllerBase {
        [HttpGet("")]
        public ActionResult Index() => Ok(SkillCategories.All);
    }
}
