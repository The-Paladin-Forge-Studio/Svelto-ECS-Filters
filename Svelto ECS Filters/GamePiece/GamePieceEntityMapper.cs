using Svelto.ECS;
using System;
using System.Collections.Generic;

namespace Svelto_ECS_Filters.GamePiece {
    class GamePieceEntityMapper : IEGIDMapper {
        public ExclusiveGroupStruct groupID { get; set; }
        public Type entityType { get; set; }

        public Dictionary<uint, uint> indexMap { get; set; }

        public GamePieceEntityMapper() {

            entityType = typeof(GamePieceEntity);
        }

        public bool Exists(uint entityID) {
            uint index;
            return indexMap.TryGetValue(entityID, out index);
        }

        public bool FindIndex(uint entityID, out uint index) {
            return indexMap.TryGetValue(entityID, out index);
        }

        public uint GetIndex(uint entityID) {
            return indexMap[entityID];
        }
    }
}
