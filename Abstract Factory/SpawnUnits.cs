using Abstract_Factory.Contracts;
using Abstract_Factory.Factory;

namespace Abstract_Factory
{
    public class SpawnUnits
    {
        public string Play(string collorTeam, string choosenClass)
        {
            if (collorTeam == null)
                throw new ArgumentNullException(nameof(collorTeam));
            if (choosenClass == null)
                throw new ArgumentNullException(nameof(choosenClass));
            
            UnitsFactory factory = FactoryTeam(collorTeam);


            switch (choosenClass)
            {
                case "Warrior":
                    IWarrior warrior = factory.CreateWarrior();
                    return $"{factory.TeamCollor} {warrior.BladeAtack()}";
                case "Mage":
                    IMage mage = factory.CreateMage();
                    return $"{factory.TeamCollor} {mage.CastSpell()}";
                case "Rogue":
                    IRogue rogue = factory.CreateRogue();
                    return $"{factory.TeamCollor} {rogue.DaggerStab()}";
                default:
                    throw new ArgumentException($"Класса {choosenClass} не существует");
            }
        }

        private UnitsFactory FactoryTeam(string collorTeam)
        {
            switch (collorTeam)
            {
                case "Red":
                    return new RedUnitsFactory();
                case "Blue":
                    return new BlueUnitsFactory();
                default:
                    throw new ArgumentException($"Команды {collorTeam} не существует");
            }
        }

    }
}
