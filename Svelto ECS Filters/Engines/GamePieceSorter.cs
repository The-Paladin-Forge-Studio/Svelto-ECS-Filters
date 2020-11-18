using Svelto.ECS;
using Svelto_ECS_Filters.ClassExtensions;
using Svelto_ECS_Filters.GamePiece;
using Svelto_ECS_Filters.Utilities;
using System;
using System.Collections.Generic;

namespace Svelto_ECS_Filters.Engines {
    class GamePieceSorter : IQueryingEntitiesEngine {
        public EntitiesDB entitiesDB { get; set; }

        public void Ready() {

        }

        public void Update(ExclusiveGroup group, int filterID, GamePieceEntityMapper mapper) {
            var (buffer, count) = entitiesDB.QueryEntities<GamePieceComponent>(group);

            List<IndexWrapper<GamePieceComponent>> ordered = new List<IndexWrapper<GamePieceComponent>>();

            foreach (IndexWrapper<GamePieceComponent> gamePieceWrapper in new EnumerateBuffer<GamePieceComponent>(buffer, count)) {
                ordered.BinaryInsert(gamePieceWrapper);
            }

            Dictionary<uint, uint> entityIDtoIndex = new Dictionary<uint, uint>();
            //entityIDtoIndex[50] = 1;// 50 is index 0
            //entityIDtoIndex[51] = 2;// 51 is index 1
            //entityIDtoIndex[52] = 0;// 52 is index 2


            for (int idx = 0; idx < count; idx++) {
                entityIDtoIndex.Add(buffer[idx].ID.entityID, (uint)ordered[idx].Index);
            }

            mapper.indexMap = entityIDtoIndex;

            var filterGroup = entitiesDB.GetFilters().CreateOrGetFilterForGroup<GamePieceComponent>(filterID, group);
            foreach (IndexWrapper<GamePieceComponent> gamePieceWrapper in new EnumerateBuffer<GamePieceComponent>(buffer, count)) {
                filterGroup.Add(gamePieceWrapper.Item.ID.entityID, mapper);
            }
        }
    }
}
