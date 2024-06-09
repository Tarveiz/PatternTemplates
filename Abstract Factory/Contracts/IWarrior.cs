using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Contracts
{
    /// <summary>
    ///     Абстракция юнита война
    /// </summary>
    internal interface IWarrior : IUnit
    {
        /// <summary>
        ///     Нанести атаку мечом война
        /// </summary>
        string BladeAtack();
    }
}
