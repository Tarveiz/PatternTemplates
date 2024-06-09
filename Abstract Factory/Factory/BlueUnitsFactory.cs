using Abstract_Factory.Contracts;
using Abstract_Factory.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factory
{
    /// <summary>
    ///     Конкретная фабрика синей команды
    /// </summary>
    internal class BlueUnitsFactory : UnitsFactory
    {
        public override double SpawnPoint { get; } = 91.0541;

        public override string TeamCollor { get; } = "Синий";

        public override IMage CreateMage() => new BlueMage();

        public override IRogue CreateRogue() => new BlueRogue();

        public override IWarrior CreateWarrior() => new BlueWarrior();
    }
}
