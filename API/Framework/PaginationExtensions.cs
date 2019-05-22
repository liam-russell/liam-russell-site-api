using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiamRussell.Api.Framework {
    public static class PaginationExtensions {
        public static IEnumerable<T> Paged<T>(this IEnumerable<T> items, int skip, int take) => items.Skip(skip).Take(take);
    }
}
