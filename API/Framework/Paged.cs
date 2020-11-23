using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiamRussell.Api.Framework {
    public class Paged<T> {
        public int Total { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
        public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
    }
}
