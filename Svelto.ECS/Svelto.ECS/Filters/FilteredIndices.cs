﻿using Svelto.ECS.DataStructures;
using System.Runtime.CompilerServices;

namespace Svelto.ECS {
    public readonly struct FilteredIndices
    {
        public FilteredIndices(NativeDynamicArrayCast<uint> denseListOfIndicesToEntityComponentArray)
        {
            _denseListOfIndicesToEntityComponentArray = denseListOfIndicesToEntityComponentArray;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count() => _denseListOfIndicesToEntityComponentArray.Count();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Get(uint index) => _denseListOfIndicesToEntityComponentArray[index];

        readonly NativeDynamicArrayCast<uint> _denseListOfIndicesToEntityComponentArray;
    }
}