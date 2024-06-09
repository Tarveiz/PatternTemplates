using Abstract_Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Service
{
    internal class BlueMage : IMage
    {
        private int _health = 3;

        public int Health { get => _health; set => _health = value; }
        public int Atack => 9;


        public string CastSpell() => $"маг делает вж-вж-вж! на {Atack} урона. Его здоровье - {Health}";
    }
}
