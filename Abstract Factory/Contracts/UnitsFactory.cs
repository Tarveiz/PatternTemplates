using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Contracts
{
    /// <summary>
    ///     Абстрактная фабрика юнитов
    /// </summary>
    internal abstract class UnitsFactory
    {
        /// <summary>
        ///      Условные координаты точки спавна юнитов
        /// </summary>
        public abstract double SpawnPoint { get; }

        /// <summary>
        ///     Цвет команды
        /// </summary>
        public abstract string TeamCollor { get; }

        /// <summary>
        ///     Создать абстрактный продукт маг
        /// </summary>
        public abstract IMage CreateMage();

        /// <summary>
        ///     Создать абстрактный продукт воин
        /// </summary>
        public abstract IWarrior CreateWarrior();

        /// <summary>
        ///     Создать абстрактный продукт разбойник
        /// </summary>
        public abstract IRogue CreateRogue();

    }
}
