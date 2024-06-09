using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Contracts
{
    /// <summary>
    ///     Абстракция юнита мага
    /// </summary>
    internal interface IMage : IUnit
    {
        /// <summary>
        ///     Использовать заклинание мага
        /// </summary>
        string CastSpell();
    }
}
