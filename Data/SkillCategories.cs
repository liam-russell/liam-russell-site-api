using LiamRussell.Data.Models;
using System.Collections.Generic;

namespace LiamRussell.Data {
    public static class SkillCategories {
        private static readonly List<SkillCategory> all = new List<SkillCategory>();
        public static IEnumerable<SkillCategory> All => all;

        public static readonly SkillCategory Databases = Add("db", "Databases");
        public static readonly SkillCategory Cloud = Add("cloud", "Cloud");
        public static readonly SkillCategory Frontend = Add("frontend", "Front-end web development");
        public static readonly SkillCategory Backend = Add("backend", "Back-end web development");
        public static readonly SkillCategory DevOps = Add("devops", "DevOps");
        public static readonly SkillCategory Servers = Add("servers", "Server management");
        public static readonly SkillCategory ProgrammingLanguages = Add("languages", "Programming languages");
        public static readonly SkillCategory Frameworks = Add("frameworks", "Frameworks");
        public static readonly SkillCategory Management = Add("management", "Project planning and management");

        private static SkillCategory Add(string key, string name) {
            var cat = new SkillCategory {
                Key = key,
                Name = name
            };

            all.Add(cat);
            return cat;
        }
    }
}
