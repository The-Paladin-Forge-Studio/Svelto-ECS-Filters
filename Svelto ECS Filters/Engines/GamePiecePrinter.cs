using Svelto.ECS;
using Svelto_ECS_Filters.GamePiece;
using Svelto_ECS_Filters.Utilities;
using System;

namespace Svelto_ECS_Filters.Engines {
    class GamePiecePrinter : IQueryingEntitiesEngine {
        public EntitiesDB entitiesDB { get; set; }

        public void Ready() {

        }

        public void Update(ExclusiveGroup group, int filterID) {
            var (buffer, count) = entitiesDB.QueryEntities<GamePieceComponent>(group);

            GroupFilters filters;
            if (entitiesDB.GetFilters().TryGetFiltersForGroup<GamePieceComponent>(group, out filters) && filters.HasFilter(filterID)) {
                FilterGroup filterGroup = filters.GetFilter(filterID);

                foreach (IndexWrapper<GamePieceComponent> gamePieceWrapper in new EnumerateBuffer<GamePieceComponent>(buffer, count)) {
                    GamePieceComponent gamePiece = buffer[filterGroup.filteredIndices.Get((uint)gamePieceWrapper.Index)];
                    Console.WriteLine(gamePiece.ToString());
                }

            } else {

                foreach (IndexWrapper<GamePieceComponent> gamePieceWrapper in new EnumerateBuffer<GamePieceComponent>(buffer, count)) {
                    Console.WriteLine(gamePieceWrapper.Item.ToString());
                }
            }
        }
    }
}
