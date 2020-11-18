using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Svelto_ECS_Filters.Utilities {
    class IndexWrapper<T> : IComparer<IndexWrapper<T>> where T : struct, IComparer<T> {
        public T Item { get; }
        public int Index { get; }

        public IndexWrapper(T idexedItem, int index) {
            Item = idexedItem;
            Index = index;
        }

        public int Compare([AllowNull] IndexWrapper<T> x, [AllowNull] IndexWrapper<T> y) {
            return Item.Compare(x.Item, y.Item);
        }
    }
}
