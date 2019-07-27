using LiamRussell.Data;
using LiamRussell.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LiamRussell.Api.Controllers {
    [Route("api/v1/skillcategories")]
    [ApiController]
    public class SkillCategoriesController : ControllerBase {
        /// <summary>
        /// List available skill categories
        /// </summary>
        [HttpGet("")]
        public ActionResult<IEnumerable<SkillCategory>> Index() => Ok(SkillCategories.All);
    }
}
