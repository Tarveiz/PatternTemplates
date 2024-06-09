using Abstract_Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Service
{
    internal class BlueRogue : IRogue
    {
        private int _health = 5;

        public int Health { get => _health; set => _health = value; }
        public int Atack => 7;


        public string DaggerStab() => $"разбойник бьет кинжалом на {Atack} урона. Его здоровье - {Health}";
    }
}
