using LiamRussell.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LiamRussell.Data {
    public static class SkillExtensions {
        public static IEnumerable<Skill> WithOptionalCategories(this IEnumerable<Skill> skills, IEnumerable<string> categoryKeys) {
            if(categoryKeys == null || !categoryKeys.Any()) {
                return skills;
            }

            return skills.Where(s =>
                categoryKeys.All(ck =>
                    s.Categories.Any(sc =>
                        sc.Key.Equals(ck, StringComparison.OrdinalIgnoreCase)
                    )
                )
            );
        }


        public static IEnumerable<Skill> WithKeywords(this IEnumerable<Skill> skills, string? keywords) {
            if(string.IsNullOrWhiteSpace(keywords)) {
                return skills;
            }

            var kw = keywords.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            bool skillSearchExpr(Skill s) =>
                s.Key?.Search(kw) == true
                || s.Name?.Search(kw) == true
                || s.Description?.Search(kw) == true
                || s.Categories?.Any(c => c.Key?.Search(kw) == true || c.Name?.Search(kw) == true) == true
                || s.SubSkills?.Any(ss => ss.Name?.Search(kw) == true || ss.Url?.Search(kw) == true) == true
                || s.Proficiency.ToString().Search(kw);


            return skills.Where(skillSearchExpr);
        }

        private static bool Search(this string @search, IEnumerable<string> @for) =>
            @for.Any(k => @search.IndexOf(k, StringComparison.OrdinalIgnoreCase) > 0);
    }
}
