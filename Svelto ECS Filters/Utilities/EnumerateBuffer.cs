using Svelto.DataStructures;
using System.Collections;
using System.Collections.Generic;

namespace Svelto_ECS_Filters.Utilities {
    class EnumerateBuffer<T> : IEnumerable where T : struct, IComparer<T> {
        private NB<T> buffer;
        private int count;

        public EnumerateBuffer(NB<T> buffer, int count) {
            this.buffer = buffer;
            this.count = count;
        }

        public IEnumerator GetEnumerator() {
            uint index = 0;
            while (index < count) {
                yield return new IndexWrapper<T>(buffer[index], (int)index++);
            }
        }
    }
}
