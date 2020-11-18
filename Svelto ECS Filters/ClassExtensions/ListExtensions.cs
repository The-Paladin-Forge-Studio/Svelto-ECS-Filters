using System.Collections.Generic;

namespace Svelto_ECS_Filters.ClassExtensions {
    public static class ListExtensions {
        public static void BinaryInsert<T>(this List<T> itemList, T item) where T : IComparer<T> {
            var pos = itemList.BinarySearch(item, item);
            pos = pos < 0 ? ~pos : pos;
            itemList.Insert(pos, item);
        }
    }
}
