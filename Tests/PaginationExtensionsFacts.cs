using LiamRussell.Api.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LiamRussell.Tests {
    public class PaginationExtensionsFacts {
        private readonly IEnumerable<int> testData = new int[50].Select((_, index) => index);
        [InlineData(0, 5)]
        [InlineData(50, 5)]
        [InlineData(5, 5)]
        [InlineData(3, 7)]
        [InlineData(7, 5)]
        [Theory]
        public void Paged_Works(int skip, int take) {
            var min = 0 + skip;
            var max = min + take;
            var page = testData.Paged(skip, take);
            Assert.All(page.Items, item => {
                Assert.InRange(item, min, max);
            });
        }

        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(-5, -5)]
        [Theory]
        public void Paged_Throws_Negative(int skip, int take) {
            Assert.Throws<ArgumentOutOfRangeException>(() => testData.Paged(skip, take));
        }

        [Fact]
        public void Paged_Throws_Null() {
            Assert.Throws<ArgumentNullException>(() => default(int[]).Paged(5, 5));
        }
    }
}
