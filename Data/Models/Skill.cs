using System.Collections.Generic;

namespace LiamRussell.Data.Models {
    public class Skill {
        /// <summary>
        /// The primary key for the skill
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// A short skill name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Categories the skill falls under
        /// </summary>
        public IEnumerable<SkillCategory> Categories { get; set; }
        /// <summary>
        /// A link to find more information about the skill
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// An optional description explaining my knowledge of this skill
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Sub items (think of bullet points) for a given skill
        /// </summary>
        public IEnumerable<SubSkill> SubSkills { get; set; }
        /// <summary>
        /// A gauge to my proficiency with this skill
        /// </summary>
        public Proficiency Proficiency { get; set; }
        /// <summary>
        /// If there are any skills which conceptually relate to this skill, their keys go here
        /// </summary>
        public IEnumerable<string> RelatedSkillKeys { get; set; }
    }
}