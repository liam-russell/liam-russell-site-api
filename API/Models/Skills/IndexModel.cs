using LiamRussell.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiamRussell.Api.Models.Skills {
    public class IndexModel {
        public IndexModel(Skill skill) {
            Key = skill.Key;
            Name = skill.Name;
        }
        /// <summary>
        /// A unique string identifying the skill
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// The name of the skill
        /// </summary>
        public string Name { get; }
    }
}
