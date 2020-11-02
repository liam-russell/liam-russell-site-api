using System.Collections.Generic;
using System.Linq;

namespace LiamRussell.Api.Framework {
    public static class PaginationExtensions {
        public static IEnumerable<T> Paged<T>(this IEnumerable<T> items, int skip, int take)
            => items.Skip(skip).Take(take);
    }
}
