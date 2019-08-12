using LiamRussell.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LiamRussell.Tests {
    public class SkillExtensionsFacts {
        [Fact]
        public void WithOptionalCategories_Filters_Single() {
            Parallel.ForEach(SkillCategories.All, cat => {
                var filtered = Skills.All.WithOptionalCategories(new[] { cat.Key });
                Assert.All(filtered, skill => {
                    Assert.Contains(cat.Key, skill.Categories.GetKeys());
                });
            });
        }

        [Fact]
        public void WithOptionalCategories_Filters_Multiple() {
            var filtered = Skills.All.WithOptionalCategories(new[] {
                SkillCategories.Backend.Key,
                SkillCategories.Frontend.Key
            });
            Assert.All(filtered, skill => {
                Assert.True(
                    skill.Categories.GetKeys().Contains(SkillCategories.Backend.Key)
                    || skill.Categories.GetKeys().Contains(SkillCategories.Frontend.Key)
                );
            });
        }
    }
}
