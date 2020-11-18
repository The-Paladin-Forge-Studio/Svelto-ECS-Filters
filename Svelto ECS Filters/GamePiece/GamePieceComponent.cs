using Svelto.ECS;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Svelto_ECS_Filters.GamePiece {
    struct GamePieceComponent : IEntityComponent, INeedEGID, IComparer<GamePieceComponent> {
        public int CombatOrder { get; }
        public EGID ID { get; set; }

        public GamePieceComponent(int combatOrder) {
            CombatOrder = combatOrder;
            ID = EGID.Empty;
        }

        public int Compare([AllowNull] GamePieceComponent x, [AllowNull] GamePieceComponent y) {
            if (x.CombatOrder > y.CombatOrder) {
                return -1;
            }

            if (x.CombatOrder < y.CombatOrder) {
                return 1;
            }
            return 0;
        }

        public override string ToString() {
            return String.Format("{0} : {{ CombatOrder : {1}}}", typeof(GamePieceComponent).ToString(), CombatOrder);
        }
    }
}
