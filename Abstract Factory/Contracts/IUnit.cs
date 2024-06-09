using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Contracts
{
    /// <summary>
    ///     Интерфейс абстрактного продукта
    /// </summary>
    internal interface IUnit
    {
        /// <summary>
        ///     Здоровье юнита
        /// </summary>
        int Health { get; set; }
        /// <summary>
        ///     Атака юнита
        /// </summary>
        int Atack { get; }
    }
}
