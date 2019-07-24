using LiamRussell.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LiamRussell.Tests {
    public class SkillsFacts {
        [Fact]
        public static void No_Duplicate_Skills_Keys() => AssertNoDuplicateKeys(Skills.All, c => c.Key);

        [Fact]
        public static void No_Duplicate_SkillCategory_Keys() => AssertNoDuplicateKeys(SkillCategories.All, c => c.Key);

        [Fact]
        public static void All_Skill_Relationships_Resolve_And_Are_Bidirectional() {
            var exceptions = new List<Exception>();
            foreach(var skill in Skills.All) {
                if(skill.RelatedSkillKeys?.Any() == true) {
                    foreach(var related in skill.RelatedSkillKeys) {
                        var resolvedRelation = Skills.All.SingleOrDefault(s => s.Key == related);
                        if(resolvedRelation == null) {
                            exceptions.Add(new KeyNotFoundException($"Skill '{skill.Key}' contains a reference to '{related}', but skill '{related}' does not exist."));
                        } else if(resolvedRelation?.RelatedSkillKeys?.Contains(skill.Key) != true) {
                            exceptions.Add(new KeyNotFoundException($"Expected skill '{related}' to contain a reference to '{skill.Key}' but it did not."));
                        }
                    }
                }
            }

            if(exceptions.Any()) {
                throw new AggregateException(exceptions);
            }
        }

        private static void AssertNoDuplicateKeys<T>(IEnumerable<T> items, Func<T, string> keySelector) =>
            Assert.DoesNotContain(items.GroupBy(keySelector, StringComparer.OrdinalIgnoreCase), a => a.Count() > 1);
    }
}
