using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    public static class CollectionComparison
    {
        #region Methods

        public static bool AreTwoCollectionsEqual(List<string> firstCollection, List<string> secondCollection)
        {
            IsColectionNull(firstCollection);
            IsColectionNull(secondCollection);

            return firstCollection.SequenceEqual(secondCollection);
        }

        public static bool IsColectionNull(List<string> collection)
        {
            if (collection is null)
            {
                throw new ArgumentNullException("Коллекция не может быть null.", nameof(collection));
            }

            return false;
        }

        #endregion
    }
}
