using System.Collections.Generic;
using System.Linq;

namespace LiamRussell.Api.Framework {
    public static class PaginationExtensions {
        public static IEnumerable<T> Paged<T>(this IEnumerable<T> items, int skip, int take) {
            if(items == null) {
                throw new ArgumentNullException(nameof(items), $"'{nameof(items)}' cannot be null.");
            }

            if(skip < 0) {
                throw new ArgumentOutOfRangeException(nameof(skip), $"'{nameof(skip)}' cannot be less than zero.");
            }

            if(take < 0) {
                throw new ArgumentOutOfRangeException(nameof(take), $"'{nameof(take)}' cannot be less than zero.");
            }

            return items.Skip(skip).Take(take);
        }
    }
}
