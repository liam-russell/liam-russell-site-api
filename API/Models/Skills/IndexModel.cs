using LiamRussell.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace LiamRussell.Api.Models.Skills {
    public class IndexModel {
        public IndexModel(Skill skill) {
            Key = skill.Key;
            Name = skill.Name;
        }

        /// <summary>
        /// A unique string identifying the skill
        /// </summary>
        [Required]
        public string Key { get; set; }

        /// <summary>
        /// The name of the skill
        /// </summary>
        [Required]
        public string Name { get; }
    }
}
