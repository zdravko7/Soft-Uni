namespace MassEffect.Engine.Commands
{
    using MassEffect.GameObjects.Ships;
    using MassEffect.Interfaces;
    using System;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {        
        }

        public new void Execute(string[] commandArgs)
        {
            StarshipType starshipType = (StarshipType) Enum.Parse(typeof(StarshipType), commandArgs[1]);
            string shipName = commandArgs[2];
            string starSystem = commandArgs[3];
            
            //GameEngine.ShipFactory.CreateShip(starshipType, shipName, starSystem);
            Console.WriteLine(GameEngine.Galaxy.StarSystems.Count);
            if (commandArgs.Length > 4)
            {
                for (int i = 4; i < commandArgs.Length; i++)
                {
                    
                }
            }


        }
    }
}
