using System;
using System.Collections.Generic;
using System.Linq;
using LiamRussell.Data;
using LiamRussell.Data.Models;
using LiamRussell.Api.Framework;
using LiamRussell.Api.Models.Skills;
using Microsoft.AspNetCore.Mvc;

namespace LiamRussell.Api.Controllers {
    [Route("api/v1/skills")]
    [ApiController]
    public class SkillsController : ControllerBase {
        /// <summary>
        /// Get a list of skills
        /// </summary>
        /// <param name="categories">Limit to skills from a particular category.</param>
        /// <param name="skip">For pagination, skip the first x items.</param>
        /// <param name="take">For pagination, take the next x items.</param>
        /// <returns>A list of skills</returns>
        [HttpGet("")]
        public ActionResult<IEnumerable<IndexModel>> Index([FromQuery] IEnumerable<string> categories = null, string keywords = null, int skip = 0, int take = 20) =>
            Ok(Skills.All
                .WithOptionalCategories(categories)
                .WithKeywords(keywords)
                .Paged(skip, take)
                .Select(s => new IndexModel(s))
            );

        /// <summary>
        /// Find a specific skill
        /// </summary>
        /// <param name="key">The key of the skill</param>
        /// <returns>A skill</returns>
        [HttpGet("{key}")]
        public ActionResult<Skill> Get(string key) {
            var skill = Skills.All.SingleOrDefault(s => s.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
            if(skill == null) {
                return NotFound();
            }
            return Ok(skill);
        }
    }
}
