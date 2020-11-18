using Svelto.ECS;
using Svelto_ECS_Filters.Engines;
using Svelto_ECS_Filters.GamePiece;
using System;

namespace Svelto_ECS_Filters {

    class MainFilterExample {
        
        static void Main(string[] args) {
            ExclusiveGroup combatGroup = new ExclusiveGroup();
            int filterID = 1;

            var entityScheduler = new SimpleEntitiesSubmissionScheduler();
            EnginesRoot enginesRoot = new EnginesRoot(entityScheduler);

            GamePiecePrinter printerEngine = new GamePiecePrinter();
            enginesRoot.AddEngine(printerEngine);

            GamePieceSorter gamePieceOrderer = new GamePieceSorter();
            enginesRoot.AddEngine(gamePieceOrderer);

            IEntityFactory entityFactory = enginesRoot.GenerateEntityFactory();

            EntityComponentInitializer componentInitializer = entityFactory.BuildEntity<GamePieceEntity>(new EGID(50, combatGroup));
            componentInitializer.Init<GamePieceComponent>(new GamePieceComponent(10));
            componentInitializer = entityFactory.BuildEntity<GamePieceEntity>(new EGID(51, combatGroup));
            componentInitializer.Init<GamePieceComponent>(new GamePieceComponent(20));
            componentInitializer = entityFactory.BuildEntity<GamePieceEntity>(new EGID(52, combatGroup));
            componentInitializer.Init<GamePieceComponent>(new GamePieceComponent(15));

            entityScheduler.SubmitEntities();

            Console.WriteLine("--== Unordered ==--");
            printerEngine.Update(combatGroup, filterID);

            GamePieceEntityMapper mapper = new GamePieceEntityMapper();
            gamePieceOrderer.Update(combatGroup, filterID, mapper);

            Console.WriteLine("--== Ordered ==--");
            printerEngine.Update(combatGroup, filterID);
        }
    }
}
