using System;
using System.Collections.Generic;
using System.Text;

namespace LiamRussell.Data.Models {
    public class SubSkill {
        public SubSkill(string name, string url) {
            Name = name;
            Url = url;
        }

        public string Name { get; set; }
        public string Url { get; set; }
    }
}
