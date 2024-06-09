using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Contracts
{
    /// <summary>
    ///     Абстракция юнита разбойника
    /// </summary>
    internal interface IRogue : IUnit
    {
        /// <summary>
        ///     Ударить кинжалом разбойника
        /// </summary>
        string DaggerStab();
    }
}
