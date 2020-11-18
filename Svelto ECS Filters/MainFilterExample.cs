using Svelto.ECS;
using Svelto_ECS_Filters.Engines;
using Svelto_ECS_Filters.GamePiece;
using System;

namespace Svelto_ECS_Filters {


    class MainFilterExample {
        static uint id;

        static uint NewEntityID() {
            return id++;
        }
        
        static void CreateEntityWithComponent<T>(IEntityFactory entityFactory, T component, ExclusiveGroup group) where T : struct, IEntityComponent {
            EntityComponentInitializer componentInitializer = entityFactory.BuildEntity<GamePieceEntity>(new EGID(NewEntityID(), group));
            componentInitializer.Init<T>(component);
        }

        static void CreateRandomEntities(IEntityFactory entityFactory, int quantity, ExclusiveGroup group) {
            var rand = new Random();
            for (int i=0; i<quantity; i++) {
                CreateEntityWithComponent(entityFactory, new GamePieceComponent(rand.Next(1,500)), group);
            }
        }

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

            CreateRandomEntities(entityFactory, 50, combatGroup);

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
