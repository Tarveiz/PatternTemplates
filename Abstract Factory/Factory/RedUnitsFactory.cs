using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Contracts;
using Abstract_Factory.Service;

namespace Abstract_Factory.Factory
{
    /// <summary>
    ///     Конкретная фабрика красной команды
    /// </summary>
    internal class RedUnitsFactory : UnitsFactory
    {
        public override double SpawnPoint { get; } = 65.3842;

        public override string TeamCollor { get; } = "Красный";

        public override IMage CreateMage() => new RedMage();

        public override IRogue CreateRogue() => new RedRogue();

        public override IWarrior CreateWarrior() => new RedWarrior();
    }
}
