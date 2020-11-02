using System.ComponentModel.DataAnnotations;

namespace LiamRussell.Data.Models {
    public class SkillCategory {
        [Required]
        public string Key { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
