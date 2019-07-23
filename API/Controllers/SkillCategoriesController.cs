using LiamRussell.Data;
using Microsoft.AspNetCore.Mvc;

namespace LiamRussell.Api.Controllers {
    [Route("api/v1/skillcategories")]
    [ApiController]
    public class SkillCategoriesController : ControllerBase {
        /// <summary>
        /// List available skill categories
        /// </summary>
        [HttpGet("")]
        public ActionResult Index() => Ok(SkillCategories.All);
    }
}
