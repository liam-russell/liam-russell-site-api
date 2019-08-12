using LiamRussell.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace LiamRussell.Data {
    public static class SkillCategoryExtensions {
        public static IEnumerable<string> GetKeys(this IEnumerable<SkillCategory> categories) =>
            categories.Select(c => c.Key);
    }
}
