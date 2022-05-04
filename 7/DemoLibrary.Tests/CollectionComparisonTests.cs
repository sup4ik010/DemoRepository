using System;
using System.Collections.Generic;
using UnitTests;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CollectionComparisonTests
    {   
        [Fact]
        public void AreTwoCollectionsEqual_ComparisonShouldWork()
        {
            var expected = true;

            var firstCollection = new List<string>();
            var secondCollection = new List<string>();
            var actual = CollectionComparison.AreTwoCollectionsEqual(firstCollection, secondCollection);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AreTwoCollectionsEqual_ComparisonShouldFail()
        {
            var expected = false;

            var firstCollection = new List<string>();
            var secondCollection = new List<string>() { "1", "2"};

            var actual = CollectionComparison.AreTwoCollectionsEqual(firstCollection, secondCollection);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsCollectionNull_ShouldWork()
        {
            var expected = false;

            var actual = CollectionComparison.IsColectionNull(new List<string>());

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsCollectionNull_ShouldFail()
        {
            Assert.Throws<ArgumentNullException>(() => CollectionComparison.IsColectionNull(null));
        }
    }
}
