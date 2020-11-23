using LiamRussell.Api.Framework;
using LiamRussell.Data;
using LiamRussell.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LiamRussell.Api.Controllers {
    [Route("api/v1/skills")]
    [ApiController]
    public class SkillsController : ControllerBase {
        /// <summary>
        /// Get a list of skills
        /// </summary>
        /// <param name="categories">Limit to skills from a particular category.</param>
        /// <param name="keywords">Search skills by keyword</param>
        /// <param name="skip">For pagination, skip the first x items.</param>
        /// <param name="take">For pagination, take the next x items.</param>
        /// <returns>A list of skills</returns>
        [HttpGet("")]
        public ActionResult<Paged<Skill>> Index(
            [FromQuery] IEnumerable<string> categories,
            [FromQuery] string? keywords = null,
            [FromQuery] int skip = 0,
            [FromQuery] int take = 20
        ) => Ok(Skills.All
            .WithOptionalCategories(categories)
            .WithKeywords(keywords)
            .Paged(skip, take)
        );

        /// <summary>
        /// Find a specific skill
        /// </summary>
        /// <param name="key">The key of the skill</param>
        /// <returns>A skill</returns>
        [HttpGet("{key}")]
        public ActionResult<Skill> Get([Required] string key) {
            var skill = Skills.All.SingleOrDefault(s => s.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
            if(skill == null) {
                return NotFound();
            }
            return Ok(skill);
        }
    }
}
