using Abstract_Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Service
{
    internal class BlueWarrior : IWarrior
    {
        private int _health = 7;

        public int Health { get => _health; set => _health = value; }
        public int Atack => 5;

        public string BladeAtack() => $"воин ударяет мечом на {Atack} урона. Его здоровье - {Health}";
    }
}
