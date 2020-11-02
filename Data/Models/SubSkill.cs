using System.ComponentModel.DataAnnotations;

namespace LiamRussell.Data.Models {
    public class SubSkill {
        private static readonly UrlAttribute UrlValidator = new UrlAttribute();
        public SubSkill(string name, string url) {
            if(!UrlValidator.IsValid(url)) {
                throw new ValidationException($"{url} is not a valid URL");
            }

            Name = name;
            Url = url;
        }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required, Url]
        public string Url { get; set; } = string.Empty;
    }
}
