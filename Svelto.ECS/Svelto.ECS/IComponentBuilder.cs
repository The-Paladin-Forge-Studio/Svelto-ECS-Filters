using Svelto.ECS.Internal;
using System;
using System.Collections.Generic;

namespace Svelto.ECS {
    public interface IComponentBuilder
    {
        void BuildEntityAndAddToList(ref ITypeSafeDictionary dictionary, EGID egid,
            IEnumerable<object> implementors);
        ITypeSafeDictionary Preallocate(ref ITypeSafeDictionary dictionary, uint size);

        Type GetEntityComponentType();
    }
}