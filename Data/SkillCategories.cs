using LiamRussell.Data.Models;
using System.Collections.Generic;

namespace LiamRussell.Data {
    public static class SkillCategories {
        private static readonly List<SkillCategory> all = new List<SkillCategory>();
        public static IEnumerable<SkillCategory> All => all;

        public static SkillCategory Databases = Add("db", "Databases");
        public static SkillCategory Cloud = Add("cloud", "Cloud");
        public static SkillCategory Frontend = Add("frontend", "Front-end web development");
        public static SkillCategory Backend = Add("backend", "Back-end web development");
        public static SkillCategory DevOps = Add("devops", "DevOps");
        public static SkillCategory Servers = Add("servers", "Server management");
        public static SkillCategory ProgrammingLanguages = Add("languages", "Programming languages");
        public static SkillCategory Frameworks = Add("frameworks", "Frameworks");
        public static SkillCategory Management = Add("management", "Project planning and management");

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
